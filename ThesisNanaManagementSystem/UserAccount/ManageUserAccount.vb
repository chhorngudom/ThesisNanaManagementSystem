Imports System.IO
Public Class ManageUserAccount
    Private txtmanagedatastudent As String = ""
    Private txtmanagedataemployee As String = ""
    Private txtmanagedatasubject As String = ""
    Private txtmanagedataschedule As String = ""
    Private txtmanagedata As String = ""
    Private txtmanageuseraccount As String = ""
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call clear()
    End Sub
    Private Sub clear()
        txtid.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtusertype.Text = ""
        cbmanageuseraccount.Checked = False
        cbmanagedatastudent.Checked = False
        cbmanagedataemployee.Checked = False
        cbmanagedatasubject.Checked = False
        cbmanagedataschedule.Checked = False
        cbmanagedata.Checked = False
        Imageuser.Image = Nothing
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសទិន្នន័យដើម្បីធ្វើការកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        If txtusername.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះគណនី!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Focus()
            Return
        End If
        If txtpassword.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលពាក្យសម្ងាត់គណនី!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpassword.Focus()
            Return
        End If
        If txtusertype.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសប្រភេទគណនី!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusertype.Focus()
            Return
        End If
        If DAL.CheckPictureBox(Imageuser, "សូមជ្រើសរើសរូបភាព") Then
            btnimage.Focus()
            Return
        End If
        If DAL.listuserfromdatabase.Count <= 0 Then
            MessageBox.Show("ទិន្នន័យនេះមិនមាននៅក្នុង Database ទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Imageuser.Image.Save(ms, Imageuser.Image.RawFormat)
        Dim img As Byte()
        img = ms.ToArray
        DAL.UpdateDataToDatabase(txtid.Text, txtusername.Text, txtpassword.Text, txtusertype.Text, txtmanageuseraccount, txtmanagedatastudent, txtmanagedataemployee, txtmanagedatasubject, txtmanagedataschedule, txtmanagedata, img)
        ' DALSchedule.listdayfromdatabase.Clear()
        Call clear()
        DAL.Showuserfrordatabase(dgvuser, txtsearch.Text)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសទិន្នន័យដើម្បីធ្វើការលុប!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        DAL.Deleteuserfromdatabase(txtid.Text)
        Call clear()
        DAL.Showuserfrordatabase(dgvuser, txtsearch.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ManageUserAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvuser.Rows.Clear()
        DAL.listuserfromdatabase.Clear()
        DAL.GetDataFromDatabase()
        DAL.Showuserfrordatabase(dgvuser, txtsearch.Text.ToString)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
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

    Private Sub dgvuser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvuser.CellContentClick
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
            cbmanagedatasubject.Checked = True
        End If
        If managedatasubject.ToString = "No" Then
            cbmanagedatasubject.Checked = False
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
        Imageuser.Image = Image.FromStream(ms)
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles cbmanagedataschedule.CheckedChanged
        If cbmanagedataschedule.Checked = True Then
            txtmanagedataschedule = "Ok"
        End If
        If cbmanagedataschedule.Checked = False Then
            txtmanagedataschedule = "No"
        End If
    End Sub

    Private Sub cbmanagedataemployee_CheckedChanged(sender As Object, e As EventArgs) Handles cbmanagedataemployee.CheckedChanged
        If cbmanagedataemployee.Checked = True Then
            txtmanagedataemployee = "Ok"
        End If
        If cbmanagedataemployee.Checked = False Then
            txtmanagedataemployee = "No"
        End If
    End Sub

    Private Sub cbmanagedatastudent_CheckedChanged(sender As Object, e As EventArgs) Handles cbmanagedatastudent.CheckedChanged
        If cbmanagedatastudent.Checked = True Then
            txtmanagedatastudent = "Ok"
        End If
        If cbmanagedatastudent.Checked = False Then
            txtmanagedatastudent = "No"
        End If
    End Sub

    Private Sub cbmanagedatasubject_CheckedChanged(sender As Object, e As EventArgs) Handles cbmanagedatasubject.CheckedChanged
        If cbmanagedatasubject.Checked = True Then
            txtmanagedatasubject = "Ok"
        End If
        If cbmanagedatasubject.Checked = False Then
            txtmanagedatasubject = "No"
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

    Private Sub btnimage_Click(sender As Object, e As EventArgs) Handles btnimage.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "choose image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            Imageuser.Image = Image.FromFile(opf.FileName)
        End If
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
    End Sub

    Private Sub Img_Click(sender As Object, e As EventArgs) Handles Imageuser.Click

    End Sub

    Private Sub txtusertype_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusertype.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xlapp As Microsoft.Office.Interop.Excel.Application
        Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misvalue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlapp = New Microsoft.Office.Interop.Excel.Application
        xlworkbook = xlapp.Workbooks.Add(misvalue)
        xlworksheet = xlworkbook.Sheets("sheet1")
        For i = 0 To dgvuser.RowCount - 1
            For j = 0 To dgvuser.ColumnCount - 1
                For k As Integer = 1 To dgvuser.Columns.Count
                    xlworksheet.Cells(1, k) = dgvuser.Columns(k - 1).HeaderText
                    xlworksheet.Cells(i + 2, j + 1) = dgvuser(j, i).Value.ToString
                Next
            Next
        Next
        xlworksheet.Rows.Item(1).Font.Bold = 1
        xlworksheet.Rows.Item(1).HorizontalAlignment = 3
        xlworksheet.Columns.AutoFit()
        xlapp.Application.Visible = True
        xlapp.Application.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
    End Sub
End Class