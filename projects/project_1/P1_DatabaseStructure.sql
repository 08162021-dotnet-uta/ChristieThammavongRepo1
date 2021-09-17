--USE MASTER;
--GO

-- CREATE
--CREATE DATABASE P1_StoreApplicationDB;
--GO

--USE P1_StoreApplicationDB;
--GO

--CREATE TABLE Customer
--(
--    CustomerID TINYINT NOT NULL IDENTITY(1,1)
--    , FirstName NVARCHAR(100) NOT NULL
--    , LastName NVARCHAR(100) NOT NULL
--);

--CREATE TABLE Store
--(
--    StoreID TINYINT NOT NULL IDENTITY(1,1)
--    , [Location] NVARCHAR(100) NOT NULL
--);

--CREATE TABLE Book
--(
--    BookID TINYINT NOT NULL IDENTITY(1,1)
--    , BookTypeID TINYINT NOT NULL
--    , BookGenreID TINYINT NOT NULL
--    , BookPrice MONEY NOT NULL
--	, QuantityAvailable TINYINT NOT NULL
--);

--CREATE TABLE BookType
--(
--	BookTypeID TINYINT NOT NULL IDENTITY(1,1)
--	, BookType NVARCHAR(100) NOT NULL
--);

--CREATE TABLE BookGenre
--(
--	BookGenreID TINYINT NOT NULL IDENTITY(1,1)
--	, BookGenre NVARCHAR(100) NOT NULL
--);

--CREATE TABLE [Order]
--(
--    OrderID SMALLINT NOT NULL IDENTITY(1,1)
--    , CustomerID TINYINT NOT NULL
--    , StoreID TINYINT NOT NULL
--	, BookID TINYINT NOT NULL
--	, Quantity TINYINT NOT NULL
--    , OrderDate DATETIME2(7) NOT NULL
--);

-- ALTER
--ALTER TABLE Customer
--	ADD CONSTRAINT PK_Customer PRIMARY KEY (CustomerID);

--ALTER TABLE Store
--	ADD CONSTRAINT PK_Store PRIMARY KEY (StoreID);

--ALTER TABLE Book
--	ADD CONSTRAINT PK_Book PRIMARY KEY (BookID);

--ALTER TABLE BookType
--	ADD CONSTRAINT PK_BookType PRIMARY KEY (BookTypeID);

--ALTER TABLE BookGenre
--	ADD CONSTRAINT PK_BookGenre PRIMARY KEY (BookGenreID);

--ALTER TABLE [Order]
--	ADD CONSTRAINT PK_Order PRIMARY KEY (OrderID);

--ALTER TABLE Book
--	ADD CONSTRAINT FK_Book_BookType FOREIGN KEY (BookTypeID) REFERENCES BookType(BookTypeID);

--ALTER TABLE Book
--	ADD CONSTRAINT FK_Book_BookGenre FOREIGN KEY (BookGenreID) REFERENCES BookGenre(BookGenreID);

--ALTER TABLE [Order]
--	ADD CONSTRAINT FK_Order_Customer FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID);

--ALTER TABLE [Order]
--	ADD CONSTRAINT FK_Order_Store FOREIGN KEY (StoreID) REFERENCES Store(StoreID);

--ALTER TABLE [Order]
--	ADD CONSTRAINT FK_Order_Book FOREIGN KEY (BookID) REFERENCES Book(BookID);

ALTER TABLE [Order]
	ADD CONSTRAINT CK_OrderDate CHECK (OrderDate <= getdate());
