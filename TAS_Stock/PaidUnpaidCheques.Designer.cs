namespace TAS_Stock
{
    partial class PaidUnpaidCheques
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
            this.label6 = new System.Windows.Forms.Label();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gvCustomerCheque = new System.Windows.Forms.DataGridView();
            this.dtto = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_ADD_CATEGORY = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerCheque)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 71);
            this.panel1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(260, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cheque(s) Info";
            // 
            // dtfrom
            // 
            this.dtfrom.Location = new System.Drawing.Point(144, 86);
            this.dtfrom.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(194, 20);
            this.dtfrom.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Date From : ";
            // 
            // gvCustomerCheque
            // 
            this.gvCustomerCheque.AllowUserToAddRows = false;
            this.gvCustomerCheque.AllowUserToDeleteRows = false;
            this.gvCustomerCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomerCheque.Location = new System.Drawing.Point(26, 119);
            this.gvCustomerCheque.Name = "gvCustomerCheque";
            this.gvCustomerCheque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvCustomerCheque.Size = new System.Drawing.Size(795, 226);
            this.gvCustomerCheque.TabIndex = 38;
            this.gvCustomerCheque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCustomerCheque_CellClick);
            // 
            // dtto
            // 
            this.dtto.Location = new System.Drawing.Point(363, 86);
            this.dtto.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtto.Name = "dtto";
            this.dtto.Size = new System.Drawing.Size(194, 20);
            this.dtto.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 40;
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
            this.BTN_ADD_CATEGORY.Location = new System.Drawing.Point(576, 77);
            this.BTN_ADD_CATEGORY.Name = "BTN_ADD_CATEGORY";
            this.BTN_ADD_CATEGORY.Size = new System.Drawing.Size(99, 32);
            this.BTN_ADD_CATEGORY.TabIndex = 41;
            this.BTN_ADD_CATEGORY.Text = "Get Data";
            this.BTN_ADD_CATEGORY.UseVisualStyleBackColor = false;
            this.BTN_ADD_CATEGORY.Click += new System.EventHandler(this.BTN_ADD_CATEGORY_Click);
            // 
            // PaidUnpaidCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 368);
            this.Controls.Add(this.BTN_ADD_CATEGORY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtto);
            this.Controls.Add(this.gvCustomerCheque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtfrom);
            this.Controls.Add(this.panel1);
            this.Name = "PaidUnpaidCheques";
            this.Text = "PaidUnpaidCheques";
            this.Load += new System.EventHandler(this.PaidUnpaidCheques_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerCheque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dtfrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvCustomerCheque;
        public System.Windows.Forms.DateTimePicker dtto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_ADD_CATEGORY;
    }
}