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

using System.Collections;
using Bus;
using Dto;


public partial class CONTROL_ADMIN_DanhSachBaiTapTuLuan : System.Web.UI.UserControl
{
    #region  Bind GridView

    private void BindGridView(int index)
    {
        ArrayList List = new ArrayList();

        List = BaiTapTuLuanBUS.selectBaiTapTuLuanByIDBaiHoc(index);
        grvBaiHoc.DataSource = List;
        grvBaiHoc.DataBind();
    }

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ArrayList list1 = new ArrayList();
            list1 = MonHocBUS.selectAllMonHoc();

            drlMonHoc.DataTextField = "TenMonHoc";
            drlMonHoc.DataValueField = "IDMonHoc";
            drlMonHoc.DataSource = list1;
            drlMonHoc.DataBind();

            ArrayList list = new ArrayList();
            list = ChuongBUS.selectChuongByIDMonHoc(1);

            drlChuong.DataTextField = "TenChuong";
            drlChuong.DataValueField = "IDChuong";
            drlChuong.DataSource = list;
            drlChuong.DataBind();

            FillDropDownListBaiHoc(1);
            BindGridView(36);
        }
    }
    protected void drlMonHoc_SelectedIndexChanged(object sender, EventArgs e)
    {
        ArrayList list = new ArrayList();
        list = ChuongBUS.selectChuongByIDMonHoc(Int32.Parse(drlMonHoc.SelectedItem.Value.ToString()));

        drlChuong.DataTextField = "TenChuong";
        drlChuong.DataValueField = "IDChuong";
        drlChuong.DataSource = list;
        drlChuong.DataBind();
    }
    private void FillDropDownListBaiHoc(int ID)
    {

        ArrayList List = new ArrayList();
        List = BaiHocBUS.selectBaiHocByIDChuong(ID);

        drlBaiHoc.DataTextField = "TenBaiHoc";
        drlBaiHoc.DataValueField = "IDBaiHoc";
        drlBaiHoc.DataSource = List;
        drlBaiHoc.DataBind();
    }
    protected void drlChuong_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillDropDownListBaiHoc(Int32.Parse(drlChuong.SelectedItem.Value.ToString()));
    }
    protected void grvBaiHoc_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        bool result = false;

        result = BaiTapTuLuanBUS.deleteBaiTapTuLuan(Int32.Parse(grvBaiHoc.Rows[e.RowIndex].Cells[1].Text.ToString()));
        drlBaiHoc.SelectedItem.Value = grvBaiHoc.Rows[e.RowIndex].Cells[3].Text;
        int index = Int32.Parse(drlChuong.SelectedItem.Value);
        BindGridView(index);

        if (result == true)
        {
            msgBox1.alert("Xóa Thành Công");
        }
        else
        {
            msgBox1.alert("Xóa IDBaiGiang Thất Bại ");
        }
    }
    protected void grvBaiHoc_RowEditing(object sender, GridViewEditEventArgs e)
    {
        int index = Int32.Parse(drlChuong.SelectedItem.Value);
        string text = grvBaiHoc.Rows[e.NewEditIndex].Cells[1].Text;
        string url = "admin.aspx?ava=CapNhatBaiTapTuLuan&IDBaiTap=" + text + "&IDChuong=" + index;
        Response.Redirect(url);
        //this is comment
    }
    protected void drlBaiHoc_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindGridView(Int32.Parse(drlBaiHoc.SelectedItem.Value.ToString()));
    }
}
