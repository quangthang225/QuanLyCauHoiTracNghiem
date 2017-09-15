﻿USE [QuanLyCauHoiTracNghiem]

IF OBJECT_ID('sp_CapNhatMonHoc') IS NOT NULL
	DROP PROC sp_CapNhatMonHoc
GO
CREATE PROC sp_CapNhatMonHoc
	@MAMH BIGINT,
	@TENMH NVARCHAR(MAX),
	@MABM BIGINT,
	@KETQUA INT OUTPUT
AS 

SET TRAN ISOLATION LEVEL SERIALIZABLE

BEGIN
	BEGIN TRAN
		BEGIN TRY
			DECLARE @IS_EXIST_MH BIT = (SELECT 1 FROM MONHOC WHERE @MAMH = MONHOC.MAMH)

			IF @IS_EXIST_MH != 1
			BEGIN 
				SET @KETQUA = 2 --Môn học này không tồn tại  
				ROLLBACK TRAN
				RETURN
			END
			
			DECLARE @IS_EXIS_BM BIT = (SELECT 1 FROM BOMON WHERE @MABM = BOMON.MABM)

			IF @IS_EXIS_BM != 1
			BEGIN 
				SET @KETQUA = 4 --Bộ môn này không tồn tại  
				ROLLBACK TRAN
				RETURN
			END

			WAITFOR DELAY '0:0:10'--Chờ 10 giây

			UPDATE MONHOC SET TENMH = @TENMH, MABM = @MABM WHERE MAMH = @MAMH
			SET @KETQUA = 1

			--DELAY 10s

			IF (@TENMH LIKE '%[^a-zA-Z0-9 ._]%')
			BEGIN
				PRINT 'Tên môn học không hợp lệ'
				SET @KETQUA = 3 --Tên môn học chứa kí tự đặc biệt
				ROLLBACK TRAN
				RETURN
			END
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @KETQUA = 0
		END CATCH
	COMMIT TRAN
END
GO 
----------------------------------------------------------------------------------------------
IF OBJECT_ID('sp_XoaMonHoc') IS NOT NULL
	DROP PROC sp_XoaMonHoc
GO
CREATE PROC sp_XoaMonHoc
	@MAMH BIGINT,
	@KETQUA INT OUTPUT
AS 
SET TRAN ISOLATION LEVEL SERIALIZABLE
BEGIN
	BEGIN TRAN
		BEGIN TRY
			DECLARE @IS_EXIST_BM BIT = (SELECT 1 FROM MONHOC WHERE @MAMH = MONHOC.MAMH)

			IF @IS_EXIST_BM!=1
			BEGIN 
				ROLLBACK TRAN
				SET @KETQUA = 2 -- Môn học không tồn tại  
			END

			DELETE FROM MONHOC WHERE MAMH = @MAMH
			SET @KETQUA = 1
		END TRY
		BEGIN CATCH
			PRINT ERROR_MESSAGE() --XẢY RA DEADLOCK
			ROLLBACK TRAN
			SET @KETQUA = 0 --Xóa môn học thất bại
		END CATCH
	COMMIT TRAN
END
GO 