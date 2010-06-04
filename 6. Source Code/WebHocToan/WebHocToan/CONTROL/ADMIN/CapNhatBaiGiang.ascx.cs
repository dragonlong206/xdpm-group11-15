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

public partial class CONTROL_ADMIN_CapNhatBaiGiang : System.Web.UI.UserControl
{
    string idBaiHoc;
    string idChuong;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.SmartNavigation = true;
        idBaiHoc = Request.QueryString["IDBaiHoc"];
        idChuong = Request.QueryString["IDChuong"];
        if (!IsPostBack)
        {
            ArrayList list1 = new ArrayList();
            list1 = MonHocBUS.selectAllMonHoc();

            drlMonHoc.DataTextField = "TenMonHoc";
            drlMonHoc.DataValueField = "IDMonHoc";
            drlMonHoc.DataSource = list1;
            drlMonHoc.DataBind();

            if (idChuong != null)
            {
                FillDropDownListChuong(Int32.Parse(idChuong.ToString()));
                FillDropDownListBaiGiang(Int32.Parse(idChuong));
            }
            if (idBaiHoc != null)
            {

                BaiHocDTO bhDto = new BaiHocDTO();
                bhDto = BaiHocBUS.selectBaiHocByIDBaiHoc(Int32.Parse(idBaiHoc));
                FillEditor(bhDto);

                drlBaiGiang.SelectedValue = idBaiHoc;
            }
            
            else
            {
                ArrayList list = new ArrayList();
                list = ChuongBUS.selectChuongByIDMonHoc(Int32.Parse(drlMonHoc.SelectedItem.Value.ToString()));

                drlChuong.DataTextField = "TenChuong";
                drlChuong.DataValueField = "IDChuong";
                drlChuong.DataSource = list;
                drlChuong.DataBind();

                FillDropDownListBaiGiang(Int32.Parse(drlChuong.SelectedItem.Value.ToString()));

                BaiHocDTO bhDto = new BaiHocDTO();
                bhDto = BaiHocBUS.selectBaiHocByIDBaiHoc(Int32.Parse(drlBaiGiang.SelectedItem.Value.ToString()));
                FillEditor(bhDto);
            }

        }
        
    }
    private void FillEditor(BaiHocDTO bhDto)
    {
        txtBaiGiangMoi.Text = bhDto.TenBaiHoc;
        if (Editor1.Text != "")
            Editor1.Text = "";
        Editor1.Text = bhDto.NoiDung;

    }
    private void FillDropDownListBaiGiang(int ID)
    {
      
        ArrayList List = new ArrayList();
        List = BaiHocBUS.selectBaiHocByIDChuong(ID);
        drlBaiGiang.DataTextField = "TenBaiHoc";
        drlBaiGiang.DataValueField = "IDBaiHoc";
        drlBaiGiang.DataSource = List;
        drlBaiGiang.DataBind();


    }
    private void FillDropDownListChuong(int ID)
    {

        ArrayList List = new ArrayList();
        List = ChuongBUS.selectChuongByIDMonHoc(ID);
        drlChuong.DataTextField = "TenChuong";
        drlChuong.DataValueField = "IDChuong";
        drlChuong.DataSource = List;
        drlChuong.DataBind();


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
        FillDropDownListBaiGiang(Int32.Parse(drlChuong.SelectedItem.Value.ToString()));
    }
    protected void drlBaiGiang_SelectedIndexChanged(object sender, EventArgs e)
    {
        BaiHocDTO bhDto = new BaiHocDTO();
        bhDto = BaiHocBUS.selectBaiHocByIDBaiHoc(Int32.Parse(drlBaiGiang.SelectedItem.Value.ToString()));
        FillEditor(bhDto);
        
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        int id = Int32.Parse(idBaiHoc.ToString());
        Boolean result = false;

        BaiHocDTO bhDto = new BaiHocDTO();
        bhDto.IDBaiHoc = id; 
        bhDto.IDChuong = Int32.Parse(idChuong.ToString());
        bhDto.NoiDung = Editor1.Text;
        bhDto.TenBaiHoc = txtBaiGiangMoi.Text;
        result = BaiHocBUS.updateBaiHoc(bhDto);
        if (result == true)
        {
            msgBox1.alert(" Cập nhật thành công ");
        }
        else
        {
            msgBox1.alert(" Cập nhật thất bại ");
        }
    }

}
