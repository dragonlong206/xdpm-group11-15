using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUSTest
{
   public interface IBaiTapChuongDAO
	{
		
		System.Boolean insertBaiTapChuong(Dto.BaiTapChuongDTO btChuongDto,System.Int32 IDBaiTapChuong);		
		System.Boolean deleteBaiTapChuong(System.Int32 IDBaiTap);		
		System.Boolean updateBaiTapChuong(Dto.BaiTapChuongDTO btChuongDto);		
		System.Collections.ArrayList selectAllBaiTapChuong();		
		System.Collections.ArrayList selectBaiTapChuongByIDChuong(System.Int32 ID);		
		Dto.BaiTapChuongDTO selectBaiTapChuongByID(System.Int32 IDBaiTap);		
		
    }
}
