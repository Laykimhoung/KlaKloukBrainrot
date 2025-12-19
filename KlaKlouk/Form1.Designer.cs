namespace KlaKlouk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.borderBoard = new System.Windows.Forms.Panel();
            this.board = new System.Windows.Forms.Panel();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.plate = new System.Windows.Forms.PictureBox();
            this.CasinoMan = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backGround = new System.Windows.Forms.PictureBox();
            this.coverPlate = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlate = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnCashIn = new System.Windows.Forms.Button();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbLastRoll = new System.Windows.Forms.Label();
            this.borderBoard.SuspendLayout();
            this.board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasinoMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // borderBoard
            // 
            this.borderBoard.BackColor = System.Drawing.Color.Gold;
            this.borderBoard.Controls.Add(this.board);
            this.borderBoard.Location = new System.Drawing.Point(227, 59);
            this.borderBoard.Name = "borderBoard";
            this.borderBoard.Padding = new System.Windows.Forms.Padding(3);
            this.borderBoard.Size = new System.Drawing.Size(556, 262);
            this.borderBoard.TabIndex = 1;
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(44)))));
            this.board.Controls.Add(this.label3);
            this.board.Controls.Add(this.label2);
            this.board.Controls.Add(this.label1);
            this.board.Controls.Add(this.CasinoMan);
            this.board.Controls.Add(this.pictureBox6);
            this.board.Controls.Add(this.pictureBox5);
            this.board.Controls.Add(this.pictureBox4);
            this.board.Controls.Add(this.pictureBox3);
            this.board.Controls.Add(this.pictureBox2);
            this.board.Controls.Add(this.pictureBox1);
            this.board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.board.Location = new System.Drawing.Point(3, 3);
            this.board.Name = "board";
            this.board.Padding = new System.Windows.Forms.Padding(5);
            this.board.Size = new System.Drawing.Size(550, 256);
            this.board.TabIndex = 0;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.Color.Black;
            this.lbWelcome.Font = new System.Drawing.Font("Khmer OS Muol Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.White;
            this.lbWelcome.Location = new System.Drawing.Point(211, 20);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(591, 36);
            this.lbWelcome.TabIndex = 2;
            this.lbWelcome.Text = "សូមស្វាគមន៍មកកាន់ហ្គេមខ្លាឃ្លោក Gen Z Version (Brainrot)";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.Yellow;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoll.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.ForeColor = System.Drawing.Color.Black;
            this.btnRoll.Location = new System.Drawing.Point(460, 429);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(97, 36);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "បង្វិលគ្រាប់";
            this.btnRoll.UseVisualStyleBackColor = false;
            // 
            // plate
            // 
            this.plate.Image = global::KlaKlouk.Properties.Resources.platee;
            this.plate.Location = new System.Drawing.Point(820, 215);
            this.plate.Name = "plate";
            this.plate.Size = new System.Drawing.Size(143, 145);
            this.plate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plate.TabIndex = 6;
            this.plate.TabStop = false;
            // 
            // CasinoMan
            // 
            this.CasinoMan.Image = global::KlaKlouk.Properties.Resources.Gemini_Generated_Image_vgadrpvgadrpvgad_removebg_preview;
            this.CasinoMan.Location = new System.Drawing.Point(386, 93);
            this.CasinoMan.Name = "CasinoMan";
            this.CasinoMan.Size = new System.Drawing.Size(160, 166);
            this.CasinoMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CasinoMan.TabIndex = 6;
            this.CasinoMan.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::KlaKlouk.Properties.Resources._4;
            this.pictureBox6.Location = new System.Drawing.Point(260, 132);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(120, 120);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::KlaKlouk.Properties.Resources._5;
            this.pictureBox5.Location = new System.Drawing.Point(260, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(120, 120);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KlaKlouk.Properties.Resources._7;
            this.pictureBox4.Location = new System.Drawing.Point(134, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 120);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KlaKlouk.Properties.Resources._3;
            this.pictureBox3.Location = new System.Drawing.Point(134, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KlaKlouk.Properties.Resources._6;
            this.pictureBox2.Location = new System.Drawing.Point(8, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KlaKlouk.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backGround
            // 
            this.backGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backGround.Image = global::KlaKlouk.Properties.Resources.Gaming0_generated;
            this.backGround.Location = new System.Drawing.Point(0, 0);
            this.backGround.Name = "backGround";
            this.backGround.Size = new System.Drawing.Size(1006, 529);
            this.backGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backGround.TabIndex = 0;
            this.backGround.TabStop = false;
            // 
            // coverPlate
            // 
            this.coverPlate.Image = global::KlaKlouk.Properties.Resources.Cover;
            this.coverPlate.Location = new System.Drawing.Point(820, 74);
            this.coverPlate.Name = "coverPlate";
            this.coverPlate.Size = new System.Drawing.Size(143, 135);
            this.coverPlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPlate.TabIndex = 7;
            this.coverPlate.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Muol Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(426, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "ចាក់ហើយដកដៃ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Muol Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(382, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "ចាក់ហើយដកដៃ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Muol Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(413, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "ចាក់ហើយដកដៃ";
            // 
            // btnPlate
            // 
            this.btnPlate.BackColor = System.Drawing.Color.Red;
            this.btnPlate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlate.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlate.ForeColor = System.Drawing.Color.White;
            this.btnPlate.Location = new System.Drawing.Point(364, 467);
            this.btnPlate.Name = "btnPlate";
            this.btnPlate.Size = new System.Drawing.Size(92, 36);
            this.btnPlate.TabIndex = 8;
            this.btnPlate.Text = "បិទគម្រប";
            this.btnPlate.UseVisualStyleBackColor = false;
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Blue;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResult.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.Location = new System.Drawing.Point(563, 467);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(97, 36);
            this.btnResult.TabIndex = 9;
            this.btnResult.Text = "លទ្ធផល";
            this.btnResult.UseVisualStyleBackColor = false;
            // 
            // btnCashIn
            // 
            this.btnCashIn.BackColor = System.Drawing.Color.Lime;
            this.btnCashIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCashIn.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashIn.ForeColor = System.Drawing.Color.Black;
            this.btnCashIn.Location = new System.Drawing.Point(12, 386);
            this.btnCashIn.Name = "btnCashIn";
            this.btnCashIn.Size = new System.Drawing.Size(103, 37);
            this.btnCashIn.TabIndex = 10;
            this.btnCashIn.Text = "ដាក់លុយ";
            this.btnCashIn.UseVisualStyleBackColor = false;
            // 
            // btnCashOut
            // 
            this.btnCashOut.BackColor = System.Drawing.Color.Red;
            this.btnCashOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCashOut.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashOut.ForeColor = System.Drawing.Color.Black;
            this.btnCashOut.Location = new System.Drawing.Point(12, 429);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(103, 36);
            this.btnCashOut.TabIndex = 11;
            this.btnCashOut.Text = "ដកលុយ";
            this.btnCashOut.UseVisualStyleBackColor = false;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Black;
            this.lbUserName.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(6, 20);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(110, 36);
            this.lbUserName.TabIndex = 12;
            this.lbUserName.Text = "UserName";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Black;
            this.lbTotal.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(857, 23);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(116, 33);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "ទឹកប្រាក់សរុប:";
            // 
            // lbLastRoll
            // 
            this.lbLastRoll.AutoSize = true;
            this.lbLastRoll.BackColor = System.Drawing.Color.Black;
            this.lbLastRoll.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastRoll.ForeColor = System.Drawing.Color.White;
            this.lbLastRoll.Location = new System.Drawing.Point(683, 507);
            this.lbLastRoll.Name = "lbLastRoll";
            this.lbLastRoll.Size = new System.Drawing.Size(128, 33);
            this.lbLastRoll.TabIndex = 14;
            this.lbLastRoll.Text = "គ្រាប់ចុងក្រោយ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.lbLastRoll);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btnCashOut);
            this.Controls.Add(this.btnCashIn);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnPlate);
            this.Controls.Add(this.coverPlate);
            this.Controls.Add(this.plate);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.borderBoard);
            this.Controls.Add(this.backGround);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.borderBoard.ResumeLayout(false);
            this.board.ResumeLayout(false);
            this.board.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasinoMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPlate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backGround;
        private System.Windows.Forms.Panel borderBoard;
        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.PictureBox CasinoMan;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox plate;
        private System.Windows.Forms.PictureBox coverPlate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlate;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnCashIn;
        private System.Windows.Forms.Button btnCashOut;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbLastRoll;
    }
}

