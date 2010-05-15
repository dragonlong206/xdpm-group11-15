using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{
    public class CauHoiBTBaiHocBUSMock
    {
        public static Boolean insertCauHoiBTBaiHoc(CauHoiBTBaiHocDTO chbtBaiHocDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTBaiHocDAO));
            ICauHoiBTBaiHocDAO Obj = (ICauHoiBTBaiHocDAO)mockController.MockInstance as ICauHoiBTBaiHocDAO;
            mockController.ExpectAndReturn("insertCauHoiBTBaiHoc", true, null);
            return Obj.insertCauHoiBTBaiHoc(chbtBaiHocDto);
        }

        public static Boolean deleteCauHoiBTBaiHoc(int IDBaiHoc)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTBaiHocDAO));
            ICauHoiBTBaiHocDAO Obj = (ICauHoiBTBaiHocDAO)mockController.MockInstance as ICauHoiBTBaiHocDAO;
            mockController.ExpectAndReturn("deleteCauHoiBTBaiHoc", true, null);
            return Obj.deleteCauHoiBTBaiHoc(IDBaiHoc);
        }
        public static Boolean deleteCauHoiBTBaiHocByIDBaiTap(int IDBaiTap)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTBaiHocDAO));
            ICauHoiBTBaiHocDAO Obj = (ICauHoiBTBaiHocDAO)mockController.MockInstance as ICauHoiBTBaiHocDAO;
            mockController.ExpectAndReturn("deleteCauHoiBTBaiHocByIDBaiTap", true, null);
            return Obj.deleteCauHoiBTBaiHocByIDBaiTap(IDBaiTap);
        }
        public static Boolean updateCauHoiBTBaiHoc(CauHoiBTBaiHocDTO chbtBaiHocDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTBaiHocDAO));
            ICauHoiBTBaiHocDAO Obj = (ICauHoiBTBaiHocDAO)mockController.MockInstance as ICauHoiBTBaiHocDAO;
            mockController.ExpectAndReturn("updateCauHoiBTBaiHoc", true, null);
            return Obj.updateCauHoiBTBaiHoc(chbtBaiHocDto);
        }

      

        public static CauHoiBTBaiHocDTO selectCauHoiBTBaiHocByIDBaiTap(int IDBaiTap)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTBaiHocDAO));
            ICauHoiBTBaiHocDAO Obj = (ICauHoiBTBaiHocDAO)mockController.MockInstance as ICauHoiBTBaiHocDAO;
            mockController.ExpectAndReturn("selectCauHoiBTBaiHocByIDBaiTap", true, null);
            return Obj.selectCauHoiBTBaiHocByIDBaiTap(IDBaiTap);
        }

        public static CauHoiBTBaiHocDTO selectCauHoiBTBaiHocByIDCauHoi(int IDCauHoi)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTBaiHocDAO));
            ICauHoiBTBaiHocDAO Obj = (ICauHoiBTBaiHocDAO)mockController.MockInstance as ICauHoiBTBaiHocDAO;
            mockController.ExpectAndReturn("selectCauHoiBTBaiHocByIDCauHoi", true, null);
            return Obj.selectCauHoiBTBaiHocByIDCauHoi(IDCauHoi);
        }

    }
}
