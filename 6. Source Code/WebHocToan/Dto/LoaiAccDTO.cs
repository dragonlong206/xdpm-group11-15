using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class LoaiAccDTO
    {
        #region Attributes

        private int mIDLoaiAcc;
        private string mTenLoaiAcc;


        #endregion Attributes

        #region Properties

        public int IDLoaiAcc
        {
            set { mIDLoaiAcc = value; }
            get { return mIDLoaiAcc; }
        }

        public string TenLoaiAcc
        {
            set { mTenLoaiAcc = value; }
            get { return mTenLoaiAcc; }
        }





        #endregion Properties

        #region Methods

        public LoaiAccDTO()
        {
            mIDLoaiAcc = 0;
            mTenLoaiAcc = "";
        }

        #endregion Methods
    }
}
