﻿Imports Npgsql

Public Class Payment_Info_Class
    Private id As Integer
    Public Property selected_id() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Function LoadAllInfo() As DataTable
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        If selected_id <> 0 Then
            cmd.CommandText = "SELECT COUNT(id) as ""Number of Payment"", SUM(amount) as ""Total Paid"",  (SELECT balance FROM balance WHERE student_id = @PID) as ""Total Payment"", ((SELECT balance FROM balance WHERE student_id = @PID) - SUM(amount)) as ""Difference"" FROM payments WHERE payor_id = @PID"
            cmd.Parameters.AddWithValue("@PID", selected_id)
        Else
            cmd.CommandText = "SELECT COUNT(id) as ""Number of Payment"", SUM(amount) as ""Total Paid"" FROM payments"
        End If
        Dim da = db.da
        Dim dt = db.dt
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        db.Close()
        Return dt
    End Function

End Class
