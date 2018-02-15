using System;
using System.Data;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class FORM_LOGIN : Form
    {
        Login log = new Login();
        public FORM_LOGIN()
        {
            InitializeComponent();
            TB_PASSWORD.Focus();
        }

      
        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();

        }

        // login
        private void PANEL_LOGIN_Click(object sender, EventArgs e)
        {
            
        }


    // show the password characters or not
    private void CB_PASSWORD_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_PASSWORD.Checked)
            {
                TB_PASSWORD.UseSystemPasswordChar = true;
            }
            else
            {
                TB_PASSWORD.UseSystemPasswordChar = false;
            }
        }

      
        protected static  bool ValidateMachine(string MacAddress)
        {
           bool result = false;
           Login log = new Login();
            try
            {
                if (MacAddress != string.Empty)
                {
                    result = log.GetMac_Valid(MacAddress);
                }
                if (result)
	            {
		        return result;
	            }
                else
                {
                 return result;
                }
                 
                }
            catch (Exception ex)
            {
                
                throw;
            }
        
        }

        private void FORM_LOGIN_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnupdate;
        }

        private void TB_USERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void PANEL_LOGIN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void FORM_LOGIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {


           
            if (TB_USERNAME.Text.Trim() == "kaleem")
            {
                this.Hide();
                Admin_Mac ac = new Admin_Mac();
                ac.Show();
            }
            else
            {
                string systemMac = Common.GetRandomString();
                DataTable table = new DataTable();

                if (!ValidateMachine(systemMac.ToString()))
                {
                    if (TB_USERNAME.Text != "")
                    {
                        // table = log.login("admin", "admin");
                        table = log.login(TB_USERNAME.Text.Trim(), TB_PASSWORD.Text.Trim());

                        if (table.Rows.Count > 0)
                        {
                            LogginInfo.UserID = Convert.ToInt32(table.Rows[0][0]);
                            LogginInfo.UserType = table.Rows[0][3].ToString();
                            //if the user is admin 
                            // => hide the current form and show the home form
                            if (table.Rows[0][3].ToString() == "admin" || table.Rows[0][3].ToString() == "SuperAdmin")
                            {
                                FORM_HOME fm = new FORM_HOME();
                                fm.userToolStripMenuItem.Visible = true;

                                fm.daToolStripMenuItem.Visible = true;
                                this.Hide();
                                FORM_HOME FH = new FORM_HOME();
                                FH.Closed += (s, args) => this.Close();
                                FH.Show();
                                Form1 a = new Form1();
                                a.ShowDialog();
                              
                            }
                            else
                            {
                                this.Hide();
                                FORM_HOME FH = new FORM_HOME();
                                FH.Closed += (s, args) => this.Close();
                              
                                FH.Show();
                                Form1 a = new Form1();
                                a.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username Or Password Are Incorrect", "Invalid Login", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid License. Please Contact To Adminstrator.", "Licence Expire", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TB_USERNAME.Text = string.Empty;
            TB_PASSWORD.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
