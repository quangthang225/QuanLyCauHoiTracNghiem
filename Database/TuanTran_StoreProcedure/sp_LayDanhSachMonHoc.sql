﻿CREATE PROCEDURE sp_LayDanhSachMonHoc
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM MONHOC
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO