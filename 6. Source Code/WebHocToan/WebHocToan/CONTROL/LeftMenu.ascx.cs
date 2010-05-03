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

public partial class CONTROL_LeftMenu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            rptChuong.DataSource = ChuongBUS.selectAllChuong();
            rptChuong.DataBind();
        }
    }
    protected void rptChuong_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        Repeater rptBai = (Repeater)e.Item.FindControl("rptBai");//tim rptBai con trong rptChuong

        if (rptBai != null)
        {
            int IDChuong = (int)DataBinder.Eval(e.Item.DataItem, "IDChuong");
            rptBai.DataSource = BaiHocBUS.selectBaiHocByIDChuong(IDChuong);
            rptBai.DataBind();
            
        }
    }
}
