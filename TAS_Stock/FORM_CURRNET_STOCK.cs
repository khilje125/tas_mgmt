using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ReportModel;

namespace TAS_Stock
{
    public partial class FORM_CURRNET_STOCK : Form
    {
        Order order = new Order();
        public FORM_CURRNET_STOCK()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            GeCurrentStock();
          
        }
        public void GeCurrentStock()
        {

            DataTable aTable = order.GetCurrentStock();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;
           /// reportViewer1.LocalReport.ReportPath = "../../CurrentStock.rdlc";
            reportViewer1.LocalReport.ReportPath = (@"Reports/CurrentStock.rdlc");
            CurrentStock objStockTotal = new CurrentStock();
            List<CurrentStock> objsalesdetail = new List<CurrentStock>();
            foreach (DataRow row in aTable.Rows)
            {
                CurrentStock objcurrentstock = new CurrentStock();
                //objcurrentstock.catid = Convert.ToInt32 (row["CAT_ID"]);
                objcurrentstock.CategoryName = (row["CAT_NAME"].ToString());
                objcurrentstock.ProductName = (row["PRO_NAME"].ToString());
                objcurrentstock.Stock = Convert.ToInt32(row["STOCK"]);
                objcurrentstock.PerUnitPrice = Convert.ToDecimal(row["PRICE"]);
                objcurrentstock.DefaultDiscountInPercent = Convert.ToDecimal(row["Discount"]);
                objcurrentstock.ActualPrice = Convert.ToInt32(row["STOCK"]) * Convert.ToDecimal(row["PRICE"]);
                
                objcurrentstock.DiscountAmount = (((objcurrentstock.PerUnitPrice * objcurrentstock.DefaultDiscountInPercent) / 100) * objcurrentstock.Stock);
                objcurrentstock.PriceAfterDiscount = objcurrentstock.ActualPrice - objcurrentstock.DiscountAmount;
                objsalesdetail.Add(objcurrentstock);

                //objStockTotal.Stock += objcurrentstock.Stock;
                //objStockTotal.PerUnitPrice += 0;
                //objStockTotal.DefaultDiscountInPercent += 0;
                //objStockTotal.ActualPrice += objcurrentstock.ActualPrice;
                //objStockTotal.DiscountAmount += objcurrentstock.DiscountAmount;
                //objStockTotal.PriceAfterDiscount += objcurrentstock.PriceAfterDiscount;
            }
            //objStockTotal.ProductName = "TOTAL";
            //objsalesdetail.Add(objStockTotal);
            Common.DynamicNameAndAddress(reportViewer1);
            ReportDataSource dsSalesOrder = new ReportDataSource("dsStock", objsalesdetail);
            localReport.DataSources.Add(dsSalesOrder);
            reportViewer1.Refresh();
        }

       

        private void FORM_CURRNET_STOCK_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
