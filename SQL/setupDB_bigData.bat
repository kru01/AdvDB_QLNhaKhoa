
@echo off
cls
chcp 65001

REM SETTING UP DATABASE
@echo ---- Creating NC03_QLNhaKhoa...
SQLCMD -E -dmaster -f65001 -i".\createDB.sql"

@echo ---- Creating Partitions...
for %%G in (.\partitions\*.sql) do SQLCMD -E -dmaster -f65001 -i"%%G"

@echo ---- Creating Functions...
for %%G in (.\funcs\*.sql) do SQLCMD -E -dmaster -f65001 -i"%%G"

@echo ---- Creating Stored Procedures...
for %%G in (.\storedProcs\*.sql) do SQLCMD -E -dmaster -f65001 -i"%%G"

REM POPULATING DATA
@echo ---- Populating TAIKHOAN...
SQLCMD -E -dmaster -f65001 -i".\bigData\taiKhoan.sql"

@echo ---- Populating LICHNGAY...
SQLCMD -E -dmaster -f65001 -i".\data\lichNgay.sql"

@echo ---- Populating LICHTHANG...
SQLCMD -E -dmaster -f65001 -i".\data\lichThang.sql"

@echo ---- Populating LICHTUAN...
SQLCMD -E -dmaster -f65001 -i".\data\lichTuan.sql"

@echo ---- Populating BEMATRANG...
SQLCMD -E -dmaster -f65001 -i".\data\beMatRang.sql"

@echo ---- Populating DANHMUC...
SQLCMD -E -dmaster -f65001 -i".\data\danhMuc.sql"

@echo ---- Populating LIEUTRINH...
SQLCMD -E -dmaster -f65001 -i".\data\lieuTrinh.sql"

@echo ---- Populating HOSOBENHNHAN...
SQLCMD -E -dmaster -f65001 -i".\bigData\hoSoBenhNhan.sql"

@echo ---- Populating PHONGKHAM...
SQLCMD -E -dmaster -f65001 -i".\data\phongKham.sql"

@echo ---- Populating RANG...
SQLCMD -E -dmaster -f65001 -i".\data\rang.sql"

@echo ---- Populating THUOC...
SQLCMD -E -dmaster -f65001 -i".\bigData\thuoc.sql"

@echo ---- Populating KEHOACHDIEUTRI...
SQLCMD -E -dmaster -f65001 -i".\bigData\keHoachDieuTri.sql"

@echo ---- Populating LICHHEN...
SQLCMD -E -dmaster -f65001 -i".\bigData\lichHen.sql"

@echo ---- Populating TOATHUOC...
SQLCMD -E -dmaster -f65001 -i".\bigData\toaThuoc.sql"

@echo ---- Populating THANHTOAN...
SQLCMD -E -dmaster -f65001 -i".\bigData\thanhToan.sql"

@echo ---- Populating GHICHU...
SQLCMD -E -dmaster -f65001 -i".\bigData\ghiChu.sql"

@echo ---- Populating CHITIETRANG...
SQLCMD -E -dmaster -f65001 -i".\bigData\chiTietRang.sql"

REM CREATING INDICES
@echo ---- Creating Indices...
SQLCMD -E -dmaster -f65001 -i".\indices.sql"

PAUSE