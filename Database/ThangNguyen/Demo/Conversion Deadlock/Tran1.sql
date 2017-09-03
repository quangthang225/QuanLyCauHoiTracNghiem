declare @p9 int
set @p9=0
exec sp_CapNhatThongTin @MaND=16,@HoTen=N'Nguyen Thang',@TenDangNhap='quangthang225',@TrangThai=1,@ToanQuyenGV=0,@MaLoai=1,@MaBM=7,@MaGVQL=6,@Return=@p9 output
select @p9