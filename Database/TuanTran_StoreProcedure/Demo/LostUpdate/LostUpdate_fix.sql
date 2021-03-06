﻿--CREATE
ALTER PROCEDURE sp_ThemCauTraLoiVaoCauHoi_DEMO
@NOIDUNG nvarchar(max),
@LADAPANDUNG bit,
@MACH bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
		BEGIN TRAN
			-- Kiểm tra tồn tại câu hỏi
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE MACH = @MACH )
			BEGIN
				SET @Return = N'Không tồn tại câu hỏi này'
			END

			-- Kiểm tra tồn tại câu trả lời trong câu hỏi này
			IF EXISTS ( SELECT * FROM CAUTRALOI WHERE MACH = @MACH AND NOIDUNG = @NOIDUNG )
			BEGIN
				SET @Return = N'Trong câu hỏi đã tồn tại câu trả lời này'
			END

			IF @Return = '' OR @Return is null
			BEGIN
				WAITFOR DELAY '00:00:10'
				INSERT INTO CAUTRALOI(NOIDUNG,LADAPANDUNG,MACH) VALUES(@NOIDUNG,@LADAPANDUNG,@MACH)
				UPDATE CAUHOI SET SOCAUTRALOI = SOCAUTRALOI + 1 WHERE MACH = @MACH
				SET @Return = ''

				DECLARE @slCauTraLoi INT
				SELECT @slCauTraLoi = SOCAUTRALOI FROM CAUHOI WHERE MACH = @MACH
				PRINT 'So luong cau tra loi co trong cau hoi: ' + Cast(@slCauTraLoi as varchar(10))
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO


ALTER PROCEDURE sp_XoaCauTraLoi_DEMO
@MACTL bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
		BEGIN TRAN
			-- Kiểm tra tồn tại câu trả lời cần xóa
			IF NOT EXISTS ( SELECT * FROM CAUTRALOI WHERE MACTL = @MACTL )
			BEGIN
				SET @Return = N'Không tồn tại câu trả lời này'
			END

			IF @Return = '' OR @Return is null
			BEGIN
				DECLARE @mach INT
				SELECT @mach = MACH FROM CAUTRALOI
				WHERE MACTL = @MACTL

				-- Xóa câu trả lời
				DELETE FROM CAUTRALOI WHERE MACTL = @MACTL
				UPDATE CAUHOI SET SOCAUTRALOI = SOCAUTRALOI - 1 WHERE MACH = @mach

				DECLARE @slCauTraLoi INT
				SELECT @slCauTraLoi = SOCAUTRALOI FROM CAUHOI WHERE MACH = @MACH
				PRINT 'So luong cau tra loi co trong cau hoi: ' + Cast(@slCauTraLoi as varchar(10))
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO

