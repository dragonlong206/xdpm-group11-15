using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUSTest
{
    public interface IMonHocDAO
    {

        System.Boolean insertMonHoc(Dto.MonHocDTO MonHocDto);
        System.Boolean deleteMonHoc(System.String IDMonHoc);
        System.Boolean updateMonHoc(Dto.MonHocDTO MonHocDto);
        System.Collections.ArrayList selectAllMonHoc();
        Dto.MonHocDTO selectMonHocByIDMonHoc(System.Int32 IDMonHoc);
     
    }
}
