using System;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class FORM_ADD_NEW_CATEGORIE : Form
    {
        DB db = new DB();
        Categorie category = new Categorie();
        public FORM_ADD_NEW_CATEGORIE()
        {
            InitializeComponent();
            
        }

        // add new categorie
        private void BTN_ADD_CATEGORY_Click(object sender, EventArgs e)
        {
            if(TB_CATEGORY_NAME.Text != string.Empty)
            {
                db.openConnection();
                category.insertCategory(TB_CATEGORY_NAME.Text);
                MessageBox.Show("New Category Inserted Successfully", "Insert Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Enter The Categorie Name");
            }
            
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bind_ParentCategory()
        {
            try
            {
                //cmParentCategory.Items.Clear();
                //cmParentCategory.Items.Add("-Select-");
             
            

              
                ////cmParentCategory.Items.Add(new { Text = "--Select One--", Value = "0" });
                //cmParentCategory.DataSource = category.getCategories();
               
                //cmParentCategory.DisplayMember = "CAT_NAME";
                //cmParentCategory.ValueMember = "CAT_ID";
                //cmParentCategory.SelectedIndex = 0;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FORM_ADD_NEW_CATEGORIE_Load(object sender, EventArgs e)
        {
           
        }

        private void FORM_ADD_NEW_CATEGORIE_DragOver(object sender, DragEventArgs e)
        {
            // the drop effect reflects that the drop cannot occur.
            if (!e.Data.GetDataPresent(typeof(System.String)))
            {

                e.Effect = DragDropEffects.None;
               
                return;
            }

            // Set the effect based upon the KeyState.
            if ((e.KeyState & (8 + 32)) == (8 + 32) &&
                (e.AllowedEffect & DragDropEffects.Link) == DragDropEffects.Link)
            {
                // KeyState 8 + 32 = CTL + ALT

                // Link drag-and-drop effect.
                e.Effect = DragDropEffects.Link;

            }
            else if ((e.KeyState & 32) == 32 &&
              (e.AllowedEffect & DragDropEffects.Link) == DragDropEffects.Link)
            {

                // ALT KeyState for link.
                e.Effect = DragDropEffects.Link;

            }
            else if ((e.KeyState & 4) == 4 &&
              (e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            {

                // SHIFT KeyState for move.
                e.Effect = DragDropEffects.Move;

            }
            else if ((e.KeyState & 8) == 8 &&
              (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {

                // CTL KeyState for copy.
                e.Effect = DragDropEffects.Copy;

            }
            else if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            {

                // By default, the drop action should be move, if allowed.
                e.Effect = DragDropEffects.Move;

            }
            else
                e.Effect = DragDropEffects.None;

            // Get the index of the item the mouse is below. 

            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.

            //indexOfItemUnderMouseToDrop =ListDragTarget.IndexFromPoint(ListDragTarget.PointToClient(new Point(e.X, e.Y)));

            //// Updates the label text.
            //if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            //{

            //    DropLocationLabel.Text = "Drops before item #" + (indexOfItemUnderMouseToDrop + 1);
            //}
            //else
            //    DropLocationLabel.Text = "Drops at the end.";
            
        }

        private void cmParentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string val = cmParentCategory.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
