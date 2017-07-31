CREATE PROC sp_CapNhatCauHoi
	@Macauhoi nvarchar(100),
	@Monhoc nvarchar(100),
	@Noidung nvarchar(Max),
	@Socautraloi int,
	@LoaiMonHoc int,
	@Thangdiemdukien int,
	@bit BIT OUTPUT
	AS 
BEGIN
BEGIN TRAN
BEGIN TRY
UPDATE CAUHOI  
SET Monhoc = @Monhoc,
Noidung = @Noidung,
Socautraloi = @Socautraloi,
LoaiMonHoc = @LoaiMonHoc,
Thangdiemdukien = @Thangdiemdukien
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