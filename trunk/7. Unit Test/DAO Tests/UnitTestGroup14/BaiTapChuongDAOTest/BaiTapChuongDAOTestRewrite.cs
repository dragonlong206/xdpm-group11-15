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
        public static Boolean insertBaiTapChuong(BaiTapChuongDTO btChuongDto, ref int IDBaiTapChuong)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiTapChuongDAOMock));
            IBaiTapChuongDAOMock ILADobj = (IBaiTapChuongDAOMock)controller.MockInstance as IBaiTapChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertBaiTapChuong", true, null);
            return ILADobj.insertBaiTapChuong(new BaiTapChuongDTO());
        }

        public static Boolean deleteBaiTapChuong(int IDBaiTap)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiTapChuongDAOMock));
            IBaiTapChuongDAOMock ILADobj = (IBaiTapChuongDAOMock)controller.MockInstance as IBaiTapChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertBaiTapChuong", true, null);
            return ILADobj.insertBaiTapChuong(new BaiTapChuongDTO());
        }
        public static Boolean updateBaiTapChuong(BaiTapChuongDTO btChuongDto)
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
        
        public static BaiTapChuongDTO selectBaiTapChuongByID(int IDBaiTap)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(IBaiTapChuongDAOMock));
            IBaiTapChuongDAOMock ILADobj = (IBaiTapChuongDAOMock)controller.MockInstance as IBaiTapChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectBaiTapChuongByID", true, null);
            return ILADobj.selectBaiTapChuongByID(IDBaiTap);
        }
    }
}
