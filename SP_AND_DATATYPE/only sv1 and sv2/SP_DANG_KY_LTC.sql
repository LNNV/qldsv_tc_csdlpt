USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[SP_DANG_KY_LTC]    Script Date: 07/06/2023 8:54:28 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DANG_KY_LTC]
@maltc int, @masv nchar(15)
as
begin
	set xact_abort on
	begin transaction;
	insert into DANGKY(MALTC, MASV, HUYDANGKY)
	values (@maltc, @masv, 'false')
	commit transaction;
end
GO

