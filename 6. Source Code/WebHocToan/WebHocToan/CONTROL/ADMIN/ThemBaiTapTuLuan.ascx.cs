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

public partial class CONTROL_ADMIN_ThemBaiTapTuLuan : System.Web.UI.UserControl
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

            FillDropDownListBaiHoc(1);

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
    protected void btnThem_Click(object sender, EventArgs e)
    {
        BaiTapTuLuanDTO btDto = new BaiTapTuLuanDTO();

        btDto.TenBaiTap = txtTuaDe.Text;
        btDto.IDBaiHoc = Int32.Parse(drlBaiHoc.SelectedItem.Value);

        //use the app-based path 
        Editor1.Setting["security:FilesGalleryPath"] = "~/uploads";

        btDto.NoiDungBaiTap = Editor1.Text;

        //Dung store IDBaiHoc auto tang.
        //bhDto.IDBaiHoc = 5;
        Boolean kq = false;
        //kq = BaiHocBUS.insertBaiHoc(bhDto);
        kq = BaiTapTuLuanBUS.insertBaiTapTuLuan(btDto);
        if (kq == true)
        {
            msgBox1.alert("Thêm Bài Học Thành Công");
        }
        else
        {
            msgBox1.alert("Thêm Bài Giảng Thất Bại");
        }
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
    protected void drlBaiHoc_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
