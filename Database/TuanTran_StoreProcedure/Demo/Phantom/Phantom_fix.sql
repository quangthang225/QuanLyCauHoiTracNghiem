ALTER PROCEDURE sp_LayDanhSachCauHoiTheoDeThi_DEMO
@MABDT bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
		BEGIN TRAN
			DECLARE @slCauHoi INT
			SELECT @slCauHoi = COUNT(*) FROM TAOBODETHI WHERE MABDT = @MABDT
			IF ( @slCauHoi < 0  )
				SET @Return = N'Bộ đề thi chưa có bất câu hỏi nào'
			IF @Return = '' OR @Return is null
			BEGIN
				WAITFOR DELAY '00:00:05'
				SELECT c.*
				FROM TAOBODETHI t , CAUHOI c 
				WHERE t.MABDT = @MABDT AND t.MACH = c.MACH
			END
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO

CREATE PROCEDURE sp_ThemCauHoiVaoBoDeThi_DEMO
@MABDT bigint,
@MACH bigint,
@Diem float,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			-- Kiểm tra tồn tại @MaBDT
			IF NOT EXISTS ( SELECT * FROM BODETHI WHERE @MABDT = MABDT )
			BEGIN
				SET @Return = N'Không tồn tại bộ đề thi này'
			END

			-- Kiểm tra tồn tại @MACH
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @MACH = MACH  )
			BEGIN
				SET @Return = N'Không tồn tại câu hỏi này'
			END

			IF @Return is null or  @Return = '' 
			BEGIN
				--Kiểm tra bộ đề thi đã tồn tại câu hỏi này
				IF EXISTS ( SELECT * FROM TAOBODETHI WHERE @MABDT = MABDT AND @MACH = MACH )
				BEGIN
					SET @Return = N'Bộ đề thi đã có câu hỏi này'
				END 
				ELSE
				BEGIN
					INSERT INTO TAOBODETHI(MABDT,MACH,DIEM) VALUES(@MABDT,@MACH,@DIEM)
				END
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO

