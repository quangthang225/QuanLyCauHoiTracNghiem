CREATE
--ALTER 
PROCEDURE sp_ThemCauTraLoiVaoCauHoi_DEMO
@NOIDUNG nvarchar(max),
@LADAPANDUNG bit,
@MACH bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
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
				INSERT INTO CAUTRALOI(NOIDUNG,LADAPANDUNG,MACH) VALUES(@NOIDUNG,@LADAPANDUNG,@MACH)
				UPDATE CAUHOI SET SOCAUTRALOI = SOCAUTRALOI + 1
				SET @Return = ''
			END						---Cố tình gây lỗi số lượng câu trả lời của câu hỏi > 10---			WAITFOR DELAY '00:00:05'			INSERT INTO CAUTRALOI(NOIDUNG,LADAPANDUNG,MACH) VALUES(@NOIDUNG,@LADAPANDUNG,@MACH)			-----------------------------------------------------------		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO


CREATE
--ALTER 
PROCEDURE sp_LayDanhSachCauTraLoiTheoCauHoi_DEMO
@MACH bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
		BEGIN TRAN
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @MACH = MACH )
			BEGIN
				SET @Return = N'Không tồn tại câu hỏi này'
			END

			SELECT * FROM CAUTRALOI WHERE MACH = @MACH
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO