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
    public partial class Add_Class : Form
    {
        public Add_Class()
        {
            InitializeComponent();
        }
        DB db = new DB();
        Categorie category = new Categorie();

        private void BTN_ADD_CATEGORY_Click(object sender, EventArgs e)
        {
          
        }
    }
}
