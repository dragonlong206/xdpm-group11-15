using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUSTest
{
    public interface ICauHoiBTBaiHocDAO
    {

        System.Boolean insertCauHoiBTBaiHoc(Dto.CauHoiBTBaiHocDTO chbtBaiHocDto);
        System.Boolean deleteCauHoiBTBaiHoc(System.Int32 IDCauHoi);
        System.Boolean deleteCauHoiBTBaiHocByIDBaiTap(System.Int32 IDBaiTap);
        System.Boolean updateCauHoiBTBaiHoc(Dto.CauHoiBTBaiHocDTO chbtBaiHocDto);
        System.Collections.ArrayList selectAllCauHoiBTBaiHoc();
        Dto.CauHoiBTBaiHocDTO selectCauHoiBTBaiHocByIDCauHoi(System.Int32 IDCauHoi);
        Dto.CauHoiBTBaiHocDTO selectCauHoiBTBaiHocByIDBaiTap(System.Int32 IDBaiTap);
      
    }
}
