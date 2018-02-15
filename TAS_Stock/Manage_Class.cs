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
    public partial class Manage_Class : Form
    {
        public Manage_Class()
        {
            InitializeComponent();
            DGV_CATEGORIES.DataSource = category.getClass();
        }
        DB db = new DB();
        Categorie category = new Categorie();
        private void Manage_Class_Load(object sender, EventArgs e)
        {

        }

        private void BTN_UPDATE_CTG_Click(object sender, EventArgs e)
        {
            try
            {
                if ( TB_Class_NAME.Text != string.Empty)
                {
                    try
                    {
                        db.openConnection();
                        category.updateClass(TB_Class_NAME.Text, DGV_CATEGORIES.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Class Updated Successfully", "Update Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DGV_CATEGORIES.DataSource = category.getClass();
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



        private void BTN_INSERT_CTG_Click(object sender, EventArgs e)
        {
            if (TB_Class_NAME.Text != string.Empty)
            {
                db.openConnection();
                category.insertclass(TB_Class_NAME.Text);
                MessageBox.Show("New class Inserted Successfully", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_CATEGORIES.DataSource = category.getClass();
            }
            else
            {
                MessageBox.Show("Enter The Class Name");
            }
        }

        private void DGV_CATEGORIES_Click(object sender, EventArgs e)
        {
            TB_Class_NAME.Text = DGV_CATEGORIES.CurrentRow.Cells[0].Value.ToString();
        }

        private void BTN_DELETE_CTG_Click(object sender, EventArgs e)
        {

        }
    }
}
