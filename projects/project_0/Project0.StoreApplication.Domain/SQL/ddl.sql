-- -- DDL = data definition language
--USE MASTER;
--GO

-- CREATE
--CREATE DATABASE StoreApplicationDB;
--GO

--USE StoreApplicationDB;
--GO

--CREATE SCHEMA Store;
--GO

--CREATE SCHEMA Customer;
--GO

--CREATE TABLE Customer.Customer
--(
--     char (a set number of characters), nchar
--     varchar (varying characters), nvarchar
--     tinyint, smallint, int, bigint, money, decimal, numerical
--    CustomerID TINYINT NOT NULL IDENTITY(1,1)
--    , FirstName NVARCHAR(100) NOT NULL
--    , LastName NVARCHAR(100) NOT NULL
--);

--CREATE TABLE Store.Store
--(
--    StoreID TINYINT NOT NULL IDENTITY(1,1)
--    , [Location] NVARCHAR(100) NOT NULL
--);

--CREATE TABLE Store.Product
--(
--    ProductID TINYINT NOT NULL IDENTITY(1,1)
--    , BookType NVARCHAR(100) NOT NULL
--    , Genre NVARCHAR(100) NOT NULL
--    , Price MONEY NOT NULL
--);

--CREATE TABLE Store.[Order]
--(
--    OrderID SMALLINT NOT NULL IDENTITY(1,1)
--    , CustomerID TINYINT NOT NULL
--    , StoreID TINYINT NOT NULL
--    , OrderDate DATETIME2(7) NOT NULL
--);

--CREATE TABLE Store.OrderProduct
--(
--    OrderProductID SMALLINT NOT NULL IDENTITY(1,1)
--    , OrderID SMALLINT NOT NULL
--    , ProductID SMALLINT NOT NULL
--);

-- ALTER
 --ALTER TABLE Customer.Customer
 --    ADD CONSTRAINT PK_Customer PRIMARY KEY (CustomerID);

 --ALTER TABLE Store.Store
 --    ADD CONSTRAINT PK_Store PRIMARY KEY (StoreID);

 --ALTER TABLE Store.Product
 --    ADD CONSTRAINT PK_Product PRIMARY KEY (ProductID);

 --ALTER TABLE Store.[Order]
 --    ADD CONSTRAINT PK_Order PRIMARY KEY (OrderID);

 --ALTER TABLE Store.OrderProduct
 --    ADD CONSTRAINT PK_OrderProduct PRIMARY KEY (OrderProductID);

 --ALTER TABLE Store.[Order]
 --    ADD CONSTRAINT FK_Order_Customer FOREIGN KEY (CustomerID) REFERENCES Customer.Customer(CustomerID);

 --ALTER TABLE Store.[Order]
 --    ADD CONSTRAINT FK_Order_Store FOREIGN KEY (StoreID) REFERENCES Store.Store(StoreID);

-- ALTER TABLE Customer.Customer
--     ADD CONSTRAINT DF_Customer DEFAULT (1) for Active;

-- ALTER TABLE Store.[Order]
--     ADD CONSTRAINT DF_Order DEFAULT (1) for Active;

-- ALTER TABLE Store.OrderProduct
--     ADD CONSTRAINT DF_OrderProduct DEFAULT (1) for Active;

-- ALTER TABLE Store.Product
--     ADD CONSTRAINT DF_Product DEFAULT (1) for Active;

-- ALTER TABLE Store.Store
--     ADD CONSTRAINT DF_Store DEFAULT (1) for Active;

 ALTER TABLE Store.[Order]
     ADD CONSTRAINT CK_Order CHECK (OrderDate <= getdate());

-- DROP
-- DROP DATABASE StoreApplicationDB;
-- DROP SCHEMA Customer;
-- DROP TABLE Customer.Customer;

-- TRUNCATE
-- TRUNCATE TABLE Customer.Customer;

-- STORED PROCEDURE
-- CREATE PROCEDURE SP_AddCustomer(@name NVARCHAR(100))
-- AS
-- BEGIN
--     DECLARE @result NVARCHAR(100);

--     SELECT @result = [Name]
--     FROM Customer.Customer
--     WHERE [Name] = @name;

--     IF (@result IS NULL)
--     BEGIN
--         INSERT INTO Customer.Customer([Name])
--         VALUES (@name)
--     END
-- END