using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TAS_Stock
{
    class DB
    {
        SqlConnection connection;
        string conn_String = ConfigurationManager.ConnectionStrings["StockDB"].ConnectionString;
        public DB()
        {
            connection = new SqlConnection(conn_String);
        }

        public void openConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public DataTable getData(string procedureName, SqlParameter[] procedureParams)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
            command.Connection = connection;
            if (procedureParams != null)
            {
                for (int i = 0; i < procedureParams.Length; i++)
                {
                    command.Parameters.Add(procedureParams[i]);
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable GetDataUsingDataTable(string spName, SqlParameter[] paramtr)
        {
            using (DataTable dt = new DataTable())
            {
                using (SqlConnection cn = new SqlConnection(conn_String))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = spName;
                        cmd.CommandTimeout = 0;
                        try
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                for (int i = 0; i <= paramtr.Length - 1; i++)
                                {
                                    cmd.Parameters.Add(paramtr[i]);
                                }

                                da.Fill(dt);
                            }
                        }
                        catch (Exception ex)
                        {
                            // DALUtility.ErrorLog(ex.Message, "DALCommon.vb, GetDataUsingDataTable");
                        }
                        finally
                        {
                            if (cn.State == ConnectionState.Open)
                            {
                                cn.Close();
                            }
                        }
                    }
                }
                return dt;
            }
        }
            public string getInsertValue(string procedureName, SqlParameter[] procedureParams)
        {
            SqlCommand command = new SqlCommand();
            string strString = "";
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
            command.Connection = connection;
            SqlParameter _ourParam = new SqlParameter("@outGuidValue", SqlDbType.VarChar);
            _ourParam.Direction = ParameterDirection.Output;
            if (procedureParams != null)
            {
                for (int i = 0; i < procedureParams.Length; i++)
                {
                    command.Parameters.Add(procedureParams[i]); 
                }

                command.Parameters.Add(_ourParam);

            }
            command.ExecuteNonQuery();           
            strString = Convert.ToString(command.Parameters["@outGuidValue"].Value);
            return strString;
        }
        public DataTable getData(string procedureName)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void setData(string procedureName, SqlParameter[] procedureParams)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procedureName;
                command.Connection = connection;
                if (procedureParams != null)
                {
                    command.Parameters.AddRange(procedureParams);
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int setOrderData(string procedureName, SqlParameter[] procedureParams)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
            command.Connection = connection;
            if (procedureParams != null)
            {
                command.Parameters.AddRange(procedureParams);
            }

          int id =   command.ExecuteNonQuery();
            return id;
        }

        public int ExecuteProcedureReturnIdentity(string procedureName, SqlParameter[] procedureParams)
        {
            int identity = 0;
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
            command.Connection = connection;
            if (procedureParams != null)
            {
                command.Parameters.AddRange(procedureParams);
            }

            //For returning Value 
            SqlParameter returnValue = default(SqlParameter);
            returnValue = command.Parameters.Add("@num", System.Data.SqlDbType.Real);
            returnValue.Direction = System.Data.ParameterDirection.ReturnValue;

            command.ExecuteNonQuery();
            identity = Convert.ToInt32(command.Parameters["@num"].Value);
            return identity;
        }

    }
}
