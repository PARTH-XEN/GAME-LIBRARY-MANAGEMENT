Imports System.Data.SqlClient

Public Class ReportsForm

    Private Sub ReportsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            FormatGridFont()
            LoadFinalSummaryReport() ' Load the final comprehensive report by default!
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormatGridFont()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        dgvReport.DefaultCellStyle.Font = New Font("Segoe UI", 10.5!, FontStyle.Regular)
        dgvReport.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.5!, FontStyle.Bold)
        dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(238, 242, 255)
        dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 27, 75)
        dgvReport.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 243, 255)
        dgvReport.EnableHeadersVisualStyles = False
        dgvReport.RowTemplate.Height = 36
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub ResetReportButtonColors()
        Dim defaultBg As Color = Color.FromArgb(237, 233, 254)
        Dim defaultFg As Color = Color.FromArgb(49, 46, 129)
        
        btnGameListReport.BackColor = defaultBg
        btnGameListReport.ForeColor = defaultFg
        btnBorrowedReport.BackColor = defaultBg
        btnBorrowedReport.ForeColor = defaultFg
        btnReturnedReport.BackColor = defaultBg
        btnReturnedReport.ForeColor = defaultFg
        btnRentalReport.BackColor = defaultBg
        btnRentalReport.ForeColor = defaultFg
        btnAvailableReport.BackColor = defaultBg
        btnAvailableReport.ForeColor = defaultFg
        btnSoldReport.BackColor = defaultBg
        btnSoldReport.ForeColor = defaultFg
        btnFinalReport.BackColor = defaultBg
        btnFinalReport.ForeColor = defaultFg
    End Sub

    Private Sub SetActiveReportButton(ByVal btn As Button)
        ResetReportButtonColors()
        btn.BackColor = Color.FromArgb(49, 46, 129)
        btn.ForeColor = Color.White
    End Sub

    ' 1. Final Report: Available, Rented and Sold Games
    Public Sub LoadFinalSummaryReport()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            SetActiveReportButton(btnFinalReport)
            lblReportTitle.Text = "Report Data: Final Comprehensive Report - Available Copies, Rented Copies & Sold Copies"
            
            Dim sql As String = "SELECT g.GameID AS [Game ID], " & _
                                "g.GameName AS [Game Title], " & _
                                "g.Platform AS [Platform], " & _
                                "g.Quantity AS [Total Stock], " & _
                                "g.AvailableQuantity AS [Available Copies], " & _
                                "(SELECT COUNT(*) FROM Rental r WHERE r.GameID = g.GameID AND r.Status = 'Rented') AS [Active Rentals], " & _
                                "(SELECT ISNULL(SUM(s.Quantity), 0) FROM Sales s WHERE s.GameID = g.GameID) AS [Sold Copies], " & _
                                "g.RentalPrice AS [Rent Price ($)], " & _
                                "g.SellingPrice AS [Sale Price ($)], " & _
                                "(SELECT ISNULL(SUM(s.TotalAmount), 0) FROM Sales s WHERE s.GameID = g.GameID) AS [Total Sales Rev ($)], " & _
                                "(SELECT ISNULL(SUM(r.RentalPrice), 0) FROM Rental r WHERE r.GameID = g.GameID) AS [Total Rental Rev ($)], " & _
                                "g.Status AS [Status] " & _
                                "FROM Games g " & _
                                "ORDER BY g.GameName"

            Dim dt As DataTable = ExecuteQuery(sql)
            dgvReport.DataSource = dt

            ' Calculate overall totals
            Dim totalAvail As Integer = 0
            Dim totalRented As Integer = 0
            Dim totalSold As Integer = 0
            Dim totalSalesRevenue As Decimal = 0
            Dim totalRentalRevenue As Decimal = 0

            For Each row As DataRow In dt.Rows
                totalAvail += Convert.ToInt32(row("Available Copies"))
                totalRented += Convert.ToInt32(row("Active Rentals"))
                totalSold += Convert.ToInt32(row("Sold Copies"))
                totalSalesRevenue += Convert.ToDecimal(row("Total Sales Rev ($)"))
                totalRentalRevenue += Convert.ToDecimal(row("Total Rental Rev ($)"))
            Next

            lblRecordCount.Text = "Titles: " & dt.Rows.Count & " | Total Available: " & totalAvail & _
                                  " | Active Rented: " & totalRented & " | Total Sold: " & totalSold & _
                                  " | Sales Revenue: $" & totalSalesRevenue.ToString("0.00") & _
                                  " | Rental Revenue: $" & totalRentalRevenue.ToString("0.00")
        Catch ex As Exception
            MessageBox.Show("Error loading final report: " & ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 2. All Available Games
    Public Sub LoadAvailableReport()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            SetActiveReportButton(btnAvailableReport)
            lblReportTitle.Text = "Report Data: All Available Games Currently In Stock"
            
            Dim sql As String = "SELECT GameID AS [ID], " & _
                                "GameName AS [Game Title], " & _
                                "Genre AS [Genre], " & _
                                "Platform AS [Platform], " & _
                                "Developer AS [Developer], " & _
                                "Quantity AS [Total Stock], " & _
                                "AvailableQuantity AS [Available Copies], " & _
                                "RentalPrice AS [Rent Price ($)], " & _
                                "SellingPrice AS [Sale Price ($)], " & _
                                "Status AS [Status] " & _
                                "FROM Games " & _
                                "WHERE AvailableQuantity > 0 " & _
                                "ORDER BY GameName"

            Dim dt As DataTable = ExecuteQuery(sql)
            dgvReport.DataSource = dt

            Dim totalAvailableCopies As Integer = 0
            For Each row As DataRow In dt.Rows
                totalAvailableCopies += Convert.ToInt32(row("Available Copies"))
            Next

            lblRecordCount.Text = "Available Titles: " & dt.Rows.Count & " | Total Available Units: " & totalAvailableCopies
        Catch ex As Exception
            MessageBox.Show("Error loading available games report: " & ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 3. Rented Games Report (Customer Details: Name, Phone, Address)
    Public Sub LoadRentalReport()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            SetActiveReportButton(btnRentalReport)
            lblReportTitle.Text = "Report Data: Commercial Game Rentals (Customer Details & Rental Status)"
            
            Dim sql As String = "SELECT r.RentalID AS [Rental ID], " & _
                                "g.GameName AS [Game Title], " & _
                                "r.CustomerName AS [Customer Name], " & _
                                "ISNULL(r.CustomerPhone, '') AS [Phone Number], " & _
                                "ISNULL(r.CustomerAddress, '') AS [Customer Address], " & _
                                "r.RentalDate AS [Rental Date], " & _
                                "r.ReturnDate AS [Return Date], " & _
                                "r.RentalPrice AS [Rental Fee ($)], " & _
                                "r.Status AS [Status] " & _
                                "FROM Rental r " & _
                                "INNER JOIN Games g ON r.GameID = g.GameID " & _
                                "ORDER BY r.RentalID DESC"

            Dim dt As DataTable = ExecuteQuery(sql)
            dgvReport.DataSource = dt

            Dim activeRentals As Integer = 0
            Dim totalRevenue As Decimal = 0
            For Each row As DataRow In dt.Rows
                If row("Status").ToString() = "Rented" Then
                    activeRentals += 1
                End If
                totalRevenue += Convert.ToDecimal(row("Rental Fee ($)"))
            Next

            lblRecordCount.Text = "Total Rentals: " & dt.Rows.Count & " | Active Rentals: " & activeRentals & " | Total Rental Fees: $" & totalRevenue.ToString("0.00")
        Catch ex As Exception
            MessageBox.Show("Error loading rental report: " & ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 4. Sold Games Report (Customer Details: Name, Phone, Address)
    Public Sub LoadSoldReport()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            SetActiveReportButton(btnSoldReport)
            lblReportTitle.Text = "Report Data: Sold Games List (Customer Details, Sale Date & Revenue)"
            
            Dim sql As String = "SELECT s.SaleID AS [Sale ID], " & _
                                "g.GameName AS [Game Title], " & _
                                "s.CustomerName AS [Customer Name], " & _
                                "s.CustomerPhone AS [Phone Number], " & _
                                "s.CustomerAddress AS [Customer Address], " & _
                                "s.SaleDate AS [Sale Date], " & _
                                "s.Quantity AS [Qty Sold], " & _
                                "s.SalePrice AS [Unit Price ($)], " & _
                                "s.TotalAmount AS [Total Revenue ($)] " & _
                                "FROM Sales s " & _
                                "INNER JOIN Games g ON s.GameID = g.GameID " & _
                                "ORDER BY s.SaleID DESC"

            Dim dt As DataTable = ExecuteQuery(sql)
            dgvReport.DataSource = dt

            Dim totalSoldUnits As Integer = 0
            Dim totalSalesRevenue As Decimal = 0
            For Each row As DataRow In dt.Rows
                totalSoldUnits += Convert.ToInt32(row("Qty Sold"))
                totalSalesRevenue += Convert.ToDecimal(row("Total Revenue ($)"))
            Next

            lblRecordCount.Text = "Total Sales Transactions: " & dt.Rows.Count & " | Total Units Sold: " & totalSoldUnits & " | Total Sales Revenue: $" & totalSalesRevenue.ToString("0.00")
        Catch ex As Exception
            MessageBox.Show("Error loading sold games report: " & ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 5. Full Inventory Catalog
    Private Sub LoadGameListReport()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            SetActiveReportButton(btnGameListReport)
            lblReportTitle.Text = "Report Data: Complete Games Inventory Catalog"
            Dim sql As String = "SELECT GameID AS [ID], GameName AS [Game Title], Genre, Platform, Developer, ReleaseYear AS [Year], Quantity AS [Total Qty], AvailableQuantity AS [Avail Qty], RentalPrice AS [Rent ($)], SellingPrice AS [Sell ($)], Status FROM Games ORDER BY GameName"
            Dim dt As DataTable = ExecuteQuery(sql)
            dgvReport.DataSource = dt
            lblRecordCount.Text = "Total Games in Catalog: " & dt.Rows.Count
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 6. Currently Borrowed / Issued
    Private Sub LoadBorrowedReport()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            SetActiveReportButton(btnBorrowedReport)
            lblReportTitle.Text = "Report Data: Currently Borrowed / Issued Games (Active Library Loans)"
            Dim sql As String = "SELECT bi.IssueID AS [Issue ID], g.GameName AS [Game Title], bi.BorrowerName AS [Borrower], bi.BorrowerContact AS [Contact No], bi.IssueDate AS [Issue Date], bi.DueDate AS [Due Date], bi.Status FROM BorrowIssue bi INNER JOIN Games g ON bi.GameID = g.GameID WHERE bi.Status = 'Borrowed' ORDER BY bi.IssueDate DESC"
            Dim dt As DataTable = ExecuteQuery(sql)
            dgvReport.DataSource = dt
            lblRecordCount.Text = "Currently Borrowed Items: " & dt.Rows.Count
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 7. Returned Borrowing History
    Private Sub LoadReturnedReport()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            SetActiveReportButton(btnReturnedReport)
            lblReportTitle.Text = "Report Data: Returned Borrowed Games History Log"
            Dim sql As String = "SELECT bi.IssueID AS [Issue ID], g.GameName AS [Game Title], bi.BorrowerName AS [Borrower], bi.BorrowerContact AS [Contact No], bi.IssueDate AS [Issue Date], bi.ReturnDate AS [Returned Date], bi.Status FROM BorrowIssue bi INNER JOIN Games g ON bi.GameID = g.GameID WHERE bi.Status = 'Returned' ORDER BY bi.ReturnDate DESC"
            Dim dt As DataTable = ExecuteQuery(sql)
            dgvReport.DataSource = dt
            lblRecordCount.Text = "Total Returned Records: " & dt.Rows.Count
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button Click Handlers
    Private Sub btnFinalReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalReport.Click
        LoadFinalSummaryReport()
    End Sub

    Private Sub btnAvailableReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvailableReport.Click
        LoadAvailableReport()
    End Sub

    Private Sub btnRentalReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentalReport.Click
        LoadRentalReport()
    End Sub

    Private Sub btnSoldReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSoldReport.Click
        LoadSoldReport()
    End Sub

    Private Sub btnGameListReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGameListReport.Click
        LoadGameListReport()
    End Sub

    Private Sub btnBorrowedReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrowedReport.Click
        LoadBorrowedReport()
    End Sub

    Private Sub btnReturnedReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturnedReport.Click
        LoadReturnedReport()
    End Sub

End Class
