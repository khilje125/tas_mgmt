using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class Customer_Ledger_Report : Form
    {
        public Customer_Ledger_Report()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        public void GetCustomerLedger(string fromdate, string toDate,int customerId)
        {
            try
            {
                CashBook ab = new CashBook();
                DataTable aTable = ab.genrateLedeger(fromdate, toDate, customerId);

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                LocalReport localReport = reportViewer1.LocalReport;
                reportViewer1.LocalReport.ReportPath = Common.GetReportPath() + "CustomerLedger.rdlc";
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("rptParamtFromDate", fromdate);
                param[1] = new ReportParameter("rptParamtToDate", toDate);

                reportViewer1.LocalReport.SetParameters(param);
                ReportDataSource dsSalesOrder = new ReportDataSource("dsCustomerLedger", aTable);
                localReport.DataSources.Add(dsSalesOrder);
                Common.DynamicNameAndAddress(reportViewer1);
                reportViewer1.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Customer_Ledger_Report_Load(object sender, EventArgs e)
        {

        }

        public void GetrRecipts()
        {
            try
            {
                CashBook ab = new CashBook();
                DataTable aTable = ab.getReciptAndPaymentList();

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                LocalReport localReport = reportViewer1.LocalReport;
               reportViewer1.LocalReport.ReportPath = Common.GetReportPath() + "ReciptPayment.rdlc";
                ReportDataSource dsSalesOrder = new ReportDataSource("dsReciptPayment", aTable);
                localReport.DataSources.Add(dsSalesOrder);
                Common.DynamicNameAndAddress(reportViewer1);
                reportViewer1.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

