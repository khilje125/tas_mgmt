using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAS_Stock
{
    class Login
    {
        DB db = new DB();
        public DataTable login(string username, string password)
        {
           
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 20);
            param[0].Value = username;
            param[1] = new SqlParameter("@pass", SqlDbType.VarChar, 20);
            param[1].Value = password;
            DataTable tab = new DataTable();
            tab = db.getData("spr_login", param);
            db.closeConnection();
            return tab;
        }

        public bool GetMac_Valid(string macAddress)
        {
            bool result = false;
            SqlParameter[] aprm = new SqlParameter[1];
            aprm[0] = new SqlParameter("@MacAddress", SqlDbType.NVarChar, 50);
            aprm[0].Value = macAddress;
            DataTable atable = new DataTable();
            atable = db.getData("spr_lValidateMac", aprm);
            db.closeConnection();
            if (atable.Rows.Count>0)
            {
                result = true;
            }
            return result;
        }
        public void updateSerialKey(string SerialKey)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            parameters[0].Value = SerialKey;

          

            db.setData("spr_update_customer", parameters);
            db.closeConnection();

        }

        public string insertGuid(string MacAddress)
        {


            try
            {

                string returnGuid ="" ;
                DataTable dt;
                SqlParameter[] parameters = new SqlParameter[1];

                parameters[0] = new SqlParameter("@ActivationGUID", SqlDbType.VarChar);
                parameters[0].Value = MacAddress;

                dt = db.GetDataUsingDataTable("spr_insert_ProductActivation", parameters);
                if (dt.Rows.Count > 0)
                {
                    returnGuid = Convert.ToString(dt.Rows[0][0]);
                }
                return returnGuid;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
       
        public void InserDefaultUser()
        {
            try
            {

                DB db = new DB();
                db.openConnection();

                db.setData("spr_insert_DefaultUser", null);
                db.closeConnection();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void TrunateTableBySuperAdmin()
        {
            try
            {

                DB db = new DB();
                db.openConnection();

                db.setData("sp_truncateTableBySuperAdmin", null);
                db.closeConnection();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int updateProductKey(string ActivationGUID,string ActivationSerialKey)
        {

            try
            {
                DB db = new DB();
                db.openConnection();
                SqlParameter[] parameters = new SqlParameter[2];

                parameters[0] = new SqlParameter("@ActivationGUID", SqlDbType.VarChar);
                parameters[0].Value = ActivationSerialKey;

                parameters[1] = new SqlParameter("@ActivationSerialKey", SqlDbType.VarChar);
                parameters[1].Value = ActivationGUID;



                int result = db.ExecuteProcedureReturnIdentity("spr_update_ProductActivation", parameters);

                db.closeConnection();
                return result;
            }
            catch ( Exception ex)
            {

                throw ex;
            }
        }

        public int checkIsProductActive()
        {


            try
            {

                int returnGuid = 0;
                DataTable dt;
                db.openConnection();
                dt = db.getData("spr_insert_ProductActivation");
                if (dt.Rows.Count > 0)
                {
                    returnGuid = Convert.ToInt32(dt.Rows[0][0]);

                }
                db.closeConnection();
                return returnGuid;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int CheckIsProductAtiveKeyExists()
        {
            try
            {
                int returnGuid = 0;
                 db.openConnection();
                returnGuid = db.ExecuteProcedureReturnIdentity("spr_select_CheckIsProductAtiveKeyExists",null);
                db.closeConnection();
                return returnGuid;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
