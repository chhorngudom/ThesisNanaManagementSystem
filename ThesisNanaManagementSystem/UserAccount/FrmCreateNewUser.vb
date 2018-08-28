Imports System.IO
Public Class FrmCreateNewUser
    Private txtmanagedatastudent As String = ""
    Private txtmanagedataemployee As String = ""
    Private txtmanagedatasubject As String = ""
    Private txtmanagedataschedule As String = ""
    Private txtmanagedata As String = ""
    Private txtmanageuseraccount As String = ""
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvuser.CellContentClick
        Dim iMmg() As Byte
        Dim managedatauseraccount As String = dgvuser.CurrentRow.Cells(5).Value
        Dim managedatastudent As String = dgvuser.CurrentRow.Cells(6).Value
        Dim managedataemployee As String = dgvuser.CurrentRow.Cells(7).Value
        Dim managedatasubject As String = dgvuser.CurrentRow.Cells(8).Value
        Dim managedataschedule As String = dgvuser.CurrentRow.Cells(9).Value
        Dim managedata As String = dgvuser.CurrentRow.Cells(9).Value
        txtid.Text = dgvuser.CurrentRow.Cells(1).Value.ToString
        txtusername.Text = dgvuser.CurrentRow.Cells(2).Value
        txtpassword.Text = dgvuser.CurrentRow.Cells(3).Value
        txtusertype.Text = dgvuser.CurrentRow.Cells(4).Value
        If managedatastudent.ToString = "Ok" Then
            cbmanagedatastudent.Checked = True
        End If
        If managedatastudent.ToString = "No" Then
            cbmanagedatastudent.Checked = False
        End If

        If managedataemployee.ToString = "Ok" Then
            cbmanagedataemployee.Checked = True
        End If
        If managedataemployee.ToString = "No" Then
            cbmanagedataemployee.Checked = False
        End If

        If managedatasubject.ToString = "Ok" Then
            cbomanagedatasubject.Checked = True
        End If
        If managedatasubject.ToString = "No" Then
            cbomanagedatasubject.Checked = False
        End If

        If managedataschedule.ToString = "Ok" Then
            cbmanagedataschedule.Checked = True
        End If
        If managedataschedule.ToString = "No" Then
            cbmanagedataschedule.Checked = False
        End If

        If managedata.ToString = "Ok" Then
            cbmanagedata.Checked = True
        End If
        If managedata.ToString = "No" Then
            cbmanagedata.Checked = False
        End If

        If managedatauseraccount.ToString = "Ok" Then
            cbmanageuseraccount.Checked = True
        End If
        If managedatauseraccount.ToString = "No" Then
            cbmanageuseraccount.Checked = False
        End If
        iMmg = dgvuser.CurrentRow.Cells(0).Value
        Dim ms As New MemoryStream(iMmg)
        Img.Image = Image.FromStream(ms)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DAL.CheckText(txtid, "សូមបញ្ចូលលេខរៀង អ្នកប្រើប្រាស់!") Then
            Return
        End If
        If DAL.CheckText(txtusername, "សូមបញ្ចូលឈ្មោះ អ្នកប្រើប្រាស់!") Then
            Return
        End If
        If DAL.CheckText(txtpassword, "សូមបញ្ចូលលេខសម្ងាត់ អ្នកប្រើប្រាស់!") Then
            Return
        End If
        If DAL.CheckCombo(txtusertype, "សូមជ្រើសរើសប្រភេទអ្នកប្រើប្រាស់!") Then
            Return
        End If
        If DAL.CheckPictureBox(Img, "សូមជ្រើសរើសរូបភាព") Then
            btnimage.Focus()
            Return
        End If
        If txtmanagedataemployee.ToString = "" Then
            txtmanagedataemployee = "No"
        End If
        If txtmanagedatastudent.ToString = "" Then
            txtmanagedatastudent = "No"
        End If
        If txtmanagedatasubject.ToString = "" Then
            txtmanagedatasubject = "No"
        End If
        If txtmanagedataschedule.ToString = "" Then
            txtmanagedataschedule = "No"
        End If
        If txtmanagedata.ToString = "" Then
            txtmanagedata = "No"
        End If
        If txtmanageuseraccount.ToString = "" Then
            txtmanageuseraccount = "No"
        End If

        Dim ms As New MemoryStream
        Img.Image.Save(ms, Img.Image.RawFormat)
        Dim im() As Byte
        im = ms.ToArray
        DAL.cua = New ClsUserAccount
        DAL.cua.id = txtid.Text
        DAL.cua.username = txtusername.Text
        DAL.cua.password = txtpassword.Text
        DAL.cua.usertype = txtusertype.Text
        DAL.cua.manageuseraccount = txtmanageuseraccount
        DAL.cua.managedatastudent = txtmanagedatastudent
        DAL.cua.managedataemployee = txtmanagedataemployee
        DAL.cua.managedatasubject = txtmanagedatasubject
        DAL.cua.managedataschedule = txtmanagedataschedule
        DAL.cua.managedata = txtmanagedata
        DAL.cua.Image = im.ToArray
        DAL.adduserlist(DAL.cua, txtid)
        DAL.Showuserlist(dgvuser)
        Dim itemCount As Integer
        Dim x As Integer = DAL.listuserfromdatabase.Count + 1
        For i As Integer = 0 To dgvuser.Rows.Count + 1
            txtid.Text = "លរគ" & itemCount + x + 1 - 2
            itemCount += 1
        Next i
        DAL.ClearText(txtusername)
        DAL.ClearText(txtpassword)
        DAL.ClearCombobox(txtusertype)
        cbmanageuseraccount.Checked = False
        cbmanagedatastudent.Checked = False
        cbmanagedataemployee.Checked = False
        cbomanagedatasubject.Checked = False
        cbmanagedataschedule.Checked = False
        cbmanagedata.Checked = False
        DAL.ClearPictureBox(Img)
        txtusername.Focus()
    End Sub

    Private Sub FrmCreateNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DAL.SetIDuser(txtid)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnimage.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "choose image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            Img.Image = Image.FromFile(opf.FileName)
        End If
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DAL.AddDataToDatabase()
        DAL.SetIDuser(txtid)
        dgvuser.Rows.Clear()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        DAL.DeleteUser(txtid, dgvuser)
        Dim itemCount As Integer
        Dim x As Integer = DAL.listuserfromdatabase.Count + 1
        For i As Integer = 0 To dgvuser.Rows.Count + 1
            txtid.Text = "លរគ" & itemCount + x + 1 - 2
            itemCount += 1
        Next i
        DAL.ClearText(txtusername)
        DAL.ClearText(txtpassword)
        DAL.ClearCombobox(txtusertype)
        cbmanageuseraccount.Checked = False
        cbmanagedatastudent.Checked = False
        cbmanagedataemployee.Checked = False
        cbomanagedatasubject.Checked = False
        cbmanagedataschedule.Checked = False
        cbmanagedata.Checked = False
        DAL.ClearPictureBox(Img)
        txtusername.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtmanagedataemployee.ToString = "" Then
            txtmanagedataemployee = "No"
        End If
        If txtmanagedatastudent.ToString = "" Then
            txtmanagedatastudent = "No"
        End If
        If txtmanagedatasubject.ToString = "" Then
            txtmanagedatasubject = "No"
        End If
        If txtmanagedataschedule.ToString = "" Then
            txtmanagedataschedule = "No"
        End If
        If txtmanagedata.ToString = "" Then
            txtmanagedata = "No"
        End If
        If txtmanageuseraccount.ToString = "" Then
            txtmanageuseraccount = "No"
        End If
        DAL.UpdateUser(txtid.Text, txtusername.Text, txtpassword.Text, txtusertype.Text, txtmanageuseraccount, txtmanagedatastudent, txtmanagedataemployee, txtmanagedatasubject, txtmanagedataschedule, txtmanagedata, Img, dgvuser)
        Dim itemCount As Integer
        Dim x As Integer = DAL.listuserfromdatabase.Count + 1
        For i As Integer = 0 To dgvuser.Rows.Count + 1
            txtid.Text = "លរគ" & itemCount + x + 1 - 2
            itemCount += 1
        Next i
        DAL.ClearText(txtusername)
        DAL.ClearText(txtpassword)
        DAL.ClearCombobox(txtusertype)
        cbmanageuseraccount.Checked = False
        cbmanagedatastudent.Checked = False
        cbmanagedataemployee.Checked = False
        cbomanagedatasubject.Checked = False
        cbmanagedataschedule.Checked = False
        cbmanagedata.Checked = False
        DAL.ClearPictureBox(Img)
        txtusername.Focus()
    End Sub

    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            txtusername.Focus()
        End If
    End Sub

    Private Sub txtusername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            txtusertype.Focus()
        End If
    End Sub

    Private Sub txtusertype_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusertype.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            btnimage.Focus()
        End If
        e.Handled = True
    End Sub

    Private Sub cbmanagedataemployee_CheckedChanged(sender As Object, e As EventArgs) Handles cbmanagedataemployee.CheckedChanged
        If cbmanagedataemployee.Checked = True Then
            txtmanagedataemployee = "Ok"
        End If
        If cbmanagedataemployee.Checked = False Then
            txtmanagedataemployee = "No"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtid.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtusertype.Text = ""
        cbmanageuseraccount.Checked = False
        cbmanagedatastudent.Checked = False
        cbmanagedataemployee.Checked = False
        cbomanagedatasubject.Checked = False
        cbmanagedataschedule.Checked = False
        cbmanagedata.Checked = False
        Img.Image = Nothing
        Dim itemCount As Integer
        Dim x As Integer = DAL.listuserfromdatabase.Count + 1
        For i As Integer = 0 To dgvuser.Rows.Count + 1
            txtid.Text = "លរគ" & itemCount + x + 1 - 2
            itemCount += 1
        Next i
    End Sub

    Private Sub cbmanagedatastudent_CheckedChanged(sender As Object, e As EventArgs) Handles cbmanagedatastudent.CheckedChanged
        If cbmanagedatastudent.Checked = True Then
            txtmanagedatastudent = "Ok"
        End If
        If cbmanagedatastudent.Checked = False Then
            txtmanagedatastudent = "No"
        End If
    End Sub

    Private Sub cbomanagedatasubject_CheckedChanged(sender As Object, e As EventArgs) Handles cbomanagedatasubject.CheckedChanged
        If cbomanagedatasubject.Checked = True Then
            txtmanagedatasubject = "Ok"
        End If
        If cbomanagedatasubject.Checked = False Then
            txtmanagedatasubject = "No"
        End If
    End Sub

    Private Sub cbmanagedataschedule_CheckedChanged(sender As Object, e As EventArgs) Handles cbmanagedataschedule.CheckedChanged
        If cbmanagedataschedule.Checked = True Then
            txtmanagedataschedule = "Ok"
        End If
        If cbmanagedataschedule.Checked = False Then
            txtmanagedataschedule = "No"
        End If
    End Sub

    Private Sub cbmanagedata_CheckedChanged(sender As Object, e As EventArgs) Handles cbmanagedata.CheckedChanged
        If cbmanagedata.Checked = True Then
            txtmanagedata = "Ok"
        End If
        If cbmanagedata.Checked = False Then
            txtmanagedata = "No"
        End If
    End Sub

    Private Sub cbmanageuseraccount_CheckedChanged(sender As Object, e As EventArgs) Handles cbmanageuseraccount.CheckedChanged
        If cbmanageuseraccount.Checked = True Then
            txtmanageuseraccount = "Ok"
        End If
        If cbmanageuseraccount.Checked = False Then
            txtmanageuseraccount = "No"
        End If
    End Sub

    Private Sub dgvuser_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvuser.CellFormatting
        If dgvuser.Columns(e.ColumnIndex).Name.Equals("password") Then
            If (Not e.Value = Nothing) Then
                e.Value = New String(CChar("*"), e.Value.ToString.Length)
            End If
        End If
    End Sub
End Class