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

public partial class CONTROL_LeftMenu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            LoadMonHoc();

            rptChuong.DataSource = ChuongBUS.selectChuongByIDMonHoc(int.Parse(drMonHoc.SelectedValue));
            //rptChuong.DataSource = ChuongBUS.selectChuongByIDMonHoc(1);
            rptChuong.DataBind();


        }
    }
    protected void rptChuong_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        Repeater rptBai = (Repeater)e.Item.FindControl("rptBai");//tim rptBai con trong rptChuong

        if (rptBai != null)
        {
            int IDChuong = (int)DataBinder.Eval(e.Item.DataItem, "IDChuong");
            rptBai.DataSource = BaiHocBUS.selectBaiHocByIDChuong(IDChuong);
            rptBai.DataBind();
            
        }
    }

    public void LoadMonHoc()
    {
        
        drMonHoc.DataSource = MonHocBUS.selectAllMonHoc();
        drMonHoc.DataTextField = "TenMonHoc";
        drMonHoc.DataValueField = "IDMonHoc";
        drMonHoc.DataBind();


        string IDMonHoc = Request.QueryString["IDMonHoc"];
        if (IDMonHoc != null)
        {
            int iIDMonHoc;
            bool result = int.TryParse(IDMonHoc, out iIDMonHoc);
            if (result)
            {
                for (int i = 0; i < drMonHoc.Items.Count; i++)
                {
                    if (drMonHoc.Items[i].Value == iIDMonHoc.ToString())
                    {
                        drMonHoc.SelectedIndex = i;
                        return;
                    }

                }
            }

        }


        string IDBaiHoc = Request.QueryString["IDBaiHoc"];
        int iIDBaiHoc;


       if (int.TryParse(IDBaiHoc, out iIDBaiHoc))
        {
            BaiHocDTO bhDTO = BaiHocBUS.selectBaiHocByIDBaiHoc(iIDBaiHoc);
            ChuongDTO chDTO = ChuongBUS.selectChuongByIDChuong(bhDTO.IDChuong);


            for (int i = 0; i < drMonHoc.Items.Count; i++)
            {
                if (drMonHoc.Items[i].Value == chDTO.IDMonHoc.ToString())
                {
                    drMonHoc.SelectedIndex = i;
                    return;
                }

            }
        }

    }
    protected void drMonHoc_SelectedIndexChanged(object sender, EventArgs e)
    {
        string url = "index.aspx?IDMonHoc=" + drMonHoc.SelectedValue;
        Response.Redirect(url);
    }
}
