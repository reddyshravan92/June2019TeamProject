CREATE DATABASE eCommerceDb

USE eCommerceDb

CREATE TABLE Category(
Id INT IDENTITY PRIMARY KEY,
Name nvarchar(100) NULL,
[Description] nvarchar(Max))


CREATE TABLE Supplier(
Id INT IDENTITY PRIMARY KEY,
Name nvarchar(MAX))

CREATE TABLE Product(
ID INT IDENTITY PRIMARY KEY,
Name nvarchar(MAX),
Price money,
CategoryId INT,
SupplierId INT,
CONSTRAINT FK_Product_Category  foreign key (CategoryId) REFERENCES  dbo.Category(Id),
CONSTRAINT FK_Product_Supplier  foreign key (SupplierId) REFERENCES  dbo.Supplier(Id))

CREATE TABLE Customer(
Id int IDENTITY PRIMARY KEY,
FirstName nvarchar(MaX),
LastName nvarchar(MAX),
Email nvarchar(max),
[Address] nvarchar(max))


CREATE TABLE [Order](
Id INT IDENTITY PRIMARY KEY,
CustomerId INT,
OrderDate datetime,
CONSTRAINT FK_Order_Customer FOREIGN KEY(CustomerId) REFERENCES dbo.Customer(Id))

CREATE TABLE OrderDetail(
Id int IDENTITY PRIMARY KEY,
OrderId INT,
ProductId INT,
Qty INT,
CONSTRAINT FK_OrderDetail_Order FOREIGN KEY(OrderId) REFERENCES dbo.[Order](Id),
CONSTRAINT FK_OrderDetail_Product FOREIGN KEY(ProductId) REFERENCES dbo.Product(Id))


