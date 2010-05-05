using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class AccountDTO
    {
        #region Attributes

        private string mIDAcc;
        private string mPass;
        private int mIDLoaiAcc;
        private string mEmail;
        private Boolean mTrangThai;

        #endregion Attributes

        #region Properties

        public string IDAcc
        {
            set { mIDAcc = value; }
            get { return mIDAcc; }
        }

        public string Pass
        {
            set { mPass = value; }
            get { return mPass; }
        }


        public int IDLoaiAcc
        {
            set { mIDLoaiAcc = value; }
            get { return mIDLoaiAcc; }
        }
        public string Email
        {
            set { mEmail = value; }
            get { return mEmail; }
        }
        public Boolean TrangThai
        {
            set { mTrangThai = value; }
            get { return mTrangThai; }
        }



        #endregion Properties

        #region Methods

        public AccountDTO()
        {

        }

        #endregion Methods
    }
}
