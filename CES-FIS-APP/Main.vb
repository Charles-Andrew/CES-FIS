Imports MaterialSkin
Public Class Main
    Public is_admin As Boolean = False
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        Ageload()
        LoadAllRecord()
    End Sub

    Private Sub dtp_dob_ValueChanged(sender As Object, e As EventArgs) Handles dtp_dob.ValueChanged
        Ageload()
    End Sub
    Private Sub btn_enroll_Click(sender As Object, e As EventArgs) Handles btn_enroll.Click
        If tb_family_name.Text = "" OrElse tb_given_name.Text = "" OrElse tb_middle_name.Text = "" OrElse tb_course.Text = "" OrElse cb_civil_status.Text = "" Then
            MessageBox.Show("Some fields are missing or with incorrect values. Please recheck.")
        Else

            Dim approve As DialogResult = MessageBox.Show("Are the data finalized?", "Confimation", MessageBoxButtons.YesNo)
            If approve = DialogResult.Yes Then
                Dim db As New DBConn
                db.Open()

                Dim cmd = db.cmd
                cmd.Connection = db.conn

                cmd.CommandText = "INSERT INTO students (family_name, given_name, middle_name, course, ""EdAt_Elem"", ""EdAt_HS"", ""EdAt_Vocational"", ""EdAt_College"", occupation, present_job, occupation_address, employer, spouse_occupation, contact_number, home_address, ""DOB"", age, civil_status)
                                    VALUES (@fn,@gn,@mn,@course,@ee,@eh,@ev,@ec,@o,@pj,@oa,@e,@so,@cn,@ha,@DOB,@age,@cs)"
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
                cmd.Parameters.AddWithValue("@cs", cb_civil_status.SelectedItem)
                Try
                    If cmd.ExecuteNonQuery Then
                        MessageBox.Show("Student successfully enrolled!.")
                        ClearRecords()
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

    Private Sub LoadAllRecord()
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT id as ""ID#"", CONCAT(given_name,' ',middle_name,' ',family_name) as ""Name of Student"", age as ""Age"", ""DOB"" as ""Date of Birth"", course as ""Course"", contact_number as ""Mobile #"", civil_status as ""Civil Status"", home_address as ""Address"" FROM students ORDER BY id ASC"
        Dim da = db.da
        Dim dt = db.dt
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        dgv_main.DataSource = dt
    End Sub

    Private Sub Ageload()
        Dim age As TimeSpan = DateTime.Now - dtp_dob.Value
        Dim calc_age = Int(age.Days / 365)
        If calc_age < 0 Then
            calc_age = 0
        End If
        tb_age.Text = calc_age.ToString()
    End Sub

    Private Sub ClearRecords()
        tb_address.Clear()
        tb_contact_number.Clear()
        tb_course.Clear()
        tb_edat_college.Clear()
        tb_edat_elem.Clear()
        tb_edat_hs.Clear()
        tb_edat_vocational.Clear()
        tb_employer.Clear()
        tb_family_name.Clear()
        tb_given_name.Clear()
        tb_middle_name.Clear()
        tb_occupation.Clear()
        tb_occupation_address.Clear()
        tb_present_job.Clear()
        tb_spouse_occupation.Clear()
        dtp_dob.Value = DateTime.Now
        cb_civil_status.SelectedIndex = 0
    End Sub

    Private Sub btn_add_item_Click(sender As Object, e As EventArgs) Handles btn_add_item.Click
        Dim a As New Add_Items
        a.ShowDialog()
        LoadFundsTable()
    End Sub

    Private Sub MTC_MAIN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MTC_MAIN.SelectedIndexChanged
        If MTC_MAIN.SelectedTab.Text = "Funds" Then
            LoadFundsTable()
        End If
    End Sub

    Private Sub LoadFundsTable()
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT items.id as ""Item ID#"", items.name as ""Name of Item"", (SELECT sum(ft.added_amount) as ""Total Amount"" FROM items as i JOIN funds_transactions as ft ON ft.item_id = i.id WHERE i.id = items.id) FROM items"
        Dim dt = db.dt
        Dim da = db.da
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        dgv_funds.DataSource = dt
        db.Close()
    End Sub

    Private Sub btn_remove_item_Click(sender As Object, e As EventArgs) Handles btn_remove_item.Click
        Dim selected_id As Integer = dgv_funds.CurrentRow.Cells(0).Value
        If selected_id <> 0 Then
            Dim item_remove As DialogResult = MessageBox.Show("Are you sure you want to delete this item? Please take not the all the other records relating to this item will also be deleted.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If item_remove = DialogResult.Yes Then
                Dim db As New DBConn
                db.Open()
                Dim cmd = db.cmd
                cmd.Connection = db.conn
                cmd.CommandText = "DELETE FROM items WHERE id = @ID"
                cmd.Parameters.AddWithValue("@ID", dgv_funds.CurrentRow.Cells(0).Value)
                Try
                    If cmd.ExecuteNonQuery Then
                        MessageBox.Show("Selected item successfully deleted.")
                        LoadFundsTable()
                    Else
                        MessageBox.Show("Something went wrong. Please try again.")
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                db.Close()
            End If
        Else
            MessageBox.Show("Selected item successfully deleted.", "Delete Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_add_funds_Click(sender As Object, e As EventArgs) Handles btn_add_funds.Click
        Dim selected_id As Integer = dgv_funds.CurrentRow.Cells(0).Value
        Dim a As New Add_Items
        a.Text = "Add Funds"
        a.btn_add_funds.Visible = True
        a.btn_item_add.Visible = False
        a.selected_id = selected_id
        a.tb_name.ReadOnly = True
        a.ShowDialog()
        LoadFundsTable()
    End Sub
End Class
