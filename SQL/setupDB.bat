
@echo off
cls
chcp 65001

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

@echo ---- Populating taiKhoan.sql
SQLCMD -E -dmaster -f65001 -i"\data\1_taiKhoan.sql"

@echo ---- Populating beMatRang.sql
SQLCMD -E -dmaster -f65001 -i"\data\2_beMatRang.sql"

@echo ---- Populating danhMuc.sql
SQLCMD -E -dmaster -f65001 -i"\data\3_danhMuc.sql"

@echo ---- Populating lieuTrinh.sql
SQLCMD -E -dmaster -f65001 -i"\data\4_lieuTrinh.sql"

@echo ---- Populating hoSoBenhNhan.sql
SQLCMD -E -dmaster -f65001 -i"\data\5_hoSoBenhNhan.sql"

@echo ---- Populating phongKham.sql
SQLCMD -E -dmaster -f65001 -i"\data\6_phongKham.sql"

@echo ---- Populating rang.sql
SQLCMD -E -dmaster -f65001 -i"\data\7_rang.sql"

@echo ---- Populating thuoc.sql
SQLCMD -E -dmaster -f65001 -i"\data\8_thuoc.sql"

@echo ---- Populating keHoachDieuTri.sql
SQLCMD -E -dmaster -f65001 -i"\data\9_keHoachDieuTri.sql"

@echo ---- Populating lichHen.sql
SQLCMD -E -dmaster -f65001 -i"\data\10_lichHen.sql"

@echo ---- Populating lichNgay.sql
SQLCMD -E -dmaster -f65001 -i"\data\11_lichNgay.sql"

@echo ---- Populating lichThang.sql
SQLCMD -E -dmaster -f65001 -i"\data\12_lichThang.sql"

@echo ---- Populating lichTuan.sql
SQLCMD -E -dmaster -f65001 -i"\data\13_lichTuan.sql"

@echo ---- Populating toaThuoc.sql
SQLCMD -E -dmaster -f65001 -i"\data\14_toaThuoc.sql"

@echo ---- Populating thanhToan.sql
SQLCMD -E -dmaster -f65001 -i"\data\15_thanhToan.sql"

@echo ---- Populating ghiChu.sql
SQLCMD -E -dmaster -f65001 -i"\data\16_ghiChu.sql"

@echo ---- Granting Permissions...
SQLCMD -E -dmaster -f65001 -i".\permissions.sql"

PAUSE