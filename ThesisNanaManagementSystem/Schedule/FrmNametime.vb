Public Class FrmNametime
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        If txtname.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះពេល!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtname.Focus()
            Return
        End If
        For i = 0 To DALSchedule.listalldatanametimefromdatabase.Count - 1
            If DALSchedule.listalldatanametimefromdatabase.Item(i).IdName = txtid.Text Then
                MsgBox("ទិន្នន័យស្ទួន មិនអាចបញ្ចូលទៅកាន់ Database ទេ")
                DALSchedule.SetIDtimename(txtid)
                Return
            End If
        Next
        DALSchedule.addupdatetimenametodatabase("AddDataTimeName", "ទិន្នន័យត្រូវបានរក្សាទុកទៅក្នុង Database រួចរាល់!", txtid.Text.ToString, txtname.Text.ToString, txtdesc.Text.ToString)
        DALSchedule.ShowdatatimenameFromDatabase(dgvtimename)
        'DALSchedule.listalldatanametimefromdatabase.Clear()
        DALSchedule.SetIDtimename(txtid)
        txtname.Clear()
        txtdesc.Clear()
        txtname.Focus()
    End Sub

    Private Sub FrmNametime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALSchedule.listtimenamefromdatabase.Clear()
        DALSchedule.ShowdatatimenameFromDatabase(dgvtimename)
        DALSchedule.SetIDtimename(txtid)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DALSchedule.SetIDtimename(txtid)
        txtname.Clear()
        txtdesc.Clear()
        txtname.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        DALSchedule.GetAllDatatimenameFromDatabase()
        If DALSchedule.listalldatanametimefromdatabase.Count <= 0 Then
            MessageBox.Show("ទិន្នន័យនេះមិនមាននៅក្នុង Database ទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        For i = 0 To DALSchedule.listtimenamefromdatabase.Count - 1
            If DALSchedule.listtimenamefromdatabase.Item(i).IdName.Equals(txtid.Text) Then
            Else
                MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtname.Clear()
                txtdesc.Clear()
                DALSchedule.SetIDtimename(txtid)
                DALSchedule.SetIDdaystudy(txtid)
                Return
            End If
        Next
        DALSchedule.addupdatetimenametodatabase("updatetimename", "ទិន្នន័យត្រូវបានកែប្រែរួចរាល់!", txtid.Text, txtname.Text, txtdesc.Text)
        ' DALSchedule.listdayfromdatabase.Clear()
        DALSchedule.ShowdatatimenameFromDatabase(dgvtimename)
        DALSchedule.SetIDtimename(txtid)
        txtname.Clear()
        txtdesc.Clear()
        txtname.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខដើម្បីធ្វើការលុបទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        DALSchedule.GetDatatimenameFromDatabase()
        If DALSchedule.listtimenamefromdatabase.Count <= 0 Then
            MessageBox.Show("ទិន្នន័យនេះមិនមាននៅក្នុង Database ទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'For i = 0 To DALSchedule.listtimenamefromdatabase.Count - 1
        '    If DALSchedule.listtimenamefromdatabase.Item(i).IdName.Equals(txtid.Text) Then
        '        MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីលុប!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        txtname.Clear()
        '        txtdesc.Clear()
        '        txtname.Focus()
        '        DALSchedule.SetIDtimename(txtid)
        '        Return
        '    End If
        'Next
        For i = 0 To DALSchedule.listtimenamefromdatabase.Count - 1
            If DALSchedule.listtimenamefromdatabase.Item(i).IdName.Equals(txtid.Text) Then
            Else
                MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីលុប!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtname.Clear()
                txtdesc.Clear()
                DALSchedule.SetIDtimename(txtid)
                Return
            End If
        Next
        For i = 0 To DALSchedule.listtimenamefromdatabase.Count - 1
            If DALSchedule.listtimenamefromdatabase.Item(i).IdName.Equals(txtid.Text) Then
                DALSchedule.DeleteDatatimename(txtid.Text)
                DALSchedule.ShowdatatimenameFromDatabase(dgvtimename)
                txtname.Clear()
                txtdesc.Clear()
                DALSchedule.SetIDtimename(txtid)
                Return
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub dgvtimename_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtimename.CellContentClick
        txtid.Text = dgvtimename.CurrentRow.Cells(0).Value
        txtname.Text = dgvtimename.CurrentRow.Cells(1).Value
        txtdesc.Text = dgvtimename.CurrentRow.Cells(2).Value
    End Sub

    Private Sub FrmNametime_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        DALSchedule.listtimenamefromdatabase.Clear()
        DALSchedule.listalldatatimefromdatabase.Clear()
    End Sub

    Private Sub FrmNametime_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DALSchedule.listtimenamefromdatabase.Clear()
        DALSchedule.listalldatatimefromdatabase.Clear()
    End Sub
End Class