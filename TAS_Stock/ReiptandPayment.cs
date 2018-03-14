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
    public partial class ReiptandPayment : Form
    {
        public ReiptandPayment()
        {
            InitializeComponent();
            lblprvtotal.Text = Convert.ToString(getReciptsAndPaymentTotal());
        }

        private void ReiptandPayment_Load(object sender, EventArgs e)
        {

        }
        public decimal getReciptsAndPaymentTotal()
        {
            CashBook cb = new CashBook();
            decimal total = 0;
            var getTable = cb.getReceiiptsAndPayment();
            if (getTable.Rows.Count > 0)
            {
                total = Convert.ToDecimal(getTable.Rows[0][0]);

            }
            return total;

        }
    }
}
