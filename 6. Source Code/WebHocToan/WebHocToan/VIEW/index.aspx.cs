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

using Bus;
using Dto;

public partial class VIEW_index : System.Web.UI.Page
{
    string ava;
    protected void Page_Load(object sender, EventArgs e)
    {
        ava = Request.QueryString["ava"];
        string IDBaiHoc = Request.QueryString["IDBaiHoc"];
        int iIDBaiHoc;
        Boolean result = int.TryParse(IDBaiHoc, out iIDBaiHoc);

        //Kiem tra chat che cac tham so
        switch (ava)
        {
            case "BaiTap":
                if (result)
                {
                    BaiHocDTO bhDTO = BaiHocBUS.selectBaiHocByIDBaiHoc(iIDBaiHoc);
                    if (bhDTO.IDBaiHoc >= 0 && bhDTO.TenBaiHoc != "")
                    {
                        BaiTap1.Visible = true;
                    }
                    else
                    {
                        Error1.Visible = true;
                    }
                }
                else
                {
                    Error1.Visible = true;
                }
                break;
            case "LyThuyet":              
                if (result)
                {
                    BaiHocDTO bhDTO = BaiHocBUS.selectBaiHocByIDBaiHoc(iIDBaiHoc);
                    if (bhDTO.IDBaiHoc >= 0 && bhDTO.TenBaiHoc != "")
                    {
                        LyThuyet1.Visible = true;
                    }
                    else
                    {
                        Error1.Visible = true;
                    }
                }
                else
                {
                    Error1.Visible = true;
                }
                break;
            default:
                Welcome1.Visible = true;
                break;

        }
    }
}
