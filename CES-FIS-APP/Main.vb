Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting
Imports MaterialSkin

Public Class Main
    Public is_admin As Boolean = False
    Private student_id_for_payment As Integer = 0
    Private logout_tab As Boolean = False
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        If Not is_admin Then
            MTC_MAIN.TabPages.RemoveAt(2)
            MTC_MAIN.TabPages.RemoveAt(2)
            MTC_MAIN.TabPages.RemoveAt(2)
            MTC_MAIN.TabPages.RemoveAt(3)
        End If
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

            Dim approve As DialogResult = MessageBox.Show("Are the data finalized?", "Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If approve = DialogResult.Yes Then
                Dim db As New DBConn
                db.Open()

                Dim cmd = db.cmd
                cmd.Connection = db.conn

                cmd.CommandText = "INSERT INTO students (family_name, given_name, middle_name, course, ""EdAt_Elem"", ""EdAt_HS"", ""EdAt_Vocational"", ""EdAt_College"", occupation, present_job, occupation_address, employer, spouse_occupation, contact_number, home_address, ""DOB"", age, civil_status, ""AYE"")
                                    VALUES (@fn,@gn,@mn,@course,@ee,@eh,@ev,@ec,@o,@pj,@oa,@e,@so,@cn,@ha,@DOB,@age,@cs, @AYE)"
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
                cmd.Parameters.AddWithValue("@AYE", cb_aye.SelectedValue.ToString)

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

    Private Sub LoadAllRecord(Optional Q As String = "")
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT id as ""ID#"", CONCAT(given_name,' ',middle_name,' ',family_name) as ""Name of Student"", age as ""Age"", ""DOB"" as ""Date of Birth"", course as ""Course"", contact_number as ""Mobile #"", civil_status as ""Civil Status"", home_address as ""Address"" FROM students WHERE LOWER(CONCAT(given_name,middle_name,family_name,home_address,course,contact_number)) LIKE LOWER('%" + Q + "%') ORDER BY id ASC"
        Dim da = db.da
        Dim dt = db.dt
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        dgv_main.DataSource = dt
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        LoadAllRecord(tb_search.Text)
    End Sub
    Private Sub dgv_main_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv_main.DataSourceChanged
        If dgv_main.Rows.Count <> 0 Then
            btn_update_student_record.Enabled = True
            btn_delete.Enabled = True
        Else
            btn_update_student_record.Enabled = False
            btn_delete.Enabled = False
        End If
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
            Me.Text = "CES - Financial Inventory System - " + MTC_MAIN.SelectedTab.Text
            LoadFundsTable()
        ElseIf MTC_MAIN.SelectedTab.Text = "Payment" Then
            Me.Text = "CES - Financial Inventory System - " + MTC_MAIN.SelectedTab.Text
            LoadPaymentStudentList()
            PaymentDetailsDesign()
            LoadPaymentsTable(student_id_for_payment)
        ElseIf MTC_MAIN.SelectedTab.Text = "Expenses" Then
            Me.Text = "CES - Financial Inventory System - " + MTC_MAIN.SelectedTab.Text
            ResetDate()
            LoadExpensesTable(all:=True)
            LoadExpenseCardDesign()



        ElseIf MTC_MAIN.SelectedTab.Text = "Reports" Then
            Me.Text = "CES - Financial Inventory System - " + MTC_MAIN.SelectedTab.Text
            ReportsTabDesign()
        ElseIf MTC_MAIN.SelectedTab.Text = "Students" Then
            Me.Text = "CES - Financial Inventory System - " + MTC_MAIN.SelectedTab.Text
            LoadAllRecord()
        ElseIf MTC_MAIN.SelectedTab.Text = "Registration" Then
            Me.Text = "CES - Financial Inventory System - " + MTC_MAIN.SelectedTab.Text
            cb_aye.Items.Clear()
            For yr = Int(Date.Now.Year) To 1980 Step -1
                cb_aye.Items.Add(yr)
            Next
            cb_aye.SelectedIndex = 0

        ElseIf MTC_MAIN.SelectedTab.Text = "Accounts" Then
            Me.Text = "CES - Financial Inventory System - " + MTC_MAIN.SelectedTab.Text
            AccountsTabDesign()
            Load_Current_Account_Records()
        End If
    End Sub
    Private Sub MTC_MAIN_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles MTC_MAIN.Selecting
        If Me.MTC_MAIN.SelectedTab Is tp8 Then
            Dim lc As DialogResult = MessageBox.Show("Are you sure you want to logout of the application?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not lc = DialogResult.Yes Then
                e.Cancel = True
                logout_tab = False
            Else
                logout_tab = True
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not logout_tab Then
            Dim lc As DialogResult = MessageBox.Show("Are you sure you want to logout of the application?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not lc = DialogResult.Yes Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub LoadFundsTable()
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT items.id as ""Item ID#"", items.name as ""Name of Item"", to_char((SELECT sum(ft.added_amount) as ""Amount"" FROM items as i JOIN funds_transactions as ft ON ft.item_id = i.id WHERE i.id = items.id)::DECIMAL,'FM999,999.00')::TEXT as ""Amount"" FROM items"
        Dim dt = db.dt
        Dim da = db.da
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        dgv_funds.DataSource = dt


        Dim dr = db.dr
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            chart_funds.Series.Clear()
            chart_funds.Titles.Clear()
            chart_funds.Titles.Add("Total Fund Amount: ₱" + TotalFundAmount()).Font = New Drawing.Font("Roboto", 20, FontStyle.Regular)
            chart_funds.Series.Add("s1").ChartType = SeriesChartType.Pie
            chart_funds.Series("s1").IsValueShownAsLabel = True
            chart_funds.Series("s1").BorderColor = Color.Black
            While dr.Read
                chart_funds.Series("s1").Points.AddXY(dr.Item("Name of Item"), dr.Item("Amount").ToString())
            End While
        End If
        db.Close()
        TotalFundAmount()
    End Sub


    Private Sub PaymentDetailsDesign()
        lbl_balance_total_value.Font = New Drawing.Font("Roboto", 20, FontStyle.Regular)
        lbl_total_paid_value.Font = New Drawing.Font("Roboto", 20, FontStyle.Regular)
        lbl_remaining_balance_value.Font = New Drawing.Font("Roboto", 20, FontStyle.Regular)
        lbl_payments_made_value.Font = New Drawing.Font("Roboto", 20, FontStyle.Regular)
        lbl_balance_total_value.ForeColor = Color.Blue
        lbl_total_paid_value.ForeColor = Color.Green
        lbl_remaining_balance_value.ForeColor = Color.Red
        lbl_payments_made_value.ForeColor = Color.Chocolate

    End Sub

    Private Sub LoadPaymentStudentList()
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT id, CONCAT(family_name,' ',given_name,' ',middle_name,' - ',course) as ""Student Details"" FROM students ORDER BY family_name ASC"
        Dim da = db.da
        Dim dt = db.dt
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        Dim drow = dt.NewRow
        drow("id") = 0
        drow("Student Details") = "ALL"
        dt.Rows.InsertAt(drow, 0)
        cb_student_list.DataSource = dt
        cb_student_list.ValueMember = "id"
        cb_student_list.DisplayMember = "Student Details"
        db.Close()
    End Sub

    Private Function TotalFundAmount() As String
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT to_char(SUM(added_amount)::DECIMAL,'FM999,999.00')::TEXT as ""Total Amount"" FROM funds_transactions"
        Dim dr = db.dr
        dr = cmd.ExecuteReader
        Dim amount As String = ""
        If dr.HasRows Then
            While dr.Read
                Try
                    amount = dr.Item("Total Amount").ToString()
                Catch ex As Exception
                    amount = 0
                End Try
            End While
        End If
        db.Close()
        Return amount
    End Function

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
                    MessageBox.Show("This item is currently connected to some records in the transaction. If you wish to delete this, delete all of the transaction records that corresponds to this item and try again.", "Delete Constrains", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                db.Close()
            End If
        Else
            MessageBox.Show("No records were selected.", "Delete Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
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

    Private Sub btn_transaction_history_Click(sender As Object, e As EventArgs) Handles btn_transaction_history.Click
        Dim th As New Transaction_History
        th.selected_id = dgv_funds.CurrentRow.Cells(0).Value
        th.ShowDialog()
        LoadFundsTable()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim student_id_to_delete As Integer = dgv_main.CurrentRow.Cells(0).Value
        Dim sdc As DialogResult = MessageBox.Show("Are you sure you want to delete this student record? Please take not the all the other records relating to this will also be deleted.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If sdc = DialogResult.Yes Then
            Dim db As New DBConn
            db.Open()
            Dim cmd = db.cmd
            cmd.Connection = db.conn
            cmd.CommandText = "DELETE FROM studens WHERE id = @ID"
            cmd.Parameters.AddWithValue("@ID", student_id_to_delete)
            Try
                If cmd.ExecuteNonQuery Then
                    MessageBox.Show("Student record has deleted.", "Success")
                Else
                    MessageBox.Show("Something went wrong.", "Failed")
                End If
            Catch ex As Exception
                MessageBox.Show("This student record is currently connected to some records in the payment section. If you wish to delete this, delete all of the payment records that corresponds to this item and try again.", "Delete Constrains", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            db.Close()
        End If
    End Sub

    Private Sub btn_update_student_record_Click(sender As Object, e As EventArgs) Handles btn_update_student_record.Click
        Dim us As New Update_Student
        us.selected_id = dgv_main.CurrentRow.Cells(0).Value
        us.ShowDialog()
        LoadAllRecord()
    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        student_id_for_payment = cb_student_list.SelectedValue
        LoadPaymentsTable(student_id_for_payment)
    End Sub
    Private Sub LoadPaymentsTable(id As Integer)
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        If id <> 0 Then
            cmd.CommandText = "SELECT id as ""Payment ID#"", to_char(amount::DECIMAL,'FM999,999.00')::TEXT as ""Amount Paid"", date as ""Payment Date"" FROM payments WHERE payor_id=@PID"
            cmd.Parameters.AddWithValue("@PID", id)
            btn_set_balance.Visible = True
            card_remaining_balance.Visible = True
            card_balance_total.Visible = True
            btn_pay.Visible = True
        Else
            cmd.CommandText = "SELECT id as ""Payment ID#"",(SELECT CONCAT(family_name,' ',given_name,' ',middle_name) as ""NAME"" FROM students WHERE id=payments.payor_id), to_char(amount::DECIMAL,'FM999,999.00')::TEXT as ""Amount Paid"", date as ""Payment Date"" FROM payments"
            btn_set_balance.Visible = False
            card_remaining_balance.Visible = False
            card_balance_total.Visible = False
            btn_pay.Visible = False

        End If
        Dim da = db.da
        Dim dt = db.dt
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        dgv_payments.DataSource = dt
        db.Close()

        Dim pic As New Payment_Info_Class
        pic.selected_id = id
        If id <> 0 Then
            For Each item As DataRow In pic.LoadAllInfo().Rows

                lbl_balance_total_value.Text = "₱" + Double.Parse(If(item("Total Payment") IsNot DBNull.Value, item("Total Payment"), 0)).ToString("N2")
                lbl_payments_made_value.Text = If(item("Number of Payment") IsNot DBNull.Value, item("Number of Payment"), 0).ToString
                lbl_remaining_balance_value.Text = "₱" + Double.Parse(If(item("Difference") IsNot DBNull.Value, item("Difference"), 0)).ToString("N2")
                lbl_total_paid_value.Text = "₱" + Double.Parse(If(item("Total Paid") IsNot DBNull.Value, item("Total Paid"), 0)).ToString("N2")
                If dgv_payments.Rows.Count <> 0 Then
                    btn_delete_payment_record.Visible = True
                Else
                    btn_delete_payment_record.Visible = False
                End If
            Next
        Else
            For Each item As DataRow In pic.LoadAllInfo().Rows
                lbl_payments_made_value.Text = If(item("Number of Payment") IsNot DBNull.Value, item("Number of Payment"), 0).ToString
                lbl_total_paid_value.Text = "₱" + Double.Parse(If(item("Total Paid") IsNot DBNull.Value, item("Total Paid"), 0)).ToString("N2")
            Next
        End If
    End Sub

    Private Sub btn_set_balance_Click(sender As Object, e As EventArgs) Handles btn_set_balance.Click
        Dim sb As New Student_Balance
        sb.selected_id = cb_student_list.SelectedValue
        sb.ShowDialog()
        LoadPaymentsTable(student_id_for_payment)
    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click
        If student_id_for_payment <> 0 Then
            Dim sb As New Student_Balance
            sb.Text = "New Payment"
            sb.lbl_student_balance.Text = "Payment Amount:"
            sb.btn_pay_new.Visible = True
            sb.btn_update_balance.Visible = False
            sb.for_payment = True
            sb.selected_id = cb_student_list.SelectedValue
            sb.ShowDialog()
            LoadPaymentsTable(student_id_for_payment)
        Else
            MessageBox.Show("You need to select a record first and press the select button to proceed.", "Error selection.")
        End If
    End Sub

    Private Sub btn_delete_payment_record_Click(sender As Object, e As EventArgs) Handles btn_delete_payment_record.Click
        Dim paydel As DialogResult = MessageBox.Show("Are you sure you want to delete this payment record? Please take not that this cannot be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If paydel = DialogResult.Yes Then
            Dim db As New DBConn
            Dim cmd = db.cmd
            db.Open()
            cmd.Connection = db.conn
            cmd.CommandText = "DELETE FROM payments WHERE id = @ID"
            cmd.Parameters.AddWithValue("@ID", dgv_payments.CurrentRow.Cells(0).Value)
            If cmd.ExecuteNonQuery Then
                MessageBox.Show("Payment record successfully deleted.")
                LoadPaymentsTable(student_id_for_payment)
            End If
            db.Close()
        End If
    End Sub

    Private Sub LoadExpensesTable(Optional all As Boolean = False)
        Dim date_from As Date = dtp_expenses_date_filter_before.Value.Date
        Dim date_to As Date = dtp_expenses_date_filter_after.Value.Date
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        Dim QS As String = "SET datestyle = dmy;SELECT id as ""Record ID#"", description as ""Description"", to_char(amount::DECIMAL,'FM999,999.00')::TEXT as ""Amount"", date as ""Date"" FROM expenses WHERE date >= '" + date_from + "' AND date <= '" + date_to + "' ORDER BY id DESC"
        If all Then
            QS = "SET datestyle = dmy;SELECT id as ""Record ID#"", description as ""Description"", to_char(amount::DECIMAL,'FM999,999.00')::TEXT as ""Amount"", date as ""Date"" FROM expenses ORDER BY id DESC"
        End If
        cmd.CommandText = QS

        Dim da = db.da
        Dim dt = db.dt
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        dgv_expenses.DataSource = dt
        db.Close()

        LoadTotalExpense(all:=If(all, True, False))
    End Sub

    Private Sub LoadTotalExpense(Optional all As Boolean = False)
        Dim date_from As Date = dtp_expenses_date_filter_before.Value.Date
        Dim date_to As Date = dtp_expenses_date_filter_after.Value.Date

        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        If all Then
            cmd.CommandText = "SET datestyle = dmy;SELECT to_char(SUM(amount)::DECIMAL,'FM999,999.00')::TEXT as ""Total"", (SELECT to_char(SUM(added_amount)::DECIMAL,'FM999,999.00')::TEXT as ""FundsTotal"" FROM funds_transactions) FROM expenses"
        Else
            cmd.CommandText = "SET datestyle = dmy;SELECT to_char(SUM(amount)::DECIMAL,'FM999,999.00')::TEXT as ""Total"", (SELECT to_char(SUM(added_amount)::DECIMAL,'FM999,999.00')::TEXT as ""FundsTotal"" FROM funds_transactions) FROM expenses WHERE date >= '" + date_from + "' AND date <= '" + date_to + "'"
        End If

        Dim dr = db.dr
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Dim bae As String = If(dr.Item("FundsTotal") IsNot DBNull.Value, dr.Item("FundsTotal"), 0).ToString()
                Dim exp_total As String = If(dr.Item("Total") IsNot DBNull.Value, dr.Item("Total"), 0).ToString()
                Dim diff As Double = Double.Parse(bae) - Double.Parse(exp_total)
                lbl_expense_total_value.Text = "₱" + exp_total
                lbl_bae.Text = "₱" + diff.ToString("N2")
            End While
        End If
        db.Close()
    End Sub

    Private Sub LoadExpenseCardDesign()
        lbl_expense_total_value.Font = New Drawing.Font("Roboto", 20, FontStyle.Regular)
        lbl_expense_total_value.ForeColor = Color.Green
        lbl_bae.Font = New Drawing.Font("Roboto", 15, FontStyle.Underline)
        lbl_bae.ForeColor = Color.Red

    End Sub

    Private Sub xpenses_add_Click(sender As Object, e As EventArgs) Handles btn_expenses_add.Click
        If tb_expenses_amount.Text <> "" AndAlso tb_expenses_desc.Text <> "" Then
            Dim db As New DBConn
            db.Open()
            Dim cmd = db.cmd
            cmd.Connection = db.conn
            cmd.CommandText = "INSERT INTO expenses (description, amount, date) VALUES (@DESC, @AMOUNT, @DATE)"
            cmd.Parameters.AddWithValue("@DESC", tb_expenses_desc.Text)
            cmd.Parameters.AddWithValue("@AMOUNT", Double.Parse(tb_expenses_amount.Text))
            cmd.Parameters.AddWithValue("@DATE", dtp_expenses_date.Value.Date)
            If cmd.ExecuteNonQuery Then
                MessageBox.Show("New expense record was saved.", "Success")
                tb_expenses_amount.Clear()
                tb_expenses_desc.Clear()
                dtp_expenses_date.Value = DateTime.Now.Date
                LoadExpensesTable()
            Else
                MessageBox.Show("Something went wrong.", "Failed")
            End If
            db.Close()
        End If
    End Sub

    Private Sub tb_expenses_amount_TextChanged(sender As Object, e As EventArgs) Handles tb_expenses_amount.TextChanged
        If IsNumeric(tb_expenses_amount.Text) Then
            btn_expenses_add.Enabled = True
        Else
            btn_expenses_add.Enabled = False
        End If
    End Sub

    Private Sub btn_expenses_delete_Click(sender As Object, e As EventArgs) Handles btn_expenses_delete.Click
        Dim exr As DialogResult = MessageBox.Show("Are you sure you want to delete this expense record? Please take not that this cannot be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If exr = DialogResult.Yes Then
            Dim db As New DBConn
            db.Open()
            Dim cmd = db.cmd
            cmd.Connection = db.conn
            cmd.CommandText = "DELETE FROM expenses WHERE id = @ID"
            cmd.Parameters.AddWithValue("@ID", dgv_expenses.CurrentRow.Cells(0).Value)
            If cmd.ExecuteNonQuery Then
                MessageBox.Show("Selected record successfully deleted.")
                Me.LoadExpensesTable()
            Else
                MessageBox.Show("Something went wrong. Please try again.")
            End If
            db.Close()
        End If
    End Sub

    Private Sub dgv_expenses_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv_expenses.DataSourceChanged
        If dgv_expenses.Rows.Count <> 0 Then
            btn_expenses_delete.Enabled = True
        Else
            btn_expenses_delete.Enabled = False
        End If
    End Sub

    Private Sub btn_expenses_reset_Click(sender As Object, e As EventArgs) Handles btn_expenses_reset.Click
        ResetDate()
    End Sub

    Private Sub ResetDate()
        dtp_expenses_date_filter_before.Value = DateTime.Now.Date
        dtp_expenses_date_filter_after.Value = DateTime.Now.Date
        LoadExpensesTable(all:=True)

    End Sub

    Private Sub btn_expenses_date_filter_Click(sender As Object, e As EventArgs) Handles btn_expenses_date_filter.Click
        LoadExpensesTable()
    End Sub
    Private Sub ReportsTabDesign()
        lbl_reports_main.Font = New Drawing.Font("Comic Sans", 20, FontStyle.Bold)
        lbl_reports_main.ForeColor = Color.Black
    End Sub

    Private Sub btn_generate_report_Click(sender As Object, e As EventArgs) Handles btn_generate_report.Click
        If cb_reports.SelectedItem = "Cash In" Then
            Dim rc As New Report_Class
            rc.From_Date = dtp_reports_from.Value.Date
            rc.To_Date = dtp_reports_to.Value.Date
            Dim rf As New Report_Form
            Dim report As New CR_CashIn
            report.SetDataSource(rc.GenerateFunds)
            report.SetParameterValue("Date_Range", dtp_reports_from.Value.Date.ToShortDateString + " - " + dtp_reports_to.Value.Date.ToShortDateString)
            rf.CrystalReportViewer1.ReportSource = report
            rf.ShowDialog()
        ElseIf cb_reports.SelectedItem = "Cash Out" Then
            Dim rc As New Report_Class
            rc.From_Date = dtp_reports_from.Value.Date
            rc.To_Date = dtp_reports_to.Value.Date
            Dim rf As New Report_Form
            Dim report As New CR_Cashout
            report.SetDataSource(rc.GenerateExpenses)
            report.SetParameterValue("Date_Range", dtp_reports_from.Value.Date.ToShortDateString + " - " + dtp_reports_to.Value.Date.ToShortDateString)
            rf.CrystalReportViewer1.ReportSource = report
            rf.ShowDialog()
        Else
            Dim rc As New Report_Class
            rc.From_Date = dtp_reports_from.Value.Date
            rc.To_Date = dtp_reports_to.Value.Date
            Dim vals = rc.GenerateCashBalance
            Dim cashin = If(vals(0) = "", 0, vals(0))
            Dim cashout = If(vals(1) = "", 0, vals(1))

            Dim rf As New Report_Form
            Dim report As New CR_CashBalance
            report.SetParameterValue("DateRange", dtp_reports_from.Value.Date.ToShortDateString + " - " + dtp_reports_to.Value.Date.ToShortDateString)
            report.SetParameterValue("Total_CashIN", cashin)
            report.SetParameterValue("Total_CashOUT", cashout)
            report.SetParameterValue("CashBalance", (Double.Parse(cashin) - Double.Parse(cashout)).ToString())

            rf.CrystalReportViewer1.ReportSource = report
            rf.ShowDialog()
        End If

    End Sub

    Private Sub btn_accounts_admin_update_Click(sender As Object, e As EventArgs) Handles btn_accounts_admin_update.Click
        If tb_admin_current_password.Text = "" OrElse tb_admin_new_password.Text = "" OrElse tb_admin_username.Text = "" Then
            MessageBox.Show("All fields must have a data. Please try again.")
        Else
            Dim ccaa As DialogResult = MessageBox.Show("Are you sure you want to edit the admin account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ccaa = DialogResult.Yes Then
                Dim uac As New Update_Account_Class
                uac._Username = tb_admin_username.Text
                Dim enp As New encrypt
                enp.hashProp = tb_admin_new_password.Text
                Dim enp2 As New encrypt
                enp2.hashProp = tb_admin_current_password.Text
                uac._Password = enp.hashProp
                uac._Password2 = enp2.hashProp
                uac._Raw_Password = tb_admin_new_password.Text

                If uac.Confirm_Password Then
                    uac.Update_Account("Admin")
                    Load_Current_Account_Records()
                Else
                    MessageBox.Show("Failed to verify the current admin password. Please try again.", "Confimation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub Load_Current_Account_Records()
        Dim db As New DBConn
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT * FROM users"
        Dim dr = db.dr
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            If Check_Existing_Director() Then
                While dr.Read
                    If Not dr.Item("is_admin") Then
                        tb_director_username.Text = dr.Item("username")
                    Else
                        tb_admin_username.Text = dr.Item("username")
                    End If
                End While
            Else
                While dr.Read
                    tb_admin_username.Text = dr.Item("username")
                End While
            End If
            tb_admin_current_password.Clear()
            tb_admin_new_password.Clear()
            tb_director_current_password.Clear()
            tb_director_new_password.Clear()
        End If
        db.Close()
    End Sub

    Private Function Check_Existing_Director() As Boolean
        Dim uac As New Update_Account_Class
        If uac.Check_Exists_Director Then
            btn_director_update.Visible = True
            lbl_director_current_password.Visible = True
            tb_director_current_password.Visible = True
            btn_set_director.Visible = False
            Return True
        Else
            btn_director_update.Visible = False
            lbl_director_current_password.Visible = False
            tb_director_current_password.Visible = False
            btn_set_director.Visible = True
            Return False
        End If
    End Function

    Private Sub btn_director_update_Click(sender As Object, e As EventArgs) Handles btn_director_update.Click
        If tb_director_current_password.Text = "" OrElse tb_director_new_password.Text = "" OrElse tb_director_username.Text = "" Then
            MessageBox.Show("All fields must have a data. Please try again.")
        Else
            Dim ccda As DialogResult = MessageBox.Show("Are you sure you want to edit the directors account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ccda = DialogResult.Yes Then
                Dim uac As New Update_Account_Class
                uac._Username = tb_director_username.Text
                Dim enp As New encrypt
                enp.hashProp = tb_director_new_password.Text
                Dim enp2 As New encrypt
                enp2.hashProp = tb_director_current_password.Text
                uac._Password = enp.hashProp
                uac._Password2 = enp2.hashProp
                uac._Raw_Password = tb_director_new_password.Text

                If uac.Confirm_Password Then
                    uac.Update_Account("Director")
                    Load_Current_Account_Records()
                Else
                    MessageBox.Show("Failed to verify the current directors password. Please try again.", "Confimation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        End If
    End Sub

    Private Sub btn_set_director_Click(sender As Object, e As EventArgs) Handles btn_set_director.Click
        Dim uac As New Update_Account_Class
        uac._Username = tb_director_username.Text
        Dim enp As New encrypt
        enp.hashProp = tb_director_new_password.Text
        uac._Password = enp.hashProp
        uac._Raw_Password = tb_director_new_password.Text
        uac.Set_Director()
        Load_Current_Account_Records()
    End Sub

    Private Sub AccountsTabDesign()
        lbl_admin_main.Font = New Drawing.Font("Comic Sans", 20, FontStyle.Bold)
        lbl_admin_main.ForeColor = Color.Black
        lbl_director_main.Font = New Drawing.Font("Comic Sans", 20, FontStyle.Bold)
        lbl_director_main.ForeColor = Color.Black
    End Sub

    Private Sub dgv_funds_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv_funds.DataSourceChanged
        If dgv_funds.Rows.Count <> 0 Then
            btn_transaction_history.Enabled = True
            btn_add_funds.Enabled = True
        Else
            btn_transaction_history.Enabled = False
            btn_add_funds.Enabled = False
        End If
    End Sub
End Class
