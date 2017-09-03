
CREATE PROC SP_LOAD_DSGV_CUNG_GVQL
	@MAGVQL BIGINT
AS
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF NOT EXISTS(SELECT COUNT(ND.MALOAI)
							FROM NGUOIDUNG ND
							WHERE ND.MAND = @MAGVQL AND
									ND.MALOAI = 2) -- 2: GVQL)
			BEGIN
				ROLLBACK TRAN
				RETURN 0
			END
			
			DECLARE @COUNT INT = (SELECT COUNT(*) FROM NGUOIDUNG WHERE MAGVQL = @MAGVQL)
			PRINT 'CO: ' + @COUNT + ' GV THUOC CUNG GVQL LA ' + @MAGVQL + ' :'
			WAITFOR DELAY '0:0:10'
			SELECT * FROM NGUOIDUNG WHERE MAGVQL = @MAGVQL
			RETURN 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			RETURN 0
		END CATCH
	COMMIT TRAN
END
GO

CREATE PROC SP_UPDATEGVQL
	@MAGV BIGINT,
	@MAGVQL BIGINT
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF NOT EXISTS (SELECT *
							FROM NGUOIDUNG ND
							WHERE ND.MAND = @MAGVQL AND
									ND.MALOAI = 2) -- 2: GVQL
			BEGIN
				ROLLBACK TRAN
				RETURN 0
			END

			UPDATE NGUOIDUNG
			SET MAGVQL = @MAGVQL
			WHERE MAND = @MAGV

			RETURN 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			RETURN 0
		END CATCH
	COMMIT TRAN
END
GO