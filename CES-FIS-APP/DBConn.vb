Imports Npgsql
Public Class DBConn
    Public conn As New NpgsqlConnection
    Public da As New NpgsqlDataAdapter
    Public dt As New DataTable
    Public dr As NpgsqlDataReader
    Public cmd As New NpgsqlCommand

    Public Sub Open()
        conn.ConnectionString = Get_Connection_String()
        conn.Open()
    End Sub
    Public Sub Close()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Protected Function Get_Connection_String()
        Return My.Computer.FileSystem.ReadAllText("_db.txt").ToString
    End Function

End Class
