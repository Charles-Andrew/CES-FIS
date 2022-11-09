Public Class Report_Class
    Private Date_From As Date
    Public Property From_Date() As Date
        Get
            Return Date_From
        End Get
        Set(ByVal value As Date)
            Date_From = value
        End Set
    End Property

    Private Date_To As Date
    Public Property To_Date() As Date
        Get
            Return Date_To
        End Get
        Set(ByVal value As Date)
            Date_To = value
        End Set
    End Property
    Public Function GenerateFunds() As DataTable
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SET datestyle = dmy;SELECT id as ""ID"",(SELECT name FROM items WHERE id = funds_transactions.item_id) as ""Item_Name"", added_amount as ""Amount"", transaction_date as ""Date"" FROM funds_transactions WHERE transaction_date >= '" + From_Date + "' AND transaction_date <= '" + To_Date + "'"
        db.Close()
        Dim da = db.da
        Dim dt = db.dt
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        Return dt
    End Function
    Public Function GenerateExpenses() As DataTable
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SET datestyle = dmy;SELECT * FROM expenses WHERE date >= '" + From_Date + "' AND date <= '" + To_Date + "'"
        db.Close()
        Dim da = db.da
        Dim dt = db.dt
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        Return dt
    End Function

    Public Function GenerateCashBalance() As List(Of String)
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SET datestyle = dmy;SELECT SUM(amount) as total_cashout, (SELECT SUM(added_amount) as total_cashin FROM funds_transactions) FROM expenses WHERE date >= '" + From_Date + "' AND date <= '" + To_Date + "'"
        Dim dr = db.dr
        Dim vals As New List(Of String)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                vals.Add(dr.Item("total_cashin").ToString())
                vals.Add(dr.Item("total_cashout").ToString())
            End While
        End If
        db.Close()
        Return vals
    End Function


End Class
