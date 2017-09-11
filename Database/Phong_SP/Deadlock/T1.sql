USE [QuanLyCauHoiTracNghiem]

--Thực hiện cập nhật môn học có mã = 1 và đổi Tên môn học thành VAN
-- Deadlock: khi T1 đang cập nhật thì T2 xóa môn học có mã là 1
-- Khắc phục
EXEC sp_CapNhatMonHoc 7,'VAN'
