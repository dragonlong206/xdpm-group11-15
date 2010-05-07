using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class CauHoiBTBaiHocDTO
    {
        #region Attributes

        private int mIDCauHoi;
        private string mCauHoiA;
        private string mCauHoiB;
        private string mCauHoiC;
        private string mCauHoiD;
        private string mCauTraLoi;
        private int mIDBaiTap;

        #endregion Attributes

        #region Properties

        public int IDCauHoi
        {
            set { mIDCauHoi = value; }
            get { return mIDCauHoi; }
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

        public int IDBaiTap
        {
            set { mIDBaiTap = value; }
            get { return mIDBaiTap; }
        }


        #endregion Properties

        #region Methods

        public CauHoiBTBaiHocDTO()
        {
            mIDCauHoi = 0;
            mCauHoiA = "";
            mCauHoiB = "";
            mCauHoiC = "";
            mCauHoiD = "";
            mCauTraLoi = "A";
            mIDBaiTap = 0;
        }

        #endregion Methods
    }
}
