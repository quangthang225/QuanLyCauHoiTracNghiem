CREATE PROC sp_CapNhatThongTin
@MaND bigint,
@HoTen nvarchar(255),
@TenDangNhap varchar(30),
@ToanQuyenGV bit,
@TrangThai bit,
@MaLoai bigint,
@MaBM bigint,
@MaGVQL bigint,
@Return int out
AS
BEGIN TRAN
	BEGIN TRY
		SET @Return = -1;
		IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaND)
			BEGIN
				PRINT N'MA NGUOI DUNG KHONG TON TAI'
				SET @Return = 1
			END
		ELSE IF NOT EXISTS(SELECT * FROM LOAINGUOIDUNG WHERE [MALOAI] = @MaLoai)
			BEGIN
				PRINT N'MA lOAI NGUOI DUNG KHONG TON TAI'
				SET @Return = 2
			END
		ELSE IF NOT EXISTS(SELECT * FROM BOMON WHERE [MABM] = @MaBM)
			BEGIN
				PRINT N'MA BO MON KHONG TON TAI'
				SET @Return = 3
			END
		IF @Return = -1
			BEGIN
				UPDATE [NGUOIDUNG] SET TENDANGNHAP = @TenDangNhap,HOTEN = @HoTen, TRANGTHAI = @TrangThai, TOANQUYENGV = @ToanQuyenGV, MALOAI = @MaLoai, MABM = @MaBM, MAGVQL = @MaGVQL  WHERE [MAND] = @MaND
				SET @Return = 0;
			END
		--TESTING
		WAITFOR DELAY '00:00:05'
		ROLLBACK TRAN
		RETURN	
	END TRY
	BEGIN CATCH
		PRINT N'LOI HE THONG'
		SET @Return = 4
		ROLLBACK TRAN
	END CATCH
COMMIT TRAN
GO

CREATE PROCEDURE sp_DangNhap
@tenDangNhap varchar(30),
@matKhau varchar(30),
@maNguoiDung bigint out,
@return bit out,
@islocked bit out
AS
BEGIN
	BEGIN TRY
	SET TRAN ISOLATION LEVEL READ UNCOMMITTED
		BEGIN TRAN
			SET @islocked = (SELECT TRANGTHAI FROM NGUOIDUNG WHERE TENDANGNHAP = @tenDangNhap)

			IF @islocked = 0
				BEGIN
					SET @return = 0
				END		

			IF EXISTS ( SELECT MAND FROM NGUOIDUNG WHERE TENDANGNHAP = @tenDangNhap AND MATKHAU = @matKhau)
				BEGIN
					SET @maNguoiDung = ( SELECT MAND FROM NGUOIDUNG WHERE TENDANGNHAP = @tenDangNhap AND MATKHAU = @matKhau )
					SET @return = 1
				END
			ELSE
				BEGIN
					SET @return = 0
				END	
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO