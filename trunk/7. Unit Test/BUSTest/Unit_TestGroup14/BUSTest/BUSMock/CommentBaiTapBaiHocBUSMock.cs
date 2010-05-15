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
    public class CommentBaiTapBaiHocBUSMock
    {
        public static Boolean insertCommentBaiTapBaiHoc(CommentBaiTapBaiHocDTO cmBTBaiHocDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiTapBaiHocDAO));
            ICommentBaiTapBaiHocDAO Obj = (ICommentBaiTapBaiHocDAO)mockController.MockInstance as ICommentBaiTapBaiHocDAO;
            mockController.ExpectAndReturn("insertCommentBaiHoc", true, null);
            return Obj.insertCommentBaiTapBaiHoc(cmBTBaiHocDto);
        }

        public static Boolean deleteCommentBaiTapBaiHoc(int IDComment)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiTapBaiHocDAO));
            ICommentBaiTapBaiHocDAO Obj = (ICommentBaiTapBaiHocDAO)mockController.MockInstance as ICommentBaiTapBaiHocDAO;
            mockController.ExpectAndReturn("deleteCommentBaiTapBaiHoc", true, null);
            return Obj.deleteCommentBaiTapBaiHoc(IDComment);
        }

        public static Boolean updateCommentBaiTapBaiHoc(CommentBaiTapBaiHocDTO cmBTBaiHocDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiTapBaiHocDAO));
            ICommentBaiTapBaiHocDAO Obj = (ICommentBaiTapBaiHocDAO)mockController.MockInstance as ICommentBaiTapBaiHocDAO;
            mockController.ExpectAndReturn("updateCommentBaiTapBaiHoc", true, null);
            return Obj.updateCommentBaiTapBaiHoc(cmBTBaiHocDto);
        }

        public static ArrayList selectAllCommetBaiTapBaiHoc()
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiTapBaiHocDAO));
            ICommentBaiTapBaiHocDAO Obj = (ICommentBaiTapBaiHocDAO)mockController.MockInstance as ICommentBaiTapBaiHocDAO;
            mockController.ExpectAndReturn("selectAllCommetBaiHoc", true, null);
            return Obj.selectAllCommentBaiTapBaiHoc();
        }

        public static ArrayList selectCommentBaiTapBaiHocByIDBaiTapBaiHoc(int IDBaiHoc)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiTapBaiHocDAO));
            ICommentBaiTapBaiHocDAO Obj = (ICommentBaiTapBaiHocDAO)mockController.MockInstance as ICommentBaiTapBaiHocDAO;
            mockController.ExpectAndReturn("selectCommentBaiTapBaiHocByIDBaiTapBaiHoc", true, null);
            return Obj.selectCommentBaiTapBaiHocByIDBTBaiHoc(IDBaiHoc);
        }

        public static CommentBaiTapBaiHocDTO selectCommentBaiTapBaiHocByIDComment(int IDComment)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiTapBaiHocDAO));
            ICommentBaiTapBaiHocDAO Obj = (ICommentBaiTapBaiHocDAO)mockController.MockInstance as ICommentBaiTapBaiHocDAO;
            mockController.ExpectAndReturn("selectCommentBaiTapBaiHocByIDComment", true, null);
            return Obj.selectCommentBaiTapBaiHocByIDComment(IDComment);
        }

    }
}
