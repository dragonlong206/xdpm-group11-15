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
        public static Boolean insertChuong(ChuongDTO chuongDto)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IChuongDAOMock));
            IChuongDAOMock ILADobj = (IChuongDAOMock)controller.MockInstance as IChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertChuong", true, null);
            return ILADobj.insertChuong(new ChuongDTO());
        }
        public static Boolean deleteChuong(string IDChuong)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IChuongDAOMock));
            IChuongDAOMock ILADobj = (IChuongDAOMock)controller.MockInstance as IChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("deleteChuong", true, null);
            return ILADobj.deleteChuong(IDChuong);
        }
        public static Boolean updateChuong(ChuongDTO chuongDto)
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
        public static ChuongDTO selectChuongByIDChuong(int IDChuong)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IChuongDAOMock));
            IChuongDAOMock ILADobj = (IChuongDAOMock)controller.MockInstance as IChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectChuongByIDChuong", true, null);
            return ILADobj.selectChuongByIDChuong(IDChuong);
        }


    }
}
