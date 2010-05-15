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
    public class CauHoiBTChuongBUSMock
    {
        public static Boolean insertCauHoiBTChuong(CauHoiBTChuongDTO chbtChuongDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTChuongDAO));
            ICauHoiBTChuongDAO Obj = (ICauHoiBTChuongDAO)mockController.MockInstance as ICauHoiBTChuongDAO;
            mockController.ExpectAndReturn("insertCauHoiBTChuong", true, null);
            return Obj.insertCauHoiBTChuong(chbtChuongDto);
        }

        public static Boolean deleteCauHoiBTChuong(int IDChuong)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTChuongDAO));
            ICauHoiBTChuongDAO Obj = (ICauHoiBTChuongDAO)mockController.MockInstance as ICauHoiBTChuongDAO;
            mockController.ExpectAndReturn("insertCauHoiBTChuong", true, null);
            return Obj.deleteCauHoiBTChuong(IDChuong);
        }

        public static Boolean deleteCauHoiBTChuongByIDBaiTap(int IDBaiTap)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTChuongDAO));
            ICauHoiBTChuongDAO Obj = (ICauHoiBTChuongDAO)mockController.MockInstance as ICauHoiBTChuongDAO;
            mockController.ExpectAndReturn("deleteCauHoiBTChuongByIDBaiTap", true, null);
            return Obj.deleteCauHoiBTChuongByIDBaiTap(IDBaiTap);
        }

        public static Boolean updateCauHoiBTChuong(CauHoiBTChuongDTO chbtChuongDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTChuongDAO));
            ICauHoiBTChuongDAO Obj = (ICauHoiBTChuongDAO)mockController.MockInstance as ICauHoiBTChuongDAO;
            mockController.ExpectAndReturn("updateCauHoiBTChuong", true, null);
            return Obj.updateCauHoiBTChuong(chbtChuongDto);
        }

        public static ArrayList selectCauHoiBTChuongByIDChuong(int IDChuong)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTChuongDAO));
            ICauHoiBTChuongDAO Obj = (ICauHoiBTChuongDAO)mockController.MockInstance as ICauHoiBTChuongDAO;
            mockController.ExpectAndReturn("selectCauHoiBTChuongByIDChuong", true, null);
            return Obj.selectCauHoiBTChuongByIDChuong(IDChuong);
        }

        public static CauHoiBTChuongDTO selectCauHoiBTChuongByIDBaiTap(int IDBaiTap)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTChuongDAO));
            ICauHoiBTChuongDAO Obj = (ICauHoiBTChuongDAO)mockController.MockInstance as ICauHoiBTChuongDAO;
            mockController.ExpectAndReturn("selectCauHoiBTChuongByIDBaiTap", true, null);
            return Obj.selectCauHoiBTChuongByIDBaiTap(IDBaiTap);
        }
        public static CauHoiBTChuongDTO selectCauHoiBTChuongByIDCauHoi(int IDCauHoi)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICauHoiBTChuongDAO));
            ICauHoiBTChuongDAO Obj = (ICauHoiBTChuongDAO)mockController.MockInstance as ICauHoiBTChuongDAO;
            mockController.ExpectAndReturn("selectCauHoiBTChuongByIDCauHoi", true, null);
            return Obj.selectCauHoiBTChuongByIDCauHoi(IDCauHoi);
        }

    }
}
