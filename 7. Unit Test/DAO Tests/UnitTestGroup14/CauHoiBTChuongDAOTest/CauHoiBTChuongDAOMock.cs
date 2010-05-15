using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestGroup14
{
<<<<<<< .mine
    public interface ICauHoiBTChuongDAOMock
    {

        System.Boolean insertCauHoiBTChuong(Dto.CauHoiBTChuongDTO chbtChuongDto);
        System.Boolean deleteCauHoiBTChuong(System.Int32 IDCauHoi);
        System.Boolean deleteCauHoiBTChuongByIDBaiTap(System.Int32 IDBaiTap);
        System.Boolean updateCauHoiBTChuong(Dto.CauHoiBTChuongDTO chbtChuongDto);
        System.Collections.ArrayList selectAllCauHoiBTChuong();
        Dto.CauHoiBTChuongDTO selectCauHoiBTChuongByIDCauHoi(System.Int32 IDCauHoi);
        System.Collections.ArrayList selectCauHoiBTChuongByIDChuong(System.Int32 IDChuong);
        Dto.CauHoiBTChuongDTO selectCauHoiBTChuongByIDBaiTap(System.Int32 IDBaiTap);
        System.String ToString();
        System.Boolean Equals(System.Object obj);
        System.Int32 GetHashCode();
        System.Type GetType();
    }
=======

        public interface ICauHoiBTChuongDAOMock
        {

            System.Boolean insertCauHoiBTChuong(Dto.CauHoiBTChuongDTO chbtChuongDto);
            System.Boolean deleteCauHoiBTChuong(System.String IDCauHoi);
            System.Boolean updateCauHoiBTChuong(Dto.CauHoiBTChuongDTO chbtChuongDto);
            System.Collections.ArrayList selectAllCauHoiBTChuong();
            Dto.CauHoiBTChuongDTO selectCauHoiBTChuongByIDCauHoi(System.Int32 IDCauHoi);
            System.Collections.ArrayList selectCauHoiBTChuongByIDChuong(System.Int32 IDChuong);
            System.String ToString();
            System.Boolean Equals(System.Object obj);
            System.Int32 GetHashCode();
            System.Type GetType();
        }
    
>>>>>>> .r128
}
