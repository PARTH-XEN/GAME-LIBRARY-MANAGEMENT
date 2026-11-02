Imports System.Data.SqlClient

Public Class SearchGamesForm

    Private Sub SearchGamesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            FormatGridFont()
            cmbSearchBy.SelectedIndex = 0
            PerformSearch()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormatGridFont()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        dgvSearchResults.DefaultCellStyle.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular)
        dgvSearchResults.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        dgvSearchResults.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(238, 242, 255)
        dgvSearchResults.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 27, 75)
        dgvSearchResults.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 243, 255)
        dgvSearchResults.EnableHeadersVisualStyles = False
        dgvSearchResults.RowTemplate.Height = 36
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Public Sub PerformSearch()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            Dim sql As String = "SELECT GameID, GameName, Genre, Platform, Developer, ReleaseYear, AvailableQuantity, RentalPrice, SellingPrice, Status FROM Games "
            Dim params As New List(Of SqlParameter)()

            Dim searchTerm As String = txtSearch.Text.Trim()

            If searchTerm <> "" Then
                Select Case cmbSearchBy.Text
                    Case "Game Name"
                        sql &= "WHERE GameName LIKE @kw "
                    Case "Genre"
                        sql &= "WHERE Genre LIKE @kw "
                    Case "Platform"
                        sql &= "WHERE Platform LIKE @kw "
                    Case Else
                        sql &= "WHERE GameName LIKE @kw OR Genre LIKE @kw OR Platform LIKE @kw "
                End Select
                params.Add(New SqlParameter("@kw", "%" & searchTerm & "%"))
            End If

            sql &= "ORDER BY GameName ASC"

            Dim dt As DataTable = ExecuteQuery(sql, params)
            dgvSearchResults.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error performing search: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        PerformSearch()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
        cmbSearchBy.SelectedIndex = 0
        PerformSearch()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        PerformSearch()
    End Sub

End Class
