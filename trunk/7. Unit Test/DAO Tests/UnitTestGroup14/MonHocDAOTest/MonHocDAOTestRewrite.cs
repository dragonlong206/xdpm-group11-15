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
    public class MonHocDAOTestRewrite
    {
        public static Boolean insertMonHoc(MonHocDTO obj)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IMonHocDAOMock));
            IMonHocDAOMock ILADobj = (IMonHocDAOMock)controller.MockInstance as IMonHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertMonHoc", true, null);
            return ILADobj.insertMonHoc(new MonHocDTO());
        }

        public static Boolean deleteMonHoc(String IDAcc)
        {
            DynamicMock controller = new DynamicMock(typeof(IMonHocDAOMock));
            IMonHocDAOMock ILADobj = (IMonHocDAOMock)controller.MockInstance as IMonHocDAOMock;
            controller.ExpectAndReturn("deleteAcount", true, null);
            return ILADobj.deleteMonHoc(IDAcc);
        }
        public static Boolean updateMonHoc(MonHocDTO acc)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IMonHocDAOMock));
            IMonHocDAOMock ILADobj = (IMonHocDAOMock)controller.MockInstance as IMonHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateMonHoc", true, null);
            return ILADobj.updateMonHoc(new MonHocDTO());
        }
        public static ArrayList selectAllMonHoc()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IMonHocDAOMock));
            IMonHocDAOMock ILADobj = (IMonHocDAOMock)controller.MockInstance as IMonHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateMonHoc", true, null);
            return ILADobj.selectAllMonHoc();
        }
        public static MonHocDTO selectMonHocByIDMonHoc(int IDMonHoc)
        {
             DynamicMock controller = new DynamicMock(typeof(IMonHocDAOMock));
             IMonHocDAOMock ILADobj = (IMonHocDAOMock)controller.MockInstance as IMonHocDAOMock;
             controller.ExpectAndReturn("selectMonHocByIDMonHoc", true, null);
             return ILADobj.selectMonHocByIDMonHoc(IDMonHoc);
        }
     
    }
}
