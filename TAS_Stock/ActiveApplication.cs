using System;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class ActiveApplication : Form
    {
        Login log = new Login();
        public ActiveApplication()
        {
            InitializeComponent();
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtserialkey.Text.Trim()!="")
                {
                    bool validateActivationKey = ProductionRandomValidator.ValidateSerialKeyWithGUID(txtserialkey.Text.Trim(), textBoxActiveKey.Text.Trim());
                    if (validateActivationKey)
                    {
                        int result = log.updateProductKey(textBoxActiveKey.Text, txtserialkey.Text.Trim());

                        if (result > 0)
                        {
                            log.InserDefaultUser();
                            MessageBox.Show("Activation was Successfull", "Active Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                            frmSplash ar = new frmSplash();
                            ar.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Activation was un-successfull", "Active Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Activation was un-successfull", "Active Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //protected static bool ValidateMachine(string MacAddress)
        //{
        //    bool result = false;
        //    Login log = new Login();
        //    try
        //    {
        //        if (MacAddress != string.Empty)
        //        {
        //            result = log.GetMac_Valid(MacAddress);
        //        }
        //        if (result)
        //        {
        //            return result;
        //        }
        //        else
        //        {
        //            return result;
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}

        private void ActiveApplication_Load(object sender, EventArgs e)
        {
           
            string productGuid = Common.GetRandomString();
           
            string guid = log.insertGuid(productGuid);

            txtserialkey.Text = guid.ToString();
            txtserialkey.ReadOnly = true;
            //if (LogginInfo.UserType.ToLower() == "superadmin")
            //{
            //    button1.Visible = true;
            //}

        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {

            lblActivationKey.Text = ProductionRandomValidator.GenerateSerialKeyWithGUID(txtserialkey.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.TrunateTableBySuperAdmin();
            MessageBox.Show("Table Truncated ", "DataBase Table", MessageBoxButtons.OK);
        }
    }
}
