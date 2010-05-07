﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class CauHoiBTBaiHocBUS
    {
        public static Boolean insertCauHoiBTBaiHoc(CauHoiBTBaiHocDTO chbtBaiHocDto)
        {
            Boolean result = false;
            result = CauHoiBTBaiHocDAO.insertCauHoiBTBaiHoc(chbtBaiHocDto);
            return result;
        }

        public static Boolean deleteCauHoiBTBaiHoc(int IDBaiHoc)
        {
            Boolean result = false;
            result = CauHoiBTBaiHocDAO.deleteCauHoiBTBaiHoc(IDBaiHoc);
            return result;
        }
        public static Boolean deleteCauHoiBTBaiHocByIDBaiTap(int IDBaiTap)
        {
            Boolean result = false;
            result = CauHoiBTBaiHocDAO.deleteCauHoiBTBaiHocByIDBaiTap(IDBaiTap);
            return result;
        }
        public static Boolean updateCauHoiBTBaiHoc(CauHoiBTBaiHocDTO chbtBaiHocDto)
        {
            Boolean result = false;
            result = CauHoiBTBaiHocDAO.updateCauHoiBTBaiHoc(chbtBaiHocDto);
            return result;
        }

        public static ArrayList selectAllBaiHoc()
        {
            return CauHoiBTBaiHocDAO.selectAllCauHoiBTBaiHoc();
        }

        public static CauHoiBTBaiHocDTO selectCauHoiBTBaiHocByIDBaiTap(int IDBaiTap)
        {
            return CauHoiBTBaiHocDAO.selectCauHoiBTBaiHocByIDBaiTap(IDBaiTap);
        }

        public static CauHoiBTBaiHocDTO selectCauHoiBTBaiHocByIDCauHoi(int IDCauHoi)
        {
            return CauHoiBTBaiHocDAO.selectCauHoiBTBaiHocByIDCauHoi(IDCauHoi);
        }

    }
}
