USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[SP_DS_SV_LTC]    Script Date: 07/06/2023 8:54:58 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DS_SV_LTC]
@nienkhoa nchar(15),
@hocky int,
@mamh nchar(15),
@nhom int
as
begin
	select SV.MASV, HO, TEN, PHAI, MALOP
	from (select MALTC from LOPTINCHI where MAMH=@mamh and NIENKHOA=@nienkhoa and HOCKY=@hocky and NHOM=@nhom and HUYLOP='False') LTC,
	DANGKY DK, SINHVIEN SV
	where DK.MALTC = LTC.MALTC and SV.MASV = DK.MASV
	order by HO, TEN
end
GO

