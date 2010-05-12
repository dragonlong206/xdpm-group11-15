using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Util
{
    public class SqlDataAccessHelper
    {
        protected static String connectionString;

        public static String getConnectionString()
        {
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["cnnWebHocToan"].ToString();
                //connectionString = "Server=.;Database=WebHocToan;uid=sa;pwd=";
            }
            catch (Exception ex)
            {
                
            }
            return connectionString;
        }

        public static SqlConnection getConnection()
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(getConnectionString());
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {

            }
            return cn;
        }
    }
}
