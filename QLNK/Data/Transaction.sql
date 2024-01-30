USE QLKHACHHANG
/***ALL***/
--đăng nhập 
GO
drop proc dang_nhap
GO
CREATE PROCEDURE dang_nhap @tai_khoan VARCHAR(10), @mat_khau VARCHAR(50)
AS
BEGIN TRY
	BEGIN TRANSACTION
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
	DECLARE @loai_tk CHAR(2);
	SET @loai_tk = NULL;
	--Lấy ra loại tài khoản
	SET @loai_tk = (SELECT tk.LoaiTK
					FROM TAI_KHOAN tk WITH (ROWLOCK)
					WHERE tk.TenTK = @tai_khoan AND tk.MatKhau = @mat_khau AND tk.TRANG_THAI_KHOA = 0)
	IF @loai_tk IS NOT NULL
		BEGIN
			--Trả về mã tương ứng với loại tài khoản đó
			IF @loai_tk = 'NV'
				BEGIN
					SELECT @loai_tk AS 'loai_tk', nv.ID_NV AS 'ma' FROM NHAN_VIEN nv WITH (ROWLOCK) WHERE nv.SDT = @tai_khoan;
					COMMIT TRAN;
					RETURN;
				END
			ELSE IF @loai_tk = 'KH'
				BEGIN
					SELECT @loai_tk AS 'loai_tk', kh.ID_KH AS 'ma' FROM KHACH_HANG kh WITH (ROWLOCK) WHERE kh.SDT = @tai_khoan;
					COMMIT TRAN;
					RETURN;
				END
			ELSE IF @loai_tk = 'NS'
				BEGIN
					SELECT @loai_tk AS 'loai_tk', ns.ID_NS AS 'ma' FROM NHA_SI ns WITH (ROWLOCK) WHERE ns.SDT = @tai_khoan;
					COMMIT TRAN;
					RETURN
				END
			ELSE IF @loai_tk = 'QT'
				BEGIN
					SELECT @loai_tk AS 'loai_tk', qtv.ID_QuanTriVien AS 'ma' FROM QUAN_TRI_VIEN qtv WITH (ROWLOCK) WHERE qtv.TenTK = @tai_khoan;
					COMMIT TRAN;
					RETURN
				END
		END
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH

/***KHÁCH HÀNG***/
--tạo tài khoản
GO
drop proc kh_taoTK
GO
CREATE PROCEDURE kh_taoTK
	@username NVARCHAR(10),
	@password VARCHAR(50),
	@name NVARCHAR(999),
	@birthday DATE,
	@address NVARCHAR(999)
AS
BEGIN TRY
	BEGIN TRAN
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
	IF EXISTS (SELECT * FROM TAI_KHOAN WHERE TenTK = @username)
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'Already have an account with matched username.', 1;
			RETURN;
		END
	ELSE
		BEGIN

			INSERT INTO TAI_KHOAN WITH (XLOCK) (TenTK, MatKhau, LoaiTK) 
			VALUES (@username, @password, 'KH');

			WAITFOR DELAY '00:00:10'

			IF EXISTS (SELECT * FROM KHACH_HANG WHERE SDT = @username)
			BEGIN
				ROLLBACK TRAN;
				THROW 50001, 'Already have an guest Customer with matched phone number, please contact admin for more infomation.', 1;
				RETURN;
			END
			ELSE
			BEGIN
				INSERT INTO KHACH_HANG WITH (XLOCK) (SDT, MatKhau, HoTen, NgaySinh, DiaChi)
				VALUES (@username, @password, @name, @birthday, @address);
			END
		END
	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH

-- xem lịch hẹn có thể đặt
GO
drop proc kh_xemLH
GO
CREATE PROCEDURE kh_xemLH
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		SELECT ns.ID_NS as 'ID Nha sĩ', ns.HoTen as 'Nha sĩ', lns.NGAY_KHAM as 'Ngày khám', lns.GIO_KHAM as 'Giờ khám'
		FROM
		  NHA_SI ns
		  INNER JOIN LICH_NHA_SI lns ON ns.ID_NS = lns.ID_NS
		WHERE NOT EXISTS (SELECT * FROM LICH_HEN WHERE ID_NS = lns.ID_NS AND NgayKham = lns.NGAY_KHAM AND GioKham = lns.GIO_KHAM )
	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH

-- xem lịch hẹn đã đặt
GO 
CREATE PROCEDURE kh_xemLHdadat
	@ID_KH int
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		SELECT ns.ID_NS as 'ID Nha sĩ', ns.HoTen as 'Nha sĩ', lh.NgayKham as 'Ngày khám', lh.GioKham as 'Giờ khám'
		FROM
		  LICH_HEN lh
		  INNER JOIN NHA_SI ns ON ns.ID_NS = lh.ID_NS
		WHERE lh.ID_KH = @ID_KH
	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH

--đặt lịch hẹn
GO
drop proc kh_datLH
GO
CREATE PROCEDURE kh_datLH
	@date DATE,
	@time TIME(7),
	@ID_KH INT,	
	@ID_NS INT
AS
BEGIN TRY
	BEGIN TRAN
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE; 

	IF EXISTS (SELECT * FROM LICH_HEN WITH (UPDLOCK) WHERE @date = NgayKham and @time = GioKham and @ID_NS = ID_NS)
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'This schedule is not exists or not available!', 1;
			RETURN;
		END

	WAITFOR DELAY '00:00:05'

	INSERT INTO LICH_HEN (NgayKham, GioKham, ID_KH, ID_NS)
	VALUES (@date, @time, @ID_KH, @ID_NS);

	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH

--xem thông tin cá nhân
GO
CREATE PROCEDURE kh_xemHS
	@id INT
AS 
BEGIN TRY
	BEGIN TRAN
	SELECT HoTen, NgaySinh, DiaChi, SDT, Email, MatKhau
	FROM KHACH_HANG WITH (ROWLOCK)
	WHERE ID_KH = @id
	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH

--cập nhật thông tin cá nhân
GO
CREATE PROCEDURE kh_capnhatHS
	@id INT,
	@newname NVARCHAR(999),
	@newbirthdate DATE,
	@newadd NVARCHAR(999),
	@newphone VARCHAR(10),
	@newemail NVARCHAR(999),
	@newpassword VARCHAR(50)
AS
BEGIN TRY
	BEGIN TRAN
		UPDATE KHACH_HANG WITH (ROWLOCK)
		SET
			HoTen = @newname,
			NgaySinh = @newbirthdate,
			DiaChi = @newadd,
			SDT = @newphone,
			Email = @newemail,
			MatKhau = @newpassword
		WHERE ID_KH = @id;
	COMMIT TRAN
END TRY
BEGIN CATCH
        ROLLBACK TRAN;
        THROW;
END CATCH

--xem hồ sơ bệnh án
GO
CREATE PROCEDURE kh_xemBA
	@id INT
AS
BEGIN TRY
	BEGIN TRAN
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
	SELECT ba.NgayKham as 'Ngày khám', kh.HoTen as 'Bệnh nhân', ns.HoTen as 'Nha sĩ', ba.DichVu as 'Dịch vụ', ba.Thuoc as 'Thuốc'
	FROM KHACH_HANG kh, BENH_AN ba, NHA_SI ns
	WHERE ba.ID_KH = @id and ba.ID_NS = ns.ID_NS and kh.ID_KH = @id
	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH

/***NHA SĨ***/
--xem hồ sơ bệnh án
GO
drop proc ns_xemBA
GO
CREATE PROCEDURE ns_xemBA
	@ID_NS INT
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		SELECT ba.ID_BenhAn as 'ID_BA', ba.NgayKham as 'Ngày khám', kh.HoTen as 'Khách hàng', ns.HoTen as 'Nha sĩ', ba.DichVu as 'Dịch vụ', ba.Thuoc as 'Thuốc'
		FROM BENH_AN ba, NHA_SI ns, KHACH_HANG kh
		WHERE ns.ID_NS = @ID_NS and ba.ID_NS = @ID_NS and ba.ID_KH = kh.ID_KH 
	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH

--xem hồ sơ bệnh án cho SDT khách hàng 
GO
drop proc ns_xemBAKH
GO
CREATE PROCEDURE ns_xemBAKH
	@SDT INT,
	@ID_NS INT
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		SELECT ba.ID_BenhAn as 'ID_BA', ba.NgayKham 'Ngày khám', kh.HoTen 'Khách hàng', ns.HoTen 'Nha sĩ', ba.DichVu 'Dịch vụ', ba.Thuoc 'Thuốc'
		FROM BENH_AN ba, NHA_SI ns, KHACH_HANG kh
		WHERE kh.SDT = @SDT and ba.ID_KH = kh.ID_KH and ba.ID_NS = ns.ID_NS and ns.ID_NS = @ID_NS
	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH

--tạo hồ sơ bệnh án
GO
drop proc ns_taoBA
GO
CREATE PROCEDURE ns_taoBA
	@ID_NS INT,
	@SDT NVARCHAR (50),
	@NgayKham DATE,
	@DichVu NVARCHAR (999),
	@Thuoc NVARCHAR (999)
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL REPEATABLE READ;
		IF NOT EXISTS (SELECT 1 FROM KHACH_HANG kh WHERE kh.SDT = @SDT)
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'Can not find customer infomation!', 1;
		END

		WAITFOR DELAY '00:00:10'
		
		DECLARE @ID_KH INT;
		SET @ID_KH = (SELECT ID_KH FROM KHACH_HANG kh WHERE kh.SDT = @SDT)

		INSERT INTO BENH_AN WITH (XLOCK) (NgayKham, ID_KH, ID_NS, DichVu, Thuoc)
		VALUES (@NgayKham, @ID_KH, @ID_NS, @DichVu, @Thuoc);

	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH

--Cập nhật hồ sơ bệnh án
GO
drop proc ns_capnhatBA
GO
CREATE PROCEDURE ns_capnhatBA
	@ID_BA INT,
	@ID_NS INT,
	@DichVu NVARCHAR (999),
	@NgayKham DATE,
	@Thuoc NVARCHAR (50)
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		UPDATE BENH_AN WITH (XLOCK)
		SET DichVu = @DichVu, Thuoc = @Thuoc, NgayKham = @NgayKham
		WHERE ID_BenhAn = @ID_BA and ID_NS = @ID_NS;
	COMMIT TRAN
END TRY
BEGIN CATCH
    ROLLBACK TRAN;
    THROW;
END CATCH

--Xem lịch hẹn nha sĩ
GO
drop proc ns_xemLH
GO
CREATE PROCEDURE ns_xemLH
	@ID_NS INT
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		SELECT lns.NGAY_KHAM as 'Ngày khám', lns.GIO_KHAM as 'Giờ khám', COALESCE(lh.ID_KH, NULL) AS 'Mã khách hẹn'
		FROM LICH_NHA_SI lns LEFT JOIN LICH_HEN lh ON lh.ID_NS = lns.ID_NS and lh.GioKham = LNS.GIO_KHAM and lh.NgayKham = lns.NGAY_KHAM
		WHERE lns.ID_NS = @ID_NS
	COMMIT TRAN
END TRY
BEGIN CATCH
    ROLLBACK TRAN;
    THROW;
END CATCH

--Sửa lịch hẹn nha sĩ
GO
drop proc ns_suaLH
GO
CREATE PROCEDURE ns_suaLH
	@ID_NS INT,
	@NgayKhamCu DATE,
	@GioKhamCu TIME(7),
	@NgayKham DATE,
	@GioKham TIME(7)
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		IF NOT EXISTS (SELECT 1 FROM LICH_NHA_SI LNS with (XLOCK) WHERE LNS.ID_NS = @ID_NS and NGAY_KHAM = @NgayKhamCu and GIO_KHAM = @GioKhamCu)
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'Dentish do not have this schedule, can not edit!', 1;
		END
		IF EXISTS (SELECT 1 FROM LICH_HEN WHERE ID_NS = @ID_NS and NgayKham = @NgayKham and GioKham = @GioKham)
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'Dentish already have this schedule as an appointment with customer, can not add an edit!', 1;
		END

		WAITFOR DELAY '00:00:05'

		UPDATE LICH_NHA_SI
		SET NGAY_KHAM = @NgayKham, GIO_KHAM = @GioKham
		WHERE ID_NS = @ID_NS and NGAY_KHAM = @NgayKhamCu and GIO_KHAM = @GioKhamCu;

	COMMIT TRAN
END TRY
BEGIN CATCH
    ROLLBACK TRAN;
    THROW;
END CATCH

--Thêm lịch hẹn nha sĩ
GO
drop proc ns_themLH
GO
CREATE PROCEDURE ns_themLH
	@ID_NS INT,
	@NgayKham DATE,
	@GioKham TIME(7)
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		IF EXISTS (SELECT * FROM LICH_NHA_SI WHERE ID_NS = @ID_NS and NGAY_KHAM = @NgayKham and GIO_KHAM = @GioKham)
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'Dentish already have this schedule!', 1;
		END
		ELSE
		BEGIN
			INSERT INTO LICH_NHA_SI WITH (XLOCK) (ID_NS, NGAY_KHAM, GIO_KHAM)
			VALUES (@ID_NS, @NgayKham, @GioKham);
		END

	COMMIT TRAN
END TRY
BEGIN CATCH
    ROLLBACK TRAN;
    THROW;
END CATCH

/***NHÂN VIÊN***/
-- Xem tất cả lịch hẹn đã được đặt
GO
CREATE PROCEDURE nv_xemLHdadat
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		SELECT lh.ID_LH 'Mã số', kh.HoTen 'Khách hàng', ns.HoTen 'Nha sĩ', lh.NgayKham 'Ngày khám', lh.GioKham 'Giờ khám' 
		FROM LICH_HEN lh, KHACH_HANG kh, NHA_SI ns
		WHERE lh.ID_KH = kh.ID_KH and lh.ID_NS = ns.ID_NS
	COMMIT TRAN
END TRY
BEGIN CATCH
    ROLLBACK TRAN;
    THROW;
END CATCH

--Xem lịch hẹn có thể đặt cho khách
GO
CREATE PROCEDURE nv_xemLH
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		SELECT ns.ID_NS as 'ID Nha sĩ', ns.HoTen as 'Nha sĩ', lns.NGAY_KHAM as 'Ngày khám', lns.GIO_KHAM as 'Giờ khám'
		FROM
		  NHA_SI ns
		  INNER JOIN LICH_NHA_SI lns ON ns.ID_NS = lns.ID_NS
		WHERE NOT EXISTS (SELECT * FROM LICH_HEN WHERE ID_NS = lns.ID_NS AND NgayKham = lns.NGAY_KHAM AND GioKham = lns.GIO_KHAM )
	COMMIT TRAN
END TRY
BEGIN CATCH
    ROLLBACK TRAN;
    THROW;
END CATCH

--Đăng kí khám cho khách
GO
drop proc nv_datLH
GO
CREATE PROCEDURE nv_datLH
	@ID_NV_LAP INT,
	@ID_KH int,
	@date DATE,
	@time TIME(7),
	@ID_NS INT
AS
BEGIN TRY
	BEGIN TRAN
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
	IF EXISTS (SELECT * FROM LICH_HEN WHERE NgayKham = @date and GioKham = @time and ID_NS = @ID_NS)
		BEGIN
				ROLLBACK TRAN;
				THROW 50001, 'Already have an appointment with matched information!', 1;
				RETURN;
		END
	ELSE
		BEGIN
			INSERT INTO LICH_HEN WITH (XLOCK) (NgayKham, GioKham, ID_KH, ID_NS)
			VALUES (@date, @time, @ID_KH, @ID_NS);
		END
	COMMIT TRAN
END TRY
BEGIN CATCH
    ROLLBACK TRAN;
    THROW;
END CATCH

--Xem thông tin thuốc
GO
CREATE PROCEDURE nv_xemThuoc
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		SELECT ID_Thuoc, TenThuoc, DonViTinh, ChiDinh, SoLuongTon, DonGiaThuoc, NgayHetHan 
		FROM THUOC WITH (ROWLOCK)
	COMMIT TRAN
END TRY
BEGIN CATCH
    ROLLBACK TRAN;
    THROW;
END CATCH		

--xem hồ sơ bệnh án (để tạo hóa đơn)
GO
CREATE PROCEDURE nv_xemBA
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		SELECT ba.NgayKham 'Ngày khám', kh.HoTen 'Khách hàng', ns.HoTen 'Nha sĩ', ba.DichVu 'Dịch vụ', ba.Thuoc 'Thuốc'
		FROM BENH_AN ba, NHA_SI ns, KHACH_HANG kh
		WHERE kh.ID_KH = ba.ID_KH and ba.ID_NS = ns.ID_NS
	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH
--xem hồ sơ bệnh án cho SDT khách hàng 
GO
CREATE PROCEDURE nv_xemBAKH
	@SDT INT
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		SELECT ba.NgayKham 'Ngày khám', kh.HoTen 'Khách hàng', ns.HoTen 'Nha sĩ', ba.DichVu 'Dịch vụ', ba.Thuoc 'Thuốc'
		FROM BENH_AN ba, NHA_SI ns, KHACH_HANG kh
		WHERE kh.SDT = @SDT and ba.ID_KH = kh.ID_KH and ba.ID_NS = ns.ID_NS
	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH
-- xem giá dịch vụ và thuốc
GO
CREATE PROCEDURE nv_xemGia
    @Ten NVARCHAR(999),
    @Loai NVARCHAR(50), -- 'THUOC' hoặc 'DICHVU'
	@Gia DECIMAL(10, 2) OUTPUT
AS
BEGIN TRY
    BEGIN TRAN
        SET TRANSACTION ISOLATION LEVEL READ COMMITTED;

        IF @Loai = 'THUOC'
        BEGIN
            SET @Gia = (SELECT DonGiaThuoc
            FROM THUOC WITH (ROWLOCK)
            WHERE TenThuoc = @Ten);
        END
        ELSE IF @Loai = 'DICHVU'
        BEGIN
            SET @Gia = (SELECT DonGia
            FROM DICH_VU WITH (ROWLOCK)
            WHERE TenDichVu = @Ten);
        END
        ELSE
        BEGIN
			ROLLBACK TRAN;
            THROW 50001, 'Loại không hợp lệ.', 1;
        END
    COMMIT TRAN
END TRY
BEGIN CATCH
    ROLLBACK TRAN;
    THROW;
END CATCH

/***QUẢN TRỊ VIÊN***/
--Thêm tài khoản 
GO
drop proc qtv_ThemTk
GO
CREATE PROCEDURE qtv_ThemTK
      @HoTen NVARCHAR(999),
      @NgaySinh DATE,
      @DiaChi NVARCHAR(999),
      @SDT VARCHAR(10),
      @Role NVARCHAR(2),
      @Password VARCHAR(50),
	  @ID_QTV INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
			SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
			-- Kiểm tra tài khoản tồn tại
			IF NOT EXISTS (SELECT 1 FROM TAI_KHOAN WHERE TenTK = @SDT)
			BEGIN
				IF @Role = 'KH'
					BEGIN
					INSERT INTO KHACH_HANG WITH (XLOCK) (SDT, MatKhau, HoTen, NgaySinh, DiaChi, ID_QuanTriVien)
					VALUES (@SDT, @password, @HoTen, @NgaySinh, @DiaChi, @ID_QTV )
					END
				ELSE IF @Role = 'NS'
					BEGIN
					INSERT INTO NHA_SI WITH (XLOCK) (SDT, MatKhau, HoTen, NgaySinh, DiaChi, ID_QuanTriVien)
					VALUES (@SDT, @password, @HoTen, @NgaySinh, @DiaChi, @ID_QTV);
					END
				ELSE IF @Role = 'NV'
					BEGIN
					INSERT INTO NHAN_VIEN WITH (XLOCK) (SDT, MatKhau, HoTen, NgaySinh, DiaChi, ID_QuanTriVien)
					VALUES (@SDT, @password, @HoTen, @NgaySinh, @DiaChi, @ID_QTV);
					END
				ELSE 
					BEGIN
						ROLLBACK TRAN;
						THROW 50001, 'Role not exist.', 1;
					END

				INSERT INTO TAI_KHOAN WITH (XLOCK) (TenTK, MatKhau, LoaiTK) 
				VALUES (@SDT, @password, @Role);

				WAITFOR DELAY '00:00:10'

				IF EXISTS (SELECT SDT, COUNT(*) FROM KHACH_HANG GROUP BY SDT HAVING COUNT(*) >= 2)
				BEGIN
						ROLLBACK TRAN;
						THROW 50001, 'Exist at least two Customer with the same phone number.', 1;
				END
				
				COMMIT TRAN;
			END
			ELSE
			BEGIN
				-- Username is already taken
				ROLLBACK TRAN;
				THROW 50002, 'Username is already taken.', 1;
			END
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN;
        THROW;
    END CATCH
END
-- Xem tài khoản QTV quản lý
GO
CREATE PROCEDURE qtv_XemTK
	@ID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		IF EXISTS (SELECT 1 FROM QUAN_TRI_VIEN WHERE @ID = ID_QuanTriVien)
		BEGIN
			SELECT kh.ID_KH as 'ID', kh.HoTen as 'Họ tên', tk.LoaiTK as 'Vai trò', tk.TRANG_THAI_KHOA as 'Đã khóa' 
			FROM KHACH_HANG kh, TAI_KHOAN tk
			WHERE kh.ID_QuanTriVien = @ID and kh.SDT = tk.TenTK
			UNION
			SELECT ns.ID_NS as 'ID', ns.HoTen as 'Họ tên', tk.LoaiTK as 'Vai trò', tk.TRANG_THAI_KHOA as 'Đã khóa' 
			FROM NHA_SI ns, TAI_KHOAN tk
			WHERE ns.ID_QuanTriVien = @ID and ns.SDT = tk.TenTK
			UNION
			SELECT nv.ID_NV as 'ID', nv.HoTen as 'Họ tên', tk.LoaiTK as 'Vai trò', tk.TRANG_THAI_KHOA as 'Đã khóa' 
			FROM NHAN_VIEN nv, TAI_KHOAN tk
			WHERE nv.ID_QuanTriVien = @ID and nv.SDT = tk.TenTK
			ORDER BY 'Vai trò'
			COMMIT TRAN;
		END
		ELSE
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'There is no QTV with that ID.', 1;
		END
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN;
        THROW;
    END CATCH
END

-- Vô hiệu hóa tài khỏan
GO
drop proc qtv_KhoaTK
GO
CREATE PROCEDURE qtv_KhoaTK
	@ID INT,
	@Role NVARCHAR(2)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		DECLARE @khoa int = 0;
		DECLARE @TenTK NVARCHAR(10);

		IF @Role = 'NV'
		BEGIN
			SET @TenTK = (SELECT SDT FROM NHAN_VIEN WHERE ID_NV = @ID)
		END
		ELSE IF @Role = 'NS'
		BEGIN
			SET @TenTK = (SELECT SDT FROM NHA_SI WHERE ID_NS = @ID)
		END
		ELSE IF @Role = 'KH'
		BEGIN
			SET @TenTK = (SELECT SDT FROM KHACH_HANG WHERE ID_KH = @ID)
		END
		ELSE
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'Role not exist', 1;
			RETURN;
		END

		IF NOT EXISTS (SELECT 1 FROM TAI_KHOAN tk WHERE @TenTK  = TenTK)
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'This account not exist', 1;
			RETURN;
		END
		
		SET @khoa = (SELECT TRANG_THAI_KHOA FROM TAI_KHOAN WHERE TenTK = @TenTK AND LoaiTK = @ROLE);
		IF (@khoa = 1)
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'This account have been locked before.', 1;
		END

		UPDATE TAI_KHOAN WITH (XLOCK)
		SET TRANG_THAI_KHOA = 1
		WHERE TenTK = @TenTK;

		WAITFOR DELAY '00:00:10'

		IF NOT EXISTS (SELECT tenTK FROM TAI_KHOAN WHERE LoaiTK = 'NV' AND TRANG_THAI_KHOA = 0)
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'You should manage at least one staff.', 1;
		END

        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN;
        THROW;
    END CATCH
END

-- Thêm thuốc vào kho
GO
drop proc qtv_ThemThuoc
GO
CREATE PROCEDURE qtv_ThemThuoc
    @TenThuoc NVARCHAR(999),
    @DonViTinh NVARCHAR(20),
    @ChiDinh NVARCHAR(999),
    @SoLuongTon INT,
    @DonGiaThuoc DECIMAL(10, 2),
    @NgayHetHan DATE
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		IF EXISTS (SELECT 1 FROM THUOC WHERE TenThuoc = @TenThuoc)
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'Inventory already have this medicine.', 1;
		END

        INSERT INTO THUOC WITH (XLOCK) (TenThuoc, DonViTinh, ChiDinh, SoLuongTon, DonGiaThuoc, NgayHetHan)
        VALUES (@TenThuoc, @DonViTinh, @ChiDinh, @SoLuongTon, @DonGiaThuoc, @NgayHetHan);

		WAITFOR DELAY '00:00:10' 

		IF EXISTS (SELECT SoLuongTon, COUNT(*)
			FROM THUOC
			WHERE SoLuongTon = 1
			GROUP BY SoLuongTon
			HAVING COUNT(*) > 1)
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'Inventory should not have a medicine with 1 quantity.', 1;
		END

        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN;
        THROW;
    END CATCH
END
 
-- Xoa Thuoc da het han
GO
drop proc qtv_XoaThuocHetHan
GO 
CREATE PROCEDURE qtv_XoaThuocHetHan
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		IF NOT EXISTS (SELECT * FROM THUOC WHERE NgayHetHan <= GETDATE())
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'There is no medicine outdated.', 1;
		END
        DELETE FROM THUOC WITH (XLOCK)
        WHERE NgayHetHan <= GETDATE();
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN;
        THROW;
    END CATCH
END
-- Xem Thuốc
GO
CREATE PROCEDURE qtv_xemThuoc
AS
BEGIN TRY
	BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
		SELECT ID_Thuoc, TenThuoc, DonViTinh, ChiDinh, SoLuongTon, DonGiaThuoc, NgayHetHan 
		FROM THUOC
	COMMIT TRAN
END TRY
BEGIN CATCH
    ROLLBACK TRAN;
    THROW;
END CATCH

-- Cập nhật số lượng thuốc
GO
drop proc qtv_UpdateSLThuoc
GO
CREATE PROCEDURE qtv_UpdateSLThuoc
    @ID_Thuoc INT,
    @SoLuong INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
		SET TRANSACTION ISOLATION LEVEL REPEATABLE READ;

		IF NOT EXISTS (SELECT 1 FROM THUOC WHERE THUOC.ID_Thuoc = @ID_Thuoc)
		BEGIN
			ROLLBACK TRAN;
			THROW 50001, 'There is no medicine with matched ID.', 1;
		END

		WAITFOR DELAY '00:00:10' -- nếu xin khóa không được

        UPDATE THUOC WITH (XLOCK)
        SET SoLuongTon = @SoLuong
        WHERE ID_Thuoc = @ID_Thuoc;

        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN;
        THROW;
    END CATCH
END