<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_History
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_transaction_history = New System.Windows.Forms.DataGridView()
        Me.lbl_item_name = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_item = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_delete = New MaterialSkin.Controls.MaterialButton()
        CType(Me.dgv_transaction_history, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_transaction_history
        '
        Me.dgv_transaction_history.AllowUserToAddRows = False
        Me.dgv_transaction_history.AllowUserToDeleteRows = False
        Me.dgv_transaction_history.AllowUserToResizeRows = False
        Me.dgv_transaction_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_transaction_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_transaction_history.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_transaction_history.Location = New System.Drawing.Point(6, 108)
        Me.dgv_transaction_history.MultiSelect = False
        Me.dgv_transaction_history.Name = "dgv_transaction_history"
        Me.dgv_transaction_history.ReadOnly = True
        Me.dgv_transaction_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_transaction_history.Size = New System.Drawing.Size(610, 237)
        Me.dgv_transaction_history.TabIndex = 0
        '
        'lbl_item_name
        '
        Me.lbl_item_name.AutoSize = True
        Me.lbl_item_name.Depth = 0
        Me.lbl_item_name.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_item_name.Location = New System.Drawing.Point(7, 68)
        Me.lbl_item_name.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_item_name.Name = "lbl_item_name"
        Me.lbl_item_name.Size = New System.Drawing.Size(198, 19)
        Me.lbl_item_name.TabIndex = 1
        Me.lbl_item_name.Text = "Transaction History of Item:"
        '
        'lbl_item
        '
        Me.lbl_item.AutoSize = True
        Me.lbl_item.Depth = 0
        Me.lbl_item.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_item.Location = New System.Drawing.Point(211, 68)
        Me.lbl_item.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_item.Name = "lbl_item"
        Me.lbl_item.Size = New System.Drawing.Size(74, 19)
        Me.lbl_item.TabIndex = 2
        Me.lbl_item.Text = "ItemName"
        '
        'btn_delete
        '
        Me.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_delete.Depth = 0
        Me.btn_delete.HighEmphasis = True
        Me.btn_delete.Icon = Nothing
        Me.btn_delete.Location = New System.Drawing.Point(543, 68)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_delete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_delete.Size = New System.Drawing.Size(73, 36)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_delete.UseAccentColor = False
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Transaction_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 351)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.lbl_item)
        Me.Controls.Add(Me.lbl_item_name)
        Me.Controls.Add(Me.dgv_transaction_history)
        Me.MaximizeBox = False
        Me.Name = "Transaction_History"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction History"
        CType(Me.dgv_transaction_history, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_transaction_history As DataGridView
    Friend WithEvents lbl_item_name As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_item As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_delete As MaterialSkin.Controls.MaterialButton
End Class
