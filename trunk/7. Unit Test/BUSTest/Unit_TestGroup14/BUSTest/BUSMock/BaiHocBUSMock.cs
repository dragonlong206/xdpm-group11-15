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
    public class BaiHocBUSMock
    {
        public static Boolean insertBaiHoc(BaiHocDTO bhDTO)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiHocDAO));
            IBaiHocDAO Obj = (IBaiHocDAO)mockController.MockInstance as IBaiHocDAO;
            mockController.ExpectAndReturn("insertAccount", true, null);
            return Obj.insertBaiHoc(bhDTO);
        }

        public static Boolean insertBaiHocAutoIncrease(BaiHocDTO bhDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiHocDAO));
            IBaiHocDAO Obj = (IBaiHocDAO)mockController.MockInstance as IBaiHocDAO;
            mockController.ExpectAndReturn("insertBaiHocAutoIncrease", true, null);
            return Obj.insertBaiHocAutoIncrease(bhDto);
        }

        public static Boolean deleteBaiHoc(string IDBaiHoc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiHocDAO));
            IBaiHocDAO Obj = (IBaiHocDAO)mockController.MockInstance as IBaiHocDAO;
            mockController.ExpectAndReturn("deleteBaiHoc", true, null);
            return Obj.deleteBaiHoc(IDBaiHoc);
        }

        public static Boolean updateBaiHoc(BaiHocDTO BaiHoc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiHocDAO));
            IBaiHocDAO Obj = (IBaiHocDAO)mockController.MockInstance as IBaiHocDAO;
            mockController.ExpectAndReturn("updateBaiHoc", true, null);
            return Obj.updateBaiHoc(BaiHoc);
        }

        public static ArrayList selectAllBaiHoc()
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiHocDAO));
            IBaiHocDAO Obj = (IBaiHocDAO)mockController.MockInstance as IBaiHocDAO;
            mockController.ExpectAndReturn("selectAllBaiHoc", true, null);
            return Obj.selectAllBaiHoc();
        }



        public static BaiHocDTO selectBaiHocByIDBaiHoc(int IDBaiHoc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiHocDAO));
            IBaiHocDAO Obj = (IBaiHocDAO)mockController.MockInstance as IBaiHocDAO;
            mockController.ExpectAndReturn("selectBaiHocByIDBaiHoc", true, null);
            return Obj.selectBaiHocByIDBaiHoc(IDBaiHoc);
        }


        public static ArrayList selectBaiHocByIDChuong(int IDChuong)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiHocDAO));
            IBaiHocDAO Obj = (IBaiHocDAO)mockController.MockInstance as IBaiHocDAO;
            mockController.ExpectAndReturn("selectBaiHocByIDChuong", true, null);
            return Obj.selectBaiHocByIDChuong(IDChuong);
        }
        public static ArrayList selectIDvaTenBaiHocByIDChuong(int IDChuong)
        {
            DynamicMock mockController = new DynamicMock(typeof(IBaiHocDAO));
            IBaiHocDAO Obj = (IBaiHocDAO)mockController.MockInstance as IBaiHocDAO;
            mockController.ExpectAndReturn("selectIDvaTenBaiHocByIDChuong", true, null);
            return Obj.selectIDvaTenBaiHocByIDChuong(IDChuong);
        }
    }
}
