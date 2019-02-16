using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class ReciptsPayaments : Form
    {
        CashBook cb = new CashBook();
        public ReciptsPayaments()
        {
            InitializeComponent();

            DataTable aTable = cb.getReciptAndPaymentList();
            dataGridViewreciptPayment.DataSource = aTable;
            dataGridViewreciptPayment.Columns[0].Visible = false;

        }

        public  decimal getReciptsAndPaymentTotal()
        {
            
            decimal total = 0;
           var getTable=  cb.getReceiiptsAndPayment();
            if (getTable.Rows.Count>0)
            {
                total = Convert.ToDecimal(getTable.Rows[0][0]);

            }
            return total;

        }

        private void BTN_Order_Click(object sender, EventArgs e)
        {
            try
            {


                if (textBoxRecipts.Text =="0" && textBoxPayment.Text == "0")
                {
                    MessageBox.Show("Fields Are Empty.", "Required Fields ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                if (textBoxPayment.Text != "0")
                {
                    //decimal pretotal = (Convert.ToDecimal(lblprvtotal.Text));
                    //decimal recipts = (Convert.ToDecimal(textBoxPayment.Text));
                    //decimal totalVal = pretotal - recipts;
                    string checkClearingDate = dtCheckDate.Text;
                    cb.insertReceiptAndPayment(textBoxpartyname.Text, 0, Convert.ToDecimal(textBoxPayment.Text), checkClearingDate, 0, LogginInfo.UserID);
                    MessageBox.Show("Sucessed.","Payments Added ",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    //decimal pretotal = (Convert.ToDecimal(lblprvtotal.Text));
                    //decimal recipts =  (Convert.ToDecimal(textBoxRecipts.Text));
                    //decimal totalVal = pretotal + recipts;
                    string checkClearingDate = dtCheckDate.Text;
                    cb.insertReceiptAndPayment(textBoxpartyname.Text, Convert.ToDecimal(textBoxRecipts.Text), 0, checkClearingDate, 0, LogginInfo.UserID);
                    MessageBox.Show("Sucessed.", "Recipts Added ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Reset()
        {
            textBoxpartyname.Text = "";
            textBoxPayment.Text = "";
            textBoxRecipts.Text = "";
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_Ledger_Report ckr = new Customer_Ledger_Report();
            ckr.GetrRecipts();
            ckr.ShowDialog();
        }

        private void dataGridViewreciptPayment_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                
                    DataGridViewRow selectedRow = dataGridViewreciptPayment.CurrentRow;
                    int id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());

                    if (id > 0)
                    {
                        //DataTable getLedgerData = ab.getCustomerLedgerDatebyId(id);
                        if (dataGridViewreciptPayment.Rows.Count > 0)
                        {
                        
                         textBoxpartyname.Text = (selectedRow.Cells[1].Value).ToString();
                        dtCheckDate.Text = Convert.ToDateTime(selectedRow.Cells[2].Value).ToString();
                        textBoxRecipts.Text = (selectedRow.Cells[3].Value).ToString();
                        textBoxPayment.Text = (selectedRow.Cells[4].Value).ToString();
                        BTN_Order.Visible = false;
                        btnupdate.Visible = true;

                    }
                    } 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridViewreciptPayment.CurrentRow;
                int id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                if (textBoxPayment.Text != "0" && id>0)
                {
                    //decimal pretotal = Convert.ToDecimal(selectedRow.Cells[5].Value);
                    //decimal recipts = (Convert.ToDecimal(textBoxPayment.Text));
                    //decimal totalVal = pretotal - recipts;
                    string checkClearingDate = dtCheckDate.Text;
                    cb.UpdateReciptAndPayment(id, textBoxpartyname.Text, 0, Convert.ToDecimal(textBoxPayment.Text), 0,checkClearingDate);
                    MessageBox.Show("Sucessed.", "Payments Updated ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BTN_Order.Visible = true;
                    btnupdate.Visible = false;
                    Reset();
                }
                else
                {
                    //decimal pretotal = Convert.ToDecimal(selectedRow.Cells[5].Value);
                    //decimal recipts = (Convert.ToDecimal(textBoxRecipts.Text));
                    //decimal totalVal = pretotal + recipts;
                    string checkClearingDate = dtCheckDate.Text;
                    cb.UpdateReciptAndPayment(id, textBoxpartyname.Text, Convert.ToDecimal(textBoxRecipts.Text), 0, 0, checkClearingDate);
                    MessageBox.Show("Sucessed", "Payments Update ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BTN_Order.Visible = true;
                    btnupdate.Visible = false;
                    Reset();
                }
                //if (id > 0)
                //{
                //    MessageBox.Show("Update Ledger", "Ledger Record Updated", MessageBoxButtons.OK, MessageBoxIcon.None);
                //    this.Refresh();
                //    btnupdate.Visible = false;
                //    Reset();
                //    getReciptsAndPaymentTotal();
                //}
                //else
                //{
                //    MessageBox.Show("Update Ledger", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
