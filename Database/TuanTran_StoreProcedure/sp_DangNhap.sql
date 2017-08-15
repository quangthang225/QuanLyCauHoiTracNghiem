CREATE PROCEDURE sp_DangNhap
@tenDangNhap varchar(30),
@matKhau varchar(30),
@maNguoiDung bigint out,
@return bit out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF EXISTS ( SELECT MAND FROM NGUOIDUNG WHERE TENDANGNHAP = @tenDangNhap AND MATKHAU = @matKhau )
			BEGIN
				SET @maNguoiDung = ( SELECT MAND FROM NGUOIDUNG WHERE TENDANGNHAP = @tenDangNhap AND MATKHAU = @matKhau )
				SET @return = 1
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO