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
    protected void Page_Load(object sender, EventArgs e)
    {
        ava = Request.QueryString["ava"];

        string user;
        //Kiem tra chat che cac tham so
            
        switch (ava)
        {
            case "DanhSachAccount":
                if(!QuanLySessionCookie.CheckLoggedin())
                {
                    LimitAccess1.Visible = true;
                    break;
                }
                else
                {
                    user = (string)(Session["gdusername"]);

                    int loaiacc;
                    
                    AccountDTO acc = new AccountDTO();
                    acc = AccountBUS.selectAccountByIDAC(user);

                    loaiacc = acc.IDLoaiAcc;

                    if (loaiacc == 1)
                    {
                        DanhSachAccount1.Visible = true;
                    }
                    else
                    {
                         LimitAccess1.Visible = true;
                    }
                }    
                break;
            case "ThemAccount":
                if (!QuanLySessionCookie.CheckLoggedin())
                {
                    LimitAccess1.Visible = true;
                    break;
                }
                else
                {
                    user = (string)(Session["gdusername"]);

                    int loaiacc;

                    AccountDTO acc = new AccountDTO();
                    acc = AccountBUS.selectAccountByIDAC(user);

                    loaiacc = acc.IDLoaiAcc;

                    if (loaiacc == 1)
                    {
                        ThemAccount1.Visible = true;
                    }
                    else
                    {
                        LimitAccess1.Visible = true;
                    }
                }    
               
                break;
            //case "CapNhatAccount":
            //  CapNhatAccount1.Visible = true;
            //break;
            case "DanhSachBaiGiang":
                if (!QuanLySessionCookie.CheckLoggedin())
                {
                    LimitAccess1.Visible = true;
                    break;
                }
                else
                {
                    user = (string)(Session["gdusername"]);

                    int loaiacc;

                    AccountDTO acc = new AccountDTO();
                    acc = AccountBUS.selectAccountByIDAC(user);

                    loaiacc = acc.IDLoaiAcc;

                    if (loaiacc == 1)
                    {
                        DanhSachBaiGiang1.Visible = true;
                    }
                    else
                    {
                        LimitAccess1.Visible = true;
                    }
                }

                break;
            case "CapNhatBaiGiang":
                if (!QuanLySessionCookie.CheckLoggedin())
                {
                    LimitAccess1.Visible = true;
                    break;
                }
                else
                {
                    user = (string)(Session["gdusername"]);

                    int loaiacc;

                    AccountDTO acc = new AccountDTO();
                    acc = AccountBUS.selectAccountByIDAC(user);

                    loaiacc = acc.IDLoaiAcc;

                    if (loaiacc == 1)
                    {
                        CapNhatBaiGiang1.Visible = true;
                    }
                    else
                    {
                        LimitAccess1.Visible = true;
                    }
                }

                break;
            case "ThemBaiGiang":
                if (!QuanLySessionCookie.CheckLoggedin())
                {
                    LimitAccess1.Visible = true;
                    break;
                }
                else
                {
                    user = (string)(Session["gdusername"]);

                    int loaiacc;

                    AccountDTO acc = new AccountDTO();
                    acc = AccountBUS.selectAccountByIDAC(user);

                    loaiacc = acc.IDLoaiAcc;

                    if (loaiacc == 1)
                    {
                        ThemBaiGiang1.Visible = true;
                    }
                    else
                    {
                        LimitAccess1.Visible = true;
                    }
                }
                break;
            case "DanhSachBaiTap":
                if (!QuanLySessionCookie.CheckLoggedin())
                {
                    LimitAccess1.Visible = true;
                    break;
                }
                else
                {
                    user = (string)(Session["gdusername"]);

                    int loaiacc;

                    AccountDTO acc = new AccountDTO();
                    acc = AccountBUS.selectAccountByIDAC(user);

                    loaiacc = acc.IDLoaiAcc;

                    if (loaiacc == 1)
                    {
                        DanhSachBaiTap1.Visible = true;
                    }
                    else
                    {
                        LimitAccess1.Visible = true;
                    }
                }

                break;                
            case "ThemBaiTap":
                if (!QuanLySessionCookie.CheckLoggedin())
                {
                    LimitAccess1.Visible = true;
                    break;
                }
                else
                {
                    user = (string)(Session["gdusername"]);

                    int loaiacc;

                    AccountDTO acc = new AccountDTO();
                    acc = AccountBUS.selectAccountByIDAC(user);

                    loaiacc = acc.IDLoaiAcc;

                    if (loaiacc == 1)
                    {
                        ThemBaiTap1.Visible = true;
                    }
                    else
                    {
                        LimitAccess1.Visible = true;
                    }
                }
                break;                
            case "CapNhatBaiTap":
                if (!QuanLySessionCookie.CheckLoggedin())
                {
                    LimitAccess1.Visible = true;
                    break;
                }
                else
                {
                    user = (string)(Session["gdusername"]);

                    int loaiacc;

                    AccountDTO acc = new AccountDTO();
                    acc = AccountBUS.selectAccountByIDAC(user);

                    loaiacc = acc.IDLoaiAcc;

                    if (loaiacc == 1)
                    {
                        CapNhatBaiTap1.Visible = true;
                    }
                    else
                    {
                        LimitAccess1.Visible = true;
                    }
                }

                break;
            case "DanhSachComment":
                if (!QuanLySessionCookie.CheckLoggedin())
                {
                    LimitAccess1.Visible = true;
                    break;
                }
                else
                {
                    user = (string)(Session["gdusername"]);

                    int loaiacc;

                    AccountDTO acc = new AccountDTO();
                    acc = AccountBUS.selectAccountByIDAC(user);

                    loaiacc = acc.IDLoaiAcc;

                    if (loaiacc == 1)
                    {
                        DanhSachComment1.Visible = true;
                    }
                    else
                    {
                        LimitAccess1.Visible = true;
                    }
                }

                break;
            default:
                adminWelcome1.Visible = true;
                break;
        }

     
    }
}
