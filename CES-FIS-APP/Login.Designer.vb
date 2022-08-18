<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.login_card = New MaterialSkin.Controls.MaterialCard()
        Me.tb_pass = New MaterialSkin.Controls.MaterialTextBox2()
        Me.tb_user = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btn_create_admin = New MaterialSkin.Controls.MaterialButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pb_user = New System.Windows.Forms.PictureBox()
        Me.pb_password = New System.Windows.Forms.PictureBox()
        Me.btn_login = New MaterialSkin.Controls.MaterialButton()
        Me.login_card.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_password, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'login_card
        '
        Me.login_card.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.login_card.Controls.Add(Me.tb_pass)
        Me.login_card.Controls.Add(Me.tb_user)
        Me.login_card.Controls.Add(Me.btn_create_admin)
        Me.login_card.Controls.Add(Me.PictureBox1)
        Me.login_card.Controls.Add(Me.pb_user)
        Me.login_card.Controls.Add(Me.pb_password)
        Me.login_card.Controls.Add(Me.btn_login)
        Me.login_card.Depth = 0
        Me.login_card.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.login_card.Location = New System.Drawing.Point(17, 72)
        Me.login_card.Margin = New System.Windows.Forms.Padding(14)
        Me.login_card.MouseState = MaterialSkin.MouseState.HOVER
        Me.login_card.Name = "login_card"
        Me.login_card.Padding = New System.Windows.Forms.Padding(14)
        Me.login_card.Size = New System.Drawing.Size(357, 363)
        Me.login_card.TabIndex = 1
        '
        'tb_pass
        '
        Me.tb_pass.AnimateReadOnly = False
        Me.tb_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_pass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_pass.Depth = 0
        Me.tb_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_pass.HideSelection = True
        Me.tb_pass.LeadingIcon = Nothing
        Me.tb_pass.Location = New System.Drawing.Point(68, 244)
        Me.tb_pass.MaxLength = 32767
        Me.tb_pass.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_pass.Name = "tb_pass"
        Me.tb_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_pass.PrefixSuffixText = Nothing
        Me.tb_pass.ReadOnly = False
        Me.tb_pass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_pass.SelectedText = ""
        Me.tb_pass.SelectionLength = 0
        Me.tb_pass.SelectionStart = 0
        Me.tb_pass.ShortcutsEnabled = True
        Me.tb_pass.Size = New System.Drawing.Size(269, 48)
        Me.tb_pass.TabIndex = 11
        Me.tb_pass.TabStop = False
        Me.tb_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_pass.TrailingIcon = Nothing
        Me.tb_pass.UseSystemPasswordChar = False
        '
        'tb_user
        '
        Me.tb_user.AnimateReadOnly = False
        Me.tb_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_user.Depth = 0
        Me.tb_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_user.HideSelection = True
        Me.tb_user.LeadingIcon = Nothing
        Me.tb_user.Location = New System.Drawing.Point(68, 175)
        Me.tb_user.MaxLength = 32767
        Me.tb_user.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_user.Name = "tb_user"
        Me.tb_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_user.PrefixSuffixText = Nothing
        Me.tb_user.ReadOnly = False
        Me.tb_user.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_user.SelectedText = ""
        Me.tb_user.SelectionLength = 0
        Me.tb_user.SelectionStart = 0
        Me.tb_user.ShortcutsEnabled = True
        Me.tb_user.Size = New System.Drawing.Size(269, 48)
        Me.tb_user.TabIndex = 10
        Me.tb_user.TabStop = False
        Me.tb_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_user.TrailingIcon = Nothing
        Me.tb_user.UseSystemPasswordChar = False
        '
        'btn_create_admin
        '
        Me.btn_create_admin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_create_admin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_create_admin.Depth = 0
        Me.btn_create_admin.HighEmphasis = True
        Me.btn_create_admin.Icon = Nothing
        Me.btn_create_admin.Location = New System.Drawing.Point(137, 308)
        Me.btn_create_admin.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_create_admin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_create_admin.Name = "btn_create_admin"
        Me.btn_create_admin.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_create_admin.Size = New System.Drawing.Size(126, 36)
        Me.btn_create_admin.TabIndex = 9
        Me.btn_create_admin.Text = "CREATE ADMIN"
        Me.btn_create_admin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_create_admin.UseAccentColor = False
        Me.btn_create_admin.UseVisualStyleBackColor = True
        Me.btn_create_admin.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CES_FIS_APP.My.Resources.Resources.manager
        Me.PictureBox1.Location = New System.Drawing.Point(131, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 133)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'pb_user
        '
        Me.pb_user.Image = CType(resources.GetObject("pb_user.Image"), System.Drawing.Image)
        Me.pb_user.Location = New System.Drawing.Point(10, 186)
        Me.pb_user.Name = "pb_user"
        Me.pb_user.Size = New System.Drawing.Size(33, 37)
        Me.pb_user.TabIndex = 7
        Me.pb_user.TabStop = False
        '
        'pb_password
        '
        Me.pb_password.Image = Global.CES_FIS_APP.My.Resources.Resources.padlock
        Me.pb_password.Location = New System.Drawing.Point(10, 254)
        Me.pb_password.Name = "pb_password"
        Me.pb_password.Size = New System.Drawing.Size(33, 37)
        Me.pb_password.TabIndex = 6
        Me.pb_password.TabStop = False
        '
        'btn_login
        '
        Me.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_login.Depth = 0
        Me.btn_login.HighEmphasis = True
        Me.btn_login.Icon = Nothing
        Me.btn_login.Location = New System.Drawing.Point(170, 308)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_login.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_login.Name = "btn_login"
        Me.btn_login.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_login.Size = New System.Drawing.Size(64, 36)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_login.UseAccentColor = False
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 455)
        Me.Controls.Add(Me.login_card)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.login_card.ResumeLayout(False)
        Me.login_card.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_password, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents login_card As MaterialSkin.Controls.MaterialCard
    Friend WithEvents btn_create_admin As MaterialSkin.Controls.MaterialButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pb_user As PictureBox
    Friend WithEvents pb_password As PictureBox
    Friend WithEvents btn_login As MaterialSkin.Controls.MaterialButton
    Friend WithEvents tb_pass As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents tb_user As MaterialSkin.Controls.MaterialTextBox2
End Class
