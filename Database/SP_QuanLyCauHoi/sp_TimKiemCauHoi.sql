CREATE PROCEDURE sp_TimKiemCauHoi
	@Macauhoi nvarchar(100),
	@Monhoc nvarchar(100),
	@LoaiMonHoc int,
	@MucDo nvarchar(100) ,
	@bit BIT OUTPUT
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT *
			FROM CAUHOI
			WHERE (MaCauHoi = @Macauhoi OR @Macauhoi = 0 ) 
					OR ( Monhoc like N'%' + @Monhoc + '%' OR @Monhoc = '' )
					OR ( LoaiMonHoc = @LoaiMonHoc OR @LoaiMonHoc = 0 )
					OR ( Mucdo like N'%' + @MucDo + '%' OR @MucDo = '' )
			SET @bit = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @bit = 0
		END CATCH
	COMMIT TRAN
END
GO