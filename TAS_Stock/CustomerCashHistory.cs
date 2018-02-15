using System;
using System.Data;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class CustomerCashHistory : Form
    {
        public CustomerCashHistory()
        {
            InitializeComponent();
            Customer customer = new Customer();
            string q = "";
            comboBoxCustomer.DataSource = customer.getCustomers(q);
            comboBoxCustomer.DisplayMember = "FIRST_NAME";
            comboBoxCustomer.ValueMember = "CUST_ID";

            comboBoxCustomerLedger.DataSource = customer.getCustomers(q);
            comboBoxCustomerLedger.DisplayMember = "FIRST_NAME";
            comboBoxCustomerLedger.ValueMember = "CUST_ID";
            //DataGridViewTextBoxColumn dgvPId = new DataGridViewTextBoxColumn();
            //dgvPId.HeaderText = "Date";
            //gvCustomerLedger.Columns.Add(dgvPId);

            //DataGridViewTextBoxColumn dgvPn = new DataGridViewTextBoxColumn();
            //dgvPn.HeaderText = "Transaction Description";
            //gvCustomerLedger.Columns.Add(dgvPn);

            //DataGridViewTextBoxColumn dgvcPp = new DataGridViewTextBoxColumn();
            //dgvcPp.HeaderText = "L.F";
            //gvCustomerLedger.Columns.Add(dgvcPp);

            //DataGridViewTextBoxColumn dgvPq = new DataGridViewTextBoxColumn();
            //dgvPq.HeaderText = "Debit";
            //gvCustomerLedger.Columns.Add(dgvPq);

            //DataGridViewTextBoxColumn dgvPt = new DataGridViewTextBoxColumn();
            //dgvPt.HeaderText = "Credit";
            //gvCustomerLedger.Columns.Add(dgvPt);


        }

        private void CustomerCashHistory_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BTN_ADD_CATEGORY_Click(object sender, EventArgs e)
        {
            try
            {
                getLedgerTabeData();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void getLedgerTabeData()
        {
            CashBook cb = new CashBook();
            DataTable dt = new DataTable();
            dt = cb.getCustomerLedgeer(dtfrom.Value.ToString(), dtto.Value.ToString(), Convert.ToInt32(comboBoxCustomer.SelectedValue));
            //gvCustomerLedger.Columns["cashbookid"].Visible = false;

            double sumDebitAmount = 0, sumCreditAmount = 0, balanceAmount = 0;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow _row in dt.Rows)
                {
                    sumDebitAmount += Convert.ToDouble(_row["Debit"]);
                    sumCreditAmount += Convert.ToDouble(_row["Credit"]);

                }
                balanceAmount = sumCreditAmount - sumDebitAmount;
                DataRow balanceRow = dt.NewRow();
                balanceRow["Debit"] = sumDebitAmount;
                balanceRow["Credit"] = sumCreditAmount;

                balanceRow["Discription"] = "Total";
                dt.Rows.InsertAt(balanceRow, dt.Rows.Count + 1);
                DataRow balanceRow_2 = dt.NewRow();
                balanceRow_2["Credit"] = balanceAmount;
                balanceRow_2["Discription"] = "Balance";
                dt.Rows.InsertAt(balanceRow_2, dt.Rows.Count + 2); gvCustomerLedger.DataSource = dt;this.gvCustomerLedger.Columns["cashbookid"].Visible = false;
            this.gvCustomerLedger.Columns["customerId"].Visible = false;
            }
            else {
                gvCustomerLedger.DataSource = null;
            }
           
          
            

        }
        CashBook ab = new CashBook();
        private void buttonInsert_Click(object sender, EventArgs e)
        {

            try
            {
                var customerID = Form1.currentCustomerId;
                var orderDate = dateTimePickerVdate.Value.ToShortDateString();
                if (maskedTextBoxVId.Text != "") //total on credit
                {
                    ab.insertCashBookOrder(Convert.ToInt32(comboBoxCustomerLedger.SelectedValue), Convert.ToInt32(maskedTextBoxVId.Text), textBoxdescription.Text,"","","",  Convert.ToInt32(maskedTextBoxDebit.Text), Convert.ToInt32(maskedTextBoxCredit.Text), orderDate);
                    MessageBox.Show("Insert Ledger", "Ledger Successed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ResetFields();
                    dtto.Value = dateTimePickerVdate.Value;
                    getLedgerTabeData();
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("Invoice No Missing", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void gvCustomerLedger_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (LogginInfo.UserType.Trim().ToLower()!= "admin")
                {
                    MessageBox.Show("You not have Permission ", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else { 
                DataGridViewRow selectedRow = gvCustomerLedger.CurrentRow;
                int id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());

                if (id > 0)
                {
                    DataTable getLedgerData = ab.getCustomerLedgerDatebyId(id);
                        if (getLedgerData.Rows.Count > 0)
                        {
                            lblhiddenCashbookid.Text = getLedgerData.Rows[0][0].ToString();
                            dateTimePickerVdate.Value = Convert.ToDateTime(getLedgerData.Rows[0][1].ToString());
                            textBoxdescription.Text = getLedgerData.Rows[0][2].ToString();
                            if (getLedgerData.Rows[0][3].ToString() != "")
                            {
                                maskedTextBoxVId.Text = getLedgerData.Rows[0][3].ToString();
                            }
                            maskedTextBoxCredit.Text = getLedgerData.Rows[0][4].ToString();
                            maskedTextBoxDebit.Text = getLedgerData.Rows[0][5].ToString();
                            comboBoxCustomerLedger.SelectedValue = Convert.ToInt32(getLedgerData.Rows[0][6].ToString());
                            dateTimePickerVdate.Enabled = false;
                            btnupdate.Visible = true;
                            buttonInsert.Visible = false;
                            comboBoxCustomerLedger.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gvCustomerLedger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ab.UpdateCashBookOrder(Convert.ToInt32(lblhiddenCashbookid.Text), Convert.ToInt32(maskedTextBoxVId.Text), textBoxdescription.Text, Convert.ToDouble(maskedTextBoxCredit.Text), Convert.ToDouble(maskedTextBoxDebit.Text), dateTimePickerVdate.Value.ToString());
                if (id > 0)
                {
                    MessageBox.Show("Update Ledger", "Ledger Record Updated", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Refresh();
                    btnupdate.Visible = false;
                    ResetFields();
                    dateTimePickerVdate.Enabled = true;
                    buttonInsert.Visible = true;
                    comboBoxCustomerLedger.Enabled = true;
                    dtto.Value = dateTimePickerVdate.Value;
                    getLedgerTabeData();
                }
                else
                {
                    MessageBox.Show("Update Ledger", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ResetFields()
        {
            maskedTextBoxCredit.Text = "";
            maskedTextBoxDebit.Text = "";
            textBoxdescription.Text = "";
            maskedTextBoxVId.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_Ledger_Report fms = new Customer_Ledger_Report();

            fms.GetCustomerLedger(dtfrom.Value.ToString(), dtto.Value.ToString(),Convert.ToInt32(comboBoxCustomer.SelectedValue));
            fms.ShowDialog();

        }

    }
}
