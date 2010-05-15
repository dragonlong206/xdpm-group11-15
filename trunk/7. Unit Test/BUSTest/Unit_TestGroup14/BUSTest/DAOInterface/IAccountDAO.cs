using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUSTest
{
    public interface IAccountDAO
    {

        System.Boolean insertAccount(Dto.AccountDTO acc);
        System.Boolean deleteAccount(System.String IDAcc);
        System.Boolean updateAccount(Dto.AccountDTO acc);
        System.Collections.ArrayList selectAllAccount();
        System.Collections.ArrayList selectAccountByLAC(System.Int32 IDLoaiAcc);
        Dto.AccountDTO selectAccountByIDAC(System.String IDAcc);
        Dto.AccountDTO selectAccountByEmail(System.String Email);
      
    }
}
