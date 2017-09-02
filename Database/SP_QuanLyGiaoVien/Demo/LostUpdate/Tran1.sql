declare @p9 int
set @p9=0
exec sp_CapNhatThongTin @MaND=14,@HoTen=N'Nguyen Le Quang Thang',@TenDangNhap='thangnguyen',@TrangThai=1,@ToanQuyenGV=0,@MaLoai=1,@MaBM=1,@MaGVQL=9,@Return=@p9 output
select @p9