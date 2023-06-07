USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[SP_DS_HP]    Script Date: 07/06/2023 8:54:37 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_DS_HP]
@malop nchar(15),
@nienkhoa nchar(15),
@hocky int
as
begin 
	SET NOCOUNT ON;
	select HOTEN, ISNULL(HOCPHI,0) as HOCPHI, ISNULL(sum(SOTIENDONG), 0) as SOTIENDADONG
	from (select MASV, HOTEN = HO + ' ' + TEN from SINHVIEN where MALOP=@malop) SV join (select MASV, NIENKHOA, HOCKY, HOCPHI from HOCPHI where NIENKHOA=@nienkhoa and HOCKY=@hocky) HP on SV.MASV=HP.MASV
		 left join (select MASV, NIENKHOA, HOCKY, SOTIENDONG from CT_DONGHOCPHI where NIENKHOA=@nienkhoa and HOCKY=@hocky) CTDHP on CTDHP.MASV=SV.MASV
	group by HOTEN, HOCPHI
end
GO

