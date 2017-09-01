ALTER PROCEDURE sp_CapNhatCauTraLoiSangCauHoiKhac_DEMO
@MACTL bigint,
@MACH bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN		
			-- Kiểm tra tồn tại CTL  
			--IF NOT EXISTS ( SELECT * FROM CAUTRALOI WHERE MACTL = @MACTL)
			--	SET @Return = N'Không tồn tại câu trả lời này'

			-- Kiểm tra tồn tại MACH
			--IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @MACH = MACH  )
			--	SET @Return = N'Không tồn tại câu câu hỏi này'

			DECLARE @MACHold BIGINT
			SELECT @MACHold = MACH FROM CAUTRALOI WHERE MACTL = @MACTL
			
				--Cập nhật số lượng CTL của CAUHOI cũ
				UPDATE CAUHOI SET SOCAUTRALOI = SOCAUTRALOI - 1 WHERE MACH = @MACHold
				--Cập nhật CAUTRALOI
				UPDATE CAUTRALOI SET MACH = @MACH WHERE MACTL = @MACTL
				
				WAITFOR DELAY '00:00:05'
				
				--Cập nhật số lượng CTL của CAUHOI mới
				UPDATE CAUHOI SET SOCAUTRALOI = SOCAUTRALOI + 1 WHERE MACH = @MACH
			
			COMMIT TRAN
	END TRY
	BEGIN CATCH
		IF ( ERROR_NUMBER() = 1205 )
		BEGIN
			SET @Return = N'Xuất hiện lỗi, đã xảy ra deadlock'
		END
		ROLLBACK TRAN
	END CATCH
END
GO

ALTER PROCEDURE sp_XoaCauTraLoiTheoCauHoi_DEMO
@MACTL bigint,
@MACH bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
				--Cập nhật số lượng CTL của CAUHOI
				UPDATE CAUHOI SET SOCAUTRALOI = SOCAUTRALOI - 1 WHERE MACH = 1

				WAITFOR DELAY '00:00:05'

				-- Xóa câu trả lời
				DELETE FROM CAUTRALOI WHERE MACTL = @MACTL
				SET @Return = 'Thành công'
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		IF ( ERROR_NUMBER() = 1205 )
		BEGIN
			SET @Return = ERROR_MESSAGE()
		END
		ROLLBACK TRAN
	END CATCH
END
GO