/* 21HTTT1 - 21CLC1.CSDLNC.03
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127296 - Đặng Hà Huy
 * 21127315 - Nguyễn Gia Khánh
 * 21127712 - Lê Quang Trường
 */
USE [NC03_QLNhaKhoa]
GO

CREATE OR ALTER PROC USP_LIEUTRINH_INS
    @TENLIEUTRINH NVARCHAR(100),
    @GIA INT,
    @IDDANHMUC CHAR(7),
    @IDLIEUTRINH CHAR(7) = NULL OUTPUT
AS BEGIN TRAN
    IF @GIA < 0 BEGIN
        RAISERROR('INVALID GIA', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF NOT EXISTS (SELECT IDDANHMUC FROM DANHMUC
        WHERE IDDANHMUC = @IDDANHMUC) BEGIN
        RAISERROR('INVALID IDDANHMUC', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    SELECT @IDLIEUTRINH = IDLIEUTRINH FROM LIEUTRINH
    WHERE IDLIEUTRINH = (SELECT MAX(IDLIEUTRINH) FROM LIEUTRINH)

    SET @IDLIEUTRINH = dbo.F_MAKE_ID('LT', @IDLIEUTRINH)

    INSERT INTO LIEUTRINH
    VALUES (@IDLIEUTRINH, @TENLIEUTRINH, @GIA, @IDDANHMUC)
COMMIT TRAN
RETURN 0
GO

CREATE OR ALTER PROC USP_LIEUTRINH_UPD
    @IDLIEUTRINH CHAR(7),
    @TENLIEUTRINH NVARCHAR(100),
    @GIA INT,
    @IDDANHMUC CHAR(7)
AS BEGIN TRAN
    IF NOT EXISTS (SELECT IDLIEUTRINH FROM LIEUTRINH
        WHERE IDLIEUTRINH = @IDLIEUTRINH) BEGIN
        RAISERROR('INVALID IDLIEUTRINH', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF @GIA < 0 BEGIN
        RAISERROR('INVALID GIA', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    IF NOT EXISTS (SELECT IDDANHMUC FROM DANHMUC
        WHERE IDDANHMUC = @IDDANHMUC) BEGIN
        RAISERROR('INVALID IDDANHMUC', 16, 1)
        ROLLBACK TRAN
        RETURN -3
    END

    UPDATE LIEUTRINH SET TENLIEUTRINH = @TENLIEUTRINH, GIA = @GIA,
        IDDANHMUC = @IDDANHMUC
    WHERE IDLIEUTRINH = @IDLIEUTRINH
COMMIT TRAN
RETURN 0
GO