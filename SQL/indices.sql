/* 21HTTT1 - 21CLC1.CSDLNC.03
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127296 - Đặng Hà Huy
 * 21127315 - Nguyễn Gia Khánh
 * 21127712 - Lê Quang Trường
 */
USE [NC03_QLNhaKhoa]
GO

--IDX1
--Gợi ý: Bác sĩ cho thuốc bệnh nhân bằng cách search tên thuốc - giả định bác sĩ không biết id thuốc
CREATE INDEX IDX_THUOC_TENTHUOC
ON THUOC(TENTHUOC)

--IDX2
--Gợi ý: Nha sĩ xem báo cáo về các thuốc còn tồn kho rất ít để cập nhật thêm
CREATE INDEX IDX_THUOC_SOLUONGTONKHO
ON THUOC(SOLUONGTONKHO)

--IDX3
--IDX này chồng lên partition của bảng lịch hẹn
-- Báo cáo lịch hẹn từ của bác sĩ
CREATE INDEX IDX_LICHHEN_NGAY
ON LICHHEN(IDNHASI, NGAY)

--IDX4
--Gợi ý: Báo cáo các kế hoạch điều trị của nha sĩ trong một khoảng thời gian
CREATE INDEX IDX_KEHOACHDIEUTRI_NHASI_NGAY
ON KEHOACHDIEUTRI(IDNHASI, NGAYDIEUTRI)

--IDX5 
--Xem dach sách nha sĩ, nhân viên, ...
CREATE INDEX IDX_TAIKHOAN_LOAITAIKHOAN
ON TAIKHOAN(LOAITAIKHOAN)

--IDX6
--Lọc cuộc hẹn riêng của nha sĩ
CREATE INDEX IDX_LICHHEN_LICHRIENGBACSI
ON LICHHEN(IDNHASI, IDNHANVIENDAT, NGAY)

--IDX7
CREATE INDEX IDX_HOSOBENHNHAN_TEN_SDT
ON HOSOBENHNHAN(HOTEN, SDT)
