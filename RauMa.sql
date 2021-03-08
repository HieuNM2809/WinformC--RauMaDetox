create database ql_rauma
on primary
(
	name ='qlquan_rauma1',
	filename ='D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\WinformC--RauMaDetox\qlquan_rauma1.mdf',
	size=100MB,
	maxsize=1GB,
	filegrowth=20%
),
(
	name ='qlquan_rauma2',
	filename ='D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\WinformC--RauMaDetox\qlquan_rauma2.ndf'
)

log on
(
	name ='qlquan_raumalog',
	filename ='D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\WinformC--RauMaDetox\qlquan_raumalog.ldf',
	size=10MB,
	maxsize=50MB,
	filegrowth=10%
)

----- Tạo Bảng ----

-- Tài Khoản, Phân quyền --
create table SanPham
(
MaSp int not null primary key,
TenSP int,
MaLoaiSP int ,
GiaTien money,
MoTa nvarchar(20),
TrangThai bit default 1
)

create table LoaiSP
(
MaLoaiSP int primary key,
LoaiSP nvarchar(20),
TrangThai bit default 1
)

--Khóa Chính, Khóa Ngoại 
alter table SanPham
add constraint FK_SanPham_LoaiSanPham foreign key (MaLoaiSP) references LoaiSP(MaLoaiSP)
