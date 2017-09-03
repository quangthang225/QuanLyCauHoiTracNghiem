DECLARE @Monhoc bigint = 3
DECLARE @Noidung nvarchar(max) = N'phantom1'
DECLARE @Socautraloi int = 5
DECLARE @Thangdiemdukien float = 9
DECLARE @Mucdo int = 3
DECLARE @Return nvarchar(500)


EXEC sp_ThemCauHoi @Monhoc, @Noidung, @Socautraloi, @Thangdiemdukien, @Mucdo, @Return out