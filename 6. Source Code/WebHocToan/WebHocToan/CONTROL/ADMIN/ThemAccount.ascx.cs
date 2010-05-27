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
public partial class CONTROL_ADMIN_ThemAccount : System.Web.UI.UserControl
{
    string mPassword;
    string mConfirmPassword;


    protected void Page_Load(object sender, EventArgs e)
    {
       if (!IsPostBack)
        {
            ArrayList list1 = new ArrayList();
            list1 = LoaiAccBUS.selectAllLoaiAcc();

            drlLoaiAccount.DataTextField = "TenLoaiAcc";
            drlLoaiAccount.DataValueField = "IDLoaiAcc";
            drlLoaiAccount.DataSource = list1;
            drlLoaiAccount.DataBind();

            msgUsername.ForeColor = System.Drawing.Color.Red;
            msgPassword.ForeColor = System.Drawing.Color.Red;
            msgConfirmPassword.ForeColor = System.Drawing.Color.Red;
            msgEmail.ForeColor = System.Drawing.Color.Red;
        }

        if (IsPostBack)
        {
            txtPassword.Attributes["value"] = txtPassword.Text;
            txtConfirmPassword.Attributes["value"] = txtConfirmPassword.Text;
        }
    }


    protected void btnDangKy_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text == "")
        {
            msgUsername.Text = "Username không được trốnng";
            msgUsername.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            string Username = txtUsername.Text;
            AccountDTO accDTO = AccountBUS.selectAccountByIDAC(Username);
            if (accDTO.IDAcc != null)
            {
                msgUsername.Text = "Username này đã được ký.";
                msgUsername.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                msgUsername.Text = "Username này có thể dùng.";
                msgUsername.ForeColor = System.Drawing.Color.Green;

            }
        }

        if (txtPassword.Text == "")
        {
            msgPassword.Text = "Password không được trốnng";
            msgPassword.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            mPassword = txtPassword.Text;
            mConfirmPassword = txtConfirmPassword.Text;

            if (mPassword != mConfirmPassword)
            {
                msgPassword.Text = "Password & ConfirmPassword không trùng khớp.";
                msgConfirmPassword.Text = "Password & ConfirmPassword không trùng khớp.";

                msgPassword.ForeColor = System.Drawing.Color.Red; ;
                msgConfirmPassword.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                msgPassword.Text = "Password & ConfirmPassword trùng khớp.";
                msgConfirmPassword.Text = "Password & ConfirmPassword trùng khớp.";

                msgPassword.ForeColor = System.Drawing.Color.Green; ;
                msgConfirmPassword.ForeColor = System.Drawing.Color.Green; ;

            }
        }

        if (txtConfirmPassword.Text == "")
        {
            msgConfirmPassword.Text = "ConfirmPassword không được trốnng";
            msgConfirmPassword.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            mPassword = txtPassword.Text;
            mConfirmPassword = txtConfirmPassword.Text;

            if (mPassword != mConfirmPassword)
            {
                msgPassword.Text = "Password & ConfirmPassword không trùng khớp.";
                msgConfirmPassword.Text = "Password & ConfirmPassword không trùng khớp.";

                msgPassword.ForeColor = System.Drawing.Color.Red; ;
                msgConfirmPassword.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                msgPassword.Text = "Password & ConfirmPassword trùng khớp.";
                msgConfirmPassword.Text = "Password & ConfirmPassword trùng khớp.";

                msgPassword.ForeColor = System.Drawing.Color.Green; ;
                msgConfirmPassword.ForeColor = System.Drawing.Color.Green; ;

            }
        }


        if (txtEmail.Text == "")
        {
            msgEmail.Text = "Email không được trốnng";
            msgEmail.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            string Email = txtEmail.Text;
            AccountDTO accDTO = AccountBUS.selectAccountByEmail(Email);
            if (accDTO.Email != null)
            {
                msgEmail.Text = "Email này đã được ký.";
                msgEmail.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                msgEmail.Text = "Email này có thể dùng.";
                msgEmail.ForeColor = System.Drawing.Color.Green;

            }
        }

        if (msgUsername.ForeColor == System.Drawing.Color.Green && msgPassword.ForeColor == System.Drawing.Color.Green && msgConfirmPassword.ForeColor == System.Drawing.Color.Green && msgEmail.ForeColor == System.Drawing.Color.Green)
        {
            AccountDTO accDTO = new AccountDTO();
            accDTO.IDAcc = txtUsername.Text;
            accDTO.Pass = txtPassword.Text;
            accDTO.Email = txtEmail.Text;
            accDTO.TrangThai = true;
            accDTO.IDLoaiAcc = Int32.Parse(drlLoaiAccount.SelectedItem.Value.ToString()) ;
            bool result = AccountBUS.insertAccount(accDTO);
            if (result)
            {
                lbUsername.Visible = false;
                txtUsername.Visible = false;
                msgUsername.Visible = false;

                lbPassword.Visible = false;
                txtPassword.Visible = false;
                msgPassword.Visible = false;

                lbConfirmPassword.Visible = false;
                txtConfirmPassword.Visible = false;
                msgConfirmPassword.Visible = false;

                lbEmail.Visible = false;
                txtEmail.Visible = false;
                msgEmail.Visible = false;

                lbDangKy.Visible = false;
                btnDangKy.Visible = false;

                lbtb1.Visible = true;
                lbTaiKhoan.Text = accDTO.IDAcc;
                lbTaiKhoan.Visible = true;
                lbtb2.Visible = true;
            }
        }
    }
    protected void drlLoaiAccount_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
