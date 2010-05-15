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
    public class CauHoiBTChuongDAOTestRewrite
    {
        public static Boolean insertCauHoiBTChuong(CauHoiBTChuongDTO chbtChuongDto)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTChuongDAOMock));
            ICauHoiBTChuongDAOMock ILADobj = (ICauHoiBTChuongDAOMock)controller.MockInstance as ICauHoiBTChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertCauHoiBTChuong", true, null);
            return ILADobj.insertCauHoiBTChuong(new CauHoiBTChuongDTO());
        }
        public static Boolean deleteCauHoiBTChuong(String IDCauHoi)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTChuongDAOMock));
            ICauHoiBTChuongDAOMock ILADobj = (ICauHoiBTChuongDAOMock)controller.MockInstance as ICauHoiBTChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("deleteCauHoiBTChuong", true, null);
            return ILADobj.deleteCauHoiBTChuong(IDCauHoi);
        }
      
        public static Boolean updateCauHoiBTChuong(CauHoiBTChuongDTO chbtChuongDto)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTChuongDAOMock));
            ICauHoiBTChuongDAOMock ILADobj = (ICauHoiBTChuongDAOMock)controller.MockInstance as ICauHoiBTChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateCauHoiBTChuong", true, null);
            return ILADobj.updateCauHoiBTChuong(new CauHoiBTChuongDTO());
        }
        public static ArrayList selectAllCauHoiBTChuong()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTChuongDAOMock));
            ICauHoiBTChuongDAOMock ILADobj = (ICauHoiBTChuongDAOMock)controller.MockInstance as ICauHoiBTChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectAllCauHoiBTChuong", true, null);
            return ILADobj.selectAllCauHoiBTChuong();
        }
        public static CauHoiBTChuongDTO selectCauHoiBTChuongByIDCauHoi(int IDCauHoi)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTChuongDAOMock));
            ICauHoiBTChuongDAOMock ILADobj = (ICauHoiBTChuongDAOMock)controller.MockInstance as ICauHoiBTChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectCauHoiBTChuongByIDCauHoi", true, null);
            return ILADobj.selectCauHoiBTChuongByIDCauHoi(IDCauHoi);
        }
        public static ArrayList selectCauHoiBTChuongByIDChuong(int IDChuong)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTChuongDAOMock));
            ICauHoiBTChuongDAOMock ILADobj = (ICauHoiBTChuongDAOMock)controller.MockInstance as ICauHoiBTChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectCauHoiBTChuongByIDChuong", true, null);
            return ILADobj.selectCauHoiBTChuongByIDChuong(IDChuong);
        }

    }
}
