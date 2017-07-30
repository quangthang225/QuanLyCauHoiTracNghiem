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
	COMMIT
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
				SET @return = 0;
			END 

			SELECT *
			FROM TAOBODETHI
			WHERE MABDT = @MABDT
			SET @return = 1;
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			RETURN 0
		END CATCH
	COMMIT
END
GO