using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class ChuongDTO
    {
        #region Attributes

        private int mIDChuong;
        private string mTenChuong;


        #endregion Attributes

        #region Properties

        public int IDChuong
        {
            set { mIDChuong = value; }
            get { return mIDChuong; }
        }

        public string TenChuong
        {
            set { mTenChuong = value; }
            get { return mTenChuong; }
        }





        #endregion Properties

        #region Methods

        public ChuongDTO()
        {
            mIDChuong = 0;
            mTenChuong = "";
        }

        #endregion Methods
    }
}
