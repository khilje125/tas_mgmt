using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class FORM_SALE : Form
    {
        public FORM_SALE()
        {
            InitializeComponent();
        }


        private void BTN_Print_Sale_Click(object sender, EventArgs e)
        {

            //SALES_TOTAL atot = new SALES_TOTAL();
            FORM_SALE_REPORT fms = new FORM_SALE_REPORT();

            fms.GetTotalSales(dtfrom.Value.ToString(), dtTo.Value.ToString());
            fms.ShowDialog();

           
            
        }

        
        private void FORM_SALE_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }


    }
}
