using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAS_Stock
{
   public class MacInfo
    {
        DB db = new DB();
        public void insertMac(string MacAddress)
       {


            try
            {

                bool isactive = false;
                db.openConnection();
                SqlParameter[] parameters = new SqlParameter[2];

                parameters[0] = new SqlParameter("@MacAddress", SqlDbType.NVarChar);
                parameters[0].Value = MacAddress;
                parameters[1] = new SqlParameter("@IsActive", SqlDbType.Bit);
                parameters[1].Value = isactive;
                db.setData("spr_insert_Mac", parameters);
                db.closeConnection();
            }
            catch (Exception ex)
            {

                throw ex;
            }

       }
    }
}
