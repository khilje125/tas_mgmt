using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class FORM_MANAGE_PRODUCT : Form
    {

        Product product = new Product();
        public FORM_MANAGE_PRODUCT()
        {
            InitializeComponent();

            DGV_PRODUCTS.DataSource = product.getProducts();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DGV_PRODUCTS.Columns[4];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGV_PRODUCTS.AllowUserToAddRows = false;
            DGV_PRODUCTS.RowTemplate.Height = 50;
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            DGV_PRODUCTS.DataSource = product.searchProducts(TB_SEARCH.Text);
        }

        private void BTN_NEW_PRODUCT_Click(object sender, EventArgs e)
        {
          frmAddProduct fnp = new frmAddProduct();
            fnp.ShowDialog();
            DGV_PRODUCTS.DataSource = product.getProducts();
        }

        private void BTN_DELETE_PRODUCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you really want to delete this product", "Remove Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                product.deleteProducts(Convert.ToInt32(DGV_PRODUCTS.CurrentRow.Cells[0].Value));
                DGV_PRODUCTS.DataSource = product.getProducts();
                MessageBox.Show("Product Deleted Successfully", "Remove Product");
            }
        }

        private void BTN_PRODUCT_PRODUCT_Click(object sender, EventArgs e)
        {
            FORM_UPDATE_PRODUCT fup = new FORM_UPDATE_PRODUCT();
            fup.LBL_PID.Text            = DGV_PRODUCTS.CurrentRow.Cells[0].Value.ToString();
            fup.TB_NAME.Text            = DGV_PRODUCTS.CurrentRow.Cells[1].Value.ToString();
            fup.TB_QUANTITY.Text        = DGV_PRODUCTS.CurrentRow.Cells[2].Value.ToString();
            fup.TB_PRICE.Text           = DGV_PRODUCTS.CurrentRow.Cells[3].Value.ToString();
            fup.TB_DESCRIPTION.Text     = DGV_PRODUCTS.CurrentRow.Cells[5].Value.ToString();
            fup.textBoxdiscount.Text = DGV_PRODUCTS.CurrentRow.Cells[9].Value.ToString();
            fup.COMBO_CATEGORIES.Text   = DGV_PRODUCTS.CurrentRow.Cells[6].Value.ToString();
         fup.COMBO_CATEGORIES.Text = DGV_PRODUCTS.CurrentRow.Cells[6].Value.ToString();
            fup.comboBoxclass.Text = DGV_PRODUCTS.CurrentRow.Cells[7].Value.ToString();
            fup.txtProductConf2.Text = DGV_PRODUCTS.CurrentRow.Cells[8].Value.ToString();
           
            byte[] img = (byte[])DGV_PRODUCTS.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(img);
            fup.PB_BROWSE_IMAGE.Image = Image.FromStream(ms);
            fup.ShowDialog();
            DGV_PRODUCTS.DataSource = product.getProducts();

        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PANEL_MENI_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FORM_MANAGE_PRODUCT_Load(object sender, EventArgs e)
        {

        }
    }
}
