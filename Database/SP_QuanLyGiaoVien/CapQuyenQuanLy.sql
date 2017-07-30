CREATE PROC sp_CapQuyenQuanLy
@MaND bigint,
@ToanQuyenGV bit
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaND)
			BEGIN
				PRINT N'MA NGUOI DUNG KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 1
			END
		UPDATE [NGUOIDUNG] SET [TOANQUYENGV] = @ToanQuyenGV  WHERE [MAND] = @MaND
	END TRY
	BEGIN CATCH
		PRINT N'LOI HE THONG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0
GO