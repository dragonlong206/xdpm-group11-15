using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUSTest
{
    public interface ICommentBaiTapChuongDAO
    {

        System.Boolean insertCommentBaiTapChuong(Dto.CommentBaiTapChuongDTO cmBTChuongDto);
        System.Boolean deleteCommentBaiTapChuong(System.Int32 IDComment);
        System.Boolean updateCommentBaiTapChuong(Dto.CommentBaiTapChuongDTO cmBTChuongDto);
        System.Collections.ArrayList selectAllCommentBaiTapChuong();
        Dto.CommentBaiTapChuongDTO selectCommentBaiTapChuongByIDComment(System.Int32 IDComment);
        System.Collections.ArrayList selectCommentBaiTapChuongByIDBTChuong(System.Int32 IDBTChuong);
        
    }
}
