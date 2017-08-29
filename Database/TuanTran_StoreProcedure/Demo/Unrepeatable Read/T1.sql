SELECT * FROM CAUHOI WHERE NOIDUNG like '%Hello%' AND MUCDO = 1

DECLARE @Return nvarchar(500)
EXEC sp_LayDanhSachCauHoiTheoMucDO_DEMO 'Hello', 1, @Return out

