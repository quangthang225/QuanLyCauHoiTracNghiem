CREATE PROC sp_ThayDoiGVQL
@MaND bigint,
@MaGVQL bit
AS
BEGIN
IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaND)
	BEGIN
		PRINT N'MA NGUOI DUNG KHONG TON TAI'
		RETURN 1
	END
ELSE IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAGVQL] = @MaGVQL)
	BEGIN
		PRINT N'MA GVQL KHONG TON TAI'
		RETURN 2
	END
ELSE
	BEGIN
		UPDATE [NGUOIDUNG] SET MAGVQL = @MaGVQL  WHERE [MAND] = @MaND
		RETURN 0
	END
END
GO