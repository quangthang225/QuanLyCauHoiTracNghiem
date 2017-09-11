﻿USE [QuanLyCauHoiTracNghiem]

IF OBJECT_ID('sp_LayMonHoc') IS NOT NULL
	DROP PROC sp_LayMonHoc
GO

CREATE PROC sp_LayMonHoc
	@MABM BIGINT
AS 
--SET TRAN ISOLATION LEVEL REPEATABLE READ --PHANTOM: Đọc phải xin và giữ đến hết giao tác nhưng ko ngăn được Insert
SET TRAN ISOLATION LEVEL SERIALIZABLE --FIX PHANTOM: Ngăn chặn Insert dữ liệu
BEGIN
	BEGIN TRAN
		BEGIN TRY
			DECLARE @COUNT INT = (SELECT COUNT(*) FROM MONHOC WHERE MABM = @MABM)
			PRINT 'CO ' + CAST(@COUNT AS VARCHAR(10)) + ' KET QUA.'
		
			WAITFOR DELAY '0:0:10'

			SELECT * FROM MONHOC WHERE MABM = @MABM
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			RETURN 0
		END CATCH
	COMMIT TRAN
END

GO

IF OBJECT_ID('sp_ThemMonHoc') IS NOT NULL
	DROP PROC sp_ThemMonHoc
GO

CREATE PROC sp_ThemMonHoc
	@TENMH NVARCHAR(MAX),
	@MABM BIGINT
AS
SET TRAN ISOLATION LEVEL READ COMMITTED
BEGIN
	BEGIN TRAN
		BEGIN TRY
			INSERT INTO MONHOC(TENMH, MABM) VALUES (@TENMH, @MABM)
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO