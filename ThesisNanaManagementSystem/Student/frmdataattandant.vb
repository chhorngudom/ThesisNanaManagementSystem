Public Class frmdataattandant
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim x As New frmManageAttandant
        x.ShowDialog()
    End Sub
End Class