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
    public class CommentChuongDAOTestRewrite
    {
        public static Boolean insertCommentChuong(Dto.CommentChuongDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICommentChuongDAOMock));
            ICommentChuongDAOMock ILADobj = (ICommentChuongDAOMock)controller.MockInstance as ICommentChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertCommentChuong", true, null);
            return ILADobj.insertCommentChuong(new CommentChuongDTO());
        }
        public static Boolean deleteCommentChuong(System.Int32 IDComment)
        {
            DynamicMock controller = new DynamicMock(typeof(ICommentChuongDAOMock));
            ICommentChuongDAOMock ILADobj = (ICommentChuongDAOMock)controller.MockInstance as ICommentChuongDAOMock;
            controller.ExpectAndReturn("deleteCommentChuong", true, null);
            return ILADobj.deleteCommentChuong(IDComment);

        }
        public static Boolean updateCommentChuong(Dto.CommentChuongDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICommentChuongDAOMock));
            ICommentChuongDAOMock ILADobj = (ICommentChuongDAOMock)controller.MockInstance as ICommentChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateCommentChuong", true, null);
            return ILADobj.updateCommentChuong(new CommentChuongDTO());
        }
        public static ArrayList selectAllCommentChuong()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICommentChuongDAOMock));
            ICommentChuongDAOMock ILADobj = (ICommentChuongDAOMock)controller.MockInstance as ICommentChuongDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectAllCommentChuong", true, null);
            return ILADobj.selectAllCommentChuong();
        }

        public static CommentChuongDTO selectCommentChuongByIDComment(System.Int32 IDComment)
        {
            DynamicMock controller = new DynamicMock(typeof(ICommentChuongDAOMock));
            ICommentChuongDAOMock ILADobj = (ICommentChuongDAOMock)controller.MockInstance as ICommentChuongDAOMock;
            controller.ExpectAndReturn("selectCommentChuongByIDComment", true, null);
            return ILADobj.selectCommentChuongByIDComment(IDComment);
        }
        public static ArrayList selectCommentChuongByIDChuong(System.Int32 IDComment)
        {
            DynamicMock controller = new DynamicMock(typeof(ICommentChuongDAOMock));
            ICommentChuongDAOMock ILADobj = (ICommentChuongDAOMock)controller.MockInstance as ICommentChuongDAOMock;
            controller.ExpectAndReturn("selectCommentChuongByIDChuong", true, null);
            return ILADobj.selectCommentChuongByIDChuong(IDComment);
        }
       

    }
}
