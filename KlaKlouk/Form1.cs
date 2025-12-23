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

        public Form1()
        {
            InitializeComponent();           
            resizer.Capture(this);
            this.Resize += (s, e) => resizer.Resize(this);
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

        private void btnRoll_Click(object sender, EventArgs e)
        {
            
        }
    }
}
