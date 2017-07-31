CREATE PROC sp_XoaCauHoi
@Macauhoi int,
@bit BIT OUTPUT
	AS 
BEGIN
BEGIN TRAN
BEGIN TRY
DELETE CauHoi
WHERE MaCauHoi = @Macauhoi 
set @bit = 1
END TRY
BEGIN CATCH
	ROLLBACK TRAN
	set @bit = 0
END CATCH
COMMIT TRAN
END
GO