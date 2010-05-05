using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class MonHocDTO
    {
        #region Attributes

        private int mIDMonHoc;
        private string mTenMonHoc;


        #endregion Attributes

        #region Properties

        public int IDMonHoc
        {
            set { mIDMonHoc = value; }
            get { return mIDMonHoc; }
        }

        public string TenMonHoc
        {
            set { mTenMonHoc = value; }
            get { return mTenMonHoc; }
        }





        #endregion Properties

        #region Methods

        public MonHocDTO()
        {
            mIDMonHoc = 0;
            mTenMonHoc = "";
        }

        #endregion Methods
    }
}
