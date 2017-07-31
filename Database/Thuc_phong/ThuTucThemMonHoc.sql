IF OBJECT_ID('SP_THEMMONHOC') IS NOT NULL
	DROP PROC SP_THEMMONHOC
GO
CREATE PROC SP_THEMMONHOC
	@MAGVQL BIGINT,
	@MABM BIGINT,
	@TENMH NVARCHAR(MAX),
	@KETQUA BIT OUTPUT
AS BEGIN
	BEGIN TRAN
		BEGIN TRY
			DECLARE @IS_EXIST BIT = (SELECT 1 FROM BOMON WHERE @MABM = BOMON.MABM)

			DECLARE @COUNT INT = (SELECT COUNT(ND.MALOAI)
										FROM NGUOIDUNG ND
										WHERE ND.MAND = @MAGVQL AND
												ND.MALOAI = 1)

			IF @IS_EXIST!=1 OR @COUNT = 0
			BEGIN 
				SET @KETQUA = 0  
				RETURN 
			END

			INSERT INTO MONHOC(MABM, TENMH) VALUES (@MABM, @TENMH)
			SET @KETQUA = 1
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @KETQUA = 0
		END CATCH
	COMMIT TRAN
END
GO 