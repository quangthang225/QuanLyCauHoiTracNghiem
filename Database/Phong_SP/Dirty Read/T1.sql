USE [QuanLyCauHoiTracNghiem]

--Thực hiện cập nhật môn học có mã = 1 và đổi Tên môn học thành VAN
-- Dirty Read: Trong quá trình thực hiện thì T1 rollback, nhưng T2 vẫn nhìn thấy được dữ liệu
-- Khắc phụ Dirty Read: SET TRAN ISOLATION LEVEL READ COMMITTED: T2 sẽ đợi T1 chạy xong thì T2 mới chạy
EXEC sp_CapNhatMonHoc 1, 'VAN'