﻿USE [QuanLyCauHoiTracNghiem]

IF OBJECT_ID('sp_LayDanhSachMonHoc') IS NOT NULL
	DROP PROC sp_LayDanhSachMonHoc
GO

CREATE PROCEDURE sp_LayDanhSachMonHoc
	@TENMH NVARCHAR(MAX),
	@MABM BIGINT
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			DECLARE @COUNT INT
			IF @MABM = 0
			BEGIN
				PRINT 'Tìm kiếm theo tên môn học'
				SELECT @COUNT = COUNT(*) FROM MONHOC MH, BOMON BM WHERE  BM.MABM = MH.MABM AND MH.TENMH LIKE '%'+@TENMH+'%'
				PRINT 'CO ' + CAST(@COUNT AS VARCHAR(10)) + ' KET QUA.'
		
				WAITFOR DELAY '0:0:10' --Chờ 10 giây

				SELECT MH.MAMH, MH.TENMH, MH.MABM, BM.TENBM FROM MONHOC MH, BOMON BM WHERE  BM.MABM = MH.MABM AND MH.TENMH LIKE '%'+@TENMH+'%'
			END
			ELSE
			BEGIN
				PRINT 'Tìm kiếm theo bộ môn và tên môn học'
				SELECT @COUNT = COUNT(*) FROM MONHOC MH, BOMON BM WHERE BM.MABM = MH.MABM AND @MABM = MH.MABM AND MH.TENMH LIKE '%'+@TENMH+'%'
				PRINT 'CO ' + CAST(@COUNT AS VARCHAR(10)) + ' KET QUA.'
		
				WAITFOR DELAY '0:0:10' --Chờ 10 giây

				SELECT MH.MAMH, MH.TENMH, MH.MABM, BM.TENBM FROM MONHOC MH, BOMON BM WHERE BM.MABM = MH.MABM AND @MABM = MH.MABM AND MH.TENMH LIKE '%'+@TENMH+'%'
			END
		END TRY
		BEGIN CATCH
			PRINT N'XẢY RA LỖI'
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO
---------------------------------------------------------------------------------------------
IF OBJECT_ID('sp_CapNhatMonHoc') IS NOT NULL
	DROP PROC sp_CapNhatMonHoc
GO
CREATE PROC sp_CapNhatMonHoc
	@MAMH BIGINT,
	@TENMH NVARCHAR(MAX),
	@MABM BIGINT,
	@KETQUA INT OUTPUT
AS BEGIN
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

			UPDATE MONHOC SET TENMH = @TENMH, MABM = @MABM WHERE MAMH = @MAMH			
			SET @KETQUA = 1
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


--IF OBJECT_ID('sp_LayMonHoc') IS NOT NULL
--	DROP PROC sp_LayMonHoc
--GO

--CREATE PROC sp_LayMonHoc
--	@MAMH BIGINT,
--	@MABM BIGINT
--AS BEGIN
--	BEGIN TRAN
--		BEGIN TRY
--			DECLARE @COUNT INT = (SELECT COUNT(*) FROM MONHOC WHERE MAMH = @MAMH AND MABM = @MABM)
--			PRINT 'CO ' + CAST(@COUNT AS VARCHAR(10)) + ' KET QUA.'
		
--			WAITFOR DELAY '0:0:10'

--			SELECT * FROM MONHOC WHERE MAMH = @MAMH AND MABM = @MABM
--		END TRY
--		BEGIN CATCH
--			ROLLBACK TRAN
--			RETURN 0
--		END CATCH
--	COMMIT TRAN
--END

--GO

--IF OBJECT_ID('sp_CapNhatMonHoc') IS NOT NULL
--	DROP PROC sp_CapNhatMonHoc
--GO

--CREATE PROC sp_CapNhatMonHoc
--	@MAMH BIGINT,
--	@MABM BIGINT
--AS BEGIN
--	BEGIN TRAN
--		BEGIN TRY
--			IF NOT EXISTS (SELECT *
--							FROM BOMON
--							WHERE MABM = @MABM)
--			BEGIN
--				ROLLBACK TRAN
--				RETURN 0
--			END

--			UPDATE MONHOC
--			SET MABM = @MABM
--			WHERE MAMH = @MAMH

--		END TRY
--		BEGIN CATCH
--			ROLLBACK TRAN
--			RETURN 0
--		END CATCH
--	COMMIT TRAN
--	RETURN 1
--END

--GO