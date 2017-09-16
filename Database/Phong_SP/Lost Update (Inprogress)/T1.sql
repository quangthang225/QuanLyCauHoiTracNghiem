USE [QuanLyCauHoiTracNghiem]

--Thực hiện cập nhật môn học có mã = 1 và đổi Tên môn học thành VAN
-- Lost update: Trong khi T1 đang cập nhật Tên môn học, T2 vào đổi tên chính môn ấy
-- Khắc phục Lost update: : T2 sẽ đợi T1 chạy xong thì T2 mới chạy

DECLARE @KQ INT
EXEC sp_CapNhatMonHoc 1, 'KHONG HOP LE @@@@', 1, @KQ
--WAITFOR DELAY '0:0:10'
--SELECT * FROM MONHOC