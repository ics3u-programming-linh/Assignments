namespace FallingObjectsLinhH
{
    partial class frmFallingObjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFallingObjects));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.imgCliff = new System.Windows.Forms.PictureBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.imgCliff2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliff)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliff2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTitle.Font = new System.Drawing.Font("Lithos Pro Regular", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitle.Location = new System.Drawing.Point(30, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(524, 72);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Falling Objects";
            this.lblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.AutoSize = true;
            this.lblMadeBy.Font = new System.Drawing.Font("League Spartan", 30F, System.Drawing.FontStyle.Bold);
            this.lblMadeBy.Location = new System.Drawing.Point(90, 176);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(366, 50);
            this.lblMadeBy.TabIndex = 1;
            this.lblMadeBy.Text = "Made by Linh Ho";
            this.lblMadeBy.Click += new System.EventHandler(this.LblMadeBy_Click);
            // 
            // imgCliff
            // 
            this.imgCliff.Image = ((System.Drawing.Image)(resources.GetObject("imgCliff.Image")));
            this.imgCliff.Location = new System.Drawing.Point(585, 41);
            this.imgCliff.Name = "imgCliff";
            this.imgCliff.Size = new System.Drawing.Size(203, 397);
            this.imgCliff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCliff.TabIndex = 2;
            this.imgCliff.TabStop = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(180, 242);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(187, 38);
            this.btnNextPage.TabIndex = 3;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 40);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(595, 156);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Enter the amount of time (in seconds)\r\n\r\n\r\n\r\n";
            this.lblQuestion.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(490, 82);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(155, 40);
            this.txtTime.TabIndex = 6;
            this.txtTime.TextChanged += new System.EventHandler(this.TxtAnswer_TextChanged);
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion2.Location = new System.Drawing.Point(12, 82);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(481, 39);
            this.lblQuestion2.TabIndex = 7;
            this.lblQuestion2.Text = "since the object was released:";
            this.lblQuestion2.Click += new System.EventHandler(this.LblQuestion2_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(180, 242);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(187, 38);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("League Spartan", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(6, 337);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(639, 34);
            this.lblAnswer.TabIndex = 9;
            this.lblAnswer.Text = "The height of the object above the ground is: ";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Ivory;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(13, 385);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(63, 33);
            this.lblHeight.TabIndex = 10;
            this.lblHeight.Text = "???";
            this.lblHeight.Click += new System.EventHandler(this.LblHeight_Click);
            // 
            // imgCliff2
            // 
            this.imgCliff2.BackColor = System.Drawing.Color.DarkBlue;
            this.imgCliff2.Image = ((System.Drawing.Image)(resources.GetObject("imgCliff2.Image")));
            this.imgCliff2.Location = new System.Drawing.Point(373, 128);
            this.imgCliff2.Name = "imgCliff2";
            this.imgCliff2.Size = new System.Drawing.Size(258, 206);
            this.imgCliff2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCliff2.TabIndex = 11;
            this.imgCliff2.TabStop = false;
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgCliff2);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.imgCliff);
            this.Controls.Add(this.lblMadeBy);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects";
            this.Load += new System.EventHandler(this.FrmFallingObjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCliff)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliff2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMadeBy;
        private System.Windows.Forms.PictureBox imgCliff;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.PictureBox imgCliff2;
    }
}

