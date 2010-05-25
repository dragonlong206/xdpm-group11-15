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
using System.Xml;


using System.Collections;
using Bus;
using Dto;

public partial class CONTROL_ADMIN_DanhSachAccount : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ArrayList list1 = new ArrayList();
            list1 = LoaiAccBUS.selectAllLoaiAcc();

            drlLoaiAccount.DataTextField = "TenLoaiAcc";
            drlLoaiAccount.DataValueField = "IDLoaiAcc";
            drlLoaiAccount.DataSource = list1;
            drlLoaiAccount.DataBind();

            BindGridView(1);
        }
    }
    #region  Bind GridView

    private void BindGridView(int index)
    {
        ArrayList List = new ArrayList();

        List = AccountBUS.selectAccountByLAC(index);
        grvAccount.DataSource = List;
        grvAccount.DataBind();
    }

    #endregion
    protected void  grvAccount_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void grvAccount_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void drlLoaiAccount_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = Int32.Parse(drlLoaiAccount.SelectedItem.Value);
        BindGridView(index);
    }
}
