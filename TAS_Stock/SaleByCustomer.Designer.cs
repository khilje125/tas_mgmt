﻿namespace TAS_Stock
{
    partial class SaleByCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleByCustomer));
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Print_Sale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(123, 64);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(225, 21);
            this.comboBoxCustomer.TabIndex = 68;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, -7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 54);
            this.panel3.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Sale ";
            // 
            // BTN_Print_Sale
            // 
            this.BTN_Print_Sale.BackColor = System.Drawing.Color.Black;
            this.BTN_Print_Sale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_Print_Sale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_Print_Sale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_Print_Sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Print_Sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Print_Sale.ForeColor = System.Drawing.Color.White;
            this.BTN_Print_Sale.Location = new System.Drawing.Point(227, 91);
            this.BTN_Print_Sale.Name = "BTN_Print_Sale";
            this.BTN_Print_Sale.Size = new System.Drawing.Size(121, 31);
            this.BTN_Print_Sale.TabIndex = 66;
            this.BTN_Print_Sale.Text = "Get";
            this.BTN_Print_Sale.UseVisualStyleBackColor = false;
            this.BTN_Print_Sale.Click += new System.EventHandler(this.BTN_Print_Sale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Select Customer:";
            // 
            // SaleByCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 137);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BTN_Print_Sale);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaleByCustomer";
            this.Text = "Customer Sale";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Print_Sale;
        private System.Windows.Forms.Label label1;
    }
}