using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUSTest
{
    public interface IBaiHocDAO
    {

        System.Boolean insertBaiHoc(Dto.BaiHocDTO bh);
        System.Boolean insertBaiHocAutoIncrease(Dto.BaiHocDTO bh);
        System.Boolean deleteBaiHoc(System.String IDBaiHoc);
        System.Boolean updateBaiHoc(Dto.BaiHocDTO bh);
        System.Collections.ArrayList selectAllBaiHoc();
        Dto.BaiHocDTO selectBaiHocByIDBaiHoc(System.Int32 IDBaiHoc);
        System.Collections.ArrayList selectBaiHocByIDChuong(System.Int32 IDChuong);
        System.Collections.ArrayList selectIDvaTenBaiHocByIDChuong(System.Int32 IDChuong);
      
    }
}
