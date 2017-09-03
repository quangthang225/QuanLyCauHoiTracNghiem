USE [QuanLyCauHoiTracNghiem]

DECLARE @RT INT
EXEC @RT = sp_CapNhatMonHoc 1, 2 --Tìm môn học có Mã môn học là 1 và đổi Mã bộ môn thành 2
PRINT @RT