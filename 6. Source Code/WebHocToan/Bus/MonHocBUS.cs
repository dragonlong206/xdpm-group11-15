using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class MonHocBUS
    {
        public static Boolean insertMonHoc(MonHocDTO MonHocDTO)
        {
            Boolean result = false;
            result = MonHocDAO.insertMonHoc(MonHocDTO);
            return result;
        }

        public static Boolean deleteMonHoc(string IDMonHoc)
        {
            Boolean result = false;
            result = MonHocDAO.deleteMonHoc(IDMonHoc);
            return result;
        }

        public static Boolean updateMonHoc(MonHocDTO MonHoc)
        {
            Boolean result = false;
            result = MonHocDAO.updateMonHoc(MonHoc);
            return result;
        }

        public static ArrayList selectAllMonHoc()
        {
            return MonHocDAO.selectAllMonHoc();
        }



        public static MonHocDTO selectMonHocByIDMonHoc(int IDMonHoc)
        {
            return MonHocDAO.selectMonHocByIDMonHoc(IDMonHoc);
        }

    }
}
