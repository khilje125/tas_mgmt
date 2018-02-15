namespace TAS_Stock
{
    partial class CustomerCashHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCashHistory));
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gvCustomerLedger = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtto = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_ADD_CATEGORY = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerVdate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.comboBoxCustomerLedger = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxVId = new System.Windows.Forms.MaskedTextBox();
            this.textBoxdescription = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCredit = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDebit = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblhiddenCashbookid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerLedger)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtfrom
            // 
            this.dtfrom.Location = new System.Drawing.Point(201, 343);
            this.dtfrom.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(194, 20);
            this.dtfrom.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date From : ";
            // 
            // gvCustomerLedger
            // 
            this.gvCustomerLedger.AllowUserToAddRows = false;
            this.gvCustomerLedger.AllowUserToDeleteRows = false;
            this.gvCustomerLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomerLedger.Location = new System.Drawing.Point(103, 392);
            this.gvCustomerLedger.Name = "gvCustomerLedger";
            this.gvCustomerLedger.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvCustomerLedger.Size = new System.Drawing.Size(646, 226);
            this.gvCustomerLedger.TabIndex = 13;
            this.gvCustomerLedger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCustomerLedger_CellContentClick);
            this.gvCustomerLedger.DoubleClick += new System.EventHandler(this.gvCustomerLedger_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Customer Name :";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.Location = new System.Drawing.Point(201, 309);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(413, 21);
            this.comboBoxCustomer.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 566);
            this.panel2.TabIndex = 21;
            // 
            // dtto
            // 
            this.dtto.Location = new System.Drawing.Point(420, 343);
            this.dtto.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtto.Name = "dtto";
            this.dtto.Size = new System.Drawing.Size(194, 20);
            this.dtto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "--";
            // 
            // BTN_ADD_CATEGORY
            // 
            this.BTN_ADD_CATEGORY.BackColor = System.Drawing.Color.Black;
            this.BTN_ADD_CATEGORY.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_ADD_CATEGORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_ADD_CATEGORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_ADD_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD_CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD_CATEGORY.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD_CATEGORY.Location = new System.Drawing.Point(620, 309);
            this.BTN_ADD_CATEGORY.Name = "BTN_ADD_CATEGORY";
            this.BTN_ADD_CATEGORY.Size = new System.Drawing.Size(74, 49);
            this.BTN_ADD_CATEGORY.TabIndex = 11;
            this.BTN_ADD_CATEGORY.Text = "Get Data";
            this.BTN_ADD_CATEGORY.UseVisualStyleBackColor = false;
            this.BTN_ADD_CATEGORY.Click += new System.EventHandler(this.BTN_ADD_CATEGORY_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Date From : ";
            // 
            // dateTimePickerVdate
            // 
            this.dateTimePickerVdate.Location = new System.Drawing.Point(23, 54);
            this.dateTimePickerVdate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerVdate.Name = "dateTimePickerVdate";
            this.dateTimePickerVdate.Size = new System.Drawing.Size(204, 20);
            this.dateTimePickerVdate.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.comboBoxCustomerLedger);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.buttonInsert);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maskedTextBoxVId);
            this.groupBox1.Controls.Add(this.textBoxdescription);
            this.groupBox1.Controls.Add(this.maskedTextBoxCredit);
            this.groupBox1.Controls.Add(this.maskedTextBoxDebit);
            this.groupBox1.Controls.Add(this.dateTimePickerVdate);
            this.groupBox1.Location = new System.Drawing.Point(103, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 187);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Customer Voucher";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Black;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(425, 143);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(113, 38);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // comboBoxCustomerLedger
            // 
            this.comboBoxCustomerLedger.Location = new System.Drawing.Point(233, 53);
            this.comboBoxCustomerLedger.Name = "comboBoxCustomerLedger";
            this.comboBoxCustomerLedger.Size = new System.Drawing.Size(305, 21);
            this.comboBoxCustomerLedger.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Customer Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Date :";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Black;
            this.buttonInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.buttonInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.buttonInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.ForeColor = System.Drawing.Color.White;
            this.buttonInsert.Location = new System.Drawing.Point(425, 142);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(113, 38);
            this.buttonInsert.TabIndex = 7;
            this.buttonInsert.Text = "Insert Entry";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Credit :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Debit :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Invoice No. :";
            // 
            // maskedTextBoxVId
            // 
            this.maskedTextBoxVId.Location = new System.Drawing.Point(302, 107);
            this.maskedTextBoxVId.Mask = "000000000000";
            this.maskedTextBoxVId.Name = "maskedTextBoxVId";
            this.maskedTextBoxVId.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBoxVId.TabIndex = 4;
            // 
            // textBoxdescription
            // 
            this.textBoxdescription.Location = new System.Drawing.Point(23, 107);
            this.textBoxdescription.Name = "textBoxdescription";
            this.textBoxdescription.Size = new System.Drawing.Size(273, 20);
            this.textBoxdescription.TabIndex = 3;
            // 
            // maskedTextBoxCredit
            // 
            this.maskedTextBoxCredit.Location = new System.Drawing.Point(460, 107);
            this.maskedTextBoxCredit.Name = "maskedTextBoxCredit";
            this.maskedTextBoxCredit.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBoxCredit.TabIndex = 6;
            // 
            // maskedTextBoxDebit
            // 
            this.maskedTextBoxDebit.Location = new System.Drawing.Point(376, 107);
            this.maskedTextBoxDebit.Name = "maskedTextBoxDebit";
            this.maskedTextBoxDebit.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBoxDebit.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(700, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generate Ledger";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblhiddenCashbookid
            // 
            this.lblhiddenCashbookid.AutoSize = true;
            this.lblhiddenCashbookid.Location = new System.Drawing.Point(16, 126);
            this.lblhiddenCashbookid.Name = "lblhiddenCashbookid";
            this.lblhiddenCashbookid.Size = new System.Drawing.Size(0, 13);
            this.lblhiddenCashbookid.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(229, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Ledger";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 83);
            this.panel1.TabIndex = 20;
            // 
            // CustomerCashHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 688);
            this.Controls.Add(this.lblhiddenCashbookid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_ADD_CATEGORY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvCustomerLedger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtfrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerCashHistory";
            this.Text = "Customer Ledger";
            this.Load += new System.EventHandler(this.CustomerCashHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerLedger)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtfrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvCustomerLedger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DateTimePicker dtto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_ADD_CATEGORY;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateTimePickerVdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVId;
        private System.Windows.Forms.TextBox textBoxdescription;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCredit;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDebit;
        private System.Windows.Forms.ComboBox comboBoxCustomerLedger;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblhiddenCashbookid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}