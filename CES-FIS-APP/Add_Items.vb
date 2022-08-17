Public Class Add_Items
    Public selected_id As Integer = 0
    Private Sub Add_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If selected_id <> 0 Then
            Dim db As New DBConn
            db.Open()
            Dim cmd = db.cmd
            cmd.Connection = db.conn
            cmd.CommandText = "SELECT * FROM items WHERE id = @ID"
            cmd.Parameters.AddWithValue("@ID", selected_id)
            Dim dr = db.dr
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    tb_name.Text = dr.Item("name").ToString()
                End While
            End If
            db.Close()
        End If
    End Sub
    Private Sub btn_item_add_Click(sender As Object, e As EventArgs) Handles btn_item_add.Click
        If tb_name.Text = "" Then
            MessageBox.Show("Name field empty. Please try again.")
        Else
            Dim db As New DBConn
            db.Open()
            Dim cmd = db.cmd
            cmd.Connection = db.conn
            cmd.CommandText = "INSERT INTO items (name) VALUES (@in) RETURNING id"
            cmd.Parameters.AddWithValue("@in", tb_name.Text)

            Dim dr = db.dr
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    Dim _db As New DBConn
                    _db.Open()
                    Dim _cmd = _db.cmd
                    _cmd.Connection = _db.conn
                    _cmd.CommandText = "INSERT INTO funds_transactions (item_id, added_amount, transaction_date) VALUES (@ii, @aa, @td)"
                    _cmd.Parameters.AddWithValue("@ii", dr.Item("id"))
                    _cmd.Parameters.AddWithValue("@aa", Double.Parse(tb_item_amount.Text))
                    _cmd.Parameters.AddWithValue("@td", DateTime.Now.Date)
                    If _cmd.ExecuteNonQuery Then
                        MessageBox.Show("Item added successfully.")
                        tb_name.Clear()
                        tb_item_amount.Text = "0"
                    Else
                        MessageBox.Show("Something went wrong. Please try again.")
                    End If
                    _db.Close()
                End While
            End If
            db.Close()
        End If

    End Sub

    Private Sub tb_item_amount_TextChanged(sender As Object, e As EventArgs) Handles tb_item_amount.TextChanged
        If IsNumeric(tb_item_amount.Text) Then
            btn_item_add.Enabled = True
            btn_add_funds.Enabled = True
        Else
            btn_item_add.Enabled = False
            btn_add_funds.Enabled = False
        End If
    End Sub
    Private Sub btn_add_funds_Click(sender As Object, e As EventArgs) Handles btn_add_funds.Click
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "INSERT INTO funds_transactions (item_id, added_amount, transaction_date) VALUES (@ii, @aa, @td)"
        cmd.Parameters.AddWithValue("@ii", selected_id)
        cmd.Parameters.AddWithValue("@aa", Double.Parse(tb_item_amount.Text))
        cmd.Parameters.AddWithValue("@td", DateTime.Now.Date)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("New transaction recorded successfully.")
            Me.Close()
        Else
            MessageBox.Show("Something went wrong. Please try again.")
        End If
    End Sub
End Class