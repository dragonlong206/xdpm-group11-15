using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dto;

namespace UnitTestGroup14
{
    public interface IMonHocDAOMock
    {

        System.Boolean insertMonHoc(Dto.MonHocDTO MonHocDto);
        System.Boolean deleteMonHoc(System.String IDMonHoc);
        System.Boolean updateMonHoc(Dto.MonHocDTO MonHocDto);
        System.Collections.ArrayList selectAllMonHoc();
        Dto.MonHocDTO selectMonHocByIDMonHoc(System.Int32 IDMonHoc);
        System.String ToString();
        System.Boolean Equals(System.Object obj);
        System.Int32 GetHashCode();
        System.Type GetType();
    }
}
