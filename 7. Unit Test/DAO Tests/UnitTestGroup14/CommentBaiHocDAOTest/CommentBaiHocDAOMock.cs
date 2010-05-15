using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestGroup14
{
    public interface ICommentBaiHocDAOMock
    {

        System.Boolean insertCommentBaiHoc(Dto.CommentBaiHocDTO cmBaiHocDto);
        System.Boolean deleteCommentBaiHoc(System.Int32 IDComment);
        System.Boolean updateCommentBaiHoc(Dto.CommentBaiHocDTO cmBaiHocDto);
        System.Collections.ArrayList selectAllCommentBaiHoc();
        Dto.CommentBaiHocDTO selectCommentBaiHocByIDComment(System.Int32 IDComment);
        System.Collections.ArrayList selectCommentBaiHocByIDBaiHoc(System.Int32 IDBaiHoc);
        System.String ToString();
        System.Boolean Equals(System.Object obj);
        System.Int32 GetHashCode();
        System.Type GetType();
    }
}
