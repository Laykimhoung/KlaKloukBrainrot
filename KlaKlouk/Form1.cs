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

        public Form1(string name)
        {          
            InitializeComponent();
            this.Text = "KlaKlouk Brainrot";
            lbUserName.Text = name;
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
            resizer.UpdateCoverLayout(plate, coverPlate);
            coverPlate.Top = resizer.GetCoverTop(isCovering);

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
           
            foreach (KlaKloukFaces face in Enum.GetValues(typeof(KlaKloukFaces)))
            {
                bets[face] = 0;
            }
        }
        
        private void picBrrBrrPatapim_Click(object sender, EventArgs e)
        {
            selectedFace = KlaKloukFaces.BrrBrrPatapim;
            PlaceBet(selectedFace);
        }

        private void picTungTungTungSahur_Click(object sender, EventArgs e)
        {
            selectedFace = KlaKloukFaces.TungTungTungSahur;
            PlaceBet(selectedFace);
        }

        private void picBombardiroCrocodilo_Click(object sender, EventArgs e)
        {
            selectedFace = KlaKloukFaces.BombardiroCrocodilo;
            PlaceBet(selectedFace);
        }

        private void picChimpanziniBananini_Click(object sender, EventArgs e)
        {
            selectedFace = KlaKloukFaces.ChimpanziniBananini;
            PlaceBet(selectedFace);
        }

        private void picCappuccinoAssassino_Click(object sender, EventArgs e)
        {
            selectedFace = KlaKloukFaces.CappuccinoAssassino;
            PlaceBet(selectedFace);
        }

        private void picTralaleroTralala_Click(object sender, EventArgs e)
        {
            selectedFace = KlaKloukFaces.TralaleroTralala;
            PlaceBet(selectedFace);
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
        
        private void btnCover_Click(object sender, EventArgs e)
        {
            coverPlate.BringToFront(); 
          
            if (!isCovering)
            {
                btnCover.Text = "បើកគម្រប";
                btnCover.BackColor = Color.Lime;
                picDice1.Visible = false;
                picDice2.Visible = false;
                picDice3.Visible = false;
            }
            else
            {
                btnCover.Text = "បិទគម្រប";
                btnCover.BackColor = Color.Red;
            }

            coverTimer.Start();
        }

        bool isCovering = false;
        private void coverTimer_Tick(object sender, EventArgs e)
        {
            int speed = 12;

            if (!isCovering)
            {
                // COVER DOWN
                coverPlate.Top += speed;

                if (coverPlate.Top >= resizer.TargetCoverY)
                {
                    coverPlate.Top = resizer.TargetCoverY;
                    coverTimer.Stop();
                    isCovering = true;
                   
                    if (startRollingAfterCover)
                    {
                        diceTimer.Start();
                        startRollingAfterCover = false;                        
                    }
                }
            }
            else
            {
                // COVER UP
                coverPlate.Top -= speed;

                if (coverPlate.Top <= resizer.OriginalCoverY)
                {
                    coverPlate.Top = resizer.OriginalCoverY;
                    coverTimer.Stop();
                    isCovering = false;

                    // Show dice again
                    picDice1.Visible = true;
                    picDice2.Visible = true;
                    picDice3.Visible = true;

                    if (isShowingResult)
                    {
                        ShowDice();
                        CalculatePayout();
                    }
                }
            }
        }

        int balance = 200; 
        int selectedBetAmount = 0;
        bool isBetting = false;
        Dictionary<KlaKloukFaces, int> bets = new Dictionary<KlaKloukFaces, int>();

        private void btnCashIn_Click(object sender, EventArgs e)
        {
            isBetting = true;
            selectedBetAmount = 0;
            MessageBox.Show("Choose money, then click a face to bet.");
        }

        private void picMoney1_Click(object sender, EventArgs e)
        {
            if (!isBetting) return;
            selectedBetAmount = 1;
        }

        private void picMoney5_Click(object sender, EventArgs e)
        {
            if (!isBetting) return;
            selectedBetAmount = 5;
        }

        private void picMoney10_Click(object sender, EventArgs e)
        {
            if (!isBetting) return;
            selectedBetAmount = 10;
        }

        private void picMoney20_Click(object sender, EventArgs e)
        {
            if (!isBetting) return;
            selectedBetAmount = 20;
        }

        private void picMoney50_Click(object sender, EventArgs e)
        {
            if (!isBetting) return;
            selectedBetAmount = 50;
        }

        private void picMoney100_Click(object sender, EventArgs e)
        {
            if (!isBetting) return;
            selectedBetAmount = 100;
        }
        void PlaceBet(KlaKloukFaces face)
        {
            if (!isBetting) return;
            if (selectedBetAmount <= 0) return;

            if (balance < selectedBetAmount)
            {
                MessageBox.Show("Not enough money!");
                return;
            }

            balance -= selectedBetAmount;
            bets[face] += selectedBetAmount;

            UpdateBetLabels();
            lbTotal.Text = "Balance: $" + balance;
        }
        void UpdateBetLabels()
        {
            lbBetBrr.Text = "$" + bets[KlaKloukFaces.BrrBrrPatapim];
            lbBetTung.Text = "$" + bets[KlaKloukFaces.TungTungTungSahur];
            lbBetBomb.Text = "$" + bets[KlaKloukFaces.BombardiroCrocodilo];
            lbBetChimp.Text = "$" + bets[KlaKloukFaces.ChimpanziniBananini];
            lbBetCap.Text = "$" + bets[KlaKloukFaces.CappuccinoAssassino];
            lbBetTral.Text = "$" + bets[KlaKloukFaces.TralaleroTralala];
        }
        private void btnCashOut_Click(object sender, EventArgs e)
        {
            foreach (var face in bets.Keys.ToList())
            {
                balance += bets[face];
                bets[face] = 0;
            }

            selectedBetAmount = 0;
            isBetting = false;

            UpdateBetLabels();
            lbTotal.Text = "Balance: $" + balance;
        }

        bool isResultMode = false;   // controls blue button state
        bool isShowingResult = false;
        bool startRollingAfterCover = false;

        private void btnResult_Click(object sender, EventArgs e)
        {
            // FIRST CLICK → COVER + ROLL
            if (!isResultMode)
            {
                // Lock betting
                isBetting = false;
                startRollingAfterCover = true;

                picDice1.Visible = false;
                picDice2.Visible = false;
                picDice3.Visible = false;

                // Cover the plate + dice
                coverPlate.BringToFront();
                coverTimer.Start();

                btnResult.Text = "បង្ហាញលទ្ធផល";
                btnResult.BackColor = Color.Red;

                isResultMode = true;
                isShowingResult = false;
            }
            // SECOND CLICK → SHOW RESULT + PAYOUT
            else
            {
                diceTimer.Stop();          // stop dice rolling
                coverTimer.Start();        // uncover

                btnResult.Text = "លទ្ធផល";
                btnResult.BackColor = Color.Blue;

                isResultMode = false;
                isShowingResult = true;
            }
        }
        void CalculatePayout()
        {
            Dictionary<KlaKloukFaces, int> counts = new Dictionary<KlaKloukFaces, int>();

            foreach (KlaKloukFaces face in Enum.GetValues(typeof(KlaKloukFaces)))
                counts[face] = 0;

            foreach (var d in dice)
                counts[d]++;

            foreach (var face in bets.Keys.ToList())
            {
                int bet = bets[face];
                int times = counts[face];

                if (bet > 0 && times > 0)
                {
                    // payout = bet × (times + orginal bet)
                    balance += bets[face] * (times + 1);
                }

                bets[face] = 0;
            }

            UpdateBetLabels();
            lbTotal.Text = "Balance: $" + balance;
        }
    }
}
