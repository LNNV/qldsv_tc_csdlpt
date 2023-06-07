USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[SP_BANG_DIEM_LTC]    Script Date: 07/06/2023 8:53:39 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_BANG_DIEM_LTC]
@nienkhoa nchar(15),
@hocky int,
@mamh nchar(15),
@nhom int
as
begin
	select SV.MASV, HO, TEN, DIEM_CC, DIEM_GK, DIEM_CK
	from (select MALTC from LOPTINCHI where MAMH=@mamh and NIENKHOA=@nienkhoa and HOCKY=@hocky and NHOM=@nhom and HUYLOP='False') LTC,
	DANGKY DK, SINHVIEN SV
	where DK.MALTC = LTC.MALTC and SV.MASV = DK.MASV
	order by HO, TEN
end
GO

