DECLARE @Macauhoi bigint = 2
DECLARE @Return nvarchar(500)

EXEC sp_XoaCauHoi @Macauhoi,@Return out
print @Return