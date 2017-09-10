﻿USE [QuanLyCauHoiTracNghiem]

IF OBJECT_ID('sp_CapNhatMonHoc') IS NOT NULL
	DROP PROC sp_CapNhatMonHoc
GO

CREATE PROC sp_CapNhatMonHoc
	@MAMH BIGINT,
	@TENMH NVARCHAR(255)
AS BEGIN
	BEGIN TRAN
		BEGIN TRY
			UPDATE MONHOC
			SET @TENMH = @TENMH
			WHERE MAMH = @MAMH

			WAITFOR DELAY '0:0:10'

			ROLLBACK TRAN
			RETURN 0
		END TRY

		BEGIN CATCH
			ROLLBACK TRAN
			RETURN 0
		END CATCH
	COMMIT TRAN
	RETURN 1
END

GO

IF OBJECT_ID('sp_LayMonHoc') IS NOT NULL
	DROP PROC sp_LayMonHoc
GO

CREATE PROC sp_LayMonHoc
	@MAMH BIGINT,
	@TENMH NVARCHAR(255)

AS

--SET TRAN ISOLATION LEVEL READ UNCOMMITTED --Khắc phục lỗi Dirty Read

BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM MONHOC WHERE MAMH = @MAMH AND TENMH = @TENMH
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			RETURN 0
		END CATCH
	COMMIT TRAN
END

GO