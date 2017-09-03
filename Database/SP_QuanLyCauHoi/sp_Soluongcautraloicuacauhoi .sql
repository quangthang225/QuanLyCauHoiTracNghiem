CREATE PROC sp_Soluongcautraloicuacauhoi 
@Macauhoi bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF NOT EXISTS(SELECT * FROM CAUHOI WHERE [MACH] = @Macauhoi)
			BEGIN
				PRINT N'MA CAU HOI KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 1
			END
			IF @Return = '' OR @Return is null
			BEGIN
				WAITFOR DELAY '00:00:05'
				SELECT SOCAUTRALOI FROM CAUHOI c WHERE c.MAMH =  @Macauhoi
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END