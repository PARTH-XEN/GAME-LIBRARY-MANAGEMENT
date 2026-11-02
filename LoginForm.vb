Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        ' Simple validation check
        If txtUsername.Text.Trim() = "" Then
            MessageBox.Show("Please enter username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Please enter password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            ' Query database to verify username and password
            Dim sql As String = "SELECT COUNT(*) FROM Users WHERE Username = @User AND Password = @Pass"
            Dim params As New List(Of SqlParameter)()
            params.Add(New SqlParameter("@User", txtUsername.Text.Trim()))
            params.Add(New SqlParameter("@Pass", txtPassword.Text.Trim()))

            Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, params))

            If count > 0 Then
                MessageBox.Show("Login successful! Welcome to Game Library System.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Hide login form and open Dashboard
                Dim dashboard As New DashboardForm()
                dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error logging in: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Show / Hide password checkbox event handler
    Private Sub chkShowPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
        chkShowPassword.Checked = False
        txtUsername.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class
