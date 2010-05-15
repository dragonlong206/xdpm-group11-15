using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dto;

namespace UnitTestGroup14
{
    public interface ICauHoiBTBaiHocDAOMock
    {

        System.Boolean insertCauHoiBTBaiHoc(Dto.CauHoiBTBaiHocDTO chbtBaiHocDto);
        System.Boolean deleteCauHoiBTBaiHoc(System.String IDCauHoi);
        System.Boolean updateCauHoiBTBaiHoc(Dto.CauHoiBTBaiHocDTO chbtBaiHocDto);
        System.Collections.ArrayList selectAllCauHoiBTBaiHoc();
        Dto.CauHoiBTBaiHocDTO selectCauHoiBTBaiHocByIDCauHoi(System.Int32 IDCauHoi);
        System.Collections.ArrayList selectCauHoiBTBaiHocByIDBaiHoc(System.Int32 IDBaiHoc);
        System.String ToString();
        System.Boolean Equals(System.Object obj);
        System.Int32 GetHashCode();
        System.Type GetType();
    }
}
