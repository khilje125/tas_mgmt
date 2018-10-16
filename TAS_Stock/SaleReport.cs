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
using ReportModel;
using System.IO;


namespace TAS_Stock
{
    public partial class SaleReport : Form
    {
        Order objorder = new Order();
        public SaleReport()
        {
            InitializeComponent();
        }
       // int orderid = 1009;
        private void reportViewer1_Load(object sender, EventArgs e)
        {

           
            //ReportViewerTest(orderid);
        }
        public void ReportViewerTest(int orderid)
        {
            int counter = 1;
            try
            {
                // Set the processing mode for the ReportViewer to Local  
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                LocalReport localReport = reportViewer1.LocalReport;
                reportViewer1.LocalReport.ReportPath = Common.GetReportPath() + "OrderInvoice.rdlc";
                DataTable tblCustomerInvoiceData = objorder.getCustomerDetailsForInvoiceByOrderId(orderid);
                DataTable aTable = objorder.getOrderDetailByOrderid_CustomerId(orderid);
                List<ModelSalesInvoice> lstModelSalesInvoice = new List<ModelSalesInvoice>();
                ModelSalesInvoice objModelSalesInvoice = new ModelSalesInvoice();
                objModelSalesInvoice.OrderId = Convert.ToInt32(tblCustomerInvoiceData.Rows[0]["ORD_ID"]);
                objModelSalesInvoice.SalesPersonName = "Admin"; //(aTable.Rows[0]["USERNAME"].ToString());
                objModelSalesInvoice.SallerAddress = Convert.ToString(tblCustomerInvoiceData.Rows[0]["ADDRESS"].ToString());
                objModelSalesInvoice.SallerName = "Admin";
                objModelSalesInvoice.OrderDate = Convert.ToDateTime(tblCustomerInvoiceData.Rows[0]["ORDER_DATE"].ToString());
                objModelSalesInvoice.OrderToal = Convert.ToDecimal(tblCustomerInvoiceData.Rows[0]["invoiceTotal"].ToString());
                //objModelSalesInvoice.PriceAfterToal = Convert.ToDecimal(tblCustomerInvoiceData.Rows[0]["TOTAL"].ToString());
                objModelSalesInvoice.CustomerName = (tblCustomerInvoiceData.Rows[0]["LAST_NAME"].ToString()) + " " + (tblCustomerInvoiceData.Rows[0]["FIRST_NAME"].ToString());
                objModelSalesInvoice.CustomerAddress = (tblCustomerInvoiceData.Rows[0]["ADDRESS"].ToString());
                objModelSalesInvoice.CustomerPhone = (tblCustomerInvoiceData.Rows[0]["TEL"].ToString());
                //objModelSalesInvoice.AmountDebit = Convert.ToDecimal(tblCustomerInvoiceData.Rows[0]["DebitAmount"].ToString());
                //objModelSalesInvoice.AmountCredit = Convert.ToDecimal(tblCustomerInvoiceData.Rows[0]["CreditAmount"].ToString());
                if (Convert.ToInt32(tblCustomerInvoiceData.Rows[0]["CustomerOrderCount"])==1)
                {
                    objModelSalesInvoice.RemainingBalance = 0;
                }
                else
                {
                    if (Convert.ToDecimal(tblCustomerInvoiceData.Rows[0]["Transactionbalance"].ToString()) > 0)
                    {
                        objModelSalesInvoice.RemainingBalance = Convert.ToDecimal(tblCustomerInvoiceData.Rows[0]["Transactionbalance"].ToString());
                    }
                    else
                    {
                        objModelSalesInvoice.RemainingBalance = 0;
                    }
                    //objModelSalesInvoice.RemainingBalance = objModelSalesInvoice.AmountCredit - objModelSalesInvoice.AmountDebit- objModelSalesInvoice.OrderToal ;
                 
                }
              

                objModelSalesInvoice.PaymentType = Convert.ToString(tblCustomerInvoiceData.Rows[0]["PaymentType"].ToString());

                List<ProductOrderDetail> lstProductOrderDetail = new List<ProductOrderDetail>();
                //for (int i = 0; i < aTable.Rows.Count; i++)
                double ProductTotal = 0;
                foreach (DataRow row in aTable.Rows )
                {
                   
                    ProductOrderDetail objProductOrderDetail = new ProductOrderDetail();
                    objProductOrderDetail.SrNo = Convert.ToInt32(counter++);
                    objProductOrderDetail.ProductName = (row["PRO_NAME"].ToString());
                    objProductOrderDetail.ProductCategory = (row["CAT_NAME"].ToString());
                    objProductOrderDetail.ProductConfig1 = (row["ProductConfig1"].ToString());
                    objProductOrderDetail.ProductConfig2 = (row["ProductConfig2"].ToString());
                    objProductOrderDetail.ProductDesc = (row["TEL"].ToString());
                    objProductOrderDetail.ProductId = Convert.ToInt32(row["PRO_ID"].ToString());
                    objProductOrderDetail.ProductPricePerUnit = Convert.ToDecimal(row["PRICE"]);
                    objProductOrderDetail.ProductQuantity = Convert.ToInt32(row["QTE"]);
                    //[ProductDiscountAmount]
                    decimal diccountedAmount = (Convert.ToDecimal(row["PRICE"]) * Convert.ToDecimal(row["dicount"])/100);
                    //decimal diccountedAmount = Convert.ToDecimal(row["PRICE"]) * Convert.ToInt32(row["QTE"]);
                    decimal actualdiscount = (Convert.ToDecimal(row["PRICE"]) - diccountedAmount);//;* Convert.ToDecimal(row["dicount"]) / 100;
                    objProductOrderDetail.ProductDiscount = Convert.ToDecimal(row["dicount"]);
                    objProductOrderDetail.ProductDiscountAmount = actualdiscount;
                    objProductOrderDetail.ProductFinalPrice = Convert.ToDecimal(row["AmountafterDiscount"]);
                    lstProductOrderDetail.Add(objProductOrderDetail);

                }
                //ReportViewer rp = new ReportViewer();
                //List<string> ls = new List<string>();
                //ls.Add("Customer Copy");
                //ls.Add("offic Copy");
                //ls.Add("warehouse Copy");
                //foreach (var item in ls)
                //{
                    lstModelSalesInvoice.Add(objModelSalesInvoice);
                    ReportDataSource dsSalesOrder = new ReportDataSource("DataSet1", lstModelSalesInvoice);
                    localReport.DataSources.Add(dsSalesOrder);
                    ReportDataSource dsSalesDetail = new ReportDataSource();
                    dsSalesDetail.Name = "DataSet2";
                    dsSalesDetail.Value = lstProductOrderDetail;
                    localReport.DataSources.Add(dsSalesDetail);
                   Common.DynamicNameAndAddress(reportViewer1);

                    //string schoolName = item.ToString();
                    
                    //ReportParameter[] param = new ReportParameter[1];
                    //param[0] = new ReportParameter("CopyName", schoolName);

                    //reportViewer1.LocalReport.SetParameters(param);  
                //}
              reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        
        }

        private void reportViewer1_Print(object sender, ReportPrintEventArgs e)
        {

        }

        private void SaleReport_Load(object sender, EventArgs e)
        {

        }

        //private void Print_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        PrintDialog printDialog1 = new PrintDialog();
        //        PrintDocument pd = new PrintDocument();

        //        printDialog1.Document = pd;
        //        printDialog1.ShowNetwork = true;
        //        printDialog1.AllowSomePages = true;
        //        printDialog1.AllowSelection = false;
        //        printDialog1.AllowCurrentPage = false;
        //        printDialog1.PrinterSettings.Copies = (short)this.CopiesToPrint;
        //        printDialog1.PrinterSettings.PrinterName = this.PrinterToPrint;
        //        DialogResult result = printDialog1.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            PrintReport(pd);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void PrintReport(PrintDocument pd)
        //{
        //    ReportDocument rDoc = (ReportDocument)crvReport.ReportSource;
        //    // This line helps, in case user selects a different printer 
        //    // other than the default selected.
        //    rDoc.PrintOptions.PrinterName = pd.PrinterSettings.PrinterName;
        //    // In place of Frompage and ToPage put 0,0 to print all pages,
        //    // however in that case user wont be able to choose selection.
        //    rDoc.PrintToPrinter(pd.PrinterSettings.Copies, false, pd.PrinterSettings.FromPage,
        //       pd.PrinterSettings.ToPage);
        //}
        //private void reportViewer1_Print(object sender, CancelEventArgs eventArgs)
        //{
        //    eventArgs.Cancel = true;

        //    var printerSettings = new PrinterSettings();

        //    printerSettings.Copies = 3;
        //    printerSettings.Collate = true;
        //    this.OnPrint
        //    var reportProcessor = new ReportProcessor();
        //    this.reportViewer1_Print
        //    reportProcessor.PrintReport(this.reportViewer1.LocalReport, printerSettings);
        //}


        //reportViewer1.Print += new CancelEventHandler(reportViewer1_Print);
        //void reportViewer1_Print(object sender, CancelEventArgs e)
        //{
        //    e.Cancel = true;
        //    MyCustomPrintFunction();
        //}

    }
}
