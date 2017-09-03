﻿CREATE PROC sp_Laydanhsachcauhoi 
@Macauhoi bigint,
@Return nvarchar(500) out
AS
BEGIN
	BEGIN TRY
		SET TRAN ISOLATION LEVEL READ COMMITTED -- mức cô lập mặc định
		BEGIN TRAN
			IF NOT EXISTS ( SELECT * FROM CAUHOI WHERE @Macauhoi = MACH )
			BEGIN
				SET @Return = N'KHONG TON TAI CAU HOI NAY'
			END
			SELECT * FROM CAUHOI WHERE [MACH] = @MaCauHoi
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SET @Return = ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END