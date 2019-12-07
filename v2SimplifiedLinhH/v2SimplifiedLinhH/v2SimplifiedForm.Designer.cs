namespace v2SimplifiedLinhH
{
    partial class frmV2Simplified
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
            this.btnStay = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.grbScore = new System.Windows.Forms.GroupBox();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picDCard3 = new System.Windows.Forms.PictureBox();
            this.picDCard2 = new System.Windows.Forms.PictureBox();
            this.picDCard = new System.Windows.Forms.PictureBox();
            this.picUCard3 = new System.Windows.Forms.PictureBox();
            this.picUCard2 = new System.Windows.Forms.PictureBox();
            this.picUCard = new System.Windows.Forms.PictureBox();
            this.lblTotalGames = new System.Windows.Forms.Label();
            this.lblDealerWinScore = new System.Windows.Forms.Label();
            this.lblPlayerWinScore = new System.Windows.Forms.Label();
            this.lblDWin = new System.Windows.Forms.Label();
            this.lblUWin = new System.Windows.Forms.Label();
            this.grbScore.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUCard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(480, 416);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(99, 43);
            this.btnStay.TabIndex = 16;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.BtnStay_Click);
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(480, 357);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(99, 42);
            this.btnHit.TabIndex = 15;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // grbScore
            // 
            this.grbScore.Controls.Add(this.lblDealerScore);
            this.grbScore.Controls.Add(this.lblDealer);
            this.grbScore.Controls.Add(this.lblPlayerScore);
            this.grbScore.Controls.Add(this.lblPlayer);
            this.grbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbScore.Location = new System.Drawing.Point(609, 357);
            this.grbScore.Name = "grbScore";
            this.grbScore.Size = new System.Drawing.Size(143, 85);
            this.grbScore.TabIndex = 17;
            this.grbScore.TabStop = false;
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerScore.Location = new System.Drawing.Point(6, 53);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(60, 24);
            this.lblDealerScore.TabIndex = 5;
            this.lblDealerScore.Text = "Score";
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(68, 53);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(65, 24);
            this.lblDealer.TabIndex = 6;
            this.lblDealer.Text = "Dealer";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(6, 29);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(60, 24);
            this.lblPlayerScore.TabIndex = 7;
            this.lblPlayerScore.Text = "Score";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(68, 29);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(62, 24);
            this.lblPlayer.TabIndex = 8;
            this.lblPlayer.Text = "Player";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(190, 102);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 36);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(77, 20);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(37, 20);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::v2SimplifiedLinhH.Properties.Resources.poker1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(914, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // picDCard3
            // 
            this.picDCard3.Image = global::v2SimplifiedLinhH.Properties.Resources.Back;
            this.picDCard3.Location = new System.Drawing.Point(335, 329);
            this.picDCard3.Name = "picDCard3";
            this.picDCard3.Size = new System.Drawing.Size(100, 145);
            this.picDCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDCard3.TabIndex = 14;
            this.picDCard3.TabStop = false;
            // 
            // picDCard2
            // 
            this.picDCard2.Image = global::v2SimplifiedLinhH.Properties.Resources.Back;
            this.picDCard2.Location = new System.Drawing.Point(205, 329);
            this.picDCard2.Name = "picDCard2";
            this.picDCard2.Size = new System.Drawing.Size(100, 145);
            this.picDCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDCard2.TabIndex = 13;
            this.picDCard2.TabStop = false;
            // 
            // picDCard
            // 
            this.picDCard.Image = global::v2SimplifiedLinhH.Properties.Resources.Back;
            this.picDCard.Location = new System.Drawing.Point(72, 329);
            this.picDCard.Name = "picDCard";
            this.picDCard.Size = new System.Drawing.Size(100, 145);
            this.picDCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDCard.TabIndex = 12;
            this.picDCard.TabStop = false;
            // 
            // picUCard3
            // 
            this.picUCard3.Image = global::v2SimplifiedLinhH.Properties.Resources.Back;
            this.picUCard3.Location = new System.Drawing.Point(335, 157);
            this.picUCard3.Name = "picUCard3";
            this.picUCard3.Size = new System.Drawing.Size(100, 145);
            this.picUCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUCard3.TabIndex = 11;
            this.picUCard3.TabStop = false;
            // 
            // picUCard2
            // 
            this.picUCard2.Image = global::v2SimplifiedLinhH.Properties.Resources.Back;
            this.picUCard2.Location = new System.Drawing.Point(205, 157);
            this.picUCard2.Name = "picUCard2";
            this.picUCard2.Size = new System.Drawing.Size(100, 145);
            this.picUCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUCard2.TabIndex = 10;
            this.picUCard2.TabStop = false;
            // 
            // picUCard
            // 
            this.picUCard.Image = global::v2SimplifiedLinhH.Properties.Resources.Back;
            this.picUCard.Location = new System.Drawing.Point(72, 157);
            this.picUCard.Name = "picUCard";
            this.picUCard.Size = new System.Drawing.Size(100, 145);
            this.picUCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUCard.TabIndex = 9;
            this.picUCard.TabStop = false;
            // 
            // lblTotalGames
            // 
            this.lblTotalGames.AutoSize = true;
            this.lblTotalGames.Location = new System.Drawing.Point(12, 590);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(78, 13);
            this.lblTotalGames.TabIndex = 22;
            this.lblTotalGames.Text = "Games Played:";
            // 
            // lblDealerWinScore
            // 
            this.lblDealerWinScore.AutoSize = true;
            this.lblDealerWinScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerWinScore.Location = new System.Drawing.Point(90, 515);
            this.lblDealerWinScore.Name = "lblDealerWinScore";
            this.lblDealerWinScore.Size = new System.Drawing.Size(0, 18);
            this.lblDealerWinScore.TabIndex = 23;
            // 
            // lblPlayerWinScore
            // 
            this.lblPlayerWinScore.AutoSize = true;
            this.lblPlayerWinScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWinScore.Location = new System.Drawing.Point(90, 546);
            this.lblPlayerWinScore.Name = "lblPlayerWinScore";
            this.lblPlayerWinScore.Size = new System.Drawing.Size(0, 18);
            this.lblPlayerWinScore.TabIndex = 24;
            // 
            // lblDWin
            // 
            this.lblDWin.AutoSize = true;
            this.lblDWin.Location = new System.Drawing.Point(12, 520);
            this.lblDWin.Name = "lblDWin";
            this.lblDWin.Size = new System.Drawing.Size(68, 13);
            this.lblDWin.TabIndex = 25;
            this.lblDWin.Text = "Dealer Wins:";
            // 
            // lblUWin
            // 
            this.lblUWin.AutoSize = true;
            this.lblUWin.Location = new System.Drawing.Point(12, 546);
            this.lblUWin.Name = "lblUWin";
            this.lblUWin.Size = new System.Drawing.Size(59, 13);
            this.lblUWin.TabIndex = 26;
            this.lblUWin.Text = "User Wins:";
            // 
            // frmV2Simplified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 612);
            this.Controls.Add(this.lblUWin);
            this.Controls.Add(this.lblDWin);
            this.Controls.Add(this.lblPlayerWinScore);
            this.Controls.Add(this.lblDealerWinScore);
            this.Controls.Add(this.lblTotalGames);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grbScore);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.picDCard3);
            this.Controls.Add(this.picDCard2);
            this.Controls.Add(this.picDCard);
            this.Controls.Add(this.picUCard3);
            this.Controls.Add(this.picUCard2);
            this.Controls.Add(this.picUCard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmV2Simplified";
            this.Text = "Version 2.0 Simplified 21";
            this.grbScore.ResumeLayout(false);
            this.grbScore.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.PictureBox picDCard3;
        private System.Windows.Forms.PictureBox picDCard2;
        private System.Windows.Forms.PictureBox picDCard;
        private System.Windows.Forms.PictureBox picUCard3;
        private System.Windows.Forms.PictureBox picUCard2;
        private System.Windows.Forms.PictureBox picUCard;
        private System.Windows.Forms.GroupBox grbScore;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblTotalGames;
        private System.Windows.Forms.Label lblDealerWinScore;
        private System.Windows.Forms.Label lblPlayerWinScore;
        private System.Windows.Forms.Label lblDWin;
        private System.Windows.Forms.Label lblUWin;
    }
}

