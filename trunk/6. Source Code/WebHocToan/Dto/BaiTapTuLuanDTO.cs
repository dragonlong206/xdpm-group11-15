

namespace Dto
{
    public class BaiTapTuLuanDTO
    {
       #region Attributes

        private int mIDBaiTap;
        private string mTenBaiTap;
        private string mNoiDungBaiTap;
        private int mIDBaiHoc;

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

        public int  IDBaiHoc
        {
            set {  mIDBaiHoc = value; }
            get { return  mIDBaiHoc; }
        }

        #endregion Properties

        #region Methods

        public BaiTapTuLuanDTO()
        {
            mIDBaiTap = 0;
            mTenBaiTap = "";
            mNoiDungBaiTap = "";
            mIDBaiHoc = 0;
        }

        #endregion Methods
    }
}
