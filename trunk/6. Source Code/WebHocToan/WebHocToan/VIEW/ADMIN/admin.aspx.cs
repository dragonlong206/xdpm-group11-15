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
using Dto;
using Bus;

public partial class VIEW_ADMIN_admin : System.Web.UI.Page
{
    string ava;
    public void check()
    {
        string user2;
        if(!QuanLySessionCookie.CheckLoggedin())
                {
                    Response.Redirect("../index.aspx");
                }
                else
                {
                    user2 = (string)(Session["gdusername"]);

                    int loaiacc;
                    
                    AccountDTO acc = new AccountDTO();
                    acc = AccountBUS.selectAccountByIDAC(user2);

                    loaiacc = acc.IDLoaiAcc;

                    if (loaiacc != 1)
                    {
                        Response.Redirect("../index.aspx");
                    }                    
                }   
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        check();

        ava = Request.QueryString["ava"];

        string user;
        //Kiem tra chat che cac tham so
            
        switch (ava)
        {
            case "DanhSachAccount":
                DanhSachAccount1.Visible = true;   
                break;
            case "ThemAccount":
                ThemAccount1.Visible = true;
                break;
            //case "CapNhatAccount":
            //  CapNhatAccount1.Visible = true;
            //break;
            case "DanhSachBaiGiang":
                DanhSachBaiGiang1.Visible = true;
                break;
            case "CapNhatBaiGiang":
                CapNhatBaiGiang1.Visible = true;
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
            case "CapNhatBaiTap":
                CapNhatBaiTap1.Visible = true;
                break;
            case "DanhSachBaiTapTuLuan":
                DanhSachBaiTapTuLuan1.Visible = true;
                break;
            case "ThemBaiTapTuLuan":
                ThemBaiTapTuLuan1.Visible = true;
                break;
            case "CapNhatBaiTapTuLuan":
                CapNhatBaiTapTuLuan1.Visible = true;
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
