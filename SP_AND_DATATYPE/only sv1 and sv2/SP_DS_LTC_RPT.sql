USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[SP_DS_LTC_RPT]    Script Date: 07/06/2023 8:54:47 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DS_LTC_RPT]
@NK nvarchar(10), @HK int
as 
begin 
	select TENMH, NHOM, HOTEN_GV = HO+' '+TEN, SOSVTOITHIEU, COUNT(DK.MASV) AS SOSVDANGKY
		FROM
        (select MALTC, MAMH, NHOM, MAGV, SOSVTOITHIEU from LOPTINCHI where NIENKHOA=@NK and HOCKY=@HK and HUYLOP='FALSE') LTC
        JOIN MONHOC MH ON LTC.MAMH = MH.MAMH
        JOIN GIANGVIEN GV ON LTC.MAGV = GV.MAGV
        LEFT JOIN DANGKY DK ON LTC.MALTC = DK.MALTC
	GROUP BY
        LTC.MALTC,
        LTC.MAMH,
        TENMH,
        NHOM,
        HO,
        TEN,
		SOSVTOITHIEU
	order by TENMH, NHOM
end

GO

