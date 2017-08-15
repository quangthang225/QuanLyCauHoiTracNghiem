USE [QuanLyCauHoiTracNghiem]
GO  

--1.Số đáp án của 1 câu hỏi là từ 2 tới 10 đáp án
CREATE TRIGGER tg_SoLuongCauTraLoiCuaCauHoi ON CAUTRALOI
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	DECLARE @SoLuongCauTraLoi INTEGER
	
	IF NOT EXISTS( SELECT * FROM deleted)
	BEGIN
		--trường hợp insert
		SELECT @SoLuongCauTraLoi = COUNT(C.MACH) FROM CAUTRALOI C,inserted I WHERE C.MACH = I.MACH 
		IF ( @SoLuongCauTraLoi > 10 ) 
		BEGIN
			RAISERROR ('Số câu trả lời của 1 câu hỏi phải là từ 2 tới 10.', 16, 1);  
			ROLLBACK TRANSACTION;  
		END
	END
	ELSE
	BEGIN
		IF NOT EXISTS ( SELECT * FROM inserted )
		BEGIN
			--trường hợp delete
			SELECT @SoLuongCauTraLoi = COUNT(C.MACH) FROM CAUTRALOI C,deleted I WHERE C.MACH = I.MACH 
			IF ( @SoLuongCauTraLoi < 2 ) 
			BEGIN
				RAISERROR ('Số câu trả lời của 1 câu hỏi là từ 2 tới 10.', 16, 1);  
				ROLLBACK TRANSACTION;  
			END
		END
		ELSE
		BEGIN
			--trường hợp update
			SELECT @SoLuongCauTraLoi = COUNT(C.MACH) FROM CAUTRALOI C,inserted I WHERE C.MACH = I.MACH 
			IF ( @SoLuongCauTraLoi < 2 OR @SoLuongCauTraLoi > 10 ) 
			BEGIN
				RAISERROR ('Số câu trả lời của 1 câu hỏi là từ 2 tới 10.', 16, 1);  
				ROLLBACK TRANSACTION;  
			END
		END
	END
END
GO

CREATE TRIGGER tg_SoCauTraLoiCuaCauHoi ON CAUHOI
AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @SoLuongCauTraLoi INTEGER
	
	SELECT @SoLuongCauTraLoi = C.SOCAUTRALOI FROM CAUHOI C,inserted I WHERE C.MACH = I.MACH 
	IF ( @SoLuongCauTraLoi < 2 OR @SoLuongCauTraLoi > 10 ) 
	BEGIN
		RAISERROR ('Số câu trả lời của 1 câu hỏi phải là từ 2 tới 10.', 16, 1);  
		ROLLBACK TRANSACTION;  
	END
	
END
GO

--2.Điểm của một bộ đề thi tối đa là 10 

--3.Một câu hỏi phải có tối thiểu 1 đáp án đúng
CREATE TRIGGER tg_MotCauHoiPhaiCoToiThieuMotDapAnDung ON CAUTRALOI
AFTER UPDATE, DELETE
AS
BEGIN
	DECLARE @SoLuongCauTraLoiDung INTEGER
	
	SELECT @SoLuongCauTraLoiDung = COUNT(*) FROM CAUTRALOI C,deleted I WHERE C.MACH = I.MACH AND C.LADAPANDUNG = 1 
	IF ( @SoLuongCauTraLoiDung < 1 ) 
	BEGIN
		RAISERROR ('Một câu hỏi phải có tối thiểu 1 đáp án đúng', 16, 1);  
		ROLLBACK TRANSACTION;  
	END
END
GO

--4.Khi chỉnh sửa câu hỏi, nếu chỉnh sửa số câu trả lời thì thuộc tính "Số lượng câu trả lời" phải cập nhật lại.

CREATE TRIGGER tg_CapNhatTuDongSoLuongCauTraLoiCuaCauHoi ON CAUTRALOI
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	DECLARE @SoLuongCauTraLoi INT
	IF NOT EXISTS( SELECT * FROM deleted)
	BEGIN
		--trường hợp insert
		SELECT @SoLuongCauTraLoi = COUNT(C.MACH) FROM CAUTRALOI C,inserted I WHERE C.MACH = I.MACH 
		UPDATE CAUHOI SET SOCAUTRALOI = @SoLuongCauTraLoi WHERE MACH IN ( SELECT MACH FROM inserted )
	END
	ELSE
	BEGIN
		IF NOT EXISTS ( SELECT * FROM inserted )
		BEGIN
			--trường hợp DELETE
			SELECT @SoLuongCauTraLoi = COUNT(C.MACH) FROM CAUTRALOI C,deleted I WHERE C.MACH = I.MACH 
			UPDATE CAUHOI SET SOCAUTRALOI = @SoLuongCauTraLoi WHERE MACH IN ( SELECT MACH FROM deleted )
		END
		ELSE
		BEGIN
			--trường hợp UPDATE
			SELECT @SoLuongCauTraLoi = COUNT(C.MACH) FROM CAUTRALOI C,inserted I WHERE C.MACH = I.MACH 
			UPDATE CAUHOI SET SOCAUTRALOI = @SoLuongCauTraLoi WHERE MACH IN ( SELECT MACH FROM inserted )
			SELECT @SoLuongCauTraLoi = COUNT(C.MACH) FROM CAUTRALOI C,deleted I WHERE C.MACH = I.MACH 
			UPDATE CAUHOI SET SOCAUTRALOI = @SoLuongCauTraLoi WHERE MACH IN ( SELECT MACH FROM deleted )
		END
	END
END
GO

--5.Bộ đề thi chỉ chứa câu hỏi của một môn học duy nhất

CREATE TRIGGER tg_BoDeThiChiChuaCauHoiCuaMotMonHocDuyNhat ON TAOBODETHI
AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @SoLuongMonHocCuaBoDeThi INT
	SELECT @SoLuongMonHocCuaBoDeThi = COUNT(*) FROM ( 
		SELECT c.MAMH FROM TAOBODETHI t, CauHoi c,inserted i WHERE i.MABDT = t.MABDT AND t.MACH = c.MACH
		GROUP BY c.MAMH	
	) as a
	IF ( @SoLuongMonHocCuaBoDeThi >1 )
	BEGIN
		RAISERROR ('Bộ đề thi chỉ chứa câu hỏi của một môn học duy nhất', 16, 1);  
		ROLLBACK TRANSACTION; 
	END
END
GO
