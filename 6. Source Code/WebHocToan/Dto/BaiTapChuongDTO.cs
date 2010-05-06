using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class BaiTapChuongDTO
    {
        #region Attributes

        private int mIDBaiTap;
        private string mTenBaiTap;
        private string mNoiDungBaiTap;
        private int mIDChuong;


        #endregion Attributes

        #region Properties

        public int IDBaiTap
        {
            set { mIDBaiTap = value; }
            get { return mIDBaiTap; }
        }

        public string TenBaiTap
        {
            set { mTenBaiTap = value; }
            get { return mTenBaiTap; }
        }
        public string NoiDungBaiTap
        {
            set { mNoiDungBaiTap = value; }
            get { return mNoiDungBaiTap; }
        }
        public int IDChuong
        {
            set { mIDChuong = value; }
            get { return mIDChuong; }
        }



        #endregion Properties

        #region Methods

        public BaiTapChuongDTO()
        {
            mIDBaiTap = 0;
            mTenBaiTap = "";
            mNoiDungBaiTap = "";
            mIDChuong = 0;
        }

        #endregion Methods
    }
}
