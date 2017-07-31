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