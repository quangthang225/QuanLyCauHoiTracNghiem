declare @p3 bigint
set @p3=NULL
declare @p4 bit
set @p4=0
declare @p5 bit
set @p5=0
exec sp_DangNhap @tenDangNhap='thang',@matKhau='thang',@maNguoiDung=@p3 output,@return=@p4 output,@islocked=@p5 output
