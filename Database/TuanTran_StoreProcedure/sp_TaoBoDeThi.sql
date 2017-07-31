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