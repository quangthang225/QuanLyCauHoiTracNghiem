USE [master]

IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'QuanLyCauHoiTracNghiem')
	CREATE DATABASE [QuanLyCauHoiTracNghiem]
GO

USE [QuanLyCauHoiTracNghiem]
GO  

--HAVE TO RUN THESE LINES
IF NOT EXISTS(SELECT * from sys.extended_properties where class=0 and major_id=0 and minor_id=0 and name = N'SCHEMA_VERSION')
 EXEC sys.sp_addextendedproperty @name = N'SCHEMA_VERSION', @value = N'1.0';
ELSE
 EXEC sys.sp_updateextendedproperty @name = N'SCHEMA_VERSION', @value = N'1.0';
 GO

 DECLARE @date CHAR(10)
 SELECT @date = CONVERT(CHAR(10), GETDATE(), 101)
 IF NOT EXISTS(SELECT * from sys.extended_properties where class=0 and major_id=0 and minor_id=0 and name = N'SCHEMA_EXECUTION_DATE')
 EXEC sys.sp_addextendedproperty @name = N'SCHEMA_EXECUTION_DATE', @value = @date;
ELSE
 EXEC sys.sp_updateextendedproperty @name = N'SCHEMA_EXECUTION_DATE', @value = @date;
 GO
 --END HAVE TO RUN

IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LOAINGUOIDUNG]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LOAINGUOIDUNG](
	[MALOAI] [bigint] IDENTITY(1,1) NOT NULL,
	[TENLOAIND] [nvarchar](255) NOT NULL,
	 CONSTRAINT [PK_LOAINGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BOMON]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BOMON](
	[MABM] [bigint] IDENTITY(1,1) NOT NULL,
	[TENBM] [nvarchar](255) NOT NULL,
	 CONSTRAINT [PK_BOMON] PRIMARY KEY CLUSTERED 
(
	[MABM] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NGUOIDUNG]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NGUOIDUNG](
	[MAND] [bigint] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](255) NULL,
	[TENDANGNHAP] [varchar](30) NULL,
	[MATKHAU] [varchar](30) NULL,
	[TRANGTHAI] [bit] NULL,
	[TOANQUYENGV] [bit] NULL,
	[MALOAI] [bigint] NOT NULL,
	[MABM] [bigint] NOT NULL,
	[MAGVQL] [bigint] NULL,
	CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[MAND] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_LOAINGUOIDUNG] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAINGUOIDUNG] ([MALOAI])

ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_LOAINGUOIDUNG]

ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_BOMON] FOREIGN KEY([MABM])
REFERENCES [dbo].[BOMON] ([MABM])

ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_BOMON]

ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_NGUOIDUNG] FOREIGN KEY([MAGVQL])
REFERENCES [dbo].[NGUOIDUNG] ([MAND])

ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_NGUOIDUNG]
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BODETHI]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BODETHI](
	[MABDT] [bigint] IDENTITY(1,1) NOT NULL,
	[TENBDT] [nvarchar](255) NULL,
	[HOCKY] [int] NULL,
	[NAMHOC] [int] NULL,
	[MAGVTAO] [bigint] NOT NULL,
	CONSTRAINT [PK_BODETHI] PRIMARY KEY CLUSTERED 
(
	[MABDT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[BODETHI]  WITH CHECK ADD  CONSTRAINT [FK_BODETHI_NGUOIDUNG] FOREIGN KEY([MAGVTAO])
REFERENCES [dbo].[NGUOIDUNG] ([MAND])

ALTER TABLE [dbo].[BODETHI] CHECK CONSTRAINT [FK_BODETHI_NGUOIDUNG]

END
GO

IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MONHOC]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [bigint] IDENTITY(1,1) NOT NULL,
	[TENMH] [nvarchar](MAX) NULL,
	[MABM] [bigint] NOT NULL,
	CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[MONHOC]  WITH CHECK ADD  CONSTRAINT [FK_MONHOC_BOMON] FOREIGN KEY([MABM])
REFERENCES [dbo].[BOMON] ([MABM])

ALTER TABLE [dbo].[MONHOC] CHECK CONSTRAINT [FK_MONHOC_BOMON]
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CAUHOI]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CAUHOI](
	[MACH] [bigint] IDENTITY(1,1) NOT NULL,
	[NOIDUNG] [nvarchar](MAX) NULL,
	[THANGDIEM] [float] NULL,
	[SOCAUTRALOI] [int] NULL,
	[MUCDO] [int] NULL,
	[MAMH] [bigint] NOT NULL,
	CONSTRAINT [PK_CAUHOI] PRIMARY KEY CLUSTERED 
(
	[MACH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
ALTER TABLE [dbo].[CAUHOI]  WITH CHECK ADD  CONSTRAINT [FK_CAUHOI_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])

ALTER TABLE [dbo].[CAUHOI] CHECK CONSTRAINT [FK_CAUHOI_MONHOC]
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAOBODETHI]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAOBODETHI](
	[MABDT] [bigint] NOT NULL,
	[MACH] [bigint] NOT NULL,
	[DIEM] [float] NULL,
	PRIMARY KEY ([MABDT],[MACH])
)

ALTER TABLE [dbo].[TAOBODETHI]  WITH CHECK ADD  CONSTRAINT [FK_TAOBODETHI_BODETHI] FOREIGN KEY([MABDT])
REFERENCES [dbo].[BODETHI] ([MABDT])

ALTER TABLE [dbo].[TAOBODETHI] CHECK CONSTRAINT [FK_TAOBODETHI_BODETHI]

ALTER TABLE [dbo].[TAOBODETHI]  WITH CHECK ADD  CONSTRAINT [FK_TAOBODETHI_CAUHOI] FOREIGN KEY([MACH])
REFERENCES [dbo].[CAUHOI] ([MACH])

ALTER TABLE [dbo].[TAOBODETHI] CHECK CONSTRAINT [FK_TAOBODETHI_CAUHOI]
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CAUTRALOI]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CAUTRALOI](
	[MACTL] [bigint] IDENTITY(1,1) NOT NULL,
	[NOIDUNG] [nvarchar](MAX) NULL,
	LADAPANDUNG [bit] NULL,
	[MACH] [bigint] NOT NULL,
	CONSTRAINT [PK_CAUTRALOI] PRIMARY KEY CLUSTERED 
(
	[MACTL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
ALTER TABLE [dbo].[CAUTRALOI]  WITH CHECK ADD  CONSTRAINT [FK_CAUTRALOI_CAUHOI] FOREIGN KEY([MACH])
REFERENCES [dbo].[CAUHOI] ([MACH])

ALTER TABLE [dbo].[CAUTRALOI] CHECK CONSTRAINT [FK_CAUTRALOI_CAUHOI]
GO
