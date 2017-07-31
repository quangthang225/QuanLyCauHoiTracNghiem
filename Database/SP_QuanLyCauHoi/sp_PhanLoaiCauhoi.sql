CREATE PROC spa_CapNhatCauHoi
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