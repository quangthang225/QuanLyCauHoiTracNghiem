USE [QuanLyCauHoiTracNghiem]

DECLARE @RT INT
EXEC @RT = sp_CapNhatMonHoc 1, 2 --Tìm môn học có Mã môn học là X và đổi Mã bộ môn thành Y'
PRINT @RT