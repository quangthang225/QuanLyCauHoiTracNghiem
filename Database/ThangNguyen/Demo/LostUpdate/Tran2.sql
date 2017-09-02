declare @p3 int
set @p3=0
exec sp_ThayDoiGVQL @MaND=14,@MaGVQL=9,@Return=@p3 output
select @p3