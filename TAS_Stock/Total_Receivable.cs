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
    public partial class Total_Receivable : Form
    {
        public Total_Receivable()
        {
            InitializeComponent();
        }

        

        private void Total_Receivable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TotalReceivableDataSet.sp_Total_Receivable' table. You can move, or remove it, as needed.
           // this.sp_Total_ReceivableTableAdapter.Fill(this.TotalReceivableDataSet.sp_Total_Receivable);

        }

        public void GetTotalReceiveable()
        {
            try
            {
                CashBook ab = new CashBook();
                DataTable aTable = ab.getTotalReceivable();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                LocalReport localReport = reportViewer1.LocalReport;
              
                reportViewer1.LocalReport.ReportPath = Common.GetReportPath() + "TotalReceiveable.rdlc";
                ReportDataSource dsSalesOrder = new ReportDataSource("TotalReceivableDataSet", aTable);
                localReport.DataSources.Add(dsSalesOrder);
                Common.DynamicNameAndAddress(reportViewer1);
                reportViewer1.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            GetTotalReceiveable();
        }
    }
}
