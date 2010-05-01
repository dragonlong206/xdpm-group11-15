using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class BaiHocDTO
    {
       #region Attributes

        private int mIDBaiHoc;
        private string mTenBaiHoc;
        private string mNoiDung;
        private int mIDChuong;

        #endregion Attributes

        #region Properties

        public int IDBaiHoc
        {
            set { mIDBaiHoc = value; }
            get { return mIDBaiHoc; }
        }

        public string TenBaiHoc
        {
            set { mTenBaiHoc = value; }
            get { return mTenBaiHoc; }
        }


        public string NoiDung
        {
            set { mNoiDung = value; }
            get { return mNoiDung; }
        }

        public int  IDChuong
        {
            set {  mIDChuong = value; }
            get { return  mIDChuong; }
        }

 



        #endregion Properties

        #region Methods

        public BaiHocDTO()
        {
            mIDBaiHoc = 0;
            mTenBaiHoc = "";
            mNoiDung = "";
            mIDChuong = 0;
        }

        #endregion Methods
    }
}
