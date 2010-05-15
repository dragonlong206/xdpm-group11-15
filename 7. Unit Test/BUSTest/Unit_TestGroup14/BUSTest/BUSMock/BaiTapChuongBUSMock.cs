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
    public class BaiTapChuongBUSMock
    {
        public static Boolean insertBaiTapChuong(BaiTapChuongDTO btChuognDto, ref int IDBaiTapChuong)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapChuongDAO));
            IBaiTapChuongDAO Obj = (IBaiTapChuongDAO)mockController.MockInstance as IBaiTapChuongDAO;
            mockController.ExpectAndReturn("insertBaiTapChuong", true, null);
            return Obj.insertBaiTapChuong(btChuognDto, IDBaiTapChuong);
        }

        public static Boolean deleteBaiTapChuong(int IDBaiTapChuong)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapChuongDAO));
            IBaiTapChuongDAO Obj = (IBaiTapChuongDAO)mockController.MockInstance as IBaiTapChuongDAO;
            mockController.ExpectAndReturn("deleteBaiTapChuong", true, null);
            return Obj.deleteBaiTapChuong(IDBaiTapChuong);
        }

        public static Boolean updateBaiTapChuong(BaiTapChuongDTO btChuognDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapChuongDAO));
            IBaiTapChuongDAO Obj = (IBaiTapChuongDAO)mockController.MockInstance as IBaiTapChuongDAO;
            mockController.ExpectAndReturn("updateBaiTapChuong", true, null);
            return Obj.updateBaiTapChuong(btChuognDto);
        }

        public static ArrayList selectAllBaiTapChuong()
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapChuongDAO));
            IBaiTapChuongDAO Obj = (IBaiTapChuongDAO)mockController.MockInstance as IBaiTapChuongDAO;
            mockController.ExpectAndReturn("selectAllBaiTapChuong", true, null);
            return Obj.selectAllBaiTapChuong();
        }



        public static BaiTapChuongDTO selectBaiTapChuongByID(int IDBaiTapChuong)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapChuongDAO));
            IBaiTapChuongDAO Obj = (IBaiTapChuongDAO)mockController.MockInstance as IBaiTapChuongDAO;
            mockController.ExpectAndReturn("selectBaiTapChuongByID", true, null);
            return Obj.selectBaiTapChuongByID(IDBaiTapChuong);
        }
        public static ArrayList selectBaiTapChuongByIDChuong(int ID)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapChuongDAO));
            IBaiTapChuongDAO Obj = (IBaiTapChuongDAO)mockController.MockInstance as IBaiTapChuongDAO;
            mockController.ExpectAndReturn("selectBaiTapChuongByIDChuong", true, null);
            return Obj.selectBaiTapChuongByIDChuong(ID);
        }

    }
}
