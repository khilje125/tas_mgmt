using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class Bank_Cheque : Form
    {
        public Bank_Cheque()
        {
            InitializeComponent();
        }

        private void Bank_Cheque_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            GetBankCheuqDetails();
        }
        public void GetBankCheuqDetails()
        {
            try
            {
                CashBook ab = new CashBook();
                DataTable aTable = ab.getBankChequeDetail();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                LocalReport localReport = reportViewer1.LocalReport;
               
                reportViewer1.LocalReport.ReportPath = (@"Reports/BankCheque.rdlc");
                ReportDataSource dsSalesOrder = new ReportDataSource("dsBankCheque", aTable);
                localReport.DataSources.Add(dsSalesOrder);
                Common.DynamicNameAndAddress(reportViewer1);
                reportViewer1.Refresh();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
