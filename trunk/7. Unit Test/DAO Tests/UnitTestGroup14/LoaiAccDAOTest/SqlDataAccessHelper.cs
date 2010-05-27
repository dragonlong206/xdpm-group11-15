using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace UnitTestGroup14
{
    public interface ISqlDataAccessHelper
    {
        System.Int32 ExecuteNonQuery(string query, List<SqlParameter> sqlParameters);
        System.Int32 ExecuteNonQuery(string query);
        DataTable ExecuteQuery(string query, List<SqlParameter> sqlParameters);
        DataTable ExecuteQuery(string query);
    }
}
