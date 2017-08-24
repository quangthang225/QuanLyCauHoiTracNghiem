ALTER PROCEDURE sp_ThemCauHoiVaoBoDeThi
@MABDT bigint,
@MACH bigint,
@Diem float,
@Return bit out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @validateInput BIT
			SET @validateInput = 1
			-- Kiểm tra tồn tại @MaBDT
			IF NOT EXISTS ( SELECT * FROM BODETHI WHERE @MABDT = MABDT )
			BEGIN
				SET @validateInput = 0
			END

			-- Kiểm tra tồn tại @MACH
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @MACH = MACH  )
			BEGIN
				SET @validateInput = 0
			END

			IF @validateInput = 1 
			BEGIN
				--Kiểm tra bộ đề thi đã tồn tại câu hỏi này
				IF EXISTS ( SELECT * FROM TAOBODETHI WHERE @MABDT = MABDT AND @MACH = MACH )
				BEGIN
					SET @Return = 0
				END 
				ELSE
				BEGIN
					INSERT INTO TAOBODETHI(MABDT,MACH,DIEM) VALUES(@MABDT,@MACH,@DIEM)
					SET @Return = 1
				END
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

