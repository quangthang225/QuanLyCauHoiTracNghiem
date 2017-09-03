CREATE PROC sp_Soluongcauhoicuabomon 
@Mamonhoc bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
		BEGIN TRAN
			DECLARE @slch INT
			SELECT @slch = COUNT(*) FROM CAUHOI c WHERE c.MAMH =  @Mamonhoc
			IF ( @slch < 1  )
				SET @Return = N'Mon hoc nay chua co cau hoi nao'
			IF @Return = '' OR @Return is null
			BEGIN
				WAITFOR DELAY '00:00:05'
				SELECT COUNT(*) FROM CAUHOI c WHERE c.MAMH =  @Mamonhoc
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END

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