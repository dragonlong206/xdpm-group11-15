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
    public class BaiTapCuaBaiHocBUSMock
    {
        public static Boolean insertBaiTapCuaBaiHoc(BaiTapCuaBaiHocDTO btcbhDto,ref int IDBaiTapBaiHoc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapCuaBaiHocDAO));
            IBaiTapCuaBaiHocDAO Obj = (IBaiTapCuaBaiHocDAO)mockController.MockInstance as IBaiTapCuaBaiHocDAO;
            mockController.ExpectAndReturn("insertBaiTapCuaBaiHoc", true, null);
            return Obj.insertBaiTapCuaBaiHoc(btcbhDto, IDBaiTapBaiHoc);
        }

        public static Boolean deleteBaiTapCuaBaiHoc(int IDBaiTapCuaBaiHoc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapCuaBaiHocDAO));
            IBaiTapCuaBaiHocDAO Obj = (IBaiTapCuaBaiHocDAO)mockController.MockInstance as IBaiTapCuaBaiHocDAO;
            mockController.ExpectAndReturn("deleteBaiTapCuaBaiHoc", true, null);
            return Obj.deleteBaiTapCuaBaiHoc(IDBaiTapCuaBaiHoc);
        }

        public static Boolean updateBaiTapCuaBaiHoc(BaiTapCuaBaiHocDTO btcbhDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapCuaBaiHocDAO));
            IBaiTapCuaBaiHocDAO Obj = (IBaiTapCuaBaiHocDAO)mockController.MockInstance as IBaiTapCuaBaiHocDAO;
            mockController.ExpectAndReturn("updateBaiTapCuaBaiHoc", true, null);
            return Obj.updateBaiTapCuaBaiHoc(btcbhDto);
        }

        public static ArrayList selectAllBaiTapCuaBaiHoc()
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapCuaBaiHocDAO));
            IBaiTapCuaBaiHocDAO Obj = (IBaiTapCuaBaiHocDAO)mockController.MockInstance as IBaiTapCuaBaiHocDAO;
            mockController.ExpectAndReturn("selectAllBaiTapCuaBaiHoc", true, null);
            return Obj.selectAllBaiTapCuaBaiHoc();
        }



        public static BaiTapCuaBaiHocDTO selectBaiTapCuaBaiHocByID(int IDBaiTapCuaBaiHoc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapCuaBaiHocDAO));
            IBaiTapCuaBaiHocDAO Obj = (IBaiTapCuaBaiHocDAO)mockController.MockInstance as IBaiTapCuaBaiHocDAO;
            mockController.ExpectAndReturn("selectBaiTapCuaBaiHocByID", true, null);
            return Obj.selectBaiTapCuaBaiHocByID(IDBaiTapCuaBaiHoc);
        }

        public static ArrayList selectAllBaiTapCuaBaiHocByIDBaiHoc(int ID)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapCuaBaiHocDAO));
            IBaiTapCuaBaiHocDAO Obj = (IBaiTapCuaBaiHocDAO)mockController.MockInstance as IBaiTapCuaBaiHocDAO;
            mockController.ExpectAndReturn("selectAllBaiTapCuaBaiHocByIDBaiHoc", true, null);
            return Obj.selectAllBaiTapCuaBaiHocByIDBaiHoc(ID);
        }
        public static ArrayList selectBaiTapCuaBaiHocByIDBaiHoc(int IDBaiTap)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapCuaBaiHocDAO));
            IBaiTapCuaBaiHocDAO Obj = (IBaiTapCuaBaiHocDAO)mockController.MockInstance as IBaiTapCuaBaiHocDAO;
            mockController.ExpectAndReturn("selectBaiTapCuaBaiHocByIDBaiHoc", true, null);
            return Obj.selectBaiTapCuaBaiHocByIDBaiHoc(IDBaiTap);
        }
        public static ArrayList selectBaiTapCuaBaiHocByIDBaiHoc2(int IDBaiTap)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiTapCuaBaiHocDAO));
            IBaiTapCuaBaiHocDAO Obj = (IBaiTapCuaBaiHocDAO)mockController.MockInstance as IBaiTapCuaBaiHocDAO;
            mockController.ExpectAndReturn("selectBaiTapCuaBaiHocByIDBaiHoc2", true, null);
            return Obj.selectBaiTapCuaBaiHocByIDBaiHoc2(IDBaiTap);
        }
    }
}
