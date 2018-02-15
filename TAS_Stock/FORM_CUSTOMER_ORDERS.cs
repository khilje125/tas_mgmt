using System;
using System.Data;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class FORM_CUSTOMER_ORDERS : Form
    {
        Order order = new Order();
        public FORM_CUSTOMER_ORDERS()
        {
            InitializeComponent();

        }
        //populate listbox with the product name in the slected order
        private void FORM_CUSTOMER_ORDERS_Load(object sender, EventArgs e)
        {
            // show customer oreders
            if(DGV_CUSTOMER_ORDERS.Rows.Count -1 != 0)
            {
                int orderId = Convert.ToInt32(DGV_CUSTOMER_ORDERS.CurrentRow.Cells[0].Value.ToString());
                DataTable details = new DataTable();
                // get the order details
                details = order.getOrderDetails(orderId);
                if (details.Rows.Count != 0)
                {
                    // show the products in the listbox
                    LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = order.getOrderDetails(orderId);
                    LSB_CUSTOMER_ORDER_PRODUCTS.DisplayMember = "PRO_NAME";
                }
                else
                {
                    LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = null;
                    LSB_CUSTOMER_ORDER_PRODUCTS.Items.Add("No Products");
                }
            }
            
        }

        // repopulate listbox with the product name in the slected order
        private void DGV_CUSTOMER_ORDERS_DoubleClick(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(DGV_CUSTOMER_ORDERS.CurrentRow.Cells[0].Value.ToString());
            DataTable details = new DataTable();
            details = order.getOrderDetails(orderId);
            if (details.Rows.Count != 0)
            {
                LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = order.getOrderDetails(orderId);
                LSB_CUSTOMER_ORDER_PRODUCTS.DisplayMember = "PRO_NAME";
            }
            else
            {
                LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = null;
                LSB_CUSTOMER_ORDER_PRODUCTS.Items.Add("No Products");
            }
        }

        // show products in the selected order 
        private void DGV_CUSTOMER_ORDERS_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = 0;
                DataTable details = new DataTable();
                if (DGV_CUSTOMER_ORDERS.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    orderId = Convert.ToInt32(DGV_CUSTOMER_ORDERS.CurrentRow.Cells[0].Value.ToString());

                    details = order.getOrderDetails(orderId);
                }
                else
                {
                    MessageBox.Show("No Order Found");
                    return;
                }


                if (details.Rows.Count != 0)
                {
                    LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = order.getOrderDetails(orderId);
                    LSB_CUSTOMER_ORDER_PRODUCTS.DisplayMember = "PRO_NAME";
                }
                else
                {
                    LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = null;
                    LSB_CUSTOMER_ORDER_PRODUCTS.Items.Add("No Products");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
