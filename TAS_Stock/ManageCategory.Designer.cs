namespace TAS_Stock
{
    partial class ManageCategory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_NEW_CATEGORY = new System.Windows.Forms.Button();
            this.BTN_PREVIOUS = new System.Windows.Forms.Button();
            this.BTN_NEXT = new System.Windows.Forms.Button();
            this.TB_CATG_NAME = new System.Windows.Forms.TextBox();
            this.TB_CATG_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LSTB_PRODUCTS_IN_CATEGORY = new System.Windows.Forms.ListBox();
            this.BTN_DELETE_CTG = new System.Windows.Forms.Button();
            this.BTN_UPDATE_CTG = new System.Windows.Forms.Button();
            this.BTN_INSERT_CTG = new System.Windows.Forms.Button();
            this.DGV_CATEGORIES = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORIES)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 110);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 53);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Categories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Add Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID : ";
            // 
            // BTN_NEW_CATEGORY
            // 
            this.BTN_NEW_CATEGORY.BackColor = System.Drawing.Color.Black;
            this.BTN_NEW_CATEGORY.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEW_CATEGORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_NEW_CATEGORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEW_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW_CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEW_CATEGORY.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW_CATEGORY.Location = new System.Drawing.Point(61, 376);
            this.BTN_NEW_CATEGORY.Name = "BTN_NEW_CATEGORY";
            this.BTN_NEW_CATEGORY.Size = new System.Drawing.Size(75, 30);
            this.BTN_NEW_CATEGORY.TabIndex = 21;
            this.BTN_NEW_CATEGORY.Text = "Reset";
            this.BTN_NEW_CATEGORY.UseVisualStyleBackColor = false;
            this.BTN_NEW_CATEGORY.Click += new System.EventHandler(this.BTN_NEW_CATEGORY_Click_1);
            // 
            // BTN_PREVIOUS
            // 
            this.BTN_PREVIOUS.BackColor = System.Drawing.Color.Black;
            this.BTN_PREVIOUS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_PREVIOUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_PREVIOUS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_PREVIOUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PREVIOUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PREVIOUS.ForeColor = System.Drawing.Color.White;
            this.BTN_PREVIOUS.Location = new System.Drawing.Point(221, 376);
            this.BTN_PREVIOUS.Name = "BTN_PREVIOUS";
            this.BTN_PREVIOUS.Size = new System.Drawing.Size(75, 30);
            this.BTN_PREVIOUS.TabIndex = 20;
            this.BTN_PREVIOUS.Text = "Previous";
            this.BTN_PREVIOUS.UseVisualStyleBackColor = false;
            this.BTN_PREVIOUS.Click += new System.EventHandler(this.BTN_PREVIOUS_Click_1);
            // 
            // BTN_NEXT
            // 
            this.BTN_NEXT.BackColor = System.Drawing.Color.Black;
            this.BTN_NEXT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEXT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_NEXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEXT.ForeColor = System.Drawing.Color.White;
            this.BTN_NEXT.Location = new System.Drawing.Point(140, 376);
            this.BTN_NEXT.Name = "BTN_NEXT";
            this.BTN_NEXT.Size = new System.Drawing.Size(75, 30);
            this.BTN_NEXT.TabIndex = 19;
            this.BTN_NEXT.Text = "Next";
            this.BTN_NEXT.UseVisualStyleBackColor = false;
            this.BTN_NEXT.Click += new System.EventHandler(this.BTN_NEXT_Click_1);
            // 
            // TB_CATG_NAME
            // 
            this.TB_CATG_NAME.Location = new System.Drawing.Point(152, 213);
            this.TB_CATG_NAME.Name = "TB_CATG_NAME";
            this.TB_CATG_NAME.Size = new System.Drawing.Size(147, 20);
            this.TB_CATG_NAME.TabIndex = 18;
            // 
            // TB_CATG_ID
            // 
            this.TB_CATG_ID.Location = new System.Drawing.Point(152, 168);
            this.TB_CATG_ID.Name = "TB_CATG_ID";
            this.TB_CATG_ID.ReadOnly = true;
            this.TB_CATG_ID.Size = new System.Drawing.Size(147, 20);
            this.TB_CATG_ID.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Categories List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(722, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Products By Category";
            // 
            // LSTB_PRODUCTS_IN_CATEGORY
            // 
            this.LSTB_PRODUCTS_IN_CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSTB_PRODUCTS_IN_CATEGORY.FormattingEnabled = true;
            this.LSTB_PRODUCTS_IN_CATEGORY.ItemHeight = 20;
            this.LSTB_PRODUCTS_IN_CATEGORY.Location = new System.Drawing.Point(711, 156);
            this.LSTB_PRODUCTS_IN_CATEGORY.Name = "LSTB_PRODUCTS_IN_CATEGORY";
            this.LSTB_PRODUCTS_IN_CATEGORY.Size = new System.Drawing.Size(232, 204);
            this.LSTB_PRODUCTS_IN_CATEGORY.TabIndex = 29;
            // 
            // BTN_DELETE_CTG
            // 
            this.BTN_DELETE_CTG.BackColor = System.Drawing.Color.Black;
            this.BTN_DELETE_CTG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_DELETE_CTG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_DELETE_CTG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_DELETE_CTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE_CTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE_CTG.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE_CTG.Location = new System.Drawing.Point(513, 376);
            this.BTN_DELETE_CTG.Name = "BTN_DELETE_CTG";
            this.BTN_DELETE_CTG.Size = new System.Drawing.Size(80, 30);
            this.BTN_DELETE_CTG.TabIndex = 28;
            this.BTN_DELETE_CTG.Text = "Delete";
            this.BTN_DELETE_CTG.UseVisualStyleBackColor = false;
            this.BTN_DELETE_CTG.Click += new System.EventHandler(this.BTN_DELETE_CTG_Click_1);
            // 
            // BTN_UPDATE_CTG
            // 
            this.BTN_UPDATE_CTG.BackColor = System.Drawing.Color.Black;
            this.BTN_UPDATE_CTG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_UPDATE_CTG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_UPDATE_CTG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_UPDATE_CTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UPDATE_CTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UPDATE_CTG.ForeColor = System.Drawing.Color.White;
            this.BTN_UPDATE_CTG.Location = new System.Drawing.Point(427, 376);
            this.BTN_UPDATE_CTG.Name = "BTN_UPDATE_CTG";
            this.BTN_UPDATE_CTG.Size = new System.Drawing.Size(80, 30);
            this.BTN_UPDATE_CTG.TabIndex = 27;
            this.BTN_UPDATE_CTG.Text = "Update";
            this.BTN_UPDATE_CTG.UseVisualStyleBackColor = false;
            this.BTN_UPDATE_CTG.Click += new System.EventHandler(this.BTN_UPDATE_CTG_Click_1);
            // 
            // BTN_INSERT_CTG
            // 
            this.BTN_INSERT_CTG.BackColor = System.Drawing.Color.Black;
            this.BTN_INSERT_CTG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_INSERT_CTG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_INSERT_CTG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_INSERT_CTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_INSERT_CTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INSERT_CTG.ForeColor = System.Drawing.Color.White;
            this.BTN_INSERT_CTG.Location = new System.Drawing.Point(341, 376);
            this.BTN_INSERT_CTG.Name = "BTN_INSERT_CTG";
            this.BTN_INSERT_CTG.Size = new System.Drawing.Size(80, 30);
            this.BTN_INSERT_CTG.TabIndex = 26;
            this.BTN_INSERT_CTG.Text = "Insert";
            this.BTN_INSERT_CTG.UseVisualStyleBackColor = false;
            this.BTN_INSERT_CTG.Click += new System.EventHandler(this.BTN_INSERT_CTG_Click_1);
            // 
            // DGV_CATEGORIES
            // 
            this.DGV_CATEGORIES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CATEGORIES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CATEGORIES.Location = new System.Drawing.Point(341, 160);
            this.DGV_CATEGORIES.Name = "DGV_CATEGORIES";
            this.DGV_CATEGORIES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CATEGORIES.Size = new System.Drawing.Size(340, 208);
            this.DGV_CATEGORIES.TabIndex = 25;
            this.DGV_CATEGORIES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CATEGORIES_CellContentClick);
            this.DGV_CATEGORIES.Click += new System.EventHandler(this.DGV_CATEGORIES_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(601, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 562);
            this.panel2.TabIndex = 2;
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(972, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LSTB_PRODUCTS_IN_CATEGORY);
            this.Controls.Add(this.BTN_DELETE_CTG);
            this.Controls.Add(this.BTN_UPDATE_CTG);
            this.Controls.Add(this.BTN_INSERT_CTG);
            this.Controls.Add(this.DGV_CATEGORIES);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_NEW_CATEGORY);
            this.Controls.Add(this.BTN_PREVIOUS);
            this.Controls.Add(this.BTN_NEXT);
            this.Controls.Add(this.TB_CATG_NAME);
            this.Controls.Add(this.TB_CATG_ID);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCategory";
            this.Text = "ManageCategory";
            this.Load += new System.EventHandler(this.ManageCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORIES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_NEW_CATEGORY;
        private System.Windows.Forms.Button BTN_PREVIOUS;
        private System.Windows.Forms.Button BTN_NEXT;
        private System.Windows.Forms.TextBox TB_CATG_NAME;
        private System.Windows.Forms.TextBox TB_CATG_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LSTB_PRODUCTS_IN_CATEGORY;
        private System.Windows.Forms.Button BTN_DELETE_CTG;
        private System.Windows.Forms.Button BTN_UPDATE_CTG;
        private System.Windows.Forms.Button BTN_INSERT_CTG;
        private System.Windows.Forms.DataGridView DGV_CATEGORIES;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}