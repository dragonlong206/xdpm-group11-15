using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class AccountBUS
    {
        public static Boolean insertAccount(AccountDTO acc)
        {
            Boolean result = false;
            result = AccountDAO.insertAccount(acc);
            return result;
        }

        public static Boolean deleteAccount(string IDAcc)
        {
            Boolean result = false;
            result = AccountDAO.deleteAccount(IDAcc);
            return result;
        }

        public static Boolean updateAccount(AccountDTO acc)
        {
            Boolean result = false;
            result = AccountDAO.updateAccount(acc);
            return result;
        }

        public static ArrayList selectAllAccount()
        {
            return AccountDAO.selectAllAccount();
        }

        public static ArrayList selectAccountByLAC(int MaLoaiacc)
        {
            return AccountDAO.selectAccountByLAC(MaLoaiacc);
        }
        public static AccountDTO selectAccountByIDAC(string IDAcc)
        {
            return AccountDAO.selectAccountByIDAC(IDAcc);
        }
        public static AccountDTO selectAccountByEmail(string Email)
        {
            return AccountDAO.selectAccountByEmail(Email);
        }
    }
}
