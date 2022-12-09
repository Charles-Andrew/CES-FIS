Public Class Logs
    Private dt As Date
    Private details As String
    Public Property DOT() As Date
        Get
            Return DateTime.Now()
        End Get
        Set(ByVal value As Date)
            dt = value
        End Set
    End Property

    Public Property TransactionDetails() As String
        Get
            Return details
        End Get
        Set(ByVal value As String)
            details = value
        End Set
    End Property

    Public Sub NewLog()
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "INSERT INTO logs (details, date) VALUES (@DETAILS, @DOT)"
        cmd.Parameters.AddWithValue("@DETAILS", TransactionDetails)
        cmd.Parameters.AddWithValue("@DOT", DOT)
        cmd.ExecuteNonQuery()
        db.Close()
    End Sub

    Public Function GetLogs() As DataTable
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT id as ""ID"", details as ""Details"", date as ""Date"" FROM logs ORDER BY date DESC, id DESC"
        db.Close()
        Dim da = db.da
        Dim dt = db.dt
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        Return dt
    End Function
End Class
