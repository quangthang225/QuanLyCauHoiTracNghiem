DECLARE @MABDT BIGINT = 1
DECLARE @Return nvarchar(500) 

EXEC sp_LayDanhSachCauHoiTheoDeThi_DEMO @MABDT, @Return out

DELETE FROM TAOBODETHI WHERE MACH = 3