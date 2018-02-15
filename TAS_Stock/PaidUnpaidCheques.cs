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
    public partial class PaidUnpaidCheques : Form
    {   CashBook cb = new CashBook();
        DataTable dt= null;
        public PaidUnpaidCheques()
        {
            InitializeComponent();
        }

        private void BTN_ADD_CATEGORY_Click(object sender, EventArgs e)
        {
         
            
            try
            {
                gvCustomerCheque.Columns.Clear();
                dt = BindBankChequeData();

                if (dt.Rows.Count > 0)
                {

                    gvCustomerCheque.DataSource = dt;
                   
                    
                    AddColumnDynamic();
                }

               

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private DataTable BindBankChequeData()
        {
            
            return cb.getBankCheque(dtfrom.Value.ToString(), dtto.Value.ToString());
        }

        private void gvCustomerCheque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gvCustomerCheque_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            try
            {
                int checid = 0;
                int result = 0;
                DataGridViewRow selectedRow = gvCustomerCheque.CurrentRow;
                checid = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                if (e.ColumnIndex == 8 || e.ColumnIndex == 9)
                {

                    if (e.ColumnIndex == 8)
                    {
                        result = cb.updateBankChequeStatus(checid, 2);
                        if (result>0)
                        {
                            MessageBox.Show("Cheque Cashed Success", "Cheque Cashed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            gvCustomerCheque.Columns.Clear();
                            gvCustomerCheque.DataSource = BindBankChequeData();
                            gvCustomerCheque.Columns[0].Visible = false;
                            AddColumnDynamic();
                        }
                    }
                    if (e.ColumnIndex == 9)
                    {
                        result = cb.updateBankChequeStatus(checid, 3);
                        if (result > 0)
                        {
                            MessageBox.Show("Cheque Returned Success", "Cheque Returned", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            gvCustomerCheque.Columns.Clear();
                            gvCustomerCheque.DataSource = BindBankChequeData();
                            AddColumnDynamic();
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void AddColumnDynamic()
        {
            gvCustomerCheque.Columns[0].Visible = false;
            gvCustomerCheque.Columns[2].Width = 90;
            gvCustomerCheque.Columns[3].Width = 60;
            gvCustomerCheque.Columns[4].Width = 70;
            gvCustomerCheque.Columns[5].Width = 60;
            gvCustomerCheque.Columns[6].Width = 60;
            gvCustomerCheque.Columns[7].Width = 60;


            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.Width = 100;
            bcol.HeaderText = "Cashed ";
            bcol.Text = "Cashed Cheque";
            bcol.Name = "btnClickCashed";
            bcol.UseColumnTextForButtonValue = true;
            gvCustomerCheque.Columns.Add(bcol);
            DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
            bcol1.Width = 100;
            bcol1.HeaderText = " Cheque Return";

            bcol1.Text = "Cheque Return";
            bcol1.Name = "btnReturn";
            bcol1.UseColumnTextForButtonValue = true;
            gvCustomerCheque.Columns.Add(bcol1);
        }

        private void PaidUnpaidCheques_Load(object sender, EventArgs e)
        {
            gvCustomerCheque.Refresh();
        }
    }
}
