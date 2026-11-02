Imports System.Data.SqlClient

Public Class BorrowIssueForm

    Private Sub BorrowIssueForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            FormatGridFont()
            LoadGamesComboBox()
            LoadActiveIssues()
            ClearFields()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormatGridFont()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        dgvActiveIssues.DefaultCellStyle.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular)
        dgvActiveIssues.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        dgvActiveIssues.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(238, 242, 255)
        dgvActiveIssues.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 27, 75)
        dgvActiveIssues.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 243, 255)
        dgvActiveIssues.EnableHeadersVisualStyles = False
        dgvActiveIssues.RowTemplate.Height = 36
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub LoadGamesComboBox()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            Dim sql As String = "SELECT GameID, GameName + ' (Available: ' + CAST(AvailableQuantity AS VARCHAR) + ')' AS DisplayName FROM Games ORDER BY GameName"
            Dim dt As DataTable = ExecuteQuery(sql)
            cmbGames.DataSource = dt
            cmbGames.DisplayMember = "DisplayName"
            cmbGames.ValueMember = "GameID"
            cmbGames.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error loading games list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadActiveIssues()
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode Then Exit Sub
        Try
            Dim sql As String = "SELECT bi.IssueID, g.GameName, bi.BorrowerName, bi.BorrowerContact, bi.IssueDate, bi.DueDate, bi.Status " & _
                               "FROM BorrowIssue bi " & _
                               "INNER JOIN Games g ON bi.GameID = g.GameID " & _
                               "WHERE bi.Status = 'Borrowed' " & _
                               "ORDER BY bi.IssueID DESC"
            Dim dt As DataTable = ExecuteQuery(sql)
            dgvActiveIssues.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading active issues: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        txtIssueID.Text = ""
        cmbGames.SelectedIndex = -1
        txtBorrowerName.Text = ""
        txtBorrowerContact.Text = ""
        dtpIssueDate.Value = DateTime.Now
        dtpDueDate.Value = DateTime.Now.AddDays(7)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnIssueGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssueGame.Click
        If cmbGames.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a game to issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtBorrowerName.Text.Trim() = "" Then
            MessageBox.Show("Please enter borrower name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBorrowerName.Focus()
            Exit Sub
        End If

        Dim gameId As Integer = Convert.ToInt32(cmbGames.SelectedValue)

        Try
            Dim checkSql As String = "SELECT AvailableQuantity FROM Games WHERE GameID = @GID"
            Dim checkParams As New List(Of SqlParameter)()
            checkParams.Add(New SqlParameter("@GID", gameId))

            Dim avail As Object = ExecuteScalar(checkSql, checkParams)
            If avail Is Nothing OrElse Convert.ToInt32(avail) <= 0 Then
                MessageBox.Show("Game is currently not available.", "Issue Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim insertSql As String = "INSERT INTO BorrowIssue (GameID, BorrowerName, BorrowerContact, IssueDate, DueDate, Status) " & _
                                      "VALUES (@GID, @Name, @Contact, @IDate, @DDate, 'Borrowed')"
            Dim params As New List(Of SqlParameter)()
            params.Add(New SqlParameter("@GID", gameId))
            params.Add(New SqlParameter("@Name", txtBorrowerName.Text.Trim()))
            params.Add(New SqlParameter("@Contact", txtBorrowerContact.Text.Trim()))
            params.Add(New SqlParameter("@IDate", dtpIssueDate.Value))
            params.Add(New SqlParameter("@DDate", dtpDueDate.Value))

            ExecuteNonQuery(insertSql, params)

            Dim updateSql As String = "UPDATE Games SET AvailableQuantity = AvailableQuantity - 1 WHERE GameID = @GID"
            Dim updateParams As New List(Of SqlParameter)()
            updateParams.Add(New SqlParameter("@GID", gameId))
            ExecuteNonQuery(updateSql, updateParams)

            MessageBox.Show("Game issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadGamesComboBox()
            LoadActiveIssues()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error issuing game: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvActiveIssues_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvActiveIssues.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvActiveIssues.Rows(e.RowIndex)
            txtIssueID.Text = row.Cells("IssueID").Value.ToString()
            txtBorrowerName.Text = row.Cells("BorrowerName").Value.ToString()
            txtBorrowerContact.Text = row.Cells("BorrowerContact").Value.ToString()
        End If
    End Sub

    Private Sub btnReturnGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturnGame.Click
        If txtIssueID.Text = "" Then
            MessageBox.Show("Please select an active issue record from the table below to return.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim issueId As Integer = Convert.ToInt32(txtIssueID.Text)

            Dim getGameSql As String = "SELECT GameID FROM BorrowIssue WHERE IssueID = @IID"
            Dim getGameParams As New List(Of SqlParameter)()
            getGameParams.Add(New SqlParameter("@IID", issueId))
            Dim gameObj As Object = ExecuteScalar(getGameSql, getGameParams)

            If gameObj IsNot Nothing Then
                Dim gameId As Integer = Convert.ToInt32(gameObj)

                Dim updateIssueSql As String = "UPDATE BorrowIssue SET ReturnDate = GETDATE(), Status = 'Returned' WHERE IssueID = @IID"
                Dim issueParams As New List(Of SqlParameter)()
                issueParams.Add(New SqlParameter("@IID", issueId))
                ExecuteNonQuery(updateIssueSql, issueParams)

                Dim updateGameSql As String = "UPDATE Games SET AvailableQuantity = AvailableQuantity + 1 WHERE GameID = @GID"
                Dim gameParams As New List(Of SqlParameter)()
                gameParams.Add(New SqlParameter("@GID", gameId))
                ExecuteNonQuery(updateGameSql, gameParams)

                MessageBox.Show("Game returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadGamesComboBox()
                LoadActiveIssues()
                ClearFields()
            End If
        Catch ex As Exception
            MessageBox.Show("Error returning game: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadGamesComboBox()
        LoadActiveIssues()
    End Sub

End Class
