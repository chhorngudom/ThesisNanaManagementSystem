Public Class FrmScore
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub cbosubjectaddstudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosubjectaddstudent.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim frmdetailscore As New FrmScoreDetail
        frmdetailscore.ShowDialog()
    End Sub
End Class