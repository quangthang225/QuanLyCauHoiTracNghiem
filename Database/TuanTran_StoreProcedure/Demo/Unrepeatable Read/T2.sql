DECLARE @MACH BIGINT = 1
DECLARE @NOIDUNG nvarchar(max) = 'Hello, what is your name ?'
DECLARE @THANGDIEM FLOAT = 0.5
DECLARE @MUCDO INT = 1
DECLARE @MAMH BIGINT = 1
DECLARE @Return nvarchar(500)

EXEC sp_CapNhatCauHoi_DEMO @MACH, @NOIDUNG, @THANGDIEM, @MUCDO, @MAMH, @Return out
print @Return
