USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[SP_UPDATE_DIEM]    Script Date: 07/06/2023 8:56:52 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_UPDATE_DIEM]
@DIEMTHI TYPE_DANGKY READONLY
AS
begin
	merge into DANGKY as Target
	using (select MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK from @DIEMTHI) as Source
	on Target.MALTC = Source.MALTC and Target.MASV = Source.MASV
	when matched then
		update SET Target.DIEM_CC=Source.DIEM_CC, Target.DIEM_GK=Source.DIEM_GK, Target.DIEM_Ck=Source.DIEM_CK
	when not matched then
		insert (MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK)
			values (Source.MALTC, Source.MASV, Source.DIEM_CC, Source.DIEM_GK, Source.DIEM_CK);
end
GO

