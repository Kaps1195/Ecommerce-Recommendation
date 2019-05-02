------ All Tables stored in Training_20Feb_Mumbai --------
-- 1. Creating categories table first
CREATE TABLE Categories_174866_MiniProj
(
	CategoryId int PRIMARY KEY,
	CategoryName varchar(50),
	Description varchar(320)
)
drop table Categories_174866_MiniProj
select * from Categories_174866_MiniProj

INSERT INTO Categories_174866_MiniProj VALUES (1,'Light Bulb','A Generic Light Bulb')
INSERT INTO Categories_174866_MiniProj VALUES (2,'Table Fan','A Generic Table Fan')
INSERT INTO Categories_174866_MiniProj VALUES (3,'Tube Light','A Generic Tube Light')


-- 2. Creating Products Table 
CREATE TABLE Products_174866_MiniProj
(
	ProductsId int PRIMARY KEY not null,
	CategoryId int FOREIGN KEY REFERENCES Categories_174866_MiniProj(CategoryId),
	ModelNumber int,	
	ModelName varchar(100),
	UnitCost decimal,
	Description varchar(320),
	imageUrl varchar(2083)
)
drop table Products_174866_MiniProj

select * from Products_174866_MiniProj

INSERT INTO Products_174866_MiniProj VALUES (101,1,1,'Philips',10,'Energy efficient light bulb','https://images.homedepot-static.com/productImages/586925f5-a0f1-483d-9a6d-0fd4497c60a7/svn/philips-led-bulbs-455955-64_1000.jpg')
INSERT INTO Products_174866_MiniProj VALUES (102,1,2,'Havells',20,'Cost efficient light bulb','https://www.havells.com/getattachment/0c5c3bff-4c05-4bda-b131-0017aeca66e9/regular-lamps.aspx')
INSERT INTO Products_174866_MiniProj VALUES (103,1,3,'Panasonic',30,'Most Powerful light bulb','https://images-na.ssl-images-amazon.com/images/I/61cQxlQnSlL._SX466_.jpg')


-- 3. Creating ProductsRecommended table here
CREATE TABLE ProductsRecommend_174866_MiniProj
(
	ProductsRecId int primary key not null,
	ProductId int FOREIGN KEY REFERENCES Products_174866_MiniProj(ProductsId),
	CategoryId int FOREIGN KEY REFERENCES Categories_174866_MiniProj(CategoryId),
	ModelNumber int,	
	ModelName varchar(100),
	UnitCost decimal,
	Description varchar(320),
	imageUrl varchar(2083)
)
drop table ProductsRecommend_174866_MiniProj

select * from Products_174866_MiniProj
select * from ProductsRecommend_174866_MiniProj

INSERT INTO ProductsRecommend_174866_MiniProj VALUES (1011,101,1,7899,'Bajaj Auto',5,'Long Lasting light bulb','https://5.imimg.com/data5/QS/VV/MY-32774374/bajaj-led-light-500x500.jpg')
INSERT INTO ProductsRecommend_174866_MiniProj VALUES (1012,102,1,6465,'Syska LED',10,'LED light bulb','http://syskaledlights.com/media/catalog/product/cache/1/image/1200x1200/9df78eab33525d08d6e5fb8d27136e95/s/y/syskaled_18v.jpg')

-- 4. Creating Customer Table
CREATE TABLE Customers_174866_MiniProj
(
	CustomerId int primary key NOT NULL,
	FullName varchar(50),
	Email varchar(320),
	Password varchar(100) NOT NULL,
	DeliveryAddress varchar(50) 
)
drop table Customers_174866_MiniProj
select * from Customers_174866_MiniProj

INSERT INTO Customers_174866_MiniProj VALUES (1,'Rumaan Ansari','rumi@gmail.com','hello@123','Pune')

-- 5. Creating Orders Table
CREATE TABLE Orders_174866_MiniProj
(
	OrderId int PRIMARY KEY NOT NULL,
	CustomerId int FOREIGN KEY REFERENCES Customers_174866_MiniProj(CustomerId),
	OrderDate Date,
	ShipDate Date
)
drop table Orders_174866_MiniProj
select * from Orders_174866_MiniProj

-- 6. Creating Order Details table here
CREATE TABLE OrderDetails_174866_MiniProj
(
	OrderId int FOREIGN KEY REFERENCES Orders_174866_MiniProj(OrderId),
	CustomerId int FOREIGN KEY REFERENCES Customers_174866_MiniProj(CustomerId),
	Quantity int,
	UnitCost int
)
drop table OrderDetails_174866_MiniProj
select * from OrderDetails_174866_MiniProj

-- 7. Creating Shopping Cart table here
CREATE TABLE ShoppingCart_174866_MiniProj
(
	RecordId int PRIMARY KEY NOT NULL,
	CartId int,
	Quantity int,
	ProductId int FOREIGN KEY REFERENCES Products_174866_MiniProj(ProductsId),
	DateCreated Date
)
drop table ShoppingCart_174866_MiniProj

SELECT * FROM ShoppingCart_174866_MiniProj

-- 8. Creating SalesTax Table here 
CREATE TABLE SalesTax_174866_MiniProj
(
	SalesTaxId int PRIMARY KEY NOT NULL,
	State varchar(50),
	County varchar(50),
	City varchar(50),
	Jurisdiction varchar(50),
	SalesTax int
)
drop table SalesTax_174866_MiniProj
select * from SalesTax_174866_MiniProj

--9. Admin Table for Login
CREATE TABLE Admin_174866_MiniProj
(
	AdminId int primary key,
	AdminEmail varchar(320),
	AdminPwd varchar(320) NOT NULL
)

SELECT * FROM Admin_174866_MiniProj

INSERT INTO Admin_174866_MiniProj VALUES (1,'admin@hifishopee.com','admin@123')

