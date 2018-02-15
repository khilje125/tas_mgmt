using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAS_Stock
{
    public class CashBook
    {
//        @ChequeNo nvarchar(60),
//@BankName varchar(50),
//@AccountTile varchar(50),

        public int insertCashBookOrder(int Cus_Id, int Inv_Id, string Trans_Desc, string ChequeNo, string BankName,string AccountTitle, decimal Debir_Amt, decimal Credit_Amt, string CashBook_Date , int UserId=1)
        {
            int invoiceId = 0;
            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[10];

            parameters[0] = new SqlParameter("@CustomerId", SqlDbType.Int);
            parameters[0].Value = Cus_Id;

            parameters[1] = new SqlParameter("@InvoiceId", SqlDbType.Int);
            parameters[1].Value = Inv_Id;

            parameters[2] = new SqlParameter("@TransactionDiscription", SqlDbType.NVarChar);
            parameters[2].Value = Trans_Desc;

            parameters[3] = new SqlParameter("@ChequeNo", SqlDbType.NVarChar);
            parameters[3].Value = ChequeNo;
            parameters[4] = new SqlParameter("@BankName", SqlDbType.VarChar);
            parameters[4].Value = BankName;
            parameters[5] = new SqlParameter("@AccountTile", SqlDbType.VarChar);
            parameters[5].Value = AccountTitle;
            parameters[6] = new SqlParameter("@AmountCredit", SqlDbType.Money);
            parameters[6].Value = Credit_Amt;

            parameters[7] = new SqlParameter("@AmountDebit", SqlDbType.Money);
            parameters[7].Value = Debir_Amt;
            parameters[8] = new SqlParameter("@CashbokDate", SqlDbType.VarChar);
            parameters[8].Value =  CashBook_Date;
            // @CashbokDate
            parameters[9] = new SqlParameter("@AddedBy", SqlDbType.Int);
            parameters[9].Value = UserId;

            invoiceId= db.ExecuteProcedureReturnIdentity("spr_Insert_Order_CashBook", parameters);
            db.closeConnection();
            return invoiceId;
        }

        // Bank Cheque Insertion 

        public int InsertBankCheque(int Cus_Id, int Inv_Id,string ChequeNo, decimal ChequeAmount, string banckName, string ChequeDueDate, string AccountTitle)
        {
    //        @CustomerId   int,
    //@InvoiceId   int,
    //@ChequeNo   nvarchar(50),
    //  @ChequeAmount numeric(18,2),
    //  @BankName varchar(50),
    //  @ChequeDueDate dateTime,
    //  @AccountTitle   varchar(50)



            int invoiceId = 0;
            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[7];

            parameters[0] = new SqlParameter("@CustomerId", SqlDbType.Int);
            parameters[0].Value = Cus_Id;

            parameters[1] = new SqlParameter("@InvoiceId", SqlDbType.Int);
            parameters[1].Value = Inv_Id;
            parameters[2] = new SqlParameter("@ChequeNo", SqlDbType.NVarChar);
            parameters[2].Value = ChequeNo;

            parameters[3] = new SqlParameter("@ChequeAmount", SqlDbType.Money);
            parameters[3].Value = ChequeAmount;

            parameters[4] = new SqlParameter("@BankName", SqlDbType.VarChar);
            parameters[4].Value = banckName;

            parameters[5] = new SqlParameter("@ChequeDueDate", SqlDbType.DateTime);
            parameters[5].Value = ChequeDueDate;

            parameters[6] = new SqlParameter("@AccountTitle", SqlDbType.VarChar);
            parameters[6].Value = AccountTitle;
            invoiceId = db.ExecuteProcedureReturnIdentity("spr_insert_Bank_Cheque", parameters);
            db.closeConnection();
            return invoiceId;
        }

        public DataTable genrateLedeger(string fromdate, string toDate,int customerId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@FromDate", SqlDbType.DateTime);
            parameters[1] = new SqlParameter("@ToDate", SqlDbType.DateTime);
            parameters[2] = new SqlParameter("@customerId", SqlDbType.Int);
            parameters[0].Value = Convert.ToDateTime(fromdate);
            parameters[1].Value = Convert.ToDateTime(toDate);
            parameters[2].Value = Convert.ToInt32(customerId);
            tab = db.getData("[sp_GetCustomer_Ledger_Report]", parameters);
            db.closeConnection();

            return tab;
        }

        public DataTable getCustomerLedgerDatebyId(int cashbookid)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@cashbookid", SqlDbType.Int);
            parameters[0].Value = cashbookid;

           
            tab = db.getData("[spr_get_Customer_Ledger]", parameters);
            db.closeConnection();

            return tab;
        }
        public DataTable getTotalReceivable()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("[sp_Total_Receivable]");
            db.closeConnection();

            return tab;
        }

        public DataTable getBankChequeDetail()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("sp_Customer_cheque");
            db.closeConnection();

            return tab;
        }

        //        @cashbookid int,
        //@CashbokDate varchar(50),
        //@TransactionDiscription varchar(50),
        //@AmountDebit int,
        //@AmountCredit int,
        //@InvoiceId int
        public int UpdateCashBookOrder( int cashbookid,int InvoiceId,  string Trans_Desc, double Credit_Amt, double Debir_Amt, string CashbokDate, int UserId = 1)
        {
            int invoiceId = 0;
            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[8];

            parameters[0] = new SqlParameter("@cashbookid", SqlDbType.Int);
            parameters[0].Value = cashbookid;

            parameters[1] = new SqlParameter("@InvoiceId", SqlDbType.Int);
            parameters[1].Value = InvoiceId;

            parameters[2] = new SqlParameter("@TransactionDiscription", SqlDbType.VarChar);
            parameters[2].Value = Trans_Desc;

            parameters[3] = new SqlParameter("@AmountCredit", SqlDbType.Money);
            parameters[3].Value = Credit_Amt;

            parameters[4] = new SqlParameter("@AmountDebit", SqlDbType.Money);
            parameters[4].Value = Debir_Amt;
            parameters[5] = new SqlParameter("@CashbokDate", SqlDbType.VarChar);
            parameters[5].Value = Convert.ToDateTime( CashbokDate);
            // @CashbokDate
            parameters[6] = new SqlParameter("@updatedBy", SqlDbType.Int);
            parameters[6].Value = UserId;
            parameters[7] = new SqlParameter("@updateDate", SqlDbType.VarChar);
            parameters[7].Value = Convert.ToDateTime(DateTime.Now);

            invoiceId = db.ExecuteProcedureReturnIdentity("spr_update_Customer_Ledger", parameters);
            db.closeConnection();
            return invoiceId;
        }

        public DataTable getCustomerLedgeer(string fromdate, string toDate, int customerId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@FromDate", SqlDbType.DateTime);
            parameters[0].Value = Convert.ToDateTime(fromdate);
            parameters[1] = new SqlParameter("@ToDate", SqlDbType.DateTime);
            parameters[1].Value = Convert.ToDateTime(toDate);
            parameters[2] = new SqlParameter("@customerid", SqlDbType.Int);
            parameters[2].Value = Convert.ToInt32(customerId);
            tab = db.getData("[sp_GetCustomerLedger]", parameters);
            db.closeConnection();

            return tab;
        }

        public DataTable getBankCheque(string fromdate, string toDate)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@FromDate", SqlDbType.DateTime);
            parameters[0].Value = Convert.ToDateTime(fromdate);
            parameters[1] = new SqlParameter("@ToDate", SqlDbType.DateTime);
            parameters[1].Value = Convert.ToDateTime(toDate);
            tab = db.getData("[sp_Customer_cheque_by_Date]", parameters);
            db.closeConnection();

            return tab;
        }

        public int updateBankChequeStatus(int checkId,int status)
        {

            try
            {
                   DB db = new DB();
                db.openConnection();
                SqlParameter[] parameters = new SqlParameter[2];

                parameters[0] = new SqlParameter("@CheckId", SqlDbType.Int);
                parameters[0].Value = checkId;

                parameters[1] = new SqlParameter("@checkIdstatus", SqlDbType.Int);
                parameters[1].Value = status;
                int result = db.ExecuteProcedureReturnIdentity("spr_update_ChecqueStatus", parameters);

                db.closeConnection();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
