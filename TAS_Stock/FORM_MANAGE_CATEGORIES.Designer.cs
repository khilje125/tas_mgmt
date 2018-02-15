namespace TAS_Stock
{
    partial class FORM_MANAGE_CATEGORIES
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
            this.DGV_CATEGORIES = new System.Windows.Forms.DataGridView();
            this.BTN_INSERT_CTG = new System.Windows.Forms.Button();
            this.BTN_UPDATE_CTG = new System.Windows.Forms.Button();
            this.BTN_DELETE_CTG = new System.Windows.Forms.Button();
            this.TB_CATG_ID = new System.Windows.Forms.TextBox();
            this.TB_CATG_NAME = new System.Windows.Forms.TextBox();
            this.BTN_NEXT = new System.Windows.Forms.Button();
            this.BTN_PREVIOUS = new System.Windows.Forms.Button();
            this.BTN_NEW_CATEGORY = new System.Windows.Forms.Button();
            this.LSTB_PRODUCTS_IN_CATEGORY = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORIES)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_CATEGORIES
            // 
            this.DGV_CATEGORIES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CATEGORIES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CATEGORIES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_CATEGORIES.Location = new System.Drawing.Point(190, 29);
            this.DGV_CATEGORIES.Name = "DGV_CATEGORIES";
            this.DGV_CATEGORIES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CATEGORIES.Size = new System.Drawing.Size(448, 355);
            this.DGV_CATEGORIES.TabIndex = 0;
            this.DGV_CATEGORIES.Click += new System.EventHandler(this.DGV_CATEGORIES_Click);
            this.DGV_CATEGORIES.DoubleClick += new System.EventHandler(this.DGV_CATEGORIES_DoubleClick);
            // 
            // BTN_INSERT_CTG
            // 
            this.BTN_INSERT_CTG.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BTN_INSERT_CTG.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_INSERT_CTG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_INSERT_CTG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_INSERT_CTG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_INSERT_CTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_INSERT_CTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INSERT_CTG.ForeColor = System.Drawing.Color.White;
            this.BTN_INSERT_CTG.Location = new System.Drawing.Point(3, 87);
            this.BTN_INSERT_CTG.Name = "BTN_INSERT_CTG";
            this.BTN_INSERT_CTG.Size = new System.Drawing.Size(179, 30);
            this.BTN_INSERT_CTG.TabIndex = 1;
            this.BTN_INSERT_CTG.Text = "Insert";
            this.BTN_INSERT_CTG.UseVisualStyleBackColor = false;
            this.BTN_INSERT_CTG.Click += new System.EventHandler(this.BTN_INSERT_CTG_Click);
            // 
            // BTN_UPDATE_CTG
            // 
            this.BTN_UPDATE_CTG.BackColor = System.Drawing.Color.Olive;
            this.BTN_UPDATE_CTG.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_UPDATE_CTG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_UPDATE_CTG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_UPDATE_CTG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_UPDATE_CTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UPDATE_CTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UPDATE_CTG.ForeColor = System.Drawing.Color.White;
            this.BTN_UPDATE_CTG.Location = new System.Drawing.Point(3, 123);
            this.BTN_UPDATE_CTG.Name = "BTN_UPDATE_CTG";
            this.BTN_UPDATE_CTG.Size = new System.Drawing.Size(179, 30);
            this.BTN_UPDATE_CTG.TabIndex = 2;
            this.BTN_UPDATE_CTG.Text = "Update";
            this.BTN_UPDATE_CTG.UseVisualStyleBackColor = false;
            this.BTN_UPDATE_CTG.Click += new System.EventHandler(this.BTN_UPDATE_CTG_Click);
            // 
            // BTN_DELETE_CTG
            // 
            this.BTN_DELETE_CTG.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BTN_DELETE_CTG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_DELETE_CTG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_DELETE_CTG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_DELETE_CTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE_CTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE_CTG.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE_CTG.Location = new System.Drawing.Point(3, 3);
            this.BTN_DELETE_CTG.Name = "BTN_DELETE_CTG";
            this.BTN_DELETE_CTG.Size = new System.Drawing.Size(80, 30);
            this.BTN_DELETE_CTG.TabIndex = 3;
            this.BTN_DELETE_CTG.Text = "Delete";
            this.BTN_DELETE_CTG.UseVisualStyleBackColor = false;
            this.BTN_DELETE_CTG.Click += new System.EventHandler(this.BTN_DELETE_CTG_Click);
            // 
            // TB_CATG_ID
            // 
            this.TB_CATG_ID.Dock = System.Windows.Forms.DockStyle.Top;
            this.TB_CATG_ID.Location = new System.Drawing.Point(3, 19);
            this.TB_CATG_ID.Name = "TB_CATG_ID";
            this.TB_CATG_ID.ReadOnly = true;
            this.TB_CATG_ID.Size = new System.Drawing.Size(180, 20);
            this.TB_CATG_ID.TabIndex = 4;
            // 
            // TB_CATG_NAME
            // 
            this.TB_CATG_NAME.Dock = System.Windows.Forms.DockStyle.Top;
            this.TB_CATG_NAME.Location = new System.Drawing.Point(3, 61);
            this.TB_CATG_NAME.Name = "TB_CATG_NAME";
            this.TB_CATG_NAME.Size = new System.Drawing.Size(180, 20);
            this.TB_CATG_NAME.TabIndex = 5;
            // 
            // BTN_NEXT
            // 
            this.BTN_NEXT.BackColor = System.Drawing.Color.BlueViolet;
            this.BTN_NEXT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEXT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_NEXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEXT.ForeColor = System.Drawing.Color.White;
            this.BTN_NEXT.Location = new System.Drawing.Point(89, 3);
            this.BTN_NEXT.Name = "BTN_NEXT";
            this.BTN_NEXT.Size = new System.Drawing.Size(75, 30);
            this.BTN_NEXT.TabIndex = 6;
            this.BTN_NEXT.Text = "Next";
            this.BTN_NEXT.UseVisualStyleBackColor = false;
            this.BTN_NEXT.Click += new System.EventHandler(this.BTN_NEXT_Click);
            // 
            // BTN_PREVIOUS
            // 
            this.BTN_PREVIOUS.BackColor = System.Drawing.Color.BlueViolet;
            this.BTN_PREVIOUS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_PREVIOUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_PREVIOUS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_PREVIOUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PREVIOUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PREVIOUS.ForeColor = System.Drawing.Color.White;
            this.BTN_PREVIOUS.Location = new System.Drawing.Point(170, 3);
            this.BTN_PREVIOUS.Name = "BTN_PREVIOUS";
            this.BTN_PREVIOUS.Size = new System.Drawing.Size(80, 30);
            this.BTN_PREVIOUS.TabIndex = 7;
            this.BTN_PREVIOUS.Text = "Previous";
            this.BTN_PREVIOUS.UseVisualStyleBackColor = false;
            this.BTN_PREVIOUS.Click += new System.EventHandler(this.BTN_PREVIOUS_Click);
            // 
            // BTN_NEW_CATEGORY
            // 
            this.BTN_NEW_CATEGORY.BackColor = System.Drawing.Color.Black;
            this.BTN_NEW_CATEGORY.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_NEW_CATEGORY.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEW_CATEGORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_NEW_CATEGORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEW_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW_CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEW_CATEGORY.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW_CATEGORY.Location = new System.Drawing.Point(3, 159);
            this.BTN_NEW_CATEGORY.Name = "BTN_NEW_CATEGORY";
            this.BTN_NEW_CATEGORY.Size = new System.Drawing.Size(180, 32);
            this.BTN_NEW_CATEGORY.TabIndex = 8;
            this.BTN_NEW_CATEGORY.Text = "Reset";
            this.BTN_NEW_CATEGORY.UseVisualStyleBackColor = false;
            this.BTN_NEW_CATEGORY.Click += new System.EventHandler(this.BTN_NEW_CATEGORY_Click);
            // 
            // LSTB_PRODUCTS_IN_CATEGORY
            // 
            this.LSTB_PRODUCTS_IN_CATEGORY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSTB_PRODUCTS_IN_CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSTB_PRODUCTS_IN_CATEGORY.FormattingEnabled = true;
            this.LSTB_PRODUCTS_IN_CATEGORY.ItemHeight = 20;
            this.LSTB_PRODUCTS_IN_CATEGORY.Location = new System.Drawing.Point(644, 29);
            this.LSTB_PRODUCTS_IN_CATEGORY.Name = "LSTB_PRODUCTS_IN_CATEGORY";
            this.LSTB_PRODUCTS_IN_CATEGORY.ScrollAlwaysVisible = true;
            this.LSTB_PRODUCTS_IN_CATEGORY.Size = new System.Drawing.Size(219, 355);
            this.LSTB_PRODUCTS_IN_CATEGORY.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(644, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Products By Category";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(190, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Categories List";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Add Category";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.23529F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(987, 537);
            this.tableLayoutPanel1.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(60, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(866, 53);
            this.label7.TabIndex = 0;
            this.label7.Text = "Manage Categories";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.22002F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.77998F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel2.Controls.Add(this.LSTB_PRODUCTS_IN_CATEGORY, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.DGV_CATEGORIES, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(60, 55);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.934307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.0657F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(866, 425);
            this.tableLayoutPanel2.TabIndex = 62;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BTN_DELETE_CTG);
            this.flowLayoutPanel1.Controls.Add(this.BTN_NEXT);
            this.flowLayoutPanel1.Controls.Add(this.BTN_PREVIOUS);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(189, 389);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 34);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.TB_CATG_ID);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.TB_CATG_NAME);
            this.flowLayoutPanel2.Controls.Add(this.BTN_INSERT_CTG);
            this.flowLayoutPanel2.Controls.Add(this.BTN_UPDATE_CTG);
            this.flowLayoutPanel2.Controls.Add(this.BTN_NEW_CATEGORY);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 28);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(183, 357);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // FORM_MANAGE_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(987, 537);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FORM_MANAGE_CATEGORIES";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_MANAGE_CATEGORIES";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORIES)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_CATEGORIES;
        private System.Windows.Forms.Button BTN_INSERT_CTG;
        private System.Windows.Forms.Button BTN_UPDATE_CTG;
        private System.Windows.Forms.Button BTN_DELETE_CTG;
        private System.Windows.Forms.TextBox TB_CATG_ID;
        private System.Windows.Forms.TextBox TB_CATG_NAME;
        private System.Windows.Forms.Button BTN_NEXT;
        private System.Windows.Forms.Button BTN_PREVIOUS;
        private System.Windows.Forms.Button BTN_NEW_CATEGORY;
        private System.Windows.Forms.ListBox LSTB_PRODUCTS_IN_CATEGORY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}