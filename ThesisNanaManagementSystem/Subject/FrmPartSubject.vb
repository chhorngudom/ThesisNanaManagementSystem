Public Class FrmPartSubject
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub FrmPartSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALSubject.listpartsubjectfromdatabase.Clear()
        DALSubject.ShowdataFromDatabase(dgvpartsubject)
        DALSubject.SetIDFaculty(txtid)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If txtid.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលអត្តលេខ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtid.Focus()
                Return
            End If
            If txtname.Text.Equals("") Then
                MessageBox.Show("សូមបំពេញផ្នែកសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtname.Focus()
                Return
            End If
            For i = 0 To DALSubject.listpartsubjectfromdatabase.Count - 1
                If DALSubject.listpartsubjectfromdatabase.Item(i).ID = txtid.Text Then
                    MsgBox("ទិន្នន័យស្ទួន មិនអាចបញ្ចូលទៅកាន់ Database ទេ")
                    DALSubject.SetIDFaculty(txtid)
                    Return
                End If
            Next
            DALSubject.addupdatepartstudytodatabase("Adddatapartstudy", "ទិន្នន័យត្រូវបានរក្សាទុកទៅក្នុង Database រួចរាល់!", txtid.Text.ToString, txtname.Text.ToString, txtdesc.Text.ToString, "Active")
            DALSubject.ShowdataFromDatabase(dgvpartsubject)
            DALSubject.SetIDFaculty(txtid)
            txtname.Text = ""
            txtdesc.Clear()
            txtname.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        DALSubject.SetIDFaculty(txtid)
        txtname.Clear()
        txtdesc.Clear()
        txtname.Focus()
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
            For i = 0 To DALSubject.listsubjectfromdatabase.Count - 1
                If DALSubject.listsubjectfromdatabase.Item(i).partid.Equals(txtid.Text) Then
                    MessageBox.Show("ទិន្នន័យនេះកំពុងប្រើជាមួយនឹងទិន្នន័យផ្សេងទៀតដូចច្នេះអ្នកមិនអាចលុបបានទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtname.Clear()
                    txtdesc.Clear()
                    txtname.Focus()
                    DALSubject.SetIDFaculty(txtid)
                    Return
                End If
            Next
            For i = 0 To DALSubject.listpartsubjectfromdatabase.Count - 1
                If DALSubject.listpartsubjectfromdatabase.Item(i).ID.Equals(txtid.Text) Then
                    DALSubject.Deletepartstudy(txtid.Text)
                    DALSubject.ShowdataFromDatabase(dgvpartsubject)
                    txtname.Clear()
                    txtdesc.Clear()
                    txtname.Focus()
                    DALSubject.SetIDFaculty(txtid)
                    Return
                End If
            Next
            For i = 0 To DALSubject.listpartsubjectfromdatabase.Count - 1
                If DALSubject.listpartsubjectfromdatabase.Item(i).ID.Equals(txtid.Text) Then
                Else
                    MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីលុប!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtname.Clear()
                    txtdesc.Clear()
                    txtname.Focus()
                    DALSubject.SetIDFaculty(txtid)
                    Return
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        If txtname.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលផ្នែកសិក្សាដើម្បីធ្វើការកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtname.Focus()
            Return
        End If
        If DALSubject.listpartsubjectfromdatabase.Count <= 0 Then
            MessageBox.Show("ទិន្នន័យនេះមិនមាននៅក្នុង Database ទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        For i = 0 To DALSubject.listpartsubjectfromdatabase.Count - 1
            If DALSubject.listpartsubjectfromdatabase.Item(i).ID.Equals(txtid.Text) Then
            Else
                MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtname.Clear()
                txtdesc.Clear()
                txtname.Focus()
                DALSubject.SetIDFaculty(txtid)
                Return
            End If
        Next
        DALSubject.addupdatepartstudytodatabase("updatedatapartstudy", "ទិន្នន័យត្រូវបានកែប្រែរួចរាល់!", txtid.Text, txtname.Text, txtdesc.Text, "Active")
        ' DALSchedule.listdayfromdatabase.Clear()
        DALSubject.ShowdataFromDatabase(dgvpartsubject)
        DALSubject.SetIDFaculty(txtid)
        txtname.Clear()
        txtdesc.Clear()
        txtname.Focus()
    End Sub

    Private Sub dgvpartsubject_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpartsubject.CellContentClick
        txtid.Text = dgvpartsubject.CurrentRow.Cells(0).Value
        txtname.Text = dgvpartsubject.CurrentRow.Cells(1).Value
        txtdesc.Text = dgvpartsubject.CurrentRow.Cells(2).Value
    End Sub

    Private Sub FrmPartSubject_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        DALSubject.listpartsubjectfromdatabase.Clear()
        DALSubject.listalldatapartsubject.Clear()
    End Sub

    Private Sub FrmPartSubject_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DALSubject.listalldatapartsubject.Clear()
        DALSubject.listpartsubjectfromdatabase.Clear()
    End Sub
    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            txtdesc.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtname.KeyDown

    End Sub

    Private Sub txtname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtname.KeyUp

    End Sub

    Private Sub txtdesc_KeyUp(sender As Object, e As KeyEventArgs) Handles txtdesc.KeyUp

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class