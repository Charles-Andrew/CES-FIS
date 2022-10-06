Imports MaterialSkin

Public Class Update_Student
    Public selected_id = 0
    Private Sub Update_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        If selected_id <> 0 Then
            LoadStudentData()
        End If
    End Sub

    Private Sub LoadStudentData()
        cb_aye.Items.Clear()
        For yr = Int(Date.Now.Year) To 1980 Step -1
            cb_aye.Items.Add(yr)
        Next


        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT * FROM students WHERE id = @ID"
        cmd.Parameters.AddWithValue("@ID", selected_id)

        Dim dr = db.dr
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                tb_family_name.Text = dr.Item("family_name").ToString
                tb_given_name.Text = dr.Item("given_name").ToString
                tb_middle_name.Text = dr.Item("middle_name").ToString
                tb_course.Text = dr.Item("course").ToString
                tb_edat_elem.Text = dr.Item("EdAt_Elem").ToString
                tb_edat_hs.Text = dr.Item("EdAt_HS").ToString
                tb_edat_college.Text = dr.Item("EdAt_College").ToString
                tb_edat_vocational.Text = dr.Item("EdAt_Vocational").ToString
                tb_occupation.Text = dr.Item("occupation").ToString
                tb_present_job.Text = dr.Item("present_job").ToString
                tb_occupation_address.Text = dr.Item("occupation_address").ToString
                tb_employer.Text = dr.Item("employer").ToString
                tb_spouse_occupation.Text = dr.Item("spouse_occupation").ToString
                tb_contact_number.Text = dr.Item("contact_number").ToString
                tb_address.Text = dr.Item("home_address").ToString
                dtp_dob.Value = dr.Item("DOB")
                tb_age.Text = dr.Item("age").ToString
                cb_civil_status.SelectedIndex = cb_civil_status.FindStringExact(dr.Item("civil_status").ToString)
                If dr.Item("AYE") IsNot DBNull.Value Then
                    cb_aye.SelectedIndex = cb_aye.FindStringExact(Int(dr.Item("AYE")))
                End If
            End While
        End If
        db.Close()


    End Sub

    Private Sub Ageload()
        Dim age As TimeSpan = DateTime.Now - dtp_dob.Value
        Dim calc_age = Int(age.Days / 365)
        If calc_age < 0 Then
            calc_age = 0
        End If
        tb_age.Text = calc_age.ToString()
    End Sub

    Private Sub btn_enroll_Click(sender As Object, e As EventArgs) Handles btn_enroll.Click
        If tb_family_name.Text = "" OrElse tb_given_name.Text = "" OrElse tb_middle_name.Text = "" OrElse tb_course.Text = "" OrElse cb_civil_status.Text = "" Then
            MessageBox.Show("Some fields are missing or with incorrect values. Please recheck.")
        Else

            Dim approve As DialogResult = MessageBox.Show("Are the data finalized?", "Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If approve = DialogResult.Yes Then
                Dim db As New DBConn
                db.Open()

                Dim cmd = db.cmd
                cmd.Connection = db.conn

                cmd.CommandText = "UPDATE students SET family_name=@fn, given_name=@gn, middle_name=@mn, course=@course, ""EdAt_Elem""=@ee, ""EdAt_HS""=@eh, ""EdAt_Vocational""=@ev, ""EdAt_College""=@ec, occupation=@o, present_job=@pj, occupation_address=@oa, employer=@e, spouse_occupation=@so, contact_number=@cn, home_address=@ha, ""DOB""=@DOB, age=@age, civil_status=@cs, ""AYE""=@AYE WHERE id=@id"
                cmd.Parameters.AddWithValue("@fn", tb_family_name.Text)
                cmd.Parameters.AddWithValue("@gn", tb_given_name.Text)
                cmd.Parameters.AddWithValue("@mn", tb_middle_name.Text)
                cmd.Parameters.AddWithValue("@course", tb_course.Text)
                cmd.Parameters.AddWithValue("@ee", If(tb_edat_elem.Text = "", DBNull.Value, tb_edat_elem.Text))
                cmd.Parameters.AddWithValue("@eh", If(tb_edat_hs.Text = "", DBNull.Value, tb_edat_hs.Text))
                cmd.Parameters.AddWithValue("@ev", If(tb_edat_vocational.Text = "", DBNull.Value, tb_edat_vocational.Text))
                cmd.Parameters.AddWithValue("@ec", If(tb_edat_college.Text = "", DBNull.Value, tb_edat_college.Text))
                cmd.Parameters.AddWithValue("@o", If(tb_occupation.Text = "", DBNull.Value, tb_occupation.Text))
                cmd.Parameters.AddWithValue("@pj", If(tb_present_job.Text = "", DBNull.Value, tb_present_job.Text))
                cmd.Parameters.AddWithValue("@oa", If(tb_occupation_address.Text = "", DBNull.Value, tb_occupation_address.Text))
                cmd.Parameters.AddWithValue("@e", If(tb_employer.Text = "", DBNull.Value, tb_employer.Text))
                cmd.Parameters.AddWithValue("@so", If(tb_spouse_occupation.Text = "", DBNull.Value, tb_spouse_occupation.Text))
                cmd.Parameters.AddWithValue("@cn", If(tb_contact_number.Text = "", DBNull.Value, tb_contact_number.Text))
                cmd.Parameters.AddWithValue("@ha", tb_address.Text)
                cmd.Parameters.AddWithValue("@DOB", dtp_dob.Value.Date)
                cmd.Parameters.AddWithValue("@age", Integer.Parse(tb_age.Text))
                cmd.Parameters.AddWithValue("@cs", cb_civil_status.SelectedItem.ToString)
                cmd.Parameters.AddWithValue("@id", selected_id)
                cmd.Parameters.AddWithValue("@AYE", cb_aye.SelectedItem.ToString)


                Try
                    If cmd.ExecuteNonQuery Then
                        MessageBox.Show("Student record successfully updated!.")
                    Else
                        MessageBox.Show("Something went wrong. Please try again.")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                db.Close()
            End If
        End If
    End Sub

    Private Sub dtp_dob_ValueChanged(sender As Object, e As EventArgs) Handles dtp_dob.ValueChanged
        Ageload()
    End Sub
End Class