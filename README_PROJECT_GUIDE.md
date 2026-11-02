# GAME LIBRARY MANAGEMENT SYSTEM
**Visual Basic 2010 (.NET Framework 4.0) College Project**

---

## PROJECT OVERVIEW
The **Game Library Management System** is a Windows Forms application built using **Microsoft Visual Basic 2010** and **SQL Server (Database Version 655 / SQL Server 2008 / 2008 R2)**. It provides a simple, clean, and intuitive interface for managing video game titles, issue/borrow transactions, borrowing history, title searching, rentals, and generating summary reports.

---

## SYSTEM ARCHITECTURE & EXPLICIT 8 FORMS
The application consists of **EXACTLY 8 FORMS** and 1 shared database access module:

1. **LoginForm** (`LoginForm.vb`): Handles user login authentication against the database `Users` table (`admin` / `admin123`).
2. **DashboardForm** (`DashboardForm.vb`): Main summary panel displaying live library metrics (Total Games, Copies, Available, Borrowed, Rented, and Sold Games) and navigation buttons to all module forms.
3. **GameManagementForm** (`GameManagementForm.vb`): Allows adding, updating, deleting, clearing, and viewing game catalog items (including Rental Price and Selling Price) in a DataGridView.
4. **BorrowIssueForm** (`BorrowIssueForm.vb`): Manages issuing games to borrowers and returning borrowed games, updating available quantities automatically.
5. **BorrowIssueHistoryForm** (`BorrowIssueHistoryForm.vb`): Displays full borrowing logs with filters by Borrower Name, Game Name, or Status.
6. **SearchGamesForm** (`SearchGamesForm.vb`): Dedicated form for searching game titles using SQL `LIKE` queries by Game Name, Genre, or Platform (displays stock, rental and sell prices).
7. **RentalForm** (`RentalForm.vb`): Manages commercial game rentals AND outright game sales with customer details (Customer Name, Phone Number, Address), returns, and filtering.
8. **ReportsForm** (`ReportsForm.vb`): Displays tabular reports including Available Games, Rented Games, Sold Games, and the Final Comprehensive Report showing all three categories with stock and revenue figures.

*Shared Database Module:* `DatabaseModule.vb` - Contains ADO.NET methods (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`, `ExecuteQuery`, `ExecuteNonQuery`, `ExecuteScalar`) connecting to the server-side database.

---

## DATABASE SETUP (SQL SERVER / DATABASE VERSION 655)

### Database Version 655 Explanation
- **Database Version 655** refers to the internal engine format version of **SQL Server 2008 / SQL Server 2008 R2** (MSSQLSERVER 10.0 / 10.50).
- Visual Studio 2010 natively bundles and integrates with SQL Server 2008 / 2008 R2.

### Step-by-Step Database Installation & Table Setup

1. **Open SQL Server Management Studio (SSMS)** or SQL Server Express Command Line (`sqlcmd`).
2. Connect to your local SQL Server instance (e.g. `.\SQLEXPRESS` or `localhost`).
3. Open a **New Query** window.
4. Open the included [`DatabaseSetup.sql`](file:///C:/Users/dell/OneDrive/Documents/Visual%20Studio%202010/Projects/GLM%20final/DatabaseSetup.sql) file and execute it, or run the following SQL statements:

```sql
-- Step A: Create Application Database
CREATE DATABASE GameLibraryDB;
GO

USE GameLibraryDB;
GO

-- Step B: Create Users Table
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(50) NOT NULL
);
GO

-- Step C: Create Games Table
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

-- Step D: Create BorrowIssue Table
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

-- Step E: Create Rental Table
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

-- Step F: Create Sales Table
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

-- Step G: Insert Default Admin User
INSERT INTO Users (Username, Password) VALUES ('admin', 'admin123');
GO
```

---

## CONNECTION STRING SETUP & CONFIGURATION

In [`DatabaseModule.vb`](file:///C:/Users/dell/OneDrive/Documents/Visual%20Studio%202010/Projects/GLM%20final/DatabaseModule.vb), locate line 5:

```vb
Public connStr As String = "Data Source=.\SQLEXPRESS;Initial Catalog=GameLibraryDB;Integrated Security=True;"
```

### How to Modify for Your Computer:
- If using **SQL Server Express**: Keep `Data Source=.\SQLEXPRESS`
- If using **Local Server / Full SQL Server**: Change to `Data Source=localhost` or `Data Source=.`
- If using **SQL Server Authentication with Password**: Change to:
  `"Data Source=localhost;Initial Catalog=GameLibraryDB;User ID=sa;Password=yourpassword;"`

---

## VIVA QUESTION & ANSWER GUIDE

1. **Q: Why did you use ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`)?**
   - **A:** ADO.NET is the fundamental data access technology standard in VB.NET. It allows direct, efficient execution of SQL queries against SQL Server without complex runtime overhead.

2. **Q: How does the Borrow and Return logic manage game availability?**
   - **A:** When a game is issued or rented, the application checks if `AvailableQuantity > 0`. Upon confirmation, it executes an `INSERT` command into `BorrowIssue` / `Rental` and decreases `AvailableQuantity` by 1 in `Games`. Upon return, it sets `Status='Returned'` and increases `AvailableQuantity` by 1.

3. **Q: How is SQL Injection prevented in your project?**
   - **A:** All queries use parameterized SQL commands (`SqlParameter`), ensuring user input in TextBoxes is treated strictly as data parameters rather than executable SQL code.

4. **Q: What happens if invalid data is entered (e.g. text in Quantity)?**
   - **A:** Simple validation rules using `If...Then` and parsing methods like `Integer.TryParse()` display friendly `MessageBox` alerts and prevent invalid database operations.

---

## COMMON ERRORS & STUDENT FIXES

1. **Error: "Cannot open database 'GameLibraryDB' requested by the login."**
   - **Fix:** You haven't created the `GameLibraryDB` database in SQL Server yet. Run `DatabaseSetup.sql` in SSMS first.

2. **Error: "A network-related or instance-specific error occurred while establishing a connection to SQL Server."**
   - **Fix:** SQL Server service is not running, or your `Data Source` in `DatabaseModule.vb` is incorrect. Open SQL Server Configuration Manager and ensure SQL Server service is Started, and check your server instance name.

3. **Error: "Invalid Username or Password" during login.**
   - **Fix:** Ensure default account `admin` / `admin123` exists in `Users` table by executing step F of `DatabaseSetup.sql`.
