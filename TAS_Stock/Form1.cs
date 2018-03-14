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



    public partial class Form1 : Form
    {
        public static decimal currentInvoiceTotal = 0;
        public static DataTable tblProductOrder;
        public static int currentCustomerId = 0;
        public static DateTime currentOrderDate;

        Customer customer = new Customer();
        Categorie category = new Categorie();
        Product product = new Product();
        Order order = new Order();
        CashBook cashbook = new CashBook();
        DB db = new DB();

        public Form1()
        {

            InitializeComponent();
            // populate datagridview and combobox

            try
            {
                string q = "";
                DataTable dtcustomer = customer.getCustomers(q);
                if (dtcustomer.Rows.Count > 0)
                {
                    DGV_CUSTOMER.DataSource = dtcustomer;
                    DGV_CUSTOMER.Columns[0].Visible = false;
                    DGV_CUSTOMER.Columns[3].Visible = false;
                    DGV_CUSTOMER.Columns[4].Visible = false;
                    DGV_CUSTOMER.Columns[5].Visible = false;
                    DGV_CUSTOMER.Columns[6].Visible = false;
                    DGV_CUSTOMER.Columns[7].Visible = false;
                   
                }
                else
                {
                    DGV_CUSTOMER.DataSource = null;
                }
                DataTable dt = category.getCategories();
                if (dt.Rows.Count > 0)
                {
                    COMBO_CATEGORIES.DataSource = dt;
                    COMBO_CATEGORIES.DisplayMember = "CAT_NAME";
                    COMBO_CATEGORIES.ValueMember = "CAT_ID";
                }
                else
                {
                    COMBO_CATEGORIES.DataSource = null;
                }


                if (order.getOrderMaxId().Rows[0][0].ToString() != "")
                {

                    lblOrderTempID.Text = (Convert.ToInt32(order.getOrderMaxId().Rows[0][0].ToString()) + 1).ToString();
                }
                else
                {
                    lblOrderTempID.Text = "0";
                }
            }
            catch (Exception ex)
            {
                // TB_ORDER_ID.Text = 3.ToString();
                MessageBox.Show(ex.Message);

                lblOrderTempID.Text = "0";
            }


            try
            {
                //if (DGV_CUSTOMER.Rows.Count>0)
                //{
                //    lblCustomerName.Text = DGV_CUSTOMER.CurrentRow.Cells[1].Value.ToString() + " " + DGV_CUSTOMER.CurrentRow.Cells[2].Value.ToString();

                //}
                //else {
                lblCustomerName.Text = "[No Customer Select]";

                DataGridViewTextBoxColumn dgvPId = new DataGridViewTextBoxColumn();
                dgvPId.HeaderText = "Id";
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPId);

                DataGridViewTextBoxColumn dgvPn = new DataGridViewTextBoxColumn();
                dgvPn.HeaderText = "Name";
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPn);

                DataGridViewTextBoxColumn dgvcPp = new DataGridViewTextBoxColumn();
                dgvcPp.HeaderText = "Price";
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvcPp);

                DataGridViewTextBoxColumn dgvPq = new DataGridViewTextBoxColumn();
                dgvPq.HeaderText = "Quantity";
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPq);

                DataGridViewTextBoxColumn dgvPt = new DataGridViewTextBoxColumn();
                dgvPt.HeaderText = "Actual Total";
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPt);

                DataGridViewTextBoxColumn dgvPd = new DataGridViewTextBoxColumn();
                dgvPd.HeaderText = "Discount%";
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPd);


                DataGridViewTextBoxColumn dgvPqXp = new DataGridViewTextBoxColumn();
                dgvPqXp.HeaderText = "Quantity X Price";
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPqXp);

                DataGridViewTextBoxColumn dgvAmountAfterDiscount = new DataGridViewTextBoxColumn();
                dgvAmountAfterDiscount.HeaderText = "Discounted Price";
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvAmountAfterDiscount);
                DataGridViewCheckBoxColumn dgvPch = new DataGridViewCheckBoxColumn();
                dgvPch.HeaderText = "Select";
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPch);

                //try
                //{
                //    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                //    imageColumn = (DataGridViewImageColumn)DGV_PRODUCTS.Columns[4];
                //    imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                //    DGV_PRODUCTS.AllowUserToAddRows = false;
                //    DGV_PRODUCTS.RowTemplate.Height = 50;
                //}

                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_PRODUCTS_IN_ORDER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double pricePerUnit = Convert.ToDouble(DGV_PRODUCTS_IN_ORDER.SelectedRows[0].Cells[2].Value.ToString());
            int totalUnit = Convert.ToInt32(DGV_PRODUCTS_IN_ORDER.SelectedRows[0].Cells[3].Value.ToString());
            double _totalPerProduct = pricePerUnit * totalUnit;
            double _discountPrice = Convert.ToDouble(DGV_PRODUCTS_IN_ORDER.SelectedRows[0].Cells[5].Value.ToString());
            double _DiscountPrice = _totalPerProduct * _discountPrice / 100;
            double _totalAfterDiscount = _totalPerProduct - _DiscountPrice;
            DGV_PRODUCTS_IN_ORDER.SelectedRows[0].Cells[6].Value = _totalAfterDiscount;

            lblTotalInvoice.Text = getTotal();

        }

        private void DGV_PRODUCTS_IN_ORDER_SelectionChanged(object sender, EventArgs e)
        {
            string val1 = DGV_PRODUCTS_IN_ORDER.SelectedRows[0].Cells[1].Value.ToString();
            string val2 = DGV_PRODUCTS_IN_ORDER.SelectedRows[0].Cells[0].Value.ToString();
        }
        private void COMBO_CATEGORIES_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(COMBO_CATEGORIES.SelectedValue.ToString(), out val);
            string cri = "";
            DGV_PRODUCTS.DataSource = product.getProductsByCategory(val, cri);
            DGV_PRODUCTS.Columns[0].Visible = false;
            DGV_PRODUCTS.Columns[4].Visible = false;
            DGV_PRODUCTS.Columns[5].Visible = false;
            DGV_PRODUCTS.Columns[7].HeaderText = "CLASS";
            DGV_PRODUCTS.Columns[8].HeaderText = "SECTION";
            DGV_PRODUCTS.Columns[9].Visible = false;
            DGV_PRODUCTS.Columns[10].Visible = false;
            DGV_PRODUCTS.RowTemplate.Height = 23;
           
        }

        private void FORM_MANAGE_ORDER_Load(object sender, EventArgs e)
        {
            COMBO_CATEGORIES_SelectedIndexChanged(null, null);
        }

        private void DGV_PRODUCTS_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                double _DiscountAmount = 0;
                double afterDiscountedAmount = 0;
                double totalamount = 0;
                double discountedamount = 0;
                // get the selected product that you want to add to order
                DataGridViewRow selectedRow = DGV_PRODUCTS.CurrentRow;



                // call add quantity form 
                FORM_QUANTITY fq = new FORM_QUANTITY();

                fq.pro_id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                fq.ShowDialog();

                int index = 0;
                bool isExist = false;// to test if the product is already add

                if (fq.addTheProduct)// test if the user cancel the add product to order | addTheProduct variable is declared in the quantity form
                {

                    string qty = fq.TB_QUANTITY.Text;// get the quantity from the quantity form
                    double quantityXprice = Convert.ToInt32(qty) * Convert.ToDouble(selectedRow.Cells[3].Value.ToString());

                    // if other products exist in the grid
                    if (DGV_PRODUCTS_IN_ORDER.Rows.Count - 1 > 0)
                    {
                        // check if the product is already add and set isExist to true
                        for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
                        {
                            if (selectedRow.Cells[0].Value.ToString() == DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[0].Value.ToString())
                            {
                                isExist = true;
                                index = i;

                            }
                        }

                        // if the product already exist
                        // check the stock quantity
                        if (isExist)
                        {
                            // the quantity sum
                            int pqty = Convert.ToInt32(DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[3].Value.ToString()) +
                                                       Convert.ToInt32(qty);

                            DataTable table = new DataTable();
                            table = product.getProduct(Convert.ToInt32(selectedRow.Cells[0].Value.ToString()));

                            // if the quantity is heigher than the stock quantity than show a message
                            int qty2 = Convert.ToInt32(table.Rows[0]["STOCK_QTE"].ToString());
                            if (pqty > qty2)
                            {
                                MessageBox.Show("Unavailable Quantity", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;

                            }
                            // if quantity is fine add the product 
                            else
                            {
                                double _perUnitPrice = Convert.ToDouble(table.Rows[0]["PRICE"].ToString());
                                totalamount = _perUnitPrice * pqty;// Convert.ToDouble(DGV_PRODUCTS_IN_ORDER.Rows[index].Cell[4].Value);
                                double _Olddiscount = Convert.ToDouble(selectedRow.Cells[9].Value.ToString());
                                //discountedamount = Convert.ToDouble(DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[6].Value);
                                

                                quantityXprice = totalamount;
                                DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[4].Value = quantityXprice.ToString();
                                
                                _DiscountAmount = quantityXprice * _Olddiscount / 100;
                                afterDiscountedAmount = totalamount - _DiscountAmount;
                                DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[3].Value = pqty.ToString();
                                DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[6].Value = _DiscountAmount;
                                DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[7].Value = afterDiscountedAmount.ToString();
                                lblTotalInvoice.Text = getTotal();

                            }

                        }

                        // if the product not exist => add product                  
                        else
                        {
                            int pqty = Convert.ToInt32(DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[3].Value.ToString()) + Convert.ToInt32(qty);
                            double _Olddiscount = 0;
                            if ((selectedRow.Cells[9].Value.ToString()) != "0")
                            {
                                _Olddiscount = Convert.ToDouble(selectedRow.Cells[9].Value.ToString());
                                _DiscountAmount = quantityXprice * _Olddiscount / 100;
                            }
                            else
                            {
                                _DiscountAmount = Convert.ToInt32(quantityXprice.ToString());

                            }
                            //_DiscountAmount = quantityXprice * _Olddiscount / 100;
                            //DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[3].Value = pqty.ToString();
                            //DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[6].Value = quantityXprice - _DiscountAmount;
                            totalamount = Convert.ToDouble(quantityXprice);
                            discountedamount = Convert.ToDouble(_DiscountAmount);
                            afterDiscountedAmount = totalamount - discountedamount;

                            DGV_PRODUCTS_IN_ORDER.Rows.Add(
                                                    selectedRow.Cells[0].Value.ToString(),
                                                    selectedRow.Cells[1].Value.ToString(),
                                                    selectedRow.Cells[3].Value.ToString(),
                                                    qty,
                                                    quantityXprice.ToString(),
                                                   selectedRow.Cells[9].Value.ToString(),
                                                    _DiscountAmount,
                                                    afterDiscountedAmount, false);
                            lblTotalInvoice.Text = getTotal();
                        }
                    }

                    // if the gridview is empty => add product       
                    else if (DGV_PRODUCTS_IN_ORDER.Rows.Count - 1 == 0)
                    {
                        double _Olddiscount = 0;

                        if ((selectedRow.Cells[9].Value.ToString()) != "0")
                        {
                            _Olddiscount = Convert.ToDouble(selectedRow.Cells[9].Value.ToString());
                            _DiscountAmount = quantityXprice * _Olddiscount / 100;
                        }
                        else
                        {
                            _DiscountAmount = Convert.ToInt32(quantityXprice.ToString());

                        }



                        totalamount = Convert.ToDouble(quantityXprice.ToString());
                        discountedamount = Convert.ToDouble(_DiscountAmount);
                        afterDiscountedAmount = totalamount - discountedamount;



                        DGV_PRODUCTS_IN_ORDER.Rows.Add(selectedRow.Cells[0].Value.ToString(),
                                                selectedRow.Cells[1].Value.ToString(),
                                                selectedRow.Cells[3].Value.ToString(),
                                                qty,
                                                quantityXprice.ToString(),
                                                selectedRow.Cells[9].Value.ToString(),
                                                _DiscountAmount
                                                , afterDiscountedAmount, false);
                        lblTotalInvoice.Text = getTotal();
                    }

                    // lblTotalInvoice.Text = getTotal();

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Cancel Quentity Form");
            }
        }

        // calculate the order total amount
        protected internal string getTotal()
        {
            string result = "";
            try
            {
                result = (from DataGridViewRow row in DGV_PRODUCTS_IN_ORDER.Rows
                          where row.Cells[7].FormattedValue.ToString() != string.Empty
                          select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return result;
        }

        // delete the checked products from the datagridview
        private void BTN_DELETE_PRODUCTS_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = DGV_PRODUCTS_IN_ORDER.Rows.Count - 2; i >= 0; i--)
                {
                    bool delete = (bool)DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[7].Value;

                    //if the checkbox cell is checked

                    if (delete == true)
                    {
                        DataGridViewRow rowToRemove = DGV_PRODUCTS_IN_ORDER.Rows[i];

                        DGV_PRODUCTS_IN_ORDER.Rows.Remove(rowToRemove);
                    }
                }

                CB_SELECT_ALL.Checked = false;
                getTotal();




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        // select products to delete from datagridview
        private void CB_SELECT_ALL_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_SELECT_ALL.Checked)
            {
                for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
                {
                    bool delete = (bool)DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[7].Value;

                    if (delete == false)
                    {
                        DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[7].Value = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
                {
                    bool delete = (bool)DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[7].Value;

                    if (delete == true)
                    {
                        DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[7].Value = false;
                    }
                }
            }
        }

        // insrt order with his details
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void BTN_INSERT_ORDER_Click(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToDecimal(lblTotalInvoice.Text) > 0)
                {


                    if (lblCustomerID.Text == "-----")
                    {
                        MessageBox.Show("No Customer Selected", "Error Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (DGV_PRODUCTS_IN_ORDER.RowCount <= 0)
                    {
                        MessageBox.Show("Order Empty", "Not found any product added in your current order.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        tblProductOrder = new DataTable();

                        foreach (DataGridViewColumn column in DGV_PRODUCTS_IN_ORDER.Columns)
                            tblProductOrder.Columns.Add(column.Name, typeof(string));

                        //2. looping through selected rows of dgv, and add them to datatable:
                        for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.RowCount; i++)
                        {
                            tblProductOrder.Rows.Add();
                            for (int j = 0; j < DGV_PRODUCTS_IN_ORDER.Columns.Count; j++)
                            {
                                tblProductOrder.Rows[i][j] = DGV_PRODUCTS_IN_ORDER[j, i].Value;


                                //BindingSource bs = (BindingSource)DGV_PRODUCTS_IN_ORDER.DataSource;
                            }
                            //tblProductOrder = (DataTable)bs.DataSource;
                            //(DataTable)DGV_PRODUCTS_IN_ORDER.DataSource;

                        }
                        if (tblProductOrder.Rows.Count > 0)
                        {
                            currentCustomerId = Convert.ToInt32(lblCustomerID.Text);
                            currentInvoiceTotal = Convert.ToDecimal(lblTotalInvoice.Text);
                            currentOrderDate = dateTimePicker1.Value;
                            CashbookForm cbh = new CashbookForm();
                            cbh.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Order Empty", "Please Generate Order First", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please Generate Order First", "Order Empty", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        // get customer id from selected datagridview selected row into textbox
        private void DGV_CUSTOMER_Click(object sender, EventArgs e)
        {
            lblCustomerID.Text = DGV_CUSTOMER.CurrentRow.Cells[0].Value.ToString();
            lblCustomerName.Text = DGV_CUSTOMER.CurrentRow.Cells[1].Value.ToString() + " " + DGV_CUSTOMER.CurrentRow.Cells[2].Value.ToString();
        }

        // show all the selected customer orders
        private void DGV_CUSTOMER_DoubleClick(object sender, EventArgs e)
        {
            FORM_CUSTOMER_ORDERS fco = new FORM_CUSTOMER_ORDERS();
            fco.DGV_CUSTOMER_ORDERS.DataSource = order.getCustomerOrders(Convert.ToInt32(DGV_CUSTOMER.CurrentRow.Cells[0].Value.ToString()));
            fco.LBL_CUSTOMER.Text = "Customer: " + DGV_CUSTOMER.CurrentRow.Cells[1].Value.ToString() + " " + DGV_CUSTOMER.CurrentRow.Cells[2].Value.ToString();
            fco.ShowDialog();
        }

        // add new customer => call FORM NEW CUSTOMER
        private void BTN_NEW_CUSTOMER_Click(object sender, EventArgs e)
        {
            FORM_NEW_CUSTOMER fnc = new FORM_NEW_CUSTOMER();
            fnc.ShowDialog();
            DGV_CUSTOMER.DataSource = customer.getCustomers();
        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        // show all orders and print to pdf file the selected order
        // ( the orders are orderd from last to first [desc] so you can print your current order by selecting the first one )
        private void BTN_ALL_ORDERS_Click(object sender, EventArgs e)
        {
            FORM_ALL_ORDERS fallOd = new FORM_ALL_ORDERS();
            fallOd.DGV_ALL_ORDERS.DataSource = order.getAllOrders();
            fallOd.ShowDialog();
        }

        private void btngenrateSale_Click(object sender, EventArgs e)
        {
            FORM_SALE frmsale = new FORM_SALE();
            frmsale.ShowDialog();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            this.AcceptButton = BTN_INSERT_ORDER;
            DGV_PRODUCTS.Columns[1].Width = 200;
           
            //this.reportViewer1.RefreshReport();
        }

        private void txtFilterCategory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int val;
                Int32.TryParse(COMBO_CATEGORIES.SelectedValue.ToString(), out val);
                string searchCriteria = txtFilterCategory.Text;
                DGV_PRODUCTS.DataSource = product.getProductsByCategory(0, searchCriteria);
                DGV_PRODUCTS.Columns[0].Visible = false;
                DGV_PRODUCTS.Columns[4].Visible = false;
                DGV_PRODUCTS.Columns[5].Visible = false;
                DGV_PRODUCTS.Columns[7].HeaderText = "CLASS";
                DGV_PRODUCTS.Columns[8].HeaderText = "SECTION";
                DGV_PRODUCTS.Columns[9].Visible = false;
                DGV_PRODUCTS.Columns[10].Visible = false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateDiscount();
            }
            catch (Exception ex)
            {
                string erromage = ex.Message.ToString();
                MessageBox.Show("Value not correct formate");
            }
        }


        private void CalculateDiscount()

        {
            double invoiceTotal = 0;
            double DiscountRate = 0;
            double afterDiscountedAmount = 0;
            double NewPriceAfterDiscount = 0;
            int getCurrentRoewindex = DGV_PRODUCTS_IN_ORDER.CurrentRow.Index;

            if (!string.IsNullOrEmpty(txtdiscoutrate.Text.Trim()) && (txtdiscoutrate.Text != "0") || (txtdiscoutrate.Text != "."))
            {
                double ActualProductPrice = Convert.ToDouble(DGV_PRODUCTS_IN_ORDER.Rows[getCurrentRoewindex].Cells[4].Value);
                DiscountRate = Convert.ToDouble(txtdiscoutrate.Text);

                double discountAmount = ActualProductPrice * DiscountRate / 100;
                NewPriceAfterDiscount = ActualProductPrice - discountAmount;
                
                DGV_PRODUCTS_IN_ORDER.Rows[getCurrentRoewindex].Cells[5].Value = DiscountRate.ToString();
                DGV_PRODUCTS_IN_ORDER.Rows[getCurrentRoewindex].Cells[7].Value = NewPriceAfterDiscount.ToString();
                DGV_PRODUCTS_IN_ORDER.Rows[getCurrentRoewindex].Cells[6].Value = discountAmount.ToString();
                for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count; i++)
                {
                    invoiceTotal = invoiceTotal + Convert.ToDouble(DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[7].Value);



                }
                lblTotalInvoice.Text = invoiceTotal.ToString();

            }
            else
            {
                txtdiscoutrate.Text = "0";
            }
        }

        private void btngenrateSale_Click_1(object sender, EventArgs e)
        {
            FORM_SALE frmsale = new FORM_SALE();
            frmsale.ShowDialog();


        }

        private void BTN_ALL_ORDERS_Click_1(object sender, EventArgs e)
        {
            try
            {
                FORM_ALL_ORDERS fallOd = new FORM_ALL_ORDERS();
                DataTable dt;
                dt = order.getAllOrders();
                if (dt.Rows.Count > 0)
                {
                    fallOd.DGV_ALL_ORDERS.DataSource = dt;
                }
                else
                {
                    fallOd.DGV_ALL_ORDERS.DataSource = null;
                }

                fallOd.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BTN_NEW_CUSTOMER_Click_1(object sender, EventArgs e)
        {
            FORM_MANAGE_CUSTOMER ar = new FORM_MANAGE_CUSTOMER();
            ar.ShowDialog();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            string searchCriteria = txtCustomer.Text;
            DGV_CUSTOMER.DataSource = customer.getCustomers(searchCriteria);
            DGV_CUSTOMER.Columns[0].Visible = false;
            DGV_CUSTOMER.Columns[3].Visible = false;
            DGV_CUSTOMER.Columns[4].Visible = false;
            DGV_CUSTOMER.Columns[5].Visible = false;

        }

        private void BTN_DELETE_PRODUCTS_Click_1(object sender, EventArgs e)
        {
            for (int i = DGV_PRODUCTS_IN_ORDER.Rows.Count - 2; i >= 0; i--)
            {
                bool delete = (bool)DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[8].Value;

                //if the checkbox cell is checked

                if (delete == true)
                {
                    DataGridViewRow rowToRemove = DGV_PRODUCTS_IN_ORDER.Rows[i];

                    DGV_PRODUCTS_IN_ORDER.Rows.Remove(rowToRemove);
                }
            }

            CB_SELECT_ALL.Checked = false;

            lblTotalInvoice.Text = getTotal();
        }

        private void CB_SELECT_ALL_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CB_SELECT_ALL.Checked)
            {
                for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
                {
                    bool delete = (bool)DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[8].Value;

                    if (delete == false)
                    {
                        DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[8].Value = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
                {
                    bool delete = (bool)DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[8].Value;

                    if (delete == true)
                    {
                        DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[8].Value = false;
                    }
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void DGV_PRODUCTS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_CUSTOMER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DGV_PRODUCTS_IN_ORDER.DataSource = null;
            DGV_PRODUCTS_IN_ORDER.Rows.Clear();
            //lblOrderTempID.Text = "";
            lblCustomerName.Text = "[No Customer Select]";
            lblTotalInvoice.Text = "00.00";
            txtdiscoutrate.Text = "0";
        }

       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
