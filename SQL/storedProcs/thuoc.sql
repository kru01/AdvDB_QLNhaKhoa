/* 21HTTT1 - 21CLC1.CSDLNC.03
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127296 - Đặng Hà Huy
 * 21127315 - Nguyễn Gia Khánh
 * 21127712 - Lê Quang Trường
 */
USE [NC03_QLNhaKhoa]
GO

CREATE OR ALTER PROC USP_THUOC_INS
    @TENTHUOC NVARCHAR(25),
    @DONVITINH INT,
    @CHIDINH NVARCHAR(50),
    @SOLUONGTONKHO INT,
    @NGAYHETHAN DATE,
    @GIATIEN INT,
    @IDTHUOC CHAR(7) = NULL OUTPUT
AS BEGIN TRAN
    IF @DONVITINH != 0 AND @DONVITINH != 1 AND @DONVITINH != 2 BEGIN
        RAISERROR(N'INVALID DONVITINH, MUST BE EITHER 0, 1, OR 2', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF @SOLUONGTONKHO < 0 BEGIN
        RAISERROR('INVALID SOLUONGTONKHO', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    IF @GIATIEN < 0 BEGIN
        RAISERROR('INVALID GIATIEN', 16, 1)
        ROLLBACK TRAN
        RETURN -3
    END

    SELECT @IDTHUOC = IDTHUOC FROM THUOC
    WHERE IDTHUOC = (SELECT MAX(IDTHUOC) FROM THUOC)

    SET @IDTHUOC = dbo.F_MAKE_ID('TH', @IDTHUOC)

    INSERT INTO THUOC
    VALUES (@IDTHUOC, @TENTHUOC, @DONVITINH, @CHIDINH,
        @SOLUONGTONKHO, @NGAYHETHAN, @GIATIEN)
COMMIT TRAN
RETURN 0
GO

CREATE OR ALTER PROC USP_THUOC_SEARCH
    @IDTHUOC CHAR(7) = NULL,
    @TENTHUOC NVARCHAR(25) = NULL,
    @DONVITINH INT = NULL,
    @CHIDINH NVARCHAR(50) = NULL,
    @SOLUONGTONKHO INT = NULL,
    @NGAYHETHAN DATE = NULL,
    @GIATIEN INT = NULL
AS BEGIN TRAN
    DECLARE @SQL NVARCHAR(MAX)
    SET @SQL = N'SELECT * FROM THUOC WHERE 1 = 1'

    IF @IDTHUOC IS NOT NULL
        SET @SQL += N' AND IDTHUOC LIKE ''%''+@IDTHUOC+''%'''
    IF @TENTHUOC IS NOT NULL
        SET @SQL += N' AND TENTHUOC LIKE ''%''+@TENTHUOC+''%'''
    IF @DONVITINH IS NOT NULL
        SET @SQL += N' AND DONVITINH = @DONVITINH'
    IF @CHIDINH IS NOT NULL
        SET @SQL += N' AND CHIDINH LIKE ''%''+@CHIDINH+''%'''
    IF @SOLUONGTONKHO IS NOT NULL
        SET @SQL += N' AND SOLUONGTONKHO <= @SOLUONGTONKHO'
    IF @NGAYHETHAN IS NOT NULL
        SET @SQL += N' AND NGAYHETHAN <= @NGAYHETHAN'
    IF @GIATIEN IS NOT NULL
        SET @SQL += N' AND GIATIEN <= GIATIEN'

    EXEC sp_executesql @SQL,
        N'@IDTHUOC CHAR(7), @TENTHUOC NVARCHAR(25), @DONVITINH INT,
        @CHIDINH NVARCHAR(50), @SOLUONGTONKHO INT, @NGAYHETHAN DATE,
        @GIATIEN INT',
        @IDTHUOC, @TENTHUOC, @DONVITINH, @CHIDINH,
        @SOLUONGTONKHO, @NGAYHETHAN, @GIATIEN
COMMIT TRAN
RETURN 0
GO