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
    public partial class ManageCategory : Form
    {
        DB db = new DB();  int position = 0;
        Categorie category = new Categorie();
        Product product = new Product();
        DataTable table = new DataTable();
        public ManageCategory()
        {
            InitializeComponent();

            // populate datagridview and listbox
            table = db.getData("spr_categorie_products", null);
            DGV_CATEGORIES.DataSource = table;
            try
            {
                LSTB_PRODUCTS_IN_CATEGORY.DataSource = product.getProductsByCategory(Convert.ToInt32(DGV_CATEGORIES.Rows[0].Cells[0].Value.ToString()));
                LSTB_PRODUCTS_IN_CATEGORY.DisplayMember = "PRO_NAME";
                LSTB_PRODUCTS_IN_CATEGORY.ValueMember = "PRO_ID";
            }
            catch (Exception ex)
            {

            }

            navigation(position);
        }

        // button insert categorie
       
        // button delete categorie
        private void BTN_DELETE_CTG_Click(object sender, EventArgs e)
        {
            
        }

        // update categorie
        private void BTN_UPDATE_CTG_Click(object sender, EventArgs e)
        {
           

        }

        // navigation method
        public void navigation(int pos)
        {
            DataTable table = new DataTable();
            table = category.getCategories();
            if (table.Rows.Count > 0)
            {
                TB_CATG_ID.Text = table.Rows[pos][0].ToString();
                TB_CATG_NAME.Text = table.Rows[pos][1].ToString();
            }
            else {

            }
           
        }

        // show products in the selected categorie in listboxe
        public void loadListBox()
        {
            LSTB_PRODUCTS_IN_CATEGORY.DataSource = product.getProductsByCategory(Convert.ToInt32(DGV_CATEGORIES.CurrentRow.Cells[0].Value.ToString()));
            LSTB_PRODUCTS_IN_CATEGORY.DisplayMember = "PRO_NAME";
            LSTB_PRODUCTS_IN_CATEGORY.ValueMember = "PRO_ID";
        }

        // show datagridview selected row data in textboxes
        private void DGV_CATEGORIES_Click(object sender, EventArgs e)
        {
            
        }

        // button Next
        private void BTN_NEXT_Click(object sender, EventArgs e)
        {
           
        }

        // button previous
        private void BTN_PREVIOUS_Click(object sender, EventArgs e)
        {
           
        }

        // clear textboxes
        private void BTN_NEW_CATEGORY_Click(object sender, EventArgs e)
        {
         
        }

        // show products exist i the categorie selected
        private void DGV_CATEGORIES_DoubleClick(object sender, EventArgs e)
        {
            FORM_PRODUCTS_IN_CATEGORY fpinc = new FORM_PRODUCTS_IN_CATEGORY();
            fpinc.LBL_CATEGORY.Text = DGV_CATEGORIES.CurrentRow.Cells[1].Value.ToString();
            int val;
            Int32.TryParse(DGV_CATEGORIES.CurrentRow.Cells[0].Value.ToString(), out val);
            fpinc.DGV_PRODUCTS_IN_CATEGORY.DataSource = product.getProductsByCategory(val);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)fpinc.DGV_PRODUCTS_IN_CATEGORY.Columns[4];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            fpinc.DGV_PRODUCTS_IN_CATEGORY.AllowUserToAddRows = false;
            fpinc.DGV_PRODUCTS_IN_CATEGORY.RowTemplate.Height = 60;
            fpinc.ShowDialog();
        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
Close();
        }

        private void BTN_INSERT_CTG_Click_1(object sender, EventArgs e)
        {
            db.openConnection();
            if (TB_CATG_NAME.Text != string.Empty)
            {
                category.insertCategory(TB_CATG_NAME.Text);
                MessageBox.Show("New Category Inserted Successfully", "Insert Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_CATEGORIES.DataSource = category.getCategories();
            }

        }

        private void BTN_UPDATE_CTG_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TB_CATG_ID.Text != string.Empty || TB_CATG_NAME.Text != string.Empty)
                {
                    try
                    {
                        db.openConnection();
                        category.updateCategory(Convert.ToInt16(TB_CATG_ID.Text), TB_CATG_NAME.Text);
                        MessageBox.Show("Category Updated Successfully", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DGV_CATEGORIES.DataSource = category.getCategories();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BTN_DELETE_CTG_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TB_CATG_ID.Text != string.Empty)
                {
                    if (MessageBox.Show("do you really want to delete this Category", "Remove Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            category.deleteCategory(Convert.ToInt32(TB_CATG_ID.Text));
                            table = category.getCategories();
                            DGV_CATEGORIES.DataSource = table;
                            MessageBox.Show("Category Deleted Successfully", "Remove Category");
                            TB_CATG_ID.Text = "";
                            TB_CATG_NAME.Text = "";
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BTN_NEXT_Click_1(object sender, EventArgs e)
        {
            if (position == category.getCategories().Rows.Count - 1)
                return;
            position++;
            navigation(position);

            //
            
        }

        private void BTN_PREVIOUS_Click_1(object sender, EventArgs e)
        {
            if (position == 0)
                return;
            position--;
            navigation(position);

        }

        private void BTN_NEW_CATEGORY_Click_1(object sender, EventArgs e)
        {
            TB_CATG_ID.Text = "";
            TB_CATG_NAME.Text = "";
        }

        private void DGV_CATEGORIES_Click_1(object sender, EventArgs e)
        {
            try
            {
                TB_CATG_ID.Text = DGV_CATEGORIES.CurrentRow.Cells[0].Value.ToString();
                TB_CATG_NAME.Text = DGV_CATEGORIES.CurrentRow.Cells[1].Value.ToString();
                LSTB_PRODUCTS_IN_CATEGORY.DataSource = product.getProductsByCategory(Convert.ToInt32(DGV_CATEGORIES.CurrentRow.Cells[0].Value.ToString()));
                LSTB_PRODUCTS_IN_CATEGORY.DisplayMember = "PRO_NAME";
                LSTB_PRODUCTS_IN_CATEGORY.ValueMember = "PRO_ID";
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void DGV_CATEGORIES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {

        }
    }
}

