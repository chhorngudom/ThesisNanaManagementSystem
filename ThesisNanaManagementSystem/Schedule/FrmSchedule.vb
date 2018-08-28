Public Class FrmSchedule
    Private txtdayid As String
    Private txttimenameid As String
    Private txtstartimeid As String
    Private txtendtimeid As String
    Private timeid As String
    Private subid As String
    Private startday As String
    Private endday As String

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Public Sub Filltxtidayid()
        Dim str As String = cbodayid.Text
        Dim strArr() As String
        Dim count As Integer
        strArr = str.Split("-")
        For count = 0 To strArr.Length - 1
            startday = strArr(0)
            endday = strArr(1)
        Next
        'MsgBox(startday.ToString)
        'MsgBox(endday.ToString)
        DALSchedule.GetDataFromDatabase()
        Dim i As Integer
        'If endday.ToString.Trim = "អង្គារ" Then
        '    MsgBox(endday.ToString)
        'End If
        For i = 0 To DALSchedule.listdayfromdatabase.Count - 1
            If startday.Trim.ToString = DALSchedule.listdayfromdatabase.Item(i).startday.ToString.Trim And endday.ToString.Trim = DALSchedule.listdayfromdatabase.Item(i).endday.Trim.ToString Then
                txtdayid = DALSchedule.listdayfromdatabase.Item(i).Id
                'MsgBox(txtdayid.ToString)
                Return
            End If
        Next

    End Sub
    Public Sub Filltxttimenameid()
        Dim i As Integer
        For i = 0 To DALSchedule.listtimenamefromdatabase.Count - 1
            If cbotimenameid.Text.Trim.ToString = DALSchedule.listtimenamefromdatabase.Item(i).TimeName.ToString.Trim Then
                txttimenameid = DALSchedule.listtimenamefromdatabase.Item(i).IdName
                'MsgBox(txttimenameid.ToString)
                Return
            End If
        Next
    End Sub
    Public Sub filltxttimeid()
        Dim str As String = cbotimeid.Text
        Dim strArr() As String
        Dim count As Integer
        strArr = str.Split("-")
        For count = 0 To strArr.Length - 1
            txtstartimeid = strArr(0)
            txtendtimeid = strArr(1)
        Next
        'MsgBox(txtstartimeid.ToString)
        'MsgBox(txtendtimeid.ToString)
        DALSchedule.GetDatatimeFromDatabase()
        Dim i As Integer
        'If endday.ToString.Trim = "អង្គារ" Then
        '    MsgBox(endday.ToString)
        'End If
        For i = 0 To DALSchedule.listtimefromdatabase.Count - 1
            If txtstartimeid.Trim.ToString = DALSchedule.listtimefromdatabase.Item(i).starttime.ToString.Trim And txtendtimeid.ToString.Trim = DALSchedule.listtimefromdatabase.Item(i).endtime.Trim.ToString Then
                timeid = DALSchedule.listtimefromdatabase.Item(i).TimeId
                'MsgBox(timeid.ToString)
                Return
            End If
        Next
    End Sub
    Public Sub Fillsubid()
        Dim i As Integer
        For i = 0 To DALSubject.listsubjectfromdatabase.Count - 1
            If cbosubject.Text.Trim.ToString = DALSubject.listsubjectfromdatabase.Item(i).subject.ToString.Trim Then
                subid = DALSubject.listsubjectfromdatabase.Item(i).Id
                'MsgBox(subid.ToString)
                Return
            End If
        Next
    End Sub
    Private Sub txtid_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnaddusertolist_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FrmSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALSchedule.ShowdatascheduleFromDatabase(dgvschedule)
        DALSchedule.listschedulefromdatabase.Clear()
        DALSchedule.SetIDtschedule(txtid)
        DALSchedule.FilldatadaytoCombobox(cbodayid)
        DALSchedule.FilldatatimenametoCombobox(cbotimenameid)
        DALSchedule.FilldatatimetoCombobox(cbotimeid)
        DALSchedule.FilldatasubjecttoCombobox(cbosubject)
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខដើម្បីធ្វើការលុបទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        DALSchedule.GetDatascheduleFromDatabase()
        If DALSchedule.listschedulefromdatabase.Count <= 0 Then
            MessageBox.Show("ទិន្នន័យនេះមិនមាននៅក្នុង Database ទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        For i = 0 To DALSchedule.listschedulefromdatabase.Count - 1
            If DALSchedule.listschedulefromdatabase.Item(i).sdid.Equals(txtid.Text) Then
                DALSchedule.DeleteDataschedule(txtid.Text)
                DALSchedule.listschedulefromdatabase.Clear()
                DALSchedule.ShowdatascheduleFromDatabase(dgvschedule)
                DALSchedule.SetIDtschedule(txtid)
                cbodayid.Text = ""
                cbotimenameid.Text = ""
                cbotimeid.Text = ""
                cbosubject.Text = ""
                dtpstartdate.Text = ""
                txtdesc.Clear()
                cbodayid.Focus()
                Return
            End If
        Next
        For i = 0 To DALSchedule.listschedulefromdatabase.Count - 1
            If DALSchedule.listschedulefromdatabase.Item(i).sdid.Equals(txtid.Text) Then
            Else
                MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីលុប!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DALSchedule.SetIDtschedule(txtid)
                cbodayid.Text = ""
                cbotimenameid.Text = ""
                cbotimeid.Text = ""
                cbosubject.Text = ""
                txtdesc.Clear()
                cbodayid.Focus()
                Return
            End If
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodayid.SelectedIndexChanged

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles tbnadddaystudy.Click
        Dim d As New FrmDayStudy
        d.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnaddtimenamestudy.Click
        Dim y As New FrmNametime
        y.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnaddtimestudy.Click
        Dim x As New FrmTime
        x.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub cbodayid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbodayid.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbotimenameid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbotimenameid.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbotimeid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbotimeid.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cls As New FrmSubject
        cls.ShowDialog()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbosubject.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbodayid_Click(sender As Object, e As EventArgs) Handles cbodayid.Click
        DALSchedule.listdayfromdatabase.Clear()
        DALSchedule.FilldatadaytoCombobox(cbodayid)
    End Sub

    Private Sub cbotimenameid_Click(sender As Object, e As EventArgs) Handles cbotimenameid.Click
        DALSchedule.listtimenamefromdatabase.Clear()
        DALSchedule.FilldatatimenametoCombobox(cbotimenameid)
    End Sub

    Private Sub cbotimeid_Click(sender As Object, e As EventArgs) Handles cbotimeid.Click
        DALSchedule.listtimefromdatabase.Clear()
        DALSchedule.FilldatatimetoCombobox(cbotimeid)
    End Sub

    Private Sub cbosubject_Click(sender As Object, e As EventArgs) Handles cbosubject.Click
        DALSubject.listsubjectfromdatabase.Clear()
        DALSchedule.FilldatasubjecttoCombobox(cbosubject)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        If cbodayid.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសថ្ងៃសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbodayid.Focus()
            Return
        End If
        If cbotimenameid.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសពេលសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbotimenameid.Focus()
            Return
        End If
        If cbotimeid.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសម៉ោងសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbotimeid.Focus()
            Return
        End If
        If cbosubject.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសមុខវិជ្ជាសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbosubject.Focus()
            Return
        End If
        If dtpstartdate.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសថ្ងៃចាប់ផ្តើមសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpstartdate.Focus()
            Return
        End If
        For i = 0 To DALSchedule.listalldataschedulefromdatabase.Count - 1
            If DALSchedule.listalldataschedulefromdatabase.Item(i).sdid = txtid.Text Then
                MsgBox("ទិន្នន័យស្ទួន មិនអាចបញ្ចូលទៅកាន់ Database ទេ")
                DALSchedule.SetIDtschedule(txtid)
                cbodayid.Text = ""
                cbotimenameid.Text = ""
                cbotimeid.Text = ""
                cbosubject.Text = ""
                dtpstartdate.Text = ""
                txtdesc.Clear()
                cbodayid.Focus()

                Return
            End If
        Next
        Call Filltxtidayid()
        Call Filltxttimenameid()
        Call filltxttimeid()
        Call Fillsubid()
        DALSchedule.addupdatescheduletodatabase("AddDataSchedule", txtid.Text.ToString, txtdayid, txttimenameid, timeid, subid, dtpstartdate.Text.ToString, txtdesc.Text.ToString)
        DALSchedule.ShowdatascheduleFromDatabase(dgvschedule)
        DALSchedule.SetIDtschedule(txtid)
        cbodayid.Text = ""
        cbotimenameid.Text = ""
        cbotimeid.Text = ""
        cbosubject.Text = ""
        txtdesc.Clear()
        cbodayid.Focus()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        DALSchedule.SetIDtschedule(txtid)
        cbodayid.Text = ""
        cbotimenameid.Text = ""
        cbotimeid.Text = ""
        cbosubject.Text = ""
        dtpstartdate.Text = ""
        txtdesc.Clear()
        cbodayid.Focus()
    End Sub

    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Focus()
            Return
        End If
        If cbodayid.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសថ្ងៃសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbodayid.Focus()
            Return
        End If
        If cbotimenameid.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសពេលសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbotimenameid.Focus()
            Return
        End If
        If cbotimeid.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសម៉ោងសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbotimeid.Focus()
            Return
        End If
        If cbosubject.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសមុខវិជ្ជាសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbosubject.Focus()
            Return
        End If
        DALSchedule.GetDatascheduleFromDatabase()
        If DALSchedule.listschedulefromdatabase.Count <= 0 Then
            MessageBox.Show("ទិន្នន័យនេះមិនមាននៅក្នុង Database ទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Not txtid.Text = dgvschedule.CurrentRow.Cells(0).Value Then
            MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'For i = 0 To DALSchedule.listschedulefromdatabase.Count - 1
        '    'If DALSchedule.listschedulefromdatabase.Item(i).sdid.ToString.Equals("លរព1") Then
        '    'Else
        '    '    MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    MsgBox(DALSchedule.listschedulefromdatabase.Item(i).sdid.ToString)
        '    'End If
        'Next
        Call Filltxtidayid()
        Call Filltxttimenameid()
        Call filltxttimeid()
        Call Fillsubid()
        DALSchedule.addupdatescheduletodatabase("updatedataschedule", txtid.Text.ToString, txtdayid, txttimenameid, timeid, subid, dtpstartdate.Text.ToString, txtdesc.Text.ToString)
        ' DALSchedule.listdayfromdatabase.Clear()
        DALSchedule.ShowdatascheduleFromDatabase(dgvschedule)
        DALSchedule.SetIDtschedule(txtid)
        DALSchedule.SetIDtschedule(txtid)
        cbodayid.Text = ""
        cbotimenameid.Text = ""
        cbotimeid.Text = ""
        cbosubject.Text = ""
        dtpstartdate.Text = ""
        txtdesc.Clear()
        cbodayid.Focus()

    End Sub

    Private Sub dgvschedule_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvschedule.CellContentClick
        txtid.Text = dgvschedule.CurrentRow.Cells(0).Value.ToString
        cbodayid.Text = dgvschedule.CurrentRow.Cells(1).Value
        cbotimenameid.Text = dgvschedule.CurrentRow.Cells(2).Value
        cbotimeid.Text = dgvschedule.CurrentRow.Cells(3).Value
        cbosubject.Text = dgvschedule.CurrentRow.Cells(4).Value
        txtdesc.Text = dgvschedule.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class