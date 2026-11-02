Imports System.Data.SqlClient

Public Class GameManagementForm

    Private Sub GameManagementForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            FormatGridFont()
            LoadGamesData()
            ClearFields()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormatGridFont()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        dgvGames.DefaultCellStyle.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular)
        dgvGames.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        dgvGames.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(238, 242, 255)
        dgvGames.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 27, 75)
        dgvGames.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 243, 255)
        dgvGames.EnableHeadersVisualStyles = False
        dgvGames.RowTemplate.Height = 36
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Public Sub LoadGamesData()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            Dim sql As String = "SELECT GameID, GameName, Genre, Platform, Developer, ReleaseYear, Quantity, AvailableQuantity, RentalPrice, SellingPrice, Status FROM Games ORDER BY GameID DESC"
            Dim dt As DataTable = ExecuteQuery(sql)
            dgvGames.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading games: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        txtGameID.Text = ""
        txtGameName.Text = ""
        txtGenre.Text = ""
        txtPlatform.Text = ""
        txtDeveloper.Text = ""
        txtReleaseYear.Text = ""
        txtTotalQty.Text = ""
        txtAvailableQty.Text = ""
        txtRentalPrice.Text = ""
        txtSellingPrice.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnAddGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddGame.Click
        If txtGameName.Text.Trim() = "" Then
            MessageBox.Show("Please enter a game name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtGameName.Focus()
            Exit Sub
        End If

        Dim qty As Integer = 0
        If Not Integer.TryParse(txtTotalQty.Text.Trim(), qty) OrElse qty < 0 Then
            MessageBox.Show("Please enter a valid total quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTotalQty.Focus()
            Exit Sub
        End If

        Dim rentPrice As Decimal = 0
        If txtRentalPrice.Text.Trim() <> "" AndAlso Not Decimal.TryParse(txtRentalPrice.Text.Trim(), rentPrice) Then
            MessageBox.Show("Please enter a valid rental price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRentalPrice.Focus()
            Exit Sub
        End If

        Dim sellPrice As Decimal = 0
        If txtSellingPrice.Text.Trim() <> "" AndAlso Not Decimal.TryParse(txtSellingPrice.Text.Trim(), sellPrice) Then
            MessageBox.Show("Please enter a valid selling price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSellingPrice.Focus()
            Exit Sub
        End If

        Try
            Dim sql As String = "INSERT INTO Games (GameName, Genre, Platform, Developer, ReleaseYear, Quantity, AvailableQuantity, RentalPrice, SellingPrice, Status) " & _
                               "VALUES (@Name, @Genre, @Platform, @Dev, @Year, @Qty, @AvailQty, @RentPrice, @SellPrice, 'Available')"
            Dim params As New List(Of SqlParameter)()
            params.Add(New SqlParameter("@Name", txtGameName.Text.Trim()))
            params.Add(New SqlParameter("@Genre", txtGenre.Text.Trim()))
            params.Add(New SqlParameter("@Platform", txtPlatform.Text.Trim()))
            params.Add(New SqlParameter("@Dev", txtDeveloper.Text.Trim()))
            params.Add(New SqlParameter("@Year", If(txtReleaseYear.Text.Trim() = "", DBNull.Value, txtReleaseYear.Text.Trim())))
            params.Add(New SqlParameter("@Qty", qty))
            params.Add(New SqlParameter("@AvailQty", qty))
            params.Add(New SqlParameter("@RentPrice", rentPrice))
            params.Add(New SqlParameter("@SellPrice", sellPrice))

            ExecuteNonQuery(sql, params)
            MessageBox.Show("Game added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadGamesData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error adding game: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvGames_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGames.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvGames.Rows(e.RowIndex)
            txtGameID.Text = row.Cells("GameID").Value.ToString()
            txtGameName.Text = row.Cells("GameName").Value.ToString()
            txtGenre.Text = row.Cells("Genre").Value.ToString()
            txtPlatform.Text = row.Cells("Platform").Value.ToString()
            txtDeveloper.Text = row.Cells("Developer").Value.ToString()
            txtReleaseYear.Text = row.Cells("ReleaseYear").Value.ToString()
            txtTotalQty.Text = row.Cells("Quantity").Value.ToString()
            txtAvailableQty.Text = row.Cells("AvailableQuantity").Value.ToString()
            txtRentalPrice.Text = row.Cells("RentalPrice").Value.ToString()
            If row.Cells("SellingPrice") IsNot Nothing AndAlso row.Cells("SellingPrice").Value IsNot Nothing Then
                txtSellingPrice.Text = row.Cells("SellingPrice").Value.ToString()
            Else
                txtSellingPrice.Text = "0.00"
            End If
        End If
    End Sub

    Private Sub btnUpdateGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateGame.Click
        If txtGameID.Text = "" Then
            MessageBox.Show("Please select a game from the grid to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim qty As Integer = 0
        If Not Integer.TryParse(txtTotalQty.Text.Trim(), qty) OrElse qty < 0 Then
            MessageBox.Show("Please enter a valid total quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim availQty As Integer = 0
        If Not Integer.TryParse(txtAvailableQty.Text.Trim(), availQty) OrElse availQty < 0 Then
            MessageBox.Show("Please enter a valid available quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim rentPrice As Decimal = 0
        If txtRentalPrice.Text.Trim() <> "" AndAlso Not Decimal.TryParse(txtRentalPrice.Text.Trim(), rentPrice) Then
            MessageBox.Show("Please enter a valid rental price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim sellPrice As Decimal = 0
        If txtSellingPrice.Text.Trim() <> "" AndAlso Not Decimal.TryParse(txtSellingPrice.Text.Trim(), sellPrice) Then
            MessageBox.Show("Please enter a valid selling price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim sql As String = "UPDATE Games SET GameName = @Name, Genre = @Genre, Platform = @Platform, Developer = @Dev, " & _
                               "ReleaseYear = @Year, Quantity = @Qty, AvailableQuantity = @AvailQty, RentalPrice = @RentPrice, SellingPrice = @SellPrice " & _
                               "WHERE GameID = @GID"
            Dim params As New List(Of SqlParameter)()
            params.Add(New SqlParameter("@Name", txtGameName.Text.Trim()))
            params.Add(New SqlParameter("@Genre", txtGenre.Text.Trim()))
            params.Add(New SqlParameter("@Platform", txtPlatform.Text.Trim()))
            params.Add(New SqlParameter("@Dev", txtDeveloper.Text.Trim()))
            params.Add(New SqlParameter("@Year", If(txtReleaseYear.Text.Trim() = "", DBNull.Value, txtReleaseYear.Text.Trim())))
            params.Add(New SqlParameter("@Qty", qty))
            params.Add(New SqlParameter("@AvailQty", availQty))
            params.Add(New SqlParameter("@RentPrice", rentPrice))
            params.Add(New SqlParameter("@SellPrice", sellPrice))
            params.Add(New SqlParameter("@GID", Convert.ToInt32(txtGameID.Text)))

            ExecuteNonQuery(sql, params)
            MessageBox.Show("Game updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadGamesData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating game: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteGame.Click
        If txtGameID.Text = "" Then
            MessageBox.Show("Please select a game from the grid to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this game?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim sql As String = "DELETE FROM Games WHERE GameID = @GID"
                Dim params As New List(Of SqlParameter)()
                params.Add(New SqlParameter("@GID", Convert.ToInt32(txtGameID.Text)))

                ExecuteNonQuery(sql, params)
                MessageBox.Show("Game deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadGamesData()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error deleting game: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadGamesData()
    End Sub

End Class
