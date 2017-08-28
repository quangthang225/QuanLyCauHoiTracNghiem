SELECT * FROM CAUHOI WHERE MACH = 1
SELECT * FROM CAUTRALOI WHERE MACH = 1

DECLARE @Error nvarchar(500)
EXEC sp_ThemCauTraLoiVaoCauHoi N'Tuấn Trần', 0, 1, @Error out
print @Error

