CREATE PROCEDURE sp_CapNhatCauHoiSangBoDeThiKhac
@MACH bigint,
@MABDTold bigint,
@MABDTnew bigint,
@Return bit out
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			-- Kiểm tra tồn tại @@MABDTold & @MABDTnew
			IF NOT EXISTS ( SELECT * FROM BODETHI WHERE @MABDTold = MABDT AND @MABDTnew = MABDT)
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

			--Kiểm tra bộ đề thi (@MABDTnew) đã tồn tại câu hỏi này
			IF EXISTS ( SELECT * FROM TAOBODETHI WHERE @MABDTnew = MABDT AND @MACH = MACH )
			BEGIN
				SET @Return = 0
				RETURN
			END 
			
			--Cập nhật
			UPDATE TAOBODETHI SET MABDT = @MABDTnew WHERE MACH = @MACH AND MABDT = @MABDTold
			SET @Return = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @return = 0
		END CATCH
	COMMIT TRAN
END
GO