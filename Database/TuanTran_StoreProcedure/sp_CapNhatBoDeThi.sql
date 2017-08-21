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