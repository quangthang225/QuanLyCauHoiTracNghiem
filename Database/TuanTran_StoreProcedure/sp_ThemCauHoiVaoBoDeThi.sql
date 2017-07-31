CREATE PROCEDURE sp_ThemCauHoiVaoBoDeThi
@MABDT bigint,
@MACH bigint,
@Return bit out
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			-- Kiểm tra tồn tại @MaBDT
			IF NOT EXISTS ( SELECT * FROM BODETHI WHERE @MABDT = MABDT )
			BEGIN
				SET @Return = 0
				RETURN
			END

			-- Kiểm tra tồn tại @MACH
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @MACH = MACH  )
			BEGIN
				SET @Return = 0
				RETURN
			END

			--Kiểm tra bộ đề thi đã tồn tại câu hỏi này
			IF EXISTS ( SELECT * FROM TAOBODETHI WHERE @MABDT = MABDT AND @MACH = MACH )
			BEGIN
				SET @Return = 0
				RETURN
			END 
			
			INSERT INTO TAOBODETHI(MABDT,MACH) VALUES(@MABDT,@MACH)
			SET @Return = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @return = 0
		END CATCH
	COMMIT TRAN
END
GO