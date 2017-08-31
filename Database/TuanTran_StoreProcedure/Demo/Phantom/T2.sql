DECLARE @MABDT BIGINT = 1
DECLARE @MACH BIGINT = 3
DECLARE @Diem FLOAT = 0.5	
DECLARE @Return nvarchar(500) 


EXEC sp_ThemCauHoiVaoBoDeThi_DEMO @MABDT, @MACH, @Diem, @Return out