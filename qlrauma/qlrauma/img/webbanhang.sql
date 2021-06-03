-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1:3306
-- Thời gian đã tạo: Th5 31, 2021 lúc 10:30 AM
-- Phiên bản máy phục vụ: 5.7.31
-- Phiên bản PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `webbanhang`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `binhluan`
--

DROP TABLE IF EXISTS `binhluan`;
CREATE TABLE IF NOT EXISTS `binhluan` (
  `Ma_TK` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `NoiDung` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `HinhAnh` text COLLATE utf8_unicode_ci NOT NULL,
  KEY `Ma_TK` (`Ma_TK`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `binhluan`
--

INSERT INTO `binhluan` (`Ma_TK`, `NoiDung`, `HinhAnh`) VALUES
('', 'djtmemaykhai', '');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitiet_hoadon`
--

DROP TABLE IF EXISTS `chitiet_hoadon`;
CREATE TABLE IF NOT EXISTS `chitiet_hoadon` (
  `Ma_HD` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `Ma_SanPham` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `NgayLap` datetime NOT NULL,
  `SoLuong` int(3) NOT NULL,
  `DonGia` char(10) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Ma_HD`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `chitiet_hoadon`
--

INSERT INTO `chitiet_hoadon` (`Ma_HD`, `Ma_SanPham`, `NgayLap`, `SoLuong`, `DonGia`) VALUES
('1', '1', '2020-04-21 00:00:00', 5, '50000'),
('2', '2', '2021-04-21 00:00:00', 5, '55000'),
('3', '3', '2022-04-21 00:00:00', 5, '100000');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hoadon`
--

DROP TABLE IF EXISTS `hoadon`;
CREATE TABLE IF NOT EXISTS `hoadon` (
  `Ma_HD` char(3) COLLATE utf8_unicode_ci NOT NULL,
  `Ma_KH` char(3) COLLATE utf8_unicode_ci NOT NULL,
  `TenKH` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `NgayLap` datetime NOT NULL,
  `TongTien` int(10) NOT NULL,
  `TrangThai` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Ma_HD`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `hoadon`
--

INSERT INTO `hoadon` (`Ma_HD`, `Ma_KH`, `TenKH`, `NgayLap`, `TongTien`, `TrangThai`) VALUES
('1', '1', 'Lưu Thành Công', '2020-04-21 00:00:00', 150000, 'X'),
('2', '2', 'Ngô Tấn An', '2021-04-21 00:00:00', 75000, 'X'),
('3', '3', 'Nguyễn Trung Quân', '2022-04-21 00:00:00', 100000, 'X');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `khachhang`
--

DROP TABLE IF EXISTS `khachhang`;
CREATE TABLE IF NOT EXISTS `khachhang` (
  `Ma_KH` char(5) COLLATE utf8_unicode_ci NOT NULL,
  `TenKH` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `DiaChi` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `SDT` int(10) NOT NULL,
  PRIMARY KEY (`Ma_KH`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `khachhang`
--

INSERT INTO `khachhang` (`Ma_KH`, `TenKH`, `DiaChi`, `SDT`) VALUES
('1', 'Lưu Thành Công', '123 Huỳnh Thúc Kháng, Quận 1, TP HCM', 333999999),
('2', 'Ngô Tấn An', '124 Huỳnh Thúc Kháng, Quận 1, TP HCM', 333888888),
('3', 'Nguyễn Trung Quân', '125 Huỳnh Thúc Kháng, Quận 1, TP HCM', 333777777);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phieunhapkho`
--

DROP TABLE IF EXISTS `phieunhapkho`;
CREATE TABLE IF NOT EXISTS `phieunhapkho` (
  `Ma_PhieuNhap` char(3) COLLATE utf8_unicode_ci NOT NULL,
  `Ma_SP` char(3) COLLATE utf8_unicode_ci NOT NULL,
  `LoaiSP` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `SoLuong` int(10) NOT NULL,
  `DonGia` int(10) NOT NULL,
  `NgayLap` datetime NOT NULL,
  `TrangThai` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Ma_PhieuNhap`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `phieunhapkho`
--

INSERT INTO `phieunhapkho` (`Ma_PhieuNhap`, `Ma_SP`, `LoaiSP`, `SoLuong`, `DonGia`, `NgayLap`, `TrangThai`) VALUES
('1', '1', 'Trà', 5, 50000, '2015-04-21 00:00:00', 'N'),
('2', '2', 'Hạt Cafe', 10, 150000, '2016-04-21 00:00:00', 'N'),
('3', '3', 'Bột Matcha', 10, 50000, '2017-04-21 00:00:00', 'N');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sanpham`
--

DROP TABLE IF EXISTS `sanpham`;
CREATE TABLE IF NOT EXISTS `sanpham` (
  `Ma_SP` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `TenSP` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `DonVi` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `DonGia` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `TrangThai` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `HinhAnh` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Ma_SP`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `sanpham`
--

INSERT INTO `sanpham` (`Ma_SP`, `TenSP`, `DonVi`, `DonGia`, `TrangThai`, `HinhAnh`) VALUES
('7', 'Trà Dâu', 'Kg', '30.000 VND', 'X', 'TraDau.jpg'),
('8', 'Matcha Đá Xay', 'Ly', '35.000 VND', 'X', 'MatchaDaXay.jpg'),
('5', 'Oreo Đá Xay', 'Kg', '45.000 VND', 'X', 'OreoDaXay.jpg'),
('6', 'Macchiato', 'Kg', '55.000 VND', 'X', 'Macchiato.jpg'),
('3', 'Trà Đào', 'Kg', '25.000 VND', 'X', 'TraDao.jpg'),
('4', 'Trà Chanh', 'Kg', '20.000 VND', 'X', 'TraChanh.jpg'),
('1', 'Capuchino', 'Ly', '50.000 VND', 'X', 'Capuchino.jpg'),
('2', 'Espresso', 'Ly', '55.000 VND', 'X', 'Espresso.jpg');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sanphamkhac`
--

DROP TABLE IF EXISTS `sanphamkhac`;
CREATE TABLE IF NOT EXISTS `sanphamkhac` (
  `MaSPKhac` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `TenSPKhac` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `DonVi` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `DonGia` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `TrangThai` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `LoaiSP` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `HinhAnh` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`MaSPKhac`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `sanphamkhac`
--

INSERT INTO `sanphamkhac` (`MaSPKhac`, `TenSPKhac`, `DonVi`, `DonGia`, `TrangThai`, `LoaiSP`, `HinhAnh`) VALUES
('9', 'Hạt Hướng Dương', 'Kg', '30.000 VND', 'X', 'Hạt', 'HatHuongDuong.jpg'),
('6', 'Cơm Hải Sản', 'Phần', '30.000 VND', 'X', 'Ăn Sáng', 'ComHaiSan.jpg'),
('7', 'Hạt Dẻ', 'Kg', '70.000 VND', 'X', 'Hạt', 'HatDe.jpg'),
('8', 'Hạt Óc Chó', 'Kg', '100.000 VND', 'X', 'Hạt', 'HatOcCho.jpg'),
('5', 'Cơm Tấm', 'Phần', '30.000 VND', 'X', 'Ăn Sáng', 'ComTam.jpg'),
('4', 'Cơm Gà', 'Phần', '35.000 VND', 'X', 'Ăn Sáng', 'ComGa.jpg'),
('3', 'Bánh Chuối', 'Cái', '13.000 VND', 'X', 'Bánh', 'BanhChuoi.jpg'),
('2', 'Khoai Tây', 'Kg', '20.000 VND', 'X', 'Bánh', 'KhoaiTayChien.jpg'),
('1', 'Donut', 'Cái', '25.000 VND', 'X', 'Bánh', 'Donut.jpg'),
('10', 'Hạt Cafe', 'Kg', '250.000 VND', 'X', 'Nguyên Liệu', 'HatCafe.jpg'),
('11', 'Bột Matcha', 'Kg', '100.000 VND', 'X', 'Nguyên Liệu', 'BotMatcha.jpg'),
('12', 'Trà Xanh', 'Kg', '45.000 VND', 'X', 'Nguyên Liệu', 'TraXanh.jpg');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sanphamtop`
--

DROP TABLE IF EXISTS `sanphamtop`;
CREATE TABLE IF NOT EXISTS `sanphamtop` (
  `MaSPT` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `TenSPT` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `HinhAnh` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`MaSPT`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `sanphamtop`
--

INSERT INTO `sanphamtop` (`MaSPT`, `TenSPT`, `HinhAnh`) VALUES
('1', 'Capuchino', 'Capuchino.jpg'),
('2', 'Espresso', 'Espresso.jpg'),
('3', 'Trà Đào', 'TraDao.jpg'),
('4', 'Trà Chanh', 'TraChanh.jpg'),
('5', 'Oreo Đá Xay', 'OreoDaXay.jpg');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sanpham_ansang`
--

DROP TABLE IF EXISTS `sanpham_ansang`;
CREATE TABLE IF NOT EXISTS `sanpham_ansang` (
  `MaSP_AnSang` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `TenSP_AnSang` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `DonGia_AnSang` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `HinhAnh_AnSang` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`MaSP_AnSang`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `sanpham_ansang`
--

INSERT INTO `sanpham_ansang` (`MaSP_AnSang`, `TenSP_AnSang`, `DonGia_AnSang`, `HinhAnh_AnSang`) VALUES
('1', 'Cơm Gà', '35.000 VND', 'ComGa.jpg'),
('2', 'Cơm Tấm', '30.000 VND', 'ComTam.jpg'),
('3', 'Cơm Hải Sản', '30.000 VND', 'ComHaiSan.jpg');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sanpham_banh`
--

DROP TABLE IF EXISTS `sanpham_banh`;
CREATE TABLE IF NOT EXISTS `sanpham_banh` (
  `MaSP_Banh` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `TenSP_Banh` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `DonGia_Banh` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `HinhAnh_Banh` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`MaSP_Banh`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `sanpham_banh`
--

INSERT INTO `sanpham_banh` (`MaSP_Banh`, `TenSP_Banh`, `DonGia_Banh`, `HinhAnh_Banh`) VALUES
('1', 'Donut', '25.000 VND', 'Donut.jpg'),
('2', 'Khoai Tây', '20.000 VND', 'KhoaiTayChien.jpg'),
('3', 'Bánh Chuối', '13.000 VND', 'BanhChuoi.jpg');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sanpham_hat`
--

DROP TABLE IF EXISTS `sanpham_hat`;
CREATE TABLE IF NOT EXISTS `sanpham_hat` (
  `MaSP_Hat` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `TenSP_Hat` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `DonGia_Hat` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `HinhAnh_Hat` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`MaSP_Hat`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `sanpham_hat`
--

INSERT INTO `sanpham_hat` (`MaSP_Hat`, `TenSP_Hat`, `DonGia_Hat`, `HinhAnh_Hat`) VALUES
('1', 'Hạt Dẻ', '70.000 VND', 'HatDe.jpg'),
('2', 'Hạt Óc Chó', '100.000 VND', 'HatOcCho.jpg'),
('3', 'Hạt Hướng Dương', '30.000 VND', 'HatHuongDuong.jpg');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sanpham_nguyenlieu`
--

DROP TABLE IF EXISTS `sanpham_nguyenlieu`;
CREATE TABLE IF NOT EXISTS `sanpham_nguyenlieu` (
  `MaSP_NguyenLieu` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `TenSP_NguyenLieu` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `DonGia_NguyenLieu` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `HinhAnh_NguyenLieu` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`MaSP_NguyenLieu`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `sanpham_nguyenlieu`
--

INSERT INTO `sanpham_nguyenlieu` (`MaSP_NguyenLieu`, `TenSP_NguyenLieu`, `DonGia_NguyenLieu`, `HinhAnh_NguyenLieu`) VALUES
('1', 'Hạt Cafe', '250.000 VND', 'HatCafe.jpg'),
('2', 'Bột Matcha', '100.000 VND', 'BotMatcha.jpg'),
('3', 'Trà Xanh', '45.000 VND', 'TraXanh.jpg');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `taikhoan`
--

DROP TABLE IF EXISTS `taikhoan`;
CREATE TABLE IF NOT EXISTS `taikhoan` (
  `Ma_TK` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `TaiKhoan` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `MatKhau` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `TrangThai` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Ma_TK`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `taikhoan`
--

INSERT INTO `taikhoan` (`Ma_TK`, `TaiKhoan`, `MatKhau`, `TrangThai`) VALUES
('1', 'thanhcong', 'ltc123', 'Hoạt động'),
('2', 'tanan', 'nta123', 'Hoạt động'),
('3', 'trungquan', 'ntq123', 'Hoạt động');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `taikhoankh`
--

DROP TABLE IF EXISTS `taikhoankh`;
CREATE TABLE IF NOT EXISTS `taikhoankh` (
  `MaKH` char(5) COLLATE utf8_unicode_ci NOT NULL,
  `Ma_TKKH` char(5) COLLATE utf8_unicode_ci NOT NULL,
  `TaiKhoanKH` char(20) COLLATE utf8_unicode_ci NOT NULL,
  `MatKhauKH` char(20) COLLATE utf8_unicode_ci NOT NULL,
  `TrangThai` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `HinhAnh` text COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`MaKH`,`Ma_TKKH`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `taikhoankh`
--

INSERT INTO `taikhoankh` (`MaKH`, `Ma_TKKH`, `TaiKhoanKH`, `MatKhauKH`, `TrangThai`, `HinhAnh`) VALUES
('1', '1', 'luuthanhcong', 'cong123123', 'Hoạt động', ''),
('2', '2', 'ngotanan', 'an123123', 'Hoạt động', ''),
('3', '3', 'nguyentrungquan', 'quan123123', 'Hoạt động', ''),
('4', '4', 'laihongkhai', 'khai123123', 'Hoạt động', ''),
('5', '5', 'leanhkiet', 'kiet123123', 'Hoạt động', 'leanhkiet.jpg');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
