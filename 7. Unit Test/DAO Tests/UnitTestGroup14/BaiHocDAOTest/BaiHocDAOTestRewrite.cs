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

        public static Boolean insertBaiHoc(Dto.BaiHocDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiHocDAOMock));
            IBaiHocDAOMock ILADobj = (IBaiHocDAOMock)controller.MockInstance as IBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertBaiHoc", true, null);
            return ILADobj.insertBaiHoc(bh);
        }
        public static Boolean deleteBaiHoc(System.Int32 IDBaiHoc)
        {
            DynamicMock controller = new DynamicMock(typeof(IBaiHocDAOMock));
            IBaiHocDAOMock ILADobj = (IBaiHocDAOMock)controller.MockInstance as IBaiHocDAOMock;
            controller.ExpectAndReturn("deleteBaiHoc", true, null);
            return ILADobj.deleteBaiHoc(IDBaiHoc);
            
        }
        public static Boolean updateBaiHoc(Dto.BaiHocDTO bh)
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
            controller.ExpectAndReturn("selectAllBaiHoc", true, null);
            return ILADobj.selectAllBaiHoc();
        }
        public static ArrayList selectBaiHocByIDChuong(System.Int32 IDChuong)
        {
            DynamicMock controller = new DynamicMock(typeof(IBaiHocDAOMock));
            IBaiHocDAOMock ILADobj = (IBaiHocDAOMock)controller.MockInstance as IBaiHocDAOMock;
            controller.ExpectAndReturn("selectBaiHocByIDChuong", true, null);
            return ILADobj.selectBaiHocByIDChuong(IDChuong);
        }
        public static BaiHocDTO selectBaiHocByIDBaiHoc(System.Int32 IDBaiHoc)
        {
            DynamicMock controller = new DynamicMock(typeof(IBaiHocDAOMock));
            IBaiHocDAOMock ILADobj = (IBaiHocDAOMock)controller.MockInstance as IBaiHocDAOMock;
            controller.ExpectAndReturn("selectBaiHocByIDBaiHoc", true, null);
            return ILADobj.selectBaiHocByIDBaiHoc(IDBaiHoc);
        }

   

    }
   
 
}
