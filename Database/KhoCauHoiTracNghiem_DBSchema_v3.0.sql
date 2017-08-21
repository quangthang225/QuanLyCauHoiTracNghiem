USE [master]

IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'QuanLyCauHoiTracNghiem')
	CREATE DATABASE [QuanLyCauHoiTracNghiem]
GO

USE [QuanLyCauHoiTracNghiem]
GO  

--HAVE TO RUN THESE LINES
IF NOT EXISTS(SELECT * from sys.extended_properties where class=0 and major_id=0 and minor_id=0 and name = N'SCHEMA_VERSION')
 EXEC sys.sp_addextendedproperty @name = N'SCHEMA_VERSION', @value = N'3.0';
ELSE
 EXEC sys.sp_updateextendedproperty @name = N'SCHEMA_VERSION', @value = N'3.0';
 GO

 DECLARE @date CHAR(10)
 SELECT @date = CONVERT(CHAR(10), GETDATE(), 101)
 IF NOT EXISTS(SELECT * from sys.extended_properties where class=0 and major_id=0 and minor_id=0 and name = N'SCHEMA_EXECUTION_DATE')
 EXEC sys.sp_addextendedproperty @name = N'SCHEMA_EXECUTION_DATE', @value = @date;
ELSE
 EXEC sys.sp_updateextendedproperty @name = N'SCHEMA_EXECUTION_DATE', @value = @date;
 GO
 --END HAVE TO RUN

ALTER TABLE BODETHI ADD MAMH BIGINT NULL

ALTER TABLE [dbo].[BODETHI]  WITH CHECK ADD  CONSTRAINT [FK_BODETHI_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])

ALTER TABLE [dbo].[BODETHI] CHECK CONSTRAINT [FK_BODETHI_MONHOC]