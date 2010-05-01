using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class CommentBaiTapBaiHocDTO
    {
        #region Attributes

        private int mIDComment;
        private string mIDAcc;
        private int mIDBTBaiHoc;
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


        public int IDBTBaiHoc
        {
            set { mIDBTBaiHoc = value; }
            get { return mIDBTBaiHoc; }
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

        public CommentBaiTapBaiHocDTO()
        {
            mIDComment = 0;
            mIDAcc = "";
            mNoiDung = "";
            IDBTBaiHoc = 0;
            NgayGio = DateTime.Now;
        }

        #endregion Methods
    }
}
