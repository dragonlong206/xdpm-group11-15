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

public partial class CONTROL_ADMIN_ThemBaiTap : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void chbBaiTap_CheckedChanged(object sender, EventArgs e)
    {
        if (chbBaiTap.Checked == true)
        {
            lblBaiHoc.Visible = true;
            drlBaiHoc.Visible = true;
         
            FillDropDownListBaiHoc(Int32.Parse(drlChuong.SelectedItem.Value.ToString()));
        }
        else
        {
            lblBaiHoc.Visible = false;
            drlBaiHoc.Visible = false;
        }
    }
    private void FillDropDownListNoiDung(int ID)
    {
        ArrayList list = new ArrayList();
        list = BaiTapCuaBaiHocBUS.selectAllBaiTapCuaBaiHocByIDBaiHoc(ID);

        drlNoiDung.DataTextField = "TenBaiTap";
        drlNoiDung.DataValueField = "IDBaiTap";
        drlNoiDung.DataSource = list;
        drlNoiDung.DataBind();
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
        FillDropDownListNoiDung(Int32.Parse(drlBaiHoc.SelectedItem.Value.ToString()));
    }
    protected void cbtNoiDung_CheckedChanged(object sender, EventArgs e)
    {
        if (chbNoiDung.Checked == true)
        {
            lblBaiTap.Visible = true;
            drlNoiDung.Visible = true;
            lblTenBaiTap.Visible = false;
            txtTenBaiTap.Visible = false;
            FillDropDownListNoiDung(Int32.Parse(drlBaiHoc.SelectedItem.Value.ToString()));
        }
        else
        {
            lblTenBaiTap.Visible = true;
            txtTenBaiTap.Visible = true;
            lblBaiTap.Visible = false;
            drlNoiDung.Visible = false;
        }
    }
    protected void btnbaitap_Click(object sender, EventArgs e)
    {
        Boolean kq = false ;
        if(chbBaiTap.Checked == true)
        {

            BaiTapCuaBaiHocDTO btcbhDto = new BaiTapCuaBaiHocDTO();
            btcbhDto.IDBaiHoc = Int32.Parse(drlBaiHoc.SelectedItem.Value.ToString());
            btcbhDto.NoiDungBaiTap = txtNoiDung.Text;
            btcbhDto.TenBaiTap = txtTenBaiTap.Text;

            
            if (chbNoiDung.Checked == false)
            {
                //insert bai tap cho bai hoc
                kq = BaiTapCuaBaiHocBUS.insertBaiTapCuaBaiHoc(btcbhDto);
                //insert dap an
            }
            else
            {

            }
        }
    }
    protected void drlNoiDung_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (chbBaiTap.Checked == true)
        {
            BaiTapCuaBaiHocDTO btDto = new BaiTapCuaBaiHocDTO();
            btDto = BaiTapCuaBaiHocBUS.selectBaiTapCuaBaiHocByID(Int32.Parse(drlNoiDung.SelectedItem.Value.ToString()));
        }
    }
}
