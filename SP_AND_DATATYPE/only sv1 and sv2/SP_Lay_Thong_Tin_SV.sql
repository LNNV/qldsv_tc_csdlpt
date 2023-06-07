USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[SP_Lay_Thong_Tin_SV]    Script Date: 07/06/2023 8:56:05 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_Lay_Thong_Tin_SV]
@MASV nvarchar(100),
@PASSWORD nvarchar(100)
as
	select HOTEN = (select HO + ' ' + TEN from dbo.SINHVIEN where MASV=@MASV and SINHVIEN.PASSWORD=@PASSWORD)
GO

