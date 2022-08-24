<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Balance
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
        Me.lbl_student_balance = New MaterialSkin.Controls.MaterialLabel()
        Me.tb_balance = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btn_update_balance = New MaterialSkin.Controls.MaterialButton()
        Me.btn_pay_new = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'lbl_student_balance
        '
        Me.lbl_student_balance.AutoSize = True
        Me.lbl_student_balance.Depth = 0
        Me.lbl_student_balance.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_student_balance.Location = New System.Drawing.Point(6, 98)
        Me.lbl_student_balance.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_student_balance.Name = "lbl_student_balance"
        Me.lbl_student_balance.Size = New System.Drawing.Size(117, 19)
        Me.lbl_student_balance.TabIndex = 0
        Me.lbl_student_balance.Text = "Current Balance:"
        '
        'tb_balance
        '
        Me.tb_balance.AnimateReadOnly = False
        Me.tb_balance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_balance.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_balance.Depth = 0
        Me.tb_balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_balance.HideSelection = True
        Me.tb_balance.LeadingIcon = Nothing
        Me.tb_balance.Location = New System.Drawing.Point(152, 81)
        Me.tb_balance.MaxLength = 32767
        Me.tb_balance.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_balance.Name = "tb_balance"
        Me.tb_balance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_balance.PrefixSuffixText = Nothing
        Me.tb_balance.ReadOnly = False
        Me.tb_balance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_balance.SelectedText = ""
        Me.tb_balance.SelectionLength = 0
        Me.tb_balance.SelectionStart = 0
        Me.tb_balance.ShortcutsEnabled = True
        Me.tb_balance.Size = New System.Drawing.Size(250, 48)
        Me.tb_balance.TabIndex = 1
        Me.tb_balance.TabStop = False
        Me.tb_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tb_balance.TrailingIcon = Nothing
        Me.tb_balance.UseSystemPasswordChar = False
        '
        'btn_update_balance
        '
        Me.btn_update_balance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_update_balance.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_update_balance.Depth = 0
        Me.btn_update_balance.HighEmphasis = True
        Me.btn_update_balance.Icon = Nothing
        Me.btn_update_balance.Location = New System.Drawing.Point(421, 88)
        Me.btn_update_balance.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_update_balance.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_update_balance.Name = "btn_update_balance"
        Me.btn_update_balance.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_update_balance.Size = New System.Drawing.Size(77, 36)
        Me.btn_update_balance.TabIndex = 2
        Me.btn_update_balance.Text = "Update"
        Me.btn_update_balance.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_update_balance.UseAccentColor = False
        Me.btn_update_balance.UseVisualStyleBackColor = True
        '
        'btn_pay_new
        '
        Me.btn_pay_new.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_pay_new.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_pay_new.Depth = 0
        Me.btn_pay_new.HighEmphasis = True
        Me.btn_pay_new.Icon = Nothing
        Me.btn_pay_new.Location = New System.Drawing.Point(421, 88)
        Me.btn_pay_new.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_pay_new.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_pay_new.Name = "btn_pay_new"
        Me.btn_pay_new.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_pay_new.Size = New System.Drawing.Size(64, 36)
        Me.btn_pay_new.TabIndex = 3
        Me.btn_pay_new.Text = "Pay"
        Me.btn_pay_new.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_pay_new.UseAccentColor = False
        Me.btn_pay_new.UseVisualStyleBackColor = True
        Me.btn_pay_new.Visible = False
        '
        'Student_Balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 158)
        Me.Controls.Add(Me.btn_pay_new)
        Me.Controls.Add(Me.btn_update_balance)
        Me.Controls.Add(Me.tb_balance)
        Me.Controls.Add(Me.lbl_student_balance)
        Me.MaximizeBox = False
        Me.Name = "Student_Balance"
        Me.Text = "Student Balance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_student_balance As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tb_balance As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btn_update_balance As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_pay_new As MaterialSkin.Controls.MaterialButton
End Class
