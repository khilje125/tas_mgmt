using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class ReportTotalReceivable : Form
    {
        public ReportTotalReceivable()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewerTR.RefreshReport();
            GetTotalReceiveable();

        }

        public void GetTotalReceiveable()
        {
            try
            {
                CashBook ab = new CashBook();
                DataTable aTable = ab.getTotalReceivable();
                reportViewerTR.ProcessingMode = ProcessingMode.Local;
                LocalReport localReport = reportViewerTR.LocalReport;
                reportViewerTR.LocalReport.ReportPath = Common.GetReportPath() + "TotalReceiveable.rdlc";
                ReportDataSource dsSalesOrder = new ReportDataSource("dsTotalR", aTable);
                localReport.DataSources.Add(dsSalesOrder);
               Common.DynamicNameAndAddress(reportViewerTR);
                reportViewerTR.Refresh();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void ReportTotalReceivable_Load(object sender, EventArgs e)
        {
            this.reportViewerTR.RefreshReport();
        }
    }
}
