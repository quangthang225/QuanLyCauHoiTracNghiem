CREATE PROC sp_Soluongcauhoicuabomon 
@Mamonhoc bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
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