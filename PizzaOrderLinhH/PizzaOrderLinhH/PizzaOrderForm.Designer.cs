namespace PizzaOrderLinhH
{
    partial class frmPizzaOrder
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblExtraLarge = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.lblSmall = new System.Windows.Forms.Label();
            this.grbTotal = new System.Windows.Forms.GroupBox();
            this.lblTipsAnswer = new System.Windows.Forms.Label();
            this.lblTips = new System.Windows.Forms.Label();
            this.lblDonationAnswer = new System.Windows.Forms.Label();
            this.lblDonation = new System.Windows.Forms.Label();
            this.lblTotalAnswer = new System.Windows.Forms.Label();
            this.lblTaxAnswer = new System.Windows.Forms.Label();
            this.lblSubtotalAnswer = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.nudToppings = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTopping3 = new System.Windows.Forms.Label();
            this.lblTopping2 = new System.Windows.Forms.Label();
            this.lblTopping1 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.grbSoda = new System.Windows.Forms.GroupBox();
            this.nudSoda = new System.Windows.Forms.NumericUpDown();
            this.lblOneSoda = new System.Windows.Forms.Label();
            this.lblNoSoda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbDelivery = new System.Windows.Forms.GroupBox();
            this.nudDelivery = new System.Windows.Forms.NumericUpDown();
            this.lblYesDelivery = new System.Windows.Forms.Label();
            this.lblNoDelivery = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grbTax = new System.Windows.Forms.GroupBox();
            this.nudTax = new System.Windows.Forms.NumericUpDown();
            this.lblGstTax = new System.Windows.Forms.Label();
            this.lblHstTax = new System.Windows.Forms.Label();
            this.lblTaxQuestion = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picConfirm = new System.Windows.Forms.PictureBox();
            this.picPizzaNext = new System.Windows.Forms.PictureBox();
            this.picPizza = new System.Windows.Forms.PictureBox();
            this.grbDonation = new System.Windows.Forms.GroupBox();
            this.lblYesDonation = new System.Windows.Forms.Label();
            this.lblNoDonation = new System.Windows.Forms.Label();
            this.nudDonation = new System.Windows.Forms.NumericUpDown();
            this.lblDonationQuestion = new System.Windows.Forms.Label();
            this.grbTips = new System.Windows.Forms.GroupBox();
            this.lblThreeDollarTip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTips = new System.Windows.Forms.NumericUpDown();
            this.lblOneDollarTip = new System.Windows.Forms.Label();
            this.lblNoTip = new System.Windows.Forms.Label();
            this.lblTipsQuestion = new System.Windows.Forms.Label();
            this.grbSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.grbTotal.SuspendLayout();
            this.grbToppings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
            this.grbSoda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoda)).BeginInit();
            this.grbDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelivery)).BeginInit();
            this.grbTax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            this.grbDonation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonation)).BeginInit();
            this.grbTips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTips)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(92, 154);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(572, 73);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Von Dough\'s Pizza";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(307, 244);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 43);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(238, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(318, 25);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome to Von Dough\'s Pizza!";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 16);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(125, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "What size for your pizza?";
            // 
            // grbSize
            // 
            this.grbSize.Controls.Add(this.nudSize);
            this.grbSize.Controls.Add(this.lblExtraLarge);
            this.grbSize.Controls.Add(this.lblLarge);
            this.grbSize.Controls.Add(this.lblSmall);
            this.grbSize.Controls.Add(this.lblSize);
            this.grbSize.Location = new System.Drawing.Point(25, 57);
            this.grbSize.Name = "grbSize";
            this.grbSize.Size = new System.Drawing.Size(208, 114);
            this.grbSize.TabIndex = 5;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Size";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(142, 14);
            this.nudSize.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(31, 20);
            this.nudSize.TabIndex = 8;
            this.nudSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblExtraLarge
            // 
            this.lblExtraLarge.AutoSize = true;
            this.lblExtraLarge.Location = new System.Drawing.Point(6, 87);
            this.lblExtraLarge.Name = "lblExtraLarge";
            this.lblExtraLarge.Size = new System.Drawing.Size(121, 13);
            this.lblExtraLarge.TabIndex = 7;
            this.lblExtraLarge.Text = "3 = Extra Large ($12.99)";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Location = new System.Drawing.Point(6, 63);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(88, 13);
            this.lblLarge.TabIndex = 6;
            this.lblLarge.Text = "2 = Large ($9.99)";
            // 
            // lblSmall
            // 
            this.lblSmall.AutoSize = true;
            this.lblSmall.Location = new System.Drawing.Point(6, 38);
            this.lblSmall.Name = "lblSmall";
            this.lblSmall.Size = new System.Drawing.Size(98, 13);
            this.lblSmall.TabIndex = 5;
            this.lblSmall.Text = "1 = Medium ($6.99)";
            this.lblSmall.Click += new System.EventHandler(this.Label1_Click);
            // 
            // grbTotal
            // 
            this.grbTotal.Controls.Add(this.lblTipsAnswer);
            this.grbTotal.Controls.Add(this.lblTips);
            this.grbTotal.Controls.Add(this.lblDonationAnswer);
            this.grbTotal.Controls.Add(this.lblDonation);
            this.grbTotal.Controls.Add(this.lblTotalAnswer);
            this.grbTotal.Controls.Add(this.lblTaxAnswer);
            this.grbTotal.Controls.Add(this.lblSubtotalAnswer);
            this.grbTotal.Controls.Add(this.lblTotal);
            this.grbTotal.Controls.Add(this.lblTax);
            this.grbTotal.Controls.Add(this.lblSubtotal);
            this.grbTotal.Location = new System.Drawing.Point(255, 129);
            this.grbTotal.Name = "grbTotal";
            this.grbTotal.Size = new System.Drawing.Size(301, 175);
            this.grbTotal.TabIndex = 11;
            this.grbTotal.TabStop = false;
            this.grbTotal.Text = "Reciept";
            // 
            // lblTipsAnswer
            // 
            this.lblTipsAnswer.AutoSize = true;
            this.lblTipsAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipsAnswer.Location = new System.Drawing.Point(145, 90);
            this.lblTipsAnswer.Name = "lblTipsAnswer";
            this.lblTipsAnswer.Size = new System.Drawing.Size(70, 25);
            this.lblTipsAnswer.TabIndex = 9;
            this.lblTipsAnswer.Text = "label2";
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTips.Location = new System.Drawing.Point(74, 90);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(59, 25);
            this.lblTips.TabIndex = 8;
            this.lblTips.Text = "Tips:";
            // 
            // lblDonationAnswer
            // 
            this.lblDonationAnswer.AutoSize = true;
            this.lblDonationAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonationAnswer.Location = new System.Drawing.Point(145, 65);
            this.lblDonationAnswer.Name = "lblDonationAnswer";
            this.lblDonationAnswer.Size = new System.Drawing.Size(70, 25);
            this.lblDonationAnswer.TabIndex = 7;
            this.lblDonationAnswer.Text = "label2";
            // 
            // lblDonation
            // 
            this.lblDonation.AutoSize = true;
            this.lblDonation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonation.Location = new System.Drawing.Point(29, 65);
            this.lblDonation.Name = "lblDonation";
            this.lblDonation.Size = new System.Drawing.Size(104, 25);
            this.lblDonation.TabIndex = 6;
            this.lblDonation.Text = "Donation:";
            // 
            // lblTotalAnswer
            // 
            this.lblTotalAnswer.AutoSize = true;
            this.lblTotalAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAnswer.Location = new System.Drawing.Point(146, 130);
            this.lblTotalAnswer.Name = "lblTotalAnswer";
            this.lblTotalAnswer.Size = new System.Drawing.Size(70, 25);
            this.lblTotalAnswer.TabIndex = 5;
            this.lblTotalAnswer.Text = "label2";
            // 
            // lblTaxAnswer
            // 
            this.lblTaxAnswer.AutoSize = true;
            this.lblTaxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAnswer.Location = new System.Drawing.Point(145, 40);
            this.lblTaxAnswer.Name = "lblTaxAnswer";
            this.lblTaxAnswer.Size = new System.Drawing.Size(70, 25);
            this.lblTaxAnswer.TabIndex = 4;
            this.lblTaxAnswer.Text = "label2";
            // 
            // lblSubtotalAnswer
            // 
            this.lblSubtotalAnswer.AutoSize = true;
            this.lblSubtotalAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalAnswer.Location = new System.Drawing.Point(145, 15);
            this.lblSubtotalAnswer.Name = "lblSubtotalAnswer";
            this.lblSubtotalAnswer.Size = new System.Drawing.Size(70, 25);
            this.lblSubtotalAnswer.TabIndex = 3;
            this.lblSubtotalAnswer.Text = "label2";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(73, 130);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 25);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(79, 40);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(54, 25);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(51, 16);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(82, 24);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.nudToppings);
            this.grbToppings.Controls.Add(this.label1);
            this.grbToppings.Controls.Add(this.lblTopping3);
            this.grbToppings.Controls.Add(this.lblTopping2);
            this.grbToppings.Controls.Add(this.lblTopping1);
            this.grbToppings.Controls.Add(this.lblToppings);
            this.grbToppings.Location = new System.Drawing.Point(25, 177);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(208, 130);
            this.grbToppings.TabIndex = 8;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // nudToppings
            // 
            this.nudToppings.Location = new System.Drawing.Point(171, 14);
            this.nudToppings.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudToppings.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToppings.Name = "nudToppings";
            this.nudToppings.Size = new System.Drawing.Size(31, 20);
            this.nudToppings.TabIndex = 9;
            this.nudToppings.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "4 = 4 Toppings ($2.75)";
            // 
            // lblTopping3
            // 
            this.lblTopping3.AutoSize = true;
            this.lblTopping3.Location = new System.Drawing.Point(6, 87);
            this.lblTopping3.Name = "lblTopping3";
            this.lblTopping3.Size = new System.Drawing.Size(114, 13);
            this.lblTopping3.TabIndex = 7;
            this.lblTopping3.Text = "3 = 3 Toppings ($2.15)";
            // 
            // lblTopping2
            // 
            this.lblTopping2.AutoSize = true;
            this.lblTopping2.Location = new System.Drawing.Point(6, 63);
            this.lblTopping2.Name = "lblTopping2";
            this.lblTopping2.Size = new System.Drawing.Size(114, 13);
            this.lblTopping2.TabIndex = 6;
            this.lblTopping2.Text = "2 = 2 Toppings ($1.35)";
            // 
            // lblTopping1
            // 
            this.lblTopping1.AutoSize = true;
            this.lblTopping1.Location = new System.Drawing.Point(6, 38);
            this.lblTopping1.Name = "lblTopping1";
            this.lblTopping1.Size = new System.Drawing.Size(109, 13);
            this.lblTopping1.TabIndex = 5;
            this.lblTopping1.Text = "1 = 1 Topping ($0.75)";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(6, 16);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(167, 13);
            this.lblToppings.TabIndex = 4;
            this.lblToppings.Text = "How many toppings do you want?";
            // 
            // grbSoda
            // 
            this.grbSoda.Controls.Add(this.nudSoda);
            this.grbSoda.Controls.Add(this.lblOneSoda);
            this.grbSoda.Controls.Add(this.lblNoSoda);
            this.grbSoda.Controls.Add(this.label5);
            this.grbSoda.Location = new System.Drawing.Point(25, 313);
            this.grbSoda.Name = "grbSoda";
            this.grbSoda.Size = new System.Drawing.Size(208, 85);
            this.grbSoda.TabIndex = 8;
            this.grbSoda.TabStop = false;
            this.grbSoda.Text = "Soda";
            // 
            // nudSoda
            // 
            this.nudSoda.Location = new System.Drawing.Point(111, 14);
            this.nudSoda.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoda.Name = "nudSoda";
            this.nudSoda.Size = new System.Drawing.Size(31, 20);
            this.nudSoda.TabIndex = 10;
            // 
            // lblOneSoda
            // 
            this.lblOneSoda.AutoSize = true;
            this.lblOneSoda.Location = new System.Drawing.Point(6, 63);
            this.lblOneSoda.Name = "lblOneSoda";
            this.lblOneSoda.Size = new System.Drawing.Size(109, 13);
            this.lblOneSoda.TabIndex = 6;
            this.lblOneSoda.Text = "1 = One Soda ($1.00)";
            // 
            // lblNoSoda
            // 
            this.lblNoSoda.AutoSize = true;
            this.lblNoSoda.Location = new System.Drawing.Point(6, 38);
            this.lblNoSoda.Name = "lblNoSoda";
            this.lblNoSoda.Size = new System.Drawing.Size(70, 13);
            this.lblNoSoda.TabIndex = 5;
            this.lblNoSoda.Text = "0 = No Soda ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Do you want soda?";
            // 
            // grbDelivery
            // 
            this.grbDelivery.Controls.Add(this.nudDelivery);
            this.grbDelivery.Controls.Add(this.lblYesDelivery);
            this.grbDelivery.Controls.Add(this.lblNoDelivery);
            this.grbDelivery.Controls.Add(this.lblDelivery);
            this.grbDelivery.Location = new System.Drawing.Point(258, 57);
            this.grbDelivery.Name = "grbDelivery";
            this.grbDelivery.Size = new System.Drawing.Size(208, 85);
            this.grbDelivery.TabIndex = 9;
            this.grbDelivery.TabStop = false;
            this.grbDelivery.Text = "Delivery";
            // 
            // nudDelivery
            // 
            this.nudDelivery.Location = new System.Drawing.Point(130, 31);
            this.nudDelivery.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelivery.Name = "nudDelivery";
            this.nudDelivery.Size = new System.Drawing.Size(31, 20);
            this.nudDelivery.TabIndex = 11;
            this.nudDelivery.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblYesDelivery
            // 
            this.lblYesDelivery.AutoSize = true;
            this.lblYesDelivery.Location = new System.Drawing.Point(6, 63);
            this.lblYesDelivery.Name = "lblYesDelivery";
            this.lblYesDelivery.Size = new System.Drawing.Size(99, 13);
            this.lblYesDelivery.TabIndex = 6;
            this.lblYesDelivery.Text = "1 = Delivery ($3.00)";
            // 
            // lblNoDelivery
            // 
            this.lblNoDelivery.AutoSize = true;
            this.lblNoDelivery.Location = new System.Drawing.Point(6, 38);
            this.lblNoDelivery.Name = "lblNoDelivery";
            this.lblNoDelivery.Size = new System.Drawing.Size(83, 13);
            this.lblNoDelivery.TabIndex = 5;
            this.lblNoDelivery.Text = "0 = No Delivery ";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(6, 16);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(112, 13);
            this.lblDelivery.TabIndex = 4;
            this.lblDelivery.Text = "Do you want delivery?";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(550, 290);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(168, 52);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm order";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // grbTax
            // 
            this.grbTax.Controls.Add(this.nudTax);
            this.grbTax.Controls.Add(this.lblGstTax);
            this.grbTax.Controls.Add(this.lblHstTax);
            this.grbTax.Controls.Add(this.lblTaxQuestion);
            this.grbTax.Location = new System.Drawing.Point(258, 154);
            this.grbTax.Name = "grbTax";
            this.grbTax.Size = new System.Drawing.Size(223, 84);
            this.grbTax.TabIndex = 11;
            this.grbTax.TabStop = false;
            this.grbTax.Text = "Tax";
            // 
            // nudTax
            // 
            this.nudTax.Location = new System.Drawing.Point(159, 14);
            this.nudTax.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTax.Name = "nudTax";
            this.nudTax.Size = new System.Drawing.Size(31, 20);
            this.nudTax.TabIndex = 10;
            // 
            // lblGstTax
            // 
            this.lblGstTax.AutoSize = true;
            this.lblGstTax.Location = new System.Drawing.Point(6, 63);
            this.lblGstTax.Name = "lblGstTax";
            this.lblGstTax.Size = new System.Drawing.Size(71, 13);
            this.lblGstTax.TabIndex = 6;
            this.lblGstTax.Text = "1 = GST TAX";
            // 
            // lblHstTax
            // 
            this.lblHstTax.AutoSize = true;
            this.lblHstTax.Location = new System.Drawing.Point(6, 38);
            this.lblHstTax.Name = "lblHstTax";
            this.lblHstTax.Size = new System.Drawing.Size(71, 13);
            this.lblHstTax.TabIndex = 5;
            this.lblHstTax.Text = "0 = HST TAX";
            // 
            // lblTaxQuestion
            // 
            this.lblTaxQuestion.AutoSize = true;
            this.lblTaxQuestion.Location = new System.Drawing.Point(6, 16);
            this.lblTaxQuestion.Name = "lblTaxQuestion";
            this.lblTaxQuestion.Size = new System.Drawing.Size(146, 13);
            this.lblTaxQuestion.TabIndex = 4;
            this.lblTaxQuestion.Text = "Do you use GST or HST tax?";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(314, 333);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 26);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Order again!";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // picConfirm
            // 
            this.picConfirm.Image = global::PizzaOrderLinhH.Properties.Resources.confirm;
            this.picConfirm.Location = new System.Drawing.Point(-28, -51);
            this.picConfirm.Name = "picConfirm";
            this.picConfirm.Size = new System.Drawing.Size(980, 558);
            this.picConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConfirm.TabIndex = 14;
            this.picConfirm.TabStop = false;
            // 
            // picPizzaNext
            // 
            this.picPizzaNext.Image = global::PizzaOrderLinhH.Properties.Resources.pizza2;
            this.picPizzaNext.Location = new System.Drawing.Point(487, 88);
            this.picPizzaNext.Name = "picPizzaNext";
            this.picPizzaNext.Size = new System.Drawing.Size(288, 192);
            this.picPizzaNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizzaNext.TabIndex = 13;
            this.picPizzaNext.TabStop = false;
            // 
            // picPizza
            // 
            this.picPizza.Image = global::PizzaOrderLinhH.Properties.Resources.Background;
            this.picPizza.Location = new System.Drawing.Point(-10, -8);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(814, 462);
            this.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza.TabIndex = 2;
            this.picPizza.TabStop = false;
            // 
            // grbDonation
            // 
            this.grbDonation.Controls.Add(this.lblYesDonation);
            this.grbDonation.Controls.Add(this.lblNoDonation);
            this.grbDonation.Controls.Add(this.nudDonation);
            this.grbDonation.Controls.Add(this.lblDonationQuestion);
            this.grbDonation.Location = new System.Drawing.Point(258, 245);
            this.grbDonation.Name = "grbDonation";
            this.grbDonation.Size = new System.Drawing.Size(223, 100);
            this.grbDonation.TabIndex = 15;
            this.grbDonation.TabStop = false;
            this.grbDonation.Text = "Donation";
            // 
            // lblYesDonation
            // 
            this.lblYesDonation.AutoSize = true;
            this.lblYesDonation.Location = new System.Drawing.Point(25, 70);
            this.lblYesDonation.Name = "lblYesDonation";
            this.lblYesDonation.Size = new System.Drawing.Size(43, 13);
            this.lblYesDonation.TabIndex = 11;
            this.lblYesDonation.Text = "1 = Yes";
            // 
            // lblNoDonation
            // 
            this.lblNoDonation.AutoSize = true;
            this.lblNoDonation.Location = new System.Drawing.Point(25, 49);
            this.lblNoDonation.Name = "lblNoDonation";
            this.lblNoDonation.Size = new System.Drawing.Size(39, 13);
            this.lblNoDonation.TabIndex = 11;
            this.lblNoDonation.Text = "0 = No";
            // 
            // nudDonation
            // 
            this.nudDonation.Location = new System.Drawing.Point(140, 58);
            this.nudDonation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDonation.Name = "nudDonation";
            this.nudDonation.Size = new System.Drawing.Size(31, 20);
            this.nudDonation.TabIndex = 11;
            // 
            // lblDonationQuestion
            // 
            this.lblDonationQuestion.AutoSize = true;
            this.lblDonationQuestion.Location = new System.Drawing.Point(15, 17);
            this.lblDonationQuestion.Name = "lblDonationQuestion";
            this.lblDonationQuestion.Size = new System.Drawing.Size(179, 26);
            this.lblDonationQuestion.TabIndex = 11;
            this.lblDonationQuestion.Text = "Do you want to donate one dollar to \r\nShepard\'s Hope?";
            // 
            // grbTips
            // 
            this.grbTips.Controls.Add(this.lblThreeDollarTip);
            this.grbTips.Controls.Add(this.label2);
            this.grbTips.Controls.Add(this.nudTips);
            this.grbTips.Controls.Add(this.lblOneDollarTip);
            this.grbTips.Controls.Add(this.lblNoTip);
            this.grbTips.Controls.Add(this.lblTipsQuestion);
            this.grbTips.Location = new System.Drawing.Point(258, 351);
            this.grbTips.Name = "grbTips";
            this.grbTips.Size = new System.Drawing.Size(223, 87);
            this.grbTips.TabIndex = 11;
            this.grbTips.TabStop = false;
            this.grbTips.Text = "Tips";
            // 
            // lblThreeDollarTip
            // 
            this.lblThreeDollarTip.AutoSize = true;
            this.lblThreeDollarTip.Location = new System.Drawing.Point(118, 62);
            this.lblThreeDollarTip.Name = "lblThreeDollarTip";
            this.lblThreeDollarTip.Size = new System.Drawing.Size(76, 13);
            this.lblThreeDollarTip.TabIndex = 12;
            this.lblThreeDollarTip.Text = "3 = ($3.00 Tip)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "2 = ($2.00 Tip)";
            // 
            // nudTips
            // 
            this.nudTips.Location = new System.Drawing.Point(130, 14);
            this.nudTips.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudTips.Name = "nudTips";
            this.nudTips.Size = new System.Drawing.Size(31, 20);
            this.nudTips.TabIndex = 10;
            // 
            // lblOneDollarTip
            // 
            this.lblOneDollarTip.AutoSize = true;
            this.lblOneDollarTip.Location = new System.Drawing.Point(118, 38);
            this.lblOneDollarTip.Name = "lblOneDollarTip";
            this.lblOneDollarTip.Size = new System.Drawing.Size(76, 13);
            this.lblOneDollarTip.TabIndex = 6;
            this.lblOneDollarTip.Text = "1 = ($1.00 Tip)";
            // 
            // lblNoTip
            // 
            this.lblNoTip.AutoSize = true;
            this.lblNoTip.Location = new System.Drawing.Point(15, 38);
            this.lblNoTip.Name = "lblNoTip";
            this.lblNoTip.Size = new System.Drawing.Size(57, 13);
            this.lblNoTip.TabIndex = 5;
            this.lblNoTip.Text = "0 = No Tip";
            // 
            // lblTipsQuestion
            // 
            this.lblTipsQuestion.AutoSize = true;
            this.lblTipsQuestion.Location = new System.Drawing.Point(6, 16);
            this.lblTipsQuestion.Name = "lblTipsQuestion";
            this.lblTipsQuestion.Size = new System.Drawing.Size(115, 13);
            this.lblTipsQuestion.TabIndex = 4;
            this.lblTipsQuestion.Text = "Feel free to leave a tip!";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbTips);
            this.Controls.Add(this.grbDonation);
            this.Controls.Add(this.picConfirm);
            this.Controls.Add(this.picPizzaNext);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grbTotal);
            this.Controls.Add(this.grbTax);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grbDelivery);
            this.Controls.Add(this.grbSoda);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.grbSize);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.picPizza);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCompanyName);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order";
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.grbTotal.ResumeLayout(false);
            this.grbTotal.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
            this.grbSoda.ResumeLayout(false);
            this.grbSoda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoda)).EndInit();
            this.grbDelivery.ResumeLayout(false);
            this.grbDelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelivery)).EndInit();
            this.grbTax.ResumeLayout(false);
            this.grbTax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            this.grbDonation.ResumeLayout(false);
            this.grbDonation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonation)).EndInit();
            this.grbTips.ResumeLayout(false);
            this.grbTips.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picPizza;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.Label lblSmall;
        private System.Windows.Forms.Label lblExtraLarge;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTopping3;
        private System.Windows.Forms.Label lblTopping2;
        private System.Windows.Forms.Label lblTopping1;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.GroupBox grbSoda;
        private System.Windows.Forms.Label lblOneSoda;
        private System.Windows.Forms.Label lblNoSoda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbDelivery;
        private System.Windows.Forms.Label lblYesDelivery;
        private System.Windows.Forms.Label lblNoDelivery;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.NumericUpDown nudToppings;
        private System.Windows.Forms.NumericUpDown nudSoda;
        private System.Windows.Forms.NumericUpDown nudDelivery;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox grbTotal;
        private System.Windows.Forms.Label lblTotalAnswer;
        private System.Windows.Forms.Label lblTaxAnswer;
        private System.Windows.Forms.Label lblSubtotalAnswer;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.GroupBox grbTax;
        private System.Windows.Forms.NumericUpDown nudTax;
        private System.Windows.Forms.Label lblGstTax;
        private System.Windows.Forms.Label lblHstTax;
        private System.Windows.Forms.Label lblTaxQuestion;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picPizzaNext;
        private System.Windows.Forms.PictureBox picConfirm;
        private System.Windows.Forms.GroupBox grbDonation;
        private System.Windows.Forms.Label lblYesDonation;
        private System.Windows.Forms.Label lblNoDonation;
        private System.Windows.Forms.NumericUpDown nudDonation;
        private System.Windows.Forms.Label lblDonationQuestion;
        private System.Windows.Forms.Label lblDonationAnswer;
        private System.Windows.Forms.Label lblDonation;
        private System.Windows.Forms.Label lblTipsAnswer;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.GroupBox grbTips;
        private System.Windows.Forms.Label lblThreeDollarTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTips;
        private System.Windows.Forms.Label lblOneDollarTip;
        private System.Windows.Forms.Label lblNoTip;
        private System.Windows.Forms.Label lblTipsQuestion;
    }
}

