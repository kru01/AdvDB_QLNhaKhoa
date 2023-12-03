
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

@echo ---- Creating Indices...
SQLCMD -E -dmaster -f65001 -i".\indices.sql"

REM POPULATING DATA
@echo ---- Populating TAIKHOAN...
SQLCMD -E -dmaster -f65001 -i".\data\taiKhoan.sql"

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
SQLCMD -E -dmaster -f65001 -i".\data\hoSoBenhNhan.sql"

@echo ---- Populating PHONGKHAM...
SQLCMD -E -dmaster -f65001 -i".\data\phongKham.sql"

@echo ---- Populating RANG...
SQLCMD -E -dmaster -f65001 -i".\data\rang.sql"

@echo ---- Populating THUOC...
SQLCMD -E -dmaster -f65001 -i".\data\thuoc.sql"

@echo ---- Populating KEHOACHDIEUTRI...
SQLCMD -E -dmaster -f65001 -i".\data\keHoachDieuTri.sql"

@echo ---- Populating LICHHEN...
SQLCMD -E -dmaster -f65001 -i".\data\lichHen.sql"

@echo ---- Populating TOATHUOC...
SQLCMD -E -dmaster -f65001 -i".\data\toaThuoc.sql"

@echo ---- Populating THANHTOAN...
SQLCMD -E -dmaster -f65001 -i".\data\thanhToan.sql"

@echo ---- Populating GHICHU...
SQLCMD -E -dmaster -f65001 -i".\data\ghiChu.sql"

REM GRANTIN PERMISSIONS
@echo ---- Granting Permissions...
SQLCMD -E -dmaster -f65001 -i".\permissions.sql"

PAUSE