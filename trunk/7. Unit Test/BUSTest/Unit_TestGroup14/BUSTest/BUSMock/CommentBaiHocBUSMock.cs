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
    public class CommentBaiHocBUSMock
    {
        public static Boolean insertCommentBaiHoc(CommentBaiHocDTO cmBaiHocDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiHocDAO));
            ICommentBaiHocDAO Obj = (ICommentBaiHocDAO)mockController.MockInstance as ICommentBaiHocDAO;
            mockController.ExpectAndReturn("insertCommentBaiHoc", true, null);
            return Obj.insertCommentBaiHoc(cmBaiHocDto);
        }

        public static Boolean deleteCommentBaiHoc(int IDComment)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiHocDAO));
            ICommentBaiHocDAO Obj = (ICommentBaiHocDAO)mockController.MockInstance as ICommentBaiHocDAO;
            mockController.ExpectAndReturn("deleteCommentBaiHoc", true, null);
            return Obj.deleteCommentBaiHoc(IDComment);
        }

        public static Boolean updateCommentBaiHoc(CommentBaiHocDTO cmBaiHocDto)
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiHocDAO));
            ICommentBaiHocDAO Obj = (ICommentBaiHocDAO)mockController.MockInstance as ICommentBaiHocDAO;
            mockController.ExpectAndReturn("updateCommentBaiHoc", true, null);
            return Obj.updateCommentBaiHoc(cmBaiHocDto);
        }

        public static ArrayList selectAllCommetBaiHoc()
        {
            DynamicMock mockController = new DynamicMock(typeof(ICommentBaiHocDAO));
            ICommentBaiHocDAO Obj = (ICommentBaiHocDAO)mockController.MockInstance as ICommentBaiHocDAO;
            mockController.ExpectAndReturn("selectAllCommetBaiHoc", true, null);
            return Obj.selectAllCommentBaiHoc();
        }

        public static ArrayList selectCommentBaiHocByIDBaiHoc(int IDBaiHoc)
        {
           DynamicMock mockController = new DynamicMock(typeof(ICommentBaiHocDAO));
            ICommentBaiHocDAO Obj = (ICommentBaiHocDAO)mockController.MockInstance as ICommentBaiHocDAO;
            mockController.ExpectAndReturn("selectCommentBaiHocByIDBaiHoc", true, null);
            return Obj.selectCommentBaiHocByIDBaiHoc(IDBaiHoc);
        }

        public static CommentBaiHocDTO selectCommentBaiHocByIDComment(int IDComment)
        {
           DynamicMock mockController = new DynamicMock(typeof(ICommentBaiHocDAO));
            ICommentBaiHocDAO Obj = (ICommentBaiHocDAO)mockController.MockInstance as ICommentBaiHocDAO;
            mockController.ExpectAndReturn("selectCommentBaiHocByIDComment", true, null);
            return Obj.selectCommentBaiHocByIDComment(IDComment);
        }

    }
}
