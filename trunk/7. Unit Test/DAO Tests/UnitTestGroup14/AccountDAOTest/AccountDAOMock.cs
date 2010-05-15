using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dto;

namespace UnitTestGroup14
{
    public interface IAccountDAOMock
    {

        System.Boolean insertAccount(Dto.AccountDTO acc);
        System.Boolean deleteAccount(System.String IDAcc);
        System.Boolean updateAccount(Dto.AccountDTO acc);
        System.Collections.ArrayList selectAllAccount();
        System.Collections.ArrayList selectAccountByLAC(System.Int32 IDLoaiAcc);
        System.String ToString();
        System.Boolean Equals(System.Object obj);
        System.Int32 GetHashCode();
        System.Type GetType();
    }
}
