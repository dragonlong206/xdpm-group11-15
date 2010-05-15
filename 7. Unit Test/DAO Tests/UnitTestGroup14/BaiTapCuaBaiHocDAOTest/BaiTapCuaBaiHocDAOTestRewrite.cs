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
    public class BaiTapCuaBaiHocDAOTestRewrite
    {
        public static Boolean insertBaiTapCuaBaiHoc(BaiTapCuaBaiHocDTO btcbhDto,ref int IDBaiTapBaiHoc)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiTapCuaBaiHocDAOMock));
            IBaiTapCuaBaiHocDAOMock ILADobj = (IBaiTapCuaBaiHocDAOMock)controller.MockInstance as IBaiTapCuaBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertBaiTapCuaBaiHoc", true, null);
            return ILADobj.insertBaiTapCuaBaiHoc(new BaiTapCuaBaiHocDTO());
        }
        public static Boolean deleteBaiTapCuaBaiHoc(String IDBaiTap)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiTapCuaBaiHocDAOMock));
            IBaiTapCuaBaiHocDAOMock ILADobj = (IBaiTapCuaBaiHocDAOMock)controller.MockInstance as IBaiTapCuaBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("deleteBaiTapCuaBaiHoc", true, null);
            return ILADobj.deleteBaiTapCuaBaiHoc(IDBaiTap);
        }
        public static Boolean updateBaiTapCuaBaiHoc(BaiTapCuaBaiHocDTO btcbhDto)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiTapCuaBaiHocDAOMock));
            IBaiTapCuaBaiHocDAOMock ILADobj = (IBaiTapCuaBaiHocDAOMock)controller.MockInstance as IBaiTapCuaBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateBaiTapCuaBaiHoc", true, null);
            return ILADobj.updateBaiTapCuaBaiHoc(new BaiTapCuaBaiHocDTO());
        }
        public static ArrayList selectAllBaiTapCuaBaiHoc()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiTapCuaBaiHocDAOMock));
            IBaiTapCuaBaiHocDAOMock ILADobj = (IBaiTapCuaBaiHocDAOMock)controller.MockInstance as IBaiTapCuaBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectAllBaiTapCuaBaiHoc", true, null);
            return ILADobj.selectAllBaiTapCuaBaiHoc();
        }
        public static BaiTapCuaBaiHocDTO selectBaiTapCuaBaiHocByID(int IDBaiTap)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiTapCuaBaiHocDAOMock));
            IBaiTapCuaBaiHocDAOMock ILADobj = (IBaiTapCuaBaiHocDAOMock)controller.MockInstance as IBaiTapCuaBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectBaiTapCuaBaiHocByID", true, null);
            return ILADobj.selectBaiTapCuaBaiHocByID(IDBaiTap);
        }

    }
}
