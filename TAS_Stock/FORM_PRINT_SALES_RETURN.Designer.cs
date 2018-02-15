namespace TAS_Stock
{
    partial class FORM_PRINT_SALES_RETURN
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
            this.GV_CUSTOMORDER = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GV_CUSTOMORDER)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_CUSTOMORDER
            // 
            this.GV_CUSTOMORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_CUSTOMORDER.Location = new System.Drawing.Point(89, 56);
            this.GV_CUSTOMORDER.Name = "GV_CUSTOMORDER";
            this.GV_CUSTOMORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_CUSTOMORDER.Size = new System.Drawing.Size(414, 150);
            this.GV_CUSTOMORDER.TabIndex = 5;
            this.GV_CUSTOMORDER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_CUSTOMORDER_CellContentClick);
            this.GV_CUSTOMORDER.SelectionChanged += new System.EventHandler(this.GV_CUSTOMORDER_SelectionChanged);
            this.GV_CUSTOMORDER.DoubleClick += new System.EventHandler(this.GV_CUSTOMORDER_DoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-151, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Custom:";
            // 
            // FORM_PRINT_SALES_RETURN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 262);
            this.Controls.Add(this.GV_CUSTOMORDER);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "FORM_PRINT_SALES_RETURN";
            this.Text = "FORM_PRINT_SALES_RETURN";
            this.Load += new System.EventHandler(this.FORM_PRINT_SALES_RETURN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_CUSTOMORDER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_CUSTOMORDER;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}