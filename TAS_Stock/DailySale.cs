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
    public partial class DailySale : Form
    {
        public DailySale()
        {
            InitializeComponent();
        }

        private void BTN_Print_Sale_Click(object sender, EventArgs e)
        {
            FORM_SALE_REPORT fms = new FORM_SALE_REPORT();

            fms.GetDailySale(dtfrom.Value.ToString(), dtTo.Value.ToString());
            fms.ShowDialog();

        }
    }
}
