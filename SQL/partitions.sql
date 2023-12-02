USE [NC03_QLNhaKhoa]
GO

--PARTITION NÀY GIÚP PHÂN BẢNG LỊCH HẸN THÀNH LỊCH HẸN THEO PHÒNG KHÁM, GIÚP DỄ DÀNG XÁC ĐỊNH
--CÁC TRUY VẤN CÓ LIÊN QUAN RIÊNG BIỆT THEO PHÒNG KHÁM NHƯ
--XEM DANH SÁCH LỊCH HẸN CỦA MỘT PHÒNG KHÁM
--XEM DANH SÁCH LỊCH HẸN CỦA MỘT NHA SĨ Ở MỘT PHÒNG KHÁM
--GIẢ ĐỊNH BỆNH NHÂN ĐẶT HẸN ĐỀU Ở CẢ 3 PHÒNG KHÁM THÌ PARTITION NÀY SẼ GIÚP CHIA NHỎ BẢNG LỊCH HẸN THÀNH 3 PHẦN ĐỀU NHAU

ALTER DATABASE [NC03_QLNhaKhoa]
ADD FILEGROUP lichhen_pk1

ALTER DATABASE [NC03_QLNhaKhoa]
ADD FILEGROUP lichhen_pk2

ALTER DATABASE [NC03_QLNhaKhoa]
ADD FILEGROUP lichhen_pk3

ALTER DATABASE [NC03_QLNhaKhoa] 
ADD FILE   
(  
    NAME = partition_lichhen_pk1,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\partition_lichhen_pk1.ndf',  
    SIZE = 5MB,  
    FILEGROWTH = 5MB  
)  
TO FILEGROUP lichhen_pk1; 

ALTER DATABASE [NC03_QLNhaKhoa]
ADD FILE   
(  
    NAME = partition_lichhen_pk2,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\partition_lichhen_pk2.ndf',  
    SIZE = 5MB,  
    FILEGROWTH = 5MB  
)  
TO FILEGROUP lichhen_pk2;  
GO 

ALTER DATABASE [NC03_QLNhaKhoa]
ADD FILE   
(  
    NAME = partition_lichhen_pk3,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\partition_lichhen_pk3.ndf',  
    SIZE = 5MB,  
    FILEGROWTH = 5MB  
)  
TO FILEGROUP lichhen_pk3;  
GO 

SELECT name AS AvailableFilegroups
FROM sys.filegroups
WHERE type = 'FG'

SELECT 
name as [FileName],
physical_name as [FilePath] 
FROM sys.database_files
where type_desc = 'ROWS'
GO

CREATE PARTITION FUNCTION [PartitioningByPhongKham_LichHen_FUNCTION] (char(7))
AS RANGE RIGHT FOR VALUES ('PK00001', 'PK00002');

CREATE PARTITION SCHEME PartitionByPhongKham_LichHen_SCHEME	
AS PARTITION PartitioningByPhongKham_LichHen_FUNCTION
TO (lichhen_pk1, lichhen_pk2, lichhen_pk3);

DROP TABLE LICHHEN

CREATE TABLE LICHHEN (
    IDHOSO CHAR(7),
    IDLICHHEN CHAR(7),
    NGAY DATE,
    GIO INT,
    TINHTRANG INT, -- 0: CUỘC HẸN MỚI, 1: TÁI KHÁM
    GHICHU NVARCHAR(200),
    IDPHONGKHAM CHAR(7),
    IDNHASI CHAR(7),
    IDTROKHAM CHAR(7),
    IDNHANVIENDAT CHAR(7),

    CONSTRAINT PK_LICHHEN
    PRIMARY KEY(IDHOSO, IDLICHHEN, IDPHONGKHAM),

    CONSTRAINT FK_LICHHEN_HOSOBENHNHAN
    FOREIGN KEY(IDHOSO)
    REFERENCES HOSOBENHNHAN,

    CONSTRAINT FK_LICHHEN_PHONGKHAM
    FOREIGN KEY(IDPHONGKHAM)
    REFERENCES PHONGKHAM,

    CONSTRAINT FK_LICHHEN_TAIKHOAN_IDNHASI
    FOREIGN KEY(IDNHASI)
    REFERENCES TAIKHOAN,
    CONSTRAINT FK_LICHHEN_TAIKHOAN_IDTROKHAM
    FOREIGN KEY(IDTROKHAM)
    REFERENCES TAIKHOAN,
    CONSTRAINT FK_LICHHEN_TAIKHOAN_IDNHANVIENDAT
    FOREIGN KEY(IDNHANVIENDAT)
    REFERENCES TAIKHOAN,

    CONSTRAINT CHK_LICHHEN_GIO
    CHECK (GIO >= 0),

    CONSTRAINT CHK_LICHHEN_TINHTRANG
    CHECK (TINHTRANG = 0 OR TINHTRANG = 1),
)


