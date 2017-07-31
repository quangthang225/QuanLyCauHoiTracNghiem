CREATE PROCEDURE sp_TimKiemTatCaCauHoiTheoBoDeThi
@MABDT bigint,
@return bit output
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			--Kiểm tra mã bộ đề thi input có tồn tại hay không
			IF NOT EXISTS ( SELECT * FROM BODETHI WHERE MABDT = @MABDT )
			BEGIN
				SET @return = 0
				RETURN
			END 

			SELECT *
			FROM TAOBODETHI
			WHERE MABDT = @MABDT
			SET @return = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @return = 0
		END CATCH
	COMMIT TRAN
END
GO