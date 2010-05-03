using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class VIEW_ADMIN_admin : System.Web.UI.Page
{
    string ava;
    protected void Page_Load(object sender, EventArgs e)
    {
        ava = Request.QueryString["ava"];


        //Kiem tra chat che cac tham so
        switch (ava)
        {
            case "DanhSachAccount":
                DanhSachAccount1.Visible = true;
                break;
            case "ThemAccount":
                ThemAccount1.Visible = true;
                break;
            case "DanhSachBaiGiang":
                DanhSachBaiGiang1.Visible = true;
                break;
            case "ThemBaiGiang":
                ThemBaiGiang1.Visible = true;
                break;
            case "DanhSachBaiTap":
                DanhSachBaiTap1.Visible = true;
                break;
            case "ThemBaiTap":
                ThemBaiTap1.Visible = true;
                break;
            case "DanhSachComment":
                DanhSachComment1.Visible = true;
                break;
            default:
                adminWelcome1.Visible = true;
                break;
        }


    }
}
