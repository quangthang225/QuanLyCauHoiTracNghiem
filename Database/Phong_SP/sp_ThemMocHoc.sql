﻿USE [QuanLyCauHoiTracNghiem]

IF OBJECT_ID('sp_ThemMonHoc') IS NOT NULL
	DROP PROC sp_ThemMonHoc
GO
CREATE PROC sp_ThemMonHoc
	@MABM BIGINT,
	@TENMH NVARCHAR(MAX),
	@KETQUA INT OUTPUT
AS BEGIN
	BEGIN TRAN
		BEGIN TRY
			DECLARE @IS_EXIST_BM BIT = (SELECT 1 FROM BOMON WHERE @MABM = BOMON.MABM)

			IF @IS_EXIST_BM!=1
			BEGIN 
				ROLLBACK TRAN
				SET @KETQUA = 2 -- Bộ môn không tồn tại  
			END

			INSERT INTO MONHOC(MABM, TENMH) VALUES (@MABM, @TENMH)
			SET @KETQUA = 1

			IF (@TENMH LIKE '%[^a-zA-Z0-9 ._]%')
			BEGIN
				PRINT N'Tên môn học không hợp lệ'
				SET @KETQUA = 3 --Tên môn học chứa kí tự đặc biệt
				ROLLBACK TRAN
				RETURN
			END
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @KETQUA = 0 --Thất bại
		END CATCH
	COMMIT TRAN
END
GO 