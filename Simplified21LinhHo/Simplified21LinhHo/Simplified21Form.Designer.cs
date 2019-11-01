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
            this.lblPlayerCard3 = new System.Windows.Forms.Label();
            this.lblCompCard2 = new System.Windows.Forms.Label();
            this.lblCompCard3 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblCompCard4 = new System.Windows.Forms.Label();
            this.lblCompCard5 = new System.Windows.Forms.Label();
            this.picMultipleCards = new System.Windows.Forms.PictureBox();
            this.picCompCard5 = new System.Windows.Forms.PictureBox();
            this.lblCompCard1 = new System.Windows.Forms.Label();
            this.picCompCard = new System.Windows.Forms.PictureBox();
            this.picCompCard2 = new System.Windows.Forms.PictureBox();
            this.picCompCard3 = new System.Windows.Forms.PictureBox();
            this.picCompCard4 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard = new System.Windows.Forms.PictureBox();
            this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.lblPlayerWin = new System.Windows.Forms.Label();
            this.lblPlayerWinScore = new System.Windows.Forms.Label();
            this.lblDealerWin = new System.Windows.Forms.Label();
            this.lblDealerWinScore = new System.Windows.Forms.Label();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.lblTotalGames = new System.Windows.Forms.Label();
            this.grbGamesPlayed = new System.Windows.Forms.GroupBox();
            this.grbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grbScore.SuspendLayout();
            this.grbHitOrStand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMultipleCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
            this.grbGamesPlayed.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSimplified
            // 
            this.lblSimplified.AutoSize = true;
            this.lblSimplified.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSimplified.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimplified.Location = new System.Drawing.Point(121, 16);
            this.lblSimplified.Name = "lblSimplified";
            this.lblSimplified.Size = new System.Drawing.Size(591, 108);
            this.lblSimplified.TabIndex = 0;
            this.lblSimplified.Text = "Simplified 21";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(348, 127);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 45);
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
            this.picBackground.Size = new System.Drawing.Size(958, 184);
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
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
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
            this.lblDealer.Location = new System.Drawing.Point(68, 16);
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
            this.lblPlayer.Location = new System.Drawing.Point(68, 46);
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
            this.btnStand.Location = new System.Drawing.Point(102, 11);
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
            this.grbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbScore.Location = new System.Drawing.Point(90, 283);
            this.grbScore.Name = "grbScore";
            this.grbScore.Size = new System.Drawing.Size(143, 85);
            this.grbScore.TabIndex = 11;
            this.grbScore.TabStop = false;
            // 
            // grbHitOrStand
            // 
            this.grbHitOrStand.Controls.Add(this.btnStand);
            this.grbHitOrStand.Controls.Add(this.btnHit);
            this.grbHitOrStand.Location = new System.Drawing.Point(39, 385);
            this.grbHitOrStand.Name = "grbHitOrStand";
            this.grbHitOrStand.Size = new System.Drawing.Size(226, 68);
            this.grbHitOrStand.TabIndex = 12;
            this.grbHitOrStand.TabStop = false;
            // 
            // lblPlayerCard1
            // 
            this.lblPlayerCard1.AutoSize = true;
            this.lblPlayerCard1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard1.Location = new System.Drawing.Point(341, 449);
            this.lblPlayerCard1.Name = "lblPlayerCard1";
            this.lblPlayerCard1.Size = new System.Drawing.Size(70, 25);
            this.lblPlayerCard1.TabIndex = 13;
            this.lblPlayerCard1.Text = "label1";
            // 
            // lblPlayerCard2
            // 
            this.lblPlayerCard2.AutoSize = true;
            this.lblPlayerCard2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerCard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard2.Location = new System.Drawing.Point(429, 449);
            this.lblPlayerCard2.Name = "lblPlayerCard2";
            this.lblPlayerCard2.Size = new System.Drawing.Size(70, 25);
            this.lblPlayerCard2.TabIndex = 14;
            this.lblPlayerCard2.Text = "label2";
            // 
            // lblPlayerCard3
            // 
            this.lblPlayerCard3.AutoSize = true;
            this.lblPlayerCard3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerCard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard3.Location = new System.Drawing.Point(515, 449);
            this.lblPlayerCard3.Name = "lblPlayerCard3";
            this.lblPlayerCard3.Size = new System.Drawing.Size(70, 25);
            this.lblPlayerCard3.TabIndex = 16;
            this.lblPlayerCard3.Text = "label2";
            // 
            // lblCompCard2
            // 
            this.lblCompCard2.AutoSize = true;
            this.lblCompCard2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCompCard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompCard2.Location = new System.Drawing.Point(429, 345);
            this.lblCompCard2.Name = "lblCompCard2";
            this.lblCompCard2.Size = new System.Drawing.Size(70, 25);
            this.lblCompCard2.TabIndex = 17;
            this.lblCompCard2.Text = "label3";
            // 
            // lblCompCard3
            // 
            this.lblCompCard3.AutoSize = true;
            this.lblCompCard3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCompCard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompCard3.Location = new System.Drawing.Point(515, 345);
            this.lblCompCard3.Name = "lblCompCard3";
            this.lblCompCard3.Size = new System.Drawing.Size(70, 25);
            this.lblCompCard3.TabIndex = 18;
            this.lblCompCard3.Text = "label3";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(605, 437);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(120, 47);
            this.btnRestart.TabIndex = 19;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // lblCompCard4
            // 
            this.lblCompCard4.AutoSize = true;
            this.lblCompCard4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCompCard4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompCard4.Location = new System.Drawing.Point(600, 345);
            this.lblCompCard4.Name = "lblCompCard4";
            this.lblCompCard4.Size = new System.Drawing.Size(70, 25);
            this.lblCompCard4.TabIndex = 20;
            this.lblCompCard4.Text = "label3";
            // 
            // lblCompCard5
            // 
            this.lblCompCard5.AutoSize = true;
            this.lblCompCard5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCompCard5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompCard5.Location = new System.Drawing.Point(688, 345);
            this.lblCompCard5.Name = "lblCompCard5";
            this.lblCompCard5.Size = new System.Drawing.Size(70, 25);
            this.lblCompCard5.TabIndex = 29;
            this.lblCompCard5.Text = "label3";
            // 
            // picMultipleCards
            // 
            this.picMultipleCards.Image = global::Simplified21LinhHo.Properties.Resources.original;
            this.picMultipleCards.Location = new System.Drawing.Point(-16, 27);
            this.picMultipleCards.Name = "picMultipleCards";
            this.picMultipleCards.Size = new System.Drawing.Size(841, 237);
            this.picMultipleCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMultipleCards.TabIndex = 30;
            this.picMultipleCards.TabStop = false;
            // 
            // picCompCard5
            // 
            this.picCompCard5.Image = global::Simplified21LinhHo.Properties.Resources.card;
            this.picCompCard5.Location = new System.Drawing.Point(666, 312);
            this.picCompCard5.Name = "picCompCard5";
            this.picCompCard5.Size = new System.Drawing.Size(73, 94);
            this.picCompCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompCard5.TabIndex = 28;
            this.picCompCard5.TabStop = false;
            // 
            // lblCompCard1
            // 
            this.lblCompCard1.AutoSize = true;
            this.lblCompCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompCard1.Image = global::Simplified21LinhHo.Properties.Resources.card;
            this.lblCompCard1.Location = new System.Drawing.Point(342, 344);
            this.lblCompCard1.Name = "lblCompCard1";
            this.lblCompCard1.Size = new System.Drawing.Size(60, 24);
            this.lblCompCard1.TabIndex = 15;
            this.lblCompCard1.Text = "label3";
            // 
            // picCompCard
            // 
            this.picCompCard.Image = global::Simplified21LinhHo.Properties.Resources.card;
            this.picCompCard.Location = new System.Drawing.Point(319, 312);
            this.picCompCard.Name = "picCompCard";
            this.picCompCard.Size = new System.Drawing.Size(73, 94);
            this.picCompCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompCard.TabIndex = 21;
            this.picCompCard.TabStop = false;
            // 
            // picCompCard2
            // 
            this.picCompCard2.Image = global::Simplified21LinhHo.Properties.Resources.card;
            this.picCompCard2.Location = new System.Drawing.Point(408, 312);
            this.picCompCard2.Name = "picCompCard2";
            this.picCompCard2.Size = new System.Drawing.Size(73, 94);
            this.picCompCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompCard2.TabIndex = 22;
            this.picCompCard2.TabStop = false;
            // 
            // picCompCard3
            // 
            this.picCompCard3.Image = global::Simplified21LinhHo.Properties.Resources.card;
            this.picCompCard3.Location = new System.Drawing.Point(497, 312);
            this.picCompCard3.Name = "picCompCard3";
            this.picCompCard3.Size = new System.Drawing.Size(73, 94);
            this.picCompCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompCard3.TabIndex = 23;
            this.picCompCard3.TabStop = false;
            // 
            // picCompCard4
            // 
            this.picCompCard4.Image = global::Simplified21LinhHo.Properties.Resources.card;
            this.picCompCard4.Location = new System.Drawing.Point(581, 312);
            this.picCompCard4.Name = "picCompCard4";
            this.picCompCard4.Size = new System.Drawing.Size(73, 94);
            this.picCompCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompCard4.TabIndex = 24;
            this.picCompCard4.TabStop = false;
            // 
            // picPlayerCard
            // 
            this.picPlayerCard.Image = global::Simplified21LinhHo.Properties.Resources.card;
            this.picPlayerCard.Location = new System.Drawing.Point(319, 416);
            this.picPlayerCard.Name = "picPlayerCard";
            this.picPlayerCard.Size = new System.Drawing.Size(73, 94);
            this.picPlayerCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard.TabIndex = 25;
            this.picPlayerCard.TabStop = false;
            // 
            // picPlayerCard2
            // 
            this.picPlayerCard2.Image = global::Simplified21LinhHo.Properties.Resources.card;
            this.picPlayerCard2.Location = new System.Drawing.Point(408, 416);
            this.picPlayerCard2.Name = "picPlayerCard2";
            this.picPlayerCard2.Size = new System.Drawing.Size(73, 94);
            this.picPlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard2.TabIndex = 26;
            this.picPlayerCard2.TabStop = false;
            // 
            // picPlayerCard3
            // 
            this.picPlayerCard3.Image = global::Simplified21LinhHo.Properties.Resources.card;
            this.picPlayerCard3.Location = new System.Drawing.Point(497, 416);
            this.picPlayerCard3.Name = "picPlayerCard3";
            this.picPlayerCard3.Size = new System.Drawing.Size(73, 94);
            this.picPlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard3.TabIndex = 27;
            this.picPlayerCard3.TabStop = false;
            // 
            // lblPlayerWin
            // 
            this.lblPlayerWin.AutoSize = true;
            this.lblPlayerWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWin.Location = new System.Drawing.Point(41, 484);
            this.lblPlayerWin.Name = "lblPlayerWin";
            this.lblPlayerWin.Size = new System.Drawing.Size(161, 24);
            this.lblPlayerWin.TabIndex = 31;
            this.lblPlayerWin.Text = "Player Win Points:";
            // 
            // lblPlayerWinScore
            // 
            this.lblPlayerWinScore.AutoSize = true;
            this.lblPlayerWinScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWinScore.Location = new System.Drawing.Point(208, 484);
            this.lblPlayerWinScore.Name = "lblPlayerWinScore";
            this.lblPlayerWinScore.Size = new System.Drawing.Size(57, 24);
            this.lblPlayerWinScore.TabIndex = 32;
            this.lblPlayerWinScore.Text = "score";
            // 
            // lblDealerWin
            // 
            this.lblDealerWin.AutoSize = true;
            this.lblDealerWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerWin.Location = new System.Drawing.Point(41, 506);
            this.lblDealerWin.Name = "lblDealerWin";
            this.lblDealerWin.Size = new System.Drawing.Size(164, 24);
            this.lblDealerWin.TabIndex = 33;
            this.lblDealerWin.Text = "Dealer Win Points:";
            // 
            // lblDealerWinScore
            // 
            this.lblDealerWinScore.AutoSize = true;
            this.lblDealerWinScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerWinScore.Location = new System.Drawing.Point(208, 506);
            this.lblDealerWinScore.Name = "lblDealerWinScore";
            this.lblDealerWinScore.Size = new System.Drawing.Size(57, 24);
            this.lblDealerWinScore.TabIndex = 34;
            this.lblDealerWinScore.Text = "score";
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Location = new System.Drawing.Point(6, 8);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(78, 13);
            this.lblGamesPlayed.TabIndex = 35;
            this.lblGamesPlayed.Text = "Games Played:";
            // 
            // lblTotalGames
            // 
            this.lblTotalGames.AutoSize = true;
            this.lblTotalGames.Location = new System.Drawing.Point(82, 8);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(13, 13);
            this.lblTotalGames.TabIndex = 36;
            this.lblTotalGames.Text = "0";
            // 
            // grbGamesPlayed
            // 
            this.grbGamesPlayed.Controls.Add(this.lblGamesPlayed);
            this.grbGamesPlayed.Controls.Add(this.lblTotalGames);
            this.grbGamesPlayed.Location = new System.Drawing.Point(0, 560);
            this.grbGamesPlayed.Name = "grbGamesPlayed";
            this.grbGamesPlayed.Size = new System.Drawing.Size(148, 24);
            this.grbGamesPlayed.TabIndex = 37;
            this.grbGamesPlayed.TabStop = false;
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 587);
            this.Controls.Add(this.grbGamesPlayed);
            this.Controls.Add(this.lblDealerWinScore);
            this.Controls.Add(this.grbScore);
            this.Controls.Add(this.picMultipleCards);
            this.Controls.Add(this.lblDealerWin);
            this.Controls.Add(this.lblPlayerWinScore);
            this.Controls.Add(this.lblPlayerWin);
            this.Controls.Add(this.lblCompCard5);
            this.Controls.Add(this.picCompCard5);
            this.Controls.Add(this.lblCompCard4);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblCompCard3);
            this.Controls.Add(this.lblCompCard2);
            this.Controls.Add(this.grbHitOrStand);
            this.Controls.Add(this.lblPlayerCard3);
            this.Controls.Add(this.lblCompCard1);
            this.Controls.Add(this.lblPlayerCard2);
            this.Controls.Add(this.lblPlayerCard1);
            this.Controls.Add(this.grbMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picCompCard);
            this.Controls.Add(this.picCompCard2);
            this.Controls.Add(this.picCompCard3);
            this.Controls.Add(this.picCompCard4);
            this.Controls.Add(this.picPlayerCard);
            this.Controls.Add(this.picPlayerCard2);
            this.Controls.Add(this.picPlayerCard3);
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
            ((System.ComponentModel.ISupportInitialize)(this.picMultipleCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
            this.grbGamesPlayed.ResumeLayout(false);
            this.grbGamesPlayed.PerformLayout();
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
        private System.Windows.Forms.Label lblCompCard4;
        private System.Windows.Forms.PictureBox picCompCard;
        private System.Windows.Forms.PictureBox picCompCard2;
        private System.Windows.Forms.PictureBox picCompCard3;
        private System.Windows.Forms.PictureBox picCompCard4;
        private System.Windows.Forms.PictureBox picPlayerCard;
        private System.Windows.Forms.PictureBox picPlayerCard2;
        private System.Windows.Forms.PictureBox picPlayerCard3;
        private System.Windows.Forms.PictureBox picCompCard5;
        private System.Windows.Forms.Label lblCompCard5;
        private System.Windows.Forms.PictureBox picMultipleCards;
        private System.Windows.Forms.Label lblPlayerWin;
        private System.Windows.Forms.Label lblPlayerWinScore;
        private System.Windows.Forms.Label lblDealerWin;
        private System.Windows.Forms.Label lblDealerWinScore;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Label lblTotalGames;
        private System.Windows.Forms.GroupBox grbGamesPlayed;
    }
}

