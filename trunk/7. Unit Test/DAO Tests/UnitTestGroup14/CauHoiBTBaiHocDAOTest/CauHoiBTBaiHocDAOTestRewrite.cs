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
    class CauHoiBTBaiHocDAOTestRewrite
    {
        public static Boolean insertCauHoiBTBaiHoc(CauHoiBTBaiHocDTO chbtBaiHocDto)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTBaiHocDAOMock));
            ICauHoiBTBaiHocDAOMock ILADobj = (ICauHoiBTBaiHocDAOMock)controller.MockInstance as ICauHoiBTBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertCauHoiBTBaiHoc", true, null);
            return ILADobj.insertCauHoiBTBaiHoc(new CauHoiBTBaiHocDTO());
        }
        public static Boolean deleteCauHoiBTBaiHoc(String IDCauHoi)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTBaiHocDAOMock));
            ICauHoiBTBaiHocDAOMock ILADobj = (ICauHoiBTBaiHocDAOMock)controller.MockInstance as ICauHoiBTBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("deleteCauHoiBTBaiHoc", true, null);
            return ILADobj.deleteCauHoiBTBaiHoc(IDCauHoi);
        }
      
        public static Boolean updateCauHoiBTBaiHoc(CauHoiBTBaiHocDTO chbtBaiHocDto)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTBaiHocDAOMock));
            ICauHoiBTBaiHocDAOMock ILADobj = (ICauHoiBTBaiHocDAOMock)controller.MockInstance as ICauHoiBTBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateCauHoiBTBaiHoc", true, null);
            return ILADobj.updateCauHoiBTBaiHoc(new CauHoiBTBaiHocDTO());
        }
        public static ArrayList selectAllCauHoiBTBaiHoc()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTBaiHocDAOMock));
            ICauHoiBTBaiHocDAOMock ILADobj = (ICauHoiBTBaiHocDAOMock)controller.MockInstance as ICauHoiBTBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectAllCauHoiBTBaiHoc", true, null);
            return ILADobj.selectAllCauHoiBTBaiHoc();
        }
        public static CauHoiBTBaiHocDTO selectCauHoiBTBaiHocByIDCauHoi(int IDCauHoi)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTBaiHocDAOMock));
            ICauHoiBTBaiHocDAOMock ILADobj = (ICauHoiBTBaiHocDAOMock)controller.MockInstance as ICauHoiBTBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectCauHoiBTBaiHocByIDCauHoi", true, null);
            return ILADobj.selectCauHoiBTBaiHocByIDCauHoi(IDCauHoi);
        }
 
    }
}
