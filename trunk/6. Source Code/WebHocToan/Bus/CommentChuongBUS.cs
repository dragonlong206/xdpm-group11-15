using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class CommentChuongBUS
    {
        public static Boolean insertCommentChuong(CommentChuongDTO cmChuongDto)
        {
            Boolean result = false;
            result = CommentChuongDAO.insertCommentChuong(cmChuongDto);
            return result;
        }

        public static Boolean deleteCommentChuong(int IDComment)
        {
            Boolean result = false;
            result = CommentChuongDAO.deleteCommentChuong(IDComment);
            return result;
        }

        public static Boolean updateCommentChuong(CommentChuongDTO cmChuongDto)
        {
            Boolean result = false;
            result = CommentChuongDAO.updateCommentChuong(cmChuongDto);
            return result;
        }

        public static ArrayList selectAllCommetChuong()
        {
            return CommentChuongDAO.selectAllCommentChuong();
        }

        public static ArrayList selectCommentChuongByIDChuong(int IDChuong)
        {
            return CommentChuongDAO.selectCommentChuongByIDChuong(IDChuong);
        }

        public static CommentChuongDTO selectCommentChuongByIDComment(int IDComment)
        {
            return CommentChuongDAO.selectCommentChuongByIDComment(IDComment);
        }

    }
}
