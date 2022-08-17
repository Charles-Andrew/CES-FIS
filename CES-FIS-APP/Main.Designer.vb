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
        Me.IL_TABS = New System.Windows.Forms.ImageList(Me.components)
        Me.tp2 = New System.Windows.Forms.TabPage()
        Me.gb_enroll = New System.Windows.Forms.GroupBox()
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
        Me.tp1 = New System.Windows.Forms.TabPage()
        Me.btn_delete = New MaterialSkin.Controls.MaterialButton()
        Me.btn_search = New MaterialSkin.Controls.MaterialButton()
        Me.tb_search = New MaterialSkin.Controls.MaterialTextBox2()
        Me.gb_main = New System.Windows.Forms.GroupBox()
        Me.dgv_main = New System.Windows.Forms.DataGridView()
        Me.MTC_MAIN = New MaterialSkin.Controls.MaterialTabControl()
        Me.tp4 = New System.Windows.Forms.TabPage()
        Me.gb_funds = New System.Windows.Forms.GroupBox()
        Me.lbl_manage = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_item = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_remove_item = New MaterialSkin.Controls.MaterialButton()
        Me.btn_add_funds = New MaterialSkin.Controls.MaterialButton()
        Me.btn_add_item = New MaterialSkin.Controls.MaterialButton()
        Me.dgv_funds = New System.Windows.Forms.DataGridView()
        Me.tp2.SuspendLayout()
        Me.gb_enroll.SuspendLayout()
        Me.tp1.SuspendLayout()
        Me.gb_main.SuspendLayout()
        CType(Me.dgv_main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MTC_MAIN.SuspendLayout()
        Me.tp4.SuspendLayout()
        Me.gb_funds.SuspendLayout()
        CType(Me.dgv_funds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IL_TABS
        '
        Me.IL_TABS.ImageStream = CType(resources.GetObject("IL_TABS.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL_TABS.TransparentColor = System.Drawing.Color.Transparent
        Me.IL_TABS.Images.SetKeyName(0, "home.png")
        Me.IL_TABS.Images.SetKeyName(1, "user.png")
        '
        'tp2
        '
        Me.tp2.Controls.Add(Me.gb_enroll)
        Me.tp2.ImageIndex = 1
        Me.tp2.Location = New System.Drawing.Point(4, 23)
        Me.tp2.Name = "tp2"
        Me.tp2.Padding = New System.Windows.Forms.Padding(3)
        Me.tp2.Size = New System.Drawing.Size(986, 506)
        Me.tp2.TabIndex = 2
        Me.tp2.Text = "Enroll"
        Me.tp2.UseVisualStyleBackColor = True
        '
        'gb_enroll
        '
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
        Me.gb_enroll.Size = New System.Drawing.Size(931, 500)
        Me.gb_enroll.TabIndex = 0
        Me.gb_enroll.TabStop = False
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
        Me.btn_enroll.Text = "Enroll"
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
        Me.tb_spouse_occupation.Location = New System.Drawing.Point(559, 386)
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
        Me.tb_employer.Location = New System.Drawing.Point(559, 351)
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
        Me.tb_occupation_address.Location = New System.Drawing.Point(559, 316)
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
        Me.tb_present_job.Location = New System.Drawing.Point(559, 281)
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
        Me.tb_occupation.Location = New System.Drawing.Point(559, 246)
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
        Me.tb_edat_vocational.Location = New System.Drawing.Point(585, 189)
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
        Me.tb_edat_college.Location = New System.Drawing.Point(585, 154)
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
        Me.tb_edat_hs.Location = New System.Drawing.Point(585, 119)
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
        Me.tb_edat_elem.Location = New System.Drawing.Point(585, 84)
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
        Me.lbl_so.Location = New System.Drawing.Point(385, 386)
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
        Me.lbl_employer.Location = New System.Drawing.Point(385, 351)
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
        Me.lbl_oa.Location = New System.Drawing.Point(385, 316)
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
        Me.lbl_first_job.Location = New System.Drawing.Point(385, 281)
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
        Me.lbl_occupation.Location = New System.Drawing.Point(385, 246)
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
        Me.lbl_eav.Location = New System.Drawing.Point(415, 184)
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
        Me.lbl_eac.Location = New System.Drawing.Point(415, 152)
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
        Me.lbl_eah.Location = New System.Drawing.Point(415, 122)
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
        Me.lbl_eae.Location = New System.Drawing.Point(415, 86)
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
        Me.lbl_ea.Location = New System.Drawing.Point(385, 52)
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
        Me.cb_civil_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.tp3.ImageKey = "user.png"
        Me.tp3.Location = New System.Drawing.Point(4, 23)
        Me.tp3.Name = "tp3"
        Me.tp3.Padding = New System.Windows.Forms.Padding(3)
        Me.tp3.Size = New System.Drawing.Size(986, 506)
        Me.tp3.TabIndex = 1
        Me.tp3.Text = "Payment"
        '
        'tp1
        '
        Me.tp1.BackColor = System.Drawing.Color.White
        Me.tp1.Controls.Add(Me.btn_delete)
        Me.tp1.Controls.Add(Me.btn_search)
        Me.tp1.Controls.Add(Me.tb_search)
        Me.tp1.Controls.Add(Me.gb_main)
        Me.tp1.ImageKey = "home.png"
        Me.tp1.Location = New System.Drawing.Point(4, 23)
        Me.tp1.Name = "tp1"
        Me.tp1.Padding = New System.Windows.Forms.Padding(3)
        Me.tp1.Size = New System.Drawing.Size(986, 506)
        Me.tp1.TabIndex = 0
        Me.tp1.Text = "Home"
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
        Me.dgv_main.AllowUserToDeleteRows = False
        Me.dgv_main.AllowUserToResizeRows = False
        Me.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_main.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgv_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_main.Location = New System.Drawing.Point(3, 16)
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
        Me.tp4.Controls.Add(Me.gb_funds)
        Me.tp4.ImageIndex = 1
        Me.tp4.Location = New System.Drawing.Point(4, 23)
        Me.tp4.Name = "tp4"
        Me.tp4.Size = New System.Drawing.Size(986, 506)
        Me.tp4.TabIndex = 3
        Me.tp4.Text = "Funds"
        Me.tp4.UseVisualStyleBackColor = True
        '
        'gb_funds
        '
        Me.gb_funds.Controls.Add(Me.lbl_manage)
        Me.gb_funds.Controls.Add(Me.lbl_item)
        Me.gb_funds.Controls.Add(Me.btn_remove_item)
        Me.gb_funds.Controls.Add(Me.btn_add_funds)
        Me.gb_funds.Controls.Add(Me.btn_add_item)
        Me.gb_funds.Controls.Add(Me.dgv_funds)
        Me.gb_funds.Dock = System.Windows.Forms.DockStyle.Left
        Me.gb_funds.Location = New System.Drawing.Point(0, 0)
        Me.gb_funds.Name = "gb_funds"
        Me.gb_funds.Size = New System.Drawing.Size(914, 506)
        Me.gb_funds.TabIndex = 0
        Me.gb_funds.TabStop = False
        '
        'lbl_manage
        '
        Me.lbl_manage.AutoSize = True
        Me.lbl_manage.Depth = 0
        Me.lbl_manage.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_manage.Location = New System.Drawing.Point(311, 406)
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
        Me.btn_add_funds.Location = New System.Drawing.Point(314, 431)
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
        Me.dgv_funds.Name = "dgv_funds"
        Me.dgv_funds.ReadOnly = True
        Me.dgv_funds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_funds.Size = New System.Drawing.Size(508, 384)
        Me.dgv_funds.TabIndex = 0
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
        Me.Text = "CES - Financial Inventory System"
        Me.tp2.ResumeLayout(False)
        Me.gb_enroll.ResumeLayout(False)
        Me.gb_enroll.PerformLayout()
        Me.tp1.ResumeLayout(False)
        Me.tp1.PerformLayout()
        Me.gb_main.ResumeLayout(False)
        CType(Me.dgv_main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MTC_MAIN.ResumeLayout(False)
        Me.tp4.ResumeLayout(False)
        Me.gb_funds.ResumeLayout(False)
        Me.gb_funds.PerformLayout()
        CType(Me.dgv_funds, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
