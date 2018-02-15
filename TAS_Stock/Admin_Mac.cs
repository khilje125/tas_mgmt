using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class Admin_Mac : Form
    {
        public Admin_Mac()
        {
            InitializeComponent();
        }

        private void Admin_Mac_Load(object sender, EventArgs e)
        {

            txtMac.Text =  Common.GetRandomString();
            txtMac.ReadOnly = true;
        }

        
         private void button1_Click(object sender, EventArgs e)
         {
             MacInfo amac = new MacInfo();
            
             try
             {

                 if (txtMac.Text == string.Empty)
                 {
                     MessageBox.Show("Field are Empty");
                 }
                 else
                 {
                     

                     amac.insertMac(txtMac.Text);
                     this.Hide();
                     FORM_LOGIN aform = new FORM_LOGIN();
                     aform.Show();

                 }
             }
             catch (Exception)
             {
                 
                 throw;
             }
         }
    }
    }

