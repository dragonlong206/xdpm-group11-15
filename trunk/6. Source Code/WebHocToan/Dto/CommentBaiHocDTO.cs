using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class CommentBaiHocDTO
    {
        #region Attributes

        private int mIDComment;
        private string mIDAcc;
        private int mIDBaiHoc;
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
            set { mIDAcc= value; }
            get { return mIDAcc; }
        }


        public int IDBaiHoc
        {
            set { mIDBaiHoc = value; }
            get { return mIDBaiHoc; }
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

        public CommentBaiHocDTO()
        {
            mIDComment = 0;
            mIDAcc = "";
            mNoiDung = "";
            IDBaiHoc = 0;
            NgayGio = DateTime.Now;
        }

        #endregion Methods
    }
}
