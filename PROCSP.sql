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
UPDATE SanPham SET TenSp= @tensp ,MaloaiSp=@maloaisp ,GiaTien=@giatien ,MoTa=@mota,Hinh=NULL WHERE MaSP=@masp AND TrangThai='True'
 end