﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class FORM_QUANTITY : Form
    {
        public Boolean addTheProduct = true;
        Product product = new Product();
        public int pro_id;

        public FORM_QUANTITY()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
        }
        private bool IsEnterSeen = false;
        private void FORM_QUANTITY_KeyDown(object sender, KeyEventArgs e)
        {
            if (TB_QUANTITY.Text == String.Empty || Convert.ToInt32(TB_QUANTITY.Text) == 0)
            {
                LBL_QTY_MESSAGE.Text = "Quantity Can't Be Empty Or = 0";
                LBL_QTY_MESSAGE.Visible = true;
                // [addTheProduct = false] = the product are not gonna be add to the datagridview
                addTheProduct = false;
            }
            else if (validQty(pro_id) == false)
            {
                LBL_QTY_MESSAGE.Text = "Unavailable Quantity";
                LBL_QTY_MESSAGE.Visible = true;
                addTheProduct = false;
            }

            else
            {
                addTheProduct = true;
                Close();
            }


            if (e.KeyCode == Keys.Enter)
                BTN_OK.PerformClick();

            // take action here if 'IsEnterSeen == 'true

        }
        private void BTN_OK_Click(object sender, EventArgs e)
        {
            if (TB_QUANTITY.Text == String.Empty || Convert.ToInt32(TB_QUANTITY.Text) == 0)
            {
                LBL_QTY_MESSAGE.Text = "Quantity Can't Be Empty Or = 0";
                LBL_QTY_MESSAGE.Visible = true;
                // [addTheProduct = false] = the product are not gonna be add to the datagridview
                addTheProduct = false;
            }
            else if(validQty(pro_id) == false)
               {
                   LBL_QTY_MESSAGE.Text = "Unavailable Quantity";
                   LBL_QTY_MESSAGE.Visible = true;
                   addTheProduct = false;
               }

            else
            {
                addTheProduct = true;
                Close();
            } 
            
        }

        // if typed quantity exist in the stock 
        public Boolean validQty(int id)
        {
            DataTable table = new DataTable();
            table = product.getProduct(id);
            int qty = Convert.ToInt32(table.Rows[0]["STOCK_QTE"].ToString());
            if (Convert.ToInt32(TB_QUANTITY.Text) > qty)
            {
                return addTheProduct = false; 
            }
            else
            {
                return addTheProduct = true;
                 
            }
                
        }

        // type only digits and delete
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            addTheProduct = false;
            Close();
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            addTheProduct = false;
            Close();
        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FORM_QUANTITY_Load(object sender, EventArgs e)
        {
            this.AcceptButton = BTN_OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTheProduct = false;
            Close();
        }
    }
}
