using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dto;
using NUnit.Framework;
using NUnit.Mocks;
using System.Collections;

namespace UnitTestGroup14
{
    public class LoaiAccDAOTestRewrite
    {
        public static Boolean insertLoaiAcc(LoaiAccDTO obj)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ILoaiAccDAOMock));
            ILoaiAccDAOMock ILADobj = (ILoaiAccDAOMock)controller.MockInstance as ILoaiAccDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertLoaiAcc", true, null);
            return ILADobj.insertLoaiAcc(new LoaiAccDTO());
        }

        public static Boolean deleteLoaiAcc(String IDAcc)
        {
            DynamicMock controller = new DynamicMock(typeof(ILoaiAccDAOMock));
            ILoaiAccDAOMock ILADobj = (ILoaiAccDAOMock)controller.MockInstance as ILoaiAccDAOMock;
            controller.ExpectAndReturn("deleteAcount", true, null);
            return ILADobj.deleteLoaiAcc(IDAcc);
        }
        public static Boolean updateLoaiAcc(LoaiAccDTO acc)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ILoaiAccDAOMock));
            ILoaiAccDAOMock ILADobj = (ILoaiAccDAOMock)controller.MockInstance as ILoaiAccDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateLoaiAcc", true, null);
            return ILADobj.updateLoaiAcc(new LoaiAccDTO());
        }
        public static ArrayList selectAllLoaiAcc()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ILoaiAccDAOMock));
            ILoaiAccDAOMock ILADobj = (ILoaiAccDAOMock)controller.MockInstance as ILoaiAccDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateLoaiAcc", true, null);
            return ILADobj.selectAllLoaiAcc();
        }
        public static LoaiAccDTO selectLoaiAccByIDLoaiAcc(int IDLoaiAcc)
        {
             DynamicMock controller = new DynamicMock(typeof(ILoaiAccDAOMock));
             ILoaiAccDAOMock ILADobj = (ILoaiAccDAOMock)controller.MockInstance as ILoaiAccDAOMock;
             controller.ExpectAndReturn("selectLoaiAccByIDLoaiAcc", true, null);
             return ILADobj.selectLoaiAccByIDLoaiAcc(IDLoaiAcc);
        }
     
    }
}
