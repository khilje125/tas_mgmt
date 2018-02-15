using System;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class FORM_PRODUCTS_IN_CATEGORY : Form
    {
        public FORM_PRODUCTS_IN_CATEGORY()
        {

            InitializeComponent();
            
        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FORM_PRODUCTS_IN_CATEGORY_Load(object sender, EventArgs e)
        {

        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
