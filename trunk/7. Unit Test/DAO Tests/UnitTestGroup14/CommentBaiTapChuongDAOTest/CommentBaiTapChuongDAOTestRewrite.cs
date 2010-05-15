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
    public class CommentBaiTapChuongDAOTestRewrite
    {
        public static Boolean insertCommentBaiTapChuong(Dto.CommentBaiTapChuongDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiTapChuongDAOMock));
            ICommentBaiTapChuongDAOMock ILADobj = (ICommentBaiTapChuongDAOMock)controller.MockInstance as ICommentBaiTapChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertCommentBaiTapChuong", true, null);
            return ILADobj.insertCommentBaiTapChuong(new CommentBaiTapChuongDTO());
        }
        public static Boolean deleteCommentBaiTapChuong(System.Int32 IDComment)
        {
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiTapChuongDAOMock));
            ICommentBaiTapChuongDAOMock ILADobj = (ICommentBaiTapChuongDAOMock)controller.MockInstance as ICommentBaiTapChuongDAOMock;
            controller.ExpectAndReturn("deleteCommentBaiTapChuong", true, null);
            return ILADobj.deleteCommentBaiTapChuong(IDComment);

        }
        public static Boolean updateCommentBaiTapChuong(Dto.CommentBaiTapChuongDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiTapChuongDAOMock));
            ICommentBaiTapChuongDAOMock ILADobj = (ICommentBaiTapChuongDAOMock)controller.MockInstance as ICommentBaiTapChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateCommentBaiTapChuong", true, null);
            return ILADobj.updateCommentBaiTapChuong(new CommentBaiTapChuongDTO());
        }
        public static ArrayList selectAllCommentBaiTapChuong()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiTapChuongDAOMock));
            ICommentBaiTapChuongDAOMock ILADobj = (ICommentBaiTapChuongDAOMock)controller.MockInstance as ICommentBaiTapChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectAllCommentBaiTapChuong", true, null);
            return ILADobj.selectAllCommentBaiTapChuong();
        }

        public static CommentBaiTapChuongDTO selectCommentBaiTapChuongByIDComment(System.Int32 IDComment)
        {
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiTapChuongDAOMock));
            ICommentBaiTapChuongDAOMock ILADobj = (ICommentBaiTapChuongDAOMock)controller.MockInstance as ICommentBaiTapChuongDAOMock;
            controller.ExpectAndReturn("selectCommentBaiTapChuongByIDComment", true, null);
            return ILADobj.selectCommentBaiTapChuongByIDComment(IDComment);
        }
        public static ArrayList selectCommentBaiTapChuongByIDBTChuong(System.Int32 IDComment)
        {
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiTapChuongDAOMock));
            ICommentBaiTapChuongDAOMock ILADobj = (ICommentBaiTapChuongDAOMock)controller.MockInstance as ICommentBaiTapChuongDAOMock;
            controller.ExpectAndReturn("selectCommentBaiTapChuongByIDBTChuong", true, null);
            return ILADobj.selectCommentBaiTapChuongByIDBTChuong(IDComment);
        }
       

    }
}
