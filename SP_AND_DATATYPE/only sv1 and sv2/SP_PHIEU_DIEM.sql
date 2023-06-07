USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[SP_PHIEU_DIEM]    Script Date: 07/06/2023 8:56:22 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_PHIEU_DIEM]
@masv nchar(15)
as
begin
	select TENMH, DIEM_CC, DIEM_GK, DIEM_CK, max(DIEM_HM) as DIEM_HM
	from (
		select TENMH, DIEM_CC, DIEM_GK, DIEM_CK, DIEM_HM = (DIEM_CC*0.1 + DIEM_GK*0.3 + DIEM_CK*0.6),
		ROW_NUMBER() OVER (PARTITION BY TENMH ORDER BY (DIEM_CC*0.1 + DIEM_GK*0.3 + DIEM_CK*0.6) DESC) AS rn
		from (select MALTC, DIEM_CC, DIEM_GK, DIEM_CK from DANGKY where MASV=@masv ) DK,
		MONHOC MH, LOPTINCHI LTC
		where DK.MALTC=LTC.MALTC and MH.MAMH=LTC.MAMH
		group by TENMH, DIEM_CC, DIEM_GK, DIEM_CK
	) as subquery
	where rn = 1
	group by TENMH, DIEM_CC, DIEM_GK, DIEM_CK
	order by TENMH
end
GO

