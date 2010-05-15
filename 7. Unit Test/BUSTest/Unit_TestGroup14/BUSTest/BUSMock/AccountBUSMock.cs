using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{
    public class AccountBUSMock
    {
        public static Boolean insertAccount(AccountDTO acc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IAccountDAO));
            IAccountDAO Obj = (IAccountDAO)mockController.MockInstance as IAccountDAO;
            mockController.ExpectAndReturn("insertAccount", true, null);
            
            return Obj.insertAccount(new AccountDTO());
        }

        public static Boolean deleteAccount(string IDAcc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IAccountDAO));
            IAccountDAO Obj = (IAccountDAO)mockController.MockInstance as IAccountDAO;
            mockController.ExpectAndReturn("deleteAccount", true, null);

            return Obj.deleteAccount(IDAcc);
        }

        public static Boolean updateAccount(AccountDTO acc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IAccountDAO));
            IAccountDAO Obj = (IAccountDAO)mockController.MockInstance as IAccountDAO;
            mockController.ExpectAndReturn("updateAccount", false, null);
            return Obj.updateAccount(new AccountDTO());
        }

        public static ArrayList selectAllAccount()
        {
            DynamicMock mockController = new DynamicMock(typeof(IAccountDAO));
            IAccountDAO Obj = (IAccountDAO)mockController.MockInstance as IAccountDAO;
            mockController.ExpectAndReturn("selectAllAccount", Obj.selectAllAccount(), null);
            return Obj.selectAllAccount();
        }

        public static ArrayList selectAccountByLAC(int MaLoaiacc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IAccountDAO));
            IAccountDAO Obj = (IAccountDAO)mockController.MockInstance as IAccountDAO;
            mockController.ExpectAndReturn("selectAccountByLAC", Obj.selectAccountByLAC(MaLoaiacc), null);
            return Obj.selectAccountByLAC(MaLoaiacc);
        }
        public static AccountDTO selectAccountByIDAC(string IDAcc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IAccountDAO));
            IAccountDAO Obj = (IAccountDAO)mockController.MockInstance as IAccountDAO;
            mockController.ExpectAndReturn("selectAccountByIDAC", Obj.selectAccountByIDAC(IDAcc), null);
            return Obj.selectAccountByIDAC( IDAcc);
        }
        public static AccountDTO selectAccountByEmail(string Email)
        {
            DynamicMock mockController = new DynamicMock(typeof(IAccountDAO));
            IAccountDAO Obj = (IAccountDAO)mockController.MockInstance as IAccountDAO;
            mockController.ExpectAndReturn("selectAccountByEmail", Obj.selectAccountByEmail(Email), null);
            return Obj.selectAccountByEmail(Email);
        }
    }
}
