Public Class FrmStart
    Private Sub FrmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 30 Then
        End If
        If ProgressBar1.Value = 80 Then
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Me.Hide()
            FrmMain.Show()
        End If
    End Sub
End Class