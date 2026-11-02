Imports System.Data.SqlClient

Public Class BorrowIssueHistoryForm

    Private Sub BorrowIssueHistoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            FormatGridFont()
            cmbFilterBy.SelectedIndex = 0
            LoadHistoryData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormatGridFont()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        dgvHistory.DefaultCellStyle.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular)
        dgvHistory.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(238, 242, 255)
        dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 27, 75)
        dgvHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 243, 255)
        dgvHistory.EnableHeadersVisualStyles = False
        dgvHistory.RowTemplate.Height = 36
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Public Sub LoadHistoryData(Optional ByVal keyword As String = "", Optional ByVal filterBy As String = "")
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            Dim sql As String = "SELECT bi.IssueID, g.GameName, bi.BorrowerName, bi.BorrowerContact, bi.IssueDate, bi.DueDate, bi.ReturnDate, bi.Status " & _
                               "FROM BorrowIssue bi " & _
                               "INNER JOIN Games g ON bi.GameID = g.GameID "

            Dim params As New List(Of SqlParameter)()

            If keyword.Trim() <> "" Then
                Select Case filterBy
                    Case "Borrower Name"
                        sql &= "WHERE bi.BorrowerName LIKE @kw "
                    Case "Game Name"
                        sql &= "WHERE g.GameName LIKE @kw "
                    Case "Status"
                        sql &= "WHERE bi.Status LIKE @kw "
                    Case Else
                        sql &= "WHERE bi.BorrowerName LIKE @kw OR g.GameName LIKE @kw OR bi.Status LIKE @kw "
                End Select
                params.Add(New SqlParameter("@kw", "%" & keyword.Trim() & "%"))
            End If

            sql &= "ORDER BY bi.IssueID DESC"

            Dim dt As DataTable = ExecuteQuery(sql, params)
            dgvHistory.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading borrow history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadHistoryData(txtSearch.Text, cmbFilterBy.Text)
    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        txtSearch.Text = ""
        LoadHistoryData()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
        cmbFilterBy.SelectedIndex = 0
        LoadHistoryData()
    End Sub

End Class
