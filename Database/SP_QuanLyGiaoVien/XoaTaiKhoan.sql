﻿CREATE PROC sp_XoaTaiKhoan
@MaND bigint
AS
BEGIN
IF EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaND)
	BEGIN
		DELETE [NGUOIDUNG] WHERE [MAND] = @MaND
		RETURN 0
	END
ELSE
	BEGIN
		PRINT N'MA NGUOI DUNG KHONG TON TAI'
		RETURN 1
	END
END
GO