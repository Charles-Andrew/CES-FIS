﻿Imports MaterialSkin

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        If Not CheckAdmin() Then
            btn_login.Visible = False
            btn_create_admin.Visible = True
        End If
    End Sub
    Private Function CheckAdmin() As Boolean
        Dim l As New DBConn
        Dim cmd = l.cmd
        Dim dr = l.dr
        l.Open()
        cmd.Connection = l.conn
        cmd.CommandText = "SELECT * FROM users WHERE is_admin=True"
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            Return True
        Else
            Return False
        End If


    End Function

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim l As New DBConn
        Dim cmd = l.cmd
        Dim dr = l.dr
        l.Open()
        cmd.Connection = l.conn
        cmd.CommandText = "SELECT * FROM users WHERE username=@UN AND password=@PW"
        cmd.Parameters.AddWithValue("@UN", tb_user.Text)
        Dim en As New encrypt
        en.hashProp = tb_pass.Text
        cmd.Parameters.AddWithValue("@PW", en.hashProp)
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            Dim m As New Main
            While dr.Read()
                If dr.GetValue(dr.GetOrdinal("is_admin")) Then
                    m.is_admin = True
                End If
            End While
            m.Show()
            Me.Close()
        Else
            MessageBox.Show("Incorrect. Please try again.")
        End If
        l.Close()
    End Sub

    Private Sub btn_create_admin_Click(sender As Object, e As EventArgs) Handles btn_create_admin.Click
        If tb_user.Text = "" OrElse tb_pass.Text = "" Then
            MessageBox.Show("Username or Password should not be empty. Please try again.")
        Else
            Dim db As New DBConn
            db.Open()
            Dim cmd = db.cmd
            cmd.Connection = db.conn
            cmd.CommandText = "INSERT INTO users (username, password, is_admin) VALUES (@UN, @PW, True)"
            cmd.Parameters.AddWithValue("@UN", tb_user.Text)
            Dim en As New encrypt
            en.hashProp = tb_pass.Text
            cmd.Parameters.AddWithValue("@PW", en.hashProp)

            Dim confirmation As DialogResult = MessageBox.Show("Admin will only be created once. Please make sure to save a copy of the credentials.", "Confirmation", MessageBoxButtons.OKCancel)
            If confirmation = DialogResult.OK Then
                If cmd.ExecuteNonQuery Then
                    btn_login.Visible = True
                    btn_create_admin.Visible = False
                    tb_user.Clear()
                    tb_pass.Clear()
                    MessageBox.Show("Admin created successfully. Please login.")
                Else
                    MessageBox.Show("Something went wrong while creating the admin account. Please try again.")
                End If
            End If
            db.Close()
        End If
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class