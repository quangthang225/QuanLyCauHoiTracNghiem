﻿CREATE PROCEDURE sp_LayDanhSachCauHoi
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT c.*,m.TENMH FROM CAUHOI c,MonHoc m WHERE c.MAMH =m.MAMH
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO