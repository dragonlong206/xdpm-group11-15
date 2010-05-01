using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Dao;
using Dto;

namespace Bus
{
    public class LoaiAccBUS
    {
        public static Boolean insertLoaiAcc(LoaiAccDTO LoaiAccDTO)
        {
            Boolean result = false;
            result = LoaiAccDAO.insertLoaiAcc(LoaiAccDTO);
            return result;
        }

        public static Boolean deleteLoaiAcc(string IDLoaiAcc)
        {
            Boolean result = false;
            result = LoaiAccDAO.deleteLoaiAcc(IDLoaiAcc);
            return result;
        }

        public static Boolean updateLoaiAcc(LoaiAccDTO LoaiAcc)
        {
            Boolean result = false;
            result = LoaiAccDAO.updateLoaiAcc(LoaiAcc);
            return result;
        }

        public static ArrayList selectAllLoaiAcc()
        {
            return LoaiAccDAO.selectAllLoaiAcc();
        }



        public static LoaiAccDTO selectLoaiAccByIDLoaiAcc(int IDLoaiAcc)
        {
            return LoaiAccDAO.selectLoaiAccByIDLoaiAcc(IDLoaiAcc);
        }

    }
}
