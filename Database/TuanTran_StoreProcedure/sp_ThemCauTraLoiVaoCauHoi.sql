ALTER PROCEDURE sp_ThemCauTraLoiVaoCauHoi
@NOIDUNG nvarchar(max),
@LADAPANDUNG bit,
@MACH bigint,
@Return bit out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @validateInput BIT
			SET @validateInput = 1
			-- Kiểm tra tồn tại câu hỏi
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @MACH = MACH )
			BEGIN
				SET @validateInput = 0
			END

			IF @validateInput = 1 
			BEGIN
				
				INSERT INTO CAUTRALOI(NOIDUNG,LADAPANDUNG,MACH) VALUES(@NOIDUNG,@LADAPANDUNG,@MACH)
				SET @Return = 1
				
			END
			ELSE
			BEGIN
				SET @Return = 0	
			END		
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO

