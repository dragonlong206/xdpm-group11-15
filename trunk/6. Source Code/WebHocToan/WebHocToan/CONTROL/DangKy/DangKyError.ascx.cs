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

public partial class CONTROL_DangKy_DangKyError : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Session["gdusername"] != null)
            txtUsername.Text = (string)HttpContext.Current.Session["gdusername"];
    }
}
