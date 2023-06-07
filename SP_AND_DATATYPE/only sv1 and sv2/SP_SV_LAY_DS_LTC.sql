USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[SP_SV_LAY_DS_LTC]    Script Date: 07/06/2023 8:56:32 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_SV_LAY_DS_LTC]
    @NK nvarchar(10),
    @HK int
AS
BEGIN
    SELECT 
        LTC.MALTC,
        LTC.MAMH,
        TENMH,
        NHOM,
        HOTEN = HO + ' ' + TEN,
        COUNT(DK.MASV) AS SOSVDANGKY
    FROM
        (select MALTC, MAMH, NHOM, MAGV from LOPTINCHI where NIENKHOA=@NK and HOCKY=@HK and HUYLOP='FALSE') LTC
        JOIN MONHOC MH ON LTC.MAMH = MH.MAMH
        JOIN GIANGVIEN GV ON LTC.MAGV = GV.MAGV
        LEFT JOIN DANGKY DK ON LTC.MALTC = DK.MALTC
    GROUP BY
        LTC.MALTC,
        LTC.MAMH,
        TENMH,
        NHOM,
        HO,
        TEN
    ORDER BY
        TENMH,
        NHOM
END
GO

