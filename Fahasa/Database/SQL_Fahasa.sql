CREATE TABLE ProductType(
	ProductTypeID INT IDENTITY(1,1) PRIMARY KEY,
	ProductTypeName NVARCHAR(50)
);

INSERT INTO ProductType VALUES(N'HÀNH TRANG ĐẾN TRƯỜNG')
INSERT INTO ProductType VALUES(N'ĐỒ CHƠI')
INSERT INTO ProductType VALUES(N'DỤNG CỤ Y TẾ')
INSERT INTO ProductType VALUES(N'ĐỒ LƯU NIỆM')

CREATE TABLE Publiser(
	PubliserID INT IDENTITY(1,1) PRIMARY KEY,
	PubliserName NVARCHAR(50)
);

INSERT INTO Publiser VALUES (N'NXB Hội Nhà Văn')
INSERT INTO Publiser VALUES (N'NXB Tổng Hợp TPHCM')
INSERT INTO Publiser VALUES (N'NXB Văn Hóa Văn nghệ')
INSERT INTO Publiser VALUES (N'NXB Dân trí')
INSERT INTO Publiser VALUES (N'NXB Hồng Đức')
INSERT INTO Publiser VALUES (N'NXB Giáo Dục Việt Nam')
INSERT INTO Publiser VALUES (N'NXB Lao Động Xã Hội')

CREATE TABLE BookType(
	BookTypeID INT IDENTITY(1,1) PRIMARY KEY,
	BookTypeName NVARCHAR(50)
);

INSERT INTO BookType VALUES (N'VĂN HỌC')
INSERT INTO BookType VALUES (N'KINH TẾ')
INSERT INTO BookType VALUES (N'THIẾU NHI')
INSERT INTO BookType VALUES (N'GIÁO KHOA - THAM KHẢO')
INSERT INTO BookType VALUES (N'TIỂU SỬ - HỒI KÝ')

CREATE TABLE JobDetail(
	JobID INT IDENTITY(1,1) PRIMARY KEY,
	JobName NVARCHAR(50),
	SalaryScale Float
);

INSERT INTO JobDetail VALUES (N'Thu ngân',1.6)
INSERT INTO JobDetail VALUES (N'Bảo vệ',1.0)
INSERT INTO JobDetail VALUES (N'Giao hàng',1.3)

CREATE TABLE BuyInvoice(
	BuyInvoiceID INT IDENTITY(1,1) PRIMARY KEY,
	BuyInvoiceDate DATE
);
CREATE TABLE SellInvoice(
	SellInvoiceID INT IDENTITY(1,1) PRIMARY KEY,
	SellInvoiceDate DATE
);
CREATE TABLE Product(
	ProductID INT IDENTITY(1,1) PRIMARY KEY,
	ProductName NVARCHAR(50) NOT NULL,
	Quantity INT,
	SellPrice DECIMAL,
	ProductTypeID INT
	CONSTRAINT fk_ProductTypeID FOREIGN KEY (ProductTypeID) REFERENCES ProductType
);

INSERT INTO Product VALUES (N'BÚT BI THIÊN LONG',500,86000,1)
INSERT INTO Product VALUES (N'BÚT CHÌ THIÊN LONG',550,56000,1)
INSERT INTO Product VALUES (N'BÚT LONG MÀU THIÊN LONG FPC03',470,124000,1)
INSERT INTO Product VALUES (N'Bút Máy Thiên Long FTC-05/MI',120,52000,1)
INSERT INTO Product VALUES (N'Gôm Thiên Long E-06',80,7000,1)
INSERT INTO Product VALUES (N'Tập Học Viện Sao Kê 100 trang',360,12000,1)
INSERT INTO Product VALUES (N'Balo Chống Gù',82,350000,1)
INSERT INTO Product VALUES (N'Bộ Đất Nặn',170,83000,2)
INSERT INTO Product VALUES (N'Đồ Chơi Bàn Học Xếp Khối',58,266000,2)
INSERT INTO Product VALUES (N'Đồ Chơi Rubik 3x3',90,58000,2)
INSERT INTO Product VALUES (N'Đồ Chơi Bác Sĩ',78,186000,2)
INSERT INTO Product VALUES (N'Dung Dịch Rửa Tay Nhanh',286,76000,3)
INSERT INTO Product VALUES (N'Gel Rửa Tay Khô',166,42000,3)
INSERT INTO Product VALUES (N'Xà Phòng Tiện Lợi',155,15000,3)
INSERT INTO Product VALUES (N'Khẩu Trang Y Tế 4 Lớp WAKAMONO',430,100000,3)
INSERT INTO Product VALUES (N'Kính Bảo Hộ Cao Cấp',65,131000,3)
INSERT INTO Product VALUES (N'Khẩu Trang Y Tế Trường Dương N95',340,106000,3)
INSERT INTO Product VALUES (N'Móc Khóa Quỳnh Aka Bông Mini',42,46000,4)
INSERT INTO Product VALUES (N'Móc Khoá Oopsie Play Game Talk',24,36000,4)
INSERT INTO Product VALUES (N'Khung Hình Gỗ 4 Kiểu',55,76000,4)
INSERT INTO Product VALUES (N'Gương Hình Thú',13,254000,4)

CREATE TABLE Book(
	BookID INT IDENTITY(1,1) PRIMARY KEY,
	BookName NVARCHAR(50) NOT NULL,
	Author NVARCHAR(50) NOT NULL,
	Quantity INT,
	SellPrice DECIMAL,
	BookTypeID INT
	CONSTRAINT fk_BookTypeID FOREIGN KEY (BookTypeID) REFERENCES BookType,
	PubliserID INT
	CONSTRAINT fk_PubliserID FOREIGN KEY (PubliserID) REFERENCES Publiser,

);

INSERT INTO Book VALUES (N'Cây Cam Ngọt Của Tôi',N'José Vasconcelos',30,85000,1,1)
INSERT INTO Book VALUES (N'Hoa Tuylip Đen',N'Alexandre Dumas',45,25000,1,1)
INSERT INTO Book VALUES (N'Nghĩ Giàu & Làm Giàu (Tái Bản 2020)',N'Napoleon Hill',58,305000,2,2)
INSERT INTO Book VALUES (N'Tay Trắng Làm Nên',N'Beaverbrook',30,32000,2,3)
INSERT INTO Book VALUES (N'Ươm Mầm Nhân Cách - Ứng Xử',N'Trí Việt',32,72000,3,4)
INSERT INTO Book VALUES (N'Vườn Cổ Tích - Alibaba Và 40 Tên Cướp',N'Triệu Phương Phương',14,26000,3,5)
INSERT INTO Book VALUES (N'Atlat Địa Lí Việt Nam',N'Bộ Giáo Dục Và Đào Tạo',89,10000,4,6)
INSERT INTO Book VALUES (N'Tin Học Dành Cho THCS - Quyển 2',N'Nhiều Tác Giả',103,21000,4,6)
INSERT INTO Book VALUES (N'Tài Liệu Dạy Và Học Vật Lí 7',N'Phạm Ngọc Tiến',92,90000,4,6)
INSERT INTO Book VALUES (N'Lấy Nước Đường Xa',N'Linda Sue Park',37,123000,5,7)
INSERT INTO Book VALUES (N'Điệp Viên Hoàn Hảo X6',N'Larry Berman',35,156000,5,5)
INSERT INTO Book VALUES (N'Tỷ Phú Bán Giày',N'Tony Hsieh',10,276000,2,7)

CREATE TABLE Employee(
	EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
	EmployeeName NVARCHAR(50) NOT NULL,
	DayOfBirth DATE,
	EmployeeAddr NVARCHAR(100),
	PhoneNumber CHAR(11),
	BeginDate DATE,
	JobID INT
	CONSTRAINT fk_JobID FOREIGN KEY (JobID) REFERENCES JobDetail
);

INSERT INTO Employee () VALUES (N'CAO LÂM BẢO KHANH',2001/10/27,N'TÂY NINH',0339208710,2021/01/01,3)
INSERT INTO Employee VALUES (N'NGUYỄN HOÀNG HIỆP',2001-01-15,N'LONG AN',0812356946,2021-02-01,2)
INSERT INTO Employee VALUES (N'HOÀNG MINH TÀI',2001-05-08,N'QUẢNG BÌNH',0852976038 ,2020-08-05,3)
INSERT INTO Employee VALUES (N'PHƯƠNG HẰNG',1971-01-26,N'BÌNH DƯƠNG',0999999999,2010-01-01,1)
INSERT INTO Employee VALUES (N'THỦY TIÊN',1985-11-25,N'KIÊN GIANG',0888888888,2021-01-01,1)
INSERT INTO Employee VALUES (N'ĐÀM VĨNH HƯNG',1971-10-02,N'TPHCM',0777777777,2021-01-02,1)
INSERT INTO Employee VALUES (N'HOÀI LINH',1969-12-18,N'KHÁNH HÒA',0141414141,2020-12-01,1)
INSERT INTO Employee VALUES (N'CÔNG VINH',1985-12-10,N'NGHỆ AN',0495349534,2020-12-01,2)

CREATE TABLE Attendance(
	AttendanceID INT IDENTITY(1,1) PRIMARY KEY,
	AttendanceDate DATE,
	EmployeeID INT
	CONSTRAINT fk_EmployeeID FOREIGN KEY (EmployeeID) REFERENCES Employee
);

CREATE TABLE BuyInvoiceDetail(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	BuyPrice DECIMAL,
	BuyInvoiceID INT 	
	CONSTRAINT fk_BuyInvoiceID FOREIGN KEY (BuyInvoiceID) REFERENCES BuyInvoice,
	BookID INT 	
	CONSTRAINT fk_BookID FOREIGN KEY (BookID) REFERENCES Book,
	ProductID INT 	
	CONSTRAINT fk_ProductID FOREIGN KEY (ProductID) REFERENCES Product
);
CREATE TABLE SellInvoiceDetail(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	SellInvoiceID INT 	
	CONSTRAINT fk_SellInvoiceID FOREIGN KEY (SellInvoiceID) REFERENCES SellInvoice,
	BookID INT 	
	CONSTRAINT fk_SellBookID FOREIGN KEY (BookID) REFERENCES Book,
	ProductID INT 	
	CONSTRAINT fk_SellProductID FOREIGN KEY (ProductID) REFERENCES Product
);


