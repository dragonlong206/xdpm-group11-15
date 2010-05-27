using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class BaiTapBaiHocDTO
    {
        #region Attributes

        int mIDBaiTap;
        string mTenBaiTap;
        string mNoiDungBaiTap;
        int mIDBaiHoc;
        string mCauHoiA;
        string mCauHoiB;
        string mCauHoiC;
        string mCauHoiD;
        string mCauTraLoi;

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
        public int IDBaiHoc
        {
            set { mIDBaiHoc = value; }
            get { return mIDBaiHoc; }
        }
        public string CauHoiA
        {
            set { mCauHoiA = value; }
            get { return mCauHoiA; }
        }


        public string CauHoiB
        {
            set { mCauHoiB = value; }
            get { return mCauHoiB; }
        }


        public string CauHoiC
        {
            set { mCauHoiC = value; }
            get { return mCauHoiC; }
        }


        public string CauHoiD
        {
            set { mCauHoiD = value; }
            get { return mCauHoiD; }
        }


        public string CauTraLoi
        {
            set { mCauTraLoi = value; }
            get { return mCauTraLoi; }
        }



        #endregion Properties

        #region Methods

        public BaiTapBaiHocDTO()
        {
            mIDBaiTap = 0;
            mTenBaiTap = "";
            mNoiDungBaiTap = "";
            mIDBaiHoc = 0;
            mCauHoiA = "";
            mCauHoiB = "";
            mCauHoiC = "";
            mCauHoiD = "";
            mCauTraLoi = "A";
        }

        #endregion Methods
    }
}
