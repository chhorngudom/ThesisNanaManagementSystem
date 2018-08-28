Public Class FrmSubject
    Public txtids As String
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnaddpartstudy.Click
        Dim frmps As New FrmPartSubject
        frmps.ShowDialog()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub
    Public Sub Filltxtid(txtname)
        DALSubject.GetDataFromDatabase()
        Dim i As Integer
        For i = 0 To DALSubject.listpartsubjectfromdatabase.Count - 1
            If txtname.Equals(DALSubject.listpartsubjectfromdatabase.Item(i).partname) Then
                txtids = DALSubject.listpartsubjectfromdatabase.Item(i).ID
            End If
        Next
    End Sub

    Private Sub FrmSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALSubject.listsubjectfromdatabase.Clear()
        DALSubject.ShowdatasubjectFromDatabase(dgvsubject)
        DALSubject.FilldatatoCombobox(cbopartstudy)
        cbopartstudy.Focus()
        DALSubject.SetIDSubject(txtid)



    End Sub

    Private Sub cbopartstudy_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbopartstudy.SelectedValueChanged

    End Sub

    Private Sub cbopartstudy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopartstudy.SelectedIndexChanged

    End Sub

    Private Sub cbopartstudy_Click(sender As Object, e As EventArgs) Handles cbopartstudy.Click
        DALSubject.listpartsubjectfromdatabase.Clear()
        DALSubject.FilldatatoCombobox(cbopartstudy)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Filltxtid(cbopartstudy.Text)
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        If cbopartstudy.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសផ្នែកសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbopartstudy.Focus()
            Return
        End If
        If txtsubject.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលមុខវិជ្ជា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtsubject.Focus()
            Return
        End If
        For i = 0 To DALSubject.listsubjectfromdatabase.Count - 1
            If DALSubject.listsubjectfromdatabase.Item(i).Id = txtid.Text Then
                MsgBox("ទិន្នន័យស្ទួន មិនអាចបញ្ចូលទៅកាន់ Database ទេ")
                DALSubject.SetIDSubject(txtid)
                Return
            End If
        Next
        DALSubject.addupdatesubjecttodatabase("Adddatasubject", "ទិន្នន័យត្រូវបានរក្សាទុកទៅក្នុង Database រួចរាល់!", txtid.Text.ToString, txtids, txtsubject.Text.ToString, txtdesc.Text.ToString)
        DALSubject.ShowdatasubjectFromDatabase(dgvsubject)
        DALSubject.SetIDSubject(txtid)
        cbopartstudy.Text = ""
        txtsubject.Clear()
        txtdesc.Clear()
        cbopartstudy.Focus()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        DALSubject.SetIDSubject(txtid)
        cbopartstudy.Text = ""
        txtsubject.Clear()
        txtdesc.Clear()
        cbopartstudy.Focus()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Filltxtid(cbopartstudy.Text)
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        If cbopartstudy.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលផ្នែកសិក្សាដើម្បីធ្វើការកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbopartstudy.Focus()
            Return
        End If
        If txtsubject.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះ​មុខវិជ្ជាដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        If DALSubject.listsubjectfromdatabase.Count <= 0 Then
            MessageBox.Show("ទិន្នន័យនេះមិនមាននៅក្នុង Database ទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        For i = 0 To DALSubject.listsubjectfromdatabase.Count - 1
            If DALSubject.listsubjectfromdatabase.Item(i).Id.Equals(txtid.Text) Then
            Else
                MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DALSubject.SetIDSubject(txtid)
                cbopartstudy.Text = ""
                txtsubject.Clear()
                txtdesc.Clear()
                cbopartstudy.Focus()
                Return
            End If
        Next
        DALSubject.addupdatesubjecttodatabase("updatedatasubject", "ទិន្នន័យត្រូវបានកែប្រែរួចរាល់!", txtid.Text, txtids, txtsubject.Text, txtdesc.Text)
        ' DALSchedule.listdayfromdatabase.Clear()
        DALSubject.ShowdatasubjectFromDatabase(dgvsubject)
        DALSubject.SetIDSubject(txtid)
        cbopartstudy.Text = ""
        txtsubject.Clear()
        txtdesc.Clear()
        cbopartstudy.Focus()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If txtid.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលអត្តលេខដើម្បីធ្វើការលុបទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtid.Focus()
                Return
            End If
            DALSubject.GetDatasubjectFromDatabase()
            If DALSubject.listpartsubjectfromdatabase.Count <= 0 Then
                MessageBox.Show("ទិន្នន័យនេះមិនមាននៅក្នុង Database ទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'For i = 0 To DALSubject.listsubjectfromdatabase.Count - 1
            '    If DALSubject.listsubjectfromdatabase.Item(i).partid.Equals(txtid.Text) Then
            '        MessageBox.Show("ទិន្នន័យនេះកំពុងប្រើជាមួយនឹងទិន្នន័យផ្សេងទៀតដូចច្នេះអ្នកមិនអាចលុបបានទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        txtname.Clear()
            '        txtdesc.Clear()
            '        txtname.Focus()
            '        DALSubject.SetIDFaculty(txtid)
            '        Return
            '    End If
            'Next
            For i = 0 To DALSubject.listsubjectfromdatabase.Count - 1
                If DALSubject.listsubjectfromdatabase.Item(i).Id.Equals(txtid.Text) Then
                    DALSubject.DeleteSubject(txtid.Text)
                    DALSubject.ShowdatasubjectFromDatabase(dgvsubject)
                    cbopartstudy.Text = ""
                    txtsubject.Clear()
                    txtdesc.Clear()
                    cbopartstudy.Focus()
                    DALSubject.SetIDSubject(txtid)
                    Return
                End If
            Next
            For i = 0 To DALSubject.listpartsubjectfromdatabase.Count - 1
                If DALSubject.listsubjectfromdatabase.Item(i).Id.Equals(txtid.Text) Then
                Else
                    MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីលុប!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cbopartstudy.Text = ""
                    txtsubject.Clear()
                    txtdesc.Clear()
                    cbopartstudy.Focus()
                    DALSubject.SetIDSubject(txtid)
                    Return
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgvsubject_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsubject.CellContentClick
        txtid.Text = dgvsubject.CurrentRow.Cells(0).Value
        cbopartstudy.Text = dgvsubject.CurrentRow.Cells(1).Value
        txtsubject.Text = dgvsubject.CurrentRow.Cells(2).Value
        txtdesc.Text = dgvsubject.CurrentRow.Cells(3).Value
    End Sub

    Private Sub FrmSubject_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        DALSubject.listsubjectfromdatabase.Clear()
        DALSubject.listalldatasubject.Clear()
    End Sub

    Private Sub FrmSubject_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DALSubject.listsubjectfromdatabase.Clear()
        DALSubject.listalldatasubject.Clear()
    End Sub

    Private Sub cbopartstudy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbopartstudy.KeyPress
        e.Handled = True
    End Sub
End Class