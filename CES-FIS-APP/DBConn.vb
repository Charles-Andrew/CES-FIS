Imports Npgsql
Public Class DBConn
    Public conn As New NpgsqlConnection
    Public da As New NpgsqlDataAdapter
    Public dt As New DataTable
    Public dr As NpgsqlDataReader
    Public cmd As New NpgsqlCommand

    Public Sub Open()
        conn.ConnectionString = "database=CESFIS_DB;server=localhost;port=5432;User ID=postgres;password=admin;"
        conn.Open()
    End Sub
    Public Sub Close()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

    End Sub

End Class
