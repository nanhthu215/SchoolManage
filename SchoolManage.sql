use SchoolManage
Go
CREATE TABLE Users (
    Username NVARCHAR(50) PRIMARY KEY,
    Password NVARCHAR(50),
    Role NVARCHAR(20)
);
GO

INSERT INTO Users (Username, Password, Role) VALUES
('admin1', '123', 'Admin'),
('gv01', '123', 'Giaovien'),
('ph01', '123', 'Phuhuynh');

CREATE TABLE GiaoVien (
    MaGV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    SDT VARCHAR(15),
    Email VARCHAR(50),
    DiaChi NVARCHAR(100)
);

INSERT INTO GiaoVien (MaGV, HoTen, NgaySinh, GioiTinh, SDT, Email, DiaChi) VALUES
('GV001', N'Nguyễn Văn An', '1980-05-20', N'Nam', '0912345678', 'nguyenvana@gmail.com', N'123 Lê Lợi, Hà Nội'),
('GV002', N'Trần Thị Bình', '1985-08-15', N'Nữ', '0987654321', 'tranthib@yahoo.com', N'456 Trần Hưng Đạo, TP.HCM'),
('GV003', N'Lê Văn Cao', '1990-01-10', N'Nam', '0909090909', 'levanc@gmail.com', N'789 Nguyễn Trãi, Đà Nẵng');

CREATE TABLE Lop (
    MaLop VARCHAR(20) PRIMARY KEY,
    TenLop NVARCHAR(50) NOT NULL,
	GVCN VARCHAR(10) NULL,
	NienKhoa VARCHAR(10),
    FOREIGN KEY (GVCN) REFERENCES GiaoVien(MaGV) ON DELETE SET NULL
);

INSERT INTO Lop (MaLop, TenLop, GVCN, NienKhoa) VALUES
('L01', N'Lớp 1A', 'GV001', '2008-2012'),
('L02', N'Lớp 2B', 'GV002', '2010-2014'),
('L03', N'Lớp 3C', 'GV003', '2011-2015');


CREATE TABLE HocSinh (
    MaHS VARCHAR(10) PRIMARY KEY ,    
    HoTen NVARCHAR(100) NOT NULL,       
    NgaySinh DATE NOT NULL,            
    GioiTinh NVARCHAR(3) NOT NULL,                  
    DiaChi NVARCHAR(200),               
    SDT NVARCHAR(15),                      
    MaLop VARCHAR(20) NULL,            
	Datotnghiep bit
    CONSTRAINT FK_HocSinh_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop) ON DELETE SET NULL
);


INSERT INTO HocSinh VALUES
('HS001',N'Nguyễn An Hải Đường', '2022-04-03', N'Nữ', N'Hà Nội', '0912345678', 'L01', 0),
('HS002',N'Trần Gia Huy', '2020-08-22', N'Nam', N'45 Đường B, Quận 2', '0987654321', 'L02', 0),
('HS003', N'Trần Minh Khoa', '2019-12-05', N'Nữ', N'67 Đường C, Quận 3', '0901234567', 'L03', 0),
('HS004', N'Lê Thị Hồng Nhung', '2021-03-12', N'Nữ', N'12 Đường D, Quận 4', '0908888999', 'L01', 0),
('HS005', N'Phạm Minh Nhật', '2020-09-25', N'Nam', N'34 Đường E, Quận 5', '0911222333', 'L02', 0),
('HS006', N'Ngô Thanh Trúc', '2022-01-14', N'Nữ', N'56 Đường F, Quận 6', '0933444555', 'L01', 0),
('HS007', N'Hồ Gia Bảo', '2019-11-08', N'Nam', N'78 Đường G, Quận 7', '0966555777', 'L03', 0),
('HS008', N'Võ Thị Mai', '2020-07-01', N'Nữ', N'90 Đường H, Quận 8', '0977666888', 'L02', 0),
('HS009', N'Đặng Anh Tuấn', '2021-10-19', N'Nam', N'11 Đường I, Quận 9', '0988777666', 'L03', 0),
('HS010', N'Trương Minh Anh', '2022-02-28', N'Nữ', N'22 Đường K, Quận 10', '0955444333', 'L01', 0);


CREATE TABLE SucKhoeTre (
    MaHS VARCHAR(10) PRIMARY KEY,            
    CanNang DECIMAL(4,1),                
    ChieuCao DECIMAL(4,1),           
    TinhTrangSucKhoe NVARCHAR(100),     
    NgayKiemTra DATE,
    FOREIGN KEY (MaHS) REFERENCES HocSinh(MaHS)
);


INSERT INTO SucKhoeTre (MaHS, CanNang, ChieuCao, TinhTrangSucKhoe, NgayKiemTra)
VALUES 
('HS001', 10.2, 110.2, N'Bình thường', '2025-04-18'),
('HS002', 11.5, 111.0, N'Bình thường', '2025-04-18'),
('HS003', 12.0, 112.5, N'Cần theo dõi', '2025-04-18'),
('HS004', 10.8, 109.0, N'Bình thường', '2025-04-18'),
('HS005', 11.2, 113.0, N'Bình thường', '2025-04-18'),
('HS006', 9.5, 108.0, N'Gầy nhẹ cân', '2025-04-18'),
('HS007', 13.0, 115.0, N'Bình thường', '2025-04-18'),
('HS008', 11.0, 111.2, N'Bình thường', '2025-04-18'),
('HS009', 12.8, 114.5, N'Bình thường', '2025-04-18'),
('HS010', 10.0, 109.5, N'Cần theo dõi', '2025-04-18');


CREATE TABLE DanhGia (
    Diem INT CHECK (Diem BETWEEN 1 AND 10),
    NhanXet NVARCHAR(500)
);

INSERT INTO DanhGia (Diem, NhanXet)
VALUES 
(9, N'Giáo viên rất nhiệt tình và dễ hiểu.'),
(8, N'Lớp học sạch sẽ, thoáng mát.'),
(7, N'Cần cập nhật thông tin thường xuyên hơn.');


CREATE TABLE Tuition (
    TuitionID INT PRIMARY KEY IDENTITY(1,1),
    MaHS VARCHAR(10) NOT NULL,
    DueDate DATETIME,
    Amount DECIMAL(18, 2),
    Status NVARCHAR(50),
	CONSTRAINT FK_HocSinh_Tuition FOREIGN KEY (MaHS) REFERENCES HocSinh(MaHS)
);

INSERT INTO Tuition (MaHS, DueDate, Amount, Status) VALUES
('HS001', '2025-05-10', 1500000, N'Chưa thanh toán'),
('HS001', '2025-04-10', 1600000, N'Đã thanh toán'),

('HS002', '2025-05-10', 1500000, N'Chưa thanh toán'),
('HS002', '2025-04-10', 1600000, N'Đã thanh toán'),

('HS003', '2025-05-10', 1500000, N'Chưa thanh toán'),
('HS004', '2025-05-10', 1500000, N'Đã thanh toán'),
('HS005', '2025-05-10', 1500000, N'Chưa thanh toán'),
('HS006', '2025-05-10', 1500000, N'Chưa thanh toán'),
('HS007', '2025-05-10', 1500000, N'Đã thanh toán'),
('HS008', '2025-05-10', 1500000, N'Chưa thanh toán'),
('HS009', '2025-05-10', 1500000, N'Chưa thanh toán'),
('HS010', '2025-05-10', 1500000, N'Đã thanh toán');

