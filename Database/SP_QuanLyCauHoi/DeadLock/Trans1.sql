DECLARE @Macauhoi bigint = 2
DECLARE @Monhoc bigint = 5
DECLARE @Noidung nvarchar(max) = N'DeadLook1'
DECLARE @Socautraloi int = 5
DECLARE @Thangdiemdukien float = 9
DECLARE @Mucdo int = 3
DECLARE @Return nvarchar(500)

EXEC sp_CapNhatCauHoi @Macauhoi,@Monhoc,@Noidung,@Socautraloi,@Thangdiemdukien,@Mucdo,@Return out
print @Return