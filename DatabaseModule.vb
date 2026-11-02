Imports System.Data
Imports System.Data.SqlClient

Module DatabaseModule
    ' Service-based Database MDF connection string (GameLibraryDBmdf.mdf)
    Public connStr As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\GameLibraryDBmdf.mdf;Integrated Security=True;User Instance=True"

    ' Alternative server connection if database is attached in SQL Server SSMS
    Public serverCatalogConnStr As String = "Data Source=.\SQLEXPRESS;Initial Catalog=GameLibraryDB;Integrated Security=True;"

    ' Helper function to get an open SQL Connection
    Public Function GetConnection() As SqlConnection
        Dim conn As SqlConnection = Nothing
        Try
            ' 1. Primary: Connect to Service-based Database .mdf file
            conn = New SqlConnection(connStr)
            conn.Open()
            Return conn
        Catch ex As Exception
            ' 2. Fallback: Connect to SQL Server database catalog if MDF attach fails
            Try
                conn = New SqlConnection(serverCatalogConnStr)
                conn.Open()
                Return conn
            Catch
                Throw ex
            End Try
        End Try
    End Function

    ' Helper function to execute SELECT queries and return a DataTable
    Public Function ExecuteQuery(ByVal sql As String, Optional ByVal parameters As List(Of SqlParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As SqlConnection = GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    If parameters IsNot Nothing Then
                        For Each param As SqlParameter In parameters
                            cmd.Parameters.Add(param)
                        Next
                    End If
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Helper function to execute INSERT, UPDATE, DELETE queries
    Public Function ExecuteNonQuery(ByVal sql As String, Optional ByVal parameters As List(Of SqlParameter) = Nothing) As Integer
        Dim rowsAffected As Integer = 0
        Try
            Using conn As SqlConnection = GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    If parameters IsNot Nothing Then
                        For Each param As SqlParameter In parameters
                            cmd.Parameters.Add(param)
                        Next
                    End If
                    rowsAffected = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return rowsAffected
    End Function

    ' Helper function to execute Scalar queries (e.g., COUNT, MAX, SUM)
    Public Function ExecuteScalar(ByVal sql As String, Optional ByVal parameters As List(Of SqlParameter) = Nothing) As Object
        Dim result As Object = Nothing
        Try
            Using conn As SqlConnection = GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    If parameters IsNot Nothing Then
                        For Each param As SqlParameter In parameters
                            cmd.Parameters.Add(param)
                        Next
                    End If
                    result = cmd.ExecuteScalar()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function
End Module
