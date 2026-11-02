Imports System.Data.SqlClient

Public Class RentalForm

    Private Sub RentalForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            FormatGridFont()
            cmbTransType.SelectedIndex = 0 ' Default to "Rent"
            cmbFilterView.SelectedIndex = 0 ' Default to "All Records"
            LoadGamesComboBox()
            LoadRentalsData()
            ClearFields()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormatGridFont()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        dgvRentals.DefaultCellStyle.Font = New Font("Segoe UI", 10.5!, FontStyle.Regular)
        dgvRentals.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.5!, FontStyle.Bold)
        dgvRentals.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(238, 242, 255)
        dgvRentals.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 27, 75)
        dgvRentals.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 243, 255)
        dgvRentals.EnableHeadersVisualStyles = False
        dgvRentals.RowTemplate.Height = 36
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub LoadGamesComboBox()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            Dim sql As String = "SELECT GameID, GameName + ' (Rent: $' + CAST(RentalPrice AS VARCHAR) + ' | Sell: $' + CAST(SellingPrice AS VARCHAR) + ' | Avail: ' + CAST(AvailableQuantity AS VARCHAR) + ')' AS DisplayName FROM Games ORDER BY GameName"
            Dim dt As DataTable = ExecuteQuery(sql)
            cmbGames.DataSource = dt
            cmbGames.DisplayMember = "DisplayName"
            cmbGames.ValueMember = "GameID"
            cmbGames.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error loading games: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadRentalsData()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            Dim filter As String = If(cmbFilterView.SelectedItem IsNot Nothing, cmbFilterView.SelectedItem.ToString(), "All Records")
            Dim sql As String = ""

            If filter = "Rentals Only" Then
                sql = "SELECT r.RentalID AS [ID], 'Rental' AS [Type], g.GameName AS [Game Title], " & _
                      "r.CustomerName AS [Customer], ISNULL(r.CustomerPhone, '') AS [Phone], " & _
                      "ISNULL(r.CustomerAddress, '') AS [Address], r.RentalDate AS [Trans Date], " & _
                      "r.ReturnDate AS [Return Date], r.RentalPrice AS [Price ($)], r.Status " & _
                      "FROM Rental r " & _
                      "INNER JOIN Games g ON r.GameID = g.GameID " & _
                      "ORDER BY r.RentalID DESC"
            ElseIf filter = "Sales Only" Then
                sql = "SELECT s.SaleID AS [ID], 'Sale' AS [Type], g.GameName AS [Game Title], " & _
                      "s.CustomerName AS [Customer], s.CustomerPhone AS [Phone], " & _
                      "s.CustomerAddress AS [Address], s.SaleDate AS [Trans Date], " & _
                      "NULL AS [Return Date], s.SalePrice AS [Price ($)], 'Sold' AS [Status] " & _
                      "FROM Sales s " & _
                      "INNER JOIN Games g ON s.GameID = g.GameID " & _
                      "ORDER BY s.SaleID DESC"
            Else
                sql = "SELECT r.RentalID AS [ID], 'Rental' AS [Type], g.GameName AS [Game Title], " & _
                      "r.CustomerName AS [Customer], ISNULL(r.CustomerPhone, '') AS [Phone], " & _
                      "ISNULL(r.CustomerAddress, '') AS [Address], r.RentalDate AS [Trans Date], " & _
                      "r.ReturnDate AS [Return Date], r.RentalPrice AS [Price ($)], r.Status " & _
                      "FROM Rental r " & _
                      "INNER JOIN Games g ON r.GameID = g.GameID " & _
                      "UNION ALL " & _
                      "SELECT s.SaleID AS [ID], 'Sale' AS [Type], g.GameName AS [Game Title], " & _
                      "s.CustomerName AS [Customer], s.CustomerPhone AS [Phone], " & _
                      "s.CustomerAddress AS [Address], s.SaleDate AS [Trans Date], " & _
                      "NULL AS [Return Date], s.SalePrice AS [Price ($)], 'Sold' AS [Status] " & _
                      "FROM Sales s " & _
                      "INNER JOIN Games g ON s.GameID = g.GameID " & _
                      "ORDER BY [Trans Date] DESC"
            End If

            Dim dt As DataTable = ExecuteQuery(sql)
            dgvRentals.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        txtRentalID.Text = ""
        cmbGames.SelectedIndex = -1
        txtCustomerName.Text = ""
        txtCustomerPhone.Text = ""
        txtCustomerAddress.Text = ""
        dtpRentalDate.Value = DateTime.Now
        dtpReturnDate.Value = DateTime.Now.AddDays(3)
        txtRentalPrice.Text = "0.00"
        cmbTransType.SelectedIndex = 0
    End Sub

    Private Sub cmbTransType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTransType.SelectedIndexChanged
        UpdatePriceForSelectedGame()
        If cmbTransType.SelectedItem IsNot Nothing AndAlso cmbTransType.SelectedItem.ToString() = "Sell" Then
            dtpReturnDate.Enabled = False
            lblRentalPrice.Text = "Sell Price ($):"
        Else
            dtpReturnDate.Enabled = True
            lblRentalPrice.Text = "Rent Price ($):"
        End If
    End Sub

    Private Sub cmbGames_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGames.SelectedIndexChanged
        UpdatePriceForSelectedGame()
    End Sub

    Private Sub UpdatePriceForSelectedGame()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        If cmbGames.SelectedValue IsNot Nothing AndAlso TypeOf cmbGames.SelectedValue Is Integer Then
            Try
                Dim gameId As Integer = Convert.ToInt32(cmbGames.SelectedValue)
                Dim isSale As Boolean = (cmbTransType.SelectedItem IsNot Nothing AndAlso cmbTransType.SelectedItem.ToString() = "Sell")
                Dim colName As String = If(isSale, "SellingPrice", "RentalPrice")
                Dim sql As String = "SELECT " & colName & " FROM Games WHERE GameID = @GID"
                Dim params As New List(Of SqlParameter)()
                params.Add(New SqlParameter("@GID", gameId))
                Dim price As Object = ExecuteScalar(sql, params)
                If price IsNot Nothing Then
                    txtRentalPrice.Text = Convert.ToDecimal(price).ToString("0.00")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub cmbFilterView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFilterView.SelectedIndexChanged
        LoadRentalsData()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' Process Rental
    Private Sub btnRentGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentGame.Click
        If cmbGames.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a game to rent.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtCustomerName.Text.Trim() = "" Then
            MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerName.Focus()
            Exit Sub
        End If

        If txtCustomerPhone.Text.Trim() = "" Then
            MessageBox.Show("Please enter customer phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerPhone.Focus()
            Exit Sub
        End If

        If txtCustomerAddress.Text.Trim() = "" Then
            MessageBox.Show("Please enter customer address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerAddress.Focus()
            Exit Sub
        End If

        Dim rentPrice As Decimal = 0
        If Not Decimal.TryParse(txtRentalPrice.Text.Trim(), rentPrice) OrElse rentPrice < 0 Then
            MessageBox.Show("Please enter a valid numeric rental price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRentalPrice.Focus()
            Exit Sub
        End If

        Dim gameId As Integer = Convert.ToInt32(cmbGames.SelectedValue)

        Try
            Dim checkSql As String = "SELECT AvailableQuantity FROM Games WHERE GameID = @GID"
            Dim checkParams As New List(Of SqlParameter)()
            checkParams.Add(New SqlParameter("@GID", gameId))

            Dim avail As Object = ExecuteScalar(checkSql, checkParams)
            If avail Is Nothing OrElse Convert.ToInt32(avail) <= 0 Then
                MessageBox.Show("Game is currently not available for rental.", "Rental Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim insertSql As String = "INSERT INTO Rental (GameID, CustomerName, CustomerPhone, CustomerAddress, RentalDate, ReturnDate, RentalPrice, Status) " & _
                                      "VALUES (@GID, @Customer, @Phone, @Addr, @RDate, @RetDate, @Price, 'Rented')"
            Dim params As New List(Of SqlParameter)()
            params.Add(New SqlParameter("@GID", gameId))
            params.Add(New SqlParameter("@Customer", txtCustomerName.Text.Trim()))
            params.Add(New SqlParameter("@Phone", txtCustomerPhone.Text.Trim()))
            params.Add(New SqlParameter("@Addr", txtCustomerAddress.Text.Trim()))
            params.Add(New SqlParameter("@RDate", dtpRentalDate.Value))
            params.Add(New SqlParameter("@RetDate", dtpReturnDate.Value))
            params.Add(New SqlParameter("@Price", rentPrice))

            ExecuteNonQuery(insertSql, params)

            Dim updateSql As String = "UPDATE Games SET AvailableQuantity = AvailableQuantity - 1 WHERE GameID = @GID"
            Dim updateParams As New List(Of SqlParameter)()
            updateParams.Add(New SqlParameter("@GID", gameId))
            ExecuteNonQuery(updateSql, updateParams)

            MessageBox.Show("Game rented successfully to " & txtCustomerName.Text.Trim() & "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadGamesComboBox()
            LoadRentalsData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error processing rental: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Process Sale
    Private Sub btnSellGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSellGame.Click
        If cmbGames.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a game to sell.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtCustomerName.Text.Trim() = "" Then
            MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerName.Focus()
            Exit Sub
        End If

        If txtCustomerPhone.Text.Trim() = "" Then
            MessageBox.Show("Please enter customer phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerPhone.Focus()
            Exit Sub
        End If

        If txtCustomerAddress.Text.Trim() = "" Then
            MessageBox.Show("Please enter customer address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerAddress.Focus()
            Exit Sub
        End If

        Dim sellPrice As Decimal = 0
        If Not Decimal.TryParse(txtRentalPrice.Text.Trim(), sellPrice) OrElse sellPrice < 0 Then
            MessageBox.Show("Please enter a valid numeric sale price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRentalPrice.Focus()
            Exit Sub
        End If

        Dim gameId As Integer = Convert.ToInt32(cmbGames.SelectedValue)

        Try
            Dim checkSql As String = "SELECT AvailableQuantity FROM Games WHERE GameID = @GID"
            Dim checkParams As New List(Of SqlParameter)()
            checkParams.Add(New SqlParameter("@GID", gameId))

            Dim avail As Object = ExecuteScalar(checkSql, checkParams)
            If avail Is Nothing OrElse Convert.ToInt32(avail) <= 0 Then
                MessageBox.Show("Game is out of stock and cannot be sold.", "Sale Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim insertSql As String = "INSERT INTO Sales (GameID, CustomerName, CustomerPhone, CustomerAddress, SaleDate, Quantity, SalePrice, TotalAmount) " & _
                                      "VALUES (@GID, @Customer, @Phone, @Addr, @SDate, 1, @Price, @Price)"
            Dim params As New List(Of SqlParameter)()
            params.Add(New SqlParameter("@GID", gameId))
            params.Add(New SqlParameter("@Customer", txtCustomerName.Text.Trim()))
            params.Add(New SqlParameter("@Phone", txtCustomerPhone.Text.Trim()))
            params.Add(New SqlParameter("@Addr", txtCustomerAddress.Text.Trim()))
            params.Add(New SqlParameter("@SDate", dtpRentalDate.Value))
            params.Add(New SqlParameter("@Price", sellPrice))

            ExecuteNonQuery(insertSql, params)

            ' Deduct available quantity and total quantity upon outright sale
            Dim updateSql As String = "UPDATE Games SET AvailableQuantity = AvailableQuantity - 1 WHERE GameID = @GID"
            Dim updateParams As New List(Of SqlParameter)()
            updateParams.Add(New SqlParameter("@GID", gameId))
            ExecuteNonQuery(updateSql, updateParams)

            MessageBox.Show("Game sold successfully to " & txtCustomerName.Text.Trim() & " for $" & sellPrice.ToString("0.00") & "!", "Sale Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadGamesComboBox()
            LoadRentalsData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error processing sale: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvRentals_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRentals.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRentals.Rows(e.RowIndex)
            txtRentalID.Text = row.Cells("ID").Value.ToString()
            txtCustomerName.Text = If(row.Cells("Customer").Value IsNot Nothing, row.Cells("Customer").Value.ToString(), "")
            txtCustomerPhone.Text = If(row.Cells("Phone").Value IsNot Nothing, row.Cells("Phone").Value.ToString(), "")
            txtCustomerAddress.Text = If(row.Cells("Address").Value IsNot Nothing, row.Cells("Address").Value.ToString(), "")
            txtRentalPrice.Text = If(row.Cells("Price ($)").Value IsNot Nothing, row.Cells("Price ($)").Value.ToString(), "0.00")
            
            Dim transType As String = If(row.Cells("Type").Value IsNot Nothing, row.Cells("Type").Value.ToString(), "Rental")
            If transType = "Sale" Then
                cmbTransType.SelectedItem = "Sell"
                dtpReturnDate.Enabled = False
            Else
                cmbTransType.SelectedItem = "Rent"
                dtpReturnDate.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnReturnRental_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturnRental.Click
        If txtRentalID.Text = "" Then
            MessageBox.Show("Please select a rental record from the table to return.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Verify if selected transaction is a Sale or Rental
        If cmbTransType.SelectedItem IsNot Nothing AndAlso cmbTransType.SelectedItem.ToString() = "Sell" Then
            MessageBox.Show("Sold games are permanent purchases and cannot be returned as rentals.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            Dim rentalId As Integer = Convert.ToInt32(txtRentalID.Text)

            Dim checkStatusSql As String = "SELECT Status FROM Rental WHERE RentalID = @RID"
            Dim checkParams As New List(Of SqlParameter)()
            checkParams.Add(New SqlParameter("@RID", rentalId))
            Dim currentStatus As Object = ExecuteScalar(checkStatusSql, checkParams)

            If currentStatus Is Nothing Then
                MessageBox.Show("Rental record not found or it was a sale transaction.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If currentStatus.ToString() = "Returned" Then
                MessageBox.Show("This rental has already been returned.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim getGameSql As String = "SELECT GameID FROM Rental WHERE RentalID = @RID"
            Dim getGameParams As New List(Of SqlParameter)()
            getGameParams.Add(New SqlParameter("@RID", rentalId))
            Dim gameObj As Object = ExecuteScalar(getGameSql, getGameParams)

            If gameObj IsNot Nothing Then
                Dim gameId As Integer = Convert.ToInt32(gameObj)

                Dim updateRentalSql As String = "UPDATE Rental SET ReturnDate = GETDATE(), Status = 'Returned' WHERE RentalID = @RID"
                Dim rentalParams As New List(Of SqlParameter)()
                rentalParams.Add(New SqlParameter("@RID", rentalId))
                ExecuteNonQuery(updateRentalSql, rentalParams)

                Dim updateGameSql As String = "UPDATE Games SET AvailableQuantity = AvailableQuantity + 1 WHERE GameID = @GID"
                Dim gameParams As New List(Of SqlParameter)()
                gameParams.Add(New SqlParameter("@GID", gameId))
                ExecuteNonQuery(updateGameSql, gameParams)

                MessageBox.Show("Rental returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadGamesComboBox()
                LoadRentalsData()
                ClearFields()
            End If
        Catch ex As Exception
            MessageBox.Show("Error returning rental: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadGamesComboBox()
        LoadRentalsData()
    End Sub

End Class
