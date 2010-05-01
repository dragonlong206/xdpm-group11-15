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

using Dao;
using Dto;
using Bus;

public partial class VIEW_test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        ArrayList lst = AccountBUS.selectAllAccount();
        for (int i = 0; i < lst.Count; i++)
        {

            AccountDTO acc = (AccountDTO)lst[i];
 
        }
         * */

        /*
        ArrayList lst = AccountBUS.selectAccountByLAC(2);
        for (int i = 0; i < lst.Count; i++)
        {

            AccountDTO acc = (AccountDTO)lst[i];

        }
         * */

        /*
        AccountDTO acc = new AccountDTO();
        acc.IDAcc = "abc";

        AccountBUS.deleteAccount(acc.IDAcc);
         * */

        /*
        AccountDTO acc = new AccountDTO();
        acc.IDAcc = "Rooney";
        acc.Pass = "123456";
        acc.IDLoaiAcc = 2;
        acc.TrangThai = true;

        AccountBUS.insertAccount(acc);
         * */


        AccountDTO acc = new AccountDTO();
        acc.IDAcc = "Rooney";
        acc.Pass = "123456789";
        acc.IDLoaiAcc = 2;
        acc.TrangThai = true;

        AccountBUS.updateAccount(acc);

    }
}
