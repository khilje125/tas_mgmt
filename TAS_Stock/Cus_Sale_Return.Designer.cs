namespace TAS_Stock
{
    partial class Cus_Sale_Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cus_Sale_Return));
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.COMBO_CATEGORIES = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilterCategory = new System.Windows.Forms.TextBox();
            this.DGV_PRODUCTS = new System.Windows.Forms.DataGridView();
            this.DGV_CUSTOMER = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdiscoutrate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalInvoice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_SELECT_ALL = new System.Windows.Forms.CheckBox();
            this.BTN_DELETE_PRODUCTS = new System.Windows.Forms.Button();
            this.DGV_PRODUCTS_IN_ORDER = new System.Windows.Forms.DataGridView();
            this.BTN_INSERT_ORDER = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_ORDER)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Quick Filter :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(-4, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 723);
            this.panel2.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 35);
            this.panel1.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(398, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Customer Sale Return";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(115, 41);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(142, 20);
            this.txtCustomer.TabIndex = 64;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.COMBO_CATEGORIES);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFilterCategory);
            this.groupBox2.Controls.Add(this.DGV_PRODUCTS);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(439, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 223);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products Panel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 18);
            this.label13.TabIndex = 51;
            this.label13.Text = "Category :";
            // 
            // COMBO_CATEGORIES
            // 
            this.COMBO_CATEGORIES.BackColor = System.Drawing.Color.Black;
            this.COMBO_CATEGORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_CATEGORIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMBO_CATEGORIES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBO_CATEGORIES.ForeColor = System.Drawing.Color.White;
            this.COMBO_CATEGORIES.FormattingEnabled = true;
            this.COMBO_CATEGORIES.Location = new System.Drawing.Point(104, 29);
            this.COMBO_CATEGORIES.Name = "COMBO_CATEGORIES";
            this.COMBO_CATEGORIES.Size = new System.Drawing.Size(128, 21);
            this.COMBO_CATEGORIES.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Quick Filter :";
            // 
            // txtFilterCategory
            // 
            this.txtFilterCategory.Location = new System.Drawing.Point(356, 29);
            this.txtFilterCategory.Name = "txtFilterCategory";
            this.txtFilterCategory.Size = new System.Drawing.Size(127, 20);
            this.txtFilterCategory.TabIndex = 35;
            // 
            // DGV_PRODUCTS
            // 
            this.DGV_PRODUCTS.AllowUserToAddRows = false;
            this.DGV_PRODUCTS.AllowUserToDeleteRows = false;
            this.DGV_PRODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTS.Location = new System.Drawing.Point(9, 59);
            this.DGV_PRODUCTS.Name = "DGV_PRODUCTS";
            this.DGV_PRODUCTS.RowTemplate.Height = 15;
            this.DGV_PRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCTS.Size = new System.Drawing.Size(480, 157);
            this.DGV_PRODUCTS.TabIndex = 33;
            this.DGV_PRODUCTS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PRODUCTS_CellContentClick_1);
            this.DGV_PRODUCTS.DoubleClick += new System.EventHandler(this.DGV_PRODUCTS_DoubleClick_1);
            // 
            // DGV_CUSTOMER
            // 
            this.DGV_CUSTOMER.AllowUserToAddRows = false;
            this.DGV_CUSTOMER.AllowUserToDeleteRows = false;
            this.DGV_CUSTOMER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CUSTOMER.Location = new System.Drawing.Point(12, 66);
            this.DGV_CUSTOMER.Name = "DGV_CUSTOMER";
            this.DGV_CUSTOMER.ReadOnly = true;
            this.DGV_CUSTOMER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CUSTOMER.Size = new System.Drawing.Size(421, 132);
            this.DGV_CUSTOMER.TabIndex = 59;
            this.DGV_CUSTOMER.Click += new System.EventHandler(this.DGV_CUSTOMER_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(171, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 25);
            this.label9.TabIndex = 82;
            this.label9.Text = "%";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtdiscoutrate
            // 
            this.txtdiscoutrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscoutrate.Location = new System.Drawing.Point(121, 244);
            this.txtdiscoutrate.Name = "txtdiscoutrate";
            this.txtdiscoutrate.Size = new System.Drawing.Size(44, 20);
            this.txtdiscoutrate.TabIndex = 79;
            this.txtdiscoutrate.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 81;
            this.label5.Text = "Discount :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerName.Location = new System.Drawing.Point(162, 282);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(20, 18);
            this.lblCustomerName.TabIndex = 78;
            this.lblCustomerName.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 18);
            this.label12.TabIndex = 77;
            this.label12.Text = "Customer Name :";
            // 
            // lblTotalInvoice
            // 
            this.lblTotalInvoice.AutoSize = true;
            this.lblTotalInvoice.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvoice.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTotalInvoice.Location = new System.Drawing.Point(870, 515);
            this.lblTotalInvoice.Name = "lblTotalInvoice";
            this.lblTotalInvoice.Size = new System.Drawing.Size(58, 25);
            this.lblTotalInvoice.TabIndex = 75;
            this.lblTotalInvoice.Text = "00.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(730, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 74;
            this.label8.Text = "Return Total : ";
            // 
            // CB_SELECT_ALL
            // 
            this.CB_SELECT_ALL.AutoSize = true;
            this.CB_SELECT_ALL.BackColor = System.Drawing.Color.Transparent;
            this.CB_SELECT_ALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_SELECT_ALL.Location = new System.Drawing.Point(850, 279);
            this.CB_SELECT_ALL.Name = "CB_SELECT_ALL";
            this.CB_SELECT_ALL.Size = new System.Drawing.Size(93, 20);
            this.CB_SELECT_ALL.TabIndex = 73;
            this.CB_SELECT_ALL.Text = "Select All";
            this.CB_SELECT_ALL.UseVisualStyleBackColor = false;
            // 
            // BTN_DELETE_PRODUCTS
            // 
            this.BTN_DELETE_PRODUCTS.BackColor = System.Drawing.Color.Red;
            this.BTN_DELETE_PRODUCTS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_DELETE_PRODUCTS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_DELETE_PRODUCTS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_DELETE_PRODUCTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE_PRODUCTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE_PRODUCTS.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE_PRODUCTS.Location = new System.Drawing.Point(705, 273);
            this.BTN_DELETE_PRODUCTS.Name = "BTN_DELETE_PRODUCTS";
            this.BTN_DELETE_PRODUCTS.Size = new System.Drawing.Size(139, 27);
            this.BTN_DELETE_PRODUCTS.TabIndex = 72;
            this.BTN_DELETE_PRODUCTS.Text = "Delete  Products";
            this.BTN_DELETE_PRODUCTS.UseVisualStyleBackColor = false;
            // 
            // DGV_PRODUCTS_IN_ORDER
            // 
            this.DGV_PRODUCTS_IN_ORDER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS_IN_ORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTS_IN_ORDER.Location = new System.Drawing.Point(18, 303);
            this.DGV_PRODUCTS_IN_ORDER.Name = "DGV_PRODUCTS_IN_ORDER";
            this.DGV_PRODUCTS_IN_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCTS_IN_ORDER.Size = new System.Drawing.Size(925, 200);
            this.DGV_PRODUCTS_IN_ORDER.TabIndex = 71;
            // 
            // BTN_INSERT_ORDER
            // 
            this.BTN_INSERT_ORDER.BackColor = System.Drawing.Color.Green;
            this.BTN_INSERT_ORDER.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_INSERT_ORDER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_INSERT_ORDER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_INSERT_ORDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_INSERT_ORDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INSERT_ORDER.ForeColor = System.Drawing.Color.White;
            this.BTN_INSERT_ORDER.Location = new System.Drawing.Point(617, 509);
            this.BTN_INSERT_ORDER.Name = "BTN_INSERT_ORDER";
            this.BTN_INSERT_ORDER.Size = new System.Drawing.Size(110, 38);
            this.BTN_INSERT_ORDER.TabIndex = 70;
            this.BTN_INSERT_ORDER.Text = "Sale Return";
            this.BTN_INSERT_ORDER.UseVisualStyleBackColor = false;
            this.BTN_INSERT_ORDER.Click += new System.EventHandler(this.BTN_INSERT_ORDER_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 69;
            this.label4.Text = "Return Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 209);
            this.dateTimePicker1.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(224, 279);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(33, 18);
            this.lblCustomerID.TabIndex = 83;
            this.lblCustomerID.Text = "-----";
            this.lblCustomerID.Visible = false;
            // 
            // Cus_Sale_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 549);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdiscoutrate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTotalInvoice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CB_SELECT_ALL);
            this.Controls.Add(this.BTN_DELETE_PRODUCTS);
            this.Controls.Add(this.DGV_PRODUCTS_IN_ORDER);
            this.Controls.Add(this.BTN_INSERT_ORDER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DGV_CUSTOMER);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cus_Sale_Return";
            this.Text = "Cus_Sale_Return";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_ORDER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCustomer;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox COMBO_CATEGORIES;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilterCategory;
        private System.Windows.Forms.DataGridView DGV_PRODUCTS;
        public System.Windows.Forms.DataGridView DGV_CUSTOMER;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdiscoutrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblTotalInvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CB_SELECT_ALL;
        private System.Windows.Forms.Button BTN_DELETE_PRODUCTS;
        private System.Windows.Forms.DataGridView DGV_PRODUCTS_IN_ORDER;
        public System.Windows.Forms.Button BTN_INSERT_ORDER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCustomerID;
    }
}