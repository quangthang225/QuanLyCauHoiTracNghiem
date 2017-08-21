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

