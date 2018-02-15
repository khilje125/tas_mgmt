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
    public partial class PurchaseReturn : Form
    {
        Customer customer = new Customer();
        Order order = new Order();
        public PurchaseReturn()
        {
            InitializeComponent();
            string q = "";
            comboBox1.DataSource = customer.getCustomers(q);
            comboBox1.DisplayMember = "FIRST_NAME";
            comboBox1.ValueMember = "CUST_ID";

            groupBox1.Visible = false;
            groupBox2.Visible = false;

       
        }
         
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val; 
                Int32.TryParse(comboBox1.SelectedValue.ToString(), out val);

            GV_CUSTOMORDER.DataSource = order.getCustomerOrders_PurchasedReturn(val);
           GV_CUSTOMORDER.Columns[1].Visible = false;
        
        }

       
        private void GV_CUSTOMORDER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            int orderid = Convert.ToInt32(GV_CUSTOMORDER.SelectedRows[0].Cells[2].Value.ToString());
            textBoxproductname.Text = GV_CUSTOMORDER.SelectedRows[0].Cells[1].Value.ToString();
            textBoxqty.Text = GV_CUSTOMORDER.SelectedRows[0].Cells[3].Value.ToString();
            textBoxprice.Text = GV_CUSTOMORDER.SelectedRows[0].Cells[4].Value.ToString();
           textBoxtotal.Text  = GV_CUSTOMORDER.SelectedRows[0].Cells[5].Value.ToString();

            textBoxdicount.Text = GV_CUSTOMORDER.SelectedRows[0].Cells[6].Value.ToString();
            textBoxdiscountPrice.Text = GV_CUSTOMORDER.SelectedRows[0].Cells[7].Value.ToString();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int orderid = Convert.ToInt32( GV_CUSTOMORDER.SelectedRows[0].Cells[0].Value.ToString());
                int customerId = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                string productname = GV_CUSTOMORDER.SelectedRows[0].Cells[1].Value.ToString();
                int quentity = Convert.ToInt32(GV_CUSTOMORDER.SelectedRows[0].Cells[2].Value.ToString());
                decimal price = Convert.ToDecimal(GV_CUSTOMORDER.SelectedRows[0].Cells[3].Value.ToString());
                decimal total = Convert.ToDecimal(GV_CUSTOMORDER.SelectedRows[0].Cells[4].Value.ToString());
                decimal discount = Convert.ToDecimal(GV_CUSTOMORDER.SelectedRows[0].Cells[5].Value.ToString());
                decimal dicountPrice = Convert.ToDecimal(GV_CUSTOMORDER.SelectedRows[0].Cells[6].Value.ToString());
                int productid = Convert.ToInt32(GV_CUSTOMORDER.SelectedRows[0].Cells[7].Value.ToString());
                string UserName = LogginInfo.UserID.ToString();
                order.InsertOrders_PurchasedReturn(customerId, productid, productname, orderid, quentity, price, total, discount, dicountPrice, Convert.ToDateTime(DateTime.Now), UserName);
                MessageBox.Show("Sales Retrun Successfull","Add Return Sales",MessageBoxButtons.OK);
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void PurchaseReturn_Load(object sender, EventArgs e)
        {

        }
    }
}
