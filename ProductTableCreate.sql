CREATE TABLE Product (
	ProductID int IDENTITY (1,1),
	ProductName varchar(50),
	Price decimal(12, 2),
	Count int,
	PRIMARY KEY(ProductID)
);