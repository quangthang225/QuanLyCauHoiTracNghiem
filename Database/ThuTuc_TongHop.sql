------- 1. Tao tai khoan ------------------
CREATE PROC sp_TaoTaiKhoan
@HoTen nvarchar(255),
@TenDangNhap varchar(30),
@MatKhau varchar(30),
@TrangThai bit,
@ToanQuyenGV bit,
@MaLoai bigint,
@MaBM bigint,
@MaGVQL bigint
AS 
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM LOAINGUOIDUNG WHERE [MALOAI] = @MaLoai)
			BEGIN
				PRINT N'MA LOAI NGUOI DUNG KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 1
			END
		ELSE IF NOT EXISTS(SELECT * FROM BOMON WHERE [MABM] = @MaBM)
			BEGIN
				PRINT N'MA BO MON KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 2
			END
		ELSE IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaGVQL)
			BEGIN
				PRINT N'MA GIAO VIEN QUAN LY KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 3
			END
		INSERT INTO [NGUOIDUNG] 
				([HOTEN],
				[TENDANGNHAP],
				[MATKHAU],
				[TRANGTHAI],
				[TOANQUYENGV],
				[MALOAI],
				[MABM],
				[MAGVQL])
		VALUES (@HoTen,
				@TenDangNhap,
				@MatKhau,
				@TrangThai,
				@ToanQuyenGV,
				@MaLoai,
				@MaBM,
				@MaGVQL)
	END TRY
	BEGIN CATCH
		PRINT N'LOI HE THONG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0
GO


------- 2. Xoa tai khoan ------------------
CREATE PROC sp_XoaTaiKhoan
@MaND bigint
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaND)
			BEGIN
				PRINT N'MA NGUOI DUNG KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 1
			END
		DELETE [NGUOIDUNG] WHERE [MAND] = @MaND
	END TRY
	BEGIN CATCH
		PRINT N'LOI HE THONG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0
GO


------- 3. Cap nhat thong tin ------------------
CREATE PROC sp_CapNhatThongTin
@MaND bigint,
@HoTen nvarchar(255),
@TenDangNhap varchar(30),
@MatKhau varchar(30),
@MaLoai bigint,
@MaBM bigint
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaND)
			BEGIN
				PRINT N'MA NGUOI DUNG KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 1
			END
		ELSE IF NOT EXISTS(SELECT * FROM LOAINGUOIDUNG WHERE [MALOAI] = @MaLoai)
			BEGIN
				PRINT N'MA lOAI NGUOI DUNG KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 1
			END
		ELSE IF NOT EXISTS(SELECT * FROM BOMON WHERE [MABM] = @MaBM)
			BEGIN
				PRINT N'MA BO MON KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 1
			END
		UPDATE [NGUOIDUNG] SET TENDANGNHAP = @TenDangNhap,HOTEN = @HoTen,MATKHAU = @MatKhau, MALOAI = @MaLoai, MABM = @MaBM  WHERE [MAND] = @MaND
	END TRY
	BEGIN CATCH
		PRINT N'LOI HE THONG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0
GO


------- 4. Cap nhat trang thai ------------------
CREATE PROC sp_CapNhatTrangThai
@MaND bigint,
@TrangThai bit
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaND)
			BEGIN
				PRINT N'MA NGUOI DUNG KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 1
			END
		UPDATE [NGUOIDUNG] SET [TRANGTHAI] = @TrangThai  WHERE [MAND] = @MaND
	END TRY
	BEGIN CATCH
			PRINT N'LOI HE THONG'
			ROLLBACK TRAN
			RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0
GO


------- 5. Giao vien QL cap quyen cho GV ------------------
CREATE PROC SP_GVQLCAPQUYEN
	@MAGVQL BIGINT,
	@MAGV BIGINT,
	@KETQUA BIT
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			DECLARE @COUNT INT = (SELECT COUNT(ND.MALOAI)
									FROM NGUOIDUNG ND
									WHERE ND.MAND = @MAGVQL AND
											ND.MALOAI = 1)

			DECLARE @CUNGBM BIT = (SELECT 1
									FROM NGUOIDUNG ND1, NGUOIDUNG ND2
									WHERE ND1.MAND = @MAGV AND
											ND2.MAND = @MAGVQL AND
											ND1.MABM = ND2.MABM)

			IF @COUNT = 0 OR @CUNGBM != 1
			BEGIN
				SET @KETQUA = 0
				RETURN
			END

			IF @COUNT = 1 AND @CUNGBM = 1
			BEGIN
				UPDATE NGUOIDUNG
				SET TOANQUYENGV = 1
				WHERE MAND = @MAGV

				SET @KETQUA = 1
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


------- 6. Thay doi giao vien quan ly ------------------
CREATE PROC sp_ThayDoiGVQL
@MaND bigint,
@MaGVQL bit
AS
BEGIN TRAN
	BEGIN TRY
	IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaND)
		BEGIN
			PRINT N'MA NGUOI DUNG KHONG TON TAI'
			ROLLBACK TRAN
			RETURN 1
		END
	ELSE IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAGVQL] = @MaGVQL)
		BEGIN
			PRINT N'MA GVQL KHONG TON TAI'
			ROLLBACK TRAN
			RETURN 2
		END
	UPDATE [NGUOIDUNG] SET MAGVQL = @MaGVQL  WHERE [MAND] = @MaND
	END TRY
BEGIN CATCH
	PRINT N'LOI HE THONG'
	ROLLBACK TRAN
	RETURN 1
END CATCH
COMMIT TRAN
RETURN 0
GO


------- 7. Cap nhat bo de thi ------------------
CREATE PROCEDURE sp_CapNhatBoDeThi
@MaBDT bigint,
@TenBoDeThi nvarchar(255),
@HocKy int,
@NamHoc int,
@Return bit out
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			-- Kiểm tra tồn tại @MaBDT
			IF NOT EXISTS ( SELECT * FROM BODETHI WHERE MABDT = @MaBDT )
			BEGIN
				SET @Return = 0
				RETURN
			END
			
			-- Kiểm tra tồn tại @TenBoDeThi
			IF EXISTS ( SELECT * FROM BODETHI WHERE MABDT != @MaBDT AND TENBDT = @TenBoDeThi )
			BEGIN
				SET @Return = 0
				RETURN
			END 

			-- @HocKy và @NamHoc hợp lệ
			IF ( @HocKy < 1 AND @NamHoc < 1)
			BEGIN
				SET @Return = 0
				RETURN
			END  

			UPDATE BODETHI SET TENBDT = @TenBoDeThi, HOCKY = @HocKy, NAMHOC = @NamHoc WHERE MABDT = @MaBDT
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @return = 0
		END CATCH
	COMMIT TRAN
END
GO


------- 8. Cap nhat cau hoi sang bo de thi khac ------------------
CREATE PROCEDURE sp_CapNhatCauHoiSangBoDeThiKhac
@MACH bigint,
@MABDTold bigint,
@MABDTnew bigint,
@Return bit out
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			-- Kiểm tra tồn tại @@MABDTold & @MABDTnew
			IF NOT EXISTS ( SELECT * FROM BODETHI WHERE @MABDTold = MABDT AND @MABDTnew = MABDT)
			BEGIN
				SET @Return = 0
				RETURN
			END

			-- Kiểm tra tồn tại @MACH
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @MACH = MACH  )
			BEGIN
				SET @Return = 0
				RETURN
			END

			--Kiểm tra bộ đề thi (@MABDTnew) đã tồn tại câu hỏi này
			IF EXISTS ( SELECT * FROM TAOBODETHI WHERE @MABDTnew = MABDT AND @MACH = MACH )
			BEGIN
				SET @Return = 0
				RETURN
			END 
			
			--Cập nhật
			UPDATE TAOBODETHI SET MABDT = @MABDTnew WHERE MACH = @MACH AND MABDT = @MABDTold
			SET @Return = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @return = 0
		END CATCH
	COMMIT TRAN
END
GO


------- 9. Tao bo de thi ------------------
CREATE PROCEDURE sp_TaoBoDeThi
@TenBoDeThi nvarchar(255),
@HocKy int,
@NamHoc int,
@Return bit out
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			-- Kiểm tra tồn tại @TenBoDeThi
			IF NOT EXISTS ( SELECT * FROM BODETHI WHERE TenBDT = @TenBoDeThi )
			BEGIN
				SET @Return = 0
				RETURN
			END

			-- Kiểm tra @HocKy và @NamHoc hợp lệ
			IF ( @HocKy < 1 AND @NamHoc < 1)
			BEGIN
				SET @Return = 0
				RETURN
			END  

			INSERT INTO BODETHI(TENBDT,HOCKY,NAMHOC) VALUES(@TenBoDeThi,@HocKy,@NamHoc)
			SET @Return = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @return = 0
		END CATCH
	COMMIT TRAN
END
GO


------- 10. Them cau hoi vao bo de thi ------------------
CREATE PROCEDURE sp_ThemCauHoiVaoBoDeThi
@MABDT bigint,
@MACH bigint,
@Return bit out
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			-- Kiểm tra tồn tại @MaBDT
			IF NOT EXISTS ( SELECT * FROM BODETHI WHERE @MABDT = MABDT )
			BEGIN
				SET @Return = 0
				RETURN
			END

			-- Kiểm tra tồn tại @MACH
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @MACH = MACH  )
			BEGIN
				SET @Return = 0
				RETURN
			END

			--Kiểm tra bộ đề thi đã tồn tại câu hỏi này
			IF EXISTS ( SELECT * FROM TAOBODETHI WHERE @MABDT = MABDT AND @MACH = MACH )
			BEGIN
				SET @Return = 0
				RETURN
			END 
			
			INSERT INTO TAOBODETHI(MABDT,MACH) VALUES(@MABDT,@MACH)
			SET @Return = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @return = 0
		END CATCH
	COMMIT TRAN
END
GO


------- 11. Tim kiem bo de thi ------------------
CREATE PROCEDURE sp_TimKiemBoDeThi
@MABDT bigint,
@TenBDT nvarchar(255),
@HocKy int,
@NamHoc int,
@return bit output
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT *
			FROM BODETHI
			WHERE (MABDT = @MABDT OR @MABDT = 0 ) 
					OR ( TENBDT like N'%' + @TenBDT + '%' OR @TenBDT = '' )
					OR ( HOCKY = @HocKy OR @HocKy = 0 )
					OR ( NAMHOC = @NamHoc OR @NamHoc = 0 )
			SET @return = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @return = 0
		END CATCH
	COMMIT TRAN
END
GO


------- 12. Tim kiem tat ca cac cau hoi theo bo de thi ------------------
CREATE PROCEDURE sp_TimKiemTatCaCauHoiTheoBoDeThi
@MABDT bigint,
@return bit output
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			--Kiểm tra mã bộ đề thi input có tồn tại hay không
			IF NOT EXISTS ( SELECT * FROM BODETHI WHERE MABDT = @MABDT )
			BEGIN
				SET @return = 0
				RETURN
			END 

			SELECT *
			FROM TAOBODETHI
			WHERE MABDT = @MABDT
			SET @return = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @return = 0
		END CATCH
	COMMIT TRAN
END
GO


------- 13. Xoa cau hoi trong bo de thi ------------------
CREATE PROCEDURE sp_XoaCauHoiTrongBodeThi
@MACH bigint,
@MABDT bigint,
@Return bit out
AS
BEGIN
	BEGIN TRY
			-- Kiểm tra tồn tại câu hỏi có trong bộ đề thi
			IF NOT EXISTS ( SELECT * FROM TAOBODETHI WHERE @MABDT = MABDT AND @MACH = MACH )
			BEGIN
				SET @Return = 0
				RETURN
			END

			-- Xóa câu hỏi trong bộ đề thi
			DELETE FROM TAOBODETHI WHERE MABDT = @MABDT AND MACH = @MACH
			SET @Return = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @Return = 0
		END CATCH
END
GO


------- 14. Them mon hoc ------------------
CREATE PROC SP_THEMMONHOC
	@MAGVQL BIGINT,
	@MABM BIGINT,
	@TENMH NVARCHAR(MAX),
	@KETQUA BIT OUTPUT
AS BEGIN
	BEGIN TRAN
		BEGIN TRY
			DECLARE @IS_EXIST BIT = (SELECT 1 FROM BOMON WHERE @MABM = BOMON.MABM)

			DECLARE @COUNT INT = (SELECT COUNT(ND.MALOAI)
										FROM NGUOIDUNG ND
										WHERE ND.MAND = @MAGVQL AND
												ND.MALOAI = 1)

			IF @IS_EXIST!=1 OR @COUNT = 0
			BEGIN 
				SET @KETQUA = 0  
				RETURN 
			END

			INSERT INTO MONHOC(MABM, TENMH) VALUES (@MABM, @TENMH)
			SET @KETQUA = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @KETQUA = 0
		END CATCH
	COMMIT TRAN
END
GO


------- 15.  ------------------


------- 16.  ------------------


------- 17.  ------------------


------- 18.  ------------------


------- 19.  ------------------


------- 20.  ------------------


------- 21.  ------------------


