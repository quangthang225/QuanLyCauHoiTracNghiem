DECLARE @NOIDUNG nvarchar(max) = 'LostUpdate test1132' 
DECLARE @LADAPANDUNG bit = 1
DECLARE @MACH bigint = 3
DECLARE @Return nvarchar(500)


EXEC sp_ThemCauTraLoiVaoCauHoi_DEMO @NOIDUNG,@LADAPANDUNG,@MACH,@Return out
print @Return

