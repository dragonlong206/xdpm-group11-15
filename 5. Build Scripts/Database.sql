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

