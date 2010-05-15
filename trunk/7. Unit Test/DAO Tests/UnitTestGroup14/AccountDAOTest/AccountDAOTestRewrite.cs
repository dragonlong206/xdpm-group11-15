using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dto;
using NUnit.Framework;
using NUnit.Mocks;
using System.Collections;

namespace UnitTestGroup14
{
    public class AccountDAOTestRewrite
    {
        public static Boolean insertAccount(AccountDTO obj)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IAccountDAOMock));
            IAccountDAOMock ILADobj = (IAccountDAOMock)controller.MockInstance as IAccountDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertAccount", true, null);
            return ILADobj.insertAccount(new AccountDTO());
        }

        public static Boolean deleteAccount(String IDAcc)
        {
            DynamicMock controller = new DynamicMock(typeof(IAccountDAOMock));
            IAccountDAOMock ILADobj = (IAccountDAOMock)controller.MockInstance as IAccountDAOMock;
            controller.ExpectAndReturn("deleteAcount", true, null);
            return ILADobj.deleteAccount(IDAcc);
        }
        public static Boolean updateAccount(AccountDTO acc)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IAccountDAOMock));
            IAccountDAOMock ILADobj = (IAccountDAOMock)controller.MockInstance as IAccountDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateAccount", true, null);
            return ILADobj.updateAccount(new AccountDTO());
        }
        public static ArrayList selectAllAccount()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IAccountDAOMock));
            IAccountDAOMock ILADobj = (IAccountDAOMock)controller.MockInstance as IAccountDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateAccount", true, null);
            return ILADobj.selectAllAccount();
        }
        public static ArrayList selectAccountByLAC(int IDLoaiAcc)
        {
             DynamicMock controller = new DynamicMock(typeof(IAccountDAOMock));
             IAccountDAOMock ILADobj = (IAccountDAOMock)controller.MockInstance as IAccountDAOMock;
             controller.ExpectAndReturn("deleteAcount", true, null);
             return ILADobj.selectAccountByLAC(IDLoaiAcc);
        }
     
    }
}
