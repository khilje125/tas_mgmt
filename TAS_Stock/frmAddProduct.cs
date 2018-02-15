using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class frmAddProduct : Form
    {
        Categorie catg = new Categorie();
        Product product = new Product();
        public frmAddProduct()
        {
            InitializeComponent();
            loadComboCategory();
           
            comboBoxclass.DataSource = catg.getClass();
            comboBoxclass.DisplayMember = "ClassName";
            comboBoxclass.ValueMember = "ClassName";
            comboBoxclass.SelectedIndex = 0;
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {

        }

        

        public void loadComboCategory()
        {
            COMBO_CATEGORIES.DataSource = catg.getCategories();
            COMBO_CATEGORIES.DisplayMember = "CAT_NAME";
            COMBO_CATEGORIES.ValueMember = "CAT_ID";
        }

        private void PB_BROWSE_IMAGE_Click(object sender, EventArgs e)
        {

            OpenFileDialog ImagefileDialog = new OpenFileDialog();
            ImagefileDialog.Filter = "Image |*.JPG; *.PNG; *.GIF";
            if (ImagefileDialog.ShowDialog() == DialogResult.OK)
            {
                PB_BROWSE_IMAGE.Image = Image.FromFile(ImagefileDialog.FileName);
            }
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PANEL_ADD_PRODUCT_Click(object sender, EventArgs e)
        {


        }

        private void TB_QUANTITY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TB_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char separator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != separator)
            {
                e.Handled = true;
            }
        }

        private void BTN_ADD_CATEGORY_Click(object sender, EventArgs e)
        {
            FORM_ADD_NEW_CATEGORIE faddc = new FORM_ADD_NEW_CATEGORIE();
            faddc.ShowDialog();
            //loadComboCategory();
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
           
           
        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void PB_BROWSE_IMAGE_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ImagefileDialog = new OpenFileDialog();
            ImagefileDialog.Filter = "Image |*.JPG; *.PNG; *.GIF";
            if (ImagefileDialog.ShowDialog() == DialogResult.OK)
            {
                PB_BROWSE_IMAGE.Image = Image.FromFile(ImagefileDialog.FileName);
            }

        }

        private void BTN_ADD_Click_1(object sender, EventArgs e)
        {
            try
            {
                int ActualProductPrice = 0;
                double discountrate = 0;
                double NewPriceAfterDiscount = 0;
                if (TB_NAME.Text == string.Empty)
                {
                    MessageBox.Show("Enter The Product Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtdiscont.Text != null)
                {
                    ActualProductPrice = Convert.ToInt32(TB_PRICE.Text);
                    discountrate = Convert.ToInt32(txtdiscont.Text);
                    double discountAmount = ActualProductPrice * discountrate / 100;
                    NewPriceAfterDiscount = ActualProductPrice - discountAmount;

                }
                if (TB_PRICE.Text == string.Empty && TB_QUANTITY.Text == string.Empty)
                {
                    MessageBox.Show("Quantity and Price Can't Be Empty | But Can Be Equal To 0", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (comboBoxclass.SelectedValue == string.Empty && txtProductConf2.Text == string.Empty)
                {
                    MessageBox.Show("ClassName and Book Can't Be Empty | But Can Be Equal To 0", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtdiscont.Text== string.Empty)
                {
                    discountrate = 0;
                }
                else if (PB_BROWSE_IMAGE.Image == null)
                {
                    MessageBox.Show("No Image Selected", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    PB_BROWSE_IMAGE.Image.Save(ms, PB_BROWSE_IMAGE.Image.RawFormat);
                    byte[] image = ms.ToArray();
                    product.insertProduct(Convert.ToInt32(COMBO_CATEGORIES.SelectedValue), TB_NAME.Text,
                                         TB_PRICE.Text, image, Convert.ToInt32(TB_QUANTITY.Text), TB_DESCRIPTION.Text, comboBoxclass.SelectedValue.ToString(), txtProductConf2.Text, discountrate, NewPriceAfterDiscount);
                    MessageBox.Show("New Product Inserted Successfully", "New Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                      FORM_MANAGE_PRODUCT ar = new FORM_MANAGE_PRODUCT();
                      ar.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, MessageBoxButtons.AbortRetryIgnore.ToString());
            }

        }

        private void BTN_ADD_CATEGORY_Click_1(object sender, EventArgs e)
        {
            FORM_MANAGE_CATEGORIES FMC = new FORM_MANAGE_CATEGORIES();
            FMC.ShowDialog();
        }

        private void BTN_CANCEL_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
