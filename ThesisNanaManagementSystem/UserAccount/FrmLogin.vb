Public Class FrmLogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles cshowpassword.CheckedChanged
        If cshowpassword.Checked Then
            txtpassword.PasswordChar = Nothing
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DAL.CheckText(txtusername, "សូមបញ្ចូលឈ្មោះគណនី របស់អ្នកប្រើប្រាស់!") Then
            Return
        End If
        If DAL.CheckText(txtpassword, "សូមបញ្ចូលពាក្យសម្ងាត់ របស់គណនី!") Then
            Return
        End If
        If DAL.CheckCombo(txtusertype, "សូមជ្រើសរើសប្រភេទ របស់អ្នកប្រើប្រាស់!") Then
            Return
        End If
        DAL.Login(txtusername.Text, txtpassword.Text, txtusertype.Text)
        If DAL.Logins.Equals("true") Then
            Me.Hide()
            FrmMain.Hide()
            Dim x As New FrmMain
            x.Show()
            Return
        End If
        If DAL.Logins.Equals("fail") Then
        End If
    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Application.Exit()
        Me.Hide()
    End Sub

    Private Sub FrmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        '  Application.Exit()
        Me.Hide()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MdiParent = FrmMain
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.Green
    End Sub

    Private Sub Label5_DoubleClick(sender As Object, e As EventArgs) Handles Label5.DoubleClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Application.Exit()
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.Red
    End Sub

    Private Sub txtusertype_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusertype.KeyPress
        e.Handled = True
    End Sub
End Class