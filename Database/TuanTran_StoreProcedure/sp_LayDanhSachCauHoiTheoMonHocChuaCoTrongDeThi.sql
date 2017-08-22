CREATE PROCEDURE sp_LayDanhSachCauHoiTheoMonHocChuaCoTrongDeThi
@MAMH bigint,
@MADT bigint
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT *
			FROM CAUHOI
			WHERE MAMH = @MAMH
			EXCEPT
			SELECT c.*
			FROM TAOBODETHI t , CAUHOI c 
			WHERE t.MABDT = 2 AND t.MACH = c.MACH
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO