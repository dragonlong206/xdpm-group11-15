using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUSTest
{
    public interface ICauHoiBTChuongDAO
    {

        System.Boolean insertCauHoiBTChuong(Dto.CauHoiBTChuongDTO chbtChuongDto);
        System.Boolean deleteCauHoiBTChuong(System.Int32 IDCauHoi);
        System.Boolean deleteCauHoiBTChuongByIDBaiTap(System.Int32 IDBaiTap);
        System.Boolean updateCauHoiBTChuong(Dto.CauHoiBTChuongDTO chbtChuongDto);
        System.Collections.ArrayList selectAllCauHoiBTChuong();
        Dto.CauHoiBTChuongDTO selectCauHoiBTChuongByIDCauHoi(System.Int32 IDCauHoi);
        System.Collections.ArrayList selectCauHoiBTChuongByIDChuong(System.Int32 IDChuong);
        Dto.CauHoiBTChuongDTO selectCauHoiBTChuongByIDBaiTap(System.Int32 IDBaiTap);
      
    }
}
