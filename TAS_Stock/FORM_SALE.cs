using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class FORM_SALE : Form
    {
        public FORM_SALE()
        {
            InitializeComponent();
        }


        private void BTN_Print_Sale_Click(object sender, EventArgs e)
        {

            //SALES_TOTAL atot = new SALES_TOTAL();
            FORM_SALE_REPORT fms = new FORM_SALE_REPORT();

            fms.GetTotalSales(dtfrom.Value.ToString(), dtTo.Value.ToString());
            fms.ShowDialog();

           

            //Order aOrder = new Order();

            //string fromdate = dtfrom.Value.ToString();
            //string todate = dtTo.Value.ToString();
            //DataTable getSalesDetail = aOrder.genrateSales(fromdate, todate);

            //FileStream fs = new FileStream(@"E:\TestingDocsale.pdf", FileMode.Create);
            //Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            //PdfWriter writer = PdfWriter.GetInstance(document, fs);
            //document.AddAuthor("kaleem");
            //document.AddCreator("Inventory App");
            //document.AddKeywords("Order");
            //document.AddSubject("Customer Order");
            //document.AddTitle("Order Details");

            //// Open the document to enable you to write to the document
            //document.Open();
            //PdfPTable table = new PdfPTable(10);
            //table.WidthPercentage = 90;
            ////table.setLockedWidth(true);
            //BaseColor myColor = WebColors.GetRGBColor("#4286f4");


            //PdfPCell cellHeader = new PdfPCell(new Phrase("Total Sales Report"));
            //cellHeader.BackgroundColor = myColor;
            //cellHeader.BorderColorRight = myColor;
            //cellHeader.Colspan = 10;

            //cellHeader.HorizontalAlignment = 1;
            //cellHeader.ExtraParagraphSpace = 2;
            //table.AddCell(cellHeader);

            //table.AddCell("Sr#");
            //table.AddCell("Order ID");
            //table.AddCell("Category Name");
            //table.AddCell("Product Name");
            //table.AddCell("Order Date");
            //table.AddCell("Price");
            //table.AddCell("Quentity");
            //table.AddCell("Total");
            //table.AddCell("Discount");
            //table.AddCell("Discounted Price");

            //for (int i = 0; i < getSalesDetail.Rows.Count; i++)
            //{
            //    table.AddCell(getSalesDetail.Rows[i][0].ToString());
            //    table.AddCell(getSalesDetail.Rows[i][1].ToString());
            //    table.AddCell(getSalesDetail.Rows[i][2].ToString());
            //    table.AddCell(getSalesDetail.Rows[i][3].ToString());
            //    table.AddCell(Convert.ToDateTime(getSalesDetail.Rows[i][4]).ToString("dd-yyyy"));
            //    table.AddCell(getSalesDetail.Rows[i][5].ToString());
            //    table.AddCell(getSalesDetail.Rows[i][6].ToString());
            //    table.AddCell(getSalesDetail.Rows[i][7].ToString());
            //    table.AddCell(getSalesDetail.Rows[i][8].ToString());
            //    table.AddCell(getSalesDetail.Rows[i][9].ToString());
            //    //table.AddCell(SelectedOrderDetails.Rows[i][4].ToString());
            //    //table.AddCell(SelectedOrderDetails.Rows[i][5].ToString());
            //}
            //object totalOrderAmount;
            //totalOrderAmount = getSalesDetail.Compute("Sum(DISCOUNTEDPRICE)", "");


            ////string custFullName = "Monthly Sales Report";

            //Paragraph prg = new Paragraph("Order Date : " + dtfrom.Value + "-" + dtTo.Value + "\n\n\n");

            //PdfPCell cellAmount = new PdfPCell(new Phrase("Grand Total Sales : " + totalOrderAmount));
            //cellAmount.HorizontalAlignment = 5;
            //cellAmount.Colspan = 10;

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

        
        private void FORM_SALE_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }


       //  Document document = new Document(PageSize.A4, 70, 70, 70, 70);

    //MemoryStream
    //MemoryStream PDFData = new MemoryStream();
    //PdfWriter writer = PdfWriter.GetInstance(document, PDFData);

    //// First, create our fonts
    //var titleFont = FontFactory.GetFont("Arial", 14, Font.BOLD);
    //var boldTableFont = FontFactory.GetFont("Arial", 10, Font.BOLD);
    //var bodyFont = FontFactory.GetFont("Arial", 10, Font.NORMAL);
    //Rectangle pageSize = writer.PageSize;

    //// Open the Document for writing
    //document.Open();
    ////Add elements to the document here

    //#region Top table
    //// Create the header table 
    //PdfPTable headertable = new PdfPTable(3);
    //headertable.HorizontalAlignment = 0;
    //headertable.WidthPercentage = 100;
    //headertable.SetWidths(new float[] { 4, 2, 4 });  // then set the column's __relative__ widths
    //headertable.DefaultCell.Border = Rectangle.NO_BORDER;
    ////headertable.DefaultCell.Border = Rectangle.BOX; //for testing
    //headertable.SpacingAfter = 30;
    //PdfPTable nested = new PdfPTable(1);
    //nested.DefaultCell.Border = Rectangle.BOX;
    //PdfPCell nextPostCell1 = new PdfPCell(new Phrase("ABC Co.,Ltd", bodyFont));
    //nextPostCell1.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
    //nested.AddCell(nextPostCell1);
    //PdfPCell nextPostCell2 = new PdfPCell(new Phrase("111/206 Moo 9, Ramkhamheang Road,", bodyFont));
    //nextPostCell2.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
    //nested.AddCell(nextPostCell2);
    //PdfPCell nextPostCell3 = new PdfPCell(new Phrase("Nonthaburi 11120", bodyFont));
    //nextPostCell3.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
    //nested.AddCell(nextPostCell3);
    //PdfPCell nesthousing = new PdfPCell(nested);
    //nesthousing.Rowspan = 4;
    //nesthousing.Padding = 0f;
    //headertable.AddCell(nesthousing);

    //headertable.AddCell("");
    //PdfPCell invoiceCell = new PdfPCell(new Phrase("INVOICE", titleFont));
    //invoiceCell.HorizontalAlignment = 2;
    //invoiceCell.Border = Rectangle.NO_BORDER;
    //headertable.AddCell(invoiceCell);
    //PdfPCell noCell = new PdfPCell(new Phrase("No :", bodyFont));
    //noCell.HorizontalAlignment = 2;
    //noCell.Border = Rectangle.NO_BORDER;
    //headertable.AddCell(noCell);
    //headertable.AddCell(new Phrase(orderNo, bodyFont));
    //PdfPCell dateCell = new PdfPCell(new Phrase("Date :", bodyFont));
    //dateCell.HorizontalAlignment = 2;
    //dateCell.Border = Rectangle.NO_BORDER;
    //headertable.AddCell(dateCell);
    //headertable.AddCell(new Phrase(orderDate, bodyFont));
    //PdfPCell billCell = new PdfPCell(new Phrase("Bill To :", bodyFont));
    //billCell.HorizontalAlignment = 2;
    //billCell.Border = Rectangle.NO_BORDER;
    //headertable.AddCell(billCell);
    //headertable.AddCell(new Phrase(txtCustomerName.Text + "\n" + txtAddress.Text, bodyFont));
    //document.Add(headertable);
    //#endregion

    //#region Items Table
    ////Create body table
    //PdfPTable itemTable = new PdfPTable(4);
    //itemTable.HorizontalAlignment = 0;
    //itemTable.WidthPercentage = 100;
    //itemTable.SetWidths(new float[] { 10, 40, 20, 30 });  // then set the column's __relative__ widths
    //itemTable.SpacingAfter = 40;
    //itemTable.DefaultCell.Border = Rectangle.BOX;
    //PdfPCell cell1 = new PdfPCell(new Phrase("NO", boldTableFont));
    //cell1.HorizontalAlignment = 1;
    //itemTable.AddCell(cell1);
    //PdfPCell cell2 = new PdfPCell(new Phrase("ITEM", boldTableFont));
    //cell2.HorizontalAlignment = 1;
    //itemTable.AddCell(cell2);
    //PdfPCell cell3 = new PdfPCell(new Phrase("QUANTITY", boldTableFont));
    //cell3.HorizontalAlignment = 1;
    //itemTable.AddCell(cell3);
    //PdfPCell cell4 = new PdfPCell(new Phrase("AMOUNT(USD)", boldTableFont));
    //cell4.HorizontalAlignment = 1;
    //itemTable.AddCell(cell4);

    //foreach (DataRow row in dt.Rows)
    //{
    //    PdfPCell numberCell = new PdfPCell(new Phrase(row["NO"].ToString(), bodyFont));
    //    numberCell.HorizontalAlignment = 0;
    //    numberCell.PaddingLeft = 10f;
    //    numberCell.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
    //    itemTable.AddCell(numberCell);

    //    PdfPCell descCell = new PdfPCell(new Phrase(row["ITEM"].ToString(), bodyFont));
    //    descCell.HorizontalAlignment = 0;
    //    descCell.PaddingLeft = 10f;
    //    descCell.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
    //    itemTable.AddCell(descCell);

    //    PdfPCell qtyCell = new PdfPCell(new Phrase(row["QUANTITY"].ToString(), bodyFont));
    //    qtyCell.HorizontalAlignment = 0;
    //    qtyCell.PaddingLeft = 10f;
    //    qtyCell.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
    //    itemTable.AddCell(qtyCell);

    //    PdfPCell amtCell = new PdfPCell(new Phrase(row["AMOUNT"].ToString(), bodyFont));
    //    amtCell.HorizontalAlignment = 1;
    //    amtCell.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
    //    itemTable.AddCell(amtCell);

    //}
    //// Table footer
    //PdfPCell totalAmtCell1 = new PdfPCell(new Phrase(""));
    //totalAmtCell1.Border = Rectangle.LEFT_BORDER | Rectangle.TOP_BORDER;
    //itemTable.AddCell(totalAmtCell1);
    //PdfPCell totalAmtCell2 = new PdfPCell(new Phrase(""));
    //totalAmtCell2.Border = Rectangle.TOP_BORDER; //Rectangle.NO_BORDER; //Rectangle.TOP_BORDER;
    //itemTable.AddCell(totalAmtCell2);
    //PdfPCell totalAmtStrCell = new PdfPCell(new Phrase("Total Amount", boldTableFont));
    //totalAmtStrCell.Border = Rectangle.TOP_BORDER;   //Rectangle.NO_BORDER; //Rectangle.TOP_BORDER;
    //totalAmtStrCell.HorizontalAlignment = 1;
    //itemTable.AddCell(totalAmtStrCell);
    //PdfPCell totalAmtCell = new PdfPCell(new Phrase(totalAmtStr.ToString("#,###.00"), boldTableFont));
    //totalAmtCell.HorizontalAlignment = 1;
    //itemTable.AddCell(totalAmtCell);

    //PdfPCell cell = new PdfPCell(new Phrase("*** Please note that ABC Co., Ltd’s bank account is USD Bank Account ***", bodyFont));
    //cell.Colspan = 4;
    //cell.HorizontalAlignment = 1;
    //itemTable.AddCell(cell);
    //document.Add(itemTable);
    //#endregion

    //Chunk transferBank = new Chunk("Your Bank Account:", boldTableFont);
    //transferBank.SetUnderline(0.1f, -2f); //0.1 thick, -2 y-location
    //document.Add(transferBank);
    //document.Add(Chunk.NEWLINE);

    //// Bank Account Info
    //PdfPTable bottomTable = new PdfPTable(3);
    //bottomTable.HorizontalAlignment = 0;
    //bottomTable.TotalWidth = 300f;
    //bottomTable.SetWidths(new int[] { 90, 10, 200 });
    //bottomTable.LockedWidth = true;
    //bottomTable.SpacingBefore = 20;
    //bottomTable.DefaultCell.Border = Rectangle.NO_BORDER;
    //bottomTable.AddCell(new Phrase("Account No", bodyFont));
    //bottomTable.AddCell(":");
    //bottomTable.AddCell(new Phrase(accountNo, bodyFont));
    //bottomTable.AddCell(new Phrase("Account Name", bodyFont));
    //bottomTable.AddCell(":");
    //bottomTable.AddCell(new Phrase(accountName, bodyFont));
    //bottomTable.AddCell(new Phrase("Branch", bodyFont));
    //bottomTable.AddCell(":");
    //bottomTable.AddCell(new Phrase(branch, bodyFont));
    //bottomTable.AddCell(new Phrase("Bank", bodyFont));
    //bottomTable.AddCell(":");
    //bottomTable.AddCell(new Phrase(bank, bodyFont));
    //document.Add(bottomTable);

    ////Approved by
    //PdfContentByte cb = new PdfContentByte(writer);
    //BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
    //cb = writer.DirectContent;
    //cb.BeginText();
    //cb.SetFontAndSize(bf, 10);
    //cb.SetTextMatrix(pageSize.GetLeft(300), 200);
    //cb.ShowText("Approved by,");
    //cb.EndText();
    ////Image Singature
    //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Server.MapPath("~/Images/Bill_Gates2.png"));
    //logo.SetAbsolutePosition(pageSize.GetLeft(300), 140);
    //document.Add(logo);

    //cb = new PdfContentByte(writer);
    //bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
    //cb = writer.DirectContent;
    //cb.BeginText();
    //cb.SetFontAndSize(bf, 10);
    //cb.SetTextMatrix(pageSize.GetLeft(70), 100);
    //cb.ShowText("Thank you for your business! If you have any questions about your order, please contact us at 800-555-NORTH.");
    //cb.EndText();

    //writer.CloseStream = false; //set the closestream property
    //// Close the Document without closing the underlying stream
    //document.Close();
    }
}
