Imports System.Data.SqlClient

Public Class DashboardForm

    Private Sub DashboardForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        FormatGridFont()
        LoadDashboardCounts()
        LoadRecentActivity()
    End Sub

    Private Sub DashboardForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        LoadDashboardCounts()
        LoadRecentActivity()
    End Sub

    Private Sub FormatGridFont()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        dgvRecentActivity.DefaultCellStyle.Font = New Font("Segoe UI", 10.5!, FontStyle.Regular)
        dgvRecentActivity.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.5!, FontStyle.Bold)
        dgvRecentActivity.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(238, 242, 255)
        dgvRecentActivity.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 27, 75)
        dgvRecentActivity.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 243, 255)
        dgvRecentActivity.EnableHeadersVisualStyles = False
        dgvRecentActivity.RowTemplate.Height = 34
    End Sub

    Public Sub LoadDashboardCounts()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            ' 1. Total Distinct Games
            Dim sqlTotalGames As String = "SELECT COUNT(*) FROM Games"
            Dim totalGames As Object = ExecuteScalar(sqlTotalGames)
            lblTotalGamesCount.Text = If(totalGames IsNot Nothing, totalGames.ToString(), "0")

            ' 2. Total Copies Quantity
            Dim sqlTotalCopies As String = "SELECT ISNULL(SUM(Quantity), 0) FROM Games"
            Dim totalCopies As Object = ExecuteScalar(sqlTotalCopies)
            lblTotalCopiesCount.Text = If(totalCopies IsNot Nothing, totalCopies.ToString(), "0")

            ' 3. Total Available Copies
            Dim sqlAvailableCopies As String = "SELECT ISNULL(SUM(AvailableQuantity), 0) FROM Games"
            Dim availCopies As Object = ExecuteScalar(sqlAvailableCopies)
            lblAvailableGamesCount.Text = If(availCopies IsNot Nothing, availCopies.ToString(), "0")

            ' 4. Total Currently Borrowed
            Dim sqlBorrowed As String = "SELECT COUNT(*) FROM BorrowIssue WHERE Status = 'Borrowed'"
            Dim totalBorrowed As Object = ExecuteScalar(sqlBorrowed)
            lblBorrowedGamesCount.Text = If(totalBorrowed IsNot Nothing, totalBorrowed.ToString(), "0")

            ' 5. Total Active Rentals
            Dim sqlRented As String = "SELECT COUNT(*) FROM Rental WHERE Status = 'Rented'"
            Dim totalRented As Object = ExecuteScalar(sqlRented)
            lblRentedGamesCount.Text = If(totalRented IsNot Nothing, totalRented.ToString(), "0")

            ' 6. Total Sold Games
            Dim sqlSold As String = "SELECT ISNULL(SUM(Quantity), 0) FROM Sales"
            Dim totalSold As Object = ExecuteScalar(sqlSold)
            lblSoldGamesCount.Text = If(totalSold IsNot Nothing, totalSold.ToString(), "0")

        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadRecentActivity()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            Dim sql As String = "SELECT TOP 10 'Borrow/Issue' AS [Transaction Type], g.GameName AS [Game Title], bi.BorrowerName AS [Person/Customer], bi.IssueDate AS [Date], bi.Status FROM BorrowIssue bi INNER JOIN Games g ON bi.GameID = g.GameID " & _
                               "UNION ALL " & _
                               "SELECT TOP 10 'Rental' AS [Transaction Type], g.GameName AS [Game Title], r.CustomerName AS [Person/Customer], r.RentalDate AS [Date], r.Status FROM Rental r INNER JOIN Games g ON r.GameID = g.GameID " & _
                               "UNION ALL " & _
                               "SELECT TOP 10 'Sale' AS [Transaction Type], g.GameName AS [Game Title], s.CustomerName AS [Person/Customer], s.SaleDate AS [Date], 'Sold' AS Status FROM Sales s INNER JOIN Games g ON s.GameID = g.GameID " & _
                               "ORDER BY [Date] DESC"
            Dim dt As DataTable = ExecuteQuery(sql)
            dgvRecentActivity.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnRefreshDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshDashboard.Click
        LoadDashboardCounts()
        LoadRecentActivity()
    End Sub

    ' Navigation Handlers
    Private Sub btnGameManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGameManagement.Click
        Dim frm As New GameManagementForm()
        frm.ShowDialog()
        LoadDashboardCounts()
        LoadRecentActivity()
    End Sub

    Private Sub btnBorrowIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrowIssue.Click
        Dim frm As New BorrowIssueForm()
        frm.ShowDialog()
        LoadDashboardCounts()
        LoadRecentActivity()
    End Sub

    Private Sub btnBorrowHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrowHistory.Click
        Dim frm As New BorrowIssueHistoryForm()
        frm.ShowDialog()
    End Sub

    Private Sub btnSearchGames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchGames.Click
        Dim frm As New SearchGamesForm()
        frm.ShowDialog()
    End Sub

    Private Sub btnRentals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentals.Click
        Dim frm As New RentalForm()
        frm.ShowDialog()
        LoadDashboardCounts()
        LoadRecentActivity()
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Dim frm As New ReportsForm()
        frm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            Dim login As New LoginForm()
            login.Show()
        End If
    End Sub

End Class
