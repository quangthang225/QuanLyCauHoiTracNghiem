ALTER PROCEDURE sp_ThemCauHoi
@NoiDung nvarchar(max),
@ThangDiem float,
@MucDo int,
@MaMH bigint,
@Return bit out
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @validateInput BIT
			SET @validateInput = 1
			-- Kiểm tra tồn tại Môn học
			IF NOT EXISTS ( SELECT * FROM MONHOC WHERE @MaMH = MAMH )
			BEGIN
				SET @validateInput = 0
			END

			IF @validateInput = 1 
			BEGIN
				INSERT INTO CAUHOI(NOIDUNG,THANGDIEM,SOCAUTRALOI,MUCDO,MAMH) VALUES(@NoiDung,@ThangDiem,0,@MucDo,@MaMH)
				SET @Return = 1
			END
			ELSE
			BEGIN
				SET @Return = 0	
			END		
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO
