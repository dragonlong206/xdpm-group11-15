using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class CauHoiBTChuongBUS
    {
        public static Boolean insertCauHoiBTChuong(CauHoiBTChuongDTO chbtChuongDto)
        {
            Boolean result = false;
            result = CauHoiBTChuongDAO.insertCauHoiBTChuong(chbtChuongDto);
            return result;
        }

        public static Boolean deleteCauHoiBTChuong(int IDChuong)
        {
            Boolean result = false;
            result = CauHoiBTChuongDAO.deleteCauHoiBTChuong(IDChuong);
            return result;
        }

        public static Boolean deleteCauHoiBTChuongByIDBaiTap(int IDBaiTap)
        {
            Boolean result = false;
            result = CauHoiBTChuongDAO.deleteCauHoiBTChuongByIDBaiTap(IDBaiTap);
            return result;
        }

        public static Boolean updateCauHoiBTChuong(CauHoiBTChuongDTO chbtChuongDto)
        {
            Boolean result = false;
            result = CauHoiBTChuongDAO.updateCauHoiBTChuong(chbtChuongDto);
            return result;
        }

        public static ArrayList selectAllChuong()
        {
            return CauHoiBTChuongDAO.selectAllCauHoiBTChuong();
        }

        public static ArrayList selectCauHoiBTChuongByIDChuong(int IDChuong)
        {
            return CauHoiBTChuongDAO.selectCauHoiBTChuongByIDChuong(IDChuong);
        }

        public static CauHoiBTChuongDTO selectCauHoiBTChuongByIDBaiTap(int IDBaiTap)
        {
            return CauHoiBTChuongDAO.selectCauHoiBTChuongByIDBaiTap(IDBaiTap);
        }
        public static CauHoiBTChuongDTO selectCauHoiBTChuongByIDCauHoi(int IDCauHoi)
        {
            return CauHoiBTChuongDAO.selectCauHoiBTChuongByIDCauHoi(IDCauHoi);
        }

    }
}
