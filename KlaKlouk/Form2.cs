using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace KlaKlouk
{
    public partial class Form2 : Form
    {
        private SoundPlayer player;
        public Form2()
        {
            InitializeComponent();           
            player = new SoundPlayer(@"Sounds\Brainrot_song.wav");
            player.PlayLooping();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.Stop();
            }
            Form1 form1 = new Form1(txtInputName.Text);
            form1.Show();
        }

    }
}
