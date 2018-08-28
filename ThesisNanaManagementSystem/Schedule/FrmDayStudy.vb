Public Class FrmDayStudy
    Private Sub FrmDayStudy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALSchedule.listdayfromdatabase.Clear()
        DALSchedule.ShowdataFromDatabase(dgvday)
        DALSchedule.SetIDdaystudy(txtid)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        If cbostartday.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសថ្ងៃចាប់ផ្តើមសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbostartday.Focus()
            Return
        End If
        If cboendday.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសថ្ងៃបញ្ចប់ការសិក្សា!!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboendday.Focus()
            Return
        End If
        For i = 0 To DALSchedule.listalldatadayfromdatabase.Count - 1
            If DALSchedule.listalldatadayfromdatabase.Item(i).Id = txtid.Text Then
                MsgBox("ទិន្នន័យស្ទួន មិនអាចបញ្ចូលទៅកាន់ Database ទេ")
                DALSchedule.SetIDdaystudy(txtid)
                Return
            End If
        Next
        DALSchedule.addupdatedaytodatabase("AddDataDay", "ទិន្នន័យត្រូវបានរក្សាទុកទៅក្នុង Database រួចរាល់!", txtid.Text.ToString, cbostartday.Text.ToString, cboendday.Text.ToString, txtdesc.Text.ToString)
        DALSchedule.ShowdataFromDatabase(dgvday)
        DALSchedule.SetIDdaystudy(txtid)
        cbostartday.Text = ""
        cboendday.Text = ""
        txtdesc.Clear()
        cbostartday.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DALSchedule.SetIDdaystudy(txtid)
        cbostartday.Text = ""
        cboendday.Text = ""
        txtdesc.Clear()
        cbostartday.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        If DALSchedule.listalldatadayfromdatabase.Count <= 0 Then
            MessageBox.Show("ទិន្នន័យនេះមិនមាននៅក្នុង Database ទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        For i = 0 To DALSchedule.listdayfromdatabase.Count - 1
            If DALSchedule.listdayfromdatabase.Item(i).Id.Equals(txtid.Text) Then
            Else
                MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbostartday.Text = ""
                cboendday.Text = ""
                txtdesc.Clear()
                cbostartday.Focus()
                DALSchedule.SetIDdaystudy(txtid)
                Return
            End If
        Next
        DALSchedule.addupdatedaytodatabase("Updatadataday", "ទិន្នន័យត្រូវបានកែប្រែរួចរាល់!", txtid.Text, cbostartday.Text, cboendday.Text, txtdesc.Text)
        ' DALSchedule.listdayfromdatabase.Clear()
        DALSchedule.ShowdataFromDatabase(dgvday)
        DALSchedule.SetIDdaystudy(txtid)
        cbostartday.Text = ""
        cboendday.Text = ""
        txtdesc.Clear()
        cbostartday.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខដើម្បីធ្វើការលុបទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        DALSchedule.GetAllDatadayFromDatabase()
        If DALSchedule.listalldatadayfromdatabase.Count <= 0 Then
            MessageBox.Show("ទិន្នន័យនេះមិនមាននៅក្នុង Database ទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        For i = 0 To DALSchedule.listalldatadayfromdatabase.Count - 1
            If DALSchedule.listalldatadayfromdatabase.Item(i).Id.Equals(txtid.Text) Then
                DALSchedule.DeleteDataday(txtid.Text)
                DALSchedule.ShowdataFromDatabase(dgvday)
                cbostartday.Text = ""
                cboendday.Text = ""
                txtdesc.Clear()
                cbostartday.Focus()
                DALSchedule.SetIDdaystudy(txtid)
                Return
            End If
        Next
        For i = 0 To DALSchedule.listalldatadayfromdatabase.Count - 1
            If DALSchedule.listalldatadayfromdatabase.Item(i).Id.Equals(txtid.Text) Then
            Else
                MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីលុប!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbostartday.Text = ""
                cboendday.Text = ""
                txtdesc.Clear()
                cbostartday.Focus()
                DALSchedule.SetIDdaystudy(txtid)
                Return
            End If
        Next

    End Sub

    Private Sub dgvday_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvday.CellContentClick
        txtid.Text = dgvday.CurrentRow.Cells(0).Value
        cbostartday.Text = dgvday.CurrentRow.Cells(1).Value
        cboendday.Text = dgvday.CurrentRow.Cells(3).Value
        txtdesc.Text = dgvday.CurrentRow.Cells(4).Value
    End Sub

    Private Sub cbostartday_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbostartday.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboendday_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboendday.KeyPress
        e.Handled = True
    End Sub

    Private Sub FrmDayStudy_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        DALSchedule.listdayfromdatabase.Clear()
        DALSchedule.listalldatadayfromdatabase.Clear()
    End Sub

    Private Sub FrmDayStudy_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DALSchedule.listdayfromdatabase.Clear()
        DALSchedule.listalldatadayfromdatabase.Clear()
    End Sub
End Class