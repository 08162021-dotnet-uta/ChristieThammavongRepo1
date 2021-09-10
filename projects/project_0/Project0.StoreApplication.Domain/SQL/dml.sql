-- DML = data manipulation language
USE StoreApplicationDB;
GO

-- INSERT
--INSERT INTO Customer.Customer
--VALUES ('Tanjiro','Kamado'), ('Naruto','Uzumaki'), ('Kyo','Sohma');
--SELECT * FROM Customer.Customer;

--INSERT INTO Store.Store
--VALUES ('Denver'), ('Boulder'), ('Colorado Springs');
--SELECT * FROM Store.Store;

INSERT INTO Store.Product
VALUES ('Non-Fiction','Autobiography',15.00), ('Non-Fiction','Memoir',15.00)
	,('Fiction','Manga',10.00), ('Fiction','Romance',18.00), ('Fiction','Suspense',18.00);
SELECT * FROM Store.Product;

-------- Examples from Training --------
---- INSERT
--INSERT INTO Customer.Customer([Name])
--VALUES('fred'), ('Tyler'), ('Cory');

--INSERT INTO Store.Product([Name], Price)
--VALUES ('computer', 500), ('monitor', 200);

--INSERT INTO Store.Store([Name])
--VALUES ('Best Buy'), ('Micro Center');

---- UPDATE
--UPDATE Customer.Customer
--SET [Name] = 'derf'
--WHERE [Name] = 'fred';

---- DELETE
--DELETE Customer.Customer
--WHERE [Name] = 'fred';

---- SELECT
----- Order of Execution
----- FROM
----- WHERE
----- GROUP BY
----- HAVING
----- SELECT
----- ORDER BY

---- get the product quantity from store

---- create report on all current customers
--SELECT [Name]
--FROM Customer.Customer
--WHERE Active = 1;

---- create report on most sold products (at least 100)
---- ProductOrder(count(ProductID))
--SELECT ProductID
--FROM Store.OrderProduct
--GROUP BY ProductID
--HAVING COUNT(ProductID) >= 100;

---- SET
---- JOIN
---- which customers bought a monitor?
---- customer, order, orderproduct, product
--SELECT NAME
--FROM Store.Product AS sp
--INNER JOIN Store.OrderProduct AS sop ON sop.ProductID = sp.ProductID
--LEFT JOIN Store.[Order] AS so ON so.OrderID = sop.OrderID
--LEFT JOIN Customer.Customer AS cc ON cc.CustomerID = so.CustomerID
--WHERE sp.Name = 'monitor';

---- UNION

