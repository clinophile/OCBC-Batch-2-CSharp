CREATE DATABASE BANK

CREATE TABLE OFFICES(
	OFFICECODE INT PRIMARY KEY,
	PHONE VARCHAR(15) NULL,
	ADDRESSLINE1 VARCHAR(100) NULL,
	ADDRESSLINE2 VARCHAR(100) NULL,
	CITY VARCHAR(50) NULL,
	STATES VARCHAR(50) NULL,
	POSTALCODE VARCHAR(10) NULL,
	COUNTRY VARCHAR(50) NULL,
	TERRITORY VARCHAR(50) NULL)

INSERT INTO OFFICES(OFFICECODE, PHONE, ADDRESSLINE1,
	ADDRESSLINE2, CITY, STATES, POSTALCODE, COUNTRY,
	TERRITORY)
VALUES (1, '0000001', 'KOPO', NULL, 'BANDUNG', 'JAWA BARAT', '40228', 'INDONESIA', 'A'),
(2, '0000002', 'CIBADUYUT', NULL, 'BANDUNG', 'JAWA BARAT', '40228', 'INDONESIA', 'B'),
(3, '0000003', 'KUNINGAN', NULL, 'JAKARTA', 'DKI JAKARTA', '10110', 'INDONESIA', 'C'),
(4, '0000004', 'LEMBANG', NULL, 'BANDUNG', 'JAWA BARAT', '40228', 'INDONESIA', 'D'),
(5, '0000005', 'SUDIRMAN', NULL, 'JAKARTA', 'DKI JAKARTA', '10110', 'INDONESIA', 'E')

CREATE TABLE EMPLOYEE (
	EMPLOYEENUMBER INT PRIMARY KEY,
	LASTNAME VARCHAR(100) NULL,
	FIRSTNAME VARCHAR (100) NULL,
	EXTENSION VARCHAR(50) NULL,
	EMAIL VARCHAR(100) NULL,
	OFFICECODE INT NULL,
	REPORTSTO VARCHAR(100) NULL,
	JOBTITLE VARCHAR(100) NULL,
	FOREIGN KEY (OFFICECODE) REFERENCES OFFICES(OFFICECODE))

INSERT INTO EMPLOYEE(EMPLOYEENUMBER, LASTNAME, FIRSTNAME,
	EXTENSION, EMAIL, OFFICECODE, REPORTSTO, JOBTITLE)
VALUES (1, 'ZU', 'ZUZU', 'ZZZZZ', 'Z@YAHOO.COM', 1, 'AAA', 'SALES'),
(2, 'YA', 'YAYA', 'YYYYY', 'Y@YAHOO.COM', 1, 'BBB', 'SALES'),
(3, 'XI', 'XIXI', 'XXXXX', 'X@YAHOO.COM', 2, 'CCC', 'SALES'),
(4, 'WO', 'WOWO', 'WWWWW', 'W@YAHOO.COM', 2, 'DDD', 'SALES'),
(5, 'VE', 'VEVE', 'VVVVV', 'V@YAHOO.COM', 3, 'EEE', 'SALES'),
(6, 'LA', 'ULALA', 'UUUUU', 'U@YAHOO.COM', 3, 'FFF', 'MANAGER'),
(7, 'TA', 'TATA', 'TTTTT', 'T@YAHOO.COM', 4, 'GGG', 'IT SUPPORT')


CREATE TABLE CUSTOMERS (
	CUSTOMERNUMBER INT PRIMARY KEY,
	CUSTOMERNAME VARCHAR(100) NULL,
	CONTACTLASTNAME VARCHAR(100) NULL,
	CONTACTFIRSTNAME VARCHAR (100) NULL,
	PHONE VARCHAR(15) NULL,
	ADDRESSLINE1 VARCHAR(100) NULL,
	ADDRESSLINE2 VARCHAR(100) NULL,
	CITY VARCHAR(50) NULL,
	STATES VARCHAR(50) NULL,
	POSTALCODE VARCHAR(10) NULL,
	COUNTRY VARCHAR(50) NULL,
	SALESREPEMPLOYEENUMBER INT NULL,
	CREDITLIMIT FLOAT NULL,
	FOREIGN KEY (SALESREPEMPLOYEENUMBER) REFERENCES EMPLOYEE(EMPLOYEENUMBER))


INSERT INTO CUSTOMERS(CUSTOMERNUMBER, CUSTOMERNAME, CONTACTLASTNAME, CONTACTFIRSTNAME,
	PHONE, ADDRESSLINE1, ADDRESSLINE2, CITY, STATES, POSTALCODE, COUNTRY,
	SALESREPEMPLOYEENUMBER, CREDITLIMIT)
	VALUES (1, 'ALAN LAN', 'LAN', 'ALAN', '0123456789', 'KOPO', 'CIBADUYUT', 'BANDUNG', 'JAWA BARAT',
	'40228', 'INDONESIA', 1, 10000),
	(2, 'BIBI BI', 'BI', 'BIBI', '0111111', 'KOPO', 'CIBADUYUT', 'BANDUNG', 'JAWA BARAT',
	'40228', 'INDONESIA', 1, 10000),
	(3, 'CUCU CU', 'CU', 'CUCU', '0222222', 'KOPO', 'CIBADUYUT', 'BANDUNG', 'JAWA BARAT',
	'40228', 'INDONESIA', 2, 50000),
	(4, 'DODO DO', 'DO', 'DODO', '0133333', 'SUDIRMAN', 'SLIPI', 'JAKARTA', 'DKI JAKARTA',
	'10110', 'INDONESIA', 3, 100000),
	(5, 'ELA LA', 'LA', 'ELA', '0444444', 'DAGO', 'SETIABUDI', 'BANDUNG', 'JAWA BARAT',
	'40228', 'INDONESIA', 2, 30000),
	(6, 'FAFI FU', 'FU', 'FAFI', '05555555', 'KUNINGAN', 'CEMPAKA PUTIH', 'JAKARTA', 'DKI JAKARTA',
	'10110', 'INDONESIA', 3, 20000),
	(7, 'GUGU GAGA', 'GAGA', 'GUGU', '0166666', 'SUDIRMAN', NULL , 'JAKARTA', 'DKI JAKARTA',
	'10110', 'INDONESIA', 3, 50000),
	(8, 'HAHA HIHI', 'HAHA', 'HIHI', '0777777', 'KUNINGAN', NULL , 'JAKARTA', 'DKI JAKARTA',
	'10110', 'INDONESIA', 4, 150000),
	(9, 'INI ITU', 'ITU', 'INI', '0888888', 'SULTAN AGUNG', NULL , 'JAKARTA', 'DKI JAKARTA',
	'10110', 'INDONESIA', 4, 60000),
	(10, 'JOJO MOJO', 'MOJO', 'JOJO', '099999', 'LEMBANG', NULL , 'BANDUNG', 'JAWA BARAT',
	'40228', 'INDONESIA', 5, 200000)


CREATE TABLE PRODUCTS (
	PRODUCTCODE INT PRIMARY KEY,
	PRODUCTNAME VARCHAR(100) NULL,
	PRODUCTLINE INT NULL,
	PRODUCTSCALE VARCHAR (100) NULL,
	PRODUCTVENDOR VARCHAR(100) NULL,
	PRODUCTDESCRIPTION VARCHAR(100) NULL,
	QUANTITYINSTOCK FLOAT NULL,
	BUYPRICE FLOAT NULL,
	MSRP FLOAT NULL,
	FOREIGN KEY (PRODUCTLINE) REFERENCES PRODUCTLINES(PRODUCTLINE))

INSERT INTO PRODUCTS(PRODUCTCODE, PRODUCTNAME, PRODUCTLINE, PRODUCTSCALE,
	PRODUCTVENDOR, PRODUCTDESCRIPTION, QUANTITYINSTOCK, BUYPRICE, MSRP)
VALUES(1, 'BRIO', 1, 'AAAA', 'HONDA', 'ZZZZ', 5, 1500, 1000),
(2, 'CIVIC', 1, 'AAAA', 'HONDA', 'ZZZZ', 3, 1300, 1000),
(3, 'MIO', 3, 'BBBB', 'YAMAHA', 'XXXXX', 8, 200, 200),
(4, 'NMAX', 3, 'BBBB', 'YAMAHA', 'XXXXX', 4, 700, 500),
(5, 'AEROX', 4, 'BBBB', 'YAMAHA', 'XXXX', 2, 700, 500)

CREATE TABLE PRODUCTLINES (
	PRODUCTLINE INT PRIMARY KEY,
	TEXTDESCRIPTION VARCHAR(100) NULL,
	HTMLDESCRIPTION VARCHAR(100) NULL,
	IMAGES VARBINARY NULL)

INSERT INTO PRODUCTLINES(PRODUCTLINE, TEXTDESCRIPTION, HTMLDESCRIPTION, IMAGES)
VALUES (1, 'MOBIL_1', 'MOBIL_1', NULL),
(2, 'MOBIL_2', 'MOBIL_2', NULL),
(3, 'MOTOR_1', 'MOTOR_1', NULL),
(4, 'MOTOR_2', 'MOTOR_2', NULL),
(5, 'MOTOR_3', 'MOTOR_3', NULL)


CREATE TABLE ORDERS (
	ORDERNUMBER INT PRIMARY KEY,
	ORDERDATE DATE NULL,
	REQUIREDDATE DATE NULL,
	SHIPPEDDATE DATE NULL,
	STATUSORDER VARCHAR(100) NULL,
	COMMENTS VARCHAR(100) NULL,
	CUSTOMERNUMBER INT,
	FOREIGN KEY (CUSTOMERNUMBER) REFERENCES CUSTOMERS(CUSTOMERNUMBER))

INSERT INTO ORDERS(ORDERNUMBER,ORDERDATE, REQUIREDDATE, SHIPPEDDATE,
	STATUSORDER, COMMENTS, CUSTOMERNUMBER)
VALUES (1, '2020-10-13', '2020-10-25', '2020-10-20', 'IN PROGRESS', 'AAAA', 1),
(2, '2020-12-30', '2021-01-25', '2021-01-05', 'WAITING', 'BBBBB', 7),
(3, '2020-10-10', '2020-10-25', '2020-10-20', 'IN PROGRESS', 'CCCC', 4),
(4, '2020-10-10', '2020-10-25', '2020-10-20', 'IN PROGRESS', 'DDDDD', 2),
(5, '2020-12-11', '2020-12-30', '2020-10-15', 'WAITING', 'VVVVVV', 5),
(6, '2020-10-13', '2020-10-25', '2020-10-20', 'WAITING', 'LLLLLL', 1),
(7, '2019-01-01', '2020-01-10', '2020-01-05', 'DELIVERED', 'PPPPP', 9),
(8, '2019-01-01', '2020-01-10', '2020-01-05', 'DELIVERED', 'RRRRR', 9)


CREATE TABLE ORDERDETAILS (
	ORDERNUMBER INT,
	PRODUCTCODE INT,
	QUANTITYORDERED FLOAT,
	PRICEEACH FLOAT,
	ORDERLINENUMBER INT,
	FOREIGN KEY (ORDERNUMBER) REFERENCES ORDERS(ORDERNUMBER),
	FOREIGN KEY (PRODUCTCODE) REFERENCES PRODUCTS(PRODUCTCODE))

INSERT INTO ORDERDETAILS(ORDERNUMBER, PRODUCTCODE, QUANTITYORDERED,
	PRICEEACH, ORDERLINENUMBER)
VALUES(1, 1, 1, 1500, 1),
(2, 1, 1, 1500, 2),
(3, 3, 1, 200, 3),
(4, 3, 1, 200, 4),
(5, 5, 1, 700, 5),
(6, 2, 1, 1300, 6),
(7, 2, 1, 1300, 7),
(8, 4, 1, 700, 8)

CREATE TABLE PAYMENTS (
	CUSTOMERNUMBER INT,
	CHECKNUMBER INT PRIMARY KEY,
	PAYMENTDATE DATE,
	AMOUNT FLOAT,
	FOREIGN KEY (CUSTOMERNUMBER) REFERENCES CUSTOMERS(CUSTOMERNUMBER))

INSERT INTO PAYMENTS(CUSTOMERNUMBER, CHECKNUMBER,
	PAYMENTDATE, AMOUNT)
VALUES(1, 1, '2020-10-13', 1500),
(4, 2, '2020-10-11', 200),
(2, 3, '2020-10-11', 200),
(5, 4, '2020-12-11', 1300),
(9, 5, '2020-01-02', 2000)




SELECT * FROM CUSTOMERS
SELECT * FROM PRODUCTS
SELECT * FROM PRODUCTLINES
SELECT * FROM ORDERS
SELECT * FROM ORDERDETAILS
SELECT * FROM PAYMENTS
SELECT * FROM EMPLOYEE
SELECT * FROM OFFICES



