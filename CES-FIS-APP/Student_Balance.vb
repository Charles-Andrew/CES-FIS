Public Class Student_Balance
    Public for_payment As Boolean = False
    Public selected_id As Integer = 0
    Private Sub Student_Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not for_payment Then
            If Not CheckExistingBalance() Then
                tb_balance.Text = "0"
            Else
                GetBalance()
            End If
        End If
    End Sub
    Private Function CheckExistingBalance() As Boolean
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT * FROM balance WHERE student_id = @SID"
        cmd.Parameters.AddWithValue("@SID", selected_id)
        Dim dr = db.dr
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            db.Close()
            Return True
        Else
            db.Close()
            Return False
        End If
    End Function

    Private Sub GetBalance()
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT balance FROM balance WHERE student_id = @SID"
        cmd.Parameters.AddWithValue("@SID", selected_id)
        Dim dr = db.dr
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                tb_balance.Text = dr.Item("balance").ToString
            End While
        End If
        db.Close()
    End Sub
    Private Sub btn_update_balance_Click(sender As Object, e As EventArgs) Handles btn_update_balance.Click
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        If CheckExistingBalance() Then
            cmd.CommandText = "UPDATE balance SET balance = @BAL WHERE student_id = @SID"
        Else
            cmd.CommandText = "INSERT INTO balance (student_id, balance) VALUES (@SID, @BAL)"
        End If
        cmd.Parameters.AddWithValue("@SID", selected_id)
        cmd.Parameters.AddWithValue("@BAL", Double.Parse(tb_balance.Text))
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("Balance successfully updated.", "Success")
        Else
            MessageBox.Show("Something went wrong while updating the balance.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub tb_balance_TextChanged(sender As Object, e As EventArgs) Handles tb_balance.TextChanged
        If IsNumeric(tb_balance.Text) Then
            btn_update_balance.Enabled = True
        Else
            btn_update_balance.Enabled = False
        End If
    End Sub

    Private Sub btn_pay_new_Click(sender As Object, e As EventArgs) Handles btn_pay_new.Click
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "INSERT INTO payments (payor_id, date, amount) VALUES (@PID, @DATE, @AMOUNT)"
        cmd.Parameters.AddWithValue("@PID", selected_id)
        cmd.Parameters.AddWithValue("@AMOUNT", Double.Parse(tb_balance.Text))
        cmd.Parameters.AddWithValue("@DATE", DateTime.Now.Date)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("New Payment Recorded.", "Success")
            Me.Dispose()
        Else
            MessageBox.Show("Something went wrong while recoding a new payment.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class