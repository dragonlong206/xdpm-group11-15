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

public partial class CONTROL_ADMIN_DanhSachBaiTap : System.Web.UI.UserControl
{
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

            BindGridViewBaiTapChuong(1);
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
    protected void drlChuong_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindGridViewBaiTapChuong(Int32.Parse(drlChuong.SelectedItem.Value.ToString()));
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
    protected void chbBaiTap_CheckedChanged(object sender, EventArgs e)
    {
        if (chbBaiTap.Checked == true)
        {
            lblBaiHoc.Visible = true;
            drlBaiHoc.Visible = true;

            FillDropDownListBaiHoc(Int32.Parse(drlChuong.SelectedItem.Value.ToString()));

            BindGridView(1);
            //drlBaiHoc_SelectedIndexChanged(sender, e);
        }
        else
        {
            lblBaiHoc.Visible = false;
            drlBaiHoc.Visible = false;

            BindGridViewBaiTapChuong(Int32.Parse(drlChuong.SelectedItem.Value.ToString()));
        }
    }
    private void BindGridView(int index)
    {
        ArrayList List = new ArrayList();

        List = BaiTapCuaBaiHocBUS.selectBaiTapCuaBaiHocByIDBaiHoc2(index);
        grvBaiTap.DataSource = List;
        grvBaiTap.DataBind();
    }
    private void BindGridViewBaiTapChuong(int index)
    {
        ArrayList List = new ArrayList();

        List = BaiTapChuongBUS.selectBaiTapChuongByIDChuong(index);
        grvBaiTap.DataSource = List;
        grvBaiTap.DataBind();
    }
    protected void drlBaiHoc_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindGridView(Int32.Parse(drlBaiHoc.SelectedItem.Value.ToString()));
    }
    protected void grvBaiTap_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        bool result = false;

        //result = BaiHocBUS.deleteBaiHoc(grvBaiHoc.Rows[e.RowIndex].Cells[1].Text);
        //drlChuong.SelectedIndex = Int32.Parse(grvBaiHoc.Rows[e.RowIndex].Cells[4].Text) - 1;
        //string text = grvBaiHoc.Rows[e.RowIndex].Cells[1].Text;
        //int index = Int32.Parse(drlChuong.SelectedItem.Value);
        //BindGridView(index);

        //KIem tra checkbox

        string id = grvBaiTap.Rows[e.RowIndex].Cells[1].Text;
        if (chbBaiTap.Checked == true)//xoa bai tap cua bai hoc
        {
            //Xoa tat ca cac cau tra loi cua bai tap bai hoc ma co cung IDBaiTap muon Xoa
            result = CauHoiBTBaiHocBUS.deleteCauHoiBTBaiHocByIDBaiTap(Int32.Parse(id));
            //Xoa bai tap
            result = BaiTapCuaBaiHocBUS.deleteBaiTapCuaBaiHoc(Int32.Parse(id));
        }
        else
        {
            //Xoa bai tap chuong
            result = CauHoiBTChuongBUS.deleteCauHoiBTChuongByIDBaiTap(Int32.Parse(id));
            //Xoa dap an bai tap chuong
            result = BaiTapChuongBUS.deleteBaiTapChuong(Int32.Parse(id));
        }

        if (result == true)
        {
            msgBox1.alert("Xóa Thành Công");
        }
        else
        {
            msgBox1.alert("Xóa IDBaiGiang" + " Thất Bại ");
        }
    }
    protected void grvBaiTap_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
}
