use QuanLyCauHoiTracNghiem
go

IF OBJECT_ID('sp_GVQLCAPQUYEN', 'P') IS NOT NULL
	DROP PROC SP_GVQLCAPQUYEN
GO

CREATE PROC sp_GVQLCAPQUYEN
	@MAGVQL BIGINT,
	@MAGV BIGINT,
	@VALUE BIT,
	@KETQUA BIT OUT
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			DECLARE @COUNT INT = (SELECT COUNT(ND.MALOAI)
									FROM NGUOIDUNG ND
									WHERE ND.MAND = @MAGVQL AND
											ND.MALOAI = 2)

			DECLARE @CUNGBM BIT = (SELECT 1
									FROM NGUOIDUNG ND1, NGUOIDUNG ND2
									WHERE ND1.MAND = @MAGV AND
											ND2.MAND = @MAGVQL AND
											ND1.MABM = ND2.MABM)

			IF @COUNT = 0 OR @CUNGBM != 1
			BEGIN
				SET @KETQUA = 0
				print @COUNT
			END

			IF @COUNT = 1 AND @CUNGBM = 1
			BEGIN
				UPDATE NGUOIDUNG
				SET TOANQUYENGV = @VALUE
				WHERE MAND = @MAGV

				SET @KETQUA = 1
			END
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @KETQUA = 0
		END CATCH
	COMMIT TRAN
END
GO