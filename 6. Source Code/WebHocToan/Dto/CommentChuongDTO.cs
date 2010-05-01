using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class CommentChuongDTO
    {
        #region Attributes

        private int mIDComment;
        private string mIDAcc;
        private int mIDChuong;
        private string mNoiDung;
        private DateTime mNgayGio;

        #endregion Attributes

        #region Properties

        public int IDComment
        {
            set { mIDComment = value; }
            get { return mIDComment; }
        }

        public string IDAcc
        {
            set { mIDAcc = value; }
            get { return mIDAcc; }
        }


        public int IDChuong
        {
            set { mIDChuong = value; }
            get { return mIDChuong; }
        }


        public string NoiDung
        {
            set { mNoiDung = value; }
            get { return mNoiDung; }
        }


        public DateTime NgayGio
        {
            set { mNgayGio = value; }
            get { return mNgayGio; }
        }


        #endregion Properties

        #region Methods

        public CommentChuongDTO()
        {
            mIDComment = 0;
            mIDAcc = "";
            mNoiDung = "";
            IDChuong = 0;
            NgayGio = DateTime.Now;
        }

        #endregion Methods
    }
}
