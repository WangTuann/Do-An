CREATE DATABASE [QUANLYTRASUA]
GO

USE [QUANLYTRASUA]
GO

--TẠO CÁC BẢNG
CREATE TABLE ChucVu
(
	MaCV			INT IDENTITY (1,1) PRIMARY KEY,
	TenChucVu		NVARCHAR(200) NOT NULL,
	GhiChu			NVARCHAR(1000)
)

CREATE TABLE TaiKhoan
(
	TenDangNhap		NVARCHAR(100) PRIMARY KEY,
	MatKhau			NVARCHAR(100) NOT NULL,
	HoTen			NVARCHAR (100) NOT NULL,
	TrangThai		BIT NOT NULL,
	NgayTao			SMALLDATETIME NOT NULL,
	ChucVu			INT REFERENCES ChucVu(MaCV)	
)

CREATE TABLE NhanVien
(
	MaNV			NVARCHAR(20) PRIMARY KEY,
	HoTen			NVARCHAR(100) NOT NULL,
	GioiTinh		NVARCHAR(10) CHECK(GioiTinh = N'Nam' OR GioiTinh = N'Nữ'),
	DiaChi			NVARCHAR(50),
	NgaySinh		DATETIME NOT NULL,
	SoDienThoai		NVARCHAR(100) NOT NULL
)

CREATE TABLE Ban
(
	MaBan			INT IDENTITY (1,1) PRIMARY KEY,
	TenBan			NVARCHAR(100) NOT NULL,
	TrangThaiBan	BIT NOT NULL
)

CREATE TABLE HoaDon
(
	MaHoaDon		INT IDENTITY (1,1) PRIMARY KEY,
	TenHoaDon		NVARCHAR(200) NOT NULL,
	MaBan			INT REFERENCES Ban(MaBan),
	TongTien		INT NOT NULL,
	GiamGia			FLOAT NOT NULL,
	Thue			FLOAT NOT NULL,
	TrangThaiHD		INT NOT NULL,
	NgayTao			DATETIME NOT NULL,
	TaiKhoanTao		NVARCHAR(100) REFERENCES TaiKhoan(TenDangNhap)
)

CREATE TABLE LoaiNuoc
(
	MaLoai			INT IDENTITY (1,1) PRIMARY KEY,
	TenLoai			NVARCHAR(100) NOT NULL,
)

CREATE TABLE NuocUong
(
		MaNuocUong		INT IDENTITY (1,1) PRIMARY KEY,
		TenNuocUong		NVARCHAR(200) NOT NULL,
		MaLoai			INT REFERENCES LoaiNuoc(MaLoai),
		DonGia			INT NOT NULL,
		DonViTinh		NVARCHAR(100) NOT NULL
)

CREATE TABLE ChiTietHoaDon
(
	MaChiTietHoaDon	INT IDENTITY (1,1) PRIMARY KEY,
	MaHoaDon		INT REFERENCES HoaDon(MaHoaDon),
	MaNuocUong		INT REFERENCES NuocUong (MaNuocUong),
	SoLuong			INT
)



--Thêm dữ liệu
SET IDENTITY_INSERT [ChucVu] ON 
INSERT [ChucVu]	([MaCV], [TenChucVu], [GhiChu])	VALUES	(1, N'Quản lý',				NULL)
INSERT [ChucVu]	([MaCV], [TenChucVu], [GhiChu])	VALUES	(2, N'Nhân viên phục vụ',	NULL)
INSERT [ChucVu]	([MaCV], [TenChucVu], [GhiChu])	VALUES	(3, N'Nhân viên pha chế',	NULL)


SET DATEFORMAT dmy
INSERT [TaiKhoan] ([TenDangNhap], [MatKhau], [HoTen], [TrangThai], [NgayTao], [ChucVu]) VALUES (N'gominn',		N'gominn',		N'Nguyễn Việt Duy Danh',	1,	 '20/11/2021', 2)
INSERT [TaiKhoan] ([TenDangNhap], [MatKhau], [HoTen], [TrangThai], [NgayTao], [ChucVu]) VALUES (N'qngtuann',	N'qngtuann',	N'Trương Quang Tuấn',		0,	 '20/11/2021', 1)
INSERT [TaiKhoan] ([TenDangNhap], [MatKhau], [HoTen], [TrangThai], [NgayTao], [ChucVu]) VALUES (N'qngbao',		N'qngbao',		N'Nguyễn Trần Quang Bảo',	1,	 '20/11/2021', 3)



INSERT [NhanVien] ([MaNV], [HoTen], [GioiTinh], [DiaChi], [NgaySinh], [SoDienThoai]) VALUES (1,	N'Nguyễn Việt Duy Danh',	'Nam',	N'Đà Lạt',	'21/12/2001', '0917291154')
INSERT [NhanVien] ([MaNV], [HoTen], [GioiTinh], [DiaChi], [NgaySinh], [SoDienThoai]) VALUES (2,	N'Nguyễn Trần Quang Bảo',	'Nam',	N'Đà Lạt',	'03/10/2001', '0987654321')
INSERT [NhanVien] ([MaNV], [HoTen], [GioiTinh], [DiaChi], [NgaySinh], [SoDienThoai]) VALUES (3,	N'Nguyễn Việt Duy Danh',	'Nam',	N'Đà Lạt',	'21/12/2001', '0917291154')
INSERT [NhanVien] ([MaNV], [HoTen], [GioiTinh], [DiaChi], [NgaySinh], [SoDienThoai]) VALUES (4,	N'Trương Quang Tuấn',		'Nam',	N'Đà Lạt',	'24/02/2001', '0334502288')
INSERT [NhanVien] ([MaNV], [HoTen], [GioiTinh], [DiaChi], [NgaySinh], [SoDienThoai]) VALUES (5,	N'Nguyễn Trần Quang Bảo',	'Nam',	N'Đà Lạt',	'03/10/2001', '0987654321')

DECLARE @i INT = 0
WHILE @i <=10
BEGIN 
	INSERT Ban (TenBan, TrangThaiBan) VALUES (N'Bàn ' + CAST (@i AS nvarchar(100)), 0)
	SET @i = @i + 1
END
GO

SET DATEFORMAT dmy
SET IDENTITY_INSERT [ChucVu] OFF
SET IDENTITY_INSERT [HoaDon] ON 
INSERT [HoaDon] ([MaHoaDon], [TenHoaDon], [MaBan], [TongTien], [GiamGia], [Thue], [TrangThaiHD], [NgayTao], [TaiKhoanTao]) VALUES (1, N'Hóa đơn thanh toán', 1, 150000, 0.05, 0.1, 1, '20/11/2021', 'gominn')
INSERT [HoaDon] ([MaHoaDon], [TenHoaDon], [MaBan], [TongTien], [GiamGia], [Thue], [TrangThaiHD], [NgayTao], [TaiKhoanTao]) VALUES (2, N'Hóa đơn thanh toán', 1, 300000, 0.05, 0.1, 1, '20/11/2021', 'gominn')
INSERT [HoaDon] ([MaHoaDon], [TenHoaDon], [MaBan], [TongTien], [GiamGia], [Thue], [TrangThaiHD], [NgayTao], [TaiKhoanTao]) VALUES (3, N'Hóa đơn thanh toán', 4, 700000, 0.05, 0.1, 1, '20/11/2021', 'gominn')
INSERT [HoaDon] ([MaHoaDon], [TenHoaDon], [MaBan], [TongTien], [GiamGia], [Thue], [TrangThaiHD], [NgayTao], [TaiKhoanTao]) VALUES (4, N'Hóa đơn thanh toán', 5, 250000, 0.05, 0.1, 1, '20/11/2021', 'gominn')
INSERT [HoaDon] ([MaHoaDon], [TenHoaDon], [MaBan], [TongTien], [GiamGia], [Thue], [TrangThaiHD], [NgayTao], [TaiKhoanTao]) VALUES (5, N'Hóa đơn thanh toán', 3, 75000,	0.05, 0.1, 1, '20/11/2021', 'gominn')
INSERT [HoaDon] ([MaHoaDon], [TenHoaDon], [MaBan], [TongTien], [GiamGia], [Thue], [TrangThaiHD], [NgayTao], [TaiKhoanTao]) VALUES (6, N'Hóa đơn thanh toán', 2, 500000, 0.05, 0.1, 1, '20/11/2021', 'gominn')

SET IDENTITY_INSERT [HoaDon] OFF
SET IDENTITY_INSERT [LoaiNuoc] ON 
INSERT [LoaiNuoc] ([MaLoai], [TenLoai]) VALUES (1,N'Trà sữa')
INSERT [LoaiNuoc] ([MaLoai], [TenLoai]) VALUES (2,N'Sữa tươi')
INSERT [LoaiNuoc] ([MaLoai], [TenLoai]) VALUES (3,N'Trà')
INSERT [LoaiNuoc] ([MaLoai], [TenLoai]) VALUES (4,N'Cà phê')
INSERT [LoaiNuoc] ([MaLoai], [TenLoai]) VALUES (5,N'Nước ngọt')

SET IDENTITY_INSERT [LoaiNuoc] OFF
SET IDENTITY_INSERT [NuocUong] ON 
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (1,  N'Trà sữa truyền thống',			1, 25000, N'Ly')
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (2,  N'Trà sữa khoai môn dẻo',			1, 30000, N'Ly')
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (3,  N'Trà sữa sốt dưa lưới',			1, 30000, N'Ly')
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (4,  N'Trà sữa bạc hà dưa lưới',		1, 30000, N'Ly')
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (5,  N'Sữa tươi trân châu đường đen',	2, 25000, N'Ly')
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (6,  N'Trà đào',						3, 20000, N'Ly')
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (7,  N'Trà vải',						3, 20000, N'Ly')
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (8,  N'Cà phê sữa đá',					4, 12000, N'Ly')
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (9,  N'Cà phê sữa nóng',				4, 12000, N'Ly')
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (10, N'Cà phê đen đá',					4, 12000, N'Ly')
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (11, N'Sting',							5, 10000, N'Chai')
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (12, N'Bò húc',							5, 15000, N'Lon')
INSERT [NuocUong] ([MaNuocUong], [TenNuocUong], [MaLoai], [DonGia], [DonViTinh]) VALUES (13, N'Coca-cola',						5, 10000, N'Chai')

SET IDENTITY_INSERT [NuocUong] OFF
SET IDENTITY_INSERT [ChiTietHoaDon] ON
INSERT [ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaNuocUong], [SoLuong]) VALUES (1, 1, 12, 10)
INSERT [ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaNuocUong], [SoLuong]) VALUES (2, 4, 1, 10)
INSERT [ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaNuocUong], [SoLuong]) VALUES (3, 6, 5, 20)





-- thực hiện truy vấn và procedure
-----------------------------------------
-- thủ tục lấy bảng NuocUong
Create procedure [dbo].[NuocUong_GetAll]
as
	select * from NuocUong
-----------------------------------------
-- thủ tục lấy bảng LoaiNuoc
Create procedure [dbo].[LoaiNuoc_GetAll]
as
	select * from LoaiNuoc
-----------------------------------------
-- Thủ tục lấy dữ liệu từ bảng Ban
CREATE PROCEDURE [Table_GetAll]
AS
	SELECT * FROM Ban
-- thủ tục thêm, xoá, sửa bảng LoaiNuoc
create PROCEDURE [dbo].[LoaiNuoc_InsertUpdateDelete]
 @MaLoai int output,
 @TenLoai nvarchar(100),
 @Action int
AS
-- Nếu Action = 0, thực hiện thêm dữ liệu
IF @Action = 0
	BEGIN
	If not exists (select * from LoaiNuoc where TenLoai = @TenLoai)
		begin
			INSERT INTO [LoaiNuoc]([TenLoai])
			VALUES (@TenLoai)
			SET @MaLoai = @@identity -- Thiết lập ID tự tăng
		END
	end
-- Nếu Action = 1, thực hiện cập nhật dữ liệu
ELSE IF @Action = 1
	BEGIN
		UPDATE [LoaiNuoc] SET [TenLoai] = @TenLoai
		WHERE [MaLoai] = @MaLoai
	END
-- Nếu Action = 2, thực hiện xóa dữ liệu
ELSE IF @Action = 2
	BEGIN
		DELETE FROM [LoaiNuoc] WHERE [MaLoai] = @MaLoai
	END
-----------------------------------------
-- thủ tục thêm, xoá, sửa bảng NuocUong
CREATE PROCEDURE [dbo].[NuocUong_InsertUpdateDelete]
 @MaNuocUong int output,
 @TenNuocUong nvarchar(200),
 @MaLoai int,
 @DonGia int,
 @DonViTinh nvarchar(100),
 @Action int
AS
-- Nếu Action = 0, thực hiện thêm dữ liệu
IF @Action = 0 -- Nếu Action = 0, thêm dữ liệu
	BEGIN
		If not exists (select * from NuocUong where TenNuocUong = @TenNuocUong)
		begin
			INSERT INTO [NuocUong] ([TenNuocUong],[MaLoai],[DonGia],[DonViTinh])
			VALUES ( @TenNuocUong, @MaLoai, @DonGia, @DonViTinh)
			SET @MaNuocUong = @@identity -- Thiết lập ID tự tăng
		END	
	end
ELSE IF @Action = 1 -- Nếu Action = 1, cập nhật dữ liệu
	BEGIN
		UPDATE [NuocUong]
		SET [TenNuocUong] = @TenNuocUong,
			[MaLoai]=@MaLoai,
			[DonGia]=@DonGia,
			[DonViTinh]=@DonViTinh
		WHERE [MaNuocUong] = @MaNuocUong
	END
ELSE IF @Action = 2 -- Nếu Action = 2, xóa dữ liệu
	BEGIN
		DELETE FROM [NuocUong] WHERE [MaNuocUong] = @MaNuocUong
	END

-----------------------------------------
-- tìm kiếm theo tên bảng NuocUong
create procedure [dbo].[NuocUong_TimTheoTen]
 @TenNuocUong nvarchar(200)
As
	Begin
		select * from NuocUong where TenNuocUong = '%' + @TenNuocUong + '%'
	End


SELECT MaHoaDon From [HoaDon] WHERE MaBan = 3 and TrangThaiHD = 1