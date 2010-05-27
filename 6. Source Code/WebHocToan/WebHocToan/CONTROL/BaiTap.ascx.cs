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

public partial class CONTROL_BaiTap : System.Web.UI.UserControl
{
    string IDBaiHoc;
    protected void Page_Load(object sender, EventArgs e)
    {
     

        IDBaiHoc = Request.QueryString["IDBaiHoc"];
        int iIDBaiHoc;
        Boolean result = int.TryParse(IDBaiHoc, out iIDBaiHoc);

        if (result)
        {
            if (!IsPostBack)
            {
                ArrayList list = new ArrayList();
                list = BaiTapCuaBaiHocBUS.selectBaiTapBaiHocByIDBaiHoc(Int32.Parse(IDBaiHoc));
                grQuestions.DataSource = list;
                grQuestions.DataBind();
            }

        }


    }
    
}
