using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{
    public class CommentChuongBUSMock
    {
        public static Boolean insertCommentChuong(CommentChuongDTO cmChuongDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentChuongDAO));
            ICommentChuongDAO Obj = (ICommentChuongDAO)mockController.MockInstance as ICommentChuongDAO;
            mockController.ExpectAndReturn("insertCommentChuong", true, null);
            return Obj.insertCommentChuong(cmChuongDto);
        }

        public static Boolean deleteCommentChuong(int IDComment)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentChuongDAO));
            ICommentChuongDAO Obj = (ICommentChuongDAO)mockController.MockInstance as ICommentChuongDAO;
            mockController.ExpectAndReturn("deleteCommentChuong", true, null);
            return Obj.deleteCommentChuong(IDComment);
        }

        public static Boolean updateCommentChuong(CommentChuongDTO cmChuongDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentChuongDAO));
            ICommentChuongDAO Obj = (ICommentChuongDAO)mockController.MockInstance as ICommentChuongDAO;
            mockController.ExpectAndReturn("updateCommentChuong", true, null);
            return Obj.updateCommentChuong(cmChuongDto);
        }

        public static ArrayList selectAllCommentChuong()
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentChuongDAO));
            ICommentChuongDAO Obj = (ICommentChuongDAO)mockController.MockInstance as ICommentChuongDAO;
            mockController.ExpectAndReturn("selectAllCommetChuong", true, null);
            return Obj.selectAllCommentChuong();
        }

        public static ArrayList selectCommentChuongByIDChuong(int IDChuong)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentChuongDAO));
            ICommentChuongDAO Obj = (ICommentChuongDAO)mockController.MockInstance as ICommentChuongDAO;
            mockController.ExpectAndReturn("selectCommentChuongByIDChuong", true, null);
            return Obj.selectCommentChuongByIDChuong(IDChuong);
        }

        public static CommentChuongDTO selectCommentChuongByIDComment(int IDComment)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentChuongDAO));
            ICommentChuongDAO Obj = (ICommentChuongDAO)mockController.MockInstance as ICommentChuongDAO;
            mockController.ExpectAndReturn("selectCommentChuongByIDComment", true, null);
            return Obj.selectCommentChuongByIDComment(IDComment);
        }

    }
}
