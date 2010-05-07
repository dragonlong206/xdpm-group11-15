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
    private void FillDropDownListBaiTap()
    {

        ArrayList List = new ArrayList();
        if (chbBaiTap.Checked == true)
        {
            List = BaiTapCuaBaiHocBUS.selectBaiTapCuaBaiHocByIDBaiHoc(Int32.Parse(drlBaiHoc.SelectedItem.Value.ToString()));
            drlNoiDung.DataSource = List;
            drlNoiDung.DataTextField = "TenBaiTap";
            drlNoiDung.DataValueField = "IDBaiTap";
            drlNoiDung.DataBind();
            //txtTenBaiTap.Text = "'Baì tập này đã có'";
            //txtTenBaiTap.Enabled = false;
        }
        else
        {
            List = BaiTapChuongBUS.selectBaiTapChuongByIDChuong(Int32.Parse(drlChuong.SelectedItem.Value.ToString()));
            drlNoiDung.DataSource = List;
            drlNoiDung.DataTextField = "TenBaiTap";
            drlNoiDung.DataValueField = "IDBaiTap";
            drlNoiDung.DataBind();
            //txtTenBaiTap.Text = "'Baì tập này đã có'";
            //txtTenBaiTap.Enabled = false;
        }
        
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
            //drlNoiDung.DataSource = 
            //lblTenBaiTap.Visible = false;
            //txtTenBaiTap.Visible = false;
            //FillDropDownListNoiDung(Int32.Parse(drlBaiHoc.SelectedItem.Value.ToString()));

            FillDropDownListBaiTap();
          
            //neu la bai tap cua chuong thi select bai tap chuong Dto theo id bai tap de dien vao txt Baitap
            if (chbBaiTap.Checked == true)
            {
                BaiTapChuongDTO btChuongDto = new BaiTapChuongDTO();
                btChuongDto = BaiTapChuongBUS.selectBaiTapChuongByID(Int32.Parse(drlNoiDung.SelectedItem.Value.ToString()));
                txtTenBaiTap.Text = btChuongDto.TenBaiTap.ToString();
                txtNoiDung.Text = btChuongDto.NoiDungBaiTap.ToString();
                txtNoiDung.Enabled = false;
            }
                //neu la bai tap bai hoc thi select bai tap bai hoc theo id roi dien vao txt noi dung 
            else
            {
                BaiTapCuaBaiHocDTO btbhDto = new BaiTapCuaBaiHocDTO();
                btbhDto = BaiTapCuaBaiHocBUS.selectBaiTapCuaBaiHocByID(Int32.Parse(drlNoiDung.SelectedItem.Value.ToString()));
                txtTenBaiTap.Text = btbhDto.TenBaiTap.ToString();
                txtNoiDung.Text = btbhDto.NoiDungBaiTap.ToString();
                txtNoiDung.Enabled = false;
            }
            //txtTenBaiTap.Text = 
            txtTenBaiTap.Text = "'Baì tập này đã có'";
            txtTenBaiTap.Enabled = false;
        }
        else
        {
            //lblTenBaiTap.Visible = true;
            //txtTenBaiTap.Visible = true;
            lblBaiTap.Visible = false;
            drlNoiDung.Visible = false;
            txtTenBaiTap.Text = "Bạn nhập tên bài tập vào đây";
            txtTenBaiTap.Enabled = true;
            txtNoiDung.Enabled = true;
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
            ch.CauTraLoi = Char.Parse(drlDapAn.SelectedItem.Value.ToString());

            BaiTapCuaBaiHocDTO btcbhDto = new BaiTapCuaBaiHocDTO();
            btcbhDto.IDBaiHoc = Int32.Parse(drlBaiHoc.SelectedItem.Value.ToString());
            btcbhDto.NoiDungBaiTap = txtNoiDung.Text;
            btcbhDto.TenBaiTap = txtTenBaiTap.Text;


            if (chbNoiDung.Checked == false)
            {
                //insert bai tap cho bai hoc
                kq = BaiTapCuaBaiHocBUS.insertBaiTapCuaBaiHoc(btcbhDto);
                //insert dap an
                kq2 = CauHoiBTBaiHocBUS.insertCauHoiBTBaiHoc(ch);
                if (kq == true && kq2 == true)
                    MsgBox1.alert("Nhập Thành Công");
                else
                    MsgBox1.alert("Nhập Thất Bại");
            }
            else
            {
                kq2 = CauHoiBTBaiHocBUS.insertCauHoiBTBaiHoc(ch);
                if (kq2 == true)
                    MsgBox1.alert("Nhập Thành Công");
                else
                    MsgBox1.alert("Nhập Thất Bại");
            }
        }
        else
        {
            CauHoiBTChuongDTO ch2 = new CauHoiBTChuongDTO();
            ch2.CauHoiA = txtA.Text;
            ch2.CauHoiB = txtB.Text;
            ch2.CauHoiC = txtC.Text;
            ch2.CauHoiD = txtD.Text;
            ch2.CauTraLoi = Char.Parse(drlDapAn.SelectedItem.Value.ToString());

            BaiTapChuongDTO btChuongDto = new BaiTapChuongDTO();
            btChuongDto.IDChuong = Int32.Parse(drlChuong.SelectedItem.Value.ToString());
            btChuongDto.NoiDungBaiTap = txtNoiDung.Text;
            btChuongDto.TenBaiTap = txtTenBaiTap.Text;

            if (chbNoiDung.Checked == false)
            {
                //insert bai tap cho bai hoc
                kq = BaiTapChuongBUS.insertBaiTapChuong(btChuongDto);
                //insert dap an
                kq2 = CauHoiBTChuongBUS.insertCauHoiBTChuong(ch2);
                if (kq == true && kq2 == true)
                    MsgBox1.alert("Nhập Thành Công");
                else
                    MsgBox1.alert("Nhập Thất Bại");
            }
            else
            {
                kq2 = CauHoiBTChuongBUS.insertCauHoiBTChuong(ch2);
                if (kq2 == true)
                    MsgBox1.alert("Nhập Thành Công");
                else
                    MsgBox1.alert("Nhập Thất Bại");
            }
        }
        if (kq == true && kq2 == true)
            MsgBox1.alert("Nhập Thành Công");
        else
            MsgBox1.alert("Nhập Thất Bại");
    }
}
