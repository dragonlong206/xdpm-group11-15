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
        Page.SmartNavigation = true;
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
        }
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

    protected void drlMonHoc_SelectedIndexChanged(object sender, EventArgs e)
    {
        ArrayList list = new ArrayList();
        list = ChuongBUS.selectChuongByIDMonHoc(Int32.Parse(drlMonHoc.SelectedItem.Value.ToString()));

        drlChuong.DataTextField = "TenChuong";
        drlChuong.DataValueField = "IDChuong";
        drlChuong.DataSource = list;
        drlChuong.DataBind();
    }

    protected void btnbaitap_Click(object sender, EventArgs e)
    {
        Boolean kq = false;
        Boolean kq2 = false;
        if (chbBaiTap.Checked == true)
        {
            CauHoiBTBaiHocDTO ch = new CauHoiBTBaiHocDTO();
            ch.CauHoiA = txtA.Text;
            ch.CauHoiB = txtB.Text;
            ch.CauHoiC = txtC.Text;
            ch.CauHoiD = txtD.Text;
            ch.CauTraLoi =drlDapAn.SelectedItem.Value.ToString();

            BaiTapCuaBaiHocDTO btcbhDto = new BaiTapCuaBaiHocDTO();
            btcbhDto.IDBaiHoc = Int32.Parse(drlBaiHoc.SelectedItem.Value.ToString());
            btcbhDto.NoiDungBaiTap = Editor1.Text;
            btcbhDto.TenBaiTap = txtTenBaiTap.Text;

            int IDBaiTapBaiHoc = 0;
            //insert bai tap cho bai hoc
            kq = BaiTapCuaBaiHocBUS.insertBaiTapCuaBaiHoc(btcbhDto, ref IDBaiTapBaiHoc);
            //insert dap an
            ch.IDBaiTap = IDBaiTapBaiHoc;
            kq2 = CauHoiBTBaiHocBUS.insertCauHoiBTBaiHoc(ch);       
        }
        else
        {
            CauHoiBTChuongDTO ch2 = new CauHoiBTChuongDTO();
            ch2.CauHoiA = txtA.Text;
            ch2.CauHoiB = txtB.Text;
            ch2.CauHoiC = txtC.Text;
            ch2.CauHoiD = txtD.Text;
            ch2.CauTraLoi = drlDapAn.SelectedItem.Value.ToString();

            BaiTapChuongDTO btChuongDto = new BaiTapChuongDTO();
            btChuongDto.IDChuong = Int32.Parse(drlChuong.SelectedItem.Value.ToString());
            btChuongDto.NoiDungBaiTap = Editor1.Text;
            btChuongDto.TenBaiTap = txtTenBaiTap.Text;

            int IDBaiTapChuong = 0;
            //insert bai tap cho bai hoc
            kq = BaiTapChuongBUS.insertBaiTapChuong(btChuongDto, ref IDBaiTapChuong);
            //insert dap an
            ch2.IDBaiTap = IDBaiTapChuong;
            kq2 = CauHoiBTChuongBUS.insertCauHoiBTChuong(ch2);
          
        }
        if (kq == true && kq2 == true)
            MsgBox1.alert("Nhập Thành Công");
        else
            MsgBox1.alert("Nhập Thất Bại");
    }
}
