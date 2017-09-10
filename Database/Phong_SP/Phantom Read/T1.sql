USE [QuanLyCauHoiTracNghiem]
--Lấy danh sách môn học có Mã bộ môn là Y
--Lỗi Phantom: Khi T1 lấy danh sách, vừa đếm có n dữ liệu, thì T2 thêm 1 môn học có bộ môn cũng là Y nên số dữ liệu là n+1
--Khắc phục lỗi: 
EXEC sp_LayMonHoc 1 