Public Class Transaction_History
    Public selected_id As Integer = 0

    Private Sub Transaction_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If selected_id <> 0 Then
            LoadItemTransaction()
        End If
    End Sub
    Private Sub LoadItemTransaction()
        Dim ithc As New Item_Transaction_History_Class
        ithc.item_id = selected_id
        dgv_transaction_history.DataSource = ithc.LoadItemTransactions
        lbl_item.Text = ithc.LoadItemName
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim dt As DialogResult = MessageBox.Show("Are you sure you want to delete the selected transaction? This action cannot be undone.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dt = DialogResult.Yes Then
            Dim ithc As New Item_Transaction_History_Class
            ithc.DeleteItemTransaction(dgv_transaction_history.CurrentRow.Cells(0).Value)
        End If
        LoadItemTransaction()
    End Sub

    Private Sub dgv_transaction_history_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv_transaction_history.DataSourceChanged
        If dgv_transaction_history.Rows.Count <> 0 Then
            btn_delete.Enabled = True
        Else
            btn_delete.Enabled = False
        End If
    End Sub
End Class