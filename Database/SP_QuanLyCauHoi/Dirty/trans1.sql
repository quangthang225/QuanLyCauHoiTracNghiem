SELECT * FROM CAUHOI WHERE MACH = 2
DECLARE @Error nvarchar(500)
EXEC sp_XoaCauHoi_demo 4, @Error out
print @Error