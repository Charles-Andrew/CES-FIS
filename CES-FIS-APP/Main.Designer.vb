<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.IL_TABS = New System.Windows.Forms.ImageList(Me.components)
        Me.tp2 = New System.Windows.Forms.TabPage()
        Me.gb_enroll = New System.Windows.Forms.GroupBox()
        Me.cb_aye = New MaterialSkin.Controls.MaterialComboBox()
        Me.lbl_aye = New MaterialSkin.Controls.MaterialLabel()
        Me.tb_age = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btn_enroll = New MaterialSkin.Controls.MaterialButton()
        Me.tb_spouse_occupation = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.tb_employer = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.tb_occupation_address = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.tb_present_job = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.tb_occupation = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.tb_edat_vocational = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.tb_edat_college = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.tb_edat_hs = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.tb_edat_elem = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.lbl_so = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_employer = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_oa = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_first_job = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_occupation = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_eav = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_eac = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_eah = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_eae = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_ea = New MaterialSkin.Controls.MaterialLabel()
        Me.tb_course = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.lbl_course = New MaterialSkin.Controls.MaterialLabel()
        Me.tb_contact_number = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.lbl_contact_number = New MaterialSkin.Controls.MaterialLabel()
        Me.tb_address = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.lbl_address = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_age = New MaterialSkin.Controls.MaterialLabel()
        Me.dtp_dob = New System.Windows.Forms.DateTimePicker()
        Me.lbl_DOB = New MaterialSkin.Controls.MaterialLabel()
        Me.cb_civil_status = New MaterialSkin.Controls.MaterialComboBox()
        Me.lbl_civil_status = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_family_name = New MaterialSkin.Controls.MaterialLabel()
        Me.tb_family_name = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.lbl_student_middle_name = New MaterialSkin.Controls.MaterialLabel()
        Me.tb_middle_name = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.lbl_student_name = New MaterialSkin.Controls.MaterialLabel()
        Me.tb_given_name = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.tp3 = New System.Windows.Forms.TabPage()
        Me.gb_payment = New System.Windows.Forms.GroupBox()
        Me.btn_delete_payment_record = New MaterialSkin.Controls.MaterialButton()
        Me.gb_payment_info = New System.Windows.Forms.GroupBox()
        Me.card_remaining_balance = New MaterialSkin.Controls.MaterialCard()
        Me.lbl_remaining_balance_value = New System.Windows.Forms.Label()
        Me.lbl_remaining_balance = New MaterialSkin.Controls.MaterialLabel()
        Me.card_total_paid = New MaterialSkin.Controls.MaterialCard()
        Me.lbl_total_paid_value = New System.Windows.Forms.Label()
        Me.lvl_total_paid = New MaterialSkin.Controls.MaterialLabel()
        Me.card_balance_total = New MaterialSkin.Controls.MaterialCard()
        Me.lbl_balance_total_value = New System.Windows.Forms.Label()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.card_payments_made = New MaterialSkin.Controls.MaterialCard()
        Me.lbl_payments_made_value = New System.Windows.Forms.Label()
        Me.lvl_payment_count = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_pay = New MaterialSkin.Controls.MaterialButton()
        Me.btn_set_balance = New MaterialSkin.Controls.MaterialButton()
        Me.dgv_payments = New System.Windows.Forms.DataGridView()
        Me.btn_select = New MaterialSkin.Controls.MaterialButton()
        Me.cb_student_list = New MaterialSkin.Controls.MaterialComboBox()
        Me.tp1 = New System.Windows.Forms.TabPage()
        Me.btn_update_student_record = New MaterialSkin.Controls.MaterialButton()
        Me.btn_delete = New MaterialSkin.Controls.MaterialButton()
        Me.btn_search = New MaterialSkin.Controls.MaterialButton()
        Me.tb_search = New MaterialSkin.Controls.MaterialTextBox2()
        Me.gb_main = New System.Windows.Forms.GroupBox()
        Me.dgv_main = New System.Windows.Forms.DataGridView()
        Me.MTC_MAIN = New MaterialSkin.Controls.MaterialTabControl()
        Me.tp4 = New System.Windows.Forms.TabPage()
        Me.gb_funds = New System.Windows.Forms.GroupBox()
        Me.chart_funds = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btn_transaction_history = New MaterialSkin.Controls.MaterialButton()
        Me.lbl_manage = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_item = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_remove_item = New MaterialSkin.Controls.MaterialButton()
        Me.btn_add_funds = New MaterialSkin.Controls.MaterialButton()
        Me.btn_add_item = New MaterialSkin.Controls.MaterialButton()
        Me.dgv_funds = New System.Windows.Forms.DataGridView()
        Me.tp5 = New System.Windows.Forms.TabPage()
        Me.gb_expenses = New System.Windows.Forms.GroupBox()
        Me.lbl_bae = New System.Windows.Forms.Label()
        Me.lbl_availablefunds = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_expenses_reset = New MaterialSkin.Controls.MaterialButton()
        Me.btn_expenses_delete = New MaterialSkin.Controls.MaterialButton()
        Me.btn_expenses_date_filter = New MaterialSkin.Controls.MaterialButton()
        Me.dtp_expenses_date_filter_after = New System.Windows.Forms.DateTimePicker()
        Me.dtp_expenses_date_filter_before = New System.Windows.Forms.DateTimePicker()
        Me.lbl_date_to = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_date_from = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.lbl_expense_total_value = New System.Windows.Forms.Label()
        Me.lbl_expense_total = New MaterialSkin.Controls.MaterialLabel()
        Me.tb_expenses_desc = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.dtp_expenses_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_date = New MaterialSkin.Controls.MaterialLabel()
        Me.tb_expenses_amount = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btn_expenses_add = New MaterialSkin.Controls.MaterialButton()
        Me.lbl_expenses_amount = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_expenses_description = New MaterialSkin.Controls.MaterialLabel()
        Me.dgv_expenses = New System.Windows.Forms.DataGridView()
        Me.tp6 = New System.Windows.Forms.TabPage()
        Me.gb_reports = New System.Windows.Forms.GroupBox()
        Me.card_report_generator = New MaterialSkin.Controls.MaterialCard()
        Me.lbl_reports_main = New System.Windows.Forms.Label()
        Me.cb_reports = New MaterialSkin.Controls.MaterialComboBox()
        Me.dtp_reports_from = New System.Windows.Forms.DateTimePicker()
        Me.dtp_reports_to = New System.Windows.Forms.DateTimePicker()
        Me.lbl_reports_from = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_reports_to = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_reports_for = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_generate_report = New MaterialSkin.Controls.MaterialButton()
        Me.tp7 = New System.Windows.Forms.TabPage()
        Me.gb_accounts = New System.Windows.Forms.GroupBox()
        Me.lbl_director_main = New System.Windows.Forms.Label()
        Me.lbl_admin_main = New System.Windows.Forms.Label()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.btn_set_director = New MaterialSkin.Controls.MaterialButton()
        Me.btn_director_update = New MaterialSkin.Controls.MaterialButton()
        Me.tb_director_current_password = New MaterialSkin.Controls.MaterialTextBox2()
        Me.tb_director_new_password = New MaterialSkin.Controls.MaterialTextBox2()
        Me.tb_director_username = New MaterialSkin.Controls.MaterialTextBox2()
        Me.lbl_director_current_password = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_director_password = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_director_username = New MaterialSkin.Controls.MaterialLabel()
        Me.card_accounts_admin = New MaterialSkin.Controls.MaterialCard()
        Me.btn_accounts_admin_update = New MaterialSkin.Controls.MaterialButton()
        Me.tb_admin_current_password = New MaterialSkin.Controls.MaterialTextBox2()
        Me.tb_admin_new_password = New MaterialSkin.Controls.MaterialTextBox2()
        Me.tb_admin_username = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.tp8 = New System.Windows.Forms.TabPage()
        Me.tp2.SuspendLayout()
        Me.gb_enroll.SuspendLayout()
        Me.tp3.SuspendLayout()
        Me.gb_payment.SuspendLayout()
        Me.gb_payment_info.SuspendLayout()
        Me.card_remaining_balance.SuspendLayout()
        Me.card_total_paid.SuspendLayout()
        Me.card_balance_total.SuspendLayout()
        Me.card_payments_made.SuspendLayout()
        CType(Me.dgv_payments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp1.SuspendLayout()
        Me.gb_main.SuspendLayout()
        CType(Me.dgv_main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MTC_MAIN.SuspendLayout()
        Me.tp4.SuspendLayout()
        Me.gb_funds.SuspendLayout()
        CType(Me.chart_funds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_funds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp5.SuspendLayout()
        Me.gb_expenses.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        CType(Me.dgv_expenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp6.SuspendLayout()
        Me.gb_reports.SuspendLayout()
        Me.card_report_generator.SuspendLayout()
        Me.tp7.SuspendLayout()
        Me.gb_accounts.SuspendLayout()
        Me.MaterialCard3.SuspendLayout()
        Me.card_accounts_admin.SuspendLayout()
        Me.SuspendLayout()
        '
        'IL_TABS
        '
        Me.IL_TABS.ImageStream = CType(resources.GetObject("IL_TABS.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL_TABS.TransparentColor = System.Drawing.Color.Transparent
        Me.IL_TABS.Images.SetKeyName(0, "students.png")
        Me.IL_TABS.Images.SetKeyName(1, "contract.png")
        Me.IL_TABS.Images.SetKeyName(2, "payment-method.png")
        Me.IL_TABS.Images.SetKeyName(3, "money.png")
        Me.IL_TABS.Images.SetKeyName(4, "report.png")
        Me.IL_TABS.Images.SetKeyName(5, "expenses.png")
        Me.IL_TABS.Images.SetKeyName(6, "power-off.png")
        Me.IL_TABS.Images.SetKeyName(7, "account.png")
        '
        'tp2
        '
        Me.tp2.Controls.Add(Me.gb_enroll)
        Me.tp2.ImageKey = "contract.png"
        Me.tp2.Location = New System.Drawing.Point(4, 39)
        Me.tp2.Name = "tp2"
        Me.tp2.Padding = New System.Windows.Forms.Padding(3)
        Me.tp2.Size = New System.Drawing.Size(986, 490)
        Me.tp2.TabIndex = 2
        Me.tp2.Text = "Registration"
        Me.tp2.UseVisualStyleBackColor = True
        '
        'gb_enroll
        '
        Me.gb_enroll.BackColor = System.Drawing.Color.White
        Me.gb_enroll.Controls.Add(Me.cb_aye)
        Me.gb_enroll.Controls.Add(Me.lbl_aye)
        Me.gb_enroll.Controls.Add(Me.tb_age)
        Me.gb_enroll.Controls.Add(Me.btn_enroll)
        Me.gb_enroll.Controls.Add(Me.tb_spouse_occupation)
        Me.gb_enroll.Controls.Add(Me.tb_employer)
        Me.gb_enroll.Controls.Add(Me.tb_occupation_address)
        Me.gb_enroll.Controls.Add(Me.tb_present_job)
        Me.gb_enroll.Controls.Add(Me.tb_occupation)
        Me.gb_enroll.Controls.Add(Me.tb_edat_vocational)
        Me.gb_enroll.Controls.Add(Me.tb_edat_college)
        Me.gb_enroll.Controls.Add(Me.tb_edat_hs)
        Me.gb_enroll.Controls.Add(Me.tb_edat_elem)
        Me.gb_enroll.Controls.Add(Me.lbl_so)
        Me.gb_enroll.Controls.Add(Me.lbl_employer)
        Me.gb_enroll.Controls.Add(Me.lbl_oa)
        Me.gb_enroll.Controls.Add(Me.lbl_first_job)
        Me.gb_enroll.Controls.Add(Me.lbl_occupation)
        Me.gb_enroll.Controls.Add(Me.lbl_eav)
        Me.gb_enroll.Controls.Add(Me.lbl_eac)
        Me.gb_enroll.Controls.Add(Me.lbl_eah)
        Me.gb_enroll.Controls.Add(Me.lbl_eae)
        Me.gb_enroll.Controls.Add(Me.lbl_ea)
        Me.gb_enroll.Controls.Add(Me.tb_course)
        Me.gb_enroll.Controls.Add(Me.lbl_course)
        Me.gb_enroll.Controls.Add(Me.tb_contact_number)
        Me.gb_enroll.Controls.Add(Me.lbl_contact_number)
        Me.gb_enroll.Controls.Add(Me.tb_address)
        Me.gb_enroll.Controls.Add(Me.lbl_address)
        Me.gb_enroll.Controls.Add(Me.lbl_age)
        Me.gb_enroll.Controls.Add(Me.dtp_dob)
        Me.gb_enroll.Controls.Add(Me.lbl_DOB)
        Me.gb_enroll.Controls.Add(Me.cb_civil_status)
        Me.gb_enroll.Controls.Add(Me.lbl_civil_status)
        Me.gb_enroll.Controls.Add(Me.lbl_family_name)
        Me.gb_enroll.Controls.Add(Me.tb_family_name)
        Me.gb_enroll.Controls.Add(Me.lbl_student_middle_name)
        Me.gb_enroll.Controls.Add(Me.tb_middle_name)
        Me.gb_enroll.Controls.Add(Me.lbl_student_name)
        Me.gb_enroll.Controls.Add(Me.tb_given_name)
        Me.gb_enroll.Dock = System.Windows.Forms.DockStyle.Left
        Me.gb_enroll.Location = New System.Drawing.Point(3, 3)
        Me.gb_enroll.Name = "gb_enroll"
        Me.gb_enroll.Size = New System.Drawing.Size(931, 484)
        Me.gb_enroll.TabIndex = 0
        Me.gb_enroll.TabStop = False
        '
        'cb_aye
        '
        Me.cb_aye.AutoResize = False
        Me.cb_aye.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_aye.Depth = 0
        Me.cb_aye.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cb_aye.DropDownHeight = 174
        Me.cb_aye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_aye.DropDownWidth = 121
        Me.cb_aye.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cb_aye.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cb_aye.FormattingEnabled = True
        Me.cb_aye.IntegralHeight = False
        Me.cb_aye.ItemHeight = 43
        Me.cb_aye.Location = New System.Drawing.Point(585, 58)
        Me.cb_aye.MaxDropDownItems = 4
        Me.cb_aye.MouseState = MaterialSkin.MouseState.OUT
        Me.cb_aye.Name = "cb_aye"
        Me.cb_aye.Size = New System.Drawing.Size(121, 49)
        Me.cb_aye.StartIndex = 0
        Me.cb_aye.TabIndex = 41
        '
        'lbl_aye
        '
        Me.lbl_aye.AutoSize = True
        Me.lbl_aye.Depth = 0
        Me.lbl_aye.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_aye.Location = New System.Drawing.Point(385, 61)
        Me.lbl_aye.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_aye.Name = "lbl_aye"
        Me.lbl_aye.Size = New System.Drawing.Size(172, 19)
        Me.lbl_aye.TabIndex = 40
        Me.lbl_aye.Text = "Academic Year Enrolled:"
        '
        'tb_age
        '
        Me.tb_age.AnimateReadOnly = False
        Me.tb_age.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_age.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_age.Depth = 0
        Me.tb_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_age.HideSelection = True
        Me.tb_age.LeadingIcon = Nothing
        Me.tb_age.Location = New System.Drawing.Point(115, 218)
        Me.tb_age.MaxLength = 32767
        Me.tb_age.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_age.Name = "tb_age"
        Me.tb_age.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_age.PrefixSuffixText = Nothing
        Me.tb_age.ReadOnly = True
        Me.tb_age.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_age.SelectedText = ""
        Me.tb_age.SelectionLength = 0
        Me.tb_age.SelectionStart = 0
        Me.tb_age.ShortcutsEnabled = True
        Me.tb_age.Size = New System.Drawing.Size(51, 48)
        Me.tb_age.TabIndex = 39
        Me.tb_age.TabStop = False
        Me.tb_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_age.TrailingIcon = Nothing
        Me.tb_age.UseSystemPasswordChar = False
        '
        'btn_enroll
        '
        Me.btn_enroll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_enroll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_enroll.Depth = 0
        Me.btn_enroll.HighEmphasis = True
        Me.btn_enroll.Icon = Nothing
        Me.btn_enroll.Location = New System.Drawing.Point(398, 455)
        Me.btn_enroll.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_enroll.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_enroll.Name = "btn_enroll"
        Me.btn_enroll.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_enroll.Size = New System.Drawing.Size(76, 36)
        Me.btn_enroll.TabIndex = 38
        Me.btn_enroll.Text = "Register"
        Me.btn_enroll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_enroll.UseAccentColor = False
        Me.btn_enroll.UseVisualStyleBackColor = True
        '
        'tb_spouse_occupation
        '
        Me.tb_spouse_occupation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_spouse_occupation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_spouse_occupation.Depth = 0
        Me.tb_spouse_occupation.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_spouse_occupation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_spouse_occupation.Location = New System.Drawing.Point(559, 419)
        Me.tb_spouse_occupation.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_spouse_occupation.Name = "tb_spouse_occupation"
        Me.tb_spouse_occupation.Size = New System.Drawing.Size(351, 29)
        Me.tb_spouse_occupation.TabIndex = 37
        Me.tb_spouse_occupation.Text = ""
        '
        'tb_employer
        '
        Me.tb_employer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_employer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_employer.Depth = 0
        Me.tb_employer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_employer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_employer.Location = New System.Drawing.Point(559, 384)
        Me.tb_employer.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_employer.Name = "tb_employer"
        Me.tb_employer.Size = New System.Drawing.Size(351, 29)
        Me.tb_employer.TabIndex = 36
        Me.tb_employer.Text = ""
        '
        'tb_occupation_address
        '
        Me.tb_occupation_address.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_occupation_address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_occupation_address.Depth = 0
        Me.tb_occupation_address.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_occupation_address.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_occupation_address.Location = New System.Drawing.Point(559, 349)
        Me.tb_occupation_address.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_occupation_address.Name = "tb_occupation_address"
        Me.tb_occupation_address.Size = New System.Drawing.Size(351, 29)
        Me.tb_occupation_address.TabIndex = 35
        Me.tb_occupation_address.Text = ""
        '
        'tb_present_job
        '
        Me.tb_present_job.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_present_job.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_present_job.Depth = 0
        Me.tb_present_job.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_present_job.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_present_job.Location = New System.Drawing.Point(559, 314)
        Me.tb_present_job.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_present_job.Name = "tb_present_job"
        Me.tb_present_job.Size = New System.Drawing.Size(351, 29)
        Me.tb_present_job.TabIndex = 34
        Me.tb_present_job.Text = ""
        '
        'tb_occupation
        '
        Me.tb_occupation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_occupation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_occupation.Depth = 0
        Me.tb_occupation.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_occupation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_occupation.Location = New System.Drawing.Point(559, 279)
        Me.tb_occupation.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_occupation.Name = "tb_occupation"
        Me.tb_occupation.Size = New System.Drawing.Size(351, 29)
        Me.tb_occupation.TabIndex = 33
        Me.tb_occupation.Text = ""
        '
        'tb_edat_vocational
        '
        Me.tb_edat_vocational.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_edat_vocational.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_edat_vocational.Depth = 0
        Me.tb_edat_vocational.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_edat_vocational.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_edat_vocational.Location = New System.Drawing.Point(585, 240)
        Me.tb_edat_vocational.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_edat_vocational.Name = "tb_edat_vocational"
        Me.tb_edat_vocational.Size = New System.Drawing.Size(325, 29)
        Me.tb_edat_vocational.TabIndex = 32
        Me.tb_edat_vocational.Text = ""
        '
        'tb_edat_college
        '
        Me.tb_edat_college.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_edat_college.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_edat_college.Depth = 0
        Me.tb_edat_college.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_edat_college.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_edat_college.Location = New System.Drawing.Point(585, 205)
        Me.tb_edat_college.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_edat_college.Name = "tb_edat_college"
        Me.tb_edat_college.Size = New System.Drawing.Size(325, 29)
        Me.tb_edat_college.TabIndex = 31
        Me.tb_edat_college.Text = ""
        '
        'tb_edat_hs
        '
        Me.tb_edat_hs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_edat_hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_edat_hs.Depth = 0
        Me.tb_edat_hs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_edat_hs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_edat_hs.Location = New System.Drawing.Point(585, 170)
        Me.tb_edat_hs.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_edat_hs.Name = "tb_edat_hs"
        Me.tb_edat_hs.Size = New System.Drawing.Size(325, 29)
        Me.tb_edat_hs.TabIndex = 30
        Me.tb_edat_hs.Text = ""
        '
        'tb_edat_elem
        '
        Me.tb_edat_elem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_edat_elem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_edat_elem.Depth = 0
        Me.tb_edat_elem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_edat_elem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_edat_elem.Location = New System.Drawing.Point(585, 135)
        Me.tb_edat_elem.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_edat_elem.Name = "tb_edat_elem"
        Me.tb_edat_elem.Size = New System.Drawing.Size(325, 29)
        Me.tb_edat_elem.TabIndex = 29
        Me.tb_edat_elem.Text = ""
        '
        'lbl_so
        '
        Me.lbl_so.AutoSize = True
        Me.lbl_so.Depth = 0
        Me.lbl_so.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_so.Location = New System.Drawing.Point(385, 419)
        Me.lbl_so.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_so.Name = "lbl_so"
        Me.lbl_so.Size = New System.Drawing.Size(143, 19)
        Me.lbl_so.TabIndex = 28
        Me.lbl_so.Text = "Spouse Occupation:"
        '
        'lbl_employer
        '
        Me.lbl_employer.AutoSize = True
        Me.lbl_employer.Depth = 0
        Me.lbl_employer.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_employer.Location = New System.Drawing.Point(385, 384)
        Me.lbl_employer.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_employer.Name = "lbl_employer"
        Me.lbl_employer.Size = New System.Drawing.Size(71, 19)
        Me.lbl_employer.TabIndex = 27
        Me.lbl_employer.Text = "Employer:"
        '
        'lbl_oa
        '
        Me.lbl_oa.AutoSize = True
        Me.lbl_oa.Depth = 0
        Me.lbl_oa.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_oa.Location = New System.Drawing.Point(385, 349)
        Me.lbl_oa.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_oa.Name = "lbl_oa"
        Me.lbl_oa.Size = New System.Drawing.Size(147, 19)
        Me.lbl_oa.TabIndex = 26
        Me.lbl_oa.Text = "Occupation Address:"
        '
        'lbl_first_job
        '
        Me.lbl_first_job.AutoSize = True
        Me.lbl_first_job.Depth = 0
        Me.lbl_first_job.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_first_job.Location = New System.Drawing.Point(385, 314)
        Me.lbl_first_job.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_first_job.Name = "lbl_first_job"
        Me.lbl_first_job.Size = New System.Drawing.Size(89, 19)
        Me.lbl_first_job.TabIndex = 25
        Me.lbl_first_job.Text = "Present Job:"
        '
        'lbl_occupation
        '
        Me.lbl_occupation.AutoSize = True
        Me.lbl_occupation.Depth = 0
        Me.lbl_occupation.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_occupation.Location = New System.Drawing.Point(385, 279)
        Me.lbl_occupation.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_occupation.Name = "lbl_occupation"
        Me.lbl_occupation.Size = New System.Drawing.Size(86, 19)
        Me.lbl_occupation.TabIndex = 24
        Me.lbl_occupation.Text = "Occupation:"
        '
        'lbl_eav
        '
        Me.lbl_eav.AutoSize = True
        Me.lbl_eav.Depth = 0
        Me.lbl_eav.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_eav.Location = New System.Drawing.Point(415, 235)
        Me.lbl_eav.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_eav.Name = "lbl_eav"
        Me.lbl_eav.Size = New System.Drawing.Size(81, 19)
        Me.lbl_eav.TabIndex = 23
        Me.lbl_eav.Text = "Vocational:"
        '
        'lbl_eac
        '
        Me.lbl_eac.AutoSize = True
        Me.lbl_eac.Depth = 0
        Me.lbl_eac.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_eac.Location = New System.Drawing.Point(415, 203)
        Me.lbl_eac.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_eac.Name = "lbl_eac"
        Me.lbl_eac.Size = New System.Drawing.Size(57, 19)
        Me.lbl_eac.TabIndex = 22
        Me.lbl_eac.Text = "College:"
        '
        'lbl_eah
        '
        Me.lbl_eah.AutoSize = True
        Me.lbl_eah.Depth = 0
        Me.lbl_eah.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_eah.Location = New System.Drawing.Point(415, 173)
        Me.lbl_eah.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_eah.Name = "lbl_eah"
        Me.lbl_eah.Size = New System.Drawing.Size(91, 19)
        Me.lbl_eah.TabIndex = 21
        Me.lbl_eah.Text = "High School:"
        '
        'lbl_eae
        '
        Me.lbl_eae.AutoSize = True
        Me.lbl_eae.Depth = 0
        Me.lbl_eae.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_eae.Location = New System.Drawing.Point(415, 137)
        Me.lbl_eae.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_eae.Name = "lbl_eae"
        Me.lbl_eae.Size = New System.Drawing.Size(84, 19)
        Me.lbl_eae.TabIndex = 20
        Me.lbl_eae.Text = "Elementary:"
        '
        'lbl_ea
        '
        Me.lbl_ea.AutoSize = True
        Me.lbl_ea.Depth = 0
        Me.lbl_ea.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_ea.Location = New System.Drawing.Point(385, 116)
        Me.lbl_ea.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_ea.Name = "lbl_ea"
        Me.lbl_ea.Size = New System.Drawing.Size(171, 19)
        Me.lbl_ea.TabIndex = 19
        Me.lbl_ea.Text = "Educational Attainment:"
        '
        'tb_course
        '
        Me.tb_course.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_course.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_course.Depth = 0
        Me.tb_course.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_course.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_course.Location = New System.Drawing.Point(455, 16)
        Me.tb_course.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_course.Name = "tb_course"
        Me.tb_course.Size = New System.Drawing.Size(455, 29)
        Me.tb_course.TabIndex = 18
        Me.tb_course.Text = ""
        '
        'lbl_course
        '
        Me.lbl_course.AutoSize = True
        Me.lbl_course.Depth = 0
        Me.lbl_course.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_course.Location = New System.Drawing.Point(385, 16)
        Me.lbl_course.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_course.Name = "lbl_course"
        Me.lbl_course.Size = New System.Drawing.Size(54, 19)
        Me.lbl_course.TabIndex = 17
        Me.lbl_course.Text = "Course:"
        '
        'tb_contact_number
        '
        Me.tb_contact_number.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_contact_number.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_contact_number.Depth = 0
        Me.tb_contact_number.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_contact_number.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_contact_number.Location = New System.Drawing.Point(132, 391)
        Me.tb_contact_number.MaxLength = 11
        Me.tb_contact_number.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_contact_number.Name = "tb_contact_number"
        Me.tb_contact_number.Size = New System.Drawing.Size(221, 29)
        Me.tb_contact_number.TabIndex = 16
        Me.tb_contact_number.Text = ""
        '
        'lbl_contact_number
        '
        Me.lbl_contact_number.AutoSize = True
        Me.lbl_contact_number.Depth = 0
        Me.lbl_contact_number.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_contact_number.Location = New System.Drawing.Point(6, 391)
        Me.lbl_contact_number.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_contact_number.Name = "lbl_contact_number"
        Me.lbl_contact_number.Size = New System.Drawing.Size(120, 19)
        Me.lbl_contact_number.TabIndex = 15
        Me.lbl_contact_number.Text = "Contact Number:"
        '
        'tb_address
        '
        Me.tb_address.AnimateReadOnly = False
        Me.tb_address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_address.Depth = 0
        Me.tb_address.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_address.HideSelection = True
        Me.tb_address.Location = New System.Drawing.Point(115, 278)
        Me.tb_address.MaxLength = 32767
        Me.tb_address.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_address.Name = "tb_address"
        Me.tb_address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_address.ReadOnly = False
        Me.tb_address.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_address.SelectedText = ""
        Me.tb_address.SelectionLength = 0
        Me.tb_address.SelectionStart = 0
        Me.tb_address.ShortcutsEnabled = True
        Me.tb_address.Size = New System.Drawing.Size(238, 100)
        Me.tb_address.TabIndex = 14
        Me.tb_address.TabStop = False
        Me.tb_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tb_address.UseSystemPasswordChar = False
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Depth = 0
        Me.lbl_address.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_address.Location = New System.Drawing.Point(6, 278)
        Me.lbl_address.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(62, 19)
        Me.lbl_address.TabIndex = 12
        Me.lbl_address.Text = "Address:"
        '
        'lbl_age
        '
        Me.lbl_age.AutoSize = True
        Me.lbl_age.Depth = 0
        Me.lbl_age.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_age.Location = New System.Drawing.Point(6, 218)
        Me.lbl_age.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(32, 19)
        Me.lbl_age.TabIndex = 10
        Me.lbl_age.Text = "Age:"
        '
        'dtp_dob
        '
        Me.dtp_dob.Location = New System.Drawing.Point(115, 184)
        Me.dtp_dob.Name = "dtp_dob"
        Me.dtp_dob.Size = New System.Drawing.Size(238, 20)
        Me.dtp_dob.TabIndex = 9
        '
        'lbl_DOB
        '
        Me.lbl_DOB.AutoSize = True
        Me.lbl_DOB.Depth = 0
        Me.lbl_DOB.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_DOB.Location = New System.Drawing.Point(6, 185)
        Me.lbl_DOB.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_DOB.Name = "lbl_DOB"
        Me.lbl_DOB.Size = New System.Drawing.Size(94, 19)
        Me.lbl_DOB.TabIndex = 8
        Me.lbl_DOB.Text = "Date of Birth:"
        '
        'cb_civil_status
        '
        Me.cb_civil_status.AutoResize = False
        Me.cb_civil_status.BackColor = System.Drawing.Color.White
        Me.cb_civil_status.Depth = 0
        Me.cb_civil_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cb_civil_status.DropDownHeight = 174
        Me.cb_civil_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_civil_status.DropDownWidth = 121
        Me.cb_civil_status.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_civil_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cb_civil_status.FormattingEnabled = True
        Me.cb_civil_status.IntegralHeight = False
        Me.cb_civil_status.ItemHeight = 43
        Me.cb_civil_status.Items.AddRange(New Object() {"Single", "Married", "Widowed"})
        Me.cb_civil_status.Location = New System.Drawing.Point(115, 122)
        Me.cb_civil_status.MaxDropDownItems = 4
        Me.cb_civil_status.MouseState = MaterialSkin.MouseState.OUT
        Me.cb_civil_status.Name = "cb_civil_status"
        Me.cb_civil_status.Size = New System.Drawing.Size(238, 49)
        Me.cb_civil_status.StartIndex = 0
        Me.cb_civil_status.TabIndex = 7
        '
        'lbl_civil_status
        '
        Me.lbl_civil_status.AutoSize = True
        Me.lbl_civil_status.Depth = 0
        Me.lbl_civil_status.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_civil_status.Location = New System.Drawing.Point(6, 122)
        Me.lbl_civil_status.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_civil_status.Name = "lbl_civil_status"
        Me.lbl_civil_status.Size = New System.Drawing.Size(85, 19)
        Me.lbl_civil_status.TabIndex = 6
        Me.lbl_civil_status.Text = "Civil Status:"
        '
        'lbl_family_name
        '
        Me.lbl_family_name.AutoSize = True
        Me.lbl_family_name.Depth = 0
        Me.lbl_family_name.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_family_name.Location = New System.Drawing.Point(6, 86)
        Me.lbl_family_name.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_family_name.Name = "lbl_family_name"
        Me.lbl_family_name.Size = New System.Drawing.Size(99, 19)
        Me.lbl_family_name.TabIndex = 5
        Me.lbl_family_name.Text = "Family Name:"
        '
        'tb_family_name
        '
        Me.tb_family_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_family_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_family_name.Depth = 0
        Me.tb_family_name.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_family_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_family_name.Location = New System.Drawing.Point(115, 86)
        Me.tb_family_name.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_family_name.Name = "tb_family_name"
        Me.tb_family_name.Size = New System.Drawing.Size(238, 29)
        Me.tb_family_name.TabIndex = 4
        Me.tb_family_name.Text = ""
        '
        'lbl_student_middle_name
        '
        Me.lbl_student_middle_name.AutoSize = True
        Me.lbl_student_middle_name.Depth = 0
        Me.lbl_student_middle_name.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_student_middle_name.Location = New System.Drawing.Point(6, 51)
        Me.lbl_student_middle_name.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_student_middle_name.Name = "lbl_student_middle_name"
        Me.lbl_student_middle_name.Size = New System.Drawing.Size(99, 19)
        Me.lbl_student_middle_name.TabIndex = 3
        Me.lbl_student_middle_name.Text = "Middle Name:"
        '
        'tb_middle_name
        '
        Me.tb_middle_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_middle_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_middle_name.Depth = 0
        Me.tb_middle_name.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_middle_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_middle_name.Location = New System.Drawing.Point(115, 51)
        Me.tb_middle_name.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_middle_name.Name = "tb_middle_name"
        Me.tb_middle_name.Size = New System.Drawing.Size(238, 29)
        Me.tb_middle_name.TabIndex = 2
        Me.tb_middle_name.Text = ""
        '
        'lbl_student_name
        '
        Me.lbl_student_name.AutoSize = True
        Me.lbl_student_name.Depth = 0
        Me.lbl_student_name.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_student_name.Location = New System.Drawing.Point(6, 16)
        Me.lbl_student_name.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_student_name.Name = "lbl_student_name"
        Me.lbl_student_name.Size = New System.Drawing.Size(91, 19)
        Me.lbl_student_name.TabIndex = 1
        Me.lbl_student_name.Text = "Given Name:"
        '
        'tb_given_name
        '
        Me.tb_given_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_given_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_given_name.Depth = 0
        Me.tb_given_name.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_given_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_given_name.Location = New System.Drawing.Point(115, 16)
        Me.tb_given_name.MouseState = MaterialSkin.MouseState.HOVER
        Me.tb_given_name.Name = "tb_given_name"
        Me.tb_given_name.Size = New System.Drawing.Size(238, 29)
        Me.tb_given_name.TabIndex = 0
        Me.tb_given_name.Text = ""
        '
        'tp3
        '
        Me.tp3.BackColor = System.Drawing.Color.White
        Me.tp3.Controls.Add(Me.gb_payment)
        Me.tp3.ImageKey = "payment-method.png"
        Me.tp3.Location = New System.Drawing.Point(4, 39)
        Me.tp3.Name = "tp3"
        Me.tp3.Padding = New System.Windows.Forms.Padding(3)
        Me.tp3.Size = New System.Drawing.Size(986, 490)
        Me.tp3.TabIndex = 1
        Me.tp3.Text = "Payment"
        '
        'gb_payment
        '
        Me.gb_payment.Controls.Add(Me.btn_delete_payment_record)
        Me.gb_payment.Controls.Add(Me.gb_payment_info)
        Me.gb_payment.Controls.Add(Me.btn_pay)
        Me.gb_payment.Controls.Add(Me.btn_set_balance)
        Me.gb_payment.Controls.Add(Me.dgv_payments)
        Me.gb_payment.Controls.Add(Me.btn_select)
        Me.gb_payment.Controls.Add(Me.cb_student_list)
        Me.gb_payment.Dock = System.Windows.Forms.DockStyle.Left
        Me.gb_payment.Location = New System.Drawing.Point(3, 3)
        Me.gb_payment.Name = "gb_payment"
        Me.gb_payment.Size = New System.Drawing.Size(914, 484)
        Me.gb_payment.TabIndex = 0
        Me.gb_payment.TabStop = False
        '
        'btn_delete_payment_record
        '
        Me.btn_delete_payment_record.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delete_payment_record.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_delete_payment_record.Depth = 0
        Me.btn_delete_payment_record.HighEmphasis = True
        Me.btn_delete_payment_record.Icon = Nothing
        Me.btn_delete_payment_record.Location = New System.Drawing.Point(138, 461)
        Me.btn_delete_payment_record.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_delete_payment_record.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_delete_payment_record.Name = "btn_delete_payment_record"
        Me.btn_delete_payment_record.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_delete_payment_record.Size = New System.Drawing.Size(73, 36)
        Me.btn_delete_payment_record.TabIndex = 7
        Me.btn_delete_payment_record.Text = "DELETE"
        Me.btn_delete_payment_record.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_delete_payment_record.UseAccentColor = False
        Me.btn_delete_payment_record.UseVisualStyleBackColor = True
        Me.btn_delete_payment_record.Visible = False
        '
        'gb_payment_info
        '
        Me.gb_payment_info.Controls.Add(Me.card_remaining_balance)
        Me.gb_payment_info.Controls.Add(Me.card_total_paid)
        Me.gb_payment_info.Controls.Add(Me.card_balance_total)
        Me.gb_payment_info.Controls.Add(Me.card_payments_made)
        Me.gb_payment_info.Location = New System.Drawing.Point(496, 94)
        Me.gb_payment_info.Name = "gb_payment_info"
        Me.gb_payment_info.Size = New System.Drawing.Size(412, 363)
        Me.gb_payment_info.TabIndex = 6
        Me.gb_payment_info.TabStop = False
        '
        'card_remaining_balance
        '
        Me.card_remaining_balance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.card_remaining_balance.Controls.Add(Me.lbl_remaining_balance_value)
        Me.card_remaining_balance.Controls.Add(Me.lbl_remaining_balance)
        Me.card_remaining_balance.Depth = 0
        Me.card_remaining_balance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.card_remaining_balance.Location = New System.Drawing.Point(221, 197)
        Me.card_remaining_balance.Margin = New System.Windows.Forms.Padding(14)
        Me.card_remaining_balance.MouseState = MaterialSkin.MouseState.HOVER
        Me.card_remaining_balance.Name = "card_remaining_balance"
        Me.card_remaining_balance.Padding = New System.Windows.Forms.Padding(14)
        Me.card_remaining_balance.Size = New System.Drawing.Size(174, 149)
        Me.card_remaining_balance.TabIndex = 11
        '
        'lbl_remaining_balance_value
        '
        Me.lbl_remaining_balance_value.AutoSize = True
        Me.lbl_remaining_balance_value.Location = New System.Drawing.Point(17, 76)
        Me.lbl_remaining_balance_value.Name = "lbl_remaining_balance_value"
        Me.lbl_remaining_balance_value.Size = New System.Drawing.Size(39, 13)
        Me.lbl_remaining_balance_value.TabIndex = 6
        Me.lbl_remaining_balance_value.Text = "Label2"
        '
        'lbl_remaining_balance
        '
        Me.lbl_remaining_balance.AutoSize = True
        Me.lbl_remaining_balance.Depth = 0
        Me.lbl_remaining_balance.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_remaining_balance.Location = New System.Drawing.Point(17, 14)
        Me.lbl_remaining_balance.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_remaining_balance.Name = "lbl_remaining_balance"
        Me.lbl_remaining_balance.Size = New System.Drawing.Size(142, 19)
        Me.lbl_remaining_balance.TabIndex = 8
        Me.lbl_remaining_balance.Text = "Remaining Balance:"
        '
        'card_total_paid
        '
        Me.card_total_paid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.card_total_paid.Controls.Add(Me.lbl_total_paid_value)
        Me.card_total_paid.Controls.Add(Me.lvl_total_paid)
        Me.card_total_paid.Depth = 0
        Me.card_total_paid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.card_total_paid.Location = New System.Drawing.Point(221, 20)
        Me.card_total_paid.Margin = New System.Windows.Forms.Padding(14)
        Me.card_total_paid.MouseState = MaterialSkin.MouseState.HOVER
        Me.card_total_paid.Name = "card_total_paid"
        Me.card_total_paid.Padding = New System.Windows.Forms.Padding(14)
        Me.card_total_paid.Size = New System.Drawing.Size(174, 149)
        Me.card_total_paid.TabIndex = 10
        '
        'lbl_total_paid_value
        '
        Me.lbl_total_paid_value.AutoSize = True
        Me.lbl_total_paid_value.Location = New System.Drawing.Point(17, 76)
        Me.lbl_total_paid_value.Name = "lbl_total_paid_value"
        Me.lbl_total_paid_value.Size = New System.Drawing.Size(39, 13)
        Me.lbl_total_paid_value.TabIndex = 7
        Me.lbl_total_paid_value.Text = "Label3"
        '
        'lvl_total_paid
        '
        Me.lvl_total_paid.AutoSize = True
        Me.lvl_total_paid.Depth = 0
        Me.lvl_total_paid.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lvl_total_paid.Location = New System.Drawing.Point(17, 14)
        Me.lvl_total_paid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lvl_total_paid.Name = "lvl_total_paid"
        Me.lvl_total_paid.Size = New System.Drawing.Size(78, 19)
        Me.lvl_total_paid.TabIndex = 7
        Me.lvl_total_paid.Text = "Total Paid:"
        '
        'card_balance_total
        '
        Me.card_balance_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.card_balance_total.Controls.Add(Me.lbl_balance_total_value)
        Me.card_balance_total.Controls.Add(Me.MaterialLabel1)
        Me.card_balance_total.Depth = 0
        Me.card_balance_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.card_balance_total.Location = New System.Drawing.Point(17, 197)
        Me.card_balance_total.Margin = New System.Windows.Forms.Padding(14)
        Me.card_balance_total.MouseState = MaterialSkin.MouseState.HOVER
        Me.card_balance_total.Name = "card_balance_total"
        Me.card_balance_total.Padding = New System.Windows.Forms.Padding(14)
        Me.card_balance_total.Size = New System.Drawing.Size(174, 149)
        Me.card_balance_total.TabIndex = 8
        '
        'lbl_balance_total_value
        '
        Me.lbl_balance_total_value.AutoSize = True
        Me.lbl_balance_total_value.Location = New System.Drawing.Point(20, 76)
        Me.lbl_balance_total_value.Name = "lbl_balance_total_value"
        Me.lbl_balance_total_value.Size = New System.Drawing.Size(39, 13)
        Me.lbl_balance_total_value.TabIndex = 5
        Me.lbl_balance_total_value.Text = "Label1"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(11, 14)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(116, 19)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "Balance To Pay:"
        '
        'card_payments_made
        '
        Me.card_payments_made.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.card_payments_made.Controls.Add(Me.lbl_payments_made_value)
        Me.card_payments_made.Controls.Add(Me.lvl_payment_count)
        Me.card_payments_made.Depth = 0
        Me.card_payments_made.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.card_payments_made.Location = New System.Drawing.Point(19, 20)
        Me.card_payments_made.Margin = New System.Windows.Forms.Padding(14)
        Me.card_payments_made.MouseState = MaterialSkin.MouseState.HOVER
        Me.card_payments_made.Name = "card_payments_made"
        Me.card_payments_made.Padding = New System.Windows.Forms.Padding(14)
        Me.card_payments_made.Size = New System.Drawing.Size(174, 149)
        Me.card_payments_made.TabIndex = 9
        '
        'lbl_payments_made_value
        '
        Me.lbl_payments_made_value.AutoSize = True
        Me.lbl_payments_made_value.Location = New System.Drawing.Point(17, 76)
        Me.lbl_payments_made_value.Name = "lbl_payments_made_value"
        Me.lbl_payments_made_value.Size = New System.Drawing.Size(39, 13)
        Me.lbl_payments_made_value.TabIndex = 8
        Me.lbl_payments_made_value.Text = "Label4"
        '
        'lvl_payment_count
        '
        Me.lvl_payment_count.AutoSize = True
        Me.lvl_payment_count.Depth = 0
        Me.lvl_payment_count.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lvl_payment_count.Location = New System.Drawing.Point(17, 14)
        Me.lvl_payment_count.MouseState = MaterialSkin.MouseState.HOVER
        Me.lvl_payment_count.Name = "lvl_payment_count"
        Me.lvl_payment_count.Size = New System.Drawing.Size(120, 19)
        Me.lvl_payment_count.TabIndex = 5
        Me.lvl_payment_count.Text = "Payments Made:"
        '
        'btn_pay
        '
        Me.btn_pay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_pay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_pay.Depth = 0
        Me.btn_pay.HighEmphasis = True
        Me.btn_pay.Icon = Nothing
        Me.btn_pay.Location = New System.Drawing.Point(7, 461)
        Me.btn_pay.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_pay.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_pay.Size = New System.Drawing.Size(123, 36)
        Me.btn_pay.TabIndex = 5
        Me.btn_pay.Text = "Add Payment"
        Me.btn_pay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_pay.UseAccentColor = False
        Me.btn_pay.UseVisualStyleBackColor = True
        '
        'btn_set_balance
        '
        Me.btn_set_balance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_set_balance.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_set_balance.Depth = 0
        Me.btn_set_balance.HighEmphasis = True
        Me.btn_set_balance.Icon = Nothing
        Me.btn_set_balance.Location = New System.Drawing.Point(755, 22)
        Me.btn_set_balance.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_set_balance.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_set_balance.Name = "btn_set_balance"
        Me.btn_set_balance.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_set_balance.Size = New System.Drawing.Size(152, 36)
        Me.btn_set_balance.TabIndex = 3
        Me.btn_set_balance.Text = "MANAGE BALANCE"
        Me.btn_set_balance.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btn_set_balance.UseAccentColor = False
        Me.btn_set_balance.UseVisualStyleBackColor = True
        Me.btn_set_balance.Visible = False
        '
        'dgv_payments
        '
        Me.dgv_payments.AllowUserToAddRows = False
        Me.dgv_payments.AllowUserToDeleteRows = False
        Me.dgv_payments.AllowUserToResizeRows = False
        Me.dgv_payments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_payments.Location = New System.Drawing.Point(6, 94)
        Me.dgv_payments.MultiSelect = False
        Me.dgv_payments.Name = "dgv_payments"
        Me.dgv_payments.ReadOnly = True
        Me.dgv_payments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_payments.Size = New System.Drawing.Size(471, 363)
        Me.dgv_payments.TabIndex = 2
        '
        'btn_select
        '
        Me.btn_select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_select.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_select.Depth = 0
        Me.btn_select.HighEmphasis = True
        Me.btn_select.Icon = Nothing
        Me.btn_select.Location = New System.Drawing.Point(326, 22)
        Me.btn_select.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_select.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_select.Name = "btn_select"
        Me.btn_select.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_select.Size = New System.Drawing.Size(74, 36)
        Me.btn_select.TabIndex = 1
        Me.btn_select.Text = "SELECT"
        Me.btn_select.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_select.UseAccentColor = False
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'cb_student_list
        '
        Me.cb_student_list.AutoResize = False
        Me.cb_student_list.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_student_list.Depth = 0
        Me.cb_student_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cb_student_list.DropDownHeight = 174
        Me.cb_student_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_student_list.DropDownWidth = 121
        Me.cb_student_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cb_student_list.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cb_student_list.FormattingEnabled = True
        Me.cb_student_list.IntegralHeight = False
        Me.cb_student_list.ItemHeight = 43
        Me.cb_student_list.Location = New System.Drawing.Point(6, 19)
        Me.cb_student_list.MaxDropDownItems = 4
        Me.cb_student_list.MouseState = MaterialSkin.MouseState.OUT
        Me.cb_student_list.Name = "cb_student_list"
        Me.cb_student_list.Size = New System.Drawing.Size(313, 49)
        Me.cb_student_list.StartIndex = 0
        Me.cb_student_list.TabIndex = 0
        '
        'tp1
        '
        Me.tp1.BackColor = System.Drawing.Color.White
        Me.tp1.Controls.Add(Me.btn_update_student_record)
        Me.tp1.Controls.Add(Me.btn_delete)
        Me.tp1.Controls.Add(Me.btn_search)
        Me.tp1.Controls.Add(Me.tb_search)
        Me.tp1.Controls.Add(Me.gb_main)
        Me.tp1.ImageKey = "students.png"
        Me.tp1.Location = New System.Drawing.Point(4, 39)
        Me.tp1.Name = "tp1"
        Me.tp1.Padding = New System.Windows.Forms.Padding(3)
        Me.tp1.Size = New System.Drawing.Size(986, 490)
        Me.tp1.TabIndex = 0
        Me.tp1.Text = "Students"
        '
        'btn_update_student_record
        '
        Me.btn_update_student_record.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_update_student_record.BackColor = System.Drawing.Color.Red
        Me.btn_update_student_record.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_update_student_record.Depth = 0
        Me.btn_update_student_record.HighEmphasis = True
        Me.btn_update_student_record.Icon = Nothing
        Me.btn_update_student_record.Location = New System.Drawing.Point(87, 461)
        Me.btn_update_student_record.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_update_student_record.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_update_student_record.Name = "btn_update_student_record"
        Me.btn_update_student_record.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_update_student_record.Size = New System.Drawing.Size(187, 36)
        Me.btn_update_student_record.TabIndex = 5
        Me.btn_update_student_record.Text = "VIEW DETAILS / UPDATE"
        Me.btn_update_student_record.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_update_student_record.UseAccentColor = False
        Me.btn_update_student_record.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_delete.Depth = 0
        Me.btn_delete.HighEmphasis = True
        Me.btn_delete.Icon = Nothing
        Me.btn_delete.Location = New System.Drawing.Point(6, 461)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_delete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_delete.Size = New System.Drawing.Size(73, 36)
        Me.btn_delete.TabIndex = 4
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_delete.UseAccentColor = False
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_search.Depth = 0
        Me.btn_search.HighEmphasis = True
        Me.btn_search.Icon = Nothing
        Me.btn_search.Location = New System.Drawing.Point(848, 461)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_search.Name = "btn_search"
        Me.btn_search.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_search.Size = New System.Drawing.Size(78, 36)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "Search"
        Me.btn_search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_search.UseAccentColor = False
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'tb_search
        '
        Me.tb_search.AnimateReadOnly = False
        Me.tb_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_search.Depth = 0
        Me.tb_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_search.HideSelection = True
        Me.tb_search.LeadingIcon = Nothing
        Me.tb_search.Location = New System.Drawing.Point(591, 455)
        Me.tb_search.MaxLength = 32767
        Me.tb_search.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_search.Name = "tb_search"
        Me.tb_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_search.PrefixSuffixText = Nothing
        Me.tb_search.ReadOnly = False
        Me.tb_search.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_search.SelectedText = ""
        Me.tb_search.SelectionLength = 0
        Me.tb_search.SelectionStart = 0
        Me.tb_search.ShortcutsEnabled = True
        Me.tb_search.Size = New System.Drawing.Size(250, 48)
        Me.tb_search.TabIndex = 2
        Me.tb_search.TabStop = False
        Me.tb_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tb_search.TrailingIcon = Nothing
        Me.tb_search.UseSystemPasswordChar = False
        '
        'gb_main
        '
        Me.gb_main.BackColor = System.Drawing.Color.White
        Me.gb_main.Controls.Add(Me.dgv_main)
        Me.gb_main.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gb_main.Location = New System.Drawing.Point(6, 6)
        Me.gb_main.Name = "gb_main"
        Me.gb_main.Size = New System.Drawing.Size(920, 446)
        Me.gb_main.TabIndex = 1
        Me.gb_main.TabStop = False
        '
        'dgv_main
        '
        Me.dgv_main.AllowUserToAddRows = False
        Me.dgv_main.AllowUserToResizeRows = False
        Me.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_main.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgv_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_main.Location = New System.Drawing.Point(3, 16)
        Me.dgv_main.MultiSelect = False
        Me.dgv_main.Name = "dgv_main"
        Me.dgv_main.ReadOnly = True
        Me.dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_main.Size = New System.Drawing.Size(914, 427)
        Me.dgv_main.TabIndex = 0
        '
        'MTC_MAIN
        '
        Me.MTC_MAIN.Controls.Add(Me.tp1)
        Me.MTC_MAIN.Controls.Add(Me.tp2)
        Me.MTC_MAIN.Controls.Add(Me.tp3)
        Me.MTC_MAIN.Controls.Add(Me.tp4)
        Me.MTC_MAIN.Controls.Add(Me.tp5)
        Me.MTC_MAIN.Controls.Add(Me.tp6)
        Me.MTC_MAIN.Controls.Add(Me.tp7)
        Me.MTC_MAIN.Controls.Add(Me.tp8)
        Me.MTC_MAIN.Depth = 0
        Me.MTC_MAIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MTC_MAIN.ImageList = Me.IL_TABS
        Me.MTC_MAIN.Location = New System.Drawing.Point(3, 64)
        Me.MTC_MAIN.MouseState = MaterialSkin.MouseState.HOVER
        Me.MTC_MAIN.Multiline = True
        Me.MTC_MAIN.Name = "MTC_MAIN"
        Me.MTC_MAIN.SelectedIndex = 0
        Me.MTC_MAIN.Size = New System.Drawing.Size(994, 533)
        Me.MTC_MAIN.TabIndex = 0
        '
        'tp4
        '
        Me.tp4.BackColor = System.Drawing.Color.White
        Me.tp4.Controls.Add(Me.gb_funds)
        Me.tp4.ImageKey = "money.png"
        Me.tp4.Location = New System.Drawing.Point(4, 39)
        Me.tp4.Name = "tp4"
        Me.tp4.Size = New System.Drawing.Size(986, 490)
        Me.tp4.TabIndex = 3
        Me.tp4.Text = "Funds"
        '
        'gb_funds
        '
        Me.gb_funds.Controls.Add(Me.chart_funds)
        Me.gb_funds.Controls.Add(Me.btn_transaction_history)
        Me.gb_funds.Controls.Add(Me.lbl_manage)
        Me.gb_funds.Controls.Add(Me.lbl_item)
        Me.gb_funds.Controls.Add(Me.btn_remove_item)
        Me.gb_funds.Controls.Add(Me.btn_add_funds)
        Me.gb_funds.Controls.Add(Me.btn_add_item)
        Me.gb_funds.Controls.Add(Me.dgv_funds)
        Me.gb_funds.Dock = System.Windows.Forms.DockStyle.Left
        Me.gb_funds.Location = New System.Drawing.Point(0, 0)
        Me.gb_funds.Name = "gb_funds"
        Me.gb_funds.Size = New System.Drawing.Size(914, 490)
        Me.gb_funds.TabIndex = 0
        Me.gb_funds.TabStop = False
        '
        'chart_funds
        '
        Me.chart_funds.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.chart_funds.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.chart_funds.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.chart_funds.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chart_funds.Legends.Add(Legend2)
        Me.chart_funds.Location = New System.Drawing.Point(523, 19)
        Me.chart_funds.Name = "chart_funds"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "s1"
        Me.chart_funds.Series.Add(Series2)
        Me.chart_funds.Size = New System.Drawing.Size(385, 384)
        Me.chart_funds.TabIndex = 8
        Me.chart_funds.Text = "Funds"
        '
        'btn_transaction_history
        '
        Me.btn_transaction_history.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_transaction_history.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_transaction_history.Depth = 0
        Me.btn_transaction_history.HighEmphasis = True
        Me.btn_transaction_history.Icon = Nothing
        Me.btn_transaction_history.Location = New System.Drawing.Point(331, 431)
        Me.btn_transaction_history.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_transaction_history.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_transaction_history.Name = "btn_transaction_history"
        Me.btn_transaction_history.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_transaction_history.Size = New System.Drawing.Size(186, 36)
        Me.btn_transaction_history.TabIndex = 7
        Me.btn_transaction_history.Text = "Transaction History"
        Me.btn_transaction_history.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_transaction_history.UseAccentColor = False
        Me.btn_transaction_history.UseVisualStyleBackColor = True
        '
        'lbl_manage
        '
        Me.lbl_manage.AutoSize = True
        Me.lbl_manage.Depth = 0
        Me.lbl_manage.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_manage.Location = New System.Drawing.Point(219, 406)
        Me.lbl_manage.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_manage.Name = "lbl_manage"
        Me.lbl_manage.Size = New System.Drawing.Size(63, 19)
        Me.lbl_manage.TabIndex = 6
        Me.lbl_manage.Text = "Manage:"
        '
        'lbl_item
        '
        Me.lbl_item.AutoSize = True
        Me.lbl_item.Depth = 0
        Me.lbl_item.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_item.Location = New System.Drawing.Point(6, 406)
        Me.lbl_item.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_item.Name = "lbl_item"
        Me.lbl_item.Size = New System.Drawing.Size(44, 19)
        Me.lbl_item.TabIndex = 5
        Me.lbl_item.Text = "Items:"
        '
        'btn_remove_item
        '
        Me.btn_remove_item.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_remove_item.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_remove_item.Depth = 0
        Me.btn_remove_item.HighEmphasis = True
        Me.btn_remove_item.Icon = Nothing
        Me.btn_remove_item.Location = New System.Drawing.Point(80, 431)
        Me.btn_remove_item.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_remove_item.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_remove_item.Name = "btn_remove_item"
        Me.btn_remove_item.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_remove_item.Size = New System.Drawing.Size(80, 36)
        Me.btn_remove_item.TabIndex = 4
        Me.btn_remove_item.Text = "Remove"
        Me.btn_remove_item.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_remove_item.UseAccentColor = False
        Me.btn_remove_item.UseVisualStyleBackColor = True
        '
        'btn_add_funds
        '
        Me.btn_add_funds.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_add_funds.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_add_funds.Depth = 0
        Me.btn_add_funds.HighEmphasis = True
        Me.btn_add_funds.Icon = Nothing
        Me.btn_add_funds.Location = New System.Drawing.Point(222, 431)
        Me.btn_add_funds.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_add_funds.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_add_funds.Name = "btn_add_funds"
        Me.btn_add_funds.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_add_funds.Size = New System.Drawing.Size(101, 36)
        Me.btn_add_funds.TabIndex = 2
        Me.btn_add_funds.Text = "Add Funds"
        Me.btn_add_funds.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_add_funds.UseAccentColor = False
        Me.btn_add_funds.UseVisualStyleBackColor = True
        '
        'btn_add_item
        '
        Me.btn_add_item.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_add_item.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_add_item.Depth = 0
        Me.btn_add_item.HighEmphasis = True
        Me.btn_add_item.Icon = Nothing
        Me.btn_add_item.Location = New System.Drawing.Point(8, 431)
        Me.btn_add_item.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_add_item.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_add_item.Name = "btn_add_item"
        Me.btn_add_item.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_add_item.Size = New System.Drawing.Size(64, 36)
        Me.btn_add_item.TabIndex = 1
        Me.btn_add_item.Text = "Add"
        Me.btn_add_item.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_add_item.UseAccentColor = False
        Me.btn_add_item.UseVisualStyleBackColor = True
        '
        'dgv_funds
        '
        Me.dgv_funds.AllowUserToAddRows = False
        Me.dgv_funds.AllowUserToDeleteRows = False
        Me.dgv_funds.AllowUserToResizeRows = False
        Me.dgv_funds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_funds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_funds.Location = New System.Drawing.Point(9, 19)
        Me.dgv_funds.MultiSelect = False
        Me.dgv_funds.Name = "dgv_funds"
        Me.dgv_funds.ReadOnly = True
        Me.dgv_funds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_funds.Size = New System.Drawing.Size(508, 384)
        Me.dgv_funds.TabIndex = 0
        '
        'tp5
        '
        Me.tp5.Controls.Add(Me.gb_expenses)
        Me.tp5.ImageKey = "expenses.png"
        Me.tp5.Location = New System.Drawing.Point(4, 39)
        Me.tp5.Name = "tp5"
        Me.tp5.Size = New System.Drawing.Size(986, 490)
        Me.tp5.TabIndex = 4
        Me.tp5.Text = "Expenses"
        Me.tp5.UseVisualStyleBackColor = True
        '
        'gb_expenses
        '
        Me.gb_expenses.BackColor = System.Drawing.Color.White
        Me.gb_expenses.Controls.Add(Me.lbl_bae)
        Me.gb_expenses.Controls.Add(Me.lbl_availablefunds)
        Me.gb_expenses.Controls.Add(Me.btn_expenses_reset)
        Me.gb_expenses.Controls.Add(Me.btn_expenses_delete)
        Me.gb_expenses.Controls.Add(Me.btn_expenses_date_filter)
        Me.gb_expenses.Controls.Add(Me.dtp_expenses_date_filter_after)
        Me.gb_expenses.Controls.Add(Me.dtp_expenses_date_filter_before)
        Me.gb_expenses.Controls.Add(Me.lbl_date_to)
        Me.gb_expenses.Controls.Add(Me.lbl_date_from)
        Me.gb_expenses.Controls.Add(Me.MaterialCard2)
        Me.gb_expenses.Controls.Add(Me.tb_expenses_desc)
        Me.gb_expenses.Controls.Add(Me.dtp_expenses_date)
        Me.gb_expenses.Controls.Add(Me.lbl_date)
        Me.gb_expenses.Controls.Add(Me.tb_expenses_amount)
        Me.gb_expenses.Controls.Add(Me.btn_expenses_add)
        Me.gb_expenses.Controls.Add(Me.lbl_expenses_amount)
        Me.gb_expenses.Controls.Add(Me.lbl_expenses_description)
        Me.gb_expenses.Controls.Add(Me.dgv_expenses)
        Me.gb_expenses.Dock = System.Windows.Forms.DockStyle.Left
        Me.gb_expenses.Location = New System.Drawing.Point(0, 0)
        Me.gb_expenses.Name = "gb_expenses"
        Me.gb_expenses.Size = New System.Drawing.Size(914, 490)
        Me.gb_expenses.TabIndex = 0
        Me.gb_expenses.TabStop = False
        '
        'lbl_bae
        '
        Me.lbl_bae.AutoSize = True
        Me.lbl_bae.Location = New System.Drawing.Point(620, 9)
        Me.lbl_bae.Name = "lbl_bae"
        Me.lbl_bae.Size = New System.Drawing.Size(39, 13)
        Me.lbl_bae.TabIndex = 9
        Me.lbl_bae.Text = "Label4"
        '
        'lbl_availablefunds
        '
        Me.lbl_availablefunds.AutoSize = True
        Me.lbl_availablefunds.Depth = 0
        Me.lbl_availablefunds.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_availablefunds.Location = New System.Drawing.Point(443, 16)
        Me.lbl_availablefunds.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_availablefunds.Name = "lbl_availablefunds"
        Me.lbl_availablefunds.Size = New System.Drawing.Size(171, 19)
        Me.lbl_availablefunds.TabIndex = 21
        Me.lbl_availablefunds.Text = "Balance After Expenses:"
        '
        'btn_expenses_reset
        '
        Me.btn_expenses_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_expenses_reset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_expenses_reset.Depth = 0
        Me.btn_expenses_reset.HighEmphasis = True
        Me.btn_expenses_reset.Icon = Nothing
        Me.btn_expenses_reset.Location = New System.Drawing.Point(612, 448)
        Me.btn_expenses_reset.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_expenses_reset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_expenses_reset.Name = "btn_expenses_reset"
        Me.btn_expenses_reset.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_expenses_reset.Size = New System.Drawing.Size(86, 36)
        Me.btn_expenses_reset.TabIndex = 9
        Me.btn_expenses_reset.Text = "View All"
        Me.btn_expenses_reset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_expenses_reset.UseAccentColor = False
        Me.btn_expenses_reset.UseVisualStyleBackColor = True
        '
        'btn_expenses_delete
        '
        Me.btn_expenses_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_expenses_delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense
        Me.btn_expenses_delete.Depth = 0
        Me.btn_expenses_delete.HighEmphasis = True
        Me.btn_expenses_delete.Icon = Nothing
        Me.btn_expenses_delete.Location = New System.Drawing.Point(191, 445)
        Me.btn_expenses_delete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_expenses_delete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_expenses_delete.Name = "btn_expenses_delete"
        Me.btn_expenses_delete.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_expenses_delete.Size = New System.Drawing.Size(73, 36)
        Me.btn_expenses_delete.TabIndex = 10
        Me.btn_expenses_delete.Text = "Delete"
        Me.btn_expenses_delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_expenses_delete.UseAccentColor = False
        Me.btn_expenses_delete.UseVisualStyleBackColor = True
        '
        'btn_expenses_date_filter
        '
        Me.btn_expenses_date_filter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_expenses_date_filter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_expenses_date_filter.Depth = 0
        Me.btn_expenses_date_filter.HighEmphasis = True
        Me.btn_expenses_date_filter.Icon = Nothing
        Me.btn_expenses_date_filter.Location = New System.Drawing.Point(706, 448)
        Me.btn_expenses_date_filter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_expenses_date_filter.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_expenses_date_filter.Name = "btn_expenses_date_filter"
        Me.btn_expenses_date_filter.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_expenses_date_filter.Size = New System.Drawing.Size(68, 36)
        Me.btn_expenses_date_filter.TabIndex = 8
        Me.btn_expenses_date_filter.Text = "Filter"
        Me.btn_expenses_date_filter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_expenses_date_filter.UseAccentColor = False
        Me.btn_expenses_date_filter.UseVisualStyleBackColor = True
        '
        'dtp_expenses_date_filter_after
        '
        Me.dtp_expenses_date_filter_after.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_expenses_date_filter_after.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_expenses_date_filter_after.Location = New System.Drawing.Point(538, 417)
        Me.dtp_expenses_date_filter_after.Name = "dtp_expenses_date_filter_after"
        Me.dtp_expenses_date_filter_after.Size = New System.Drawing.Size(333, 25)
        Me.dtp_expenses_date_filter_after.TabIndex = 7
        '
        'dtp_expenses_date_filter_before
        '
        Me.dtp_expenses_date_filter_before.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_expenses_date_filter_before.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_expenses_date_filter_before.Location = New System.Drawing.Point(538, 381)
        Me.dtp_expenses_date_filter_before.Name = "dtp_expenses_date_filter_before"
        Me.dtp_expenses_date_filter_before.Size = New System.Drawing.Size(333, 25)
        Me.dtp_expenses_date_filter_before.TabIndex = 6
        '
        'lbl_date_to
        '
        Me.lbl_date_to.AutoSize = True
        Me.lbl_date_to.Depth = 0
        Me.lbl_date_to.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_date_to.Location = New System.Drawing.Point(490, 423)
        Me.lbl_date_to.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_date_to.Name = "lbl_date_to"
        Me.lbl_date_to.Size = New System.Drawing.Size(24, 19)
        Me.lbl_date_to.TabIndex = 20
        Me.lbl_date_to.Text = "To:"
        '
        'lbl_date_from
        '
        Me.lbl_date_from.AutoSize = True
        Me.lbl_date_from.Depth = 0
        Me.lbl_date_from.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_date_from.Location = New System.Drawing.Point(490, 390)
        Me.lbl_date_from.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_date_from.Name = "lbl_date_from"
        Me.lbl_date_from.Size = New System.Drawing.Size(42, 19)
        Me.lbl_date_from.TabIndex = 19
        Me.lbl_date_from.Text = "From:"
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.lbl_expense_total_value)
        Me.MaterialCard2.Controls.Add(Me.lbl_expense_total)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(493, 318)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(378, 46)
        Me.MaterialCard2.TabIndex = 5
        '
        'lbl_expense_total_value
        '
        Me.lbl_expense_total_value.AutoSize = True
        Me.lbl_expense_total_value.Location = New System.Drawing.Point(128, 6)
        Me.lbl_expense_total_value.Name = "lbl_expense_total_value"
        Me.lbl_expense_total_value.Size = New System.Drawing.Size(39, 13)
        Me.lbl_expense_total_value.TabIndex = 8
        Me.lbl_expense_total_value.Text = "Label4"
        '
        'lbl_expense_total
        '
        Me.lbl_expense_total.AutoSize = True
        Me.lbl_expense_total.Depth = 0
        Me.lbl_expense_total.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_expense_total.Location = New System.Drawing.Point(17, 14)
        Me.lbl_expense_total.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_expense_total.Name = "lbl_expense_total"
        Me.lbl_expense_total.Size = New System.Drawing.Size(105, 19)
        Me.lbl_expense_total.TabIndex = 5
        Me.lbl_expense_total.Text = "Total Expense:"
        '
        'tb_expenses_desc
        '
        Me.tb_expenses_desc.AnimateReadOnly = False
        Me.tb_expenses_desc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_expenses_desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_expenses_desc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_expenses_desc.Depth = 0
        Me.tb_expenses_desc.HideSelection = True
        Me.tb_expenses_desc.Location = New System.Drawing.Point(534, 56)
        Me.tb_expenses_desc.MaxLength = 32767
        Me.tb_expenses_desc.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_expenses_desc.Name = "tb_expenses_desc"
        Me.tb_expenses_desc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_expenses_desc.ReadOnly = False
        Me.tb_expenses_desc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_expenses_desc.SelectedText = ""
        Me.tb_expenses_desc.SelectionLength = 0
        Me.tb_expenses_desc.SelectionStart = 0
        Me.tb_expenses_desc.ShortcutsEnabled = True
        Me.tb_expenses_desc.Size = New System.Drawing.Size(333, 97)
        Me.tb_expenses_desc.TabIndex = 1
        Me.tb_expenses_desc.TabStop = False
        Me.tb_expenses_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tb_expenses_desc.UseSystemPasswordChar = False
        '
        'dtp_expenses_date
        '
        Me.dtp_expenses_date.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_expenses_date.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_expenses_date.Location = New System.Drawing.Point(534, 228)
        Me.dtp_expenses_date.Name = "dtp_expenses_date"
        Me.dtp_expenses_date.Size = New System.Drawing.Size(333, 25)
        Me.dtp_expenses_date.TabIndex = 3
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Depth = 0
        Me.lbl_date.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_date.Location = New System.Drawing.Point(490, 228)
        Me.lbl_date.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(38, 19)
        Me.lbl_date.TabIndex = 15
        Me.lbl_date.Text = "Date:"
        '
        'tb_expenses_amount
        '
        Me.tb_expenses_amount.AnimateReadOnly = False
        Me.tb_expenses_amount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_expenses_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_expenses_amount.Depth = 0
        Me.tb_expenses_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_expenses_amount.HideSelection = True
        Me.tb_expenses_amount.LeadingIcon = Nothing
        Me.tb_expenses_amount.Location = New System.Drawing.Point(534, 164)
        Me.tb_expenses_amount.MaxLength = 7
        Me.tb_expenses_amount.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_expenses_amount.Name = "tb_expenses_amount"
        Me.tb_expenses_amount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_expenses_amount.PrefixSuffixText = Nothing
        Me.tb_expenses_amount.ReadOnly = False
        Me.tb_expenses_amount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_expenses_amount.SelectedText = ""
        Me.tb_expenses_amount.SelectionLength = 0
        Me.tb_expenses_amount.SelectionStart = 0
        Me.tb_expenses_amount.ShortcutsEnabled = True
        Me.tb_expenses_amount.Size = New System.Drawing.Size(333, 48)
        Me.tb_expenses_amount.TabIndex = 2
        Me.tb_expenses_amount.TabStop = False
        Me.tb_expenses_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_expenses_amount.TrailingIcon = Nothing
        Me.tb_expenses_amount.UseSystemPasswordChar = False
        '
        'btn_expenses_add
        '
        Me.btn_expenses_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_expenses_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_expenses_add.Depth = 0
        Me.btn_expenses_add.HighEmphasis = True
        Me.btn_expenses_add.Icon = Nothing
        Me.btn_expenses_add.Location = New System.Drawing.Point(636, 273)
        Me.btn_expenses_add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_expenses_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_expenses_add.Name = "btn_expenses_add"
        Me.btn_expenses_add.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_expenses_add.Size = New System.Drawing.Size(126, 36)
        Me.btn_expenses_add.TabIndex = 4
        Me.btn_expenses_add.Text = "Add Expenses"
        Me.btn_expenses_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_expenses_add.UseAccentColor = False
        Me.btn_expenses_add.UseVisualStyleBackColor = True
        '
        'lbl_expenses_amount
        '
        Me.lbl_expenses_amount.AutoSize = True
        Me.lbl_expenses_amount.Depth = 0
        Me.lbl_expenses_amount.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_expenses_amount.Location = New System.Drawing.Point(467, 164)
        Me.lbl_expenses_amount.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_expenses_amount.Name = "lbl_expenses_amount"
        Me.lbl_expenses_amount.Size = New System.Drawing.Size(61, 19)
        Me.lbl_expenses_amount.TabIndex = 10
        Me.lbl_expenses_amount.Text = "Amount:"
        '
        'lbl_expenses_description
        '
        Me.lbl_expenses_description.AutoSize = True
        Me.lbl_expenses_description.Depth = 0
        Me.lbl_expenses_description.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_expenses_description.Location = New System.Drawing.Point(443, 56)
        Me.lbl_expenses_description.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_expenses_description.Name = "lbl_expenses_description"
        Me.lbl_expenses_description.Size = New System.Drawing.Size(85, 19)
        Me.lbl_expenses_description.TabIndex = 9
        Me.lbl_expenses_description.Text = "Description:"
        '
        'dgv_expenses
        '
        Me.dgv_expenses.AllowUserToAddRows = False
        Me.dgv_expenses.AllowUserToDeleteRows = False
        Me.dgv_expenses.AllowUserToResizeRows = False
        Me.dgv_expenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_expenses.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_expenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_expenses.GridColor = System.Drawing.SystemColors.Control
        Me.dgv_expenses.Location = New System.Drawing.Point(6, 19)
        Me.dgv_expenses.Name = "dgv_expenses"
        Me.dgv_expenses.ReadOnly = True
        Me.dgv_expenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_expenses.Size = New System.Drawing.Size(431, 420)
        Me.dgv_expenses.TabIndex = 0
        '
        'tp6
        '
        Me.tp6.Controls.Add(Me.gb_reports)
        Me.tp6.ImageKey = "report.png"
        Me.tp6.Location = New System.Drawing.Point(4, 39)
        Me.tp6.Name = "tp6"
        Me.tp6.Size = New System.Drawing.Size(986, 490)
        Me.tp6.TabIndex = 5
        Me.tp6.Text = "Reports"
        Me.tp6.UseVisualStyleBackColor = True
        '
        'gb_reports
        '
        Me.gb_reports.BackColor = System.Drawing.Color.White
        Me.gb_reports.Controls.Add(Me.card_report_generator)
        Me.gb_reports.Dock = System.Windows.Forms.DockStyle.Left
        Me.gb_reports.Location = New System.Drawing.Point(0, 0)
        Me.gb_reports.Name = "gb_reports"
        Me.gb_reports.Size = New System.Drawing.Size(913, 490)
        Me.gb_reports.TabIndex = 1
        Me.gb_reports.TabStop = False
        '
        'card_report_generator
        '
        Me.card_report_generator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.card_report_generator.Controls.Add(Me.lbl_reports_main)
        Me.card_report_generator.Controls.Add(Me.cb_reports)
        Me.card_report_generator.Controls.Add(Me.dtp_reports_from)
        Me.card_report_generator.Controls.Add(Me.dtp_reports_to)
        Me.card_report_generator.Controls.Add(Me.lbl_reports_from)
        Me.card_report_generator.Controls.Add(Me.lbl_reports_to)
        Me.card_report_generator.Controls.Add(Me.lbl_reports_for)
        Me.card_report_generator.Controls.Add(Me.btn_generate_report)
        Me.card_report_generator.Depth = 0
        Me.card_report_generator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.card_report_generator.Location = New System.Drawing.Point(302, 56)
        Me.card_report_generator.Margin = New System.Windows.Forms.Padding(14)
        Me.card_report_generator.MouseState = MaterialSkin.MouseState.HOVER
        Me.card_report_generator.Name = "card_report_generator"
        Me.card_report_generator.Padding = New System.Windows.Forms.Padding(14)
        Me.card_report_generator.Size = New System.Drawing.Size(309, 328)
        Me.card_report_generator.TabIndex = 1
        '
        'lbl_reports_main
        '
        Me.lbl_reports_main.AutoSize = True
        Me.lbl_reports_main.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reports_main.Location = New System.Drawing.Point(38, 14)
        Me.lbl_reports_main.Name = "lbl_reports_main"
        Me.lbl_reports_main.Size = New System.Drawing.Size(245, 38)
        Me.lbl_reports_main.TabIndex = 2
        Me.lbl_reports_main.Text = "Report Generator"
        '
        'cb_reports
        '
        Me.cb_reports.AutoResize = False
        Me.cb_reports.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_reports.Depth = 0
        Me.cb_reports.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cb_reports.DropDownHeight = 174
        Me.cb_reports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_reports.DropDownWidth = 121
        Me.cb_reports.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cb_reports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cb_reports.FormattingEnabled = True
        Me.cb_reports.IntegralHeight = False
        Me.cb_reports.ItemHeight = 43
        Me.cb_reports.Items.AddRange(New Object() {"Cash Balance", "Cash In", "Cash Out"})
        Me.cb_reports.Location = New System.Drawing.Point(17, 79)
        Me.cb_reports.MaxDropDownItems = 4
        Me.cb_reports.MouseState = MaterialSkin.MouseState.OUT
        Me.cb_reports.Name = "cb_reports"
        Me.cb_reports.Size = New System.Drawing.Size(275, 49)
        Me.cb_reports.StartIndex = 0
        Me.cb_reports.TabIndex = 6
        '
        'dtp_reports_from
        '
        Me.dtp_reports_from.Location = New System.Drawing.Point(21, 169)
        Me.dtp_reports_from.Name = "dtp_reports_from"
        Me.dtp_reports_from.Size = New System.Drawing.Size(271, 20)
        Me.dtp_reports_from.TabIndex = 5
        '
        'dtp_reports_to
        '
        Me.dtp_reports_to.Location = New System.Drawing.Point(21, 229)
        Me.dtp_reports_to.Name = "dtp_reports_to"
        Me.dtp_reports_to.Size = New System.Drawing.Size(271, 20)
        Me.dtp_reports_to.TabIndex = 4
        '
        'lbl_reports_from
        '
        Me.lbl_reports_from.AutoSize = True
        Me.lbl_reports_from.Depth = 0
        Me.lbl_reports_from.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_reports_from.Location = New System.Drawing.Point(18, 147)
        Me.lbl_reports_from.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_reports_from.Name = "lbl_reports_from"
        Me.lbl_reports_from.Size = New System.Drawing.Size(42, 19)
        Me.lbl_reports_from.TabIndex = 3
        Me.lbl_reports_from.Text = "From:"
        '
        'lbl_reports_to
        '
        Me.lbl_reports_to.AutoSize = True
        Me.lbl_reports_to.Depth = 0
        Me.lbl_reports_to.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_reports_to.Location = New System.Drawing.Point(18, 206)
        Me.lbl_reports_to.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_reports_to.Name = "lbl_reports_to"
        Me.lbl_reports_to.Size = New System.Drawing.Size(24, 19)
        Me.lbl_reports_to.TabIndex = 2
        Me.lbl_reports_to.Text = "To:"
        '
        'lbl_reports_for
        '
        Me.lbl_reports_for.AutoSize = True
        Me.lbl_reports_for.Depth = 0
        Me.lbl_reports_for.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_reports_for.Location = New System.Drawing.Point(18, 57)
        Me.lbl_reports_for.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_reports_for.Name = "lbl_reports_for"
        Me.lbl_reports_for.Size = New System.Drawing.Size(28, 19)
        Me.lbl_reports_for.TabIndex = 1
        Me.lbl_reports_for.Text = "For:"
        '
        'btn_generate_report
        '
        Me.btn_generate_report.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_generate_report.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_generate_report.Depth = 0
        Me.btn_generate_report.HighEmphasis = True
        Me.btn_generate_report.Icon = Nothing
        Me.btn_generate_report.Location = New System.Drawing.Point(108, 281)
        Me.btn_generate_report.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_generate_report.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_generate_report.Name = "btn_generate_report"
        Me.btn_generate_report.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_generate_report.Size = New System.Drawing.Size(95, 36)
        Me.btn_generate_report.TabIndex = 0
        Me.btn_generate_report.Text = "Generate"
        Me.btn_generate_report.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_generate_report.UseAccentColor = False
        Me.btn_generate_report.UseVisualStyleBackColor = True
        '
        'tp7
        '
        Me.tp7.Controls.Add(Me.gb_accounts)
        Me.tp7.ImageKey = "account.png"
        Me.tp7.Location = New System.Drawing.Point(4, 39)
        Me.tp7.Name = "tp7"
        Me.tp7.Size = New System.Drawing.Size(986, 490)
        Me.tp7.TabIndex = 6
        Me.tp7.Text = "Accounts"
        Me.tp7.UseVisualStyleBackColor = True
        '
        'gb_accounts
        '
        Me.gb_accounts.Controls.Add(Me.lbl_director_main)
        Me.gb_accounts.Controls.Add(Me.lbl_admin_main)
        Me.gb_accounts.Controls.Add(Me.MaterialCard3)
        Me.gb_accounts.Controls.Add(Me.card_accounts_admin)
        Me.gb_accounts.Dock = System.Windows.Forms.DockStyle.Left
        Me.gb_accounts.Location = New System.Drawing.Point(0, 0)
        Me.gb_accounts.Name = "gb_accounts"
        Me.gb_accounts.Size = New System.Drawing.Size(914, 490)
        Me.gb_accounts.TabIndex = 0
        Me.gb_accounts.TabStop = False
        '
        'lbl_director_main
        '
        Me.lbl_director_main.AutoSize = True
        Me.lbl_director_main.Location = New System.Drawing.Point(465, 35)
        Me.lbl_director_main.Name = "lbl_director_main"
        Me.lbl_director_main.Size = New System.Drawing.Size(87, 13)
        Me.lbl_director_main.TabIndex = 10
        Me.lbl_director_main.Text = "Director Account"
        '
        'lbl_admin_main
        '
        Me.lbl_admin_main.AutoSize = True
        Me.lbl_admin_main.Location = New System.Drawing.Point(147, 35)
        Me.lbl_admin_main.Name = "lbl_admin_main"
        Me.lbl_admin_main.Size = New System.Drawing.Size(79, 13)
        Me.lbl_admin_main.TabIndex = 9
        Me.lbl_admin_main.Text = "Admin Account"
        '
        'MaterialCard3
        '
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.btn_set_director)
        Me.MaterialCard3.Controls.Add(Me.btn_director_update)
        Me.MaterialCard3.Controls.Add(Me.tb_director_current_password)
        Me.MaterialCard3.Controls.Add(Me.tb_director_new_password)
        Me.MaterialCard3.Controls.Add(Me.tb_director_username)
        Me.MaterialCard3.Controls.Add(Me.lbl_director_current_password)
        Me.MaterialCard3.Controls.Add(Me.lbl_director_password)
        Me.MaterialCard3.Controls.Add(Me.lbl_director_username)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(468, 71)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(290, 388)
        Me.MaterialCard3.TabIndex = 8
        '
        'btn_set_director
        '
        Me.btn_set_director.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_set_director.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_set_director.Depth = 0
        Me.btn_set_director.HighEmphasis = True
        Me.btn_set_director.Icon = Nothing
        Me.btn_set_director.Location = New System.Drawing.Point(118, 332)
        Me.btn_set_director.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_set_director.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_set_director.Name = "btn_set_director"
        Me.btn_set_director.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_set_director.Size = New System.Drawing.Size(64, 36)
        Me.btn_set_director.TabIndex = 8
        Me.btn_set_director.Text = "SET"
        Me.btn_set_director.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_set_director.UseAccentColor = False
        Me.btn_set_director.UseVisualStyleBackColor = True
        '
        'btn_director_update
        '
        Me.btn_director_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_director_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_director_update.Depth = 0
        Me.btn_director_update.HighEmphasis = True
        Me.btn_director_update.Icon = Nothing
        Me.btn_director_update.Location = New System.Drawing.Point(105, 332)
        Me.btn_director_update.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_director_update.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_director_update.Name = "btn_director_update"
        Me.btn_director_update.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_director_update.Size = New System.Drawing.Size(77, 36)
        Me.btn_director_update.TabIndex = 7
        Me.btn_director_update.Text = "UPDATE"
        Me.btn_director_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_director_update.UseAccentColor = False
        Me.btn_director_update.UseVisualStyleBackColor = True
        '
        'tb_director_current_password
        '
        Me.tb_director_current_password.AnimateReadOnly = False
        Me.tb_director_current_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_director_current_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_director_current_password.Depth = 0
        Me.tb_director_current_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_director_current_password.HideSelection = True
        Me.tb_director_current_password.LeadingIcon = Nothing
        Me.tb_director_current_password.Location = New System.Drawing.Point(17, 277)
        Me.tb_director_current_password.MaxLength = 32767
        Me.tb_director_current_password.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_director_current_password.Name = "tb_director_current_password"
        Me.tb_director_current_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_director_current_password.PrefixSuffixText = Nothing
        Me.tb_director_current_password.ReadOnly = False
        Me.tb_director_current_password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_director_current_password.SelectedText = ""
        Me.tb_director_current_password.SelectionLength = 0
        Me.tb_director_current_password.SelectionStart = 0
        Me.tb_director_current_password.ShortcutsEnabled = True
        Me.tb_director_current_password.Size = New System.Drawing.Size(256, 48)
        Me.tb_director_current_password.TabIndex = 6
        Me.tb_director_current_password.TabStop = False
        Me.tb_director_current_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_director_current_password.TrailingIcon = Nothing
        Me.tb_director_current_password.UseSystemPasswordChar = False
        '
        'tb_director_new_password
        '
        Me.tb_director_new_password.AnimateReadOnly = False
        Me.tb_director_new_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_director_new_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_director_new_password.Depth = 0
        Me.tb_director_new_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_director_new_password.HideSelection = True
        Me.tb_director_new_password.LeadingIcon = Nothing
        Me.tb_director_new_password.Location = New System.Drawing.Point(17, 131)
        Me.tb_director_new_password.MaxLength = 32767
        Me.tb_director_new_password.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_director_new_password.Name = "tb_director_new_password"
        Me.tb_director_new_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_director_new_password.PrefixSuffixText = Nothing
        Me.tb_director_new_password.ReadOnly = False
        Me.tb_director_new_password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_director_new_password.SelectedText = ""
        Me.tb_director_new_password.SelectionLength = 0
        Me.tb_director_new_password.SelectionStart = 0
        Me.tb_director_new_password.ShortcutsEnabled = True
        Me.tb_director_new_password.Size = New System.Drawing.Size(256, 48)
        Me.tb_director_new_password.TabIndex = 5
        Me.tb_director_new_password.TabStop = False
        Me.tb_director_new_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_director_new_password.TrailingIcon = Nothing
        Me.tb_director_new_password.UseSystemPasswordChar = False
        '
        'tb_director_username
        '
        Me.tb_director_username.AnimateReadOnly = False
        Me.tb_director_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_director_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_director_username.Depth = 0
        Me.tb_director_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_director_username.HideSelection = True
        Me.tb_director_username.LeadingIcon = Nothing
        Me.tb_director_username.Location = New System.Drawing.Point(17, 40)
        Me.tb_director_username.MaxLength = 32767
        Me.tb_director_username.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_director_username.Name = "tb_director_username"
        Me.tb_director_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_director_username.PrefixSuffixText = Nothing
        Me.tb_director_username.ReadOnly = False
        Me.tb_director_username.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_director_username.SelectedText = ""
        Me.tb_director_username.SelectionLength = 0
        Me.tb_director_username.SelectionStart = 0
        Me.tb_director_username.ShortcutsEnabled = True
        Me.tb_director_username.Size = New System.Drawing.Size(256, 48)
        Me.tb_director_username.TabIndex = 4
        Me.tb_director_username.TabStop = False
        Me.tb_director_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tb_director_username.TrailingIcon = Nothing
        Me.tb_director_username.UseSystemPasswordChar = False
        '
        'lbl_director_current_password
        '
        Me.lbl_director_current_password.AutoSize = True
        Me.lbl_director_current_password.Depth = 0
        Me.lbl_director_current_password.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_director_current_password.Location = New System.Drawing.Point(18, 255)
        Me.lbl_director_current_password.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_director_current_password.Name = "lbl_director_current_password"
        Me.lbl_director_current_password.Size = New System.Drawing.Size(130, 19)
        Me.lbl_director_current_password.TabIndex = 2
        Me.lbl_director_current_password.Text = "Current Password:"
        '
        'lbl_director_password
        '
        Me.lbl_director_password.AutoSize = True
        Me.lbl_director_password.Depth = 0
        Me.lbl_director_password.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_director_password.Location = New System.Drawing.Point(17, 109)
        Me.lbl_director_password.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_director_password.Name = "lbl_director_password"
        Me.lbl_director_password.Size = New System.Drawing.Size(75, 19)
        Me.lbl_director_password.TabIndex = 1
        Me.lbl_director_password.Text = "Password:"
        '
        'lbl_director_username
        '
        Me.lbl_director_username.AutoSize = True
        Me.lbl_director_username.Depth = 0
        Me.lbl_director_username.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_director_username.Location = New System.Drawing.Point(18, 18)
        Me.lbl_director_username.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_director_username.Name = "lbl_director_username"
        Me.lbl_director_username.Size = New System.Drawing.Size(76, 19)
        Me.lbl_director_username.TabIndex = 0
        Me.lbl_director_username.Text = "Username:"
        '
        'card_accounts_admin
        '
        Me.card_accounts_admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.card_accounts_admin.Controls.Add(Me.btn_accounts_admin_update)
        Me.card_accounts_admin.Controls.Add(Me.tb_admin_current_password)
        Me.card_accounts_admin.Controls.Add(Me.tb_admin_new_password)
        Me.card_accounts_admin.Controls.Add(Me.tb_admin_username)
        Me.card_accounts_admin.Controls.Add(Me.MaterialLabel4)
        Me.card_accounts_admin.Controls.Add(Me.MaterialLabel3)
        Me.card_accounts_admin.Controls.Add(Me.MaterialLabel2)
        Me.card_accounts_admin.Depth = 0
        Me.card_accounts_admin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.card_accounts_admin.Location = New System.Drawing.Point(150, 71)
        Me.card_accounts_admin.Margin = New System.Windows.Forms.Padding(14)
        Me.card_accounts_admin.MouseState = MaterialSkin.MouseState.HOVER
        Me.card_accounts_admin.Name = "card_accounts_admin"
        Me.card_accounts_admin.Padding = New System.Windows.Forms.Padding(14)
        Me.card_accounts_admin.Size = New System.Drawing.Size(290, 388)
        Me.card_accounts_admin.TabIndex = 0
        '
        'btn_accounts_admin_update
        '
        Me.btn_accounts_admin_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_accounts_admin_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_accounts_admin_update.Depth = 0
        Me.btn_accounts_admin_update.HighEmphasis = True
        Me.btn_accounts_admin_update.Icon = Nothing
        Me.btn_accounts_admin_update.Location = New System.Drawing.Point(105, 334)
        Me.btn_accounts_admin_update.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_accounts_admin_update.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_accounts_admin_update.Name = "btn_accounts_admin_update"
        Me.btn_accounts_admin_update.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_accounts_admin_update.Size = New System.Drawing.Size(77, 36)
        Me.btn_accounts_admin_update.TabIndex = 7
        Me.btn_accounts_admin_update.Text = "UPDATE"
        Me.btn_accounts_admin_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_accounts_admin_update.UseAccentColor = False
        Me.btn_accounts_admin_update.UseVisualStyleBackColor = True
        '
        'tb_admin_current_password
        '
        Me.tb_admin_current_password.AnimateReadOnly = False
        Me.tb_admin_current_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_admin_current_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_admin_current_password.Depth = 0
        Me.tb_admin_current_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_admin_current_password.HideSelection = True
        Me.tb_admin_current_password.LeadingIcon = Nothing
        Me.tb_admin_current_password.Location = New System.Drawing.Point(17, 277)
        Me.tb_admin_current_password.MaxLength = 32767
        Me.tb_admin_current_password.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_admin_current_password.Name = "tb_admin_current_password"
        Me.tb_admin_current_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_admin_current_password.PrefixSuffixText = Nothing
        Me.tb_admin_current_password.ReadOnly = False
        Me.tb_admin_current_password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_admin_current_password.SelectedText = ""
        Me.tb_admin_current_password.SelectionLength = 0
        Me.tb_admin_current_password.SelectionStart = 0
        Me.tb_admin_current_password.ShortcutsEnabled = True
        Me.tb_admin_current_password.Size = New System.Drawing.Size(256, 48)
        Me.tb_admin_current_password.TabIndex = 6
        Me.tb_admin_current_password.TabStop = False
        Me.tb_admin_current_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_admin_current_password.TrailingIcon = Nothing
        Me.tb_admin_current_password.UseSystemPasswordChar = False
        '
        'tb_admin_new_password
        '
        Me.tb_admin_new_password.AnimateReadOnly = False
        Me.tb_admin_new_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_admin_new_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_admin_new_password.Depth = 0
        Me.tb_admin_new_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_admin_new_password.HideSelection = True
        Me.tb_admin_new_password.LeadingIcon = Nothing
        Me.tb_admin_new_password.Location = New System.Drawing.Point(17, 131)
        Me.tb_admin_new_password.MaxLength = 32767
        Me.tb_admin_new_password.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_admin_new_password.Name = "tb_admin_new_password"
        Me.tb_admin_new_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_admin_new_password.PrefixSuffixText = Nothing
        Me.tb_admin_new_password.ReadOnly = False
        Me.tb_admin_new_password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_admin_new_password.SelectedText = ""
        Me.tb_admin_new_password.SelectionLength = 0
        Me.tb_admin_new_password.SelectionStart = 0
        Me.tb_admin_new_password.ShortcutsEnabled = True
        Me.tb_admin_new_password.Size = New System.Drawing.Size(256, 48)
        Me.tb_admin_new_password.TabIndex = 5
        Me.tb_admin_new_password.TabStop = False
        Me.tb_admin_new_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_admin_new_password.TrailingIcon = Nothing
        Me.tb_admin_new_password.UseSystemPasswordChar = False
        '
        'tb_admin_username
        '
        Me.tb_admin_username.AnimateReadOnly = False
        Me.tb_admin_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_admin_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_admin_username.Depth = 0
        Me.tb_admin_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_admin_username.HideSelection = True
        Me.tb_admin_username.LeadingIcon = Nothing
        Me.tb_admin_username.Location = New System.Drawing.Point(17, 40)
        Me.tb_admin_username.MaxLength = 32767
        Me.tb_admin_username.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_admin_username.Name = "tb_admin_username"
        Me.tb_admin_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_admin_username.PrefixSuffixText = Nothing
        Me.tb_admin_username.ReadOnly = False
        Me.tb_admin_username.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_admin_username.SelectedText = ""
        Me.tb_admin_username.SelectionLength = 0
        Me.tb_admin_username.SelectionStart = 0
        Me.tb_admin_username.ShortcutsEnabled = True
        Me.tb_admin_username.Size = New System.Drawing.Size(256, 48)
        Me.tb_admin_username.TabIndex = 4
        Me.tb_admin_username.TabStop = False
        Me.tb_admin_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tb_admin_username.TrailingIcon = Nothing
        Me.tb_admin_username.UseSystemPasswordChar = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.Location = New System.Drawing.Point(18, 255)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(130, 19)
        Me.MaterialLabel4.TabIndex = 2
        Me.MaterialLabel4.Text = "Current Password:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(17, 109)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(75, 19)
        Me.MaterialLabel3.TabIndex = 1
        Me.MaterialLabel3.Text = "Password:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(18, 18)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(76, 19)
        Me.MaterialLabel2.TabIndex = 0
        Me.MaterialLabel2.Text = "Username:"
        '
        'tp8
        '
        Me.tp8.ImageKey = "power-off.png"
        Me.tp8.Location = New System.Drawing.Point(4, 39)
        Me.tp8.Name = "tp8"
        Me.tp8.Size = New System.Drawing.Size(986, 490)
        Me.tp8.TabIndex = 7
        Me.tp8.Text = "Logout"
        Me.tp8.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.MTC_MAIN)
        Me.DrawerShowIconsWhenHidden = True
        Me.DrawerTabControl = Me.MTC_MAIN
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 600)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CES - Financial Inventory System - Students"
        Me.tp2.ResumeLayout(False)
        Me.gb_enroll.ResumeLayout(False)
        Me.gb_enroll.PerformLayout()
        Me.tp3.ResumeLayout(False)
        Me.gb_payment.ResumeLayout(False)
        Me.gb_payment.PerformLayout()
        Me.gb_payment_info.ResumeLayout(False)
        Me.card_remaining_balance.ResumeLayout(False)
        Me.card_remaining_balance.PerformLayout()
        Me.card_total_paid.ResumeLayout(False)
        Me.card_total_paid.PerformLayout()
        Me.card_balance_total.ResumeLayout(False)
        Me.card_balance_total.PerformLayout()
        Me.card_payments_made.ResumeLayout(False)
        Me.card_payments_made.PerformLayout()
        CType(Me.dgv_payments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp1.ResumeLayout(False)
        Me.tp1.PerformLayout()
        Me.gb_main.ResumeLayout(False)
        CType(Me.dgv_main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MTC_MAIN.ResumeLayout(False)
        Me.tp4.ResumeLayout(False)
        Me.gb_funds.ResumeLayout(False)
        Me.gb_funds.PerformLayout()
        CType(Me.chart_funds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_funds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp5.ResumeLayout(False)
        Me.gb_expenses.ResumeLayout(False)
        Me.gb_expenses.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        CType(Me.dgv_expenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp6.ResumeLayout(False)
        Me.gb_reports.ResumeLayout(False)
        Me.card_report_generator.ResumeLayout(False)
        Me.card_report_generator.PerformLayout()
        Me.tp7.ResumeLayout(False)
        Me.gb_accounts.ResumeLayout(False)
        Me.gb_accounts.PerformLayout()
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        Me.card_accounts_admin.ResumeLayout(False)
        Me.card_accounts_admin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IL_TABS As ImageList
    Friend WithEvents tp2 As TabPage
    Friend WithEvents tp3 As TabPage
    Friend WithEvents tp1 As TabPage
    Friend WithEvents MTC_MAIN As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tp4 As TabPage
    Friend WithEvents gb_main As GroupBox
    Friend WithEvents dgv_main As DataGridView
    Friend WithEvents tb_search As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_delete As MaterialSkin.Controls.MaterialButton
    Friend WithEvents gb_enroll As GroupBox
    Friend WithEvents lbl_student_name As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tb_given_name As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents cb_civil_status As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents lbl_civil_status As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_family_name As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tb_family_name As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents lbl_student_middle_name As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tb_middle_name As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents tb_edat_vocational As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents tb_edat_college As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents tb_edat_hs As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents tb_edat_elem As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents lbl_so As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_employer As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_oa As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_first_job As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_occupation As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_eav As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_eac As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_eah As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_eae As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_ea As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tb_course As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents lbl_course As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tb_contact_number As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents lbl_contact_number As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tb_address As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents lbl_address As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_age As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtp_dob As DateTimePicker
    Friend WithEvents lbl_DOB As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tb_spouse_occupation As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents tb_employer As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents tb_occupation_address As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents tb_present_job As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents tb_occupation As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents btn_enroll As MaterialSkin.Controls.MaterialButton
    Friend WithEvents tb_age As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents gb_funds As GroupBox
    Friend WithEvents lbl_manage As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_item As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_remove_item As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_add_funds As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_add_item As MaterialSkin.Controls.MaterialButton
    Friend WithEvents dgv_funds As DataGridView
    Friend WithEvents btn_transaction_history As MaterialSkin.Controls.MaterialButton
    Friend WithEvents chart_funds As DataVisualization.Charting.Chart
    Friend WithEvents btn_update_student_record As MaterialSkin.Controls.MaterialButton
    Friend WithEvents gb_payment As GroupBox
    Friend WithEvents btn_set_balance As MaterialSkin.Controls.MaterialButton
    Friend WithEvents dgv_payments As DataGridView
    Friend WithEvents btn_select As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cb_student_list As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btn_pay As MaterialSkin.Controls.MaterialButton
    Friend WithEvents gb_payment_info As GroupBox
    Friend WithEvents lvl_payment_count As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents card_remaining_balance As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lbl_remaining_balance As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents card_total_paid As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lvl_total_paid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents card_payments_made As MaterialSkin.Controls.MaterialCard
    Friend WithEvents card_balance_total As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_remaining_balance_value As Label
    Friend WithEvents lbl_total_paid_value As Label
    Friend WithEvents lbl_payments_made_value As Label
    Friend WithEvents lbl_balance_total_value As Label
    Friend WithEvents tp5 As TabPage
    Friend WithEvents gb_expenses As GroupBox
    Friend WithEvents dgv_expenses As DataGridView
    Friend WithEvents tb_expenses_desc As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents dtp_expenses_date As DateTimePicker
    Friend WithEvents lbl_date As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tb_expenses_amount As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btn_expenses_add As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lbl_expenses_amount As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_expenses_description As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_expenses_date_filter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents dtp_expenses_date_filter_after As DateTimePicker
    Friend WithEvents dtp_expenses_date_filter_before As DateTimePicker
    Friend WithEvents lbl_date_to As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_date_from As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lbl_expense_total_value As Label
    Friend WithEvents lbl_expense_total As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_expenses_reset As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_expenses_delete As MaterialSkin.Controls.MaterialButton
    Friend WithEvents tp6 As TabPage
    Friend WithEvents gb_reports As GroupBox
    Friend WithEvents card_report_generator As MaterialSkin.Controls.MaterialCard
    Friend WithEvents cb_reports As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents dtp_reports_from As DateTimePicker
    Friend WithEvents dtp_reports_to As DateTimePicker
    Friend WithEvents lbl_reports_from As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_reports_to As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_reports_for As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_generate_report As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lbl_reports_main As Label
    Friend WithEvents tp7 As TabPage
    Friend WithEvents gb_accounts As GroupBox
    Friend WithEvents card_accounts_admin As MaterialSkin.Controls.MaterialCard
    Friend WithEvents btn_accounts_admin_update As MaterialSkin.Controls.MaterialButton
    Friend WithEvents tb_admin_current_password As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents tb_admin_new_password As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents tb_admin_username As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents btn_director_update As MaterialSkin.Controls.MaterialButton
    Friend WithEvents tb_director_current_password As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents tb_director_new_password As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents tb_director_username As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents lbl_director_current_password As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_director_password As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_director_username As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_set_director As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lbl_director_main As Label
    Friend WithEvents lbl_admin_main As Label
    Friend WithEvents tp8 As TabPage
    Friend WithEvents btn_delete_payment_record As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lbl_aye As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cb_aye As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents lbl_availablefunds As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_bae As Label
End Class
