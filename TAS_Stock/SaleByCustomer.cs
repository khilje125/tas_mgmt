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
    public partial class SaleByCustomer : Form
    {
        Customer customer = new Customer();
        public SaleByCustomer()
        {
            InitializeComponent();
            string q = "";
            DataTable dtcustomer = customer.getCustomers(q);
            comboBoxCustomer.DataSource = dtcustomer;
            comboBoxCustomer.DisplayMember = "FIRST_NAME";
            comboBoxCustomer.ValueMember = "CUST_ID";

        }

        private void BTN_Print_Sale_Click(object sender, EventArgs e)
        {
            FORM_PRINT_PURCHSE_INVOICE fms = new FORM_PRINT_PURCHSE_INVOICE();

            fms.GetSalesByCustomerid(Convert.ToInt32(comboBoxCustomer.SelectedValue));
            fms.ShowDialog();
        }
    }
}
