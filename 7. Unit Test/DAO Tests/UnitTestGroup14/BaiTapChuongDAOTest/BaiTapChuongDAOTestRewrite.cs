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

    public class BaiTapChuongDAOTestRewrite

    {

        public static Boolean insertBaiTapChuong(Dto.BaiTapChuongDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiTapChuongDAOMock));
            IBaiTapChuongDAOMock ILADobj = (IBaiTapChuongDAOMock)controller.MockInstance as IBaiTapChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertBaiTapChuong", true, null);
            return ILADobj.insertBaiTapChuong(bh);
        }
        public static Boolean deleteBaiTapChuong(System.String IDBaiTapChuong)
        {
            DynamicMock controller = new DynamicMock(typeof(IBaiTapChuongDAOMock));
            IBaiTapChuongDAOMock ILADobj = (IBaiTapChuongDAOMock)controller.MockInstance as IBaiTapChuongDAOMock;
            controller.ExpectAndReturn("deleteBaiTapChuong", true, null);
            return ILADobj.deleteBaiTapChuong(IDBaiTapChuong);

        }
        public static Boolean updateBaiTapChuong(Dto.BaiTapChuongDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiTapChuongDAOMock));
            IBaiTapChuongDAOMock ILADobj = (IBaiTapChuongDAOMock)controller.MockInstance as IBaiTapChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateBaiTapChuong", true, null);
            return ILADobj.updateBaiTapChuong(new BaiTapChuongDTO());
        }
        public static ArrayList selectAllBaiTapChuong()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiTapChuongDAOMock));
            IBaiTapChuongDAOMock ILADobj = (IBaiTapChuongDAOMock)controller.MockInstance as IBaiTapChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectAllBaiTapChuong", true, null);
            return ILADobj.selectAllBaiTapChuong();
        }
     
        public static BaiTapChuongDTO selectBaiTapChuongByID(System.Int32 IDBaiTapChuong)
        {
            DynamicMock controller = new DynamicMock(typeof(IBaiTapChuongDAOMock));
            IBaiTapChuongDAOMock ILADobj = (IBaiTapChuongDAOMock)controller.MockInstance as IBaiTapChuongDAOMock;
            controller.ExpectAndReturn("selectAllBaiTapChuong", true, null);
            return ILADobj.selectBaiTapChuongByID(IDBaiTapChuong);
        }

    }
}
