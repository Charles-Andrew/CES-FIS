<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Items
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
        Me.lbl_item_name = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_amount = New MaterialSkin.Controls.MaterialLabel()
        Me.tb_name = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btn_item_add = New MaterialSkin.Controls.MaterialButton()
        Me.tb_item_amount = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btn_add_funds = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'lbl_item_name
        '
        Me.lbl_item_name.AutoSize = True
        Me.lbl_item_name.Depth = 0
        Me.lbl_item_name.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_item_name.Location = New System.Drawing.Point(17, 81)
        Me.lbl_item_name.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_item_name.Name = "lbl_item_name"
        Me.lbl_item_name.Size = New System.Drawing.Size(47, 19)
        Me.lbl_item_name.TabIndex = 0
        Me.lbl_item_name.Text = "Name:"
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Depth = 0
        Me.lbl_amount.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_amount.Location = New System.Drawing.Point(17, 153)
        Me.lbl_amount.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(61, 19)
        Me.lbl_amount.TabIndex = 1
        Me.lbl_amount.Text = "Amount:"
        '
        'tb_name
        '
        Me.tb_name.AnimateReadOnly = False
        Me.tb_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_name.Depth = 0
        Me.tb_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_name.HideSelection = True
        Me.tb_name.LeadingIcon = Nothing
        Me.tb_name.Location = New System.Drawing.Point(99, 81)
        Me.tb_name.MaxLength = 32767
        Me.tb_name.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_name.Name = "tb_name"
        Me.tb_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_name.PrefixSuffixText = Nothing
        Me.tb_name.ReadOnly = False
        Me.tb_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_name.SelectedText = ""
        Me.tb_name.SelectionLength = 0
        Me.tb_name.SelectionStart = 0
        Me.tb_name.ShortcutsEnabled = True
        Me.tb_name.Size = New System.Drawing.Size(295, 48)
        Me.tb_name.TabIndex = 2
        Me.tb_name.TabStop = False
        Me.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_name.TrailingIcon = Nothing
        Me.tb_name.UseSystemPasswordChar = False
        '
        'btn_item_add
        '
        Me.btn_item_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_item_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_item_add.Depth = 0
        Me.btn_item_add.HighEmphasis = True
        Me.btn_item_add.Icon = Nothing
        Me.btn_item_add.Location = New System.Drawing.Point(270, 210)
        Me.btn_item_add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_item_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_item_add.Name = "btn_item_add"
        Me.btn_item_add.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_item_add.Size = New System.Drawing.Size(124, 36)
        Me.btn_item_add.TabIndex = 4
        Me.btn_item_add.Text = "Add New Item"
        Me.btn_item_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_item_add.UseAccentColor = False
        Me.btn_item_add.UseVisualStyleBackColor = True
        '
        'tb_item_amount
        '
        Me.tb_item_amount.AnimateReadOnly = False
        Me.tb_item_amount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_item_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_item_amount.Depth = 0
        Me.tb_item_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tb_item_amount.HideSelection = True
        Me.tb_item_amount.LeadingIcon = Nothing
        Me.tb_item_amount.Location = New System.Drawing.Point(99, 153)
        Me.tb_item_amount.MaxLength = 7
        Me.tb_item_amount.MouseState = MaterialSkin.MouseState.OUT
        Me.tb_item_amount.Name = "tb_item_amount"
        Me.tb_item_amount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_item_amount.PrefixSuffixText = Nothing
        Me.tb_item_amount.ReadOnly = False
        Me.tb_item_amount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_item_amount.SelectedText = ""
        Me.tb_item_amount.SelectionLength = 0
        Me.tb_item_amount.SelectionStart = 0
        Me.tb_item_amount.ShortcutsEnabled = True
        Me.tb_item_amount.Size = New System.Drawing.Size(295, 48)
        Me.tb_item_amount.TabIndex = 5
        Me.tb_item_amount.TabStop = False
        Me.tb_item_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_item_amount.TrailingIcon = Nothing
        Me.tb_item_amount.UseSystemPasswordChar = False
        '
        'btn_add_funds
        '
        Me.btn_add_funds.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_add_funds.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_add_funds.Depth = 0
        Me.btn_add_funds.HighEmphasis = True
        Me.btn_add_funds.Icon = Nothing
        Me.btn_add_funds.Location = New System.Drawing.Point(293, 210)
        Me.btn_add_funds.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_add_funds.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_add_funds.Name = "btn_add_funds"
        Me.btn_add_funds.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_add_funds.Size = New System.Drawing.Size(101, 36)
        Me.btn_add_funds.TabIndex = 6
        Me.btn_add_funds.Text = "Add Funds"
        Me.btn_add_funds.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_add_funds.UseAccentColor = False
        Me.btn_add_funds.UseVisualStyleBackColor = True
        Me.btn_add_funds.Visible = False
        '
        'Add_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 259)
        Me.Controls.Add(Me.btn_add_funds)
        Me.Controls.Add(Me.tb_item_amount)
        Me.Controls.Add(Me.btn_item_add)
        Me.Controls.Add(Me.tb_name)
        Me.Controls.Add(Me.lbl_amount)
        Me.Controls.Add(Me.lbl_item_name)
        Me.MaximizeBox = False
        Me.Name = "Add_Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Items"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_item_name As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_amount As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tb_name As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btn_item_add As MaterialSkin.Controls.MaterialButton
    Friend WithEvents tb_item_amount As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btn_add_funds As MaterialSkin.Controls.MaterialButton
End Class
