using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class CommentBaiTapBaiHocBUS
    {
        public static Boolean insertCommentBaiTapBaiHoc(CommentBaiTapBaiHocDTO cmBTBaiHocDto)
        {
            Boolean result = false;
            result = CommentBaiTapBaiHocDAO.insertCommentBaiTapBaiHoc(cmBTBaiHocDto);
            return result;
        }

        public static Boolean deleteCommentBaiTapBaiHoc(int IDComment)
        {
            Boolean result = false;
            result = CommentBaiTapBaiHocDAO.deleteCommentBaiTapBaiHoc(IDComment);
            return result;
        }

        public static Boolean updateCommentBaiTapBaiHoc(CommentBaiTapBaiHocDTO cmBTBaiHocDto)
        {
            Boolean result = false;
            result = CommentBaiTapBaiHocDAO.updateCommentBaiTapBaiHoc(cmBTBaiHocDto);
            return result;
        }

        public static ArrayList selectAllCommetBaiHoc()
        {
            return CommentBaiTapBaiHocDAO.selectAllCommentBaiTapBaiHoc();
        }

        public static ArrayList selectCommentBaiTapBaiHocByIDBaiTapBaiHoc(int IDBaiHoc)
        {
            return CommentBaiTapBaiHocDAO.selectCommentBaiTapBaiHocByIDBTBaiHoc(IDBaiHoc);
        }

        public static CommentBaiTapBaiHocDTO selectCommentBaiTapBaiHocByIDComment(int IDComment)
        {
            return CommentBaiTapBaiHocDAO.selectCommentBaiTapBaiHocByIDComment(IDComment);
        }

    }
}
