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

public partial class CONTROL_ADMIN_ThemBaiGiang : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ArrayList list = new ArrayList();
            list = ChuongBUS.selectChuongByIDMonHoc(1);

            drlChuong.DataTextField = "TenChuong";
            drlChuong.DataValueField = "IDChuong";
            drlChuong.DataSource = list;
            drlChuong.DataBind();
        }
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        BaiHocDTO bhDto = new BaiHocDTO();

        bhDto.TenBaiHoc = txtTuaDe.Text;
        bhDto.IDChuong =  Int32.Parse(drlChuong.SelectedItem.Value);
       
        //use the app-based path 
        Editor1.Setting["security:FilesGalleryPath"]= "~/uploads";

        bhDto.NoiDung = Editor1.Text;

        //Dung store IDBaiHoc auto tang.
        //bhDto.IDBaiHoc = 5;
        Boolean kq = false;
        //kq = BaiHocBUS.insertBaiHoc(bhDto);
        kq = BaiHocBUS.insertBaiHocAutoIncrease(bhDto);
        if (kq == true)
        {
            msgBox1.alert("Thêm Bài Học Thành Công");
        }
        else
        {
            msgBox1.alert("Thêm Bài Giảng Thất Bại");
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
}
