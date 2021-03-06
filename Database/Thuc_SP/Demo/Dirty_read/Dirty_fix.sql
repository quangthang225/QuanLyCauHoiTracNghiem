
CREATE PROC SP_GVQLCAPQUYEN_FIX
	@MAGVQL BIGINT,
	@MAGV BIGINT
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
				ROLLBACK TRAN
				RETURN 0
			END

			IF @COUNT = 1 AND @CUNGBM = 1
			BEGIN
				UPDATE NGUOIDUNG
				SET TOANQUYENGV = 0
				WHERE MAND = @MAGV

				RETURN 1
			END

			--TEST
			WAITFOR DELAY '0:0:10'
			ROLLBACK TRAN
			RETURN 0
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			RETURN 0
		END CATCH
	COMMIT TRAN
END
GO

CREATE PROC SP_LOADDSGV_FIX
AS
--SET TRAN ISOLATION LEVEL READ UNCOMMITTED
BEGIN
	BEGIN TRAN
		BEGIN TRY 
			SELECT ND.MAND FROM NGUOIDUNG ND WHERE ND.TOANQUYENGV = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END