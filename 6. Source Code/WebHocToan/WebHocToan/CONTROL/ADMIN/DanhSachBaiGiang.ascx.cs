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

public partial class CONTROL_ADMIN_DanhSachBaiGiang : System.Web.UI.UserControl
{
    #region  Bind GridView

    private void BindGridView()
    {
        int index = Int32.Parse(drlChuong.SelectedItem.Value);
        ArrayList List = new ArrayList();

        List = BaiHocBUS.selectBaiHocByIDChuong(index);
        grvBaiHoc.DataSource = List;
        grvBaiHoc.DataBind();       
    }

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            int index = 1;  
            ArrayList List = new ArrayList();

            List = BaiHocBUS.selectBaiHocByIDChuong(index);
            grvBaiHoc.DataSource = List;
            grvBaiHoc.DataBind();
        }
    }
    protected void drlChuong_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindGridView();
    }
    protected void grvBaiHoc_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        bool result = false;

        result = BaiHocBUS.deleteBaiHoc(grvBaiHoc.Rows[e.RowIndex].Cells[1].Text);
        drlChuong.SelectedIndex = Int32.Parse(grvBaiHoc.Rows[e.RowIndex].Cells[4].Text) - 1;
        string text = grvBaiHoc.Rows[e.RowIndex].Cells[1].Text;

        BindGridView();
 
        if (result == true)
        {
            msgBox1.alert("Xóa Thành Công");
        }
        else
        {
            msgBox1.alert("Xóa IDBaiGiang" + text + " Thất Bại ");
        }
    }
}
