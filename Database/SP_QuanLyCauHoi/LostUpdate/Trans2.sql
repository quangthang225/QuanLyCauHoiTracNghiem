DECLARE @Macauhoi bigint = 2
DECLARE @Monhoc bigint = 4
DECLARE @Return nvarchar(500)

EXEC sp_ThayDoiMonHoc @Macauhoi,@Monhoc,@Return out
print @Return