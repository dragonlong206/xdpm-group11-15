using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestGroup14
{
    public interface IChuongDAO
    {

        System.Boolean insertChuong(Dto.ChuongDTO chuongDto);
        System.Boolean deleteChuong(System.String IDChuong);
        System.Boolean updateChuong(Dto.ChuongDTO chuongDto);
        System.Collections.ArrayList selectAllChuong();
        Dto.ChuongDTO selectChuongByIDChuong(System.Int32 IDChuong);
        System.String ToString();
        System.Boolean Equals(System.Object obj);
        System.Int32 GetHashCode();
        System.Type GetType();
    }
}
