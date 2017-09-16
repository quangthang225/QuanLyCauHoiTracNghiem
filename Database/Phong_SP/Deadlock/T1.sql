USE [QuanLyCauHoiTracNghiem]

--Thực hiện cập nhật môn học có mã = x và đổi Tên môn học thành "***********" (coi như T1 không xảy ra lỗi)
-- Deadlock: khi T1 đang cập nhật thì T2 xóa môn học có mã là x
-- Khắc phục
DECLARE @KQ INT
EXEC sp_CapNhatMonHoc 102, 'VAN 33333', 2, @KQ
