

CREATE PROC sp_UpdateToanQuyenGV1_Fix
	@MaGV bigint,
	@MaGVQL bigint
AS
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM NGUOIDUNG ND 
								WHERE ND.MAND = @MaGV AND 
										ND.MAGVQL = @MaGVQL)
		BEGIN
			COMMIT TRAN
			RETURN 0
		END

		DECLARE @VALUE BIT = (SELECT ND.TOANQUYENGV FROM NGUOIDUNG ND WHERE ND.MAND = @MaGV)

		--TEST
		WAITFOR DELAY '0:0:10'
		UPDATE NGUOIDUNG
		SET TOANQUYENGV = 1 - @VALUE
		WHERE MAND = @MaGV
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		RETURN 0
	END CATCH
COMMIT TRAN
RETURN 1
GO

CREATE PROC sp_UpdateToanQuyenGV2_Fix
	@MaGV bigint,
	@MaGVQL bigint
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM NGUOIDUNG ND 
								WHERE ND.MAND = @MaGV AND 
										ND.MAGVQL = @MaGVQL)
		BEGIN
			COMMIT TRAN
			RETURN 0
		END

		DECLARE @VALUE BIT = (SELECT ND.TOANQUYENGV FROM NGUOIDUNG ND WHERE ND.MAND = @MaGV)


		UPDATE NGUOIDUNG
		SET TOANQUYENGV = 1 - @VALUE
		WHERE MAND = @MaGV
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		RETURN 0
	END CATCH
COMMIT TRAN
RETURN 1
GO