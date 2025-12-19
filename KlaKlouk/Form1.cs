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
    public partial class Form1 : Form
    {
        FormResizer resizer = new FormResizer();

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
    }
}
