USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[SP_Lay_Thong_Tin_GV_Tu_Login]    Script Date: 07/06/2023 8:55:48 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_Lay_Thong_Tin_GV_Tu_Login]
@TENLOGIN nvarchar(100)
as 
declare @UID int
declare @MAGV nvarchar(100)

select @UID = uid , @MAGV = NAME from sys.sysusers
	where sid = SUSER_SID(@TENLOGIN)
select MAGV = @MAGV,
	   HOTEN = (select HO + ' ' + TEN from dbo.GIANGVIEN where MAGV=@MAGV),
	   TENNHOM = NAME
	from sys.sysusers
	  where UID = (select groupuid from sys.sysmembers where memberuid=@UID)




GO

