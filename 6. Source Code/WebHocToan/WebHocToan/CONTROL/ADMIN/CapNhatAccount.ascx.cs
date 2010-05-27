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
public partial class CONTROL_ADMIN_CapNhatAccount : System.Web.UI.UserControl
{
    string idAccout;
    string idLoaiAccount;
    protected void Page_Load(object sender, EventArgs e)
    {
        idAccout = Request.QueryString["IDAccount"];
        idLoaiAccount = Request.QueryString["IDLoaiAccount"];



        if (!IsPostBack)
        {
            if (idAccout != null)
            {
                ArrayList list1 = new ArrayList();
                list1 = LoaiAccBUS.selectAllLoaiAcc();

                drlLoaiAccount.DataTextField = "TenLoaiAcc";
                drlLoaiAccount.DataValueField = "IDLoaiAcc";
                drlLoaiAccount.DataSource = list1;
                drlLoaiAccount.DataBind();

                AccountDTO accDto = new AccountDTO();
                accDto = AccountBUS.selectAccountByIDAC(idAccout);
                FillEditor(accDto);

                drlLoaiAccount.SelectedIndex = accDto.IDLoaiAcc - 1;

                ArrayList list2 = new ArrayList();
                list2 = AccountBUS.selectAccountByLAC(accDto.IDLoaiAcc);

                drlAccount.DataTextField = "IDAcc";
                drlAccount.DataValueField = "IDAcc";
                drlAccount.DataSource = list2;
                drlAccount.DataBind();
                drlAccount.SelectedItem.Value = idAccout;

            }
            else
            {
                ArrayList list1 = new ArrayList();
                list1 = LoaiAccBUS.selectAllLoaiAcc();

                drlLoaiAccount.DataTextField = "TenLoaiAcc";
                drlLoaiAccount.DataValueField = "IDLoaiAcc";
                drlLoaiAccount.DataSource = list1;
                drlLoaiAccount.DataBind();

                ArrayList list2 = new ArrayList();
                list2 = AccountBUS.selectAccountByLAC(Int32.Parse(drlLoaiAccount.SelectedItem.Value.ToString()));

                drlAccount.DataTextField = "IDAcc";
                drlAccount.DataValueField = "IDAcc";
                drlAccount.DataSource = list2;
                drlAccount.DataBind();


                AccountDTO accDto = new AccountDTO();
                accDto = AccountBUS.selectAccountByIDAC(drlLoaiAccount.SelectedItem.Value.ToString());
                FillEditor(accDto);
            }

        }
    }

    private void FillEditor(AccountDTO accDto)
    {
        if (txtUsername.Text != "")
            txtUsername.Text = "";
        txtUsername.Text = accDto.IDAcc;
        if (txtPassword.Text != "")
            txtPassword.Text = "";
        txtPassword.Text = accDto.Pass;
        if (txtEmail.Text != "")
            txtEmail.Text = "";
        txtEmail.Text = accDto.Email;

    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
    
        Boolean result = false;
        string temp = drlAccount.SelectedItem.Value.ToString();
        AccountDTO accDto = new AccountDTO();
        accDto.Email = txtEmail.Text;
        accDto.Pass = txtPassword.Text;
        accDto.TrangThai = true;
        accDto.IDLoaiAcc = Int32.Parse(drlLoaiAccount.SelectedItem.Value.ToString());
        if (idAccout != null && idAccout == temp)
            accDto.IDAcc = idAccout;
        else
            accDto.IDAcc = temp;

        result = AccountBUS.updateAccount(accDto);
        if (result == true)
        {
            msgBox1.alert(" Cập nhật thành công ");
        }
        else
        {
            msgBox1.alert(" Cập nhật thất bại ");
        }
    }

    protected void drlLoaiAccount_SelectedIndexChanged(object sender, EventArgs e)
    {
        ArrayList list2 = new ArrayList();
        list2 = AccountBUS.selectAccountByLAC(Int32.Parse(drlLoaiAccount.SelectedItem.Value.ToString()));

        drlAccount.DataTextField = "IDAcc";
        drlAccount.DataValueField = "IDAcc";
        drlAccount.DataSource = list2;
        drlAccount.DataBind();


        AccountDTO accDto = new AccountDTO();
        accDto = AccountBUS.selectAccountByIDAC(drlLoaiAccount.SelectedItem.Value.ToString());
        FillEditor(accDto);
    }
    protected void drlAccount_SelectedIndexChanged(object sender, EventArgs e)
    {
        AccountDTO accDto = new AccountDTO();
        accDto = AccountBUS.selectAccountByIDAC(drlAccount.SelectedItem.Text);
        txtUsername.Text = accDto.IDAcc;
        txtPassword.Text = accDto.Pass;
        txtEmail.Text = accDto.Email;
    }
}
