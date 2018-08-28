Public Class Frmalluseraccount
    Private Sub Frmalluseraccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvuser.Rows.Clear()
        DAL.listuserfromdatabase.Clear()
        DAL.GetDataFromDatabase()
        DAL.Showuserfrordatabase(dgvuser, txtsearch.Text.ToString)
    End Sub

    Private Sub dgvuser_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvuser.CellFormatting
        If dgvuser.Columns(e.ColumnIndex).Name.Equals("password") Then
            If (Not e.Value = Nothing) Then
                e.Value = New String(CChar("*"), e.Value.ToString.Length)
            End If
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        dgvuser.Rows.Clear()
        DAL.listuserfromdatabase.Clear()
        DAL.GetDataFromDatabase()
        DAL.Showuserfrordatabase(dgvuser, txtsearch.Text.ToString)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As New FrmReportuser
        x.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class