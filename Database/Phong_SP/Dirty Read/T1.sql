USE [QuanLyCauHoiTracNghiem]

--Thực hiện cập nhật môn học có mã = 1 và Mã bộ môn là x và đổi Tên môn học thành tên có kí tự đặc biệt
-- Dirty Read: Trong quá trình thực hiện thì T1 rollback vì Tên môn học không hợp lệ, nhưng T2 vẫn nhìn thấy được dữ liệu
-- Khắc phụ Dirty Read: SET TRAN ISOLATION LEVEL READ COMMITTED: T2 sẽ đợi T1 chạy xong thì T2 mới chạy
DECLARE @KQ INT
EXEC sp_CapNhatMonHoc 3, '$%$% KHONG HOP LE', 1, @KQ