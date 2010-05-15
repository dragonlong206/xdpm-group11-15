using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUSTest
{
    public interface IBaiTapCuaBaiHocDAO
    {

        System.Boolean insertBaiTapCuaBaiHoc(Dto.BaiTapCuaBaiHocDTO btcbhDto, System.Int32 IDBaiTapBaiHoc);
        System.Boolean deleteBaiTapCuaBaiHoc(System.Int32 IDBaiTap);
        System.Boolean updateBaiTapCuaBaiHoc(Dto.BaiTapCuaBaiHocDTO btcbhDto);
        System.Collections.ArrayList selectAllBaiTapCuaBaiHoc();
        Dto.BaiTapCuaBaiHocDTO selectBaiTapCuaBaiHocByID(System.Int32 IDBaiTap);
        System.Collections.ArrayList selectBaiTapCuaBaiHocByIDBaiHoc(System.Int32 IDBaiHoc);
        System.Collections.ArrayList selectBaiTapCuaBaiHocByIDBaiHoc2(System.Int32 IDBaiHoc);
        System.Collections.ArrayList selectAllBaiTapCuaBaiHocByIDBaiHoc(System.Int32 ID);
      
    }
}
