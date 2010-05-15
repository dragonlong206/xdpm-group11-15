using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestGroup14
{
    public interface IBaiTapChuongDAO
    {

        System.Boolean insertBaiTapChuong(Dto.BaiTapChuongDTO btChuongDto);
        System.Boolean deleteBaiTapChuong(System.String IDBaiTap);
        System.Boolean updateBaiTapChuong(Dto.BaiTapChuongDTO btChuongDto);
        System.Collections.ArrayList selectAllBaiTapChuong();
        Dto.BaiTapChuongDTO selectBaiTapChuongByID(System.Int32 IDBaiTap);
        System.String ToString();
        System.Boolean Equals(System.Object obj);
        System.Int32 GetHashCode();
        System.Type GetType();
    }
}
