CREATE PROC sp_Soluongcautraloicuacauhoi 
@Macauhoi bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		SET TRAN ISOLATION LEVEL REPEATABLE READ
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
				SELECT SOCAUTRALOI FROM CAUHOI c WHERE c.MACH =  @Macauhoi
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END

CREATE PROC sp_CapNhatSoLuongCauHoi
	@Macauhoi bigint,
	@Socautraloi int,
	@Thangdiemdukien float,
	@Mucdo int,
	@Return nvarchar(500) out
	AS 
	BEGIN TRAN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM CAUHOI WHERE [MACH] = @Macauhoi)
			BEGIN
				SET @Return = N'MA CAU HOI KHONG TON TAI'
			END
			BEGIN
				UPDATE [CAUHOI] SET SOCAUTRALOI = @Socautraloi, THANGDIEM = @Thangdiemdukien , MUCDO = @Mucdo  WHERE [MACH] = @Macauhoi
				SET @Return = '';
			END	
		END TRY
		BEGIN CATCH
			SET @Return = N'LOI HE THONG'
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
GO