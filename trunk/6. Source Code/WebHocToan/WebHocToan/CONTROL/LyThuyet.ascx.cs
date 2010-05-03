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

public partial class CONTROL_LyThuyet : System.Web.UI.UserControl
{
    string IDBaiHoc;
    protected void Page_Load(object sender, EventArgs e)
    {
        IDBaiHoc = Request.QueryString["IDBaiHoc"];
        if (IDBaiHoc != null)
        {
            int iIDBaiHoc = int.Parse(IDBaiHoc);

            BaiHocDTO bhDTO = BaiHocBUS.selectBaiHocByIDBaiHoc(iIDBaiHoc);

            ltrTenBai.Text = bhDTO.TenBaiHoc;
            ltrNoiDung.Text = "<p>" + bhDTO.NoiDung + "</p>";

        }

    }
}
