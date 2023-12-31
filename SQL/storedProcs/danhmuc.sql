/* 21HTTT1 - 21CLC1.CSDLNC.03
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127296 - Đặng Hà Huy
 * 21127315 - Nguyễn Gia Khánh
 * 21127712 - Lê Quang Trường
 */
USE [NC03_QLNhaKhoa]
GO

CREATE OR ALTER PROC USP_DANHMUC_INS
    @TENDANHMUC NVARCHAR(100),
    @IDDANHMUC CHAR(7) = NULL OUTPUT
AS BEGIN TRAN
    SELECT @IDDANHMUC = IDDANHMUC FROM DANHMUC
    WHERE IDDANHMUC = (SELECT MAX(IDDANHMUC) FROM DANHMUC)

    SET @IDDANHMUC = dbo.F_MAKE_ID('DM', @IDDANHMUC)

    INSERT INTO DANHMUC VALUES (@IDDANHMUC, @TENDANHMUC)
COMMIT TRAN
RETURN 0
GO