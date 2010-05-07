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

public partial class CONTROL_Login_LoginForm : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            txtPassword.Attributes["value"] = txtPassword.Text;
        }

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        if (QuanLySessionCookie.ConfirmUser(username, password))
        {
            QuanLySessionCookie.CreateSessions(username, password);

            if (chkRemember.Checked == true)
            {
                QuanLySessionCookie.CreateCookies(username, password);
            }

        }
        else
        {
            QuanLySessionCookie.ClearSessionCookies();
        }

        Response.Redirect(Page.Request.Url.ToString(), true);
    }
}
