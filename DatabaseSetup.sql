-- =========================================================================
-- GAME LIBRARY MANAGEMENT SYSTEM - DATABASE SETUP SCRIPT
-- Compatible with SQL Server 2008 / 2008 R2 (Database Version 655) & VB.NET 2010
-- =========================================================================

-- Step 1: Create Database manually in SQL Server Management Studio
CREATE DATABASE GameLibraryDB;
GO

USE GameLibraryDB;
GO

-- Step 2: Create Users Table for Login Authentication
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(50) NOT NULL
);
GO

-- Step 3: Create Games Table
CREATE TABLE Games (
    GameID INT IDENTITY(1,1) PRIMARY KEY,
    GameName VARCHAR(100) NOT NULL,
    Genre VARCHAR(50) NOT NULL,
    Platform VARCHAR(50) NOT NULL,
    Developer VARCHAR(100) NULL,
    ReleaseYear INT NULL,
    Quantity INT NOT NULL DEFAULT 1,
    AvailableQuantity INT NOT NULL DEFAULT 1,
    RentalPrice DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    SellingPrice DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Status VARCHAR(20) NOT NULL DEFAULT 'Available'
);
GO

-- Step 4: Create BorrowIssue Table
CREATE TABLE BorrowIssue (
    IssueID INT IDENTITY(1,1) PRIMARY KEY,
    GameID INT NOT NULL FOREIGN KEY REFERENCES Games(GameID) ON DELETE CASCADE,
    BorrowerName VARCHAR(100) NOT NULL,
    BorrowerContact VARCHAR(50) NULL,
    IssueDate DATETIME NOT NULL DEFAULT GETDATE(),
    DueDate DATETIME NOT NULL,
    ReturnDate DATETIME NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Borrowed'
);
GO

-- Step 5: Create Rental Table (Game Rentals)
CREATE TABLE Rental (
    RentalID INT IDENTITY(1,1) PRIMARY KEY,
    GameID INT NOT NULL FOREIGN KEY REFERENCES Games(GameID) ON DELETE CASCADE,
    CustomerName VARCHAR(100) NOT NULL,
    CustomerPhone VARCHAR(50) NULL,
    CustomerAddress VARCHAR(200) NULL,
    RentalDate DATETIME NOT NULL DEFAULT GETDATE(),
    ReturnDate DATETIME NULL,
    RentalPrice DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Status VARCHAR(20) NOT NULL DEFAULT 'Rented'
);
GO

-- Step 6: Create Sales Table (Game Sales)
CREATE TABLE Sales (
    SaleID INT IDENTITY(1,1) PRIMARY KEY,
    GameID INT NOT NULL FOREIGN KEY REFERENCES Games(GameID) ON DELETE CASCADE,
    CustomerName VARCHAR(100) NOT NULL,
    CustomerPhone VARCHAR(50) NOT NULL,
    CustomerAddress VARCHAR(200) NOT NULL,
    SaleDate DATETIME NOT NULL DEFAULT GETDATE(),
    Quantity INT NOT NULL DEFAULT 1,
    SalePrice DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    TotalAmount DECIMAL(10,2) NOT NULL DEFAULT 0.00
);
GO

-- Step 7: Insert Default Admin User for Login
INSERT INTO Users (Username, Password) VALUES ('admin', 'admin123');
GO

-- Step 8: Sample Data for Demonstration
INSERT INTO Games (GameName, Genre, Platform, Developer, ReleaseYear, Quantity, AvailableQuantity, RentalPrice, SellingPrice, Status)
VALUES 
('The Legend of Zelda: Ocarina of Time', 'Action-Adventure', 'Nintendo 64', 'Nintendo', 1998, 3, 3, 4.99, 49.99, 'Available'),
('Super Mario 64', 'Platformer', 'Nintendo 64', 'Nintendo', 1996, 2, 2, 3.99, 39.99, 'Available'),
('Halo: Combat Evolved', 'FPS', 'Xbox', 'Bungie', 2001, 4, 3, 5.00, 24.99, 'Available'),
('God of War', 'Action', 'PlayStation 2', 'Santa Monica Studio', 2005, 2, 1, 4.50, 29.99, 'Available'),
('Grand Theft Auto: San Andreas', 'Open World', 'PlayStation 2', 'Rockstar Games', 2004, 5, 5, 5.99, 34.99, 'Available');
GO

-- Sample Issued Game
INSERT INTO BorrowIssue (GameID, BorrowerName, BorrowerContact, IssueDate, DueDate, Status)
VALUES (3, 'John Smith', '555-0192', GETDATE(), DATEADD(day, 7, GETDATE()), 'Borrowed');

UPDATE Games SET AvailableQuantity = AvailableQuantity - 1 WHERE GameID = 3;

-- Sample Rented Game (with Customer Phone and Address)
INSERT INTO Rental (GameID, CustomerName, CustomerPhone, CustomerAddress, RentalDate, RentalPrice, Status)
VALUES (4, 'Alice Johnson', '555-0143', '123 Maple Street, Apt 4B', GETDATE(), 4.50, 'Rented');

UPDATE Games SET AvailableQuantity = AvailableQuantity - 1 WHERE GameID = 4;
GO

-- Sample Sold Game (with Customer Phone and Address)
INSERT INTO Sales (GameID, CustomerName, CustomerPhone, CustomerAddress, SaleDate, Quantity, SalePrice, TotalAmount)
VALUES (1, 'David Miller', '555-8821', '742 Evergreen Terrace, Springfield', DATEADD(day, -2, GETDATE()), 1, 49.99, 49.99);
GO

PRINT 'Database GameLibraryDB and all tables created successfully!';
