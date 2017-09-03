CREATE PROC sp_TaoTaiKhoan
@HoTen nvarchar(255),
@TenDangNhap varchar(30),
@MatKhau varchar(30),
@TrangThai bit,
@ToanQuyenGV bit,
@MaLoai bigint,
@MaBM bigint,
@MaGVQL bigint
AS 
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM LOAINGUOIDUNG WHERE [MALOAI] = @MaLoai)
			BEGIN
				PRINT N'MA LOAI NGUOI DUNG KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 1
			END
		IF NOT EXISTS(SELECT * FROM BOMON WHERE [MABM] = @MaBM)
			BEGIN
				PRINT N'MA BO MON KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 2
			END
		IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaGVQL)
			BEGIN
				PRINT N'MA GIAO VIEN QUAN LY KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 3
			END
		INSERT INTO [NGUOIDUNG] 
				([HOTEN],
				[TENDANGNHAP],
				[MATKHAU],
				[TRANGTHAI],
				[TOANQUYENGV],
				[MALOAI],
				[MABM],
				[MAGVQL])
		VALUES (@HoTen,
				@TenDangNhap,
				@MatKhau,
				@TrangThai,
				@ToanQuyenGV,
				@MaLoai,
				@MaBM,
				@MaGVQL)
	END TRY
	BEGIN CATCH
		PRINT N'LOI HE THONG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0
GO

CREATE PROC sp_XoaBoMon
@MaBM bigint
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM BOMON WHERE [MABM] = @MaBM)
			BEGIN
				PRINT N'MA BO MON KHONG TON TAI'
				RETURN 1
			END
		DELETE BOMON WHERE [MABM] = @MaBM
	END TRY
	BEGIN CATCH
		PRINT N'LOI HE THONG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0
GO