using System;
using System.Windows.Forms;

namespace TAS_Stock
{
    public partial class CashbookForm : Form
    {
        CashBook cb = new CashBook();
        public CashbookForm()
        {
            InitializeComponent();

            lblcurrentOrderAmount.Text =Convert.ToString(Form1.currentInvoiceTotal);
        }

        private void ddlPayment_SelectedIndexChanged(object sender, EventArgs e)
        {        
            try
            {
              
                if (ddlPayment.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Select Payment Type First");
                }
                else if (ddlPayment.SelectedIndex == 1) // if invoice credit
                {
                    BTN_Order.Visible = true;
                    lblcashamount.Visible = false;
                    textBoxcashamount.Visible = false;
                    textBoxcheque.Visible = false;
                    textBoxcheckamount.Visible = false;
                    lblcheckno.Visible = false;
                    lblcheckamount.Visible = false;
                    lblbankname.Visible = false;
                    textBoxBankName.Visible = false;
                    lblAccountTitle.Visible = false;
                    textBoxaccountTitle.Visible = false;
                    lblcheckdate.Visible = false;
                    dtCheckDate.Visible = false;
                    groupBoxmulticheque.Visible = false; ;
                    brnaddmore.Visible = false;
                   
                }
                else if (ddlPayment.SelectedIndex == 2) //if inovice in cheque
                {

                    groupBoxmulticheque.Visible = false; 
                    brnaddmore.Visible = true;
                    BTN_Order.Visible = true;
                    lblcashamount.Visible = false;
                    textBoxcashamount.Visible = false;
                    textBoxcheque.Visible = true;
                    textBoxcheckamount.Visible = true;
                    lblcheckno.Visible = true;
                    lblcheckamount.Visible = true;
                    lblbankname.Visible = true;
                    textBoxBankName.Visible = true;
                    lblAccountTitle.Visible = true;
                    textBoxaccountTitle.Visible = true;
                    lblcheckdate.Visible = true;
                    dtCheckDate.Visible = true;
                }
                else if (ddlPayment.SelectedIndex == 3 || ddlPayment.SelectedIndex == 5) //if inovice in cash
                {   lblcashamount.Visible = true;
                  
                   
                    groupBoxmulticheque.Visible = false; ;
                    brnaddmore.Visible = false;
                    textBoxcashamount.Visible = true;
                    BTN_Order.Visible = true;
                    if (ddlPayment.SelectedIndex == 5)
                    {
                        textBoxcashamount.Text = lblcurrentOrderAmount.Text;
                        textBoxcashamount.ReadOnly = false;
                    }
                    else
                    {
                        textBoxcashamount.Text = lblcurrentOrderAmount.Text;
                        textBoxcashamount.ReadOnly = true;
                    }
                  
                    textBoxcheque.Visible = false;
                    textBoxcheckamount.Visible = false;
                    lblcheckno.Visible = false;
                    lblcheckamount.Visible = false;
                    lblbankname.Visible = false;
                    textBoxBankName.Visible = false;
                    lblAccountTitle.Visible = false;
                    textBoxaccountTitle.Visible = false;
                    lblcheckdate.Visible = false;
                    dtCheckDate.Visible = false;
                }
                else if (ddlPayment.SelectedIndex == 4) //if inovice in cash & cheque
                {
                  
                    brnaddmore.Visible = true;
                    BTN_Order.Visible = true;
                    textBoxcheque.Visible = true;
                    lblcashamount.Visible = true;
                    textBoxcashamount.Text = "";
                    lblcashamount.Visible = true;
                    textBoxcheckamount.Visible = true;
                    lblcashamount.Visible = true;
                    lblcheckno.Visible = true;
                    textBoxcashamount.Visible = true;
                    lblcheckamount.Visible = true;
                    textBoxcheckamount.Visible = true;
                    lblbankname.Visible = true;
                    textBoxBankName.Visible = true;
                    lblAccountTitle.Visible = true;
                    textBoxaccountTitle.Visible = true;
                    lblcheckdate.Visible = true;
                    dtCheckDate.Visible = true;
                }
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }

        private void BTN_Order_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("Do You Want to Generate This Order?", "Gernerate Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    int invoiceId = 0;

                    decimal orderTotal = Form1.currentInvoiceTotal;
                    var customerID = Form1.currentCustomerId;
                    var orderDate = Form1.currentOrderDate;
                    decimal val1 = 0;
                    decimal val2 = getSafeStringToDecimal(textBoxcheckAmount1.Text);
                    decimal val3 = getSafeStringToDecimal(textBoxcheckAmount2.Text);
                    decimal val4 = getSafeStringToDecimal(textBoxcheckAmount3.Text);
                    decimal val5 = getSafeStringToDecimal(textBoxcheckAmount4.Text);
                    decimal val6 = getSafeStringToDecimal(textBoxcheckAmount5.Text);
                    decimal val7 = 0;
                    decimal perviousbalence = getSafeStringToDecimal(lblcurrentOrderAmount.Text);
                    if (ddlPayment.SelectedIndex == 2)// cheque
                    {
                        val1 = Convert.ToDecimal(textBoxcheckamount.Text);
                        decimal checkedbalnce = Convert.ToDecimal(val1 + val2 + val3 + val4 + val5 + val6);
                        if (perviousbalence == checkedbalnce)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Amount is not equal to actual invoice." + Environment.NewLine + "Amount must be equal to the invoice amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                    }
                    if (ddlPayment.SelectedIndex == 4)
                    {
                        val1 = getSafeStringToDecimal(textBoxcashamount.Text.Trim());
                        val7 = getSafeStringToDecimal(textBoxcheckamount.Text.Trim());
                        decimal checkedbalnce1 = Convert.ToDecimal(val7+val1 + val2 + val3 + val4 + val5 + val6);
                        if (perviousbalence == checkedbalnce1)
                        {
                        }
                        else
                        {
                            MessageBox.Show("Amount is not equal to actual invoice." + Environment.NewLine + "Amount must be equal to the invoice amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                    }
                    int generatedOrderID = processOrder();
                    if (generatedOrderID > 0)
                    {
                        if (ddlPayment.SelectedIndex == 1) //total on credit
                        {
                            GenerateCashbook(generatedOrderID, customerID, ddlPayment.SelectedIndex, orderTotal, 0, 0, orderDate.ToShortDateString());
                        }
                        if (ddlPayment.SelectedIndex == 2)// cheque
                        {
                            string checkNumber = textBoxcheque.Text.Trim();
                            decimal checkAmount = Convert.ToDecimal(textBoxcheckamount.Text.ToLower().Trim());
                            decimal cashAmount = 0;
                            string checkBankName = textBoxBankName.Text.Trim();
                            string checkAccountTile = textBoxaccountTitle.Text.Trim();
                            string checkClearingDate = dtCheckDate.Text;
                            invoiceId = GenerateCashbook(generatedOrderID, customerID, ddlPayment.SelectedIndex, orderTotal, 0, checkAmount, orderDate.ToShortDateString(), checkNumber, checkAccountTile, checkBankName, checkClearingDate);
                            cb.InsertBankCheque(customerID, invoiceId, checkNumber, checkAmount, checkBankName, checkClearingDate.ToString(), checkAccountTile);
                            invoiceId = MultipleChequeHandle(invoiceId, generatedOrderID, orderTotal, customerID, orderDate);
                        }
                        if (ddlPayment.SelectedIndex == 3 || ddlPayment.SelectedIndex == 5)// cash
                        {
                            string checkNumber = string.Empty;
                            decimal checkAmount = 0;
                            decimal cashAmount = Convert.ToDecimal(textBoxcashamount.Text.ToLower().Trim());
                            string checkBankName = string.Empty;
                            string checkAccountTile = string.Empty;
                            string checkClearingDate = string.Empty;
                            invoiceId = GenerateCashbook(generatedOrderID, customerID, ddlPayment.SelectedIndex, orderTotal, cashAmount, 0, orderDate.ToShortDateString(), null, null, null, null);
                        }
                        if (ddlPayment.SelectedIndex == 4) // cheque and cash
                        {

                            string checkNumber = textBoxcheque.Text.Trim();
                            decimal checkAmount = Convert.ToDecimal(textBoxcheckamount.Text.ToLower().Trim());
                            decimal cashAmount = Convert.ToDecimal(textBoxcashamount.Text.ToLower().Trim()); ;
                            string checkBankName = textBoxBankName.Text.Trim();
                            string checkAccountTile = textBoxaccountTitle.Text.Trim();
                            string checkClearingDate = dtCheckDate.Text;
                            invoiceId = GenerateCashbook(generatedOrderID, customerID, ddlPayment.SelectedIndex, orderTotal, cashAmount, checkAmount, orderDate.ToShortDateString(), checkNumber, checkAccountTile, checkBankName, checkClearingDate);
                            invoiceId = MultipleChequeHandle(invoiceId, generatedOrderID, orderTotal, customerID, orderDate);
                            cb.InsertBankCheque(customerID, invoiceId, checkNumber, checkAmount, checkBankName, checkClearingDate.ToString(), checkAccountTile);


                        }
                        MessageBox.Show("Your order completed successfully.\n\r Invoice Generating...");
                        Form1 a = new Form1();
                        a.Close();
                        SaleReport ar = new SaleReport();
                        ar.ReportViewerTest(Convert.ToInt32(generatedOrderID));
                        ar.ShowDialog();
                        BTN_Order.Visible = true;
                        BTN_Order.Visible = false;
                        button1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error", "Order NOT Generated", MessageBoxButtons.OK);
                    }
                }
                else
                {
                }


               
            }
            catch (Exception ec)
            { MessageBox.Show(ec.Message); }
               
            return;
              
        }
        private int MultipleChequeHandle(int invoiceId, int generatedOrderID, decimal orderTotal, int customerID, DateTime orderDate)
        {
            string _multiplevale = dateTimePickerOrder1.Value.ToString()  + "," + getSafeStringToDecimal(textBoxcheckAmount1.Text.Trim()) + "," + textBoxbankname1.Text.Trim() + "," + textBoxbankno1.Text.Trim() + "," + textBoxbanktitle1.Text;
            string[] strcheck1 = _multiplevale.Split(',');
            string _multiplevale2 = dateTimePickerOrder2.Value.ToString() + "," + getSafeStringToDecimal(textBoxcheckAmount2.Text.Trim()) + "," + textBoxbankname2.Text.Trim() + "," + textBoxbankno2.Text.Trim() + "," + textBoxbanktitle2.Text;
            string[] strcheck2 = _multiplevale2.Split(',');
            string _multiplevale3 = dateTimePickerOrder3.Value.ToString() + "," + getSafeStringToDecimal(textBoxcheckAmount3.Text.Trim()) + "," + textBoxbankname3.Text.Trim() + "," + textBoxbankno3.Text.Trim() + "," + textBoxbanktitle3.Text;
            string[] strcheck3 = _multiplevale3.Split(',');
            string _multiplevale4 = dateTimePickerOrder4.Value.ToString() + "," + getSafeStringToDecimal(textBoxcheckAmount4.Text.Trim()) + "," + textBoxbankname4.Text.Trim() + "," + textBoxbankno4.Text.Trim() + "," + textBoxbanktitle4.Text;
            string[] strcheck4 = _multiplevale4.Split(',');
            string _multiplevale5 = dateTimePickerOrder5.Value.ToString() + "," + getSafeStringToDecimal(textBoxcheckAmount5.Text.Trim()) + "," + textBoxbankname5.Text.Trim() + "," + textBoxbankno5.Text.Trim() + "," + textBoxbanktitle5.Text;
            string[] strcheck5 = _multiplevale5.Split(',');
            // multiple payment proce 1
            decimal checkAmount1 = Convert.ToDecimal(strcheck1[1]);
            if (checkAmount1 != 0)
            {
                string checkNumber1 = strcheck1[3].ToString();
                decimal checkAmounts = checkAmount1;
                string checkBankName1 = strcheck1[2].ToString();
                string checkAccountTile1 = strcheck1[1].ToString();
                string checkClearingDate1 = strcheck1[0].ToString();
                invoiceId = GenerateCashbook(generatedOrderID, customerID, ddlPayment.SelectedIndex, orderTotal, 0, checkAmount1, orderDate.ToShortDateString(), checkNumber1, checkAccountTile1, checkBankName1, checkClearingDate1);
                cb.InsertBankCheque(customerID, invoiceId, checkNumber1, checkAmount1, checkBankName1, checkClearingDate1.ToString(), checkAccountTile1);
            }
            decimal checkAmount2 = Convert.ToDecimal(strcheck2[1]);
            if (checkAmount2 != 0)
            {
                string checkNumber2 = strcheck2[3].ToString();
                decimal checkAmounts = checkAmount2;
                string checkBankName2 = strcheck2[2].ToString();
                string checkAccountTile2 = strcheck2[1].ToString();
                string checkClearingDate2 = strcheck2[0].ToString();
                invoiceId = GenerateCashbook(generatedOrderID, customerID, ddlPayment.SelectedIndex, orderTotal, 0, checkAmount2, orderDate.ToShortDateString(), checkNumber2, checkAccountTile2, checkBankName2, checkClearingDate2);

                cb.InsertBankCheque(customerID, invoiceId, checkNumber2, checkAmount2, checkBankName2, checkClearingDate2.ToString(), checkAccountTile2);
            }
            decimal checkAmount3 = Convert.ToDecimal(strcheck3[1]);
            if  ( checkAmount3 != 0)
            {
                string checkNumber3 = strcheck3[3].ToString();
                decimal checkAmounts = checkAmount3;

                string checkBankName3 = strcheck3[2].ToString();
                string checkAccountTile3 = strcheck3[1].ToString();
                string checkClearingDate3 = strcheck3[0].ToString();
                invoiceId = GenerateCashbook(generatedOrderID, customerID, ddlPayment.SelectedIndex, orderTotal, 0, checkAmount1, orderDate.ToShortDateString(), checkNumber3, checkAccountTile3, checkBankName3, checkClearingDate3);
                cb.InsertBankCheque(customerID, invoiceId, checkNumber3, checkAmount3, checkBankName3, checkClearingDate3.ToString(),checkAccountTile3);
            }
            decimal checkAmount4 = Convert.ToDecimal(strcheck4[1]);
            if (checkAmount4 != 0)
            {
                string checkNumber4 = strcheck4[3].ToString();
                decimal checkAmounts = checkAmount4;
                string checkBankName4 = strcheck4[2].ToString();
                string checkAccountTile4 = strcheck4[1].ToString();
                string checkClearingDate4 = strcheck4[0].ToString();
                invoiceId = GenerateCashbook(generatedOrderID, customerID, ddlPayment.SelectedIndex, orderTotal, 0, checkAmount1, orderDate.ToShortDateString(), checkNumber4, checkAccountTile4, checkBankName4, checkClearingDate4);
                cb.InsertBankCheque(customerID, invoiceId, checkNumber4, checkAmount4, checkBankName4, checkClearingDate4.ToString(), checkAccountTile4);
            }
            decimal checkAmount5 = Convert.ToDecimal(strcheck5[1]);
            if (checkAmount5 != 0)
            {
                string checkNumber5 = strcheck5[3].ToString();
                decimal checkAmounts = checkAmount5;
                string checkBankName5 = strcheck5[2].ToString();
                string checkAccountTile5 = strcheck5[1].ToString();
                string checkClearingDate5 = strcheck5[0].ToString();
                invoiceId = GenerateCashbook(generatedOrderID, customerID, ddlPayment.SelectedIndex, orderTotal, 0, checkAmount1, orderDate.ToShortDateString(), checkNumber5, checkAccountTile5, checkBankName5, checkClearingDate5);
                cb.InsertBankCheque(customerID, invoiceId, checkNumber5, checkAmount5, checkBankName5, checkClearingDate5.ToString(),checkAccountTile5);
            }

            return invoiceId;
        }

        private decimal getSafeStringToDecimal(string objValue) {

            if (!String.IsNullOrEmpty(objValue.Trim()))
            {
                return Convert.ToDecimal(objValue);
            }
            else {
                return 0;
            }
        }
        private int GenerateCashbook(int orderId, int customerid, int TransactionType, decimal invoiceAmount, decimal cashAmount, decimal chequeAmount, string orderdate = null, string chequeNo = null, string accountTitle = null, string bankName = null, string checqueDate = null)
        {
            int invoiceId = 0;
            decimal debitAmount = 0;
            decimal creaditAmount = 0;
            try
            {
                int userid = LogginInfo.UserID;
                CashBook cashbook = new CashBook();
                string TransactionDescription = string.Empty;
                if (TransactionType == 1) // if invoice credit
                {
                    TransactionDescription = "Order No:" + orderId + " created on credit";
                    invoiceId = cashbook.insertCashBookOrder(customerid, orderId, TransactionDescription, "", "", "", 0, invoiceAmount, orderdate, userid);
                }
                else if (TransactionType == 2) // if inovice in Cheque
                {
                    if (chequeAmount == invoiceAmount)
                    {
                        TransactionDescription = "Order No:" + orderId + " created on cheque";
                        invoiceId = cashbook.insertCashBookOrder(customerid, orderId, TransactionDescription,chequeNo,bankName,accountTitle, 0, chequeAmount, orderdate, userid);
                     
                    }
                }
                else if (TransactionType == 3) // if inovice in Cash
                {
                    if (cashAmount == invoiceAmount)
                    {
                        TransactionDescription = "Order No:" + orderId + " created on cash";
                        invoiceId = cashbook.insertCashBookOrder(customerid, orderId, TransactionDescription, "", "", "", cashAmount, 0, orderdate, userid);
                        TransactionDescription = "Cash received against order no. :" + orderId;
                        invoiceId = cashbook.insertCashBookOrder(customerid, orderId, TransactionDescription, "", "", "", 0, cashAmount, orderdate, userid);
                    }
                }
              
                else if (TransactionType == 4) // if inovice in cash & cheque
                {
                    TransactionDescription = "Order No:" + orderId + " created partially on cash & partially on cheque";
                    invoiceId = cashbook.insertCashBookOrder(customerid, orderId, TransactionDescription, "", "", "", cashAmount, 0, orderdate, userid);
                    TransactionDescription = "Cash partially received against order no. :" + orderId;
                    invoiceId = cashbook.insertCashBookOrder(customerid, orderId, TransactionDescription,  chequeNo, bankName, accountTitle, 0, cashAmount, orderdate, userid);
                    TransactionDescription = "Chaque partially received against order no. :" + orderId;
                    invoiceId = cashbook.insertCashBookOrder(customerid, orderId, TransactionDescription,  chequeNo, bankName, accountTitle, 0, chequeAmount, orderdate, userid);
                }
                else if (TransactionType == 5) // if inovice in cash & credit
                {
                    decimal leftcreditamount = invoiceAmount - cashAmount;
                    TransactionDescription = "Order No:" + orderId + " created partially on cash & partially on credit";
                    invoiceId = cashbook.insertCashBookOrder(customerid, orderId, TransactionDescription, "", "", "", cashAmount, 0, orderdate, userid);

                    TransactionDescription = "Cash partially received against order no. :" + orderId;
                    invoiceId = cashbook.insertCashBookOrder(customerid, orderId, TransactionDescription, "", "", "", 0, cashAmount, orderdate, userid);

                    TransactionDescription = "On Credit partially against order no. :" + orderId;
                    invoiceId = cashbook.insertCashBookOrder(customerid, orderId, TransactionDescription, "", "", "", 0, leftcreditamount, orderdate, userid);
                }
            }
            catch (Exception ex)
            {
                invoiceId = 0;
            }
            return invoiceId;

        }

        private int processOrder()
        {
            int orderGeneratedId = 0;
            try
            {
                var productsTable = Form1.tblProductOrder;
                var orderTotal = Form1.currentInvoiceTotal;
                var customerID = Form1.currentCustomerId;
                var orderDate = Form1.currentOrderDate;
                string paymentType = "";
                if (ddlPayment.SelectedIndex == 1)
                {
                    paymentType = "On-Credit";
                }
                else if (ddlPayment.SelectedIndex == 2)
                {
                    paymentType = "On-Cheque";
                }
                else if (ddlPayment.SelectedIndex == 3)
                {
                    paymentType = "On-Cash";
                }
                else if (ddlPayment.SelectedIndex == 4)
                {
                    paymentType = "On Cash & Cheque";
                }
                else if (ddlPayment.SelectedIndex == 5)
                {
                    paymentType = "On Cash & Credit";
                }
                Order objOrder = new Order();
                orderGeneratedId = objOrder.insertOrder(orderDate, Convert.ToInt32(customerID), Convert.ToDecimal(orderTotal), Convert.ToInt32(0), paymentType);
                if (orderGeneratedId > 0)

                {
                    for (int i = 0; i < productsTable.Rows.Count-1; i++)
                    {
                        if (productsTable.Rows[i][0] != null)
                        {
                            objOrder.insertOrderDetail(Convert.ToInt32(productsTable.Rows[i][0].ToString()),
                                                                              orderGeneratedId,
                                                                              Convert.ToInt32(productsTable.Rows[i][3].ToString()),
                                                                              productsTable.Rows[i][2].ToString(),
                                                productsTable.Rows[i][4].ToString(), Convert.ToDecimal(productsTable.Rows[i][5].ToString()), Convert.ToDecimal(productsTable.Rows[i][6].ToString()), Convert.ToDecimal(productsTable.Rows[i][7].ToString()));
                        }
                    }
                }
                else {
                    orderGeneratedId = 0;
                }
                return orderGeneratedId;                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return orderGeneratedId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 a = new Form1();
            a.Refresh();
        }

        private void CashbookForm_Load(object sender, EventArgs e)
        {

        }
        private void brnaddmore_Click(object sender, EventArgs e)
        {
            groupBoxmulticheque.Visible = true; ;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
