



// For instance:

// Or:
using Microsoft.Reporting.WinForms;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportModel;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class SALES_TOTAL : Form
    {
          Order aOrder = new Order();
        public SALES_TOTAL()
        {
            InitializeComponent();
        }

       
        private void SALES_TOTAL_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
       
        private void reportViewer1_Load(object sender, EventArgs e)
        {
          

        }

         public void GetTotalSales(string fromdate, string totdate)
        {
            DataTable aTable = aOrder.genrateSales(fromdate, totdate);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;
            reportViewer1.LocalReport.ReportPath = (@"Reports/Report1.rdlc");
            object totalAmtStr1 = aTable.Compute("Sum(DISCOUNTEDPRICE)", "");
            List<SalesModel> objsalesdetail = new List<SalesModel>();
            foreach (DataRow row in aTable.Rows)
            {
                SalesModel objSalesModel = new SalesModel();
                objSalesModel.ProductName = (row["PRO_NAME"].ToString());
                objSalesModel.ProductCategory = (row["CAT_NAME"].ToString());
                objSalesModel.ProductConfig1 = (row["PRODUCTCONF1"].ToString());
                objSalesModel.ProductConfig2 = (row["PRODUCTCONF2"].ToString());
                objSalesModel.ProductPrice = Convert.ToDecimal(row["PRICE"].ToString());
                objSalesModel.ProductQuantity = Convert.ToInt32(row["QTE"].ToString());
                objSalesModel.ProductTOTAL = Convert.ToDecimal(row["TOTAL"].ToString());
                objSalesModel.ProductDiscount = Convert.ToDecimal(row["DISCOUNT"]);
                objSalesModel.ProductFinalPrice = Convert.ToDecimal(row["DISCOUNTEDPRICE"]);
                objSalesModel.DateFrom = Convert.ToString(fromdate);
                objSalesModel.DateTo = Convert.ToString(totdate);
                objSalesModel.GrandTotalSales = Convert.ToDecimal(totalAmtStr1);
                objsalesdetail.Add(objSalesModel);
            }
            Common.DynamicNameAndAddress(reportViewer1);
            ReportDataSource dsSalesOrder = new ReportDataSource("dsTotalSales", objsalesdetail);
            localReport.DataSources.Add(dsSalesOrder);
            reportViewer1.Refresh();
        }

       
    }
}
