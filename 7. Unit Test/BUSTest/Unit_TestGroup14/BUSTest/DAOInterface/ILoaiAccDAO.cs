using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUSTest
{
    public interface ILoaiAccDAO
    {

        System.Boolean insertLoaiAcc(Dto.LoaiAccDTO LoaiAccDto);
        System.Boolean deleteLoaiAcc(System.String IDLoaiAcc);
        System.Boolean updateLoaiAcc(Dto.LoaiAccDTO LoaiAccDto);
        System.Collections.ArrayList selectAllLoaiAcc();
        Dto.LoaiAccDTO selectLoaiAccByIDLoaiAcc(System.Int32 IDLoaiAcc);
       
    }
}
