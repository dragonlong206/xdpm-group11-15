CREATE PROCEDURE insertBaiHoc
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


select * from BaiHoc