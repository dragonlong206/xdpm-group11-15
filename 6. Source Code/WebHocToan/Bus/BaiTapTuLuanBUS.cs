
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class BaiTapTuLuanBUS
    {
        public static Boolean insertBaiTapTuLuan(BaiTapTuLuanDTO btcbhDto)
        {
            Boolean result = false;
            result = BaiTapTuLuanDAO.insertBaiTapTuLuan(btcbhDto);
            return result;
        }

        public static Boolean deleteBaiTapTuLuan(int IDBaiTap)
        {
            Boolean result = false;
            result = BaiTapTuLuanDAO.deleteBaiTapTuLuan(IDBaiTap);
            return result;
        }

        public static Boolean updateBaiTapTuLuan(BaiTapTuLuanDTO btcbhDto)
        {
            Boolean result = false;
            result = BaiTapTuLuanDAO.updateBaiTapTuLuan(btcbhDto);
            return result;
        }

        public static ArrayList selectAllBaiTapTuLuan()
        {
            return BaiTapTuLuanDAO.selectAllBaiTapTuLuan();
        }

        public static BaiTapTuLuanDTO selectBaiTapTuLuanByID(int IDBaiTap)
        {
            return BaiTapTuLuanDAO.selectBaiTapTuLuanByID(IDBaiTap);
        }


        public static ArrayList selectBaiTapTuLuanByIDBaiHoc(int IDBaiHoc)
        {
            return BaiTapTuLuanDAO.selectBaiTapTuLuanByIDBaiHoc(IDBaiHoc);
        }
        public static ArrayList selectBaiTapByIDBaiHoc(int IDBaiHoc)
        {
            return BaiTapTuLuanDAO.selectBaiTapTuLuanByIDBaiHoc(IDBaiHoc);
        }
    }
}
