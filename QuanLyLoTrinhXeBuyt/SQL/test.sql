USE QLLTXB;

DELETE FROM PhanCong;
DELETE FROM ChuyenXe;
DELETE FROM TuyenXe_ChiTiet;
DELETE FROM TramXe;
DELETE FROM XeBuyt;
DELETE FROM NhanVien;
DELETE FROM TuyenXe;
DELETE FROM TaiKhoan

-- Reset identity
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'TuyenXe' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('TuyenXe', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'Xe' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('Xe', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'NhanVien' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('NhanVien', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'TaiKhoan' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('TaiKhoan', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'ChuyenXe' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('ChuyenXe', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'PhanCong' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('PhanCong', RESEED, 0);
	
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'TramXe' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('TramXe', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'TuyenXe_ChiTiet' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('TuyenXe_ChiTiet', RESEED, 0);

SET IDENTITY_INSERT XeBuyt ON;
-- Insert data into XeBuyt (Buses)
INSERT INTO XeBuyt (XeID, BienSo, TrangThai, HinhAnh)
VALUES
    (1, '51B-12345', N'Hoạt động', 'xe1.jpg'),
    (2, '51B-23456', N'Hoạt động', 'xe2.jpg'),
    (3, '51B-34567', N'Bảo trì', 'xe3.jpg'),
    (4, '51B-45678', N'Hoạt động', 'xe4.jpg'),
    (5, '51B-56789', N'Hoạt động', 'xe5.jpg');
SET IDENTITY_INSERT XeBuyt OFF;
GO

SET IDENTITY_INSERT TramXe ON;
-- Insert data into TramXe (Bus Stations)
INSERT INTO TramXe (TramXeID, TenTramXe)
VALUES
    (1, N'Bến Thành'),
    (2, N'Chợ Lớn'),
    (3, N'Đại học Quốc Gia'),
    (4, N'Bến xe Miền Đông'),
    (5, N'Suối Tiên'),
    (6, N'Thủ Đức'),
    (7, N'Quận 7'),
    (8, N'Bình Thạnh');
SET IDENTITY_INSERT TramXe OFF;
GO

SET IDENTITY_INSERT TuyenXe ON;
-- Insert data into TuyenXe (Bus Routes)
INSERT INTO TuyenXe (TuyenXeID, TenTuyen, MoTa)
VALUES
    (1, N'Tuyến 01', N'Bến Thành - Chợ Lớn'),
    (2, N'Tuyến 08', N'Bến Thành - Đại học Quốc Gia'),
    (3, N'Tuyến 19', N'Bến xe Miền Đông - Suối Tiên'),
    (4, N'Tuyến 150', N'Thủ Đức - Quận 7');
SET IDENTITY_INSERT TuyenXe OFF;
GO

SET IDENTITY_INSERT TuyenXe_ChiTiet ON;
-- Insert data into TuyenXe_ChiTiet (Route Details)
INSERT INTO TuyenXe_ChiTiet (ID, TuyenXeID, TramXeID)
VALUES
    -- Tuyến 01: Bến Thành - Chợ Lớn
    (1, 1, 1),
    (2, 1, 8),
    (3, 1, 2),
    
    -- Tuyến 08: Bến Thành - Đại học Quốc Gia
    (4, 2, 1),
    (5, 2, 8),
    (6, 2, 6),
    (7, 2, 3),
    
    -- Tuyến 19: Bến xe Miền Đông - Suối Tiên
    (8, 3, 4),
    (9, 3, 6),
    (10, 3, 5),
    
    -- Tuyến 150: Thủ Đức - Quận 7
    (11, 4, 6),
    (12, 4, 8),
    (13, 4, 7);
SET IDENTITY_INSERT TuyenXe_ChiTiet OFF;
GO

SET IDENTITY_INSERT NhanVien ON;
-- Insert data into NhanVien (Staff)
INSERT INTO NhanVien (NhanVienID, HoTen, SoDienThoai, Email, DiaChi, VaiTro)
VALUES
    (1, N'Nguyễn Văn An', '0901234567', 'annguyen@example.com', N'123 Nguyễn Trãi, Q1, TP.HCM', N'Lái xe'),
    (2, N'Trần Thị Bình', '0912345678', 'binhtran@example.com', N'45 Lê Lợi, Q5, TP.HCM', N'Lái xe'),
    (3, N'Lê Văn Công', '0923456789', 'congle@example.com', N'67 Trần Hưng Đạo, Q1, TP.HCM', N'Lái xe'),
    (4, N'Phạm Thị Dung','0934567890', 'dungpham@example.com', N'89 Võ Văn Tần, Q3, TP.HCM', N'Phụ xe'),
    (5, N'Hoàng Văn Em', '0945678901', 'emhoang@example.com', N'101 Điện Biên Phủ, Bình Thạnh, TP.HCM', N'Phụ xe'),
    (6, N'Vũ Thị Giang', '0956789012', 'giangvu@example.com', N'234 Cách Mạng Tháng 8, Q10, TP.HCM', N'Quản lý'),
    (7, N'Đặng Văn Hùng', '0967890123', 'hungdang@example.com', N'45 Nguyễn Thị Minh Khai, Q1, TP.HCM', N'Quản trị viên');
SET IDENTITY_INSERT NhanVien OFF;
GO

-- Tạo lại câu lệnh INSERT cho bảng TaiKhoan với mật khẩu "123456" được mã hóa bằng BCrypt
SET IDENTITY_INSERT TaiKhoan ON;
INSERT INTO TaiKhoan (TaiKhoanID, TenDangNhap, MatKhau, QuyenHan, NhanVienID)
VALUES
    (1, 'vanan', '$2a$11$zauJw0Np/.SuZbsiuAXhn.rDCBmg64z/uvYUflNNlLp3wEc0vXp9S', 'user', 1),
    (2, 'thibinh', '$2a$11$t1KFDk/y5wPoYEuCcToGx.ecKQKX0FXGOX4E.90jQa7FOJS7MFUK2', 'user', 2),
    (3, 'vancong', '$2a$11$VxdyTMAVLFn0PJOTcynJ6O1TmWHc8gblx4djPwelBLGylyicmusue', 'user', 3),
    (4, 'thidung', '$2a$11$ZswQLe47uJXzBgc2S3UVM.68ymD4Vq39pyp0mRO4tjdSgQeHNxtDW', 'user', 4),
    (5, 'vanem', '$2a$11$xbd6hgieRueyzYUJ5/qEyekPJ098Ido0RGP7/TQjCsHF6UZMKuZza', 'user', 5),
    (6, 'thigiang', '$2a$11$o.nbz5A5D0aiScQmCoROHuT.i/OoQqJ2xsdY97KWF/lnOw5O.6mMS', 'user', 6),
    (7, 'admin', '$2a$11$oWLilcd7lkaXWilybsWb4eadZMjU/.NitC9zNMTww2yHliiMiYHK6', 'admin', 7);
SET IDENTITY_INSERT TaiKhoan OFF;
GO

SET IDENTITY_INSERT ChuyenXe ON;
-- Insert data into ChuyenXe (Bus Trips) with fixed dates, times, and duration (ThoiGianDen)
INSERT INTO ChuyenXe (ChuyenXeID, TenChuyen, DiemXuatPhat, ThoiGianDi, ThoiGianDen, TuyenXeID, XeID)
VALUES
    -- Ngày 22/04/2025
    (1, N'Chuyến sáng - Tuyến 01', N'Bến Thành', '2025-04-22 06:00:00', '2025-04-22 06:45:00', 1, 1),
    (2, N'Chuyến trưa - Tuyến 01', N'Bến Thành', '2025-04-22 12:00:00', '2025-04-22 12:50:00', 1, 1),
    (3, N'Chuyến chiều - Tuyến 01', N'Bến Thành', '2025-04-22 17:00:00', '2025-04-22 17:55:00', 1, 1),
    (4, N'Chuyến sáng - Tuyến 08', N'Bến Thành', '2025-04-22 07:00:00', '2025-04-22 07:50:00', 2, 2),
    (5, N'Chuyến trưa - Tuyến 08', N'Bến Thành', '2025-04-22 13:00:00', '2025-04-22 13:50:00', 2, 2),

    -- Ngày 23/04/2025
    (6, N'Chuyến sáng - Tuyến 01', N'Bến Thành', '2025-04-23 06:00:00', '2025-04-23 06:45:00', 1, 1),
    (7, N'Chuyến sáng - Tuyến 19', N'Bến xe Miền Đông', '2025-04-23 07:00:00', '2025-04-23 08:00:00', 3, 4),
    (8, N'Chuyến chiều - Tuyến 19', N'Bến xe Miền Đông', '2025-04-23 16:00:00', '2025-04-23 17:00:00', 3, 4),

    -- Ngày 24/04/2025
    (9, N'Chuyến sáng - Tuyến 08', N'Bến Thành', '2025-04-24 07:00:00', '2025-04-24 07:45:00', 2, 2),
    (10, N'Chuyến sáng - Tuyến 150', N'Thủ Đức', '2025-04-24 06:00:00', '2025-04-24 07:30:00', 4, 5);
SET IDENTITY_INSERT ChuyenXe OFF;
GO


SET IDENTITY_INSERT PhanCong ON;
INSERT INTO PhanCong (PhanCongID, ChuyenXeID, NhanVienID, NgayLamViec)
VALUES
    -- ChuyếnXe ngày 22/04/2025
    (1, 1, 1, '2025-04-22'),
    (2, 1, 4, '2025-04-22'),
    (3, 2, 2, '2025-04-22'),
    (4, 2, 5, '2025-04-22'),
    (5, 3, 3, '2025-04-22'),
    (6, 3, 5, '2025-04-22'),
    (7, 4, 1, '2025-04-22'),
    (8, 4, 4, '2025-04-22'),
    (9, 5, 2, '2025-04-22'),
    (10, 5, 5, '2025-04-22'),

    -- ChuyếnXe ngày 23/04/2025
    (11, 6, 3, '2025-04-23'),
    (12, 6, 5, '2025-04-23'),
    (13, 7, 1, '2025-04-23'),
    (14, 7, 4, '2025-04-23'),
    (15, 8, 2, '2025-04-23'),
    (16, 8, 5, '2025-04-23'),

    -- ChuyếnXe ngày 24/04/2025
    (17, 9, 3, '2025-04-24'),
    (18, 9, 4, '2025-04-24'),
    (19, 10, 2, '2025-04-24'),
    (20, 10, 5, '2025-04-24');
SET IDENTITY_INSERT PhanCong OFF;
GO


