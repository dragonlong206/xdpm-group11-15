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
    public class ChuongBUSMock
    {
        public static Boolean insertChuong(ChuongDTO chuongDTO)
        {
            DynamicMock mockController = new DynamicMock(typeof(IChuongDAO));
            IChuongDAO Obj = (IChuongDAO)mockController.MockInstance as IChuongDAO;
            mockController.ExpectAndReturn("insertChuong", true, null);
            return Obj.insertChuong(chuongDTO);
        }

        public static Boolean deleteChuong(string IDChuong)
        {
            DynamicMock mockController = new DynamicMock(typeof(IChuongDAO));
            IChuongDAO Obj = (IChuongDAO)mockController.MockInstance as IChuongDAO;
            mockController.ExpectAndReturn("deleteChuong", true, null);
            return Obj.deleteChuong(IDChuong);
        }

        public static Boolean updateChuong(ChuongDTO Chuong)
        {
            DynamicMock mockController = new DynamicMock(typeof(IChuongDAO));
            IChuongDAO Obj = (IChuongDAO)mockController.MockInstance as IChuongDAO;
            mockController.ExpectAndReturn("updateChuong", true, null);
            return Obj.updateChuong(Chuong);
        }

        public static ArrayList selectAllChuong()
        {
            DynamicMock mockController = new DynamicMock(typeof(IChuongDAO));
            IChuongDAO Obj = (IChuongDAO)mockController.MockInstance as IChuongDAO;
            mockController.ExpectAndReturn("selectAllChuong", true, null);
            return Obj.selectAllChuong();
        }



        public static ChuongDTO selectChuongByIDChuong(int IDChuong)
        {
            DynamicMock mockController = new DynamicMock(typeof(IChuongDAO));
            IChuongDAO Obj = (IChuongDAO)mockController.MockInstance as IChuongDAO;
            mockController.ExpectAndReturn("selectChuongByIDChuong", true, null);
            return Obj.selectChuongByIDChuong(IDChuong);
        }
        public static ArrayList selectChuongByIDMonHoc(int IDMonHoc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IChuongDAO));
            IChuongDAO Obj = (IChuongDAO)mockController.MockInstance as IChuongDAO;
            mockController.ExpectAndReturn("selectChuongByIDMonHoc", true, null);
            return Obj.selectChuongByIDMonHoc(IDMonHoc);
        }
    }
}
