CREATE PROC sp_CapNhatThongTin
@MaND bigint,
@HoTen nvarchar(255),
@TenDangNhap varchar(30),
@ToanQuyenGV bit,
@TrangThai bit,
@MaLoai bigint,
@MaBM bigint,
@MaGVQL bigint,
@Return int out
AS
BEGIN TRAN
	BEGIN TRY
		SET @Return = -1;
		IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaND)
			BEGIN
				PRINT N'MA NGUOI DUNG KHONG TON TAI'
				SET @Return = 1
			END
		ELSE IF NOT EXISTS(SELECT * FROM LOAINGUOIDUNG WHERE [MALOAI] = @MaLoai)
			BEGIN
				PRINT N'MA lOAI NGUOI DUNG KHONG TON TAI'
				SET @Return = 2
			END
		ELSE IF NOT EXISTS(SELECT * FROM BOMON WHERE [MABM] = @MaBM)
			BEGIN
				PRINT N'MA BO MON KHONG TON TAI'
				SET @Return = 3
			END
		IF @Return = -1
			BEGIN
				UPDATE [NGUOIDUNG] SET TENDANGNHAP = @TenDangNhap,HOTEN = @HoTen, TRANGTHAI = @TrangThai, TOANQUYENGV = @ToanQuyenGV, MALOAI = @MaLoai, MABM = @MaBM, MAGVQL = @MaGVQL  WHERE [MAND] = @MaND
				SET @Return = 0;
			END
	END TRY
	BEGIN CATCH
		PRINT N'LOI HE THONG'
		SET @Return = 4
		ROLLBACK TRAN
	END CATCH
COMMIT TRAN
GO

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

CREATE PROCEDURE sp_LayDanhSachBoMon
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM BOMON
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO

CREATE PROCEDURE sp_LayDanhSachLGiaoVienQuanLy
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM NGUOIDUNG WHERE MALOAI=2
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO

CREATE PROCEDURE sp_LayDanhSachNguoiDung
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT nd.*,lnd.TENLOAIND, bm.TENBM, nd2.HOTEN AS TENGVQL FROM NGUOIDUNG nd,NGUOIDUNG nd2,BOMON bm, LOAINGUOIDUNG lnd WHERE nd.MABM = bm.MABM and nd.MALOAI = lnd.MALOAI and nd.MAGVQL = nd2.MAND and nd.MAGVQL IS NOT NULL
			UNION
			SELECT nd.*,lnd.TENLOAIND, bm.TENBM, NULL FROM NGUOIDUNG nd,BOMON bm, LOAINGUOIDUNG lnd WHERE nd.MABM = bm.MABM and nd.MALOAI = lnd.MALOAI and nd.MAGVQL IS NULL
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO


CREATE PROCEDURE sp_LayNguoiDung
@MaND bigint
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM NGUOIDUNG WHERE MAND = @MaND
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO

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
		IF NOT EXISTS(SELECT * FROM BOMON WHERE [MABM] = @MaBM)
			BEGIN
				PRINT N'MA BO MON KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 2
			END
		IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaGVQL)
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

ALTER PROC sp_ThayDoiGVQL
@MaND bigint,
@MaGVQL bigint,
@Return int out
AS
BEGIN TRAN
	BEGIN TRY
	IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaND)
		BEGIN
			PRINT N'MA NGUOI DUNG KHONG TON TAI'
			SET @Return = 1
		END
	IF NOT EXISTS(SELECT * FROM NGUOIDUNG WHERE [MAND] = @MaGVQL)
		BEGIN
			PRINT N'MA GVQL KHONG TON TAI'
			SET @Return = 2
		END
	UPDATE [NGUOIDUNG] SET MAGVQL = @MaGVQL  WHERE [MAND] = @MaND
	SET @Return = 0
	END TRY
	BEGIN CATCH
		PRINT N'LOI HE THONG'
		ROLLBACK TRAN
		SET @Return = 3
	END CATCH
COMMIT TRAN
GO

CREATE PROC sp_ThemBoMon
@TenBM nvarchar(255)
AS
BEGIN TRAN
	BEGIN TRY
		INSERT INTO BOMON ([TENBM]) VALUES (@TenBM)
	END TRY
	BEGIN CATCH
		PRINT N'LOI HE THONG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0
GO

CREATE PROC sp_XoaBoMon
@MaBM bigint
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM BOMON WHERE [MABM] = @MaBM)
			BEGIN
				PRINT N'MA BO MON KHONG TON TAI'
				RETURN 1
			END
		DELETE BOMON WHERE [MABM] = @MaBM
	END TRY
	BEGIN CATCH
		PRINT N'LOI HE THONG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0
GO

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

ALTER PROCEDURE sp_CapNhatBoDeThi
@MaBDT bigint,
@TenBoDeThi nvarchar(255),
@HocKy int,
@NamHoc int,
@Return int out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @validateInput BIT
			SET @validateInput = 1
			
			-- Kiểm tra tồn tại @TenBoDeThi
			IF EXISTS ( SELECT * FROM BODETHI WHERE MABDT != @MaBDT AND TENBDT = @TenBoDeThi )
				SET @validateInput = 0

			-- @HocKy và @NamHoc hợp lệ
			IF ( @HocKy < 1 OR @NamHoc < 1)
				SET @validateInput = 0

			IF @validateInput = 1
			BEGIN
				-- Kiểm tra tồn tại @MaBDT
				IF NOT EXISTS ( SELECT * FROM BODETHI WHERE MABDT = @MaBDT )
					SET @Return = 2
				ELSE
				BEGIN
					UPDATE BODETHI SET TENBDT = @TenBoDeThi, HOCKY = @HocKy, NAMHOC = @NamHoc WHERE MABDT = @MaBDT
					SET @Return = 1
				END
			END
			ELSE
				SET @Return = 0
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO

ALTER PROCEDURE sp_CapNhatCauHoi
@MACH bigint,
@NOIDUNG nvarchar(max),
@THANGDIEM float,
@MUCDO int,
@MAMH bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			-- Kiểm tra tồn tại câu hỏi
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE MACH = @MACH )
				SET @Return = N'Không tồn tại câu hỏi này'

			-- Kiểm tra có cập nhật môn học cho câu hỏi hay ko
			DECLARE @MAMHtemp BIGINT
			SELECT @MAMHtemp = MAMH FROM CAUHOI WHERE MACH = @MACH
			IF ( @MAMHtemp != @MAMH )
			BEGIN
				IF EXISTS ( SELECT * FROM CAUTRALOI WHERE MACH = @MACH )
					SET @Return = N'Không thể cập nhật môn học cho câu hỏi này vì câu hỏi đang có câu trả lời'
				ELSE
				BEGIN
					UPDATE CAUHOI SET NOIDUNG = @NOIDUNG, THANGDIEM = @THANGDIEM, MUCDO = @MUCDO, MAMH = @MAMH WHERE MACH = @MACH
					SET @Return = ''
				END
			END
			ELSE
			BEGIN
				IF @Return = '' OR @Return is null
				BEGIN
					UPDATE CAUHOI SET NOIDUNG = @NOIDUNG, THANGDIEM = @THANGDIEM, MUCDO = @MUCDO 
					WHERE MACH = @MACH
					SET @Return = ''
				END
				ELSE
					SET @Return = N'Dữ liệu không hợp lệ'
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO

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

CREATE PROCEDURE sp_CapNhatCauTraLoi
@MACTL bigint,
@NOIDUNG nvarchar(max),
@LADAPANDUNG bit,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @validateInput BIT
			SET @validateInput = 1
			
			-- Kiểm tra tồn tại câu trả lời cần cập nhật
			IF NOT EXISTS ( SELECT * FROM CAUTRALOI WHERE MACTL = @MACTL )
				SET @validateInput = 0

			IF @validateInput = 1
			BEGIN
				UPDATE CAUTRALOI SET NOIDUNG = @NOIDUNG, LADAPANDUNG = @LADAPANDUNG WHERE MACTL = @MACTL
				SET @Return = ''
			END
			ELSE
				SET @Return = 'Dữ liệu không hợp lệ'
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO

CREATE PROCEDURE sp_DangNhap
@tenDangNhap varchar(30),
@matKhau varchar(30),
@maNguoiDung bigint out,
@return bit out,
@islocked bit out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			SET @islocked = (SELECT TRANGTHAI FROM NGUOIDUNG WHERE TENDANGNHAP = @tenDangNhap)

			IF @islocked = 0
				BEGIN
					SET @return = 0
				END		

			IF EXISTS ( SELECT MAND FROM NGUOIDUNG WHERE TENDANGNHAP = @tenDangNhap AND MATKHAU = @matKhau)
				BEGIN
					SET @maNguoiDung = ( SELECT MAND FROM NGUOIDUNG WHERE TENDANGNHAP = @tenDangNhap AND MATKHAU = @matKhau )
					SET @return = 1
				END
			ELSE
				BEGIN
					SET @return = 0
				END	
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO

CREATE PROCEDURE sp_DiChuyenCauHoiRaKhoiDeThi
@MABDT bigint,
@MACH bigint,
@Return bit out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @validateInput BIT
			SET @validateInput = 1
			-- Kiểm tra tồn tại @MaBDT
			IF NOT EXISTS ( SELECT * FROM BODETHI WHERE @MABDT = MABDT )
			BEGIN
				SET @validateInput = 0
			END

			-- Kiểm tra tồn tại @MACH
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @MACH = MACH  )
			BEGIN
				SET @validateInput = 0
			END

			IF @validateInput = 1 
			BEGIN
				--Kiểm tra bộ đề thi đã tồn tại câu hỏi này
				IF EXISTS ( SELECT * FROM TAOBODETHI WHERE @MABDT = MABDT AND @MACH = MACH )
				BEGIN
					DELETE FROM TAOBODETHI WHERE MACH = @MACH AND MABDT = @MABDT
					SET @Return = 1
				END 
				ELSE
				BEGIN
					SET @Return = 0
				END
			END
			ELSE
			BEGIN
				SET @Return = 0	
			END		
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO

CREATE PROCEDURE sp_LayDanhSachBoDeThi
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT B.*, M.TENMH
			FROM BODETHI B , MONHOC M 
			WHERE B.MAMH = M.MAMH; 
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO

CREATE PROCEDURE sp_LayDanhSachCauHoi
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT c.*,m.TENMH FROM CAUHOI c,MonHoc m WHERE c.MAMH =m.MAMH
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO

CREATE PROCEDURE sp_LayDanhSachCauHoiTheoDeThi
@MABDT bigint
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT c.*
			FROM TAOBODETHI t , CAUHOI c 
			WHERE t.MABDT = @MABDT AND t.MACH = c.MACH 
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO

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

CREATE PROCEDURE sp_LayDanhSachCauHoiTheoMucDO
@MUCDO int,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF NOT EXISTS( SELECT * FROM CAUHOI )
				SET @Return = N'Hệ thống chưa có bất kỳ câu hỏi nào'
			
			IF @Return = '' OR @Return is null	
			BEGIN
				SELECT c.*,m.TENMH FROM CAUHOI c,MonHoc m WHERE c.MAMH = m.MAMH AND c.MUCDO = @MUCDO
				SET @Return = ''
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE() 
		ROLLBACK TRAN
	END CATCH
END
GO

ALTER PROCEDURE sp_LayDanhSachCauTraLoiTheoCauHoi
@MACH bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @MACH = MACH )
			BEGIN
				SET @Return = N'Không tồn tại câu hỏi này'
			END

			SELECT * FROM CAUTRALOI WHERE MACH = @MACH
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO

CREATE PROCEDURE sp_LayDanhSachMonHoc
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM MONHOC
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO

ALTER PROCEDURE sp_TaoBoDeThi
@TenBoDeThi nvarchar(255),
@HocKy int,
@NamHoc int,
@MaGvTao bigint,
@MaMonHoc bigint,
@Return int out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @validateInput BIT
			SET @validateInput = 1
			

			-- Kiểm tra @HocKy và @NamHoc hợp lệ
			IF ( @HocKy < 1 OR @NamHoc < 1)
			BEGIN
				SET @validateInput = 0
			END  
			
			IF ( @validateInput = 1 ) 
			BEGIN
					-- Kiểm tra tồn tại @TenBoDeThi
				IF EXISTS ( SELECT * FROM BODETHI WHERE TenBDT = @TenBoDeThi )
				BEGIN
					SET @Return = 2
				END
				ELSE
				BEGIN
					INSERT INTO BODETHI(TENBDT,HOCKY,NAMHOC,MAGVTAO,MAMH) VALUES(@TenBoDeThi,@HocKy,@NamHoc,@MaGvTao,@MaMonHoc)
					SET @Return = 1
				END
			END
			ELSE
			BEGIN
				SET @Return = 0
			END
		COMMIT TRAN
	END TRY	
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO


ALTER PROCEDURE sp_ThemCauHoi
@NoiDung nvarchar(max),
@ThangDiem float,
@MucDo int,
@MaMH bigint,
@Return bit out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @validateInput BIT
			SET @validateInput = 1
			-- Kiểm tra tồn tại Môn học
			IF NOT EXISTS ( SELECT * FROM MONHOC WHERE @MaMH = MAMH )
			BEGIN
				SET @validateInput = 0
			END

			IF @validateInput = 1 
			BEGIN
				INSERT INTO CAUHOI(NOIDUNG,THANGDIEM,SOCAUTRALOI,MUCDO,MAMH) VALUES(@NoiDung,@ThangDiem,0,@MucDo,@MaMH)
				SET @Return = 1
			END
			ELSE
			BEGIN
				SET @Return = 0	
			END		
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO

ALTER PROCEDURE sp_ThemCauHoiVaoBoDeThi
@MABDT bigint,
@MACH bigint,
@Diem float,
@Return bit out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @validateInput BIT
			SET @validateInput = 1
			-- Kiểm tra tồn tại @MaBDT
			IF NOT EXISTS ( SELECT * FROM BODETHI WHERE @MABDT = MABDT )
			BEGIN
				SET @validateInput = 0
			END

			-- Kiểm tra tồn tại @MACH
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @MACH = MACH  )
			BEGIN
				SET @validateInput = 0
			END

			IF @validateInput = 1 
			BEGIN
				--Kiểm tra bộ đề thi đã tồn tại câu hỏi này
				IF EXISTS ( SELECT * FROM TAOBODETHI WHERE @MABDT = MABDT AND @MACH = MACH )
				BEGIN
					SET @Return = 0
				END 
				ELSE
				BEGIN
					INSERT INTO TAOBODETHI(MABDT,MACH,DIEM) VALUES(@MABDT,@MACH,@DIEM)
					SET @Return = 1
				END
			END
			ELSE
			BEGIN
				SET @Return = 0	
			END		
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO

ALTER PROCEDURE sp_ThemCauTraLoiVaoCauHoi
@NOIDUNG nvarchar(max),
@LADAPANDUNG bit,
@MACH bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			-- Kiểm tra tồn tại câu hỏi
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE MACH = @MACH )
			BEGIN
				SET @Return = N'Không tồn tại câu hỏi này'
			END

			-- Kiểm tra tồn tại câu trả lời trong câu hỏi này
			IF EXISTS ( SELECT * FROM CAUTRALOI WHERE MACH = @MACH AND NOIDUNG = @NOIDUNG )
			BEGIN
				SET @Return = N'Trong câu hỏi đã tồn tại câu trả lời này'
			END

			IF @Return = '' OR @Return is null
			BEGIN
				INSERT INTO CAUTRALOI(NOIDUNG,LADAPANDUNG,MACH) VALUES(@NOIDUNG,@LADAPANDUNG,@MACH)
				SET @Return = ''
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO

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

CREATE PROCEDURE sp_XoaCauTraLoi
@MACTL bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @validateInput BIT = 1
			-- Kiểm tra tồn tại câu trả lời cần xóa
			IF NOT EXISTS ( SELECT * FROM CAUTRALOI WHERE MACTL = @MACTL )
			BEGIN
				SET @validateInput = 0
				RETURN
			END

			IF @validateInput = 1
			BEGIN
				-- Xóa câu trả lời
				DELETE FROM CAUTRALOI WHERE MACTL = @MACTL
				SET @Return = ''
			END
			ELSE
			BEGIN
				SET @Return = 'Mã câu trả lời không tòn tại'
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO

CREATE PROC sp_CapNhatCauHoi
	@Macauhoi bigint,
	@Monhoc bigint,
	@Noidung nvarchar(Max),
	@Socautraloi int,
	@Thangdiemdukien float,
	@Mucdo int,
	@Return nvarchar(500) out
AS
BEGIN 
	BEGIN TRAN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM CAUHOI WHERE [MACH] = @Macauhoi)
			BEGIN
				SET @Return = N'MA CAU HOI KHONG TON TAI'
			END
			ELSE IF NOT EXISTS(SELECT * FROM MONHOC WHERE [MAMH] = @Monhoc)
			BEGIN
				SET @Return = N'MA MON HOC KHONG TON TAI'
			END
			WAITFOR DELAY '00:00:05'
			BEGIN
				UPDATE [CAUHOI] SET MAMH = @Monhoc,NOIDUNG = @Noidung, SOCAUTRALOI = @Socautraloi, THANGDIEM = @Thangdiemdukien , MUCDO = @Mucdo  WHERE [MACH] = @Macauhoi
				SET @Return = '';
			END	
		END TRY
		BEGIN CATCH
			SET @Return = N'LOI HE THONG'
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO

CREATE PROC sp_Laydanhsachcauhoi 
@Macauhoi bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		SET TRAN ISOLATION LEVEL READ COMMITTED -- m?c c� l?p m?c ??nh
		BEGIN TRAN
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @Macauhoi = MACH )
			BEGIN
				SET @Return = N'KHONG TON TAI CAU HOI NAY'
			END
			SELECT * FROM CAUHOI WHERE [MACH] = @MaCauHoi
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO

CREATE PROC spa_PhanLoaiCauHoi
	@Macauhoi nvarchar(100),
	@MucDo nvarchar(100),
	@bit BIT OUTPUT
	AS 
BEGIN
BEGIN TRAN
BEGIN TRY
UPDATE CAUHOI  
SET MucDo = @MucDo
WHERE MaCauHoi = @Macauhoi 
set @bit = 1

END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @bit = 0
		END CATCH
			COMMIT TRAN
END
GO

CREATE PROC sp_Soluongcauhoicuabomon 
@Mamonhoc bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @slch INT
			SELECT @slch = COUNT(*) FROM CAUHOI c WHERE c.MAMH =  @Mamonhoc
			IF ( @slch < 1  )
				SET @Return = N'Mon hoc nay chua co cau hoi nao'
			IF @Return = '' OR @Return is null
			BEGIN
				WAITFOR DELAY '00:00:05'
				SELECT COUNT(*) FROM CAUHOI c WHERE c.MAMH =  @Mamonhoc
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END

CREATE PROC sp_Soluongcautraloicuacauhoi 
@Macauhoi bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF NOT EXISTS(SELECT * FROM CAUHOI WHERE [MACH] = @Macauhoi)
			BEGIN
				PRINT N'MA CAU HOI KHONG TON TAI'
				ROLLBACK TRAN
				RETURN 1
			END
			IF @Return = '' OR @Return is null
			BEGIN
				WAITFOR DELAY '00:00:05'
				SELECT SOCAUTRALOI FROM CAUHOI c WHERE c.MAMH =  @Macauhoi
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END

CREATE PROC sp_ThayDoiMonHoc
@Macauhoi bigint,
@Monhoc bigint,
@Return nvarchar(500) out
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM CAUHOI WHERE [MACH] = @Macauhoi)
			BEGIN
				SET @Return = N'MA CAU HOI KHONG TON TAI'
			END
		ELSE IF NOT EXISTS(SELECT * FROM MONHOC WHERE [MAMH] = @Monhoc)
			BEGIN
				SET @Return = N'MA MON HOC KHONG TON TAI'
			END
		UPDATE [CAUHOI] SET MAMH = @Monhoc  WHERE [MACH] = @Macauhoi
		SET @Return = ''
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SET @Return = N'LOI HE THONG'
	END CATCH
COMMIT TRAN
GO

CREATE PROC sp_ThemCauHoi
	@Monhoc bigint,
	@Noidung nvarchar(Max),
	@Socautraloi int,
	@Thangdiemdukien float,
	@Mucdo int,
	@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			BEGIN
				BEGIN
					INSERT INTO CAUHOI(MAMH,NOIDUNG,SOCAUTRALOI,THANGDIEM,MUCDO) VALUES(@Monhoc,@Noidung,@Socautraloi,@Thangdiemdukien,@Mucdo)
				END
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO

CREATE PROCEDURE sp_TimKiemCauHoi
	@Macauhoi nvarchar(100),
	@Monhoc nvarchar(100),
	@LoaiMonHoc int,
	@MucDo nvarchar(100) ,
	@bit BIT OUTPUT
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT *
			FROM CAUHOI
			WHERE (MaCauHoi = @Macauhoi OR @Macauhoi = 0 ) 
					OR ( Monhoc like N'%' + @Monhoc + '%' OR @Monhoc = '' )
					OR ( LoaiMonHoc = @LoaiMonHoc OR @LoaiMonHoc = 0 )
					OR ( Mucdo like N'%' + @MucDo + '%' OR @MucDo = '' )
			SET @bit = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @bit = 0
		END CATCH
	COMMIT TRAN
END
GO

CREATE PROC sp_XoaCauHoi
	@Macauhoi bigint,
	@Return nvarchar(500) out
	AS 
	BEGIN TRY
		BEGIN TRAN
			IF NOT EXISTS(SELECT * FROM CAUHOI WHERE [MACH] = @Macauhoi)
			BEGIN
				SET @Return = N'MA CAU HOI KHONG TON TAI'
			END
			BEGIN
				DELETE CauHoi WHERE MACH = @Macauhoi 
				SET @Return = '';
			END
		
				--TESTING
			WAITFOR DELAY '00:00:05'
			ROLLBACK TRAN
			RETURN	
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = N'LOI HE THONG'
		ROLLBACK TRAN
	END CATCH
GO

CREATE PROC sp_Laydanhsachcauhoi 
@Macauhoi bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		SET TRAN ISOLATION LEVEL READ COMMITTED -- mức cô lập mặc định
		BEGIN TRAN
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @Macauhoi = MACH )
			BEGIN
				SET @Return = N'KHONG TON TAI CAU HOI NAY'
			END
			SELECT * FROM CAUHOI WHERE [MACH] = @MaCauHoi
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END

CREATE PROCEDURE sp_LayDanhSachBoMon
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM BOMON
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO

CREATE PROCEDURE sp_LayDanhSachMonHoc
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM MONHOC
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO

IF OBJECT_ID('sp_ThemMonHoc') IS NOT NULL
	DROP PROC sp_ThemMonHoc
GO
CREATE PROC sp_ThemMonHoc
	@MABM BIGINT,
	@TENMH NVARCHAR(MAX),
	@KETQUA BIT OUTPUT
AS BEGIN
	BEGIN TRAN
		BEGIN TRY
			DECLARE @IS_EXIST BIT = (SELECT 1 FROM BOMON WHERE @MABM = BOMON.MABM)

			IF @IS_EXIST!=1
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