declare @p2 int
set @p2=0
exec sp_XoaBoMon @MaBM=11,@Return=@p2 output
select @p2