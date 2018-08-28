Public Class FrmTime
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        If cbostarthour.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសម៉ោងចាប់ផ្តើមសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbostarthour.Focus()
            Return
        End If
        If cbostarthour.Text.Equals("ម៉ោង") Then
            MessageBox.Show("សូមជ្រើសរើសម៉ោងចាប់ផ្តើមសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbostarthour.Focus()
            Return
        End If
        If cbostartmn.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសនាទីចាប់ផ្តើមសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbostartmn.Focus()
            Return
        End If
        If cbostartmn.Text.Equals("នាទី") Then
            MessageBox.Show("សូមជ្រើសរើសនាទីចាប់ផ្តើមសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbostartmn.Focus()
            Return
        End If
        If cboendhour.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសម៉ោងបញ្ចប់ការសិក្សា!!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboendhour.Focus()
            Return
        End If
        If cboendhour.Text.Equals("ម៉ោង") Then
            MessageBox.Show("សូមជ្រើសរើសម៉ោងបញ្ចប់ការសិក្សា!!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboendhour.Focus()
            Return
        End If
        If cboendmn.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសនាទីបញ្ចប់ការសិក្សា!!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboendmn.Focus()
            Return
        End If
        If cboendmn.Text.Equals("នាទី") Then
            MessageBox.Show("សូមជ្រើសរើសនាទីបញ្ចប់ការសិក្សា!!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboendmn.Focus()
            Return
        End If
        For i = 0 To DALSchedule.listalldatatimefromdatabase.Count - 1
            If DALSchedule.listalldatatimefromdatabase.Item(i).TimeId = txtid.Text Then
                MsgBox("ទិន្នន័យស្ទួន មិនអាចបញ្ចូលទៅកាន់ Database ទេ")
                DALSchedule.SetIDtime(txtid)
                Return
            End If
        Next
        DALSchedule.addupdatetimetodatabase("AddDataTime", "ទិន្នន័យត្រូវបានរក្សាទុកទៅក្នុង Database រួចរាល់!", txtid.Text.ToString, (cbostarthour.Text.ToString & ":" & cbostartmn.Text.ToString), (cboendhour.Text.ToString & ":" & cboendmn.Text.ToString), txtdesc.Text.ToString)
        DALSchedule.ShowdatatimeFromDatabase(dgvtime)
        DALSchedule.SetIDtime(txtid)
        cbostarthour.Text = "ម៉ោង"
        cbostartmn.Text = "នាទី"
        cboendhour.Text = "ម៉ោង"
        cboendmn.Text = "នាទី"
        txtdesc.Clear()
        cbostarthour.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FrmTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALSchedule.listtimefromdatabase.Clear()
        DALSchedule.ShowdatatimeFromDatabase(dgvtime)
        DALSchedule.SetIDtime(txtid)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DALSchedule.SetIDtime(txtid)
        cbostarthour.Text = "ម៉ោង"
        cbostartmn.Text = "នាទី"
        cboendhour.Text = "ម៉ោង"
        cboendmn.Text = "នាទី"
        txtdesc.Clear()
        cbostarthour.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        If cbostarthour.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលម៉ោងចាប់ផ្តើមសិក្សា​ដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbostarthour.Focus()
            Return
        End If
        If cbostarthour.Text.Equals("ម៉ោង") Then
            MessageBox.Show("សូមបញ្ចូលម៉ោងចាប់ផ្តើមសិក្សា​ដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbostarthour.Focus()
            Return
        End If
        If cbostartmn.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលនាទីចាប់ផ្តើមសិក្សា​ដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbostartmn.Focus()
            Return
        End If
        If cbostartmn.Text.Equals("នាទី") Then
            MessageBox.Show("សូមបញ្ចូលនាទីចាប់ផ្តើមសិក្សា​ដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbostartmn.Focus()
            Return
        End If
        If cboendhour.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលម៉ោងបញ្ចប់ការសិក្សា​ដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboendhour.Focus()
            Return
        End If
        If cboendhour.Text.Equals("ម៉ោង") Then
            MessageBox.Show("សូមបញ្ចូលម៉ោងបញ្ចប់ការសិក្សា​ដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboendhour.Focus()
            Return
        End If
        If cboendmn.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលនាទីបញ្ចប់ការសិក្សា​ដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboendmn.Focus()
            Return
        End If
        If cboendmn.Text.Equals("នាទី") Then
            MessageBox.Show("សូមបញ្ចូលនាទីបញ្ចប់ការសិក្សា​ដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboendmn.Focus()
            Return
        End If
        If DALSchedule.listalldatatimefromdatabase.Count <= 0 Then
            MessageBox.Show("ទិន្នន័យនេះមិនមាននៅក្នុង Database ទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        For i = 0 To DALSchedule.listtimefromdatabase.Count - 1
            If DALSchedule.listtimefromdatabase.Item(i).TimeId.Equals(txtid.Text) Then
            Else
                MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DALSchedule.SetIDtime(txtid)
                cbostarthour.Text = "ម៉ោង"
                cbostartmn.Text = "នាទី"
                cboendhour.Text = "ម៉ោង"
                cboendmn.Text = "នាទី"
                txtdesc.Clear()
                cbostarthour.Focus()

                Return
            End If
        Next
        DALSchedule.addupdatetimetodatabase("updatedatatime", "ទិន្នន័យត្រូវបានកែប្រែរួចរាល់!", txtid.Text.ToString, (cbostarthour.Text.ToString & ":" & cbostartmn.Text.ToString), (cboendhour.Text.ToString & ":" & cboendmn.Text.ToString), txtdesc.Text.ToString)
        ' DALSchedule.listdayfromdatabase.Clear()
        DALSchedule.ShowdatatimeFromDatabase(dgvtime)
        DALSchedule.SetIDtime(txtid)
        cbostarthour.Text = "ម៉ោង"
        cbostartmn.Text = "នាទី"
        cboendhour.Text = "ម៉ោង"
        cboendmn.Text = "នាទី"
        txtdesc.Clear()
        cbostarthour.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខដើម្បីធ្វើការលុបទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        For i = 0 To DALSchedule.listalldatatimefromdatabase.Count - 1
            If DALSchedule.listalldatatimefromdatabase.Item(i).TimeId.Equals(txtid.Text) Then
                DALSchedule.DeleteDatatime(txtid.Text)
                DALSchedule.ShowdatatimeFromDatabase(dgvtime)
                DALSchedule.SetIDtime(txtid)
                cbostarthour.Text = "ម៉ោង"
                cbostartmn.Text = "នាទី"
                cboendhour.Text = "ម៉ោង"
                cboendmn.Text = "នាទី"
                txtdesc.Clear()
                cbostarthour.Focus()
                Return
            End If
        Next
        For i = 0 To DALSchedule.listalldatatimefromdatabase.Count - 1
            If DALSchedule.listalldatatimefromdatabase.Item(i).TimeId.Equals(txtid.Text) Then
            Else
                MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីលុប!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DALSchedule.SetIDtime(txtid)
                cbostarthour.Text = "ម៉ោង"
                cbostartmn.Text = "នាទី"
                cboendhour.Text = "ម៉ោង"
                cboendmn.Text = "នាទី"
                txtdesc.Clear()
                cbostarthour.Focus()
                Return
            End If
        Next

    End Sub

    Private Sub dgvtime_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtime.CellContentClick
        Dim str As String = dgvtime.CurrentRow.Cells(1).Value
        Dim strr As String = dgvtime.CurrentRow.Cells(3).Value
        Dim strArr() As String
        Dim count As Integer
        strArr = str.Split(":")
        For count = 0 To strArr.Length - 1
            cbostarthour.Text = strArr(0)
            cbostartmn.Text = strArr(1)
        Next
        strArr = strr.Split(":")
        For count = 0 To strArr.Length - 1
            cboendhour.Text = strArr(0)
            cboendmn.Text = strArr(1)
        Next
        txtid.Text = dgvtime.CurrentRow.Cells(0).Value
        txtdesc.Text = dgvtime.CurrentRow.Cells(4).Value
    End Sub

    Private Sub FrmTime_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        DALSchedule.listtimefromdatabase.Clear()
        DALSchedule.listalldatatimefromdatabase.Clear()
    End Sub

    Private Sub FrmTime_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DALSchedule.listtimefromdatabase.Clear()
        DALSchedule.listalldatatimefromdatabase.Clear()
    End Sub

    Private Sub cbostarthour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbostarthour.SelectedIndexChanged

    End Sub

    Private Sub cbostarthour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbostarthour.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbostartmn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbostartmn.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboendhour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboendhour.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboendmn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboendmn.KeyPress
        e.Handled = True
    End Sub
End Class

