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

public partial class CONTROL_ADMIN_CapNhatBaiTap : System.Web.UI.UserControl
{
    string MonHoc ;
    string Chuong ;
    string status;
    string BaiHoc ;
    string IDBaiTapBaiHoc ;
    string IDBaiTapChuong ;

    protected void Page_Load(object sender, EventArgs e)
    {
        Page.SmartNavigation = true;
        MonHoc = Request.QueryString["monhoc"];
        BaiHoc = Request.QueryString["baihoc"];
        Chuong = Request.QueryString["chuong"];

        status = Request.QueryString["status"];
        IDBaiTapBaiHoc = Request.QueryString["IDBaiTapBaiHoc"];
        IDBaiTapChuong = Request.QueryString["IDBaiTapChuong"];

        if (!IsPostBack)
        {
            ArrayList list1 = new ArrayList();
            list1 = MonHocBUS.selectAllMonHoc();

            drlMonHoc.DataTextField = "TenMonHoc";
            drlMonHoc.DataValueField = "IDMonHoc";
            drlMonHoc.DataSource = list1;
            drlMonHoc.DataBind();
            
            if (MonHoc != null)
            {
                drlMonHoc.SelectedIndex = Int32.Parse(MonHoc) - 1;
            }

            if (Chuong != null)
            {
                ArrayList list = new ArrayList();
                list = ChuongBUS.selectChuongByIDMonHoc(Int32.Parse(Chuong));

                drlChuong.DataTextField = "TenChuong";
                drlChuong.DataValueField = "IDChuong";
                drlChuong.DataSource = list;
                drlChuong.DataBind();


                BaiTapChuongDTO btcDto = new BaiTapChuongDTO();


                if (IDBaiTapChuong != "")
                {                    
                    btcDto = BaiTapChuongBUS.selectBaiTapChuongByID(Int32.Parse(IDBaiTapChuong));
                    txtTenBaiTap.Text = btcDto.TenBaiTap.ToString();
                    txtNoiDung.Text = btcDto.NoiDungBaiTap.ToString();

                    CauHoiBTChuongDTO chbtcDto = new CauHoiBTChuongDTO();
                    chbtcDto = CauHoiBTChuongBUS.selectCauHoiBTChuongByIDBaiTap(Int32.Parse(IDBaiTapChuong));
                    txtA.Text = chbtcDto.CauHoiA.ToString() ;
                    txtB.Text = chbtcDto.CauHoiB.ToString();
                    txtC.Text = chbtcDto.CauHoiC.ToString();
                    txtD.Text = chbtcDto.CauHoiD.ToString();
                    drlDapAn.Text = chbtcDto.CauTraLoi.ToString();
                }
            }
            if (status == "1")
            {
                chbBaiTap.Checked = true;

                FillDropDownListBaiHoc(Int32.Parse(Chuong));
                BaiTapCuaBaiHocDTO btcbhDto = new BaiTapCuaBaiHocDTO();
                btcbhDto = BaiTapCuaBaiHocBUS.selectBaiTapCuaBaiHocByID(Int32.Parse(BaiHoc));
                txtTenBaiTap.Text = btcbhDto.TenBaiTap;
                txtNoiDung.Text = btcbhDto.NoiDungBaiTap;

                CauHoiBTBaiHocDTO chbtbhDto = new CauHoiBTBaiHocDTO();
                chbtbhDto = CauHoiBTBaiHocBUS.selectCauHoiBTBaiHocByIDBaiTap(Int32.Parse(IDBaiTapBaiHoc));

                txtA.Text = chbtbhDto.CauHoiA.ToString();
                txtB.Text = chbtbhDto.CauHoiB.ToString();
                txtC.Text = chbtbhDto.CauHoiC.ToString();
                txtD.Text = chbtbhDto.CauHoiD.ToString();
                drlDapAn.Text = chbtbhDto.CauTraLoi.ToString();
            }
            else
            {
                chbBaiTap.Checked = true;
                ArrayList list = new ArrayList();
                list = ChuongBUS.selectChuongByIDMonHoc(1);

                drlChuong.DataTextField = "TenChuong";
                drlChuong.DataValueField = "IDChuong";
                drlChuong.DataSource = list;
                drlChuong.DataBind();

                FillDropDownListBaiHoc(1);

                FillDropDownListNoiDung(1);

            }
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
    private void FillDropDownListNoiDung(int ID)
    {
        ArrayList list = new ArrayList();
        if (chbBaiTap.Checked == true)
            list = BaiTapCuaBaiHocBUS.selectAllBaiTapCuaBaiHocByIDBaiHoc(ID);
        else
            list = BaiTapChuongBUS.selectBaiTapChuongByIDChuong(ID);
        drlNoiDung.DataTextField = "TenBaiTap";
        drlNoiDung.DataValueField = "IDBaiTap";
        drlNoiDung.DataSource = list;
        drlNoiDung.DataBind();
    }
    protected void drlChuong_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillDropDownListBaiHoc(Int32.Parse(drlChuong.SelectedItem.Value.ToString()));
        if (chbBaiTap.Checked == false)
            FillDropDownListNoiDung(Int32.Parse(drlChuong.SelectedItem.Value.ToString()));
    }
    protected void drlBaiHoc_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(chbBaiTap.Checked == true)
            FillDropDownListNoiDung(Int32.Parse(drlBaiHoc.SelectedItem.Value.ToString()));
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

    protected void drlNoiDung_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (chbBaiTap.Checked == true)
        {
            //FillDropDownListBaiHoc(Int32.Parse(Chuong));
            BaiTapCuaBaiHocDTO btcbhDto = new BaiTapCuaBaiHocDTO();
            btcbhDto = BaiTapCuaBaiHocBUS.selectBaiTapCuaBaiHocByID(Int32.Parse(drlNoiDung.SelectedItem.Value.ToString()));
            txtTenBaiTap.Text = btcbhDto.TenBaiTap;
            txtNoiDung.Text = btcbhDto.NoiDungBaiTap;

            CauHoiBTBaiHocDTO chbtbhDto = new CauHoiBTBaiHocDTO();
            chbtbhDto = CauHoiBTBaiHocBUS.selectCauHoiBTBaiHocByIDBaiTap(Int32.Parse(drlNoiDung.SelectedItem.Value.ToString()));

            txtA.Text = chbtbhDto.CauHoiA.ToString();
            txtB.Text = chbtbhDto.CauHoiB.ToString();
            txtC.Text = chbtbhDto.CauHoiC.ToString();
            txtD.Text = chbtbhDto.CauHoiD.ToString();
            drlDapAn.Text = chbtbhDto.CauTraLoi.ToString();
        }
        else
        {
            BaiTapChuongDTO btcDto = new BaiTapChuongDTO();

            btcDto = BaiTapChuongBUS.selectBaiTapChuongByID(Int32.Parse(drlNoiDung.SelectedItem.Value.ToString()));
            txtTenBaiTap.Text = btcDto.TenBaiTap.ToString();
            txtNoiDung.Text = btcDto.NoiDungBaiTap.ToString();

            CauHoiBTChuongDTO chbtcDto = new CauHoiBTChuongDTO();
            chbtcDto = CauHoiBTChuongBUS.selectCauHoiBTChuongByIDBaiTap(Int32.Parse(drlNoiDung.SelectedItem.Value.ToString()));
            txtA.Text = chbtcDto.CauHoiA.ToString();
            txtB.Text = chbtcDto.CauHoiB.ToString();
            txtC.Text = chbtcDto.CauHoiC.ToString();
            txtD.Text = chbtcDto.CauHoiD.ToString();
            drlDapAn.Text = chbtcDto.CauTraLoi.ToString();
        }

    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        Boolean kq = false;
        Boolean kq2 = false;
        if (chbBaiTap.Checked == true)
        {
            BaiTapCuaBaiHocDTO btcbhDto = new BaiTapCuaBaiHocDTO();
            btcbhDto.TenBaiTap = txtTenBaiTap.Text;
            btcbhDto.NoiDungBaiTap =   txtNoiDung.Text;
            btcbhDto.IDBaiHoc = Int32.Parse(drlBaiHoc.SelectedItem.Value.ToString());
            btcbhDto.IDBaiTap = Int32.Parse(drlNoiDung.SelectedItem.Value.ToString());
            kq =  BaiTapCuaBaiHocBUS.updateBaiTapCuaBaiHoc(btcbhDto);

            CauHoiBTBaiHocDTO chbtbhDto = new CauHoiBTBaiHocDTO();
           
            chbtbhDto.CauHoiA = txtA.Text ;
            chbtbhDto.CauHoiB = txtB.Text ; 
            chbtbhDto.CauHoiC = txtC.Text;
            chbtbhDto.CauHoiD = txtD.Text;
            chbtbhDto.CauTraLoi = drlDapAn.SelectedItem.Value.ToString();
            chbtbhDto.IDBaiTap = Int32.Parse(drlNoiDung.SelectedItem.Value.ToString());

            kq2 =  CauHoiBTBaiHocBUS.updateCauHoiBTBaiHoc(chbtbhDto);

        }
        else
        {
            BaiTapChuongDTO btcDto = new BaiTapChuongDTO();
            btcDto.TenBaiTap = txtTenBaiTap.Text;
            btcDto.NoiDungBaiTap = txtNoiDung.Text;
            btcDto.IDBaiTap = Int32.Parse(drlNoiDung.SelectedItem.Value.ToString());
            btcDto.IDChuong = Int32.Parse(drlChuong.SelectedItem.Value.ToString());
            kq =  BaiTapChuongBUS.updateBaiTapChuong(btcDto);

            CauHoiBTChuongDTO chbtcDto = new CauHoiBTChuongDTO();
           
            chbtcDto.CauHoiA = txtA.Text;
            chbtcDto.CauHoiB = txtB.Text;
            chbtcDto.CauHoiC = txtC.Text;
            chbtcDto.CauHoiD = txtD.Text;
            chbtcDto.CauTraLoi = drlDapAn.SelectedItem.Value.ToString();
            chbtcDto.IDBaiTap = Int32.Parse(drlNoiDung.SelectedItem.Value.ToString());
            kq2 = CauHoiBTChuongBUS.updateCauHoiBTChuong(chbtcDto);
        }
        if (kq == true && kq2 == true)
           msgBox1.alert("Cập Nhật Thành Công");
        else
           msgBox1.alert("Cập Nhật Thất Bại");
    }
}
