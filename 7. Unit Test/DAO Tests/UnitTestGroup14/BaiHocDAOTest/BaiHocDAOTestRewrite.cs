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
    public class BaiHocDAOTestRewrite
    {
        public static Boolean insertBaiHoc(BaiHocDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiHocDAOMock));
            IBaiHocDAOMock ILADobj = (IBaiHocDAOMock)controller.MockInstance as IBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertBaiHoc", true, null);
            return ILADobj.insertBaiHoc(new BaiHocDTO());
        }
        public static Boolean deleteBaiHoc(int IDBaiHoc)
        {
            DynamicMock controller = new DynamicMock(typeof(IBaiHocDAOMock));
            IBaiHocDAOMock ILADobj = (IBaiHocDAOMock)controller.MockInstance as IBaiHocDAOMock;
            controller.ExpectAndReturn("deleteBaiHoc", true, null);
            return ILADobj.deleteBaiHoc(IDBaiHoc);
        }
        public static Boolean updateBaiHoc(BaiHocDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiHocDAOMock));
            IBaiHocDAOMock ILADobj = (IBaiHocDAOMock)controller.MockInstance as IBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateBaiHoc", true, null);
            return ILADobj.updateBaiHoc(new BaiHocDTO());
        }
        public static ArrayList selectAllBaiHoc()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiHocDAOMock));
            IBaiHocDAOMock ILADobj = (IBaiHocDAOMock)controller.MockInstance as IBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateBaiTapCuaBaiHoc", true, null);
            return ILADobj.selectAllBaiHoc();
        }

        public static BaiHocDTO selectBaiHocByIDBaiHoc (int IDBaiHoc)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiHocDAOMock));
            IBaiHocDAOMock ILADobj = (IBaiHocDAOMock)controller.MockInstance as IBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectBaiHocBayIDBaiHoc", true, null);
            return ILADobj.selectBaiHocByIDBaiHoc(IDBaiHoc);
        }
        public static ArrayList selectBaiHocByIDChuong(int IDChuong)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiHocDAOMock));
            IBaiHocDAOMock ILADobj = (IBaiHocDAOMock)controller.MockInstance as IBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectBbselectBaiHocByIDChuong", true, null);
            return ILADobj.selectBaiHocByIDChuong(IDChuong);
        }
  
    }
}
