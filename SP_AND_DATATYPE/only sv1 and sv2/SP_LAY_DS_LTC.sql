USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[SP_LAY_DS_LTC]    Script Date: 07/06/2023 8:55:13 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_LAY_DS_LTC]
@NK nvarchar(10), @HK int
as 
begin 
	select MALTC, TENMH, NHOM, HOTEN = HO+' '+TEN
		from (select MALTC, MAMH, NHOM, MAGV from LOPTINCHI where NIENKHOA=@NK and HOCKY=@HK and HUYLOP='FALSE') LTC,
		MONHOC MH, GIANGVIEN GV
		where LTC.MAMH = MH.MAMH and LTC.MAGV=GV.MAGV
	order by TENMH, NHOM
end
GO

