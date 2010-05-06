using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class BaiHocBUS
    {
        public static Boolean insertBaiHoc(BaiHocDTO bhDTO)
        {
            Boolean result = false;
            result = BaiHocDAO.insertBaiHoc(bhDTO);
            return result;
        }

        public static Boolean insertBaiHocAutoIncrease(BaiHocDTO bhDto)
        {
            Boolean result = false;
            result = BaiHocDAO.insertBaiHocAutoIncrease(bhDto);
            return result;
        }

        public static Boolean deleteBaiHoc(string IDBaiHoc)
        {
            Boolean result = false;
            result = BaiHocDAO.deleteBaiHoc(IDBaiHoc);
            return result;
        }

        public static Boolean updateBaiHoc(BaiHocDTO BaiHoc)
        {
            Boolean result = false;
            result = BaiHocDAO.updateBaiHoc(BaiHoc);
            return result;
        }

        public static ArrayList selectAllBaiHoc()
        {
            return BaiHocDAO.selectAllBaiHoc();
        }



        public static BaiHocDTO selectBaiHocByIDBaiHoc(int IDBaiHoc)
        {
            return BaiHocDAO.selectBaiHocByIDBaiHoc(IDBaiHoc);
        }


        public static ArrayList selectBaiHocByIDChuong(int IDChuong)
        {
            return BaiHocDAO.selectBaiHocByIDChuong(IDChuong);
        }
        public static ArrayList selectIDvaTenBaiHocByIDChuong(int IDChuong)
        {
            return BaiHocDAO.selectIDvaTenBaiHocByIDChuong(IDChuong);
        }
    }
}
