namespace TAS_Stock
{
    partial class CashbookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashbookForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ddlPayment = new System.Windows.Forms.ComboBox();
            this.lblcashamount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcurrentOrderAmount = new System.Windows.Forms.Label();
            this.textBoxcashamount = new System.Windows.Forms.TextBox();
            this.textBoxcheckamount = new System.Windows.Forms.TextBox();
            this.lblcheckamount = new System.Windows.Forms.Label();
            this.textBoxBankName = new System.Windows.Forms.TextBox();
            this.lblbankname = new System.Windows.Forms.Label();
            this.textBoxcheque = new System.Windows.Forms.TextBox();
            this.lblcheckno = new System.Windows.Forms.Label();
            this.textBoxaccountTitle = new System.Windows.Forms.TextBox();
            this.lblAccountTitle = new System.Windows.Forms.Label();
            this.lblcheckdate = new System.Windows.Forms.Label();
            this.dtCheckDate = new System.Windows.Forms.DateTimePicker();
            this.BTN_Order = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.brnaddmore = new System.Windows.Forms.Button();
            this.dateTimePickerOrder1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxbanktitle1 = new System.Windows.Forms.TextBox();
            this.textBoxbankno1 = new System.Windows.Forms.TextBox();
            this.textBoxbankname1 = new System.Windows.Forms.TextBox();
            this.textBoxcheckAmount1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrder2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxbanktitle2 = new System.Windows.Forms.TextBox();
            this.textBoxbankno2 = new System.Windows.Forms.TextBox();
            this.textBoxbankname2 = new System.Windows.Forms.TextBox();
            this.textBoxcheckAmount2 = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrder3 = new System.Windows.Forms.DateTimePicker();
            this.textBoxbanktitle3 = new System.Windows.Forms.TextBox();
            this.textBoxbankno3 = new System.Windows.Forms.TextBox();
            this.textBoxbankname3 = new System.Windows.Forms.TextBox();
            this.textBoxcheckAmount3 = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrder4 = new System.Windows.Forms.DateTimePicker();
            this.textBoxbanktitle4 = new System.Windows.Forms.TextBox();
            this.textBoxbankno4 = new System.Windows.Forms.TextBox();
            this.textBoxbankname4 = new System.Windows.Forms.TextBox();
            this.textBoxcheckAmount4 = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrder5 = new System.Windows.Forms.DateTimePicker();
            this.textBoxbanktitle5 = new System.Windows.Forms.TextBox();
            this.textBoxbankno5 = new System.Windows.Forms.TextBox();
            this.textBoxbankname5 = new System.Windows.Forms.TextBox();
            this.textBoxcheckAmount5 = new System.Windows.Forms.TextBox();
            this.groupBoxmulticheque = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxmulticheque.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Type:";
            // 
            // ddlPayment
            // 
            this.ddlPayment.FormattingEnabled = true;
            this.ddlPayment.Items.AddRange(new object[] {
            "-- Select Payement Type --",
            "On-Credit",
            "On-Cheque",
            "On-Cash",
            "On-Cash & Cheque",
            "On-Cash & Credit"});
            this.ddlPayment.Location = new System.Drawing.Point(121, 128);
            this.ddlPayment.Name = "ddlPayment";
            this.ddlPayment.Size = new System.Drawing.Size(208, 21);
            this.ddlPayment.TabIndex = 1;
            this.ddlPayment.SelectedIndexChanged += new System.EventHandler(this.ddlPayment_SelectedIndexChanged);
            // 
            // lblcashamount
            // 
            this.lblcashamount.AutoSize = true;
            this.lblcashamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcashamount.Location = new System.Drawing.Point(27, 161);
            this.lblcashamount.Name = "lblcashamount";
            this.lblcashamount.Size = new System.Drawing.Size(85, 13);
            this.lblcashamount.TabIndex = 2;
            this.lblcashamount.Text = "Cash Amount:";
            this.lblcashamount.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order Amount:";
            // 
            // lblcurrentOrderAmount
            // 
            this.lblcurrentOrderAmount.AutoSize = true;
            this.lblcurrentOrderAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblcurrentOrderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrentOrderAmount.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblcurrentOrderAmount.Location = new System.Drawing.Point(267, 96);
            this.lblcurrentOrderAmount.Name = "lblcurrentOrderAmount";
            this.lblcurrentOrderAmount.Size = new System.Drawing.Size(27, 20);
            this.lblcurrentOrderAmount.TabIndex = 4;
            this.lblcurrentOrderAmount.Text = "---";
            // 
            // textBoxcashamount
            // 
            this.textBoxcashamount.Location = new System.Drawing.Point(121, 158);
            this.textBoxcashamount.Name = "textBoxcashamount";
            this.textBoxcashamount.Size = new System.Drawing.Size(208, 20);
            this.textBoxcashamount.TabIndex = 5;
            this.textBoxcashamount.Visible = false;
            // 
            // textBoxcheckamount
            // 
            this.textBoxcheckamount.Location = new System.Drawing.Point(299, 219);
            this.textBoxcheckamount.Name = "textBoxcheckamount";
            this.textBoxcheckamount.Size = new System.Drawing.Size(86, 20);
            this.textBoxcheckamount.TabIndex = 7;
            this.textBoxcheckamount.Visible = false;
            // 
            // lblcheckamount
            // 
            this.lblcheckamount.AutoSize = true;
            this.lblcheckamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckamount.Location = new System.Drawing.Point(297, 198);
            this.lblcheckamount.Name = "lblcheckamount";
            this.lblcheckamount.Size = new System.Drawing.Size(100, 13);
            this.lblcheckamount.TabIndex = 6;
            this.lblcheckamount.Text = "Cheque Amount:";
            this.lblcheckamount.Visible = false;
            // 
            // textBoxBankName
            // 
            this.textBoxBankName.Location = new System.Drawing.Point(390, 219);
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.Size = new System.Drawing.Size(193, 20);
            this.textBoxBankName.TabIndex = 9;
            this.textBoxBankName.Visible = false;
            // 
            // lblbankname
            // 
            this.lblbankname.AutoSize = true;
            this.lblbankname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbankname.Location = new System.Drawing.Point(435, 198);
            this.lblbankname.Name = "lblbankname";
            this.lblbankname.Size = new System.Drawing.Size(76, 13);
            this.lblbankname.TabIndex = 8;
            this.lblbankname.Text = "Bank Name:";
            this.lblbankname.Visible = false;
            // 
            // textBoxcheque
            // 
            this.textBoxcheque.Location = new System.Drawing.Point(588, 219);
            this.textBoxcheque.Name = "textBoxcheque";
            this.textBoxcheque.Size = new System.Drawing.Size(86, 20);
            this.textBoxcheque.TabIndex = 11;
            this.textBoxcheque.Visible = false;
            // 
            // lblcheckno
            // 
            this.lblcheckno.AutoSize = true;
            this.lblcheckno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckno.Location = new System.Drawing.Point(590, 198);
            this.lblcheckno.Name = "lblcheckno";
            this.lblcheckno.Size = new System.Drawing.Size(74, 13);
            this.lblcheckno.TabIndex = 10;
            this.lblcheckno.Text = "Cheque No:";
            this.lblcheckno.Visible = false;
            // 
            // textBoxaccountTitle
            // 
            this.textBoxaccountTitle.Location = new System.Drawing.Point(680, 219);
            this.textBoxaccountTitle.Name = "textBoxaccountTitle";
            this.textBoxaccountTitle.Size = new System.Drawing.Size(177, 20);
            this.textBoxaccountTitle.TabIndex = 13;
            this.textBoxaccountTitle.Visible = false;
            // 
            // lblAccountTitle
            // 
            this.lblAccountTitle.AutoSize = true;
            this.lblAccountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountTitle.Location = new System.Drawing.Point(715, 198);
            this.lblAccountTitle.Name = "lblAccountTitle";
            this.lblAccountTitle.Size = new System.Drawing.Size(87, 13);
            this.lblAccountTitle.TabIndex = 12;
            this.lblAccountTitle.Text = "Account Title:";
            this.lblAccountTitle.Visible = false;
            // 
            // lblcheckdate
            // 
            this.lblcheckdate.AutoSize = true;
            this.lblcheckdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckdate.Location = new System.Drawing.Point(126, 198);
            this.lblcheckdate.Name = "lblcheckdate";
            this.lblcheckdate.Size = new System.Drawing.Size(85, 13);
            this.lblcheckdate.TabIndex = 14;
            this.lblcheckdate.Text = "Cheque Date:";
            this.lblcheckdate.Visible = false;
            // 
            // dtCheckDate
            // 
            this.dtCheckDate.Location = new System.Drawing.Point(81, 219);
            this.dtCheckDate.Name = "dtCheckDate";
            this.dtCheckDate.Size = new System.Drawing.Size(211, 20);
            this.dtCheckDate.TabIndex = 15;
            this.dtCheckDate.Visible = false;
            // 
            // BTN_Order
            // 
            this.BTN_Order.BackColor = System.Drawing.Color.Black;
            this.BTN_Order.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_Order.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_Order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Order.ForeColor = System.Drawing.Color.White;
            this.BTN_Order.Location = new System.Drawing.Point(720, 403);
            this.BTN_Order.Name = "BTN_Order";
            this.BTN_Order.Size = new System.Drawing.Size(137, 30);
            this.BTN_Order.TabIndex = 16;
            this.BTN_Order.Text = "Confirm Order";
            this.BTN_Order.UseVisualStyleBackColor = false;
            this.BTN_Order.Visible = false;
            this.BTN_Order.Click += new System.EventHandler(this.BTN_Order_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(632, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brnaddmore
            // 
            this.brnaddmore.BackColor = System.Drawing.Color.DodgerBlue;
            this.brnaddmore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.brnaddmore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.brnaddmore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.brnaddmore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnaddmore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnaddmore.ForeColor = System.Drawing.Color.White;
            this.brnaddmore.Location = new System.Drawing.Point(18, 213);
            this.brnaddmore.Name = "brnaddmore";
            this.brnaddmore.Size = new System.Drawing.Size(40, 30);
            this.brnaddmore.TabIndex = 18;
            this.brnaddmore.Text = "+";
            this.brnaddmore.UseVisualStyleBackColor = false;
            this.brnaddmore.Visible = false;
            this.brnaddmore.Click += new System.EventHandler(this.brnaddmore_Click);
            // 
            // dateTimePickerOrder1
            // 
            this.dateTimePickerOrder1.Location = new System.Drawing.Point(37, 16);
            this.dateTimePickerOrder1.Name = "dateTimePickerOrder1";
            this.dateTimePickerOrder1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerOrder1.TabIndex = 23;
            // 
            // textBoxbanktitle1
            // 
            this.textBoxbanktitle1.Location = new System.Drawing.Point(621, 16);
            this.textBoxbanktitle1.Name = "textBoxbanktitle1";
            this.textBoxbanktitle1.Size = new System.Drawing.Size(176, 20);
            this.textBoxbanktitle1.TabIndex = 22;
            // 
            // textBoxbankno1
            // 
            this.textBoxbankno1.Location = new System.Drawing.Point(527, 16);
            this.textBoxbankno1.Name = "textBoxbankno1";
            this.textBoxbankno1.Size = new System.Drawing.Size(86, 20);
            this.textBoxbankno1.TabIndex = 21;
            // 
            // textBoxbankname1
            // 
            this.textBoxbankname1.Location = new System.Drawing.Point(329, 16);
            this.textBoxbankname1.Name = "textBoxbankname1";
            this.textBoxbankname1.Size = new System.Drawing.Size(193, 20);
            this.textBoxbankname1.TabIndex = 20;
            // 
            // textBoxcheckAmount1
            // 
            this.textBoxcheckAmount1.Location = new System.Drawing.Point(238, 16);
            this.textBoxcheckAmount1.Name = "textBoxcheckAmount1";
            this.textBoxcheckAmount1.Size = new System.Drawing.Size(86, 20);
            this.textBoxcheckAmount1.TabIndex = 19;
            // 
            // dateTimePickerOrder2
            // 
            this.dateTimePickerOrder2.Location = new System.Drawing.Point(38, 42);
            this.dateTimePickerOrder2.Name = "dateTimePickerOrder2";
            this.dateTimePickerOrder2.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerOrder2.TabIndex = 28;
            // 
            // textBoxbanktitle2
            // 
            this.textBoxbanktitle2.Location = new System.Drawing.Point(620, 42);
            this.textBoxbanktitle2.Name = "textBoxbanktitle2";
            this.textBoxbanktitle2.Size = new System.Drawing.Size(176, 20);
            this.textBoxbanktitle2.TabIndex = 27;
            // 
            // textBoxbankno2
            // 
            this.textBoxbankno2.Location = new System.Drawing.Point(528, 42);
            this.textBoxbankno2.Name = "textBoxbankno2";
            this.textBoxbankno2.Size = new System.Drawing.Size(86, 20);
            this.textBoxbankno2.TabIndex = 26;
            // 
            // textBoxbankname2
            // 
            this.textBoxbankname2.Location = new System.Drawing.Point(330, 42);
            this.textBoxbankname2.Name = "textBoxbankname2";
            this.textBoxbankname2.Size = new System.Drawing.Size(193, 20);
            this.textBoxbankname2.TabIndex = 25;
            // 
            // textBoxcheckAmount2
            // 
            this.textBoxcheckAmount2.Location = new System.Drawing.Point(239, 42);
            this.textBoxcheckAmount2.Name = "textBoxcheckAmount2";
            this.textBoxcheckAmount2.Size = new System.Drawing.Size(86, 20);
            this.textBoxcheckAmount2.TabIndex = 24;
            // 
            // dateTimePickerOrder3
            // 
            this.dateTimePickerOrder3.Location = new System.Drawing.Point(38, 68);
            this.dateTimePickerOrder3.Name = "dateTimePickerOrder3";
            this.dateTimePickerOrder3.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerOrder3.TabIndex = 33;
            // 
            // textBoxbanktitle3
            // 
            this.textBoxbanktitle3.Location = new System.Drawing.Point(620, 68);
            this.textBoxbanktitle3.Name = "textBoxbanktitle3";
            this.textBoxbanktitle3.Size = new System.Drawing.Size(176, 20);
            this.textBoxbanktitle3.TabIndex = 32;
            // 
            // textBoxbankno3
            // 
            this.textBoxbankno3.Location = new System.Drawing.Point(528, 68);
            this.textBoxbankno3.Name = "textBoxbankno3";
            this.textBoxbankno3.Size = new System.Drawing.Size(86, 20);
            this.textBoxbankno3.TabIndex = 31;
            // 
            // textBoxbankname3
            // 
            this.textBoxbankname3.Location = new System.Drawing.Point(330, 68);
            this.textBoxbankname3.Name = "textBoxbankname3";
            this.textBoxbankname3.Size = new System.Drawing.Size(193, 20);
            this.textBoxbankname3.TabIndex = 30;
            // 
            // textBoxcheckAmount3
            // 
            this.textBoxcheckAmount3.Location = new System.Drawing.Point(239, 68);
            this.textBoxcheckAmount3.Name = "textBoxcheckAmount3";
            this.textBoxcheckAmount3.Size = new System.Drawing.Size(86, 20);
            this.textBoxcheckAmount3.TabIndex = 29;
            // 
            // dateTimePickerOrder4
            // 
            this.dateTimePickerOrder4.Location = new System.Drawing.Point(38, 94);
            this.dateTimePickerOrder4.Name = "dateTimePickerOrder4";
            this.dateTimePickerOrder4.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerOrder4.TabIndex = 38;
            // 
            // textBoxbanktitle4
            // 
            this.textBoxbanktitle4.Location = new System.Drawing.Point(620, 94);
            this.textBoxbanktitle4.Name = "textBoxbanktitle4";
            this.textBoxbanktitle4.Size = new System.Drawing.Size(176, 20);
            this.textBoxbanktitle4.TabIndex = 37;
            // 
            // textBoxbankno4
            // 
            this.textBoxbankno4.Location = new System.Drawing.Point(528, 94);
            this.textBoxbankno4.Name = "textBoxbankno4";
            this.textBoxbankno4.Size = new System.Drawing.Size(86, 20);
            this.textBoxbankno4.TabIndex = 36;
            // 
            // textBoxbankname4
            // 
            this.textBoxbankname4.Location = new System.Drawing.Point(330, 94);
            this.textBoxbankname4.Name = "textBoxbankname4";
            this.textBoxbankname4.Size = new System.Drawing.Size(193, 20);
            this.textBoxbankname4.TabIndex = 35;
            // 
            // textBoxcheckAmount4
            // 
            this.textBoxcheckAmount4.Location = new System.Drawing.Point(239, 94);
            this.textBoxcheckAmount4.Name = "textBoxcheckAmount4";
            this.textBoxcheckAmount4.Size = new System.Drawing.Size(86, 20);
            this.textBoxcheckAmount4.TabIndex = 34;
            // 
            // dateTimePickerOrder5
            // 
            this.dateTimePickerOrder5.Location = new System.Drawing.Point(37, 120);
            this.dateTimePickerOrder5.Name = "dateTimePickerOrder5";
            this.dateTimePickerOrder5.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerOrder5.TabIndex = 43;
            // 
            // textBoxbanktitle5
            // 
            this.textBoxbanktitle5.Location = new System.Drawing.Point(619, 120);
            this.textBoxbanktitle5.Name = "textBoxbanktitle5";
            this.textBoxbanktitle5.Size = new System.Drawing.Size(176, 20);
            this.textBoxbanktitle5.TabIndex = 42;
            // 
            // textBoxbankno5
            // 
            this.textBoxbankno5.Location = new System.Drawing.Point(527, 120);
            this.textBoxbankno5.Name = "textBoxbankno5";
            this.textBoxbankno5.Size = new System.Drawing.Size(86, 20);
            this.textBoxbankno5.TabIndex = 41;
            // 
            // textBoxbankname5
            // 
            this.textBoxbankname5.Location = new System.Drawing.Point(329, 120);
            this.textBoxbankname5.Name = "textBoxbankname5";
            this.textBoxbankname5.Size = new System.Drawing.Size(193, 20);
            this.textBoxbankname5.TabIndex = 40;
            // 
            // textBoxcheckAmount5
            // 
            this.textBoxcheckAmount5.Location = new System.Drawing.Point(238, 120);
            this.textBoxcheckAmount5.Name = "textBoxcheckAmount5";
            this.textBoxcheckAmount5.Size = new System.Drawing.Size(86, 20);
            this.textBoxcheckAmount5.TabIndex = 39;
            // 
            // groupBoxmulticheque
            // 
            this.groupBoxmulticheque.Controls.Add(this.label5);
            this.groupBoxmulticheque.Controls.Add(this.label8);
            this.groupBoxmulticheque.Controls.Add(this.label7);
            this.groupBoxmulticheque.Controls.Add(this.label6);
            this.groupBoxmulticheque.Controls.Add(this.label4);
            this.groupBoxmulticheque.Controls.Add(this.label2);
            this.groupBoxmulticheque.Controls.Add(this.dateTimePickerOrder1);
            this.groupBoxmulticheque.Controls.Add(this.dateTimePickerOrder5);
            this.groupBoxmulticheque.Controls.Add(this.textBoxcheckAmount1);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbanktitle5);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbankname1);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbankno5);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbankno1);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbankname5);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbanktitle1);
            this.groupBoxmulticheque.Controls.Add(this.textBoxcheckAmount5);
            this.groupBoxmulticheque.Controls.Add(this.textBoxcheckAmount2);
            this.groupBoxmulticheque.Controls.Add(this.dateTimePickerOrder4);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbankname2);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbanktitle4);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbankno2);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbankno4);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbanktitle2);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbankname4);
            this.groupBoxmulticheque.Controls.Add(this.dateTimePickerOrder2);
            this.groupBoxmulticheque.Controls.Add(this.textBoxcheckAmount4);
            this.groupBoxmulticheque.Controls.Add(this.textBoxcheckAmount3);
            this.groupBoxmulticheque.Controls.Add(this.dateTimePickerOrder3);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbankname3);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbanktitle3);
            this.groupBoxmulticheque.Controls.Add(this.textBoxbankno3);
            this.groupBoxmulticheque.Location = new System.Drawing.Point(62, 245);
            this.groupBoxmulticheque.Name = "groupBoxmulticheque";
            this.groupBoxmulticheque.Size = new System.Drawing.Size(831, 152);
            this.groupBoxmulticheque.TabIndex = 44;
            this.groupBoxmulticheque.TabStop = false;
            this.groupBoxmulticheque.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "6:";
            this.label5.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "5:";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "4:";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "3:";
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "2:";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-50, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "1.";
            this.label2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 68);
            this.panel1.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(252, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 36);
            this.label9.TabIndex = 0;
            this.label9.Text = "Add Payment For Order ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(1, -94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 723);
            this.panel2.TabIndex = 57;
            // 
            // CashbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 437);
            this.Controls.Add(this.lblcurrentOrderAmount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxmulticheque);
            this.Controls.Add(this.brnaddmore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Order);
            this.Controls.Add(this.dtCheckDate);
            this.Controls.Add(this.lblcheckdate);
            this.Controls.Add(this.textBoxaccountTitle);
            this.Controls.Add(this.lblAccountTitle);
            this.Controls.Add(this.textBoxcheque);
            this.Controls.Add(this.lblcheckno);
            this.Controls.Add(this.textBoxBankName);
            this.Controls.Add(this.lblbankname);
            this.Controls.Add(this.textBoxcheckamount);
            this.Controls.Add(this.lblcheckamount);
            this.Controls.Add(this.textBoxcashamount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblcashamount);
            this.Controls.Add(this.ddlPayment);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashbookForm";
            this.Text = "CashbookForm";
            this.Load += new System.EventHandler(this.CashbookForm_Load);
            this.groupBoxmulticheque.ResumeLayout(false);
            this.groupBoxmulticheque.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcashamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcurrentOrderAmount;
        private System.Windows.Forms.Label lblcheckamount;
        private System.Windows.Forms.Label lblbankname;
        private System.Windows.Forms.Label lblcheckno;
        private System.Windows.Forms.Label lblAccountTitle;
        private System.Windows.Forms.Label lblcheckdate;
        private System.Windows.Forms.Button BTN_Order;
        public System.Windows.Forms.ComboBox ddlPayment;
        public System.Windows.Forms.TextBox textBoxcashamount;
        public System.Windows.Forms.TextBox textBoxcheckamount;
        public System.Windows.Forms.TextBox textBoxBankName;
        public System.Windows.Forms.TextBox textBoxcheque;
        public System.Windows.Forms.TextBox textBoxaccountTitle;
        public System.Windows.Forms.DateTimePicker dtCheckDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button brnaddmore;
        public System.Windows.Forms.DateTimePicker dateTimePickerOrder1;
        public System.Windows.Forms.TextBox textBoxbanktitle1;
        public System.Windows.Forms.TextBox textBoxbankno1;
        public System.Windows.Forms.TextBox textBoxbankname1;
        public System.Windows.Forms.TextBox textBoxcheckAmount1;
        public System.Windows.Forms.DateTimePicker dateTimePickerOrder2;
        public System.Windows.Forms.TextBox textBoxbanktitle2;
        public System.Windows.Forms.TextBox textBoxbankno2;
        public System.Windows.Forms.TextBox textBoxbankname2;
        public System.Windows.Forms.TextBox textBoxcheckAmount2;
        public System.Windows.Forms.DateTimePicker dateTimePickerOrder3;
        public System.Windows.Forms.TextBox textBoxbanktitle3;
        public System.Windows.Forms.TextBox textBoxbankno3;
        public System.Windows.Forms.TextBox textBoxbankname3;
        public System.Windows.Forms.TextBox textBoxcheckAmount3;
        public System.Windows.Forms.DateTimePicker dateTimePickerOrder4;
        public System.Windows.Forms.TextBox textBoxbanktitle4;
        public System.Windows.Forms.TextBox textBoxbankno4;
        public System.Windows.Forms.TextBox textBoxbankname4;
        public System.Windows.Forms.TextBox textBoxcheckAmount4;
        public System.Windows.Forms.DateTimePicker dateTimePickerOrder5;
        public System.Windows.Forms.TextBox textBoxbanktitle5;
        public System.Windows.Forms.TextBox textBoxbankno5;
        public System.Windows.Forms.TextBox textBoxbankname5;
        public System.Windows.Forms.TextBox textBoxcheckAmount5;
        private System.Windows.Forms.GroupBox groupBoxmulticheque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}