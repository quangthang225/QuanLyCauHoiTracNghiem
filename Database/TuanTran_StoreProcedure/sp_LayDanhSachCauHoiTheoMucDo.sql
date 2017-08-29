CREATE PROCEDURE sp_LayDanhSachCauHoiTheoMucDO
@MUCDO int,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF NOT EXISTS( SELECT * FROM CAUHOI )
				SET @Return = N'Hệ thống chưa có bất kỳ câu hỏi nào'
			
			IF @Return = '' OR @Return is null	
			BEGIN
				SELECT c.*,m.TENMH FROM CAUHOI c,MonHoc m WHERE c.MAMH = m.MAMH AND c.MUCDO = @MUCDO
				SET @Return = ''
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE() 
		ROLLBACK TRAN
	END CATCH
END
GO