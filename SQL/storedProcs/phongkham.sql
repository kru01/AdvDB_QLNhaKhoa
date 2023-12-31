﻿/* 21HTTT1 - 21CLC1.CSDLNC.03
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127296 - Đặng Hà Huy
 * 21127315 - Nguyễn Gia Khánh
 * 21127712 - Lê Quang Trường
 */
USE [NC03_QLNhaKhoa]
GO

CREATE OR ALTER PROC USP_PHONGKHAM_INS
    @EMAIL VARCHAR(30),
    @SDT VARCHAR(11),
    @DIACHI NVARCHAR(200),
    @GIOMOCUA INT,
    @GIODONGCUA INT,
    @IDPHONGKHAM CHAR(7) = NULL OUTPUT
AS BEGIN TRAN
    IF @GIOMOCUA < 0 OR @GIODONGCUA < 0 BEGIN
        RAISERROR('INVALID GIO', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    SELECT @IDPHONGKHAM = IDPHONGKHAM FROM PHONGKHAM
    WHERE IDPHONGKHAM = (SELECT MAX(IDPHONGKHAM) FROM PHONGKHAM)

    SET @IDPHONGKHAM = dbo.F_MAKE_ID('PK', @IDPHONGKHAM)

    INSERT INTO PHONGKHAM
    VALUES (@IDPHONGKHAM, @EMAIL, @SDT, @DIACHI,
        @GIOMOCUA, @GIODONGCUA)
COMMIT TRAN
RETURN 0
GO