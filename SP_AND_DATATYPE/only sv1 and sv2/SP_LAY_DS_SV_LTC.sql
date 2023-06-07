USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[SP_LAY_DS_SV_LTC]    Script Date: 07/06/2023 8:55:29 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_LAY_DS_SV_LTC]
@MALTC int
as 
begin 
	select SV.MASV, HOTENSV=HO+' '+TEN, DIEM_CC, DIEM_GK, DIEM_CK
		from (select MASV, DIEM_CC, DIEM_GK, DIEM_CK from DANGKY where MALTC = @MALTC and HUYDANGKY='FALSE') DSDK,
		SINHVIEN SV
		where DSDK.MASV = SV.MASV
	order by SV.MASV
end
GO

