﻿/* 21HTTT1 - 21CLC1.CSDLNC.03
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127296 - Đặng Hà Huy
 * 21127315 - Nguyễn Gia Khánh
 * 21127712 - Lê Quang Trường
 */
USE [NC03_QLNhaKhoa]
GO

CREATE OR ALTER FUNCTION F_MAKE_ID
    (@TYPE CHAR(2), @ID CHAR(7))
RETURNS CHAR(7) AS BEGIN
    IF (@ID IS NULL) SET @ID = @TYPE + '00001'
    ELSE BEGIN
        SET @ID = CAST(RIGHT(@ID, 5) AS INT) + 1
        SET @ID = @TYPE + RIGHT('00000'
            + CAST(@ID AS CHAR(5)), 5)
    END
    RETURN @ID
END
GO