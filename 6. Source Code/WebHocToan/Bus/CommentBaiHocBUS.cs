using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class CommentBaiHocBUS
    {
        public static Boolean insertCommentBaiHoc(CommentBaiHocDTO cmBaiHocDto)
        {
            Boolean result = false;
            result = CommentBaiHocDAO.insertCommentBaiHoc(cmBaiHocDto);
            return result;
        }

        public static Boolean deleteCommentBaiHoc(int IDComment)
        {
            Boolean result = false;
            result = CommentBaiHocDAO.deleteCommentBaiHoc(IDComment);
            return result;
        }

        public static Boolean updateCommentBaiHoc(CommentBaiHocDTO cmBaiHocDto)
        {
            Boolean result = false;
            result = CommentBaiHocDAO.updateCommentBaiHoc(cmBaiHocDto);
            return result;
        }

        public static ArrayList selectAllCommetBaiHoc()
        {
            return CommentBaiHocDAO.selectAllCommentBaiHoc();
        }

        public static ArrayList selectCommentBaiHocByIDBaiHoc(int IDBaiHoc)
        {
            return CommentBaiHocDAO.selectCommentBaiHocByIDBaiHoc(IDBaiHoc);
        }

        public static CommentBaiHocDTO selectCommentBaiHocByIDComment(int IDComment)
        {
            return CommentBaiHocDAO.selectCommentBaiHocByIDComment(IDComment);
        }

    }
}
