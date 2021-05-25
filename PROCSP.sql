CREATE PROCEDURE suasp
(
@masp NVARCHAR,
@tensp NVARCHAR,
@maloaisp NVARCHAR,
@giatien MONEY,
@mota NVARCHAR,
@hinh NVARCHAR
)
as
begin
UPDATE SanPham SET TenSp= @tensp ,MaloaiSp=@maloaisp ,GiaTien=@giatien ,MoTa=@mota,Hinh=NULL,TrangThai=1 WHERE MaSP=@masp AND TrangThai=1
 end