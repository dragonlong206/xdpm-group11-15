using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dto;

namespace UnitTestGroup14
{
    public interface ILoaiAccDAOMock
    {

        System.Boolean insertLoaiAcc(Dto.LoaiAccDTO LoaiAccDto);
        System.Boolean deleteLoaiAcc(System.String IDLoaiAcc);
        System.Boolean updateLoaiAcc(Dto.LoaiAccDTO LoaiAccDto);
        System.Collections.ArrayList selectAllLoaiAcc();
        Dto.LoaiAccDTO selectLoaiAccByIDLoaiAcc(System.Int32 IDLoaiAcc);
        System.String ToString();
        System.Boolean Equals(System.Object obj);
        System.Int32 GetHashCode();
        System.Type GetType();
    }
}
