﻿/* 21HTTT1 - 21CLC1.CSDLNC.03
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127296 - Đặng Hà Huy
 * 21127315 - Nguyễn Gia Khánh
 * 21127712 - Lê Quang Trường
 */
USE [NC03_QLNhaKhoa]
GO

CREATE OR ALTER PROC USP_GHICHU_INS
    @IDHOSO CHAR(7),
    @THONGTIN NVARCHAR(200),
    @LOAIGHICHU INT, -- 0: TÌNH TRẠNG DỊ ỨNG, 1: CHỐNG CHỈ ĐỊNH THUỐC
    @IDGHICHU CHAR(7) = NULL OUTPUT
AS BEGIN TRAN
    IF NOT EXISTS (SELECT * FROM HOSOBENHNHAN WHERE IDHOSO = @IDHOSO) BEGIN
        RAISERROR('INVALID IDHOSO', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF @LOAIGHICHU != 0 AND @LOAIGHICHU != 1 BEGIN
        RAISERROR('INVALID LOAIGHICHU', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    SELECT @IDGHICHU = IDGHICHU FROM GHICHU
    WHERE IDGHICHU = (SELECT MAX(IDGHICHU) FROM GHICHU
        WHERE IDHOSO = @IDHOSO)

    SET @IDGHICHU = dbo.F_MAKE_ID('GC', @IDGHICHU)

    INSERT INTO GHICHU
    VALUES (@IDHOSO, @IDGHICHU, @THONGTIN, GETDATE(), @LOAIGHICHU)
COMMIT TRAN
RETURN 0
GO

CREATE OR ALTER PROC USP_GHICHU_UPD
    @IDHOSO CHAR(7),
    @IDGHICHU CHAR(7),
    @THONGTIN NVARCHAR(200),
    @LOAIGHICHU INT -- 0: TÌNH TRẠNG DỊ ỨNG, 1: CHỐNG CHỈ ĐỊNH THUỐC
AS BEGIN TRAN
    IF NOT EXISTS (SELECT * FROM GHICHU WHERE IDHOSO = @IDHOSO
        AND IDGHICHU = @IDGHICHU) BEGIN
        RAISERROR('INVALID GHICHU', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF @LOAIGHICHU != 0 AND @LOAIGHICHU != 1 BEGIN
        RAISERROR('INVALID LOAIGHICHU', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    UPDATE GHICHU SET THONGTIN = @THONGTIN, NGAYCAPNHAT = GETDATE(),
        LOAIGHICHU = @LOAIGHICHU
    WHERE IDHOSO = @IDHOSO AND IDGHICHU = @IDGHICHU
COMMIT TRAN
RETURN 0
GO