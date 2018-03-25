using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAS_Stock
{
    class Order
    {


        public int insertOrder(DateTime order_date, int customer_id,decimal invoiceTotal, int DiscountonTotal, string paymentType)
        {
            try
            {
                int orderId = 0;
                DB db = new DB();
                db.openConnection();
                SqlParameter[] parameters = new SqlParameter[5];

                parameters[0] = new SqlParameter("@o_date", SqlDbType.DateTime);
                parameters[0].Value = order_date;

                parameters[1] = new SqlParameter("@cus_id", SqlDbType.Int);
                parameters[1].Value = customer_id;
                parameters[2] = new SqlParameter("@invoiceTotal", SqlDbType.Money);
                parameters[2].Value = invoiceTotal;

                parameters[3] = new SqlParameter("@DiscountonTotal", SqlDbType.Money);
                parameters[3].Value = DiscountonTotal;

                parameters[4] = new SqlParameter("@PaymentType", SqlDbType.VarChar);
                parameters[4].Value = paymentType;

                orderId = db.ExecuteProcedureReturnIdentity("spr_insert_order", parameters);
                db.closeConnection();
                return orderId;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void insertOrderDetail(int p_id, int o_id, int qty, string price, string total,decimal discount, decimal discountedprice,decimal AmountafterDiscount)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[8];

            parameters[0] = new SqlParameter("@p_id", SqlDbType.Int);
            parameters[0].Value = p_id;

            parameters[1] = new SqlParameter("@o_id", SqlDbType.Int);
            parameters[1].Value = o_id;

            parameters[2] = new SqlParameter("@qty", SqlDbType.Int);
            parameters[2].Value = qty;

            parameters[3] = new SqlParameter("@price", SqlDbType.Money);
            parameters[3].Value = price;

            parameters[4] = new SqlParameter("@total", SqlDbType.Money);
            parameters[4].Value = total;

            parameters[5] = new SqlParameter("@dicount", SqlDbType.Int);
            parameters[5].Value = discount;

            parameters[6] = new SqlParameter("@discountedprice", SqlDbType.Money);
            parameters[6].Value = discountedprice;

            parameters[7] = new SqlParameter("@AmountafterDiscount", SqlDbType.Money);
            parameters[7].Value = AmountafterDiscount;
            db.setData("spr_insert_order_detail", parameters);
            db.closeConnection();

        }
        //getOrderDetailbyCustomerId_PurchasedReturn
        public DataTable getCustomerOrders(int customerId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = customerId;
            tab = db.getData("spr_get_all_customer_orders", parameters);
            db.closeConnection();

            return tab;
        }

         public DataTable getCustomerOrders_PurchasedReturn(int customerId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Customerid", SqlDbType.Int);
            parameters[0].Value = customerId;
            tab = db.getData("etOrderDetailbyCustomerId_PurchasedReturn", parameters);
            db.closeConnection();

            return tab;
        }

        //INvoic

         public DataTable getCustomerOrders_PurchasedReturn_CutomerInvoic(int salereturnid)
         {
             DB db = new DB();
             DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@saleReurnId", SqlDbType.Int);
            parameters[0].Value = salereturnid;
            tab = db.getData("[etOrderDetailbyCustomerId_PurchasedReturn]",parameters);
             db.closeConnection();

             return tab;
         }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="cat_id"></param>
        /// <param name="SearchCriteria"></param>
        /// <returns></returns>
        public DataTable getOrderQuatation()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            table = db.getData("spr_get_OrderQuatation");
            db.closeConnection();
            return table;
        }
        public DataTable getSaleReturnByCustomerId(int customerid)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@CustomerId", SqlDbType.Int);
            parameters[0].Value = customerid;
            tab = db.getData("[sp_GetAllSaleReturnByCustomerId]", parameters);
            db.closeConnection();

            return tab;
        }
        public DataTable getSaleByCustomerId(int customerid)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@CustomerId", SqlDbType.Int);
            parameters[0].Value = customerid;
            tab = db.getData("[sp_GetTotalSaleByCustomerId]", parameters);
            db.closeConnection();

            return tab;
        }

        public void InsertOrders_PurchasedReturn(int retrunid,int customerId, int ProductID, string ProducName, int orderid, int qty, decimal price, decimal total, decimal discount, decimal discountedprice, DateTime AddedDate, string addedby)
         
         {
             try
             {
                //@ReturnId
                int returnedId = 0;
                DB db = new DB();
                db.openConnection();
                SqlParameter[] parameters = new SqlParameter[12];
                parameters[0] = new SqlParameter("@ReturnId", SqlDbType.Int);
                parameters[0].Value = retrunid;

                parameters[1] = new SqlParameter("@CustomerId", SqlDbType.Int);
                parameters[1].Value = customerId;

                parameters[2] = new SqlParameter("@ProductID", SqlDbType.Int);
                parameters[2].Value = ProductID;

                parameters[3] = new SqlParameter("@ProducName", SqlDbType.VarChar);
                parameters[3].Value = ProducName;

                parameters[4] = new SqlParameter("@OrderId", SqlDbType.Int);
                parameters[4].Value = orderid;

                parameters[5] = new SqlParameter("@Qty ", SqlDbType.Int);
                parameters[5].Value = qty;

                parameters[6] = new SqlParameter("@Price", SqlDbType.Int);
                parameters[6].Value = price;
                parameters[7] = new SqlParameter("@Total", SqlDbType.Int);
                parameters[7].Value = total;
                parameters[8] = new SqlParameter("@Discount", SqlDbType.Int);
                parameters[8].Value = discount;
                parameters[9] = new SqlParameter("@DiscountedPrice", SqlDbType.Int);
                parameters[9].Value = discountedprice;
                parameters[10] = new SqlParameter("@AddedDate", SqlDbType.DateTime);
                parameters[10].Value = AddedDate;
                parameters[11] = new SqlParameter("@AddedBy", SqlDbType.VarChar);
                parameters[11].Value = addedby;

                db.setData("spr_insert_sales_Return_by_Customer", parameters);
                db.closeConnection();

                
             }
             catch (Exception)
             {
                 
                 throw;
             }
            
         }

        public DataTable genrateSales(string fromdate, string toDate)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@FromDate", SqlDbType.DateTime);
            parameters[1] = new SqlParameter("@ToDate", SqlDbType.DateTime);
            parameters[0].Value = Convert.ToDateTime(fromdate);
            parameters[1].Value = Convert.ToDateTime(toDate);
            tab = db.getData("[sp_GetTotalSaleBySelectiveDate]", parameters);
            db.closeConnection();

            return tab;
        }

        public DataTable genratedailySales(string fromdate, string toDate)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@FromDate", SqlDbType.DateTime);
            parameters[1] = new SqlParameter("@ToDate", SqlDbType.DateTime);
            parameters[0].Value = Convert.ToDateTime(fromdate);
            parameters[1].Value = Convert.ToDateTime(toDate);
            tab = db.getData("[sp_GetDailySaleDetailReport]", parameters);
            db.closeConnection();

            return tab;
        }

        public DataTable getAllOrders()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("spr_get_all_orders", null);
            db.closeConnection();
            return tab;
        }

        public DataTable getOrderMaxId()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("spr_get_order_max_id", null);
            db.closeConnection();
            return tab;
        }

        public DataTable getOrderDetails(int orderId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id",SqlDbType.Int);
            parameters[0].Value = orderId;
            tab = db.getData("spr_get_order_details", parameters);
            db.closeConnection();
            return tab;
        }

        public DataTable getOrderTotalAmount(int orderId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = orderId;
            tab = db.getData("spr_get_total_order_amount", parameters);
            db.closeConnection();
            return tab;
        }

        public DataTable getCustomerDetailsForInvoiceByOrderId(int orderId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@OrderId", SqlDbType.Int);
            parameters[0].Value = orderId;

            tab = db.getData("sp_CustomerDetails_By_Orderid", parameters);
            db.closeConnection();
            return tab;
        }

        public DataTable getOrderDetailByOrderid_CustomerId(int orderId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@OrderId", SqlDbType.Int);
            parameters[0].Value = orderId;
          

            tab = db.getData("SP_GenrateOrderby_By_Orderid", parameters);
            db.closeConnection();
            return tab;
        }

        public string getCustomerOrdersCount(int customerId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = customerId;
            tab = db.getData("spr_get_customer_orders_count", parameters);
            db.closeConnection();
            if (tab.Rows.Count == 0)
            {
                return "No Orders";
            }
            else
            {
                return tab.Rows[0][1].ToString();
            }
        }

        public string getCustomerOrdersTotalAmount(int customerId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = customerId;
            tab = db.getData("spr_get_customer_orders_amount", parameters);
            db.closeConnection();  
            if(tab.Rows.Count == 0)
            {
                return "0";
            }
            else
            {
                return tab.Rows[0][2].ToString();
            }
        }

        //spr_get_customer_last_order_date
        public string getCustomerLastOrderDate(int customerId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = customerId;
            tab = db.getData("spr_get_customer_last_order_date", parameters);
            db.closeConnection();
            if (tab.Rows.Count == 0)
            {
                return "No Order";
            }
            else
            {
                return tab.Rows[0][0].ToString();
            }
        }
        public DataTable GetCurrentStock()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            
            tab = db.getData("spr_Current_Stock");
            db.closeConnection();
            return tab;
        }
    }
}
