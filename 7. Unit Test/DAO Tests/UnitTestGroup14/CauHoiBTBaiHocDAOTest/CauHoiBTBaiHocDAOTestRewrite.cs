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
    public class CauHoiBTBaiHocDAOTestRewrite
    {

        public static Boolean insertCauHoiBTBaiHoc(Dto.CauHoiBTBaiHocDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTBaiHocDAOMock));
            ICauHoiBTBaiHocDAOMock ILADobj = (ICauHoiBTBaiHocDAOMock)controller.MockInstance as ICauHoiBTBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertCauHoiBTBaiHoc", true, null);
            return ILADobj.insertCauHoiBTBaiHoc(bh);
        }
        public static Boolean deleteCauHoiBTBaiHoc(System.String IDCauHoiBTBaiHoc)
        {
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTBaiHocDAOMock));
            ICauHoiBTBaiHocDAOMock ILADobj = (ICauHoiBTBaiHocDAOMock)controller.MockInstance as ICauHoiBTBaiHocDAOMock;
            controller.ExpectAndReturn("deleteCauHoiBTBaiHoc", true, null);
            return ILADobj.deleteCauHoiBTBaiHoc(IDCauHoiBTBaiHoc);

        }
        public static Boolean updateCauHoiBTBaiHoc(Dto.CauHoiBTBaiHocDTO bh)
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

        public static CauHoiBTBaiHocDTO selectCauHoiBTBaiHocByIDCauHoi(System.Int32 IDCauHoiBTBaiHoc)
        {
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTBaiHocDAOMock));
            ICauHoiBTBaiHocDAOMock ILADobj = (ICauHoiBTBaiHocDAOMock)controller.MockInstance as ICauHoiBTBaiHocDAOMock;
            controller.ExpectAndReturn("selectCauHoiBTBaiHocByIDCauHoi", true, null);
            return ILADobj.selectCauHoiBTBaiHocByIDCauHoi(IDCauHoiBTBaiHoc);
        }
        public static ArrayList selectCauHoiBTBaiHocByIDBaiHoc(System.Int32 IDCauHoiBTBaiHoc)
        {
            DynamicMock controller = new DynamicMock(typeof(ICauHoiBTBaiHocDAOMock));
            ICauHoiBTBaiHocDAOMock ILADobj = (ICauHoiBTBaiHocDAOMock)controller.MockInstance as ICauHoiBTBaiHocDAOMock;
            controller.ExpectAndReturn("selectCauHoiBTBaiHocByIDBaiHoc", true, null);
            return ILADobj.selectCauHoiBTBaiHocByIDBaiHoc(IDCauHoiBTBaiHoc);
        }
    }
}
