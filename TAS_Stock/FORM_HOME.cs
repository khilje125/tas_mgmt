using System;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class FORM_HOME : Form
    {
        public string userType;
        public FORM_HOME()
        {
            InitializeComponent();

            if (LogginInfo.UserType == "SuperAdmin")
            {
                addClassToolStripMenuItem.Visible = true;
            }

        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ADD_NEW_CATEGORIE fmcg = new FORM_ADD_NEW_CATEGORIE();
            fmcg.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CUSTOMER fmcm = new FORM_MANAGE_CUSTOMER();
            fmcm.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fmo = new Form1();
            fmo.ShowDialog();
        }

        public void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_USER fmus = new FORM_MANAGE_USER();
            fmus.ShowDialog();
        }

       

        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cus_Sale_Return pr = new Cus_Sale_Return();
            pr.ShowDialog();
            
        }

        private void orderSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaleReport ar = new SaleReport();
            //ar.ShowDialog();
        }

        private void salesReutnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerSaleReturn csr = new CustomerSaleReturn();
            csr.ShowDialog();
        }

        private void productStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_CURRNET_STOCK fcr = new FORM_CURRNET_STOCK();
            fcr.ShowDialog();
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_PRODUCT FMP = new FORM_MANAGE_PRODUCT();
            FMP.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProduct fap = new frmAddProduct();
            fap.ShowDialog();
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerCashHistory csh = new CustomerCashHistory();
            csh.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Form1 order = new Form1();
            order.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            CustomerCashHistory cch = new CustomerCashHistory();
            cch.ShowDialog();

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            FORM_SALE frm = new FORM_SALE();
            frm.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            logOut();
        }

        public  void logOut()
        {
            this.Hide();
            FORM_HOME FH = new FORM_HOME();
            FH.Closed += (s, args) => this.Close();
            FH.Close();
            FORM_LOGIN a = new FORM_LOGIN();
            a.ShowDialog();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void daToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBaseBackUp dss = new DataBaseBackUp();
            dss.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalReceiveableToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ReportTotalReceivable frtr = new ReportTotalReceivable();
            frtr.ShowDialog();
        }

        private void bankChequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank_Cheque  ab = new Bank_Cheque();
            ab.ShowDialog();
        }

        private void bankChequeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PaidUnpaidCheques ch = new PaidUnpaidCheques();
            ch.ShowDialog();
        }

        private void FORM_HOME_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddProduct ab = new frmAddProduct();
            ab.ShowDialog();
        }

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CATEGORIES ab = new FORM_MANAGE_CATEGORIES();
            ab.ShowDialog();
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CUSTOMER mc = new FORM_MANAGE_CUSTOMER();
            mc.ShowDialog();
        }

        private void btn_OrderSystem_Click(object sender, EventArgs e)
        {
            Form1 order = new Form1();
            order.ShowDialog();
        }

        private void btn_CustomerLedger_Click(object sender, EventArgs e)
        {
            CustomerCashHistory cch = new CustomerCashHistory();
            cch.ShowDialog();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            FORM_SALE frm = new FORM_SALE();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
          
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Class AC = new Manage_Class();
            AC.ShowDialog();

        }

        private void orderQuatationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_PRINT_PURCHSE_INVOICE PR = new FORM_PRINT_PURCHSE_INVOICE();
            PR.OrderQuatation();
            PR.ShowDialog();
        }

        private void customerSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleByCustomer sbc = new SaleByCustomer();
            sbc.ShowDialog();
        }

        private void saleByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_SALE fs = new FORM_SALE();
             fs.ShowDialog();
        }

        private void reciptsPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReciptsPayaments rp = new ReciptsPayaments();
            rp.ShowDialog();
        }

        private void dailySaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailySale ds = new DailySale();
            ds.ShowDialog();
        }
    }
}
