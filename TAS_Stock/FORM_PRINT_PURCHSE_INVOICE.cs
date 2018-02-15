using Microsoft.Reporting.WinForms;
using ReportModel;
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
    public partial class FORM_PRINT_PURCHSE_INVOICE : Form
    {
        Order aorder = new Order();
        public FORM_PRINT_PURCHSE_INVOICE()
        {
            InitializeComponent();
        }

        private void FORM_PRINT_PURCHSE_INVOICE_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            GetSalesReturnByCustomer(2);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        public void GetSalesReturnByCustomer(int returnid)
        {

            DataTable aTable = aorder.getCustomerOrders_PurchasedReturn_CutomerInvoic(returnid);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;
            //reportViewer1.LocalReport.ReportPath = (@"Reports/Report3.rdlc");
            reportViewer1.LocalReport.ReportPath = "../../Report3.rdlc";
            


            List<CustomerSalesRetrun> objCustomerSalesRetrun = new List<CustomerSalesRetrun>();
            foreach (DataRow row in aTable.Rows)
            {
                CustomerSalesRetrun objSalesModel = new CustomerSalesRetrun();

                objSalesModel.ProductName = (row["ProducName"].ToString());
               
                objSalesModel.CustomerName = Convert.ToString(row["FIRST_NAME"].ToString()) + "" + Convert.ToString(row["LAST_NAME"].ToString());
                objSalesModel.ProductPrice = Convert.ToDecimal(row["Price"].ToString());
                objSalesModel.ProductQuantity = Convert.ToInt32(row["Qty"].ToString());
                objSalesModel.ProductTOTAL = Convert.ToDecimal(row["Total"].ToString());
                objSalesModel.ProductDiscount = Convert.ToDecimal(row["Discount"]);
            
                objSalesModel.OrderDate = Convert.ToDateTime(row["AddedDate"]).ToString("dd/mm/yyyy");
                objSalesModel.AfterDisPrice = Convert.ToDecimal(row["DiscountedPrice"].ToString());
                objCustomerSalesRetrun.Add(objSalesModel);

            }
            Common.DynamicNameAndAddress(reportViewer1);
            ReportDataSource dsSalesOrder = new ReportDataSource("DataSet1", objCustomerSalesRetrun);
            localReport.DataSources.Add(dsSalesOrder);
            reportViewer1.Refresh();




        }
    
}
}
