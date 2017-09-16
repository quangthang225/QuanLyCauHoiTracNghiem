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
				UPDATE CAUHOI SET SOCAUTRALOI = SOCAUTRALOI + 1
				SET @Return = ''
			END
			
			WAITFOR DELAY '00:00:10'
			INSERT INTO CAUTRALOI(NOIDUNG,LADAPANDUNG,MACH) VALUES(@NOIDUNG,@LADAPANDUNG,@MACH)
			-----------------------------------------------------------

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO


CREATE
--ALTER 
PROCEDURE sp_LayDanhSachCauHoi_DEMO
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
		BEGIN TRAN
			IF NOT EXISTS ( SELECT * FROM CAUHOI )
			BEGIN
				print N'Không tồn tại câu hỏi'
			END

			SELECT C.*,M.MAMH,M.TENMH FROM CAUHOI C, MONHOC M WHERE C.MAMH = M.MAMH
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO