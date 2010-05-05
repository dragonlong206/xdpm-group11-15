﻿using System;
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
        idBaiHoc = Request.QueryString["IDBaiHoc"];
        idChuong = Request.QueryString["IDChuong"];
        if (!IsPostBack)
        {
            if(idChuong!=null)
                FillDropDownList(Int32.Parse(idChuong));
            if (idBaiHoc != null)
            {
                BaiHocDTO bhDto = new BaiHocDTO();
                bhDto = BaiHocBUS.selectBaiHocByIDBaiHoc(Int32.Parse(idBaiHoc));
                FillEditor(bhDto);
            }
        }
        
    }
    private void FillEditor(BaiHocDTO bhDto)
    {

        //BaiHocDTO bhDto = new BaiHocDTO();

        //msgBox1.alert(drlBaiGiang.SelectedItem.Value.ToString());
        txtBaiGiangMoi.Text = bhDto.TenBaiHoc;
        Editor1.Text = bhDto.NoiDung;

    }
    private void FillDropDownList(int ID)
    {
      
        ArrayList List = new ArrayList();
        List = BaiHocBUS.selectBaiHocByIDChuong(ID);
        drlBaiGiang.DataTextField = "TenBaiHoc";
        drlBaiGiang.DataValueField = "IDBaiHoc";
        drlBaiGiang.DataSource = List;
        drlBaiGiang.DataBind();


    }
    protected void drlChuong_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillDropDownList(Int32.Parse(drlChuong.SelectedItem.Value.ToString()));
    }
    protected void drlBaiGiang_SelectedIndexChanged(object sender, EventArgs e)
    {
        BaiHocDTO bhDto = new BaiHocDTO();
        bhDto = BaiHocBUS.selectBaiHocByIDBaiHoc(Int32.Parse(drlBaiGiang.SelectedItem.Value.ToString()));
        FillEditor(bhDto);
        
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        int id = Int32.Parse(drlBaiGiang.SelectedItem.Value.ToString());
        Boolean result = false;

        BaiHocDTO bhDto = new BaiHocDTO();
        bhDto.IDBaiHoc = id; 
        bhDto.IDChuong = Int32.Parse(drlChuong.SelectedItem.Value.ToString());
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