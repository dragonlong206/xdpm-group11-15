using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestGroup14
{

    public interface IBaiTapCuaBaiHocDAOMock
    {

        System.Boolean insertBaiTapCuaBaiHoc(Dto.BaiTapCuaBaiHocDTO btcbhDto);
        System.Boolean deleteBaiTapCuaBaiHoc(System.String IDBaiTap);
        System.Boolean updateBaiTapCuaBaiHoc(Dto.BaiTapCuaBaiHocDTO btcbhDto);
        System.Collections.ArrayList selectAllBaiTapCuaBaiHoc();
        Dto.BaiTapCuaBaiHocDTO selectBaiTapCuaBaiHocByID(System.Int32 IDBaiTap);
        System.String ToString();
        System.Boolean Equals(System.Object obj);
        System.Int32 GetHashCode();
        System.Type GetType();
    }
}
