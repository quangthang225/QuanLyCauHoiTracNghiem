CREATE PROCEDURE sp_XoaCauHoiTrongBodeThi
@MACH bigint,
@MABDT bigint,
@Return bit out
AS
BEGIN
	BEGIN TRY
			-- Kiểm tra tồn tại câu hỏi có trong bộ đề thi
			IF NOT EXISTS ( SELECT * FROM TAOBODETHI WHERE @MABDT = MABDT AND @MACH = MACH )
			BEGIN
				SET @Return = 0
				RETURN
			END

			-- Xóa câu hỏi trong bộ đề thi
			DELETE FROM TAOBODETHI WHERE MABDT = @MABDT AND MACH = @MACH
			SET @Return = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @Return = 0
		END CATCH
END
GO