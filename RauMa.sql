create database ql_rauma
use ql_rauma
go
----- Tạo Bảng ----

create table SanPham
(
MaSp nvarchar(5) not null primary key,
TenSp nvarchar(20),
MaLoaiSp nvarchar(5) ,
GiaTien money,
MoTa nvarchar(50),
Hinh nvarchar(MAX),
TrangThai int default 1
)
go
create table LoaiSP
(
MaLoaiSp nvarchar(5) primary key not null,
LoaiSP nvarchar(20),
TrangThai int default 1
)
go
create table NhanVien
(
IDNV nvarchar(3) not null,
HoTen nvarchar(50),
NgaySinh datetime,
GioiTinh nvarchar(10),
ChucDanh nvarchar(30),
LoaiNV nvarchar(20),
SDT char(10),
TaiKhoan varchar(100),
MatKhau varchar(100),
Email varchar(100),
TrangThai smallint,
)
go
create table CTPhanQuyen
(
	IDNV nvarchar(3),
	IDquyen nvarchar(3),
	Taikhoan varchar(100),
	LoaiQuyen varchar(50),
	TrangThai Bit default 1,
	primary key (IDNV,Idquyen),
)
go
create table PhanQuyen
(
	IDquyen nvarchar(3) not null,
	LoaiQuyen varchar(50)
)
go
create table HoaDon
(
	IDHoaDon nvarchar(3) not null,
	IDNV nvarchar(3),
	NgayLapHoaDon datetime,
	TrangThai smallint
)
go
create table CTHoaDon
(
	IDHoaDon nvarchar(3),
	MaSp nvarchar(3),
	SoLuong int,
	DonGia money,
	ChietKhau money,
	TongTien money,
	primary key(IDHoaDon, MaSp)
)
go



--Khóa Chính, Khóa Ngoại 
alter table SanPham
add constraint FK_SanPham_LoaiSanPham foreign key (MaLoaiSP) references LoaiSP(MaLoaiSP)
go
alter table NhanVien
add constraint PK_NhanVien primary key (IDNV)
go
alter table PhanQuyen
add constraint PK_PhanQuyen primary key (IDquyen)
go
alter table HoaDon
add constraint PK_HoaDon primary key (IDHoaDon)
go
alter table CTPhanQuyen
add constraint FK_CTPhanQuyen_PhanQuyen foreign key (IDquyen) references PhanQuyen(IDquyen)
go
alter table CTPhanQuyen
add constraint FK_CTPhanQuyen_NhanVien foreign key (IDNV) references NhanVien(IDNV)
go
alter table CTHoaDon
add constraint FK_CTHoaDon_HoaDon foreign key (IDHoaDon) references HoaDon(IDHoaDon)
go
alter table CTHoaDon
add constraint FK_CTHoaDon_SanPham foreign key (MaSp) references SanPham(MaSp)
go
alter table HoaDon
add constraint FK_HoaDon_NhanVien foreign key (IDNV) references NhanVien(IDNV)
go

--PROCEDURE--

CREATE PROCEDURE THEMHD
(
	@idhd nvarchar(3),
	@idnv nvarchar(3),
	@ngaylap datetime
)
AS
BEGIN 
	INSERT INTO HoaDon(IDHoaDon,IDNV,NgayLapHoaDon,TrangThai) VALUES(@idhd,@idnv,@ngaylap,1)
END

CREATE PROC XOAHD
(
	@idhd nvarchar(3)
)
AS
BEGIN
UPDATE HoaDon SET TrangThai=0 WHERE IDHoaDon=@idhd
END

--thêm bảng MaHD làm khóa chính cho CTHoaDon--

alter table CTHoaDon
add MaHD nvarchar(3) not null 


-- Khóa ngoại CTHoaDon qua HoaDon --

alter table CTHoaDon
add constraint FK_CTHoaDon_HoaDon foreign key (IDHoaDon) references HoaDon(IDHoaDon)

--Thêm xóa sửa sản phẩm--

CREATE PROCEDURE THEMSP
(
	@masp nvarchar(5),
	@Tensp nvarchar(20),
	@Maloaisp nvarchar(5),
	@Giatien money,
	@Mota nvarchar(50),
	@Hinh nvarchar(MAX)
)
AS
BEGIN 
	INSERT INTO SanPham(MaSp,TenSp,MaLoaiSp,GiaTien,MoTa,Hinh,TrangThai) 
	VALUES(@masp,@Tensp,@Maloaisp,@Giatien,@Mota,@Hinh,1)
END

CREATE PROCEDURE SUASP
(
	@masp nvarchar(5),
	@Tensp nvarchar(20),
	@Maloaisp nvarchar(5),
	@Giatien money,
	@Mota nvarchar(50),
	@Hinh nvarchar(MAX)
)
AS
BEGIN 
	UPDATE SanPham
SET TenSp=@Tensp, MaLoaiSp=@Maloaisp,GiaTien=@Giatien,MoTa=@Mota,Hinh=@Hinh,TrangThai=1
WHERE MaSp=@masp and TrangThai=1;
END

CREATE PROCEDURE XOASP
(
	@masp nvarchar(5)
)
AS
BEGIN 
	UPDATE SanPham
SET TrangThai=0
WHERE MaSp=@masp 
END
