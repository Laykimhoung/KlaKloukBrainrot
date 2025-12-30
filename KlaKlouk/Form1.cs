using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlaKlouk
{
    enum KlaKloukFaces
    {
        BrrBrrPatapim,
        TungTungTungSahur,
        BombardiroCrocodilo,
        ChimpanziniBananini,
        CappuccinoAssassino,
        TralaleroTralala
    }

    public partial class Form1 : Form
    {
        FormResizer resizer = new FormResizer();
        KlaKloukFaces selectedFace;
        Random rnd = new Random();
        KlaKloukFaces[] dice = new KlaKloukFaces[3];       
        Image GetImage(KlaKloukFaces s)
        {
            switch (s)
            {
                case KlaKloukFaces.BrrBrrPatapim: return Properties.Resources.BrrBrrPatapim;
                case KlaKloukFaces.TungTungTungSahur: return Properties.Resources.TungTungTungSahur;
                case KlaKloukFaces.BombardiroCrocodilo: return Properties.Resources.BombardiroCrocodilo;
                case KlaKloukFaces.ChimpanziniBananini: return Properties.Resources.ChimpanziniBananini;
                case KlaKloukFaces.CappuccinoAssassino: return Properties.Resources.CappuccinoAssassino;
                case KlaKloukFaces.TralaleroTralala: return Properties.Resources.TralaleroTralala;
            }
            return null;
        }
        void RollDice()
        {
            for (int i = 0; i < 3; i++)
            {
                dice[i] = (KlaKloukFaces)rnd.Next(0, 6);
            }
        }

        void ShowDice()
        {
            picDice1.Image = GetImage(dice[0]);
            picDice2.Image = GetImage(dice[1]);
            picDice3.Image = GetImage(dice[2]);
        }
        public Form1()
        {
            InitializeComponent();           
            resizer.Capture(this);
            resizer.IgnoreControls.Add(coverPlate);
            this.Resize += (s, e) => resizer.Resize(this);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            resizer.Resize(this);
            resizer.UpdateCoverLayout(plate, coverPlate);
            coverPlate.Top = resizer.GetCoverTop(isCovering);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbWelcome.Parent = backGround;
            lbWelcome.BackColor = Color.Transparent;

            lbUserName.Parent = backGround;
            lbUserName.BackColor = Color.Transparent;

            lbTotal.Parent = backGround;
            lbTotal.BackColor = Color.Transparent;

            lbLastRoll.Parent = backGround;
            lbLastRoll.BackColor = Color.Transparent;

            coverPlate.Parent = backGround;
            coverPlate.BackColor = Color.Transparent;

            plate.Parent = backGround;
            plate.BackColor = Color.Transparent;
            
            resizer.UpdateCoverLayout(plate, coverPlate);
            coverPlate.Top = resizer.GetCoverTop(isCovering);
        }
        
        private void picBrrBrrPatapim_Click(object sender, EventArgs e)
        {
            selectedFace = KlaKloukFaces.BrrBrrPatapim;
        }

        private void picTungTungTungSahur_Click(object sender, EventArgs e)
        {
            selectedFace = KlaKloukFaces.TungTungTungSahur;
        }

        private void picBombardiroCrocodilo_Click(object sender, EventArgs e)
        {
            selectedFace = KlaKloukFaces.BombardiroCrocodilo;
        }

        private void picChimpanziniBananini_Click(object sender, EventArgs e)
        {
            selectedFace = KlaKloukFaces.ChimpanziniBananini;
        }

        private void picCappuccinoAssassino_Click(object sender, EventArgs e)
        {
            selectedFace = KlaKloukFaces.CappuccinoAssassino;
        }

        private void picTralaleroTralala_Click(object sender, EventArgs e)
        {
            selectedFace = KlaKloukFaces.TralaleroTralala;
        }
        bool isRolling = false;
        private void btnRoll_Click(object sender, EventArgs e)
        {           
            if (!isRolling)
            {
                diceTimer.Start();
                btnRoll.Text = "ឈប់បង្វិល";
                btnRoll.BackColor = Color.Red;
                isRolling = true;
            }
            else
            {
                diceTimer.Stop();
                btnRoll.Text = "បង្វិលគ្រាប់";
                btnRoll.BackColor = Color.Lime;
                isRolling = false;
            }
        }
        private void diceTimer_Tick(object sender, EventArgs e)
        {
            RollDice();
            ShowDice();
        }

        bool isCovering = false;

        private void btnRotate_Click(object sender, EventArgs e)
        {
            coverPlate.BringToFront(); 
          
            if (!isCovering)
            {
                btnRotate.Text = "បើកគម្រប";
                btnRotate.BackColor = Color.Lime;
                picDice1.Visible = false;
                picDice2.Visible = false;
                picDice3.Visible = false;
            }
            else
            {
                btnRotate.Text = "បិទគម្រប";
                btnRotate.BackColor = Color.Red;
            }

            rotateTimer.Start();
        }

        private void rotateTimer_Tick(object sender, EventArgs e)
        {
            int speed = 12;

            if (!isCovering)
            {
                coverPlate.Top += speed;

                if (coverPlate.Top >= resizer.TargetCoverY)
                {
                    coverPlate.Top = resizer.TargetCoverY;
                    rotateTimer.Stop();
                    isCovering = true;
                }
            }
            else
            {
                coverPlate.Top -= speed;

                if (coverPlate.Top <= resizer.OriginalCoverY)
                {
                    coverPlate.Top = resizer.OriginalCoverY;
                    rotateTimer.Stop();
                    isCovering = false;

                    // Show dice again when golden goes back
                    picDice1.Visible = true;
                    picDice2.Visible = true;
                    picDice3.Visible = true;
                }
            }
        }       
    }
}
