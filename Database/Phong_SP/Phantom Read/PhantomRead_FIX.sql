USE [QuanLyCauHoiTracNghiem]

IF OBJECT_ID('sp_LayDanhSachMonHoc') IS NOT NULL
	DROP PROC sp_LayDanhSachMonHoc
GO

CREATE PROCEDURE sp_LayDanhSachMonHoc
	@TENMH NVARCHAR(MAX),
	@MABM BIGINT
AS

SET TRAN ISOLATION LEVEL SERIALIZABLE --FIX PHANTOM: Ngăn chặn Insert dữ liệu, T2 xen vô phải đợi T1 xong

BEGIN
	BEGIN TRAN
		BEGIN TRY
			DECLARE @COUNT INT
			IF @MABM = 0
			BEGIN
				PRINT N'Tìm kiếm theo tên môn học'
				SELECT @COUNT = COUNT(*) FROM MONHOC MH, BOMON BM WHERE BM.MABM = MH.MABM AND MH.TENMH LIKE '%'+@TENMH+'%'
				PRINT N'CÓ ' + CAST(@COUNT AS VARCHAR(10)) + ' KẾT QUẢ.'
		
				WAITFOR DELAY '0:0:10' --Chờ 10 giây

				SELECT MH.MAMH, MH.TENMH, MH.MABM, BM.TENBM FROM MONHOC MH, BOMON BM WHERE BM.MABM = MH.MABM AND MH.TENMH LIKE '%'+@TENMH+'%'
			END
			ELSE
			BEGIN
				PRINT N'Tìm kiếm theo bộ môn và tên môn học'
				SELECT @COUNT = COUNT(*) FROM MONHOC MH, BOMON BM WHERE BM.MABM = MH.MABM AND @MABM = MH.MABM AND MH.TENMH LIKE '%'+@TENMH+'%'
				PRINT N'CÓ ' + CAST(@COUNT AS VARCHAR(10)) + ' KẾT QUẢ.'
		
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
------------------------------------------------------------------------------------------------------------------------------------------------
IF OBJECT_ID('sp_ThemMonHoc') IS NOT NULL
	DROP PROC sp_ThemMonHoc
GO
CREATE PROC sp_ThemMonHoc
	@MABM BIGINT,
	@TENMH NVARCHAR(MAX),
	@KETQUA INT OUTPUT
AS 

SET TRAN ISOLATION LEVEL READ COMMITTED --Ghi: xin và nhả khóa đến hết gt, Đọc: xin và nhả khóa liền

BEGIN
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