
USE [QuanLyCauHoiTracNghiem]
--Tìm môn học có Mã môn học là X và  Mã bộ môn là Y
--Lỗi Unrepeatable Read: T1 tìm và đếm có 1 môn học, trong thời gian đó T2 đổi Mã v=bộ môn thành Y' thì T1 kết quả tìm là không thấy
-- Khắc phục lỗi: SET TRAN ISOLATION LEVEL REPEATABLE READ CHO T1: ĐỌC PHẢI XIN VÀ GIỮ KHÓA ĐẾN HẾT GT

EXEC sp_LayDanhSachMonHoc '', 1 