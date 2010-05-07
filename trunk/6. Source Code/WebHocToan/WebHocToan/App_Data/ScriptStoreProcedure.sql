--

-----------------------------
--1. insertBaiHoc-------------
------------------------------

alter PROCEDURE insertBaiHoc
			(	@TenBaiHoc nvarchar(50), @NoiDungBaiHoc ntext,@IDChuong int)
AS
Begin
	Declare @DS_BaiHoc cursor
	Set @DS_BaiHoc = cursor for select IDBaiHoc, TenBaiHoc from BAIHOC
	Declare @mIDBaiHoc int, @mTenBaiHoc nvarchar(50)
	Declare @ViTri int, @TimDuoc int
	Set @ViTri = 1 --Vị trí sẽ thêm môn học mới vào
	Set @TimDuoc = 0  --Flag = 0 Không tìm được 
	Open @DS_BaiHoc

	fetch next from @DS_BaiHoc into @mIDBaiHoc, @mTenBaiHoc
	While @@fetch_status = 0
	Begin
		if @TimDuoc = 0  
		Begin

			if @ViTri != @mIDBaiHoc
			Begin
				set @TimDuoc = 1
			End
			Else
			Begin
				set @ViTri = @ViTri + 1
			End
		End

		if @TenBaiHoc = @mTenBaiHoc
		Begin
			Print N'Đã Có Bài Học Này Bạn Hãy Nhập Topic khác'
			Return 
		End

			Fetch next From @DS_BaiHoc into  @mIDBaiHoc, @mTenBaiHoc
	End
	Close @DS_BaiHoc

	Insert into BAIHOC values(@ViTri, @TenBaiHoc, @NoiDungBaiHoc , @IDChuong)
End
GO 

-----------------------------
--2. insertBaiTapCuaBaiHoc-------------
------------------------------

alter PROCEDURE insertBaiTapBaiHoc
			(	@TenBaiTap nvarchar(50), @NoiDungBaiTap ntext,@IDBaiHoc int, @IDBaiTapBaiHoc int out)
AS
Begin
	Declare @DS_BaiTap cursor
	Set @DS_BaiTap = cursor for select IDBaiTap, TenBaiTap from BAITAPCUABAIHOC
	Declare @mIDBaiTap int, @mTenBaiTap nvarchar(50)
	Declare @ViTri int, @TimDuoc int
	Set @ViTri = 1 --Vị trí sẽ thêm môn học mới vào
	Set @TimDuoc = 0  --Flag = 0 Không tìm được 
	Open @DS_BaiTap

	fetch next from @DS_BaiTap into @mIDBaiTap, @mTenBaiTap
	While @@fetch_status = 0
	Begin
		if @TimDuoc = 0  
		Begin
			if @ViTri != @mIDBaiTap
			Begin
				set @TimDuoc = 1
			End
			Else
			Begin
				set @ViTri = @ViTri + 1
			End
		End

		if @TenBaiTap = @mTenBaiTap
		Begin
			Print N'Đã Có Bài Học Này Bạn Hãy Nhập Topic khác'
			Return 
		End

			Fetch next From @DS_BaiTap into  @mIDBaiTap, @mTenBaiTap
	End
	Close @DS_BaiTap
	set @IDBaiTapBaiHoc = @ViTri;
	Insert into BaiTapCuaBaiHoc values(@ViTri, @TenBaiTap, @NoiDungBaiTap , @IDBaiHoc)
End
GO 


-----------------------------
--3. insertBaiTapCuaChuong-------------
------------------------------

alter PROCEDURE insertBaiTapChuong
			(	@TenBaiTap nvarchar(50), @NoiDungBaiTap ntext,@IDChuong int, @IDBaiTapChuong int out)
AS
Begin
	Declare @DS_BaiTap cursor
	Set @DS_BaiTap = cursor for select IDChuong, TenBaiTap from BAITAPCHUONG
	Declare @mIDBaiTap int, @mTenBaiTap nvarchar(50)
	Declare @ViTri int, @TimDuoc int
	Set @ViTri = 1 --Vị trí sẽ thêm môn học mới vào
	Set @TimDuoc = 0  --Flag = 0 Không tìm được 
	Open @DS_BaiTap

	fetch next from @DS_BaiTap into @mIDBaiTap, @mTenBaiTap
	While @@fetch_status = 0
	Begin
		if @TimDuoc = 0  
		Begin

			if @ViTri != @mIDBaiTap
			Begin
				set @TimDuoc = 1
			End
			Else
			Begin
				set @ViTri = @ViTri + 1
			End
		End

		if @TenBaiTap = @mTenBaiTap
		Begin
			Print N'Đã Có Bài Học Này Bạn Hãy Nhập Topic khác'
			Return 
		End

			Fetch next From @DS_BaiTap into  @mIDBaiTap, @mTenBaiTap
	End
	Close @DS_BaiTap
	set @IDBaiTapChuong = @ViTri
	Insert into BaiTapChuong values(@ViTri, @TenBaiTap, @NoiDungBaiTap , @IDChuong)
End
GO 

-----------------------------
--4. insertCauHoiBTBaiHoc-------------
------------------------------

alter PROCEDURE [dbo].[insertCauHoiBTBaiHoc]
			(	@CauHoiA nText,@CauHoiB nText, @CauHoiC nText, @CauHoiD nText, @CauTraLoi nvarchar(5),@IDBaiTap int)
AS
Begin
--Xac dinh ma cau hoi them vao
	Declare @DS_CauHoi cursor
	Set @DS_CauHoi  = cursor for select IDCauHoi from CauHoiBTBaiHoc
	Declare @mIDCauHoi int
	Declare @ViTri int, @TimDuoc int
	Set @ViTri = 1 --Vị trí sẽ thêm môn học mới vào
	Set @TimDuoc = 0  --Flag = 0 Không tìm được 
	Open @DS_CauHoi

	fetch next from @DS_CauHoi into @mIDCauHoi
	While @@fetch_status = 0
	Begin
		if @TimDuoc = 0  
		Begin

			if @ViTri != @mIDCauHoi
			Begin
				set @TimDuoc = 1
			End
			Else
			Begin
				set @ViTri = @ViTri + 1
			End
		End

			Fetch next From @DS_CauHoi into  @mIDCauHoi
	End
	Close @DS_CauHoi

	Insert into CauHoiBTBaiHoc values(@ViTri,@CauHoiA,@CauHoiB, @CauHoiC, @CauHoiD, @CauTraLoi,@IDBaiTap)
End

go 



-----------------------------
--5. insertCauHoiBTChuong-------------
------------------------------

alter PROCEDURE [dbo].[insertCauHoiBTChuong]
			(	@CauHoiA nText,@CauHoiB nText, @CauHoiC nText, @CauHoiD nText, @CauTraLoi nvarchar(5),@IDBaiTap int)
AS
Begin
--Xac dinh ma cau hoi them vao
	Declare @DS_CauHoi cursor
	Set @DS_CauHoi  = cursor for select IDCauHoi from CauHoiBTChuong
	Declare @mIDCauHoi int
	Declare @ViTri int, @TimDuoc int
	Set @ViTri = 1 --Vị trí sẽ thêm môn học mới vào
	Set @TimDuoc = 0  --Flag = 0 Không tìm được 
	Open @DS_CauHoi

	fetch next from @DS_CauHoi into @mIDCauHoi
	While @@fetch_status = 0
	Begin
		if @TimDuoc = 0  
		Begin

			if @ViTri != @mIDCauHoi
			Begin
				set @TimDuoc = 1
			End
			Else
			Begin
				set @ViTri = @ViTri + 1
			End
		End

			Fetch next From @DS_CauHoi into  @mIDCauHoi
	End
	Close @DS_CauHoi
	Insert into CauHoiBTChuong values(@ViTri,@CauHoiA,@CauHoiB, @CauHoiC, @CauHoiD, @CauTraLoi,@IDBaiTap)
End
