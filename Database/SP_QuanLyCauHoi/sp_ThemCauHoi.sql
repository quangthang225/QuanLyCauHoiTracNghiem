CREATE PROC spa_ThemCauHoi
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
INSERT INTO CauHoi 
([MaCauHoi],
[Monhoc],
[Noidung],
[Socautraloi],
[LoaiMonHoc],
[Thangdiemdukien])
VALUES (@Macauhoi ,
@Monhoc ,
@Noidung ,
@Socautraloi ,
@LoaiMonHoc ,
@Thangdiemdukien)
set @bit = 1
END TRY
BEGIN CATCH
	ROLLBACK TRAN
	set @bit = 0
END CATCH
COMMIT TRAN
END
GO