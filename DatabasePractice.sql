--1.	Design a Database for a company to Manage all its projects.
--Company has diverse offices in several countries, which manage and co-ordinate the project of that country.
--Head office has a unique name, city, country, address, phone number and name of the director.
--Every head office manages a set of projects with Project code, title, project starting and end date, assigned budget and name of the person in-charge. One project is formed by the set of operations that can affect to several cities.
--We want to know what actions are realized in each city storing its name, country and number of inhabitants.

create database DB_Company_Management
on primary
(
NAME = 'DB_Company_Management.MDF',
FILENAME = 'C:\Users\90718\Desktop\Antra\DB_Company_Management.MDF',
SIZE = 16MB,
FILEGROWTH = 8MB,
MAXSIZE = UNLIMITED
)
LOG ON
(
NAME = 'DB_Company_Management.LDF',
FILENAME = 'C:\Users\90718\Desktop\Antra\DB_Company_Management.LDF',
SIZE = 16MB,
FILEGROWTH = 8MB,
MAXSIZE = UNLIMITED
)

use DB_Company_Management
go

create table Office
(
OfficeID int primary key identity(1, 1),
OfficeName varchar(32) not null unique,
Address varchar(50) not null,
City varchar(32) not null,
Country varchar(32) not null,
Phone char(15) not null,
DirectorName varchar(32) not null
)

create table Projects
(
ProjectCode int primary key identity(1, 1),
Title varchar(32) not null,
StartingDate date not null,
EndDate date not null,
Budget decimal(10, 2) not null,
InchargePersonName varchar(32) not null,
ManagedByOffice int foreign key references dbo.Office(OfficeID),
check(Budget > 0)
)

create table AffectedCity
(
CityID int primary key identity(1, 1),
CityName varchar(32) not null,
Country varchar(32) not null,
InhabitantsNumber int not null,
check(InhabitantsNumber > 0)
)

create table ProjectDetails
(
ProjectCode int foreign key references Projects(ProjectCode),
AffectedCityID int foreign key references AffectedCity(CityID),
primary key(ProjectCode, AffectedCityID)
)

--2.	Design a database for a lending company which manages lending among people (p2p lending)
--Lenders that lending money are registered with an Id, name and available amount of money for the financial operations. 
--Borrowers are identified by their id and the company registers their name and a risk value depending on their personal situation.
--When borrowers apply for a loan, a new loan code, the total amount, the refund deadline, the interest rate and its purpose are stored in database. 
--Lenders choose the amount they want to invest in each loan. A lender can contribute with different partial amounts to several loans.

create database DB_Lending_Company
on primary
(
NAME = 'DB_Lending_Company.MDF',
FILENAME = 'C:\Users\90718\Desktop\Antra\DB_Lending_Company.MDF',
SIZE = 16MB,
FILEGROWTH = 8MB,
MAXSIZE = UNLIMITED
)
LOG ON
(
NAME = 'DB_Lending_Company.LDF',
FILENAME = 'C:\Users\90718\Desktop\Antra\DB_Lending_Company.LDF',
SIZE = 16MB,
FILEGROWTH = 8MB,
MAXSIZE = UNLIMITED
)
go
use DB_Lending_Company
go

create table Lenders
(
LenderID int primary key identity(1, 1),
LenderName varchar(32) not null,
AvailableMoney decimal(8, 2)
)

create table Borrowers
(
BorrowerID int primary key identity(1, 1),
BorrowerName varchar(32) not null,
RiskValue int not null
)

create table Loans
(
LoanCode int primary key identity(1, 1),
BorrowerID int foreign key references Borrowers(BorrowerID) not null,
AmountApplied decimal(8, 2) not null,
RefundDeadline date not null,
InterestRate decimal(6, 4) not null,
Purpose ntext,
RepaidStatus bit,
check (AmountApplied > 0 and InterestRate >= 0)
)

create table LoansDetails
(
LenderID int foreign key references Lenders(LenderID),
LoanCode int foreign key references Loans(LoanCode),
LentMoney decimal(8, 2) not null,
check (LentMoney > 0),
primary key(LenderID, LoanCode)
)

--3.	Design a database to maintain the menu of a restaurant.
--Each course has its name, a short description, photo and final price.
--Each course has categories characterized by their names, short description, name of the employee in-charge of them.
--Besides the courses some recipes are stored. They are formed by the name of their ingredients, the required amount, units of measurements and the current amount in the store.

create database DB_Menu_Management
on primary
(
NAME = 'DB_Menu_Management.MDF',
FILENAME = 'C:\Users\90718\Desktop\Antra\DB_Menu_Management.MDF',
SIZE = 16MB,
FILEGROWTH = 8MB,
MAXSIZE = UNLIMITED
)
LOG ON
(
NAME = 'DB_Menu_Management.LDF',
FILENAME = 'C:\Users\90718\Desktop\Antra\DB_Menu_Management.LDF',
SIZE = 16MB,
FILEGROWTH = 8MB,
MAXSIZE = UNLIMITED
)

use DB_Menu_Management
go

create table Categories
(
CategoryID int primary key identity(1, 1),
CategoryName varchar(32) not null,
Description ntext,
EmployeeIncharge varchar(32) not null
)


create table Course
(
CourseID int primary key identity(1, 1),
CourseName varchar(32) not null,
Discription ntext,
Photo image,
Price decimal(6, 2) not null,
check(Price > 0),
CategoryID int foreign key references Categories(CategoryID)
)

create table Ingredients
(
IngredientID int primary key identity(1, 1),
IngredientName varchar(16) not null unique,
Units char(10) not null,
UnitsInStock int
)

create table Recipes
(
RecipeID int primary key identity(1, 1),
RecipeName varchar(16) not null unique
)

create table RecipesDetails
(
RecipeID int foreign key references Recipes(RecipeID),
IngredientID int not null foreign key references Ingredients(IngredientID),
Units char(5) not null,
AmountNeeded int not null,
check (AmountNeeded > 0),
primary key(RecipeID, IngredientID)
)
