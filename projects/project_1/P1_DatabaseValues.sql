--USE P1_StoreApplicationDB;
--GO

-- INSERT
--INSERT INTO Customer(FirstName, LastName)
--VALUES ('Tanjiro','Kamado'), ('Naruto','Uzumaki'), ('Kyo','Sohma');
--SELECT * FROM Customer;

--INSERT INTO Store(Location)
--VALUES ('Denver'), ('Boulder'), ('Colorado Springs');
--SELECT * FROM Store;

--INSERT INTO BookType(BookType)
--VALUES ('Non-Fiction'), ('Fiction');
--SELECT * FROM BookType;

--INSERT INTO BookGenre(BookGenre)
--VALUES ('Autobiography'), ('Memoir'), ('Manga'), ('Romance'), ('Suspense');
--SELECT * FROM BookGenre;

--INSERT INTO Book(BookTypeID, BookGenreID, BookPrice, QuantityAvailable)
--VALUES (1, 1, 15.00, 50), (1, 2, 15.00, 50), (2, 3, 10.00, 50), (2, 4, 18.00, 50), (2, 5, 18.00, 50);
--SELECT * FROM Book;

--INSERT INTO [Order](CustomerID, StoreID, BookID, Quantity, OrderDate)
--VALUES (1, 1, 1, 2, GETDATE()), (1, 1, 2, 1, GETDATE());

--INSERT INTO [Order](CustomerID, StoreID, BookID, Quantity, OrderDate)
--VALUES (2, 1, 3, 1, GETDATE());

--INSERT INTO [Order](CustomerID, StoreID, BookID, Quantity, OrderDate)
--VALUES (3, 2, 4, 2, GETDATE()), (3, 2, 2, 1, GETDATE());

--INSERT INTO [Order](CustomerID, StoreID, BookID, Quantity, OrderDate)
--VALUES (1, 3, 5, 2, GETDATE());
--SELECT * FROM [Order];

--SELECT Book.BookID, BookType.BookType, BookGenre.BookGenre, Book.BookPrice, Book.QuantityAvailable
--FROM ((Book
--INNER JOIN BookType
--ON BookType.BookTypeID = Book.BookTypeID)
--INNER JOIN BookGenre
--ON BookGenre.BookGenreID = Book.BookGenreID);


CREATE PROCEDURE GetBooks
AS
BEGIN
	SELECT Book.BookID, BookType.BookType, BookGenre.BookGenre, Book.BookPrice, Book.QuantityAvailable
	FROM ((Book
	INNER JOIN BookType
	ON BookType.BookTypeID = Book.BookTypeID)
	INNER JOIN BookGenre
	ON BookGenre.BookGenreID = Book.BookGenreID);
END;
GO

EXECUTE GetBooks;
