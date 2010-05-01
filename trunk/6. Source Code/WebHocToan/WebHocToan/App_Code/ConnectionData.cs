using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for ConnectionData
/// </summary>
public class ConnectionData
{
    public ConnectionData()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public SqlConnection connectData()
    {
        string strCnn = ConfigurationManager.ConnectionStrings["cnnWebBanHang"].ToString();
        SqlConnection sqlCnn = new SqlConnection(strCnn);
        sqlCnn.Open();

        return sqlCnn;
    }
}
