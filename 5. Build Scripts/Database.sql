create database WebDayToan10
go
use  WebDayToan10
create table Account
(
	IDAcc nvarchar(30) not null,
	Pass nvarchar(30) not null,
	IDLoaiAcc int not null,
	TrangThai bit not null
)

create table LoaiAcc
(
	IDLoaiAcc int not null,
	TenLoaiAcc nvarchar(30) not null
)

create table Chuong
(
	IDChuong int not null,
	TenChuong nvarchar(50) not null
)

create table BaiHoc
(
	IDBaiHoc int not null,
	TenBaiHoc nvarchar(50) not null,
	NoiDungBaiHoc ntext,
	IDChuong int not null
)

create table BaiTapCuaBaiHoc
(
	IDBaiTap int not null,
	TenBaiTap nvarchar(50) not null,
	IDBaiHoc int not null
)

create table CauHoiBTBaiHoc
(
	IDCauHoi int not null,
	CauHoiA ntext,
	CauHoiB ntext,
	CauHoiC ntext,
	CauHoiD ntext,
	CauTraLoi nchar,
	IDBaiTap int not null
)

create table BaiTapChuong
(
	IDBaiTap int not null,
	TenBaiTap nvarchar(50),
	IDChuong int not null
)

create table CauHoiBTChuong
(
	IDCauHoi int not null,
	CauHoiA ntext,
	CauHoiB ntext,
	CauHoiC ntext,
	CauHoiD ntext,
	CauTraLoi nchar,
	IDBaiTap int not null
)

create table CommentBaiHoc
(
	IDComment int not null,
	IDAcc nvarchar(30) not null,
	IDBaiHoc int not null,
	NoiDung ntext not null,
	NgayGio datetime
)

create table CommentBaiTapBaiHoc
(
	IDComment int not null,
	IDAcc nvarchar(30) not null,
	IDBTBaiHoc int not null,
	NoiDung ntext not null,
	NgayGio datetime
)

create table CommentBaiTapChuong
(
	IDComment int not null,
	IDAcc nvarchar(30) not null,
	IDBTChuong int not null,
	NoiDung ntext not null,
	NgayGio datetime
)

create table CommentChuong
(
	IDComment int not null,
	IDAcc nvarchar(30) not null,
	IDChuong int not null,
	NoiDung ntext not null,
	NgayGio datetime
)
--------------------------------------------------
--------------------------------------------------
 alter table LoaiAcc
 add constraint PK_LoaiAcc
 primary key (IDLoaiAcc)
 
 alter table CauHoiBTChuong
 add constraint PK_CauHoiBTChuong
 primary key (IDCauHoi)
 
 alter table Chuong
 add constraint PK_Chuong
 primary key (IDChuong)
 
 alter table Account
 add constraint PK_Account
 primary key (IDAcc)
 
 alter table CommentChuong
 add constraint PK_CommentChuong
 primary key (IDComment)
 
 alter table CommentBaiTapChuong
 add constraint PK_CommentBaiTapChuong
 primary key (IDComment)
 
 alter table CommentBaiTapBaiHoc
 add constraint PK_CommentBaiTapBaiHoc
 primary key (IDComment)
 
 alter table CommentBaiHoc
 add constraint PK_CommentBaiHoc
 primary key (IDComment)
 
 alter table BaiHoc
 add constraint PK_BaiHoc
 primary key (IDBaiHoc)
 
 alter table BaiTapChuong
 add constraint PK_BaiTapChuong
 primary key (IDBaiTap)
 
 alter table CauHoiBTBaiHoc
 add constraint PK_CauHoiBTBaiHoc
 primary key (IDCauHoi)
 
 alter table BaiTapCuaBaiHoc
 add constraint PK_BBaiTapCuaBaiHoc
 primary key (IDBaiTap)
 
 -----------------------------------------------------
 -----------------------------------------------------
 alter table Account
 add constraint FK_Account_LoaiAcc
 foreign key (IDLoaiAcc)
 references LoaiAcc(IDLoaiAcc)
 
 alter table BaiHoc
 add constraint FK_BaiHoc_Chuong
 foreign key (IDChuong)
 references Chuong(IDChuong)
 
 alter table BaiTapChuong
 add constraint FK_BaiTapChuong_Chuong
 foreign key (IDChuong)
 references Chuong(IDChuong)
 
 alter table CauHoiBTChuong
 add constraint FK_CauHoiBTChuong_BaiTapChuong
 foreign key (IDBaiTap)
 references BaiTapChuong(IDBaiTap)
 
 alter table BaiTapCuaBaiHoc
 add constraint FK_BaiTapCuaBaiHoc_BaiHoc
 foreign key (IDBaiHoc)
 references BaiHoc(IDBaiHoc)
 
 alter table CauHoiBTBaiHoc
 add constraint FK_CauHoiBTBaiHoc_BaiTapCuaBaiHoc
 foreign key (IDBaiTap)
 references BaiTapCuaBaiHoc(IDBaiTap)
 
 alter table CommentBaiHoc
 add constraint FK_CommentBaiHoc_Account
 foreign key (IDAcc)
 references Account(IDAcc)
 
 alter table CommentBaiHoc
 add constraint FK_CommentBaiHoc_BaiHoc
 foreign key (IDBaiHoc)
 references BaiHoc(IDBaiHoc)
 
 alter table CommentBaiTapBaiHoc
 add constraint FK_CommentBaiTapBaiHoc_Account
 foreign key (IDAcc)
 references Account(IDAcc)
 
 alter table CommentBaiTapBaiHoc
 add constraint FK_CommentBaiTapBaiHoc_BaiTapCuaBaiHoc
 foreign key (IDBTBaiHoc)
 references BaiTapCuaBaiHoc(IDBaiTap)
 
  alter table CommentBaiTapChuong
 add constraint FK_CommentBaiTapChuong_BaiTapChuong
 foreign key (IDBTChuong)
 references BaiTapChuong(IDBaiTap)
 
  alter table CommentBaiTapChuong
 add constraint FK_CommentBaiTapChuong_Account
 foreign key (IDAcc)
 references Account(IDAcc)
 
  alter table CommentChuong
 add constraint FK_CommentChuong_Chuong
 foreign key (IDChuong)
 references Chuong(IDChuong)
 
  alter table CommentChuong
 add constraint FK_CommentChuong_Acc
 foreign key (IDAcc)
 references Account(IDAcc)
 
 
 
 