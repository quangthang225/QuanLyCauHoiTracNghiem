USE [QuanLyCauHoiTracNghiem]

DECLARE @KQ INT
EXEC sp_CapNhatMonHoc 1, 'MON HOC MOI', 2, @KQ --Tìm môn học có Mã môn học là X và đổi Mã bộ môn thành Y'
