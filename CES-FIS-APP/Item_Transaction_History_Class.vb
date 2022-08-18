Public Class Item_Transaction_History_Class
    Private id As Integer
    Public Property item_id() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Private name As String
    Public Property item_name() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    Public Function LoadItemTransactions() As DataTable
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT id as ""Transaction ID"", added_amount as ""Transaction Amount"", transaction_date as ""Date"" FROM funds_transactions WHERE item_id = @IID ORDER BY id DESC "
        cmd.Parameters.AddWithValue("@IID", id)
        Dim dt = db.dt
        Dim da = db.da
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        db.Close()
        Return dt
    End Function

    Public Function LoadItemName() As String
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT name FROM items WHERE id = @ID"
        cmd.Parameters.AddWithValue("@ID", id)
        Dim dr = db.dr
        dr = cmd.ExecuteReader
        Dim item_name As String = "None"
        If dr.HasRows Then
            While dr.Read
                item_name = dr.Item("name").ToString()
            End While
        End If
        db.Close()
        Return item_name
    End Function

    Public Sub DeleteItemTransaction(itd As Integer)
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "DELETE FROM funds_transactions WHERE id = @id"
        cmd.Parameters.AddWithValue("@id", itd)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("Selected item transaction succesfully deleted.", "Deletion Success")
        Else
            MessageBox.Show("Something went wrong while deleting the selected transaction.", "Deletion Failed")
        End If
        db.Close()
    End Sub
End Class
