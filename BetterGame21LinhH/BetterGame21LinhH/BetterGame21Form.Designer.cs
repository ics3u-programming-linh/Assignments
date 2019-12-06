namespace BetterGame21LinhH
{
    partial class frmBetterGame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.picUCard = new System.Windows.Forms.PictureBox();
            this.picUCard2 = new System.Windows.Forms.PictureBox();
            this.picUCard3 = new System.Windows.Forms.PictureBox();
            this.picDCard3 = new System.Windows.Forms.PictureBox();
            this.picDCard2 = new System.Windows.Forms.PictureBox();
            this.picDCard = new System.Windows.Forms.PictureBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit,
            this.mniNewGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(37, 20);
            this.mniExit.Text = "Exit";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(77, 20);
            this.mniNewGame.Text = "New Game";
            // 
            // picUCard
            // 
            this.picUCard.Image = global::BetterGame21LinhH.Properties.Resources.Back;
            this.picUCard.Location = new System.Drawing.Point(61, 82);
            this.picUCard.Name = "picUCard";
            this.picUCard.Size = new System.Drawing.Size(100, 145);
            this.picUCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUCard.TabIndex = 1;
            this.picUCard.TabStop = false;
            // 
            // picUCard2
            // 
            this.picUCard2.Image = global::BetterGame21LinhH.Properties.Resources.Back;
            this.picUCard2.Location = new System.Drawing.Point(194, 82);
            this.picUCard2.Name = "picUCard2";
            this.picUCard2.Size = new System.Drawing.Size(100, 145);
            this.picUCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUCard2.TabIndex = 2;
            this.picUCard2.TabStop = false;
            // 
            // picUCard3
            // 
            this.picUCard3.Location = new System.Drawing.Point(324, 82);
            this.picUCard3.Name = "picUCard3";
            this.picUCard3.Size = new System.Drawing.Size(100, 145);
            this.picUCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUCard3.TabIndex = 3;
            this.picUCard3.TabStop = false;
            // 
            // picDCard3
            // 
            this.picDCard3.Location = new System.Drawing.Point(324, 254);
            this.picDCard3.Name = "picDCard3";
            this.picDCard3.Size = new System.Drawing.Size(100, 145);
            this.picDCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDCard3.TabIndex = 6;
            this.picDCard3.TabStop = false;
            // 
            // picDCard2
            // 
            this.picDCard2.Location = new System.Drawing.Point(194, 254);
            this.picDCard2.Name = "picDCard2";
            this.picDCard2.Size = new System.Drawing.Size(100, 145);
            this.picDCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDCard2.TabIndex = 5;
            this.picDCard2.TabStop = false;
            // 
            // picDCard
            // 
            this.picDCard.Location = new System.Drawing.Point(61, 254);
            this.picDCard.Name = "picDCard";
            this.picDCard.Size = new System.Drawing.Size(100, 145);
            this.picDCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDCard.TabIndex = 4;
            this.picDCard.TabStop = false;
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(618, 97);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(99, 42);
            this.btnHit.TabIndex = 7;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(618, 156);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(99, 43);
            this.btnStay.TabIndex = 8;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.BtnStay_Click);
            // 
            // frmBetterGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.picDCard3);
            this.Controls.Add(this.picDCard2);
            this.Controls.Add(this.picDCard);
            this.Controls.Add(this.picUCard3);
            this.Controls.Add(this.picUCard2);
            this.Controls.Add(this.picUCard);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmBetterGame";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.PictureBox picUCard;
        private System.Windows.Forms.PictureBox picUCard2;
        private System.Windows.Forms.PictureBox picUCard3;
        private System.Windows.Forms.PictureBox picDCard3;
        private System.Windows.Forms.PictureBox picDCard2;
        private System.Windows.Forms.PictureBox picDCard;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
    }
}

