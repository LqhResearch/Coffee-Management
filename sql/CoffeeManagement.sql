CREATE DATABASE CoffeeManagement
GO

USE CoffeeManagement
GO

CREATE TABLE Account
(
	Username NVARCHAR(50) NOT NULL PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Nhân viên',
	Password VARCHAR(50) NOT NULL DEFAULT 0,
	Access NVARCHAR(100) NOT NULL DEFAULT N'Staff'
)
GO

CREATE TABLE TableFood
(
	IdTable INT IDENTITY PRIMARY KEY,
	NameTable NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	StatusTable NVARCHAR(30) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Category
(
	IdCategory INT IDENTITY PRIMARY KEY,
	NameCategory NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Drink
(
	IdDrink INT IDENTITY PRIMARY KEY,
	NameDrink NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	PriceDrink FLOAT NOT NULL DEFAULT 0,
	IdCategory INT NOT NULL,
	
	FOREIGN KEY (IdCategory) REFERENCES dbo.Category(IdCategory)
)
GO

CREATE TABLE Bill
(
	IdBill INT IDENTITY PRIMARY KEY,
	DateCheckInBill DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOutBill DATE,
	StatusBill BIT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
	Discount INT NOT NULL DEFAULT 0,
	TotalPrice FLOAT NOT NULL DEFAULT 0,
	IdTable INT NOT NULL,
	
	FOREIGN KEY (IdTable) REFERENCES dbo.TableFood(IdTable)
)
GO

CREATE TABLE BillInfo
(
	IdBillInfo INT IDENTITY PRIMARY KEY,
	IdBill INT NOT NULL,
	IdDrink INT NOT NULL,
	Amount INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (IdBill) REFERENCES dbo.Bill(IdBill),
	FOREIGN KEY (IdDrink) REFERENCES dbo.Drink(IdDrink)
)
GO

-- Tài khoản
INSERT INTO Account VALUES (N'QH', N'Quốc Hưng', '1', N'Admin')
INSERT INTO Account VALUES (N'NV1', N'Nguyễn Văn A', '1', N'Staff')
GO

-- Bàn ăn
DECLARE @i INT = 0
WHILE (@i <= 10)
BEGIN
	INSERT INTO TableFood VALUES (N'Bàn ' + CAST(@i AS NVARCHAR(10)), N'Trống')
	SET @i = @i + 1
END
GO

UPDATE TableFood SET StatusTable = N'Có người' WHERE IdTable = 1 OR IdTable = 3 OR IdTable = 5
GO

-- Danh mục
INSERT INTO Category VALUES (N'Cà phê máy'),
							(N'Nước ép'),
							(N'Sinh tố hoa quả'),
							(N'Cà phê'),
							(N'Sữa chua'),
							(N'Trà sữa')
GO

-- Thức uống
INSERT INTO Drink VALUES (N'Cappuccino', 25000, 1),
						 (N'Espresso', 18000, 1),
						 (N'Americano', 12000, 1),
						 (N'Nước ép táo', 30000, 2),
						 (N'Nước ép dâu', 35000, 2),
						 (N'Nước ép lựu', 30000, 2),
						 (N'Nước ép cam', 15000, 2),
						 (N'Sinh tố bơ', 25000, 3),
						 (N'Sinh tố dừa', 18000, 3),
						 (N'Sinh tố xoài', 22000, 3),
						 (N'Cà phê đen', 15000, 4),
						 (N'Cà phê sữa', 18000, 4),
						 (N'Cà phê sữa tươi', 12000, 4),
						 (N'Sữa chua cà phê', 20000, 5),
						 (N'Sữa chua cacao', 20000, 5),
						 (N'Sữa chua cam', 25000, 5),
						 (N'Sữa chua dâu', 25000, 5),
						 (N'Trà sữa truyền thống', 10000, 6),
						 (N'Trà sữa matcha', 10000, 6),
						 (N'Trà sữa đào', 18000, 6)
GO

SET DATEFORMAT DMY
GO

-- Hoá đơn
INSERT INTO Bill VALUES ('26/07/2021', NULL, 0, 0, 0, 1),
						('26/07/2021', '26/07/2021', 1, 0, 56000, 2),
						('27/07/2021', NULL, 0, 0, 0, 3),
						('26/07/2021', '26/07/2021', 1, 0, 133000, 4),
						('28/07/2021', NULL, 0, 0, 0, 5)
GO

-- Thông tin hoá đơn
INSERT INTO BillInfo VALUES (1, 1, 1),
							(1, 3, 1),
							(1, 8, 1),
							(2, 12, 1),
							(2, 1, 2),
							(3, 14, 1),
							(4, 2, 1),
							(4, 5, 1),
							(4, 6, 1),
							(4, 8, 1),
							(4, 1, 1),
							(5, 10, 1),
							(5, 9, 1),
							(5, 7, 2)
GO

-- Trigger
CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = IdBill FROM Inserted	
	
	DECLARE @idTable INT
	SELECT @idTable = IdTable FROM Bill WHERE IdBill = @idBill
	
	DECLARE @count int = 0
	SELECT @count = COUNT(*) FROM Bill WHERE IdTable = @idTable AND StatusBill = 0
	
	IF (@count = 0)
		UPDATE TableFood SET StatusTable = N'Trống' WHERE IdTable = @idTable
END
GO

CREATE TRIGGER TG_UpdateBillInfo
ON BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM Bill WHERE IdBill = @idBill AND StatusBill = 0
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM BillInfo WHERE IdBill = @idBill
	
	IF (@count > 0)
		UPDATE dbo.TableFood SET StatusTable = N'Có người' WHERE IdTable = @idTable		
	ELSE
		UPDATE dbo.TableFood SET StatusTable = N'Trống' WHERE IdTable = @idTable	
END
GO

CREATE TRIGGER TG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS 
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = IdBillInfo, @idBill = Deleted.idBill FROM Deleted
	
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE IdBill = @idBill
	
	DECLARE @count INT = 0
	
	SELECT @count = COUNT(*) 
	FROM dbo.BillInfo, dbo.Bill
	WHERE Bill.IdBill = BillInfo.IdBill 
	AND Bill.IdBill = @idBill 
	AND StatusBill = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET StatusTable = N'Trống' WHERE IdTable = @idTable
END
GO

-- Stored procendure
CREATE PROC SP_IsLogin
@username NVARCHAR(50),	
@password VARCHAR(50)
AS
BEGIN
	SELECT COUNT(Username)
	FROM Account
	WHERE Username = @username 
	AND Password = @password
END
GO

CREATE PROC SP_IsAdminLogin
@username NVARCHAR(50),	
@password VARCHAR(50)
AS
BEGIN
	SELECT COUNT(Username)
	FROM Account
	WHERE Username = @username 
	AND Password = @password
	AND Access = N'Admin'
END
GO

CREATE PROC SP_GetUncheckBillIDByTableID
@idTable INT
AS
BEGIN
	SELECT *
	FROM Bill
	WHERE IdTable = @idTable
	AND StatusBill = 0
END
GO

CREATE PROC SP_GetBillInfoByIdBill
@idBill INT
AS
BEGIN
	SELECT NameDrink AS [Tên món], PriceDrink AS [Giá], Amount AS [Số lượng], PriceDrink * Amount AS [Thành tiền]
	FROM Drink, Bill, BillInfo
	WHERE Drink.IdDrink = BillInfo.IdDrink
	AND BillInfo.IdBill = Bill.IdBill
	AND Bill.IdBill = @idBill
	AND Bill.StatusBill = 0
END
GO

CREATE PROC SP_GetDrinkByIdCategory
@idCategory INT
AS
BEGIN
	SELECT *
	FROM Drink
	WHERE Drink.IdCategory = @idCategory
END
GO

CREATE PROC SP_InsertBill
@idTable INT
AS
BEGIN
	INSERT INTO Bill
	VALUES (GETDATE(), NULL, 0, 0, 0, @idTable)
END
GO

CREATE PROC SP_InsertBillInfo
@idBill INT,
@idDrink INT,
@amount INT
AS
BEGIN
	DECLARE @isExistBillInfo INT = 0
	DECLARE @drinkAmount INT = 1

	SELECT @isExistBillInfo = IdBill, @drinkAmount = Amount
	FROM BillInfo 
	WHERE IdBill = @idBill AND IdDrink = @idDrink

	IF (@isExistBillInfo > 0)
	BEGIN
		DECLARE @newAmount INT = @drinkAmount + @amount
		IF (@newAmount > 0)
			UPDATE BillInfo SET Amount = @newAmount WHERE IdBill = @isExistBillInfo AND IdDrink = @idDrink
		ELSE
			DELETE BillInfo WHERE IdBill = @idBill AND IdDrink = @idDrink
	END
	ELSE
		INSERT INTO BillInfo VALUES (@idBill, @idDrink, @amount)
END
GO

CREATE PROC SP_GetMaxIDBill
AS
BEGIN
	SELECT MAX(IdBill)
	FROM Bill
END
GO

CREATE PROC SP_Payment
@idBill INT,
@discount INT,
@totalPrice FLOAT
AS
BEGIN
	UPDATE Bill 
	SET DateCheckOutBill = GETDATE(), StatusBill = 1, Discount = @discount, TotalPrice = @totalPrice
	WHERE IdBill = @idBill
END
GO

CREATE PROC SP_SwitchTabel
@idTable1 INT, 
@idTable2 INT
AS
BEGIN
	DECLARE @idFirstBill INT
	DECLARE @idSecondBill INT
	
	DECLARE @isFirstTableEmpty INT = 1
	DECLARE @isSecondTableEmpty INT = 1
	
	SELECT @idFirstBill = IdBill FROM Bill WHERE IdTable = @idTable1 AND StatusBill = 0
	SELECT @idSecondBill = IdBill FROM Bill WHERE IdTable = @idTable2 AND StatusBill = 0
	
	IF (@idFirstBill IS NULL)
	BEGIN
		INSERT Bill VALUES (GETDATE(), NULL, 0, 0, 0, @idTable1)
		SELECT @idFirstBill = MAX(IdBill) FROM Bill WHERE IdTable = @idTable1 AND StatusBill = 0
	END
	SELECT @isFirstTableEmpty = COUNT(*) FROM BillInfo WHERE IdBill = @idFirstBill
	
	IF (@idSecondBill IS NULL)
	BEGIN
		INSERT Bill VALUES (GETDATE(), NULL, 0, 0, 0, @idTable2)
		SELECT @idSecondBill = MAX(IdBill) FROM Bill WHERE IdTable = @idTable2 AND StatusBill = 0	
	END
	SELECT @isSecondTableEmpty = COUNT(*) FROM BillInfo WHERE IdBill = @idSecondBill

	SELECT IdBillInfo INTO IDBillInfoTable FROM BillInfo WHERE IdBill = @idSecondBill
	
	UPDATE BillInfo SET IdBill = @idSecondBill WHERE IdBill = @idFirstBill
	UPDATE BillInfo SET IdBill = @idFirstBill WHERE IdBillInfo IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTableEmpty = 0)
		UPDATE TableFood SET StatusTable = N'Trống' WHERE IdTable = @idTable2
		
	IF (@isSecondTableEmpty = 0)
		UPDATE TableFood SET StatusTable = N'Trống' WHERE IdTable = @idTable1
END
GO

CREATE PROC SP_MergeTable
@idTable1 INT, 
@idTable2 INT
AS
BEGIN
	DECLARE @idFirstBill INT
	DECLARE @idSecondBill INT
	
	SELECT @idFirstBill = IdBill FROM Bill WHERE IdTable = @idTable1 AND StatusBill = 0
	SELECT @idSecondBill = IdBill FROM Bill WHERE IdTable = @idTable2 AND StatusBill = 0
	
	IF (@idFirstBill IS NULL)
	BEGIN
		INSERT Bill VALUES (GETDATE(), NULL, 0, 0, 0, @idTable1)
		SELECT @idFirstBill = MAX(IdBill) FROM Bill WHERE IdTable = @idTable1 AND StatusBill = 0
	END
	
	IF (@idSecondBill IS NULL)
	BEGIN
		INSERT Bill VALUES (GETDATE(), NULL, 0, 0, 0, @idTable2)
		SELECT @idSecondBill = MAX(IdBill) FROM Bill WHERE IdTable = @idTable2 AND StatusBill = 0	
	END

	UPDATE BillInfo SET IdBill = @idSecondBill WHERE IdBill = @idFirstBill
	
	DECLARE @isSecondTableEmpty INT = 0
	SELECT @isSecondTableEmpty = COUNT(*) FROM BillInfo WHERE IdBill = @idSecondBill
		
	UPDATE TableFood SET StatusTable = N'Trống' WHERE IdTable = @idTable1

	IF (@isSecondTableEmpty = 0)
		UPDATE TableFood SET StatusTable = N'Trống' WHERE IdTable = @idTable2
	ELSE 
		UPDATE TableFood SET StatusTable = N'Có người' WHERE IdTable = @idTable2
END
GO

CREATE PROC SP_GetListBillByDate
@dateCheckIn DATE,
@dateCheckOut DATE
AS
BEGIN
	SELECT NameTable AS [Tên bàn], DateCheckInBill AS [Ngày vào], DateCheckOutBill AS [Ngày ra], Discount AS [Giảm giá], TotalPrice AS [Tổng tiền]
	FROM Bill, TableFood
	WHERE Bill.IdTable = TableFood.IdTable
	AND StatusBill = 1
	AND DateCheckInBill >= @dateCheckIn AND DateCheckOutBill <= DateCheckOutBill
END
GO

CREATE PROC SP_GetAccountByUsername
@username NVARCHAR(50)
AS
BEGIN
	SELECT Username, DisplayName, Password, Access
	FROM Account
	WHERE Username = @username
END
GO

CREATE PROC SP_UpdateAccount
@userName NVARCHAR(50), 
@displayName NVARCHAR(100), 
@password NVARCHAR(50), 
@newPassword NVARCHAR(50)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE Username = @userName AND Password = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, Password = @newPassword WHERE UserName = @userName
	END
END
GO

CREATE PROC SP_SearchDrink
@keyword NVARCHAR(100)
AS
BEGIN
	SELECT @keyword = dbo.F_VietnameseWithoutAccents(@keyword);
	SET @keyword = CONCAT(N'%', @keyword, N'%')

	SELECT *
	FROM Drink
	WHERE dbo.F_VietnameseWithoutAccents(NameDrink) LIKE @keyword
END
GO

CREATE PROC SP_InsertDrink
@nameDrink NVARCHAR(100),
@priceDrink FLOAT,
@idCategory INT
AS
BEGIN
	INSERT INTO Drink 
	VALUES (@nameDrink, @priceDrink, @idCategory)
END
GO

CREATE PROC SP_UpdateDrink
@idDrink INT,
@nameDrink NVARCHAR(100),
@priceDrink FLOAT,
@idCategory INT
AS
BEGIN
	UPDATE Drink
	SET NameDrink = @nameDrink, PriceDrink = @priceDrink, IdCategory = @idCategory
	WHERE IdDrink = @idDrink
END
GO

CREATE PROC SP_DeleteDrink
@idDrink INT
AS
BEGIN
	DELETE Drink
	WHERE IdDrink = @idDrink
END
GO

CREATE FUNCTION F_VietnameseWithoutAccents(@str NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN
    IF (@str IS NULL OR @str = '')  RETURN ''

    DECLARE @signChars NCHAR(256)
    DECLARE @unsignChars NCHAR (256)

    SET @signChars = N'áàảãạăắằẳẵặâấầẩẫậđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴ' + NCHAR(272) + NCHAR(208)
    SET @unsignChars = N'aaaaaaaaaaaaaaaaadeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyyAAAAAAAAAAAAAAAAADEEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOOOUUUUUUUUUUUYYYYYDD'

    DECLARE @count INT = 1
    DECLARE @count1 INT

    WHILE (@count <= LEN(@str))
    BEGIN  
        SET @count1 = 1
        WHILE (@count1 <= LEN(@signChars) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@signChars, @count1, 1)) = UNICODE(SUBSTRING(@str, @count, 1))
            BEGIN          
                IF @count = 1
                    SET @str = SUBSTRING(@unsignChars, @count1, 1) + SUBSTRING(@str, @count + 1, LEN(@str) - 1)      
                ELSE
                    SET @str = SUBSTRING(@str, 1, @count - 1) + SUBSTRING(@unsignChars, @count1, 1) + SUBSTRING(@str, @count + 1, LEN(@str) - @count)
                BREAK
            END
            SET @count1 = @count1 + 1
        END
        SET @count = @count + 1
    END
    RETURN @str
END
GO

CREATE PROC SP_SearchTable
@keyword NVARCHAR(100)
AS
BEGIN
	SELECT @keyword = dbo.F_VietnameseWithoutAccents(@keyword);
	SET @keyword = CONCAT(N'%', @keyword, N'%')

	SELECT *
	FROM TableFood
	WHERE dbo.F_VietnameseWithoutAccents(NameTable) LIKE @keyword
END
GO

CREATE PROC SP_InsertTable
@nameTable NVARCHAR(100)
AS
BEGIN
	INSERT INTO TableFood
	VALUES (@nameTable, N'Trống')
END
GO

CREATE PROC SP_UpdateTable
@idTable INT,
@nameTable NVARCHAR(100)
AS
BEGIN
	UPDATE TableFood
	SET NameTable = @nameTable
	WHERE IdTable = @idTable
END
GO

CREATE PROC SP_DeleteTable
@idTable INT
AS
BEGIN
	DELETE TableFood
	WHERE IdTable = @idTable
END
GO

CREATE PROC SP_SearchCategory
@keyword NVARCHAR(100)
AS
BEGIN
	SELECT @keyword = dbo.F_VietnameseWithoutAccents(@keyword);
	SET @keyword = CONCAT(N'%', @keyword, N'%')

	SELECT *
	FROM Category
	WHERE dbo.F_VietnameseWithoutAccents(NameCategory) LIKE @keyword
END
GO

CREATE PROC SP_InsertCategory
@nameCategory NVARCHAR(100)
AS
BEGIN
	INSERT INTO Category
	VALUES (@nameCategory)
END
GO

CREATE PROC SP_UpdateCategory
@idCategory INT,
@nameCategory NVARCHAR(100)
AS
BEGIN
	UPDATE Category
	SET NameCategory = @nameCategory
	WHERE IdCategory = @idCategory
END
GO

CREATE PROC SP_DeleteCategory
@idCategory INT
AS
BEGIN
	DELETE Drink
	WHERE IdCategory = @idCategory

	DELETE Category
	WHERE IdCategory = @idCategory
END
GO

CREATE PROC SP_GetAccount
AS
BEGIN
	SELECT Username AS [Tên tài khoản], DisplayName AS [Tên hiển thị], Access AS [Quyền truy cập]
	FROM Account
END
GO

CREATE PROC SP_SearchAccount
@keyword NVARCHAR(100)
AS
BEGIN
	SELECT @keyword = dbo.F_VietnameseWithoutAccents(@keyword);
	SET @keyword = CONCAT(N'%', @keyword, N'%')

	SELECT *
	FROM Account
	WHERE dbo.F_VietnameseWithoutAccents(Username) LIKE @keyword
END
GO

CREATE PROC SP_InsertAccount
@username NVARCHAR(50),
@displayName NVARCHAR(100),
@access NVARCHAR(100)
AS
BEGIN
	INSERT INTO Account
	VALUES (@username, @displayName, N'cafe31', @access)
END
GO

CREATE PROC SP_EditAccount
@username NVARCHAR(50),
@displayName NVARCHAR(100),
@access NVARCHAR(100)
AS
BEGIN
	UPDATE Account
	SET DisplayName = @displayName, Access = @access
	WHERE Username = @username
END
GO

CREATE PROC SP_DeleteAccount
@username NVARCHAR(50)
AS
BEGIN
	DELETE Account
	WHERE Username = @username
END
GO

CREATE PROC SP_ResetPassword
@username NVARCHAR(50)
AS
BEGIN
	UPDATE Account
	SET Password = N'cafe31'
	WHERE Username = @username
END
GO

CREATE PROC SP_GetBillByDateAndPage
@checkIn DATE, 
@checkOut DATE, 
@page INT
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows;
	
	WITH BillShow 
	AS 
	(
		SELECT Bill.IdBill AS [ID], NameTable AS [Tên bàn], DateCheckInBill AS [Ngày vào], DateCheckOutBill AS [Ngày ra], Discount AS [Giảm giá], TotalPrice AS [Tổng tiền]
		FROM Bill, TableFood
		WHERE DateCheckInBill >= @checkIn AND DateCheckInBill <= @checkOut 
		AND StatusBill = 1 AND Bill.IdTable = TableFood.IdTable
	)
	
	SELECT TOP (@selectRows) * 
	FROM BillShow 
	WHERE ID NOT IN 
	(
		SELECT TOP (@exceptRows) ID 
		FROM BillShow
	)
END
GO

CREATE PROC SP_GetNumBillByDate
@checkIn DATE, 
@checkOut DATE
AS 
BEGIN
	SELECT COUNT(*)
	FROM Bill, TableFood
	WHERE DateCheckInBill >= @checkIn AND DateCheckInBill <= @checkOut 
	AND StatusBill = 1 
	AND Bill.IdTable = TableFood.IdTable
END
GO