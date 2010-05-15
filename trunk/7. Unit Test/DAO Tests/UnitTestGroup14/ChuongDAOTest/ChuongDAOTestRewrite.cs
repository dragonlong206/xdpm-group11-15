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
    public class ChuongDAOTestRewrite
    {

        public static Boolean insertChuong(Dto.ChuongDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IChuongDAOMock));
            IChuongDAOMock ILADobj = (IChuongDAOMock)controller.MockInstance as IChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertChuong", true, null);
            return ILADobj.insertChuong(bh);
        }
        public static Boolean deleteChuong(System.String IDChuong)
        {
            DynamicMock controller = new DynamicMock(typeof(IChuongDAOMock));
            IChuongDAOMock ILADobj = (IChuongDAOMock)controller.MockInstance as IChuongDAOMock;
            controller.ExpectAndReturn("deleteChuong", true, null);
            return ILADobj.deleteChuong(IDChuong);

        }
        public static Boolean updateChuong(Dto.ChuongDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IChuongDAOMock));
            IChuongDAOMock ILADobj = (IChuongDAOMock)controller.MockInstance as IChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateChuong", true, null);
            return ILADobj.updateChuong(new ChuongDTO());
        }
        public static ArrayList selectAllChuong()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IChuongDAOMock));
            IChuongDAOMock ILADobj = (IChuongDAOMock)controller.MockInstance as IChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectAllChuong", true, null);
            return ILADobj.selectAllChuong();
        }

        public static ChuongDTO selectChuongByIDChuong(System.Int32 IDChuong)
        {
            DynamicMock controller = new DynamicMock(typeof(IChuongDAOMock));
            IChuongDAOMock ILADobj = (IChuongDAOMock)controller.MockInstance as IChuongDAOMock;
            controller.ExpectAndReturn("selectChuongByIDChuong", true, null);
            return ILADobj.selectChuongByIDChuong(IDChuong);
        }
       

    }
}
