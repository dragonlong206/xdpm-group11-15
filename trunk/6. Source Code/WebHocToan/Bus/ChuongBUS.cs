using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class ChuongBUS
    {
        public static Boolean insertChuong(ChuongDTO chuongDTO)
        {
            Boolean result = false;
            result = ChuongDAO.insertChuong(chuongDTO);
            return result;
        }

        public static Boolean deleteChuong(string IDChuong)
        {
            Boolean result = false;
            result = ChuongDAO.deleteChuong(IDChuong);
            return result;
        }

        public static Boolean updateChuong(ChuongDTO Chuong)
        {
            Boolean result = false;
            result = ChuongDAO.updateChuong(Chuong);
            return result;
        }

        public static ArrayList selectAllChuong()
        {
            return ChuongDAO.selectAllChuong();
        }



        public static ChuongDTO selectChuongByIDChuong(int IDChuong)
        {
            return ChuongDAO.selectChuongByIDChuong(IDChuong);
        }
        public static ArrayList selectChuongByIDMonHoc(int IDMonHoc)
        {
            return ChuongDAO.selectChuongByIDMonHoc(IDMonHoc);
        }
    }
}
