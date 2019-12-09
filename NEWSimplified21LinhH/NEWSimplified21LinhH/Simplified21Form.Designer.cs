namespace NEWSimplified21LinhH
{
    partial class frmSimplified21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimplified21));
            this.mnuTaskBar = new System.Windows.Forms.MenuStrip();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picBacground = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSimplified21 = new System.Windows.Forms.Label();
            this.picDealerCard = new System.Windows.Forms.PictureBox();
            this.picDealerCard2 = new System.Windows.Forms.PictureBox();
            this.picDealerCard3 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard = new System.Windows.Forms.PictureBox();
            this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.grbTotal = new System.Windows.Forms.GroupBox();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.lblPlayerTotal = new System.Windows.Forms.Label();
            this.lblDealerTotalAns = new System.Windows.Forms.Label();
            this.lblPlayerTotalAnswer = new System.Windows.Forms.Label();
            this.mnuTaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBacground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
            this.grbTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuTaskBar
            // 
            this.mnuTaskBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mnuExit});
            this.mnuTaskBar.Location = new System.Drawing.Point(0, 0);
            this.mnuTaskBar.Name = "mnuTaskBar";
            this.mnuTaskBar.Size = new System.Drawing.Size(800, 24);
            this.mnuTaskBar.TabIndex = 0;
            this.mnuTaskBar.Text = "mnuTaskbar";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(77, 20);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.MniNewGame_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // picBacground
            // 
            this.picBacground.Image = ((System.Drawing.Image)(resources.GetObject("picBacground.Image")));
            this.picBacground.Location = new System.Drawing.Point(0, 27);
            this.picBacground.Name = "picBacground";
            this.picBacground.Size = new System.Drawing.Size(800, 430);
            this.picBacground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBacground.TabIndex = 1;
            this.picBacground.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(275, 257);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(184, 81);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblSimplified21
            // 
            this.lblSimplified21.AutoSize = true;
            this.lblSimplified21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSimplified21.Font = new System.Drawing.Font("Bebas Neue", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimplified21.Location = new System.Drawing.Point(144, 125);
            this.lblSimplified21.Name = "lblSimplified21";
            this.lblSimplified21.Size = new System.Drawing.Size(495, 115);
            this.lblSimplified21.TabIndex = 3;
            this.lblSimplified21.Text = "Simplified 21";
            // 
            // picDealerCard
            // 
            this.picDealerCard.Image = global::NEWSimplified21LinhH.Properties.Resources.Back;
            this.picDealerCard.Location = new System.Drawing.Point(37, 70);
            this.picDealerCard.Name = "picDealerCard";
            this.picDealerCard.Size = new System.Drawing.Size(114, 150);
            this.picDealerCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard.TabIndex = 4;
            this.picDealerCard.TabStop = false;
            // 
            // picDealerCard2
            // 
            this.picDealerCard2.Image = global::NEWSimplified21LinhH.Properties.Resources.Back;
            this.picDealerCard2.Location = new System.Drawing.Point(180, 70);
            this.picDealerCard2.Name = "picDealerCard2";
            this.picDealerCard2.Size = new System.Drawing.Size(114, 150);
            this.picDealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard2.TabIndex = 5;
            this.picDealerCard2.TabStop = false;
            // 
            // picDealerCard3
            // 
            this.picDealerCard3.Image = global::NEWSimplified21LinhH.Properties.Resources.Back;
            this.picDealerCard3.Location = new System.Drawing.Point(325, 70);
            this.picDealerCard3.Name = "picDealerCard3";
            this.picDealerCard3.Size = new System.Drawing.Size(114, 150);
            this.picDealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard3.TabIndex = 6;
            this.picDealerCard3.TabStop = false;
            // 
            // picPlayerCard
            // 
            this.picPlayerCard.Image = global::NEWSimplified21LinhH.Properties.Resources.Back;
            this.picPlayerCard.Location = new System.Drawing.Point(37, 243);
            this.picPlayerCard.Name = "picPlayerCard";
            this.picPlayerCard.Size = new System.Drawing.Size(114, 150);
            this.picPlayerCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard.TabIndex = 7;
            this.picPlayerCard.TabStop = false;
            // 
            // picPlayerCard2
            // 
            this.picPlayerCard2.Image = global::NEWSimplified21LinhH.Properties.Resources.Back;
            this.picPlayerCard2.Location = new System.Drawing.Point(180, 243);
            this.picPlayerCard2.Name = "picPlayerCard2";
            this.picPlayerCard2.Size = new System.Drawing.Size(114, 150);
            this.picPlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard2.TabIndex = 8;
            this.picPlayerCard2.TabStop = false;
            // 
            // picPlayerCard3
            // 
            this.picPlayerCard3.Image = global::NEWSimplified21LinhH.Properties.Resources.Back;
            this.picPlayerCard3.Location = new System.Drawing.Point(325, 243);
            this.picPlayerCard3.Name = "picPlayerCard3";
            this.picPlayerCard3.Size = new System.Drawing.Size(114, 150);
            this.picPlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard3.TabIndex = 9;
            this.picPlayerCard3.TabStop = false;
            // 
            // grbTotal
            // 
            this.grbTotal.Controls.Add(this.lblPlayerTotalAnswer);
            this.grbTotal.Controls.Add(this.lblDealerTotalAns);
            this.grbTotal.Controls.Add(this.lblPlayerTotal);
            this.grbTotal.Controls.Add(this.lblDealerTotal);
            this.grbTotal.Location = new System.Drawing.Point(542, 100);
            this.grbTotal.Name = "grbTotal";
            this.grbTotal.Size = new System.Drawing.Size(200, 100);
            this.grbTotal.TabIndex = 10;
            this.grbTotal.TabStop = false;
            this.grbTotal.Text = "Total";
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerTotal.Location = new System.Drawing.Point(15, 25);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(60, 20);
            this.lblDealerTotal.TabIndex = 0;
            this.lblDealerTotal.Text = "Dealer:";
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.AutoSize = true;
            this.lblPlayerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTotal.Location = new System.Drawing.Point(15, 62);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(56, 20);
            this.lblPlayerTotal.TabIndex = 1;
            this.lblPlayerTotal.Text = "Player:";
            // 
            // lblDealerTotalAns
            // 
            this.lblDealerTotalAns.AutoSize = true;
            this.lblDealerTotalAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerTotalAns.Location = new System.Drawing.Point(74, 25);
            this.lblDealerTotalAns.Name = "lblDealerTotalAns";
            this.lblDealerTotalAns.Size = new System.Drawing.Size(0, 20);
            this.lblDealerTotalAns.TabIndex = 2;
            // 
            // lblPlayerTotalAnswer
            // 
            this.lblPlayerTotalAnswer.AutoSize = true;
            this.lblPlayerTotalAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTotalAnswer.Location = new System.Drawing.Point(74, 62);
            this.lblPlayerTotalAnswer.Name = "lblPlayerTotalAnswer";
            this.lblPlayerTotalAnswer.Size = new System.Drawing.Size(0, 20);
            this.lblPlayerTotalAnswer.TabIndex = 3;
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbTotal);
            this.Controls.Add(this.picPlayerCard3);
            this.Controls.Add(this.picPlayerCard2);
            this.Controls.Add(this.picPlayerCard);
            this.Controls.Add(this.picDealerCard3);
            this.Controls.Add(this.picDealerCard2);
            this.Controls.Add(this.picDealerCard);
            this.Controls.Add(this.lblSimplified21);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picBacground);
            this.Controls.Add(this.mnuTaskBar);
            this.MainMenuStrip = this.mnuTaskBar;
            this.Name = "frmSimplified21";
            this.Text = "Simplified 21";
            this.mnuTaskBar.ResumeLayout(false);
            this.mnuTaskBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBacground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
            this.grbTotal.ResumeLayout(false);
            this.grbTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuTaskBar;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.PictureBox picBacground;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSimplified21;
        private System.Windows.Forms.PictureBox picDealerCard;
        private System.Windows.Forms.PictureBox picDealerCard2;
        private System.Windows.Forms.PictureBox picDealerCard3;
        private System.Windows.Forms.PictureBox picPlayerCard;
        private System.Windows.Forms.PictureBox picPlayerCard2;
        private System.Windows.Forms.PictureBox picPlayerCard3;
        private System.Windows.Forms.GroupBox grbTotal;
        private System.Windows.Forms.Label lblPlayerTotalAnswer;
        private System.Windows.Forms.Label lblDealerTotalAns;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Label lblDealerTotal;
    }
}

