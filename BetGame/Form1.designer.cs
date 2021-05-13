
namespace BetGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picture4 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.panelGame = new System.Windows.Forms.Panel();
            this.numericPlaneNo = new System.Windows.Forms.NumericUpDown();
            this.numericBetAmount = new System.Windows.Forms.NumericUpDown();
            this.lblPlaneSelection = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.picture4);
            this.panel1.Controls.Add(this.picture3);
            this.panel1.Controls.Add(this.picture2);
            this.panel1.Controls.Add(this.picture1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 309);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BetGame.Properties.Resources.startline;
            this.pictureBox6.Location = new System.Drawing.Point(109, -2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 307);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BetGame.Properties.Resources.endline;
            this.pictureBox5.Location = new System.Drawing.Point(963, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 307);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // picture4
            // 
            this.picture4.Image = global::BetGame.Properties.Resources.four;
            this.picture4.Location = new System.Drawing.Point(3, 246);
            this.picture4.Name = "picture4";
            this.picture4.Size = new System.Drawing.Size(100, 50);
            this.picture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture4.TabIndex = 3;
            this.picture4.TabStop = false;
            // 
            // picture3
            // 
            this.picture3.Image = global::BetGame.Properties.Resources.third;
            this.picture3.Location = new System.Drawing.Point(3, 165);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(100, 50);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture3.TabIndex = 2;
            this.picture3.TabStop = false;
            // 
            // picture2
            // 
            this.picture2.Image = global::BetGame.Properties.Resources.second;
            this.picture2.Location = new System.Drawing.Point(3, 84);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(100, 50);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture2.TabIndex = 1;
            this.picture2.TabStop = false;
            // 
            // picture1
            // 
            this.picture1.Image = global::BetGame.Properties.Resources.first;
            this.picture1.Location = new System.Drawing.Point(3, 3);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(100, 50);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGame.Controls.Add(this.numericPlaneNo);
            this.panelGame.Controls.Add(this.numericBetAmount);
            this.panelGame.Controls.Add(this.lblPlaneSelection);
            this.panelGame.Controls.Add(this.lblBet);
            this.panelGame.Controls.Add(this.lblMax);
            this.panelGame.Controls.Add(this.text3);
            this.panelGame.Controls.Add(this.text2);
            this.panelGame.Controls.Add(this.text1);
            this.panelGame.Controls.Add(this.radio3);
            this.panelGame.Controls.Add(this.radio2);
            this.panelGame.Controls.Add(this.radio1);
            this.panelGame.Location = new System.Drawing.Point(5, 327);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1001, 365);
            this.panelGame.TabIndex = 1;
            // 
            // numericPlaneNo
            // 
            this.numericPlaneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPlaneNo.Location = new System.Drawing.Point(621, 305);
            this.numericPlaneNo.Name = "numericPlaneNo";
            this.numericPlaneNo.Size = new System.Drawing.Size(366, 34);
            this.numericPlaneNo.TabIndex = 10;
            // 
            // numericBetAmount
            // 
            this.numericBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBetAmount.Location = new System.Drawing.Point(621, 251);
            this.numericBetAmount.Name = "numericBetAmount";
            this.numericBetAmount.Size = new System.Drawing.Size(366, 34);
            this.numericBetAmount.TabIndex = 9;
            // 
            // lblPlaneSelection
            // 
            this.lblPlaneSelection.AutoSize = true;
            this.lblPlaneSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneSelection.Location = new System.Drawing.Point(17, 307);
            this.lblPlaneSelection.Name = "lblPlaneSelection";
            this.lblPlaneSelection.Size = new System.Drawing.Size(378, 29);
            this.lblPlaneSelection.TabIndex = 8;
            this.lblPlaneSelection.Text = "Player 1 Place Bet on Plane No";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(17, 253);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(371, 29);
            this.lblBet.TabIndex = 7;
            this.lblBet.Text = "Player 1 Place Bet of Amount $";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(17, 192);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(276, 29);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Max Amount Bet is $50";
            // 
            // text3
            // 
            this.text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.Location = new System.Drawing.Point(150, 142);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(837, 34);
            this.text3.TabIndex = 5;
            this.text3.Text = "Player 3 hasn\'t placed a bet";
            // 
            // text2
            // 
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(150, 82);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(837, 34);
            this.text2.TabIndex = 4;
            this.text2.Text = "Player 2 hasn\'t placed a bet";
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(150, 25);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(837, 34);
            this.text1.TabIndex = 3;
            this.text1.Text = "Player 1 hasn\'t placed a bet";
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio3.Location = new System.Drawing.Point(22, 147);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(104, 29);
            this.radio3.TabIndex = 2;
            this.radio3.TabStop = true;
            this.radio3.Text = "Player 3";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio3_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2.Location = new System.Drawing.Point(22, 87);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(104, 29);
            this.radio2.TabIndex = 1;
            this.radio2.TabStop = true;
            this.radio2.Text = "Player 2";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.Location = new System.Drawing.Point(22, 30);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(104, 29);
            this.radio1.TabIndex = 0;
            this.radio1.TabStop = true;
            this.radio1.Text = "Player 1";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // btnPlace
            // 
            this.btnPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlace.Location = new System.Drawing.Point(29, 698);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(515, 73);
            this.btnPlace.TabIndex = 2;
            this.btnPlace.Text = "Place A BET";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(550, 698);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(429, 73);
            this.btnBegin.TabIndex = 3;
            this.btnBegin.Text = "Start Race For Bet";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 783);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox picture4;
        private System.Windows.Forms.PictureBox picture3;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.NumericUpDown numericPlaneNo;
        private System.Windows.Forms.NumericUpDown numericBetAmount;
        private System.Windows.Forms.Label lblPlaneSelection;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnBegin;
    }
}

