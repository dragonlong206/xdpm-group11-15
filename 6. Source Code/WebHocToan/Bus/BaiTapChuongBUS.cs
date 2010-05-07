using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class BaiTapChuongBUS
    {
        public static Boolean insertBaiTapChuong(BaiTapChuongDTO btChuognDto, ref int IDBaiTapChuong)
        {
            Boolean result = false;
            result = BaiTapChuongDAO.insertBaiTapChuong(btChuognDto, ref IDBaiTapChuong);
            return result;
        }

        public static Boolean deleteBaiTapChuong(int IDBaiTapChuong)
        {
            Boolean result = false;
            result = BaiTapChuongDAO.deleteBaiTapChuong(IDBaiTapChuong);
            return result;
        }

        public static Boolean updateBaiTapChuong(BaiTapChuongDTO btChuognDto)
        {
            Boolean result = false;
            result = BaiTapChuongDAO.updateBaiTapChuong(btChuognDto);
            return result;
        }

        public static ArrayList selectAllBaiTapChuong()
        {
            return BaiTapChuongDAO.selectAllBaiTapChuong();
        }



        public static BaiTapChuongDTO selectBaiTapChuongByID(int IDBaiTapChuong)
        {
            return BaiTapChuongDAO.selectBaiTapChuongByID(IDBaiTapChuong);
        }
        public static ArrayList selectBaiTapChuongByIDChuong(int ID)
        {
            return BaiTapChuongDAO.selectBaiTapChuongByIDChuong(ID);
        }

    }
}
