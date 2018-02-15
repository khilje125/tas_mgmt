﻿using System;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class FORM_ALL_ORDERS : Form
    {
        Order order = new Order();
        public FORM_ALL_ORDERS()
        {
            InitializeComponent();
        }

        // Print The Selected Order in PDF File Using iTextSharp
        private void BTN_PRINT_ORDER_Click(object sender, EventArgs e)
        {
            try
            {

                SaleReport ar = new SaleReport();
                ar.ReportViewerTest(Convert.ToInt32(Convert.ToInt32(DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString())));
                ar.ShowDialog();
            }
            catch (Exception ex )
            {
                MessageBox.Show("Order Faild " + ex.Message, "",MessageBoxButtons.AbortRetryIgnore);
              
            }





            //FileStream fs = new FileStream(@"E:\TestingDoc2.pdf", FileMode.Create);
            //Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            //PdfWriter writer = PdfWriter.GetInstance(document, fs);
            //document.AddAuthor("kaleem");
            //document.AddCreator("Inventory App");
            //document.AddKeywords("Order");
            //document.AddSubject("Customer Order");
            //document.AddTitle("Order Details");

            //// Open the document to enable you to write to the document
            //document.Open();
            //PdfPTable table = new PdfPTable(5);
            //DataTable SelectedOrderDetails = new DataTable();
            //String totalOrderAmount = order.getOrderTotalAmount(Convert.ToInt32(DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString())).Rows[0][0].ToString();
            //string ordId = DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString();
            //string ordDate = DGV_ALL_ORDERS.CurrentRow.Cells[3].Value.ToString();
            //SelectedOrderDetails = order.getOrderDetails(Convert.ToInt32(DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString()));
            //PdfPCell cellHeader = new PdfPCell(new Phrase("Order " + ordId+" Details"));
            //cellHeader.Colspan = 5;
            //cellHeader.HorizontalAlignment = 1;
            //cellHeader.ExtraParagraphSpace = 20;
            //table.AddCell(cellHeader);
            //table.AddCell("Product Id");
            //table.AddCell("Product Name");
            //table.AddCell("Qty");
            //table.AddCell("Price");
            //table.AddCell("Qty x Price");
         
            //for (int i = 0; i < SelectedOrderDetails.Rows.Count; i++)
            //{
            //    table.AddCell(SelectedOrderDetails.Rows[i][0].ToString());
            //    table.AddCell(SelectedOrderDetails.Rows[i][1].ToString());
            //    table.AddCell(SelectedOrderDetails.Rows[i][2].ToString());
            //    table.AddCell(SelectedOrderDetails.Rows[i][3].ToString());
            //    table.AddCell(SelectedOrderDetails.Rows[i][4].ToString());
            //}

            //string custFullName = DGV_ALL_ORDERS.CurrentRow.Cells[1].Value.ToString() + " " + DGV_ALL_ORDERS.CurrentRow.Cells[2].Value.ToString();
            
            //Paragraph prg = new Paragraph("Order Date : "+ordDate+"\n\n\nCustomer : "+ custFullName+"\n"+"Order Id : "+ordId+"\n\n");

            //PdfPCell cellAmount = new PdfPCell(new Phrase("Total Amount : " + totalOrderAmount));
            //cellAmount.HorizontalAlignment = 2;
            //cellAmount.Colspan = 5;

            //document.Add(prg);
            //table.AddCell(cellAmount);
            
            //document.Add(table);
            ////document.Add(prg);
            //// Close the document
            //document.Close();
            //// Close the writer instance
            //writer.Close();
            //// Always close open filehandles explicity
            //fs.Close();
            //MessageBox.Show("Report Generated Successfully");
        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FORM_ALL_ORDERS_Load(object sender, EventArgs e)
        {

        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
