﻿/*
CREATE database QLKHACHHANG, thêm các dòng dữ liệu, sau đó backup - restore database QLKHACHHANGfalse để chứa transaction chưa fix tranh chấp đồng thời
*/

USE master; -- Switch to the master database
GO

-- Check if the database exists
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'QLNHAKHOA')
BEGIN
    -- Drop the database
    DROP DATABASE QLKHACHHANG;
    PRINT 'Database QLKHACHHANG has been dropped.';
END
ELSE
BEGIN
    PRINT 'Database QLKHACHHANG does not exist.';

    -- Create the database
    CREATE DATABASE QLKHACHHANG;
    PRINT 'Database QLKHACHHANG has been created.';
END

USE QLKHACHHANG;

-- TAI_KHOAN table
CREATE TABLE TAI_KHOAN
(
	TenTK VARCHAR(10) PRIMARY KEY,
	MatKhau VARCHAR(50) NOT NULL,
	NgayDK DATE DEFAULT GETDATE(),
	LoaiTK CHAR(2),
	TRANG_THAI_KHOA BIT DEFAULT 0,
)

-- QUAN_TRI_VIEN table
CREATE TABLE QUAN_TRI_VIEN (
    ID_QuanTriVien INT PRIMARY KEY,
	TenTK VARCHAR(10) NOT NULL
);

-- NHAN_VIEN table
CREATE TABLE NHAN_VIEN (
    ID_NV INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(999),
    NgaySinh DATE,
    DiaChi NVARCHAR(999),
    SDT VARCHAR(10),
    Email NVARCHAR(999),
    MatKhau VARCHAR(50) NOT NULL,
    ID_QuanTriVien INT DEFAULT 1,
    FOREIGN KEY (ID_QuanTriVien) REFERENCES QUAN_TRI_VIEN(ID_QuanTriVien)
);

-- KHACH_HANG table
CREATE TABLE KHACH_HANG (
    ID_KH INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(999),
    NgaySinh DATE,
    DiaChi NVARCHAR(999),
    SDT VARCHAR(10),
    Email NVARCHAR(999),
    MatKhau VARCHAR(50),
    ID_QuanTriVien INT DEFAULT 1,
    FOREIGN KEY (ID_QuanTriVien) REFERENCES QUAN_TRI_VIEN(ID_QuanTriVien)
);

-- NHA_SI table
CREATE TABLE NHA_SI (
    ID_NS INT IDENTITY(1,1) PRIMARY KEY,
    HoTen VARCHAR(50),
    NgaySinh DATE,
    DiaChi NVARCHAR(999),
    SDT NVARCHAR(10),
    Email NVARCHAR(999),
    MatKhau VARCHAR(50),
    ID_QuanTriVien INT DEFAULT 1,
    FOREIGN KEY (ID_QuanTriVien) REFERENCES QUAN_TRI_VIEN(ID_QuanTriVien)
);

-- LICH_NHA_SI table
CREATE TABLE LICH_NHA_SI (
    ID_NS INT,
    NGAY_KHAM DATE,
    GIO_KHAM TIME,
    PRIMARY KEY (ID_NS, NGAY_KHAM, GIO_KHAM),
    FOREIGN KEY (ID_NS) REFERENCES NHA_SI(ID_NS)
);

-- LICH_HEN table
CREATE TABLE LICH_HEN (
    ID_LH INT IDENTITY(1,1) PRIMARY KEY,
    NgayKham DATE,
    GioKham TIME,
    ID_KH INT,
    ID_NS INT,
    ID_NV_Lap INT,
    FOREIGN KEY (ID_KH) REFERENCES KHACH_HANG(ID_KH),
    FOREIGN KEY (ID_NS) REFERENCES NHA_SI(ID_NS),
    FOREIGN KEY (ID_NV_Lap) REFERENCES NHAN_VIEN(ID_NV)
);

-- BENH_AN table
CREATE TABLE BENH_AN (
    ID_BenhAn INT IDENTITY(1,1) PRIMARY KEY,
    NgayKham DATE,
    DichVu NVARCHAR(999),
    Thuoc NVARCHAR(999),
    ID_KH INT,
    ID_NS INT,
    FOREIGN KEY (ID_KH) REFERENCES KHACH_HANG(ID_KH),
    FOREIGN KEY (ID_NS) REFERENCES NHA_SI(ID_NS)
);

-- HOA_DON table
CREATE TABLE HOA_DON (
    ID_HoaDon INT IDENTITY(1,1) PRIMARY KEY,
    NgayTao DATE,
    TongTien DECIMAL(10, 2),
    ID_NV_Lap INT,
    FOREIGN KEY (ID_NV_Lap) REFERENCES NHAN_VIEN(ID_NV)
);

-- DICH_VU table
CREATE TABLE DICH_VU (
    ID_DichVu INT IDENTITY(1,1) PRIMARY KEY,
    TenDichVu NVARCHAR(999),
    DonGia DECIMAL(10, 2)
);

-- THUOC table
CREATE TABLE THUOC (
    ID_Thuoc INT IDENTITY(1,1) PRIMARY KEY,
    TenThuoc NVARCHAR(999),
    DonViTinh NVARCHAR(50),
    ChiDinh NVARCHAR(999),
    SoLuongTon INT,
    DonGiaThuoc DECIMAL(10, 2),
    NgayHetHan DATE
);