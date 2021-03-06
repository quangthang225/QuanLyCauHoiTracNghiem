CREATE PROCEDURE sp_LayDanhSachNguoiDung
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT nd.*,lnd.TENLOAIND, bm.TENBM, nd2.HOTEN AS TENGVQL FROM NGUOIDUNG nd,NGUOIDUNG nd2,BOMON bm, LOAINGUOIDUNG lnd WHERE nd.MABM = bm.MABM and nd.MALOAI = lnd.MALOAI and nd.MAGVQL = nd2.MAND and nd.MAGVQL IS NOT NULL
			UNION
			SELECT nd.*,lnd.TENLOAIND, bm.TENBM, NULL FROM NGUOIDUNG nd,BOMON bm, LOAINGUOIDUNG lnd WHERE nd.MABM = bm.MABM and nd.MALOAI = lnd.MALOAI and nd.MAGVQL IS NULL
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN
END
GO