using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class CommentBaiTapChuongBUS
    {
        public static Boolean insertCommentBaiTapChuong(CommentBaiTapChuongDTO cmBTChuongDto)
        {
            Boolean result = false;
            result = CommentBaiTapChuongDAO.insertCommentBaiTapChuong(cmBTChuongDto);
            return result;
        }

        public static Boolean deleteCommentBaiTapChuong(int IDComment)
        {
            Boolean result = false;
            result = CommentBaiTapChuongDAO.deleteCommentBaiTapChuong(IDComment);
            return result;
        }

        public static Boolean updateCommentBaiTapChuong(CommentBaiTapChuongDTO cmBTChuongDto)
        {
            Boolean result = false;
            result = CommentBaiTapChuongDAO.updateCommentBaiTapChuong(cmBTChuongDto);
            return result;
        }

        public static ArrayList selectAllCommetChuong()
        {
            return CommentBaiTapChuongDAO.selectAllCommentBaiTapChuong();
        }

        public static ArrayList selectCommentBaiTapChuongByIDBaiTapChuong(int IDChuong)
        {
            return CommentBaiTapChuongDAO.selectCommentBaiTapChuongByIDBTChuong(IDChuong);
        }

        public static CommentBaiTapChuongDTO selectCommentBaiTapChuongByIDComment(int IDComment)
        {
            return CommentBaiTapChuongDAO.selectCommentBaiTapChuongByIDComment(IDComment);
        }

    }
}
