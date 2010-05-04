using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Data.SqlClient;
using Bus;
using Dto;


/// <summary>
/// Summary description for QuanLySessionCookie
/// </summary>
public class QuanLySessionCookie
{
    public QuanLySessionCookie()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static void CreateSessions(string Username, string Password)
    {
        HttpContext.Current.Session["gdusername"] = Username;
        HttpContext.Current.Session["gdpassword"] = Password;
    }

    public static void CreateCookies(string Username, string Password)
    {
        HttpCookie user = new HttpCookie("gdthongtin");
        user["gdusername"] = Username;
        user["gdpassword"] = Password;
        user.Expires = DateTime.Now.AddYears(1);
        HttpContext.Current.Response.Cookies.Add(user);

    }


    public static void ClearSessionCookies()
    {
        HttpContext.Current.Session.Remove("gdusername");
        HttpContext.Current.Session.Remove("gdpassword");
        HttpContext.Current.Session.Remove("gdloaiuser");
        HttpContext.Current.Response.Cookies["gdthongtin"].Expires = DateTime.Now.AddDays(-1);
    }


    public static bool ConfirmUser(string Username, string Password)
    {
        /*
        if (Username == "demo" && Password == "demo")
            return true;
        else
            return false;
         * */

        AccountDTO AccDTO = AccountBUS.selectAccountByIDAC(Username);

        if (AccDTO.IDAcc != null && Password ==  AccDTO.Pass)
        {
            LoaiAccDTO loaiAccDTO = LoaiAccBUS.selectLoaiAccByIDLoaiAcc(AccDTO.IDLoaiAcc);
            HttpContext.Current.Session["gdloaiuser"] = loaiAccDTO.TenLoaiAcc;
            return true;
        }

        /*
        DataTable dt = TaiKhoan(Username, Password);
        if (dt.Rows.Count > 0)
        {
            HttpContext.Current.Session["gdloaiuser"] = (string)dt.Rows[0]["Loai_User"].ToString();
            return true;
        }
         * */


        return false;

    }

    public static bool CheckLoggedin()
    {

        if (HttpContext.Current.Session["gdusername"] != null && HttpContext.Current.Session["gdpassword"] != null)
        {
            return true;
        }


        HttpCookie cookie = HttpContext.Current.Request.Cookies["gdthongtin"];
        if (cookie != null)
        {
            if (cookie["gdusername"] != null && cookie["gdpassword"] != null)
            {
                if (ConfirmUser(cookie["gdusername"], cookie["gdpassword"]))
                {
                    CreateSessions(cookie["gdusername"], cookie["gdpassword"]);
                    return true;
                }
                else
                {
                    ClearSessionCookies();
                    return false;
                }

            }
            else
            {
                return false;
            }
        }


        return false;
    }

    public static DataTable TaiKhoan(string Username, string Password)
    {

        DataTable dt = new DataTable();
        // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
        //string cnStr = "Data Source=THANH-PC; Initial Catalog=SieuThiSMO; Integrated Security=True";
        string cnStr = System.Configuration.ConfigurationManager.ConnectionStrings["cnnSieuThiSMO"].ConnectionString;
        SqlConnection cn = new SqlConnection(cnStr);
        cn.Open();
        // B3: Tao chuoi strSQL thao tac CSDL
        string strSQL;
        strSQL = "select * From Account where CMND = @CMND and Mat_Khau = @Mat_Khau";

        SqlCommand cmd = new SqlCommand(strSQL, cn);

        cmd.Parameters.Add("@CMND", SqlDbType.NVarChar);
        cmd.Parameters.Add("@Mat_Khau", SqlDbType.VarChar);

        cmd.Parameters["@CMND"].Value = Username;
        cmd.Parameters["@Mat_Khau"].Value = Password;

        SqlDataAdapter sqlDA = new SqlDataAdapter();
        sqlDA.SelectCommand = cmd;

        sqlDA.Fill(dt);
        // B5: Dong ket noi CSDL
        cn.Close();
        return dt;
    }
}
