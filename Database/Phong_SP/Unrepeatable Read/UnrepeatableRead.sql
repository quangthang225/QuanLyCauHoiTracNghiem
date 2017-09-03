﻿CREATE PROC sp_LayMonHoc
	@MAMH BIGINT,
	@MABM BIGINT
AS BEGIN
	BEGIN TRAN
		BEGIN TRY
			DECLARE @COUNT INT = (SELECT COUNT(*) FROM MONHOC WHERE MAMH = @MAMH AND MABM = @MABM)
			PRINT 'CO ' + CAST(@COUNT AS VARCHAR(10)) + ' KET QUA.'
		
			WAITFOR DELAY '0:0:10'

			SELECT * FROM MONHOC WHERE MAMH = @MAMH AND MABM = @MABM
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			RETURN 0
		END CATCH
	COMMIT TRAN
END

GO

CREATE PROC sp_CapNhatMonHoc
	@MAMH BIGINT,
	@MABM BIGINT
AS BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF NOT EXISTS (SELECT *
							FROM BOMON
							WHERE MABM = @MABM)
			BEGIN
				ROLLBACK TRAN
				RETURN 0
			END

			UPDATE MONHOC
			SET MABM = @MABM
			WHERE MAMH = @MAMH

		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			RETURN 0
		END CATCH
	COMMIT TRAN
	RETURN 1
END

GO