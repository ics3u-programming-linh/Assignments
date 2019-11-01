namespace Simplified21LinhHo
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
            this.components = new System.ComponentModel.Container();
            this.lblSimplified = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.grbMain = new System.Windows.Forms.GroupBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.grbScore = new System.Windows.Forms.GroupBox();
            this.grbHitOrStand = new System.Windows.Forms.GroupBox();
            this.lblPlayerCard1 = new System.Windows.Forms.Label();
            this.lblPlayerCard2 = new System.Windows.Forms.Label();
            this.lblCompCard1 = new System.Windows.Forms.Label();
            this.lblPlayerCard3 = new System.Windows.Forms.Label();
            this.lblCompCard2 = new System.Windows.Forms.Label();
            this.lblCompCard3 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.grbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grbScore.SuspendLayout();
            this.grbHitOrStand.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSimplified
            // 
            this.lblSimplified.AutoSize = true;
            this.lblSimplified.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSimplified.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimplified.Location = new System.Drawing.Point(124, 16);
            this.lblSimplified.Name = "lblSimplified";
            this.lblSimplified.Size = new System.Drawing.Size(591, 108);
            this.lblSimplified.TabIndex = 0;
            this.lblSimplified.Text = "Simplified 21";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(352, 127);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 56);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // grbMain
            // 
            this.grbMain.Controls.Add(this.lblSimplified);
            this.grbMain.Controls.Add(this.btnStart);
            this.grbMain.Controls.Add(this.picBackground);
            this.grbMain.Location = new System.Drawing.Point(0, 27);
            this.grbMain.Name = "grbMain";
            this.grbMain.Size = new System.Drawing.Size(942, 190);
            this.grbMain.TabIndex = 2;
            this.grbMain.TabStop = false;
            this.grbMain.Text = "Created by Linh Ho";
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Simplified21LinhHo.Properties.Resources.main;
            this.picBackground.Location = new System.Drawing.Point(-16, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(958, 190);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 2;
            this.picBackground.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(77, 20);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.MniNewGame_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(37, 20);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerScore.Location = new System.Drawing.Point(6, 16);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(60, 24);
            this.lblDealerScore.TabIndex = 5;
            this.lblDealerScore.Text = "Score";
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(69, 16);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(65, 24);
            this.lblDealer.TabIndex = 6;
            this.lblDealer.Text = "Dealer";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(6, 46);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(60, 24);
            this.lblPlayerScore.TabIndex = 7;
            this.lblPlayerScore.Text = "Score";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(69, 46);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(62, 24);
            this.lblPlayer.TabIndex = 8;
            this.lblPlayer.Text = "Player";
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(6, 12);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(85, 46);
            this.btnHit.TabIndex = 9;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(117, 11);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(116, 47);
            this.btnStand.TabIndex = 10;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.Button1_Click);
            // 
            // grbScore
            // 
            this.grbScore.Controls.Add(this.lblDealerScore);
            this.grbScore.Controls.Add(this.lblDealer);
            this.grbScore.Controls.Add(this.lblPlayerScore);
            this.grbScore.Controls.Add(this.lblPlayer);
            this.grbScore.Location = new System.Drawing.Point(89, 304);
            this.grbScore.Name = "grbScore";
            this.grbScore.Size = new System.Drawing.Size(143, 85);
            this.grbScore.TabIndex = 11;
            this.grbScore.TabStop = false;
            // 
            // grbHitOrStand
            // 
            this.grbHitOrStand.Controls.Add(this.btnStand);
            this.grbHitOrStand.Controls.Add(this.btnHit);
            this.grbHitOrStand.Location = new System.Drawing.Point(37, 223);
            this.grbHitOrStand.Name = "grbHitOrStand";
            this.grbHitOrStand.Size = new System.Drawing.Size(248, 64);
            this.grbHitOrStand.TabIndex = 12;
            this.grbHitOrStand.TabStop = false;
            // 
            // lblPlayerCard1
            // 
            this.lblPlayerCard1.AutoSize = true;
            this.lblPlayerCard1.Location = new System.Drawing.Point(364, 359);
            this.lblPlayerCard1.Name = "lblPlayerCard1";
            this.lblPlayerCard1.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerCard1.TabIndex = 13;
            this.lblPlayerCard1.Text = "label1";
            // 
            // lblPlayerCard2
            // 
            this.lblPlayerCard2.AutoSize = true;
            this.lblPlayerCard2.Location = new System.Drawing.Point(416, 359);
            this.lblPlayerCard2.Name = "lblPlayerCard2";
            this.lblPlayerCard2.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerCard2.TabIndex = 14;
            this.lblPlayerCard2.Text = "label2";
            // 
            // lblCompCard1
            // 
            this.lblCompCard1.AutoSize = true;
            this.lblCompCard1.Location = new System.Drawing.Point(364, 255);
            this.lblCompCard1.Name = "lblCompCard1";
            this.lblCompCard1.Size = new System.Drawing.Size(35, 13);
            this.lblCompCard1.TabIndex = 15;
            this.lblCompCard1.Text = "label3";
            // 
            // lblPlayerCard3
            // 
            this.lblPlayerCard3.AutoSize = true;
            this.lblPlayerCard3.Location = new System.Drawing.Point(472, 359);
            this.lblPlayerCard3.Name = "lblPlayerCard3";
            this.lblPlayerCard3.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerCard3.TabIndex = 16;
            this.lblPlayerCard3.Text = "label2";
            // 
            // lblCompCard2
            // 
            this.lblCompCard2.AutoSize = true;
            this.lblCompCard2.Location = new System.Drawing.Point(416, 255);
            this.lblCompCard2.Name = "lblCompCard2";
            this.lblCompCard2.Size = new System.Drawing.Size(35, 13);
            this.lblCompCard2.TabIndex = 17;
            this.lblCompCard2.Text = "label3";
            // 
            // lblCompCard3
            // 
            this.lblCompCard3.AutoSize = true;
            this.lblCompCard3.Location = new System.Drawing.Point(472, 255);
            this.lblCompCard3.Name = "lblCompCard3";
            this.lblCompCard3.Size = new System.Drawing.Size(35, 13);
            this.lblCompCard3.TabIndex = 18;
            this.lblCompCard3.Text = "label3";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(662, 280);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(120, 47);
            this.btnRestart.TabIndex = 19;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 431);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblCompCard3);
            this.Controls.Add(this.lblCompCard2);
            this.Controls.Add(this.grbHitOrStand);
            this.Controls.Add(this.lblPlayerCard3);
            this.Controls.Add(this.lblCompCard1);
            this.Controls.Add(this.lblPlayerCard2);
            this.Controls.Add(this.lblPlayerCard1);
            this.Controls.Add(this.grbScore);
            this.Controls.Add(this.grbMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSimplified21";
            this.Text = "Simplified 21 by Linh Ho";
            this.grbMain.ResumeLayout(false);
            this.grbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbScore.ResumeLayout(false);
            this.grbScore.PerformLayout();
            this.grbHitOrStand.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSimplified;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grbMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.GroupBox grbHitOrStand;
        private System.Windows.Forms.GroupBox grbScore;
        private System.Windows.Forms.Label lblPlayerCard1;
        private System.Windows.Forms.Label lblPlayerCard2;
        private System.Windows.Forms.Label lblCompCard1;
        private System.Windows.Forms.Label lblPlayerCard3;
        private System.Windows.Forms.Label lblCompCard2;
        private System.Windows.Forms.Label lblCompCard3;
        private System.Windows.Forms.Button btnRestart;
    }
}

