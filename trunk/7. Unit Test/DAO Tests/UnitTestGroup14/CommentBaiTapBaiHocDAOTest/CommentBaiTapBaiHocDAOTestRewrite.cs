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
    public class CommentBaiTapBaiHocDAOTestRewrite
    {
        public static Boolean insertCommentBaiTapBaiHoc(Dto.CommentBaiTapBaiHocDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiTapBaiHocDAOMock));
            ICommentBaiTapBaiHocDAOMock ILADobj = (ICommentBaiTapBaiHocDAOMock)controller.MockInstance as ICommentBaiTapBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("insertCommentBaiTapBaiHoc", true, null);
            return ILADobj.insertCommentBaiTapBaiHoc(new CommentBaiTapBaiHocDTO());
        }
        public static Boolean deleteCommentBaiTapBaiHoc(System.Int32 IDComment)
        {
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiTapBaiHocDAOMock));
            ICommentBaiTapBaiHocDAOMock ILADobj = (ICommentBaiTapBaiHocDAOMock)controller.MockInstance as ICommentBaiTapBaiHocDAOMock;
            controller.ExpectAndReturn("deleteCommentBaiTapBaiHoc", true, null);
            return ILADobj.deleteCommentBaiTapBaiHoc(IDComment);

        }
        public static Boolean updateCommentBaiTapBaiHoc(Dto.CommentBaiTapBaiHocDTO bh)
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiTapBaiHocDAOMock));
            ICommentBaiTapBaiHocDAOMock ILADobj = (ICommentBaiTapBaiHocDAOMock)controller.MockInstance as ICommentBaiTapBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("updateCommentBaiTapBaiHoc", true, null);
            return ILADobj.updateCommentBaiTapBaiHoc(new CommentBaiTapBaiHocDTO());
        }
        public static ArrayList selectAllCommentBaiTapBaiHoc()
        {
            //Create mock object of DAO
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiTapBaiHocDAOMock));
            ICommentBaiTapBaiHocDAOMock ILADobj = (ICommentBaiTapBaiHocDAOMock)controller.MockInstance as ICommentBaiTapBaiHocDAOMock;
            //Set return value is true
            controller.ExpectAndReturn("selectAllCommentBaiTapBaiHoc", true, null);
            return ILADobj.selectAllCommentBaiTapBaiHoc();
        }

        public static CommentBaiTapBaiHocDTO selectCommentBaiTapBaiHocByIDComment(System.Int32 IDComment)
        {
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiTapBaiHocDAOMock));
            ICommentBaiTapBaiHocDAOMock ILADobj = (ICommentBaiTapBaiHocDAOMock)controller.MockInstance as ICommentBaiTapBaiHocDAOMock;
            controller.ExpectAndReturn("selectCommentBaiTapBaiHocByIDComment", true, null);
            return ILADobj.selectCommentBaiTapBaiHocByIDComment(IDComment);
        }
        public static ArrayList selectCommentBaiTapBaiHocByIDBTBaiHoc(System.Int32 IDComment)
        {
            DynamicMock controller = new DynamicMock(typeof(ICommentBaiTapBaiHocDAOMock));
            ICommentBaiTapBaiHocDAOMock ILADobj = (ICommentBaiTapBaiHocDAOMock)controller.MockInstance as ICommentBaiTapBaiHocDAOMock;
            controller.ExpectAndReturn("selectCommentBaiTapBaiHocByIDBTBaiHoc", true, null);
            return ILADobj.selectCommentBaiTapBaiHocByIDBTBaiHoc(IDComment);
        }
       
    }
}
