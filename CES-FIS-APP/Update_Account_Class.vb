Public Class Update_Account_Class
    Private Username As String
    Public Property _Username() As String
        Get
            Return Username
        End Get
        Set(ByVal value As String)
            Username = value
        End Set
    End Property

    Private Password As String
    Public Property _Password() As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            Password = value
        End Set
    End Property

    Private Password_2 As String
    Public Property _Password2() As String
        Get
            Return Password_2
        End Get
        Set(ByVal value As String)
            Password_2 = value
        End Set
    End Property

    Private Password_Raw As String
    Public Property _Raw_Password() As String
        Get
            Return Password_Raw
        End Get
        Set(ByVal value As String)
            Password_Raw = value
        End Set
    End Property

    Public Function Confirm_Password() As Boolean
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT * FROM users WHERE password = @PW"
        cmd.Parameters.AddWithValue("@PW", _Password2)
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

    Public Sub Update_Account(account As String)
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "UPDATE users SET username = @UN, password = @PW WHERE password = @CPW"
        cmd.Parameters.AddWithValue("@UN", _Username)
        cmd.Parameters.AddWithValue("@PW", _Password)
        cmd.Parameters.AddWithValue("@CPW", _Password2)

        If cmd.ExecuteNonQuery Then
            MessageBox.Show("The Account was updated successfully. A txt file containing the credentials was saved in your desktop. Please store it in a secure folder to avoid unauthorized access.", "Information")
            Save_Creds(account)
        Else
            MessageBox.Show("Something went wrong. Please try again.")
        End If
        db.Close()
    End Sub

    Public Sub Save_Creds(account As String)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + account + "_Credentials.txt", False)
        file.WriteLine("Admin Username: " + _Username)
        file.WriteLine("Admin Password: " + _Raw_Password)
        file.Close()
    End Sub

    Public Function Check_Exists_Director() As Boolean
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT * FROM users WHERE is_admin = False"
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

    Public Sub Set_Director()
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "INSERT INTO users (username, password, is_admin) VALUES (@UN,@PW,False)"
        cmd.Parameters.AddWithValue("@UN", _Username)
        cmd.Parameters.AddWithValue("@PW", _Password)

        If cmd.ExecuteNonQuery Then
            MessageBox.Show("Directors account was created successfully.", "Confirmation")
            MessageBox.Show("Admin created successfully. A txt file containing the credentials was saved in your desktop. Please store it in a secure folder to avoid unauthorized access.", "Information")
            Dim uac As New Update_Account_Class
            uac._Username = _Username
            uac._Raw_Password = _Raw_Password
            uac.Save_Creds("Director_Initial")
        End If
    End Sub
End Class
