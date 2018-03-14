namespace TAS_Stock
{
    partial class Form1
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
            this.DGV_CUSTOMER = new System.Windows.Forms.DataGridView();
            this.btngenrateSale = new System.Windows.Forms.Button();
            this.BTN_NEW_CUSTOMER = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilterCategory = new System.Windows.Forms.TextBox();
            this.BTN_INSERT_ORDER = new System.Windows.Forms.Button();
            this.DGV_PRODUCTS = new System.Windows.Forms.DataGridView();
            this.COMBO_CATEGORIES = new System.Windows.Forms.ComboBox();
            this.CB_SELECT_ALL = new System.Windows.Forms.CheckBox();
            this.BTN_DELETE_PRODUCTS = new System.Windows.Forms.Button();
            this.DGV_PRODUCTS_IN_ORDER = new System.Windows.Forms.DataGridView();
            this.BTN_ALL_ORDERS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalInvoice = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblOrderTempID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiscoutrate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ModelSalesInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductOrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_ORDER)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelSalesInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductOrderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_CUSTOMER
            // 
            this.DGV_CUSTOMER.AllowUserToAddRows = false;
            this.DGV_CUSTOMER.AllowUserToDeleteRows = false;
            this.DGV_CUSTOMER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CUSTOMER.Location = new System.Drawing.Point(17, 69);
            this.DGV_CUSTOMER.Name = "DGV_CUSTOMER";
            this.DGV_CUSTOMER.ReadOnly = true;
            this.DGV_CUSTOMER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CUSTOMER.Size = new System.Drawing.Size(421, 132);
            this.DGV_CUSTOMER.TabIndex = 21;
            this.DGV_CUSTOMER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CUSTOMER_CellContentClick);
            this.DGV_CUSTOMER.Click += new System.EventHandler(this.DGV_CUSTOMER_Click);
            this.DGV_CUSTOMER.DoubleClick += new System.EventHandler(this.DGV_CUSTOMER_DoubleClick);
            // 
            // btngenrateSale
            // 
            this.btngenrateSale.BackColor = System.Drawing.Color.Black;
            this.btngenrateSale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.btngenrateSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btngenrateSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.btngenrateSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenrateSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenrateSale.ForeColor = System.Drawing.Color.White;
            this.btngenrateSale.Location = new System.Drawing.Point(6, 19);
            this.btngenrateSale.Name = "btngenrateSale";
            this.btngenrateSale.Size = new System.Drawing.Size(110, 29);
            this.btngenrateSale.TabIndex = 25;
            this.btngenrateSale.Text = "Genrate Sale";
            this.btngenrateSale.UseVisualStyleBackColor = false;
            this.btngenrateSale.Click += new System.EventHandler(this.btngenrateSale_Click_1);
            // 
            // BTN_NEW_CUSTOMER
            // 
            this.BTN_NEW_CUSTOMER.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_NEW_CUSTOMER.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEW_CUSTOMER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_NEW_CUSTOMER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEW_CUSTOMER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW_CUSTOMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEW_CUSTOMER.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW_CUSTOMER.Location = new System.Drawing.Point(306, 38);
            this.BTN_NEW_CUSTOMER.Name = "BTN_NEW_CUSTOMER";
            this.BTN_NEW_CUSTOMER.Size = new System.Drawing.Size(132, 26);
            this.BTN_NEW_CUSTOMER.TabIndex = 24;
            this.BTN_NEW_CUSTOMER.Text = "Add New Customer";
            this.BTN_NEW_CUSTOMER.UseVisualStyleBackColor = false;
            this.BTN_NEW_CUSTOMER.Click += new System.EventHandler(this.BTN_NEW_CUSTOMER_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Order Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 319);
            this.dateTimePicker1.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 28;
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
            this.txtFilterCategory.Location = new System.Drawing.Point(361, 29);
            this.txtFilterCategory.Name = "txtFilterCategory";
            this.txtFilterCategory.Size = new System.Drawing.Size(109, 20);
            this.txtFilterCategory.TabIndex = 35;
            this.txtFilterCategory.TextChanged += new System.EventHandler(this.txtFilterCategory_TextChanged);
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
            this.BTN_INSERT_ORDER.Location = new System.Drawing.Point(630, 649);
            this.BTN_INSERT_ORDER.Name = "BTN_INSERT_ORDER";
            this.BTN_INSERT_ORDER.Size = new System.Drawing.Size(110, 42);
            this.BTN_INSERT_ORDER.TabIndex = 34;
            this.BTN_INSERT_ORDER.Text = "Process Order";
            this.BTN_INSERT_ORDER.UseVisualStyleBackColor = false;
            this.BTN_INSERT_ORDER.Click += new System.EventHandler(this.BTN_INSERT_ORDER_Click);
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
            this.DGV_PRODUCTS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PRODUCTS_CellContentClick);
            this.DGV_PRODUCTS.DoubleClick += new System.EventHandler(this.DGV_PRODUCTS_DoubleClick);
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
            this.COMBO_CATEGORIES.SelectedIndexChanged += new System.EventHandler(this.COMBO_CATEGORIES_SelectedIndexChanged);
            // 
            // CB_SELECT_ALL
            // 
            this.CB_SELECT_ALL.AutoSize = true;
            this.CB_SELECT_ALL.BackColor = System.Drawing.Color.Transparent;
            this.CB_SELECT_ALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_SELECT_ALL.Location = new System.Drawing.Point(867, 354);
            this.CB_SELECT_ALL.Name = "CB_SELECT_ALL";
            this.CB_SELECT_ALL.Size = new System.Drawing.Size(93, 20);
            this.CB_SELECT_ALL.TabIndex = 42;
            this.CB_SELECT_ALL.Text = "Select All";
            this.CB_SELECT_ALL.UseVisualStyleBackColor = false;
            this.CB_SELECT_ALL.CheckedChanged += new System.EventHandler(this.CB_SELECT_ALL_CheckedChanged_1);
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
            this.BTN_DELETE_PRODUCTS.Location = new System.Drawing.Point(697, 342);
            this.BTN_DELETE_PRODUCTS.Name = "BTN_DELETE_PRODUCTS";
            this.BTN_DELETE_PRODUCTS.Size = new System.Drawing.Size(164, 32);
            this.BTN_DELETE_PRODUCTS.TabIndex = 41;
            this.BTN_DELETE_PRODUCTS.Text = "Delete Slected Products";
            this.BTN_DELETE_PRODUCTS.UseVisualStyleBackColor = false;
            this.BTN_DELETE_PRODUCTS.Click += new System.EventHandler(this.BTN_DELETE_PRODUCTS_Click_1);
            // 
            // DGV_PRODUCTS_IN_ORDER
            // 
            this.DGV_PRODUCTS_IN_ORDER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS_IN_ORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTS_IN_ORDER.Location = new System.Drawing.Point(20, 381);
            this.DGV_PRODUCTS_IN_ORDER.Name = "DGV_PRODUCTS_IN_ORDER";
            this.DGV_PRODUCTS_IN_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCTS_IN_ORDER.Size = new System.Drawing.Size(943, 256);
            this.DGV_PRODUCTS_IN_ORDER.TabIndex = 39;
            // 
            // BTN_ALL_ORDERS
            // 
            this.BTN_ALL_ORDERS.BackColor = System.Drawing.Color.Black;
            this.BTN_ALL_ORDERS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_ALL_ORDERS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_ALL_ORDERS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_ALL_ORDERS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ALL_ORDERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ALL_ORDERS.ForeColor = System.Drawing.Color.White;
            this.BTN_ALL_ORDERS.Location = new System.Drawing.Point(122, 19);
            this.BTN_ALL_ORDERS.Name = "BTN_ALL_ORDERS";
            this.BTN_ALL_ORDERS.Size = new System.Drawing.Size(110, 29);
            this.BTN_ALL_ORDERS.TabIndex = 43;
            this.BTN_ALL_ORDERS.Text = "Show All Orders";
            this.BTN_ALL_ORDERS.UseVisualStyleBackColor = false;
            this.BTN_ALL_ORDERS.Click += new System.EventHandler(this.BTN_ALL_ORDERS_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngenrateSale);
            this.groupBox1.Controls.Add(this.BTN_ALL_ORDERS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 53);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Section";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(746, 650);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Invoice Total : ";
            // 
            // lblTotalInvoice
            // 
            this.lblTotalInvoice.AutoSize = true;
            this.lblTotalInvoice.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvoice.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTotalInvoice.Location = new System.Drawing.Point(886, 649);
            this.lblTotalInvoice.Name = "lblTotalInvoice";
            this.lblTotalInvoice.Size = new System.Drawing.Size(58, 25);
            this.lblTotalInvoice.TabIndex = 46;
            this.lblTotalInvoice.Text = "00.00";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(533, 318);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(33, 18);
            this.lblCustomerID.TabIndex = 47;
            this.lblCustomerID.Text = "-----";
            this.lblCustomerID.Visible = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerName.Location = new System.Drawing.Point(170, 357);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(20, 18);
            this.lblCustomerName.TabIndex = 49;
            this.lblCustomerName.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 18);
            this.label12.TabIndex = 48;
            this.label12.Text = "Customer Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.COMBO_CATEGORIES);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFilterCategory);
            this.groupBox2.Controls.Add(this.DGV_PRODUCTS);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(444, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 223);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products Panel";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            // lblOrderTempID
            // 
            this.lblOrderTempID.AutoSize = true;
            this.lblOrderTempID.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderTempID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTempID.ForeColor = System.Drawing.Color.Red;
            this.lblOrderTempID.Location = new System.Drawing.Point(470, 318);
            this.lblOrderTempID.Name = "lblOrderTempID";
            this.lblOrderTempID.Size = new System.Drawing.Size(48, 18);
            this.lblOrderTempID.TabIndex = 52;
            this.lblOrderTempID.Text = "[-----]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Discount :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtdiscoutrate
            // 
            this.txtdiscoutrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscoutrate.Location = new System.Drawing.Point(501, 355);
            this.txtdiscoutrate.Name = "txtdiscoutrate";
            this.txtdiscoutrate.Size = new System.Drawing.Size(44, 20);
            this.txtdiscoutrate.TabIndex = 52;
            this.txtdiscoutrate.Text = "0";
            this.txtdiscoutrate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(547, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "%";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(120, 44);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(182, 20);
            this.txtCustomer.TabIndex = 52;
            this.txtCustomer.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 35);
            this.panel1.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(398, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Customer Order ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 723);
            this.panel2.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Order ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(14, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 35);
            this.panel3.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(398, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Quick Filter :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(261, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 29);
            this.button1.TabIndex = 58;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(979, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdiscoutrate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOrderTempID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblTotalInvoice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CB_SELECT_ALL);
            this.Controls.Add(this.BTN_DELETE_PRODUCTS);
            this.Controls.Add(this.DGV_PRODUCTS_IN_ORDER);
            this.Controls.Add(this.BTN_INSERT_ORDER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BTN_NEW_CUSTOMER);
            this.Controls.Add(this.DGV_CUSTOMER);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_ORDER)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelSalesInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductOrderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView DGV_CUSTOMER;
        private System.Windows.Forms.Button btngenrateSale;
        private System.Windows.Forms.Button BTN_NEW_CUSTOMER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilterCategory;
        private System.Windows.Forms.DataGridView DGV_PRODUCTS;
        private System.Windows.Forms.ComboBox COMBO_CATEGORIES;
        private System.Windows.Forms.CheckBox CB_SELECT_ALL;
        private System.Windows.Forms.Button BTN_DELETE_PRODUCTS;
        private System.Windows.Forms.DataGridView DGV_PRODUCTS_IN_ORDER;
        private System.Windows.Forms.Button BTN_ALL_ORDERS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource ModelSalesInvoiceBindingSource;
        private System.Windows.Forms.BindingSource ProductOrderDetailBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiscoutrate;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblTotalInvoice;
        public System.Windows.Forms.Label lblOrderTempID;
        public System.Windows.Forms.Button BTN_INSERT_ORDER;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}