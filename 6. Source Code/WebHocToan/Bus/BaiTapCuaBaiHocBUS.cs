using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class BaiTapCuaBaiHocBUS
    {
        public static Boolean insertBaiTapCuaBaiHoc(BaiTapCuaBaiHocDTO btcbhDto)
        {
            Boolean result = false;
            result = BaiTapCuaBaiHocDAO.insertBaiTapCuaBaiHoc(btcbhDto);
            return result;
        }

        public static Boolean deleteBaiTapCuaBaiHoc(string IDBaiTapCuaBaiHoc)
        {
            Boolean result = false;
            result = BaiTapCuaBaiHocDAO.deleteBaiTapCuaBaiHoc(IDBaiTapCuaBaiHoc);
            return result;
        }

        public static Boolean updateBaiTapCuaBaiHoc(BaiTapCuaBaiHocDTO btcbhDto)
        {
            Boolean result = false;
            result = BaiTapCuaBaiHocDAO.updateBaiTapCuaBaiHoc(btcbhDto);
            return result;
        }

        public static ArrayList selectAllBaiTapCuaBaiHoc()
        {
            return BaiTapCuaBaiHocDAO.selectAllBaiTapCuaBaiHoc();
        }



        public static BaiTapCuaBaiHocDTO selectBaiTapCuaBaiHocByID(int IDBaiTapCuaBaiHoc)
        {
            return BaiTapCuaBaiHocDAO.selectBaiTapCuaBaiHocByID(IDBaiTapCuaBaiHoc);
        }

        public static ArrayList selectAllBaiTapCuaBaiHocByIDBaiHoc(int ID)
        {
            return BaiTapCuaBaiHocDAO.selectAllBaiTapCuaBaiHocByIDBaiHoc(ID);
        }
    }
}
