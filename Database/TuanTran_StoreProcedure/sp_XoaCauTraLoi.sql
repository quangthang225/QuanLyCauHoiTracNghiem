CREATE PROCEDURE sp_XoaCauTraLoi
@MACTL bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @validateInput BIT = 1
			-- Kiểm tra tồn tại câu trả lời cần xóa
			IF NOT EXISTS ( SELECT * FROM CAUTRALOI WHERE MACTL = @MACTL )
			BEGIN
				SET @validateInput = 0
				RETURN
			END

			IF @validateInput = 1
			BEGIN
				-- Xóa câu trả lời
				DELETE FROM CAUTRALOI WHERE MACTL = @MACTL
				SET @Return = ''
			END
			ELSE
			BEGIN
				SET @Return = 'Mã câu trả lời không tòn tại'
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO