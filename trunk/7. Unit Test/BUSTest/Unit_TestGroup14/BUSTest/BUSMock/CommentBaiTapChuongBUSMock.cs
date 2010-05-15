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
    public class CommentBaiTapChuongBUSMock
    {
        public static Boolean insertCommentBaiTapChuong(CommentBaiTapChuongDTO cmBTChuongDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiTapChuongDAO));
            ICommentBaiTapChuongDAO Obj = (ICommentBaiTapChuongDAO)mockController.MockInstance as ICommentBaiTapChuongDAO;
            mockController.ExpectAndReturn("insertCommentBaiTapChuong", true, null);
            return Obj.insertCommentBaiTapChuong(cmBTChuongDto);
        }

        public static Boolean deleteCommentBaiTapChuong(int IDComment)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiTapChuongDAO));
            ICommentBaiTapChuongDAO Obj = (ICommentBaiTapChuongDAO)mockController.MockInstance as ICommentBaiTapChuongDAO;
            mockController.ExpectAndReturn("deleteCommentBaiTapChuong", true, null);
            return Obj.deleteCommentBaiTapChuong(IDComment);
        }

        public static Boolean updateCommentBaiTapChuong(CommentBaiTapChuongDTO cmBTChuongDto)
        {
              DynamicMock mockController = new DynamicMock(typeof(ICommentBaiTapChuongDAO));
            ICommentBaiTapChuongDAO Obj = (ICommentBaiTapChuongDAO)mockController.MockInstance as ICommentBaiTapChuongDAO;
            mockController.ExpectAndReturn("updateCommentBaiTapChuong", true, null);
            return Obj.updateCommentBaiTapChuong(cmBTChuongDto);
        }


        public static ArrayList selectAllCommetBaiTapChuong()
        {
             DynamicMock mockController = new DynamicMock(typeof(ICommentBaiTapChuongDAO));
            ICommentBaiTapChuongDAO Obj = (ICommentBaiTapChuongDAO)mockController.MockInstance as ICommentBaiTapChuongDAO;
            mockController.ExpectAndReturn("selectAllCommentBaiTapChuong", true, null);
            return Obj.selectAllCommentBaiTapChuong();
        }


        public static ArrayList selectCommentBaiTapChuongByIDBTChuong(int IDChuong)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiTapChuongDAO));
            ICommentBaiTapChuongDAO Obj = (ICommentBaiTapChuongDAO)mockController.MockInstance as ICommentBaiTapChuongDAO;
            mockController.ExpectAndReturn("selectCommentBaiTapChuongByIDBTChuong", true, null);
            return Obj.selectCommentBaiTapChuongByIDBTChuong(IDChuong);
        }

        public static CommentBaiTapChuongDTO selectCommentBaiTapChuongByIDComment(int IDComment)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiTapChuongDAO));
            ICommentBaiTapChuongDAO Obj = (ICommentBaiTapChuongDAO)mockController.MockInstance as ICommentBaiTapChuongDAO;
            mockController.ExpectAndReturn("selectCommentBaiTapChuongByIDComment", true, null);
            return Obj.selectCommentBaiTapChuongByIDComment(IDComment);
        }

    }
}
