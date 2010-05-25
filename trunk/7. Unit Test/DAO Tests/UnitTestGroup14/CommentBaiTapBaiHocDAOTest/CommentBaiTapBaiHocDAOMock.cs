﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestGroup14
{
    public interface ICommentBaiTapBaiHocDAOMock
    {

        System.Boolean insertCommentBaiTapBaiHoc(Dto.CommentBaiTapBaiHocDTO cmBTBaiHocDto);
        System.Boolean deleteCommentBaiTapBaiHoc(System.Int32 IDComment);
        System.Boolean updateCommentBaiTapBaiHoc(Dto.CommentBaiTapBaiHocDTO cmBTBaiHocDto);
        System.Collections.ArrayList selectAllCommentBaiTapBaiHoc();
        Dto.CommentBaiTapBaiHocDTO selectCommentBaiTapBaiHocByIDComment(System.Int32 IDComment);
        System.Collections.ArrayList selectCommentBaiTapBaiHocByIDBTBaiHoc(System.Int32 IDBTBaiHoc);
        System.String ToString();
        System.Boolean Equals(System.Object obj);
        System.Int32 GetHashCode();
        System.Type GetType();
    }
}