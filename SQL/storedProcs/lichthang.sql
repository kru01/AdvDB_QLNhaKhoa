﻿/* 21HTTT1 - 21CLC1.CSDLNC.03
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127296 - Đặng Hà Huy
 * 21127315 - Nguyễn Gia Khánh
 * 21127712 - Lê Quang Trường
 */
USE [NC03_QLNhaKhoa]
GO

CREATE OR ALTER PROC USP_LICHTHANG_INS
    @IDNHASI CHAR(7),
    @NGAYTRONGTHANG INT,
    @IDLT CHAR(7) = NULL OUTPUT
AS BEGIN TRAN
    IF NOT EXISTS (SELECT * FROM TAIKHOAN WHERE IDTAIKHOAN = @IDNHASI) BEGIN
        RAISERROR('INVALID IDNHASI', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF @NGAYTRONGTHANG < 0 OR @NGAYTRONGTHANG > 31 BEGIN
        RAISERROR('INVALID NGAYTRONGTHANG, MUST BE FROM 0 TO 31', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    SELECT @IDLT = IDLT FROM LICHTHANG
    WHERE IDLT = (SELECT MAX(IDLT) FROM LICHTHANG
        WHERE IDNHASI = @IDNHASI)

    SET @IDLT = dbo.F_MAKE_ID('HS', @IDLT)

    INSERT INTO LICHTHANG
    VALUES (@IDNHASI, @IDLT, @NGAYTRONGTHANG)
COMMIT TRAN
RETURN 0
GO