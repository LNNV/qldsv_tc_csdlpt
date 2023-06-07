USE [QLDSV_TC]
GO

/****** Object:  UserDefinedTableType [dbo].[TYPE_DANGKY]    Script Date: 07/06/2023 8:57:56 CH ******/
CREATE TYPE [dbo].[TYPE_DANGKY] AS TABLE(
	[MALTC] [int] NULL,
	[MASV] [nchar](10) NULL,
	[DIEM_CC] [int] NULL,
	[DIEM_GK] [float] NULL,
	[DIEM_CK] [float] NULL
)
GO

