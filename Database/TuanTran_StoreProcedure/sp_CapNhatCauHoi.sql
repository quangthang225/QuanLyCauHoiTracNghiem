CREATE PROCEDURE sp_CapNhatCauTraLoi
@MACTL bigint,
@NOIDUNG nvarchar(max),
@LADAPANDUNG bit,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @validateInput BIT
			SET @validateInput = 1
			
			-- Kiểm tra tồn tại câu trả lời cần cập nhật
			IF NOT EXISTS ( SELECT * FROM CAUTRALOI WHERE MACTL = @MACTL )
				SET @validateInput = 0

			IF @validateInput = 1
			BEGIN
				UPDATE CAUTRALOI SET NOIDUNG = @NOIDUNG, LADAPANDUNG = @LADAPANDUNG WHERE MACTL = @MACTL
				SET @Return = ''
			END
			ELSE
				SET @Return = 'Dữ liệu không hợp lệ'
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO