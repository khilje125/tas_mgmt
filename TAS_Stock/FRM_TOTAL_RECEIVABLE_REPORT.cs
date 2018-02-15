using Microsoft.Reporting.WinForms;
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
    public partial class FRM_TOTAL_RECEIVABLE_REPORT : Form
    {
        public FRM_TOTAL_RECEIVABLE_REPORT()
        {
         
            InitializeComponent();
        }

        public void GetTotalReceiveable()
        {
            try
            {
                CashBook ab = new CashBook();
                DataTable aTable = ab.getTotalReceivable();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                LocalReport localReport = reportViewer1.LocalReport;
                reportViewer1.LocalReport.ReportPath = (@"Reports/TotalReceiveable.rdlc");
               // reportViewer1.LocalReport.ReportPath = "../../TotalReceiveable.rdlc";
                ReportDataSource dsSalesOrder = new ReportDataSource("TotalReceivableDataSet", aTable);
                localReport.DataSources.Add(dsSalesOrder);
                reportViewer1.Refresh();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            GetTotalReceiveable();
        }

        private void FRM_TOTAL_RECEIVABLE_REPORT_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
