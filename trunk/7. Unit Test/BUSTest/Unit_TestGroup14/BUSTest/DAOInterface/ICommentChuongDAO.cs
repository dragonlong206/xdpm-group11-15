using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUSTest
{
    public interface ICommentChuongDAO
    {

        System.Boolean insertCommentChuong(Dto.CommentChuongDTO cmChuongDto);
        System.Boolean deleteCommentChuong(System.Int32 IDComment);
        System.Boolean updateCommentChuong(Dto.CommentChuongDTO cmChuongDto);
        System.Collections.ArrayList selectAllCommentChuong();
        Dto.CommentChuongDTO selectCommentChuongByIDComment(System.Int32 IDComment);
        System.Collections.ArrayList selectCommentChuongByIDChuong(System.Int32 IDChuong);
        
    }
}
