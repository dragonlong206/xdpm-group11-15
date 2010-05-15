using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUSTest
{
    public interface ICommentBaiTapBaiHocDAO
    {

        System.Boolean insertCommentBaiTapBaiHoc(Dto.CommentBaiTapBaiHocDTO cmBTBaiHocDto);
        System.Boolean deleteCommentBaiTapBaiHoc(System.Int32 IDComment);
        System.Boolean updateCommentBaiTapBaiHoc(Dto.CommentBaiTapBaiHocDTO cmBTBaiHocDto);
        System.Collections.ArrayList selectAllCommentBaiTapBaiHoc();
        Dto.CommentBaiTapBaiHocDTO selectCommentBaiTapBaiHocByIDComment(System.Int32 IDComment);
        System.Collections.ArrayList selectCommentBaiTapBaiHocByIDBTBaiHoc(System.Int32 IDBTBaiHoc);
       
    }
}
