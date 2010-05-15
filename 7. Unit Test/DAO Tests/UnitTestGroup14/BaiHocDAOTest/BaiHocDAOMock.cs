using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestGroup14
{
    public interface IBaiHocDAOMock
    {

        System.Boolean insertBaiHoc(Dto.BaiHocDTO bh);
        System.Boolean deleteBaiHoc(System.Int32 IDBaiHoc);
        System.Boolean updateBaiHoc(Dto.BaiHocDTO bh);
        System.Collections.ArrayList selectAllBaiHoc();
        Dto.BaiHocDTO selectBaiHocByIDBaiHoc(System.Int32 IDBaiHoc);
        System.Collections.ArrayList selectBaiHocByIDChuong(System.Int32 IDChuong);
        System.String ToString();
        System.Boolean Equals(System.Object obj);
        System.Int32 GetHashCode();
        System.Type GetType();
    }
}
