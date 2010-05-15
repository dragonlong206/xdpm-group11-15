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
    public class CommentBaiHocDAOTestRewrite
    {
        public static Boolean insertCommentBaiHoc(Dto.CommentBaiHocDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiHocDAOMock));
            ICommentBaiHocDAOMock ILADobj = (ICommentBaiHocDAOMock)controller.MockInstance as ICommentBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertCommentBaiHoc", true, null);
            return ILADobj.insertCommentBaiHoc(new CommentBaiHocDTO());
        }
        public static Boolean deleteCommentBaiHoc(System.Int32 IDComment)
        {
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiHocDAOMock));
            ICommentBaiHocDAOMock ILADobj = (ICommentBaiHocDAOMock)controller.MockInstance as ICommentBaiHocDAOMock;
            controller.ExpectAndReturn("deleteCommentBaiHoc", true, null);
            return ILADobj.deleteCommentBaiHoc(IDComment);

        }
        public static Boolean updateCommentBaiHoc(Dto.CommentBaiHocDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiHocDAOMock));
            ICommentBaiHocDAOMock ILADobj = (ICommentBaiHocDAOMock)controller.MockInstance as ICommentBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateCommentBaiHoc", true, null);
            return ILADobj.updateCommentBaiHoc(new CommentBaiHocDTO());
        }
        public static ArrayList selectAllCommentBaiHoc()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiHocDAOMock));
            ICommentBaiHocDAOMock ILADobj = (ICommentBaiHocDAOMock)controller.MockInstance as ICommentBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectAllCommentBaiHoc", true, null);
            return ILADobj.selectAllCommentBaiHoc();
        }

        public static CommentBaiHocDTO selectCommentBaiHocByIDComment(System.Int32 IDComment)
        {
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiHocDAOMock));
            ICommentBaiHocDAOMock ILADobj = (ICommentBaiHocDAOMock)controller.MockInstance as ICommentBaiHocDAOMock;
            controller.ExpectAndReturn("selectCommentBaiHocByIDComment", true, null);
            return ILADobj.selectCommentBaiHocByIDComment(IDComment);
        }
        public static ArrayList selectCommentBaiHocByIDBaiHoc(System.Int32 IDBaiHoc)
        {
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiHocDAOMock));
            ICommentBaiHocDAOMock ILADobj = (ICommentBaiHocDAOMock)controller.MockInstance as ICommentBaiHocDAOMock;
            controller.ExpectAndReturn("selectCommentBaiHocByIDBaiHoc", true, null);
            return ILADobj.selectCommentBaiHocByIDBaiHoc(IDBaiHoc);
        }
       
    }
}
