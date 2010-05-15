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
    public class MonHocBUSMock
    {
        public static Boolean insertMonHoc(MonHocDTO MonHocDTO)
        {
            DynamicMock mockController = new DynamicMock(typeof(IMonHocDAO));
            IMonHocDAO Obj = (IMonHocDAO)mockController.MockInstance as IMonHocDAO;
            mockController.ExpectAndReturn("insertMonHoc", true, null);
            return Obj.insertMonHoc(MonHocDTO);
        }

        public static Boolean deleteMonHoc(string IDMonHoc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IMonHocDAO));
            IMonHocDAO Obj = (IMonHocDAO)mockController.MockInstance as IMonHocDAO;
            mockController.ExpectAndReturn("deleteMonHoc", true, null);
            return Obj.deleteMonHoc(IDMonHoc);
        }

        public static Boolean updateMonHoc(MonHocDTO MonHoc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IMonHocDAO));
            IMonHocDAO Obj = (IMonHocDAO)mockController.MockInstance as IMonHocDAO;
            mockController.ExpectAndReturn("updateMonHoc", true, null);
            return Obj.updateMonHoc(MonHoc);
        }

        public static ArrayList selectAllMonHoc()
        {
            DynamicMock mockController = new DynamicMock(typeof(IMonHocDAO));
            IMonHocDAO Obj = (IMonHocDAO)mockController.MockInstance as IMonHocDAO;
            mockController.ExpectAndReturn("selectAllMonHoc", true, null);
            return Obj.selectAllMonHoc();
        }



        public static MonHocDTO selectMonHocByIDMonHoc(int IDMonHoc)
        {
            DynamicMock mockController = new DynamicMock(typeof(IMonHocDAO));
            IMonHocDAO Obj = (IMonHocDAO)mockController.MockInstance as IMonHocDAO;
            mockController.ExpectAndReturn("selectMonHocByIDMonHoc", true, null);
            return Obj.selectMonHocByIDMonHoc(IDMonHoc);
        }

    }
}
