USE [QuanLyCauHoiTracNghiem]

--Thực hiện đổi mã Bộ môn của Môn học
DECLARE @KQ INT
EXEC sp_CapNhatMonHoc 1, 'TEN HOP LE 22', 1, @KQ