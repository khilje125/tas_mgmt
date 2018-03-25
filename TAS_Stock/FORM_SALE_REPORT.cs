using Microsoft.Reporting.WinForms;
using ReportModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class FORM_SALE_REPORT : Form
    {
        Order aOrder = new Order();
         public  FORM_SALE_REPORT()
        {
            InitializeComponent();
        }

        private void FORM_SALE_REPORT_Load(object sender, EventArgs e)
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

            reportViewer1.LocalReport.ReportPath = (@"Reports/SaleReportBydate.rdlc");
        // reportViewer1.LocalReport.ReportPath = "../../SaleReportBydate.rdlc";

            //object totalAmtStr1 = aTable.Compute("Sum(AmountafterDiscount)", "");


            //List<SalesModel> objsalesdetail = new List<SalesModel>();
            //foreach (DataRow row in aTable.Rows)
            //{
            //    SalesModel objSalesModel = new SalesModel();

            //    objSalesModel.ProductName = (row["PRO_NAME"].ToString());
            //    objSalesModel.ProductCategory = (row["CAT_NAME"].ToString());
            //    objSalesModel.ProductConfig1 = (row["ProductConfig1"].ToString());
            //    objSalesModel.ProductConfig2 = (row["ProductConfig2"].ToString());
            //    objSalesModel.ProductPrice = Convert.ToDecimal(row["PRICE"].ToString());
            //    objSalesModel.ProductQuantity = Convert.ToInt32(row["QTE"].ToString());
            //    objSalesModel.ProductTOTAL = Convert.ToDecimal(row["TOTAL"].ToString());
            //    objSalesModel.ProductDiscount = Convert.ToDecimal(row["dicount"]);
            //    objSalesModel.ProductFinalPrice = Convert.ToDecimal(row["AmountafterDiscount"]);
            //    objSalesModel.DateFrom = Convert.ToDateTime(fromdate).ToString("dd/MM/yyyy");
            //    objSalesModel.DateTo = Convert.ToDateTime(totdate).ToString("dd/MM/yyyy");
            //    objSalesModel.GrandTotalSales = Convert.ToDecimal(totalAmtStr1);

            //    objsalesdetail.Add(objSalesModel);

            //}

            ReportParameter[] param = new ReportParameter[4];
            param[0] = new ReportParameter("DateFrom", Convert.ToDateTime(fromdate).ToString("dd/MM/yyyy"));
            param[1] = new ReportParameter("DateTo", Convert.ToDateTime(totdate).ToString("dd/MM/yyyy"));
            string schoolName = ConfigurationManager.AppSettings["SchoolNAME"].ToString();
            string SchoolAddress = ConfigurationManager.AppSettings["SchoolAddress"].ToString();
       
            param[2] = new ReportParameter("SchoolName", schoolName);
            param[3] = new ReportParameter("SchoolAddress", SchoolAddress);
            reportViewer1.LocalReport.SetParameters(param);
            //Common.DynamicNameAndAddress(reportViewer1);
            ReportDataSource dsSalesOrder = new ReportDataSource("DataSet1", aTable);
            localReport.DataSources.Add(dsSalesOrder);
            reportViewer1.Refresh();




        }

        public void GetDailySale(string fromdate, string totdate)
        {

            DataTable aTable = aOrder.genratedailySales(fromdate, totdate);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;

           reportViewer1.LocalReport.ReportPath = (@"Reports/DailySaleReport.rdlc");
           // reportViewer1.LocalReport.ReportPath = "../../DailySaleReport.rdlc";


            //ReportParameter[] param = new ReportParameter[2];
            ////param[0] = new ReportParameter("DateFrom", Convert.ToDateTime(fromdate).ToString("dd/MM/yyyy"));
            ////param[1] = new ReportParameter("DateTo", Convert.ToDateTime(totdate).ToString("dd/MM/yyyy"));
            //string schoolName = ConfigurationManager.AppSettings["SchoolNAME"].ToString();
            //string SchoolAddress = ConfigurationManager.AppSettings["SchoolAddress"].ToString();

            //param[2] = new ReportParameter("SchoolName", schoolName);
            ////param[3] = new ReportParameter("SchoolAddress", SchoolAddress);
            //reportViewer1.LocalReport.SetParameters(param);
            Common.DynamicNameAndAddress(reportViewer1);
            ReportDataSource dsSalesOrder = new ReportDataSource("dsDailySale", aTable);
            localReport.DataSources.Add(dsSalesOrder);
            reportViewer1.Refresh();




        }
    }
}
