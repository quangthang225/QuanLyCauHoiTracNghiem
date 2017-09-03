CREATE PROC sp_ThayDoiMonHoc
@Macauhoi bigint,
@Monhoc bigint,
@Return nvarchar(500) out
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM CAUHOI WHERE [MACH] = @Macauhoi)
			BEGIN
				SET @Return = N'MA CAU HOI KHONG TON TAI'
			END
		ELSE IF NOT EXISTS(SELECT * FROM MONHOC WHERE [MAMH] = @Monhoc)
			BEGIN
				SET @Return = N'MA MON HOC KHONG TON TAI'
			END
		UPDATE [CAUHOI] SET MAMH = @Monhoc  WHERE [MACH] = @Macauhoi
		SET @Return = ''
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SET @Return = N'LOI HE THONG'
	END CATCH
COMMIT TRAN
GO