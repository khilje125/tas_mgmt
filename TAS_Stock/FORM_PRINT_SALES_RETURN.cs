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
    public partial class FORM_PRINT_SALES_RETURN : Form
    {
        Customer customer = new Customer();
        Order order = new Order();
        public FORM_PRINT_SALES_RETURN()
        {
            InitializeComponent();
            string q = "";
            comboBox1.DataSource = getCustomers();
            comboBox1.DisplayMember = "FIRST_NAME";
            comboBox1.ValueMember = "CUST_ID";
        }
        public DataTable getCustomers()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("spr_get_customers", null);
            db.closeConnection();
            return tab;
        }
        private void GV_CUSTOMORDER_SelectionChanged(object sender, EventArgs e)
        {
            //int val;
            //Int32.TryParse(comboBox1.SelectedValue.ToString(), out val);

            //GV_CUSTOMORDER.DataSource = order.getCustomerOrders_PurchasedReturn(val);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBox1.SelectedValue.ToString(), out val);
            GV_CUSTOMORDER.DataSource = order.getCustomerOrders_PurchasedReturn(val);
            GV_CUSTOMORDER.Columns[1].Visible = false;
        }

      

        private void GV_CUSTOMORDER_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                int customerid = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                int OrderId = Convert.ToInt32(GV_CUSTOMORDER.SelectedRows[0].Cells[0].Value.ToString());
                FORM_PRINT_PURCHSE_INVOICE fppi = new FORM_PRINT_PURCHSE_INVOICE();
                //fppi.GetSalesReturnByCustomer(customerid, OrderId);
                fppi.ShowDialog();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void FORM_PRINT_SALES_RETURN_Load(object sender, EventArgs e)
        {

        }

        private void GV_CUSTOMORDER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
