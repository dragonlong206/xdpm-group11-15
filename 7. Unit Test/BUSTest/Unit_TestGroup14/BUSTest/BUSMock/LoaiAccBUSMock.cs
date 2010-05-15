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
    public class LoaiAccBUSMock
    {
        public static Boolean insertLoaiAcc(LoaiAccDTO LoaiAccDTO)
        {
            DynamicMock mockController = new DynamicMock(typeof(ILoaiAccDAO));
            ILoaiAccDAO Obj = (ILoaiAccDAO)mockController.MockInstance as ILoaiAccDAO;
            mockController.ExpectAndReturn("insertLoaiAcc", true, null);
            return Obj.insertLoaiAcc(LoaiAccDTO);
        }

        public static Boolean deleteLoaiAcc(string IDLoaiAcc)
        {
            DynamicMock mockController = new DynamicMock(typeof(ILoaiAccDAO));
            ILoaiAccDAO Obj = (ILoaiAccDAO)mockController.MockInstance as ILoaiAccDAO;
            mockController.ExpectAndReturn("deleteLoaiAcc", true, null);
            return Obj.deleteLoaiAcc(IDLoaiAcc);
        }

        public static Boolean updateLoaiAcc(LoaiAccDTO LoaiAcc)
        {
            DynamicMock mockController = new DynamicMock(typeof(ILoaiAccDAO));
            ILoaiAccDAO Obj = (ILoaiAccDAO)mockController.MockInstance as ILoaiAccDAO;
            mockController.ExpectAndReturn("updateLoaiAcc", true, null);
            return Obj.updateLoaiAcc(LoaiAcc);
        }

        public static ArrayList selectAllLoaiAcc()
        {
            DynamicMock mockController = new DynamicMock(typeof(ILoaiAccDAO));
            ILoaiAccDAO Obj = (ILoaiAccDAO)mockController.MockInstance as ILoaiAccDAO;
            mockController.ExpectAndReturn("selectAllLoaiAcc", true, null);
            return Obj.selectAllLoaiAcc();
        }



        public static LoaiAccDTO selectLoaiAccByIDLoaiAcc(int IDLoaiAcc)
        {
            DynamicMock mockController = new DynamicMock(typeof(ILoaiAccDAO));
            ILoaiAccDAO Obj = (ILoaiAccDAO)mockController.MockInstance as ILoaiAccDAO;
            mockController.ExpectAndReturn("selectLoaiAccByIDLoaiAcc", true, null);
            return Obj.selectLoaiAccByIDLoaiAcc(IDLoaiAcc);
        }

    }
}
