﻿ALTER PROCEDURE sp_CapNhatCauHoi
@MACH bigint,
@NOIDUNG nvarchar(max),
@THANGDIEM float,
@MUCDO int,
@MAMH bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			-- Kiểm tra tồn tại câu hỏi
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE MACH = @MACH )
				SET @Return = N'Không tồn tại câu hỏi này'

			-- Kiểm tra có cập nhật môn học cho câu hỏi hay ko
			DECLARE @MAMHtemp BIGINT
			SELECT @MAMHtemp = MAMH FROM CAUHOI WHERE MACH = @MACH
			IF ( @MAMHtemp != @MAMH )
			BEGIN
				IF EXISTS ( SELECT * FROM CAUTRALOI WHERE MACH = @MACH )
					SET @Return = N'Không thể cập nhật môn học cho câu hỏi này vì câu hỏi đang có câu trả lời'
				ELSE
				BEGIN
					UPDATE CAUHOI SET NOIDUNG = @NOIDUNG, THANGDIEM = @THANGDIEM, MUCDO = @MUCDO, MAMH = @MAMH WHERE MACH = @MACH
					SET @Return = ''
				END
			END
			ELSE
			BEGIN
				IF @Return = '' OR @Return is null
				BEGIN
					UPDATE CAUHOI SET NOIDUNG = @NOIDUNG, THANGDIEM = @THANGDIEM, MUCDO = @MUCDO 
					WHERE MACH = @MACH
					SET @Return = ''
				END
				ELSE
					SET @Return = N'Dữ liệu không hợp lệ'
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO