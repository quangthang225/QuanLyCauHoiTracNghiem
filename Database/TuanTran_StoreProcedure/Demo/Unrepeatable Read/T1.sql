SELECT * FROM CAUHOI WHERE NOIDUNG like '%Hello%' AND MUCDO = 3

DECLARE @Return nvarchar(500)
EXEC sp_LayDanhSachCauHoiTheoNoiDungVaMucDo_DEMO 'Hello', 3, @Return out
print @Return
