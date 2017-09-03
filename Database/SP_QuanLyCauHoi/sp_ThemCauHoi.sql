CREATE PROC sp_ThemCauHoi
	@Monhoc bigint,
	@Noidung nvarchar(Max),
	@Socautraloi int,
	@Thangdiemdukien float,
	@Mucdo int,
	@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			BEGIN
				BEGIN
					INSERT INTO CAUHOI(MAMH,NOIDUNG,SOCAUTRALOI,THANGDIEM,MUCDO) VALUES(@Monhoc,@Noidung,@Socautraloi,@Thangdiemdukien,@Mucdo)
				END
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO