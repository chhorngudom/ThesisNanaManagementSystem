Imports System.IO
Imports System.Text.RegularExpressions
Public Class FrmMain
    Dim fs As New FrmSubject
    Dim fps As New FrmPartSubject
    Private txtdayid As String
    Private txttimenameid As String
    Private txtstartimeid As String
    Private txtendtimeid As String
    Private timeid As String
    Private subid As String
    Private startday As String
    Private endday As String
    Private txttermid As String
    Private sdid As String
    Private detailstudentid As String
    Private teacherid As String = ""
    Private attid As String = ""
    Private attdetailid As String = ""
    Private paymentid As String = ""
    Private paymentdetailid As String = ""
    Private scoreid As String = ""
    Private scoredetailid As String = ""
    Private txtsalaryid As String
    Private txtsalarydetailid As String = ""
    Private txtemployeeid As String = ""
    Private txtstopworkid As String
    Private txtdetailemployeeid As String
    Private txttermidmanagedataemployee As String
    Private txtmanageuseraccount As String = ""
    Private txtmanagestudent As String = ""
    Private txtmanageemployee As String = ""
    Private txtmanagesubject As String = ""
    Private txtmanaschedule As String = ""
    Private txtmanagedata As String = ""
    Private Sub បញជToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmmanageemployee.Click

    End Sub
    Private Sub Fillidschedule()
        DALSchedule.listalldataschedulefromdatabase.Clear()
        DALSchedule.GetAllDatascheduleFromDatabase()
        sdid = "លរព" & DALSchedule.listalldataschedulefromdatabase.Count + 1
    End Sub
    Private Sub Filltermid()
        DALStudent.listalltermfromdatabase.Clear()
        DALStudent.getalldatatermfromdatabase()
        txttermid = "រយ" & DALStudent.listalltermfromdatabase.Count + 1
    End Sub
    Private Sub FillDetailstudentid()
        DALStudent.listalldetailstudentfromdatabase.Clear()
        DALStudent.getalldatadetailstudent()
        detailstudentid = "សល" & DALStudent.listalldetailstudentfromdatabase.Count + 1
    End Sub
    Private Sub Fillsdid()
        Try
            DALStudent.GetAllDatastudentFromDatabase()
            Dim i As Integer
            For i = 0 To DALStudent.liststudentfromdatabaseactive.Count - 1
                If txtidmanagedatastudent.Text.ToString.ToUpper.Equals(DALStudent.liststudentfromdatabaseactive.Item(i).id.ToString.ToUpper) Then
                    sdid = DALStudent.liststudentfromdatabaseactive.Item(i).sdid
                    Return
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Dim strArr() As String
    Public Sub Filltxtidayid(ByVal cbo As ComboBox)
        Dim str As String = cbo.Text
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
    Public Sub Filltxttimenameid(ByVal cbo As ComboBox)
        Dim i As Integer
        For i = 0 To DALSchedule.listtimenamefromdatabase.Count - 1
            If cbo.Text.Trim.ToString = DALSchedule.listtimenamefromdatabase.Item(i).TimeName.ToString.Trim Then
                txttimenameid = DALSchedule.listtimenamefromdatabase.Item(i).IdName
                'MsgBox(txttimenameid.ToString)
                Return
            End If
        Next
    End Sub
    Public Sub filltxttimeid(ByVal cbo As ComboBox)
        Dim str As String = cbo.Text
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
    Public Sub Fillsubid(ByVal cbo As ComboBox)
        Dim i As Integer
        DALSubject.GetDatasubjectFromDatabase()

        For i = 0 To DALSubject.listsubjectfromdatabase.Count - 1
            If cbo.Text.Trim.ToString = DALSubject.listsubjectfromdatabase.Item(i).subject.ToString.Trim Then
                subid = DALSubject.listsubjectfromdatabase.Item(i).Id
                'MsgBox(subid.ToString)
                Return
            End If
        Next
    End Sub
    Public Sub Filltxtempid()
        DALEmployee.listallemployee.Clear()
        DALEmployee.GetAllDataEmployeeFromDatabase()
        txtemployeeid = "បល" & DALEmployee.listallemployee.Count + 1
    End Sub
    Public Sub Filltxtsrid()
        DALEmployee.listallsalary.Clear()
        DALEmployee.getallSalaryfromdatabase()
        txtsalaryid = "បខ" & DALEmployee.listallsalary.Count + 1
    End Sub
    Public Sub Filltxtdetailsrid()
        DALEmployee.listalldetailsalary.Clear()
        DALEmployee.getallDetailSalaryfromdatabase()
        txtsalarydetailid = "បខល" & DALEmployee.listalldetailsalary.Count + 1
    End Sub

    Public Sub Filltxtdetailempid()
        DALEmployee.listalldetailemployee.Clear()
        DALEmployee.getallDetailemployeefromdatabase()
        txtdetailemployeeid = "បលល" & DALEmployee.listalldetailemployee.Count + 1
    End Sub
    Public Sub Filltxtstopworkid()
        DALEmployee.listallstopwork.Clear()
        DALEmployee.getalldatastopworkfromdatabase("getdatastopwork")
        txtstopworkid = "ឈធ" & DALEmployee.listallstopwork.Count + 1
    End Sub
    Public Sub Filltxttermid()
        DALEmployee.listallstopwork.Clear()
        DALEmployee.getalldatastopworkfromdatabase("getdatastopwork")
        txttermid = "ឈរ" & DALEmployee.listallstopwork.Count + 1
    End Sub
    Public Sub Filltxtattid()
        DALStudent.listallattfromdatabase.Clear()
        DALStudent.getalldataattandant()
        attid = "អវ" & DALStudent.listallattfromdatabase.Count + 1
    End Sub
    Public Sub Filltxtattdetailid()
        DALStudent.listallattdetailfromdatabase.Clear()
        DALStudent.getalldatadetailattandant()
        attdetailid = "អវល" & DALStudent.listallattdetailfromdatabase.Count + 1
    End Sub
    Public Sub Filltxtscoreid()
        DALStudent.listallscorefromdatabase.Clear()
        DALStudent.getalldatascore()
        scoreid = "ព" & DALStudent.listallscorefromdatabase.Count + 1
    End Sub
    Public Sub Filltxtscoredetailid()
        DALStudent.listallscoredetailfromdatabase.Clear()
        DALStudent.getalldatadetailscore()
        scoredetailid = "ពល" & DALStudent.listallscoredetailfromdatabase.Count + 1
    End Sub
    Public Sub Filltxtpaymenid()
        DALStudent.listallpaymentfromdatabase.Clear()
        DALStudent.getalldatapayment()
        paymentid = "បថ" & DALStudent.listallpaymentfromdatabase.Count + 1
    End Sub
    Public Sub Filltxtpaymendetailid()
        DALStudent.listallpaymentdetailfromdatabase.Clear()
        DALStudent.getalldatadetailpayment()
        paymentdetailid = "បថល" & DALStudent.listallpaymentdetailfromdatabase.Count + 1
    End Sub
    Private Sub Filltxttermidmanagedatastudent()
        Try
            Dim i As Integer
            For i = 0 To DALEmployee.listallemployeeactive.Count - 1
                If DALEmployee.listallemployeeactive.Item(i).ID = txtidmanagedataemployee.Text.ToString Then
                    txttermidmanagedataemployee = DALEmployee.listallemployeeactive.Item(i).Termid
                    Return
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ទននសសសទងអសToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ទននសសសទងអសToolStripMenuItem.Click
        Dim x As New FrmAllEmployee
        x.ShowDialog()
    End Sub
    Private Sub HidePanel()
        PBackground.Hide()
        JPManageDataStudent.Hide()
        pbackgroundss.Hide()
        PAddstudent.Hide()
        paddemployee.Hide()
        Pmanagedataemployee.Hide()
    End Sub
    Private Sub loaddataPaneladdstudent()
        DALSubject.listpartsubjectfromdatabase.Clear()
        DALSubject.listsubjectfromdatabase.Clear()
        DALSchedule.listdayfromdatabase.Clear()
        DALSchedule.listtimenamefromdatabase.Clear()
        DALSchedule.listtimefromdatabase.Clear()
        DALSubject.FilldatatoCombobox(cbopartstudyaddstudent)
        DALSchedule.FilldatasubjecttoCombobox(cbosubjectaddstudent)
        DALSchedule.FilldatadaytoCombobox(cbdaystudyaddstudent)
        DALSchedule.FilldatatimenametoCombobox(cbtimestudyaddstudent)
        DALSchedule.FilldatatimetoCombobox(cbohourstudyaddstudent)
        DALStudent.listallstudentfromdatabase.Clear()
        DALStudent.SetIDStudent(txtidaddstudent)
    End Sub
    Private Sub loaddataPanelmodifystudent()
        DALSubject.listpartsubjectfromdatabase.Clear()
        DALSubject.listsubjectfromdatabase.Clear()
        DALSchedule.listdayfromdatabase.Clear()
        DALSchedule.listtimenamefromdatabase.Clear()
        DALSchedule.listtimefromdatabase.Clear()
        DALSubject.FilldatatoCombobox(cbopartstudymanagedatastudent)
        DALSchedule.FilldatasubjecttoCombobox(cbosubjectmanagedatastudent)
        DALSchedule.FilldatadaytoCombobox(cbodaystudymanagedatastudent)
        DALSchedule.FilldatatimenametoCombobox(cbotimenammanagedatastudent)
        DALSchedule.FilldatatimetoCombobox(cbotimestudymanagedatastudent)
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HidePanel()
        pbackgroundss.Show()
        Call PermissionLogin()
        Call loaddataPaneladdstudent()
    End Sub
    Public Sub PermissionLogin()
        If DAL.userid.ToString = "" Then
            Dim fr As New FrmLogin
            fr.ShowDialog()
            Return
        End If
        DAL.listuserfromdatabase.Clear()
        DAL.GetDataFromDatabase()
        Dim i As Integer
        For i = 0 To DAL.listuserfromdatabase.Count - 1
            If DAL.listuserfromdatabase.Item(i).id = DAL.userid Then
                txtmanageuseraccount = DAL.listuserfromdatabase.Item(i).manageuseraccount
                txtmanagestudent = DAL.listuserfromdatabase.Item(i).managedatastudent
                txtmanageemployee = DAL.listuserfromdatabase.Item(i).managedataemployee
                txtmanagesubject = DAL.listuserfromdatabase.Item(i).managedatasubject
                txtmanaschedule = DAL.listuserfromdatabase.Item(i).managedataschedule
                txtmanagedata = DAL.listuserfromdatabase.Item(i).managedata
                tsmusername.Text = DAL.listuserfromdatabase.Item(i).username
                Dim img() As Byte
                img = DAL.listuserfromdatabase.Item(i).Image
                Dim ms As New MemoryStream(img)
                tsmusername.Image = Image.FromStream(ms)
            End If
        Next
        If txtmanagestudent.ToString = "Ok" Then
            'tsmmanagedatastudent.Enabled = True
            tsmmanagestudent.Enabled = True
            tsmmanagestudentdata.Enabled = True
        Else
            tsmmanagestudent.Enabled = False
            tsmmanagestudentdata.Enabled = False
            'tsmmanagedatastudent.Enabled = False
        End If

        If txtmanageemployee.ToString = "Ok" Then
            '  tsmmanageemployee.Enabled = True
            tsmmanagedataemployee.Enabled = True
            tsmmanageemployeedata.Enabled = True
        Else
            'tsmmanageemployee.Enabled = False
            tsmmanagedataemployee.Enabled = False
            tsmmanageemployeedata.Enabled = False
        End If

        If txtmanaschedule.ToString = "Ok" Then
            tsmschedule.Enabled = True
        Else
            tsmschedule.Enabled = False
        End If

        If txtmanagesubject.ToString = "Ok" Then
            tsmsubject.Enabled = True
        Else
            tsmsubject.Enabled = False
        End If

        If txtmanagedata.ToString = "Ok" Then
            tsmrestoreanddeletedatastudent.Enabled = True
            tsmrestoreanddeletedataemployee.Enabled = True
            BackUpDatabaseToolStripMenuItem.Enabled = True
            RestoreDatabaseToolStripMenuItem.Enabled = True
        Else
            tsmrestoreanddeletedatastudent.Enabled = False
            tsmrestoreanddeletedataemployee.Enabled = False
            BackUpDatabaseToolStripMenuItem.Enabled = False
            RestoreDatabaseToolStripMenuItem.Enabled = False
        End If

        If txtmanageuseraccount.ToString = "Ok" Then
            '  tsmmanageemployee.Enabled = True
            tsmcreateuser.Enabled = True
            tsmmanageuseraccount.Enabled = True
        Else
            'tsmmanageemployee.Enabled = False
            tsmcreateuser.Enabled = False
            tsmmanageuseraccount.Enabled = False
        End If

    End Sub

    Private Sub toolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles tsmcreateuser.Click
        Dim x As New FrmCreateNewUser
        x.ShowDialog()
    End Sub

    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub ToolStripMenuItem25_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem25.Click
        Shell("calc.exe")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnimageaddstudent.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "choose image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            imgstudent.Image = Image.FromFile(opf.FileName)
        End If
        Dim ms As New MemoryStream
        imgstudent.Image.Save(ms, imgstudent.Image.RawFormat)
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles tsmmanagestudentdata.Click
        Call HidePanel()
        JPManageDataStudent.Show()
        Call clearpmanagedatastudent()
        DALStudent.liststudentfromdatabaseactive.Clear()
        DALStudent.GetDatastudentFromDatabaseActive()
        DALStudent.ShowalldatastudentFromDatabase(dgvmanagedatastudent)
    End Sub

    Private Sub កលវភគToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles កលវភគToolStripMenuItem.Click
        Dim proc As New System.Diagnostics.Process()
        proc = Process.Start("notepad.exe")
    End Sub

    Private Sub ToolStripMenuItem27_Click(sender As Object, e As EventArgs) Handles tsmschedule.Click
        Dim x As New FrmSchedule
        x.ShowDialog()
    End Sub

    Private Sub បនថមមខវជជសកសToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmsubject.Click
        Dim x As New FrmSubject
        x.ShowDialog()
    End Sub

    Private Sub FrmMain_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        FrmLogin.ShowDialog()
    End Sub

    Private Sub មខវជជសកសToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles មខវជជសកសToolStripMenuItem.Click
        Dim x As New Frmalldatasubject
        x.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        fps.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        fs.ShowDialog()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btnaddpartstudyaddstudent.Click
        fps.ShowDialog()
    End Sub

    Private Sub btnadddaystudyaddstudent_Click(sender As Object, e As EventArgs) Handles btnadddaystudyaddstudent.Click
        Dim x As New FrmDayStudy
        x.ShowDialog()
    End Sub

    Private Sub btnaddsubjectaddstudent_Click(sender As Object, e As EventArgs) Handles btnaddsubjectaddstudent.Click
        Dim fs As New FrmSubject
        fs.ShowDialog()
    End Sub

    Private Sub btnaddtimestudyaddstudent_Click(sender As Object, e As EventArgs) Handles btnaddtimestudyaddstudent.Click
        Dim tn As New FrmNametime
        tn.ShowDialog()
    End Sub

    Private Sub btnaddhourstudyaddstudent_Click(sender As Object, e As EventArgs) Handles btnaddhourstudyaddstudent.Click
        Dim t As New FrmTime
        t.ShowDialog()
    End Sub

    Private Sub cbgenderaddstudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbgenderaddstudent.KeyPress
        e.Handled = True
    End Sub

    Private Sub dtdobaddstudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtdobaddstudent.KeyPress
        e.Handled = True
    End Sub

    Private Sub dtstartdateaddstudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtstartdateaddstudent.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbopartstudyaddstudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbopartstudyaddstudent.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbosubjectaddstudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbosubjectaddstudent.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbdaystudyaddstudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbdaystudyaddstudent.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbtimestudyaddstudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbtimestudyaddstudent.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbohourstudyaddstudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbohourstudyaddstudent.KeyPress
        e.Handled = True
    End Sub

    Private Sub btncloseaddstudent_Click(sender As Object, e As EventArgs) Handles btncloseaddstudent.Click
        Call HidePanel()
        pbackgroundss.Show()
    End Sub

    Private Sub cbopartstudyaddstudent_Click(sender As Object, e As EventArgs) Handles cbopartstudyaddstudent.Click
        DALSubject.listpartsubjectfromdatabase.Clear()
        DALSubject.FilldatatoCombobox(cbopartstudyaddstudent)
    End Sub

    Private Sub cbosubjectaddstudent_Click(sender As Object, e As EventArgs) Handles cbosubjectaddstudent.Click
        DALSubject.listsubjectfromdatabase.Clear()
        DALSchedule.FilldatasubjecttoCombobox(cbosubjectaddstudent)
    End Sub

    Private Sub cbdaystudyaddstudent_Click(sender As Object, e As EventArgs) Handles cbdaystudyaddstudent.Click
        DALSchedule.listdayfromdatabase.Clear()
        DALSchedule.FilldatadaytoCombobox(cbdaystudyaddstudent)
    End Sub

    Private Sub cbtimestudyaddstudent_Click(sender As Object, e As EventArgs) Handles cbtimestudyaddstudent.Click
        DALSchedule.listtimenamefromdatabase.Clear()
        DALSchedule.FilldatatimenametoCombobox(cbtimestudyaddstudent)
    End Sub

    Private Sub cbohourstudyaddstudent_Click(sender As Object, e As EventArgs) Handles cbohourstudyaddstudent.Click
        DALSchedule.listtimefromdatabase.Clear()
        DALSchedule.FilldatatimetoCombobox(cbohourstudyaddstudent)
    End Sub

    Private Sub btnsaveaddstudent_Click(sender As Object, e As EventArgs) Handles btnsaveaddstudent.Click
        If txtidaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtidaddstudent.Focus()
            Return
        End If
        If txtidcardaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខអត្តសញ្ញាណប័ណ្ណ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtidcardaddstudent.Focus()
            Return
        End If
        If txtkhmernameaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចលឈ្មោះជាភាសាខ្មែរ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtkhmernameaddstudent.Focus()
            Return
        End If
        If txtlatinnameaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះជាអក្សរឡាតាំង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtlatinnameaddstudent.Focus()
            Return
        End If
        If txtnationaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះជាតិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnationManagedatastudent.Focus()
            Return
        End If
        If txtnationalityaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះសញ្ជាតិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnationalitymanagedatastudent.Focus()
            Return
        End If
        If cbgenderaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសភេទ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbgenderaddstudent.Focus()
            Return
        End If
        If dtdobaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសថ្ងៃខែឆ្នាំកំណើត!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtdobaddstudent.Focus()
            Return
        End If
        If txtphonenumberaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខទូរស័ព្ទ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtphonenumberaddstudent.Focus()
            Return
        End If
        If txtemailaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអ៊ីម៉ែល!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtemailaddstudent.Focus()
            Return
        End If
        If dtstartdateaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលជ្រើសរើសថ្ងៃចូលរៀង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtstartdateaddstudent.Focus()
            Return
        End If
        If cbopartstudyaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសផ្នែកសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbopartstudyaddstudent.Focus()
            Return
        End If
        If cbosubjectaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសមុខវិជ្ជាសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbosubjectaddstudent.Focus()
            Return
        End If
        If cbdaystudyaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសថ្ងៃសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbdaystudyaddstudent.Focus()
            Return
        End If
        If cbtimestudyaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសពេលសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbtimestudyaddstudent.Focus()
            Return
        End If
        If cbohourstudyaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសម៉ោងសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbohourstudyaddstudent.Focus()
            Return
        End If
        If imgstudent.Image Is Nothing Then
            MessageBox.Show("សូមបញ្ចូលរូបភាព!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnimageaddstudent.Focus()
            Return
        End If
        If txtpobroadnoaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខផ្លូវ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpobroadnoaddstudent.Focus()
            Return
        End If
        If txtpobhomenoaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខផ្ទះ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpobhomenoaddstudent.Focus()
            Return
        End If
        If txtpobvillageaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះភូមិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpobvillageaddstudent.Focus()
            Return
        End If
        If txtpobcommuneaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះឃុំ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpobcommuneaddstudent.Focus()
            Return
        End If
        If txtpobdistrictaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះស្រុក/ក្រុង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpobdistrictaddstudent.Focus()
            Return
        End If
        If txtpobprovinceaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះខេត្ត/រាជធានី!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpobprovinceaddstudent.Focus()
            Return
        End If
        If txtadnroadnoaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខផ្លូវ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtadnroadnoaddstudent.Focus()
            Return
        End If
        If txtadnhomenoaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខផ្ទះ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtadnhomenoaddstudent.Focus()
            Return
        End If
        If txtadnvillageaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះភូមិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtadnvillageaddstudent.Focus()
            Return
        End If
        If txtadncommuneaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះឃុំ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtadncommuneaddstudent.Focus()
            Return
        End If
        If txtadndistrictaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះស្រុក/ក្រុង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtadndistrictaddstudent.Focus()
            Return
        End If
        If txtadnprovinceaddstudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះខេត្ត/រាជធានី!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtadnprovinceaddstudent.Focus()
            Return
        End If
        Call Fillidschedule()
        Call Filltxtidayid(cbdaystudyaddstudent)
        Call Filltxttimenameid(cbtimestudyaddstudent)
        Call filltxttimeid(cbohourstudyaddstudent)
        Call Fillsubid(cbosubjectaddstudent)
        Call FillDetailstudentid()
        Call Filltermid()
        Call Filltxtattid()
        Call Filltxtattdetailid()
        Call Filltxtscoreid()
        Call Filltxtscoredetailid()
        Call Filltxtpaymenid()
        Call Filltxtpaymendetailid()
        'DALSchedule.GetAllDatascheduleFromDatabase()
        Dim i As Integer
        'For i = 0 To DALSchedule.listalldataschedulefromdatabase.Count - 1
        '    If txtdayid.Trim.ToString.Equals(DALSchedule.listalldataschedulefromdatabase.Item(i).dayid.ToString.Trim) And txttimenameid.Trim.ToString.Equals(DALSchedule.listalldataschedulefromdatabase.Item(i).timenameid.ToString.Trim) And timeid.Trim.ToString.Equals(DALSchedule.listalldataschedulefromdatabase.Item(i).timeid.ToString.Trim) And subid.Trim.ToString.Equals(DALSchedule.listalldataschedulefromdatabase.Item(i).subid.ToString.Trim) Then
        '        sdid = DALSchedule.listalldataschedulefromdatabase.Item(i).sdid
        'Dim ms As New MemoryStream
        '        imgstudent.Image.Save(ms, imgstudent.Image.RawFormat)
        '        Dim im() As Byte
        '        im = ms.ToArray
        '    DALStudent.addupdatestudenttodatabase("adddatastudent", "ទិន្នន័យត្រូវបានរក្សាទុកទៅក្នុង Database រួចរាល់!", txtidaddstudent.Text.ToString, txtidcardaddstudent.Text.ToString, txtkhmernameaddstudent.Text.ToString, txtlatinnameaddstudent.Text.ToString, txtnationaddstudent.Text.ToString, txtnationalityaddstudent.Text.ToString, cbgenderaddstudent.Text.ToString, dtdobaddstudent.Text.ToString, txtphonenumberaddstudent.Text.ToString, txtemailaddstudent.Text.ToString, txtpobroadnoaddstudent.Text.ToString, txtpobhomenoaddstudent.Text.ToString, txtpobvillageaddstudent.Text.ToString, txtpobcommuneaddstudent.Text.ToString, txtpobdistrictaddstudent.Text.ToString, txtpobprovinceaddstudent.Text.ToString, txtadnroadnoaddstudent.Text.ToString, txtadnhomenoaddstudent.Text.ToString, txtadnvillageaddstudent.Text.ToString, txtadncommuneaddstudent.Text.ToString, txtadndistrictaddstudent.Text.ToString, txtadnprovinceaddstudent.Text.ToString, im)
        '    DALStudent.adddatatermtodatabase("adddataterm", txttermid, dtstartdateaddstudent.Text.ToString, "", "", "", "", "Active")
        '    DALStudent.addupdatedataattandant("Adddataatt", attid, "", "Active")
        '    DALStudent.adddatadetailattandant("Adddataattdetail", attdetailid, attid, "", "", "")
        '    DALStudent.addupdatedatascore("Adddscore", scoreid, "", "")
        '    DALStudent.adddatadetailscore("AdddscoreDetail", scoredetailid, scoreid, "", 0, "", "")
        '    DALStudent.addupdatedatapayment("Addpayment", paymentid, "", "")
        '    DALStudent.adddatadetailpayment("Adddetailpayment", paymentdetailid, paymentid, 0, 0, 0, "", "", "")
        '    DALStudent.adddatadetailstudent("adddatadetailstudent", detailstudentid.ToString, sdid.ToString, txtidaddstudent.Text.ToString, txttermid, attid, scoreid, paymentid, "")
        '    DALStudent.SetIDStudent(txtidaddstudent)
        '    Call clearpaddstudent()
        '    Return
        'Else
        '    Try
        Dim ms As New MemoryStream
        imgstudent.Image.Save(ms, imgstudent.Image.RawFormat)
        Dim im() As Byte
        im = ms.ToArray
        DALStudent.addupdatestudenttodatabase("adddatastudent", "ទិន្នន័យត្រូវបានរក្សាទុកទៅក្នុង Database រួចរាល់!", txtidaddstudent.Text.ToString, txtidcardaddstudent.Text.ToString, txtkhmernameaddstudent.Text.ToString, txtlatinnameaddstudent.Text.ToString, txtnationaddstudent.Text.ToString, txtnationalityaddstudent.Text.ToString, cbgenderaddstudent.Text.ToString, dtdobaddstudent.Text.ToString, txtphonenumberaddstudent.Text.ToString, txtemailaddstudent.Text.ToString, txtpobroadnoaddstudent.Text.ToString, txtpobhomenoaddstudent.Text.ToString, txtpobvillageaddstudent.Text.ToString, txtpobcommuneaddstudent.Text.ToString, txtpobdistrictaddstudent.Text.ToString, txtpobprovinceaddstudent.Text.ToString, txtadnroadnoaddstudent.Text.ToString, txtadnhomenoaddstudent.Text.ToString, txtadnvillageaddstudent.Text.ToString, txtadncommuneaddstudent.Text.ToString, txtadndistrictaddstudent.Text.ToString, txtadnprovinceaddstudent.Text.ToString, im)
        DALStudent.adddatatermtodatabase("adddataterm", txttermid, dtstartdateaddstudent.Text.ToString, "", "", "", "", "Active")
        DALStudent.addupdatedataattandant("Adddataatt", attid, "", "Active")
        DALStudent.adddatadetailattandant("Adddataattdetail", attdetailid, attid, "", "", "")
        DALStudent.addupdatedatascore("Adddscore", scoreid, "", "")
        DALStudent.adddatadetailscore("AdddscoreDetail", scoredetailid, scoreid, "", 0, "", "")
        DALStudent.addupdatedatapayment("Addpayment", paymentid, "", "")
        DALStudent.adddatadetailpayment("Adddetailpayment", paymentdetailid, paymentid, 0, 0, 0, "", "", "")
        DALSchedule.addupdatescheduletodatabase("AddDataSchedule", sdid, txtdayid, txttimenameid, timeid, subid, dtstartdateaddstudent.Text.ToString, "")
        DALStudent.adddatadetailstudent("adddatadetailstudent", detailstudentid.ToString, sdid.ToString, txtidaddstudent.Text.ToString, txttermid, attid, scoreid, paymentid, "")
        DALStudent.SetIDStudent(txtidaddstudent)
        Call clearpaddstudent()
        '        Catch ex As Exception

        '        End Try

        '    End If
        'Next

    End Sub
    Private Sub clearpaddstudent()
        DALStudent.SetIDStudent(txtidaddstudent)
        txtidcardaddstudent.Clear()
        txtkhmernameaddstudent.Clear()
        txtlatinnameaddstudent.Clear()
        txtnationaddstudent.Clear()
        txtnationalityaddstudent.Clear()
        cbgenderaddstudent.Text = ""
        dtdobaddstudent.Text = ""
        txtphonenumberaddstudent.Clear()
        txtemailaddstudent.Clear()
        dtstartdateaddstudent.Text = ""
        cbopartstudyaddstudent.Text = ""
        cbosubjectaddstudent.Text = ""
        cbdaystudyaddstudent.Text = ""
        cbtimestudyaddstudent.Text = ""
        cbohourstudyaddstudent.Text = ""
        imgstudent.Image = Nothing
        txtpobroadnoaddstudent.Clear()
        txtpobhomenoaddstudent.Clear()
        txtpobvillageaddstudent.Clear()
        txtpobcommuneaddstudent.Clear()
        txtpobdistrictaddstudent.Clear()
        txtpobprovinceaddstudent.Clear()
        txtadnroadnoaddstudent.Clear()
        txtadnhomenoaddstudent.Clear()
        txtadnvillageaddstudent.Clear()
        txtadncommuneaddstudent.Clear()
        txtadndistrictaddstudent.Clear()
        txtadnprovinceaddstudent.Clear()
        txtidcardaddstudent.Focus()
        Return
    End Sub
    Private Sub clearpmanagedatastudent()
        txtidmanagedatastudent.Clear()
        txtidcardmanagedatastudent.Clear()
        txtkhmernamemanagedatastudent.Clear()
        txtlatinnamemanagedatastudent.Clear()
        txtnationManagedatastudent.Clear()
        txtnationalitymanagedatastudent.Clear()
        cbogendermanagedatastudent.Text = ""
        dtpdobmanagedatastudent.Text = ""
        txtphonenumbermanagedatastudent.Clear()
        txtemailmanagedatastudent.Clear()
        dtpstartstudyManagedatastudent.Text = ""
        cbopartstudymanagedatastudent.Text = ""
        cbosubjectmanagedatastudent.Text = ""
        cbodaystudymanagedatastudent.Text = ""
        cbotimenammanagedatastudent.Text = ""
        cbotimestudymanagedatastudent.Text = ""
        pimagemanagedatastudent.Image = Nothing
        txtroadnopobmanagedatastudent.Clear()
        txthomenopobmanagedatastudent.Clear()
        txtvillagepobmanagedatastudent.Clear()
        txtcommunepobmanagedatastudent.Clear()
        txtdistrictpobmanagedatastudent.Clear()
        txtprovincepobmanagedatastudent.Clear()
        txtroadnoadnmanagedatastudent.Clear()
        txthomenoadnmanagedatastudent.Clear()
        txtvillageadnmanagedatastudent.Clear()
        txtcommuneadnmanagedatastudent.Clear()
        txtdistrictadnmanagedatastudent.Clear()
        txtprovinceadnmanagedatastudent.Clear()
        txtidmanagedatastudent.Focus()
        Return
    End Sub
    Private Sub clearpaddemployee()
        Call Filltxtempid()
        txtidaddemployee.Text = txtemployeeid
        txtidcardaddemployee.Clear()
        txtkhmernameaddemployee.Clear()
        txtlatinnameaddemployee.Clear()
        txtnationaddemployee.Clear()
        txtnationalityaddemployee.Clear()
        cbogenderaddemployee.Text = ""
        dtpdobaddemployee.Text = ""
        txtphonenumberaddemployee.Clear()
        txtemailaddemployee.Clear()
        dtpstartworkaddemployee.Text = ""
        pimageaddemployee.Image = Nothing
        txtpobroadnoaddemployee.Clear()
        txtpobhomenoaddemployee.Clear()
        txtpobvillageaddemployee.Clear()
        txtpobcommuneaddemployee.Clear()
        txtpobdistrictaddemployee.Clear()
        txtpobprovinceaddemployee.Clear()
        txtadnroadnoaddemployee.Clear()
        txtadnhomenoaddemployee.Clear()
        txtadnvillageaddemployee.Clear()
        txtadncommuneaddemployee.Clear()
        txtadndistrictaddemployee.Clear()
        txtadnprovinceaddemployee.Clear()
        txtidcardaddemployee.Focus()
        Return
    End Sub
    Private Sub clearmanagedataemployee()
        txtidmanagedataemployee.Clear()
        txtidcardmanagedataemployee.Clear()
        txtkhmernamemanagedataemployee.Clear()
        txtlatinnamemanagedataemployee.Clear()
        txtnationmanagedataemployee.Clear()
        txtnationalitymanagedataemployee.Clear()
        cbogendermanagedataemployee.Text = ""
        dtpdobmanagedataemployee.Text = ""
        txtphonenumbermanagedataemployee.Clear()
        txtemailmanagedataemployee.Clear()
        dtpstartworkmanagedataemployee.Text = ""
        pimagemanagedataemployee.Image = Nothing
        txtpobroadnomanagedataemployee.Clear()
        txtpobhomnomanagedataemployee.Clear()
        txtpobvillagemanagedataemployee.Clear()
        txtpobcommunemanagedataemployee.Clear()
        txtpobdistrictmanagedataemployee.Clear()
        txtpobprovincemanagedataemployee.Clear()
        txtadnroadnomanagedataemployee.Clear()
        txtadnhomenomanagedataemployee.Clear()
        txtadnvillagemanagedataemployee.Clear()
        txtadncommunemanagedataemployee.Clear()
        txtadndistrictmanagedataemployee.Clear()
        txtadnprovincemanagedataemployee.Clear()
        txtidmanagedataemployee.Focus()
        Return
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub បនថមទនននយសសសToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles បនថមទនននយសសសToolStripMenuItem.Click
        HidePanel()
        PBackground.Show()
        PAddstudent.Show()
        Call clearpaddstudent()
    End Sub

    Private Sub ករបងបរកថលសកសToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ករបងបរកថលសកសToolStripMenuItem.Click
        Dim fps As New FrmStudentFees
        fps.ShowDialog()
    End Sub

    Private Sub អវតតមនសសសToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles អវតតមនសសសToolStripMenuItem.Click

    End Sub

    Private Sub សរងអវតតមនToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles សរងអវតតមនToolStripMenuItem.Click
        Dim fatt As New Frmattantdant
        fatt.ShowDialog()
    End Sub

    Private Sub ពនជសសសToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ពនជសសសToolStripMenuItem.Click
        Dim fs As New FrmScore
        fs.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles tsmrestoreanddeletedataemployee.Click
        Dim x As New FrmDeleteAndRestoreDataEmployee
        x.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles tsmrestoreanddeletedatastudent.Click
        Dim x As New FrmRestoreAndDeleteDataStudent
        x.ShowDialog()
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles tsmmanagedatastudent.Click

    End Sub

    Private Sub គរបគរងToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles គរបគរងToolStripMenuItem.Click
        Dim frmdata As New frmdataattandant
        frmdata.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Dim frmallstu As New FrmAllstudent
        frmallstu.ShowDialog()
    End Sub

    Private Sub ចកចញToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmmanagedataemployee.Click

    End Sub

    Private Sub បនថមទនននយបគគលកToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles បនថមទនននយបគគលកToolStripMenuItem.Click
        Call HidePanel()
        Call clearpaddemployee()
        paddemployee.Show()
    End Sub

    Private Sub បរកខToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub សរងអវតតមនបគគលកToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub គរបគរងទនននយអវតតមនបគគលកToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub បរកខToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles បរកខToolStripMenuItem1.Click
        Dim fs As New FrmSalary
        fs.ShowDialog()
    End Sub

    Private Sub គរបគរងទនននយសសសToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmmanageemployeedata.Click
        Call HidePanel()
        Pmanagedataemployee.Show()
        DALEmployee.listallemployeeactive.Clear()
        dgvmanagedataemployee.Columns(0).Width = 50
        '    DALEmployee.GetAllDataEmployeeActiveFromDatabase()
        DALEmployee.ShowdataactiveemployeeFromDatabase(dgvmanagedataemployee)

    End Sub

    Private Sub toolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles tsmmanagesubject.Click

    End Sub

    Private Sub toolStripMenuItem8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub toolStripMenuItem9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub toolStripMenuItem10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem26_Click_1(sender As Object, e As EventArgs) Handles tsmmanageschedule.Click

    End Sub

    Private Sub ToolStripMenuItem28_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem28.Click
        Dim x As New Frmtimetable
        x.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click

    End Sub

    Private Sub CameraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CameraToolStripMenuItem.Click
        Dim currentScreen = Screen.FromHandle(Me.Handle).WorkingArea

        'create a bitmap of the working area
        Using bmp As New Bitmap(currentScreen.Width, currentScreen.Height)

            'copy the screen to the image
            Using g = Graphics.FromImage(bmp)
                g.CopyFromScreen(New Point(0, 0), New Point(0, 0), currentScreen.Size)
            End Using

            'save the image
            Using sfd As New SaveFileDialog() With {.Filter = "PNG Image|*.png",
                                                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop}

                If sfd.ShowDialog() = DialogResult.OK Then
                    bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png)
                End If
            End Using
        End Using
    End Sub

    Private Sub RestoreDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDatabaseToolStripMenuItem.Click
        Dim x As New FrmBackup
        x.ShowDialog()
    End Sub

    Private Sub BackUpDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackUpDatabaseToolStripMenuItem.Click
        Dim x As New FrmRestoreDatabase
        x.ShowDialog()
    End Sub

    Private Sub បញជគរបគរងសសសToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles បញជគរបគរងសសសToolStripMenuItem.Click

    End Sub

    Private Sub toolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles tsmusername.Click

    End Sub

    Private Sub បនថមចននសសសToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles បនថមចននសសសToolStripMenuItem.Click
        DAL.userid = ""
        DAL.listuserfromdatabase.Clear()
        Me.Hide()
        Dim frmlogin As New FrmLogin
        frmlogin.Show()

    End Sub

    Private Sub cbohourstudyaddstudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbohourstudyaddstudent.SelectedIndexChanged

    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

    End Sub

    Private Sub cbosubjectaddstudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosubjectaddstudent.SelectedIndexChanged

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub cbopartstudyaddstudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopartstudyaddstudent.SelectedIndexChanged

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub

    Private Sub cbtimestudyaddstudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtimestudyaddstudent.SelectedIndexChanged

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub txtadnprovinceaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtadnprovinceaddstudent.TextChanged

    End Sub

    Private Sub txtadnvillageaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtadnvillageaddstudent.TextChanged

    End Sub

    Private Sub txtadndistrictaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtadndistrictaddstudent.TextChanged

    End Sub

    Private Sub txtadnhomenoaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtadnhomenoaddstudent.TextChanged

    End Sub

    Private Sub txtadncommuneaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtadncommuneaddstudent.TextChanged

    End Sub

    Private Sub txtadnroadnoaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtadnroadnoaddstudent.TextChanged

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub txtpobprovinceaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtpobprovinceaddstudent.TextChanged

    End Sub

    Private Sub txtpobvillageaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtpobvillageaddstudent.TextChanged

    End Sub

    Private Sub txtpobdistrictaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtpobdistrictaddstudent.TextChanged

    End Sub

    Private Sub txtpobhomenoaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtpobhomenoaddstudent.TextChanged

    End Sub

    Private Sub txtpobcommuneaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtpobcommuneaddstudent.TextChanged

    End Sub

    Private Sub txtpobroadnoaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtpobroadnoaddstudent.TextChanged

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub imgstudent_Click(sender As Object, e As EventArgs) Handles imgstudent.Click

    End Sub

    Private Sub dtdobaddstudent_ValueChanged(sender As Object, e As EventArgs) Handles dtdobaddstudent.ValueChanged

    End Sub

    Private Sub cbgenderaddstudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbgenderaddstudent.SelectedIndexChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtlatinnameaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtlatinnameaddstudent.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtphonenumberaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtphonenumberaddstudent.TextChanged

    End Sub

    Private Sub txtemailaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtemailaddstudent.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtidcardaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtidcardaddstudent.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtkhmernameaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtkhmernameaddstudent.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtidaddstudent_TextChanged(sender As Object, e As EventArgs) Handles txtidaddstudent.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim x As New FrmDayStudy
        x.ShowDialog()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim x As New FrmNametime
        x.ShowDialog()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim x As New FrmTime
        x.ShowDialog()
    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click

    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles txtsearchmanagedatastudent.TextChanged
        dgvmanagedatastudent.Rows.Clear()
        DALStudent.liststudentfromdatabaseactive.Clear()
        DALStudent.GetDatastudentFromDatabaseActive()
        DALStudent.GetAllDatastudentFromDatabase()
        If Not txtsearchmanagedatastudent.Text = "" Then
            Dim i As Integer
            For i = 0 To DALStudent.liststudentfromdatabaseactive.Count - 1
                If (DALStudent.liststudentfromdatabaseactive.Item(i).namekhmer.ToUpper.Contains(txtsearchmanagedatastudent.Text.ToUpper) Or DALStudent.liststudentfromdatabaseactive.Item(i).namelatin.ToUpper.Contains(txtsearchmanagedatastudent.Text.ToUpper)) Then
                    dgvmanagedatastudent.Rows.Add(DALStudent.liststudentfromdatabaseactive.Item(i).Image, DALStudent.liststudentfromdatabaseactive.Item(i).id, DALStudent.liststudentfromdatabaseactive.Item(i).idcard, DALStudent.liststudentfromdatabaseactive.Item(i).namekhmer, DALStudent.liststudentfromdatabaseactive.Item(i).namelatin, DALStudent.liststudentfromdatabaseactive.Item(i).Nation, DALStudent.liststudentfromdatabaseactive.Item(i).Nationalty, DALStudent.liststudentfromdatabaseactive.Item(i).gender, DALStudent.liststudentfromdatabaseactive.Item(i).dob, DALStudent.liststudentfromdatabaseactive.Item(i).roadnopob & "," & DALStudent.liststudentfromdatabaseactive.Item(i).homenopob & "," & DALStudent.liststudentfromdatabaseactive.Item(i).villagepob & "," & DALStudent.liststudentfromdatabaseactive.Item(i).communepob & "," & DALStudent.liststudentfromdatabaseactive.Item(i).Districtpob & "," & DALStudent.liststudentfromdatabaseactive.Item(i).provincepob, DALStudent.liststudentfromdatabaseactive.Item(i).phonenumber, DALStudent.liststudentfromdatabaseactive.Item(i).emailaddress, DALStudent.liststudentfromdatabaseactive.Item(i).roadnoadn & "," & DALStudent.liststudentfromdatabaseactive.Item(i).homenoadn & "," & DALStudent.liststudentfromdatabaseactive.Item(i).villageadn & "," & DALStudent.liststudentfromdatabaseactive.Item(i).communeadn & "," & DALStudent.liststudentfromdatabaseactive.Item(i).Districtadn & "," & DALStudent.liststudentfromdatabaseactive.Item(i).provinceadn, DALStudent.liststudentfromdatabaseactive.Item(i).dayid, DALStudent.liststudentfromdatabaseactive.Item(i).timenameid, DALStudent.liststudentfromdatabaseactive.Item(i).timeid, DALStudent.liststudentfromdatabaseactive.Item(i).desc, DALStudent.liststudentfromdatabaseactive.Item(i).subid, DALStudent.liststudentfromdatabaseactive.Item(i).Startdate)
                End If
            Next
        End If
        If txtsearchmanagedatastudent.Text = "" Then
            DALStudent.liststudentfromdatabaseactive.Clear()
            DALStudent.ShowalldatastudentFromDatabase(dgvmanagedatastudent)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If txtidmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសទិន្នន័យដើម្បីធ្វើការលុប!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtidmanagedatastudent.Focus()
            Return
        End If
        DALStudent.DeleteRestoredataStudent("updatedatastudentdelete", "Delete", txtidmanagedatastudent.Text.ToString)
        MessageBox.Show("ទិន្នន័យត្រូវបានលុបចេញពី Database!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call clearpmanagedatastudent()
        DALStudent.listscoredetailfromdatabaseactive.Clear()
        DALStudent.GetAllDatastudentFromDatabase
        DALStudent.ShowalldatastudentFromDatabase(dgvmanagedatastudent)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If txtidmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសទិន្នន័យដើម្បីធ្វើការកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtidmanagedatastudent.Focus()
            Return
        End If
        If txtidcardmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខអត្តសញ្ញាណប័ណ្ណ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtidcardmanagedatastudent.Focus()
            Return
        End If
        If txtkhmernamemanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចលឈ្មោះជាភាសាខ្មែរ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtkhmernamemanagedatastudent.Focus()
            Return
        End If
        If txtlatinnamemanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះជាអក្សរឡាតាំង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtlatinnamemanagedatastudent.Focus()
            Return
        End If
        If txtnationManagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះជាតិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnationManagedatastudent.Focus()
            Return
        End If
        If txtnationalitymanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះសញ្ជាតិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnationalitymanagedatastudent.Focus()
            Return
        End If
        If cbogendermanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសភេទ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbodaystudymanagedatastudent.Focus()
            Return
        End If
        If dtpdobmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសថ្ងៃខែឆ្នាំកំណើត!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpdobmanagedatastudent.Focus()
            Return
        End If
        If txtphonenumbermanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខទូរស័ព្ទ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtphonenumbermanagedatastudent.Focus()
            Return
        End If
        If txtemailmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអ៊ីម៉ែល!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtemailmanagedatastudent.Focus()
            Return
        End If
        If dtpstartstudyManagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលជ្រើសរើសថ្ងៃចូលរៀង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpstartstudyManagedatastudent.Focus()
            Return
        End If
        If cbopartstudymanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសផ្នែកសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbopartstudymanagedatastudent.Focus()
            Return
        End If
        If cbosubjectmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសមុខវិជ្ជាសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbosubjectmanagedatastudent.Focus()
            Return
        End If
        If cbodaystudymanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសថ្ងៃសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbodaystudymanagedatastudent.Focus()
            Return
        End If
        If cbotimenammanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសពេលសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbotimenammanagedatastudent.Focus()
            Return
        End If
        If cbotimestudymanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសម៉ោងសិក្សា!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbotimestudymanagedatastudent.Focus()
            Return
        End If
        If pimagemanagedatastudent.Image Is Nothing Then
            MessageBox.Show("សូមបញ្ចូលរូបភាព!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnpicturemanagedatastudent.Focus()
            Return
        End If
        If txtroadnopobmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខផ្លូវ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtroadnopobmanagedatastudent.Focus()
            Return
        End If
        If txthomenopobmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខផ្ទះ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txthomenopobmanagedatastudent.Focus()
            Return
        End If
        If txtvillagepobmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះភូមិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtvillagepobmanagedatastudent.Focus()
            Return
        End If
        If txtcommunepobmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះឃុំ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcommunepobmanagedatastudent.Focus()
            Return
        End If
        If txtdistrictpobmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះស្រុក/ក្រុង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtdistrictpobmanagedatastudent.Focus()
            Return
        End If
        If txtprovincepobmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះខេត្ត/រាជធានី!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtprovincepobmanagedatastudent.Focus()
            Return
        End If
        If txtroadnoadnmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខផ្លូវ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtroadnoadnmanagedatastudent.Focus()
            Return
        End If
        If txthomenoadnmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខផ្ទះ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txthomenoadnmanagedatastudent.Focus()
            Return
        End If
        If txtvillageadnmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះភូមិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtvillageadnmanagedatastudent.Focus()
            Return
        End If
        If txtcommuneadnmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះឃុំ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcommuneadnmanagedatastudent.Focus()
            Return
        End If
        If txtdistrictadnmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះស្រុក/ក្រុង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtdistrictadnmanagedatastudent.Focus()
            Return
        End If
        If txtprovinceadnmanagedatastudent.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះខេត្ត/រាជធានី!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtprovinceadnmanagedatastudent.Focus()
            Return
        End If
        'Call Fillsdid()
        'Call Filltermid()
        'Call Filltxtidayid(cbodaystudymanagedatastudent)
        'Call Filltxttimenameid(cbotimenammanagedatastudent)
        'Call filltxttimeid(cbotimenammanagedatastudent)
        'Call Fillsubid(cbosubjectmanagedatastudent)
        Dim i As Integer
        Dim ms As New MemoryStream
        pimagemanagedatastudent.Image.Save(ms, pimagemanagedatastudent.Image.RawFormat)
        Dim im() As Byte
        im = ms.ToArray
        DALStudent.addupdatestudenttodatabase("updatedatastudent", "ទិន្នន័យត្រូវបានកែប្រែរួចរាល់!", txtidmanagedatastudent.Text.ToString, txtidcardmanagedatastudent.Text.ToString, txtkhmernamemanagedatastudent.Text.ToString, txtlatinnamemanagedatastudent.Text.ToString, txtnationManagedatastudent.Text.ToString, txtnationalitymanagedatastudent.Text.ToString, cbogendermanagedatastudent.Text.ToString, dtpdobmanagedatastudent.Text.ToString, txtphonenumbermanagedatastudent.Text.ToString, txtemailmanagedatastudent.Text.ToString, txtroadnopobmanagedatastudent.Text.ToString, txthomenopobmanagedatastudent.Text.ToString, txtvillagepobmanagedatastudent.Text.ToString, txtcommunepobmanagedatastudent.Text.ToString, txtdistrictpobmanagedatastudent.Text.ToString, txtprovincepobmanagedatastudent.Text.ToString, txtroadnoadnmanagedatastudent.Text.ToString, txthomenoadnmanagedatastudent.Text.ToString, txtvillageadnmanagedatastudent.Text.ToString, txtcommuneadnmanagedatastudent.Text.ToString, txtdistrictadnmanagedatastudent.Text.ToString, txtprovinceadnmanagedatastudent.Text.ToString, im)
        ' DALStudent.adddatatermtodatabase("adddataterm", txttermid, dtstartdateaddstudent.Text.ToString, "", "", "", "", "Active")
        'DALSchedule.addupdatescheduletodatabase("updatedataschedule", sdid, txtdayid, txttimenameid, timeid, subid, dtstartdateaddstudent.Text.ToString, "")
        DALStudent.listscoredetailfromdatabaseactive.Clear()
        DALStudent.ShowalldatastudentFromDatabase(dgvmanagedatastudent)
        Call clearpmanagedatastudent()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmanagedatastudent.CellContentClick
        Dim img() As Byte
        txtidmanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(1).Value.ToString
        txtidcardmanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(2).Value
        txtkhmernamemanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(3).Value
        txtlatinnamemanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(4).Value
        txtnationManagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(5).Value
        txtnationalitymanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(6).Value
        cbogendermanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(7).Value
        dtpdobmanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(8).Value
        Dim Str As String = dgvmanagedatastudent.CurrentRow.Cells(9).Value
        Dim strArr() As String
        Dim count As Integer
        strArr = Str.Split(",")
        For count = 0 To strArr.Length - 1
            txtroadnopobmanagedatastudent.Text = strArr(0)
            txthomenopobmanagedatastudent.Text = strArr(1)
            txtvillagepobmanagedatastudent.Text = strArr(2)
            txtcommunepobmanagedatastudent.Text = strArr(3)
            txtdistrictpobmanagedatastudent.Text = strArr(4)
            txtprovincepobmanagedatastudent.Text = strArr(5)
        Next
        txtphonenumbermanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(10).Value
        txtemailmanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(11).Value
        Dim StrA As String = dgvmanagedatastudent.CurrentRow.Cells(12).Value
        Dim strArrA() As String
        Dim countA As Integer
        strArrA = StrA.Split(",")
        For countA = 0 To strArrA.Length - 1
            txtroadnoadnmanagedatastudent.Text = strArrA(0)
            txthomenoadnmanagedatastudent.Text = strArrA(1)
            txtvillageadnmanagedatastudent.Text = strArrA(2)
            txtcommuneadnmanagedatastudent.Text = strArrA(3)
            txtdistrictadnmanagedatastudent.Text = strArrA(4)
            txtprovinceadnmanagedatastudent.Text = strArrA(5)
        Next
        cbodaystudymanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(13).Value
        cbotimenammanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(14).Value
        cbotimestudymanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(15).Value
        cbopartstudymanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(16).Value
        cbosubjectmanagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(17).Value
        dtpstartstudyManagedatastudent.Text = dgvmanagedatastudent.CurrentRow.Cells(18).Value

        'dtpstartworkmanagedataemployee.Text = dgvmanagedataemployee.CurrentRow.Cells(13).Value
        img = dgvmanagedatastudent.CurrentRow.Cells(0).Value
        Dim ms As New MemoryStream(img)
        pimagemanagedatastudent.Image = Image.FromStream(ms)
    End Sub

    Private Sub cbotimestudymodifystudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbotimestudymanagedatastudent.SelectedIndexChanged

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub cbosubjectmodifystudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosubjectmanagedatastudent.SelectedIndexChanged

    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

    End Sub

    Private Sub cbopartstudymodifystudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopartstudymanagedatastudent.SelectedIndexChanged

    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpstartstudyManagedatastudent.ValueChanged

    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click

    End Sub

    Private Sub cbotimenamemodifystudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbotimenammanagedatastudent.SelectedIndexChanged

    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click

    End Sub

    Private Sub cbodaystudymodifysubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodaystudymanagedatastudent.SelectedIndexChanged

    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call HidePanel()
        pbackgroundss.Show()
    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click

    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtprovinceadnmanagedatastudent.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtvillageadnmanagedatastudent.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtdistrictadnmanagedatastudent.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txthomenoadnmanagedatastudent.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtcommuneadnmanagedatastudent.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtroadnoadnmanagedatastudent.TextChanged

    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click

    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click

    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click

    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click

    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click

    End Sub

    Private Sub Label45_Click(sender As Object, e As EventArgs) Handles Label45.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtprovincepobmanagedatastudent.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txtvillagepobmanagedatastudent.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles txtdistrictpobmanagedatastudent.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles txthomenopobmanagedatastudent.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles txtcommunepobmanagedatastudent.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles txtroadnopobmanagedatastudent.TextChanged

    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click

    End Sub

    Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click

    End Sub

    Private Sub Label48_Click(sender As Object, e As EventArgs) Handles Label48.Click

    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click

    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs) Handles Label50.Click

    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnpicturemanagedatastudent.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "choose image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            pimagemanagedatastudent.Image = Image.FromFile(opf.FileName)
        End If
        Dim ms As New MemoryStream
        pimagemanagedatastudent.Image.Save(ms, pimagemanagedatastudent.Image.RawFormat)
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pimagemanagedatastudent.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles dtpdobmanagedatastudent.ValueChanged

    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbogendermanagedatastudent.SelectedIndexChanged

    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click

    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click

    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles Label54.Click

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles txtlatinnamemanagedatastudent.TextChanged

    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs) Handles Label55.Click

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles txtphonenumbermanagedatastudent.TextChanged

    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles txtemailmanagedatastudent.TextChanged

    End Sub

    Private Sub Label56_Click(sender As Object, e As EventArgs) Handles Label56.Click

    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles txtidcardmanagedatastudent.TextChanged

    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs) Handles Label57.Click

    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles txtkhmernamemanagedatastudent.TextChanged

    End Sub

    Private Sub Label58_Click(sender As Object, e As EventArgs) Handles Label58.Click

    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles txtidmanagedatastudent.TextChanged

    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click

    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs) Handles Label60.Click

    End Sub

    Private Sub Label61_Click(sender As Object, e As EventArgs) Handles Label61.Click

    End Sub

    Private Sub pbackgroundss_Paint(sender As Object, e As PaintEventArgs) Handles pbackgroundss.Paint

    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs) Handles Label63.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub paddemployee_Paint(sender As Object, e As PaintEventArgs) Handles paddemployee.Paint

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pimageaddemployee.Click

    End Sub

    Private Sub btnimageaddemployee_Click(sender As Object, e As EventArgs) Handles btnimageaddemployee.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "choose image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            pimageaddemployee.Image = Image.FromFile(opf.FileName)
        End If
        Dim ms As New MemoryStream
        pimageaddemployee.Image.Save(ms, pimageaddemployee.Image.RawFormat)
    End Sub

    Private Sub បគគលកឈបធវករToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles បគគលកឈបធវករToolStripMenuItem.Click
        Dim fsw As New FrmStopwork
        fsw.ShowDialog()
    End Sub

    Private Sub btnsaveaddemployee_Click(sender As Object, e As EventArgs) Handles btnsaveaddemployee.Click
        Try
            If txtidaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលអត្តលេខ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtidaddemployee.Focus()
                Return
            End If
            If txtidcardaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលលេខអត្តសញ្ញាណប័ណ្ណ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtidcardaddemployee.Focus()
                Return
            End If
            If txtkhmernameaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចលឈ្មោះជាភាសាខ្មែរ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtkhmernameaddemployee.Focus()
                Return
            End If
            If txtlatinnameaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលឈ្មោះជាអក្សរឡាតាំង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtlatinnameaddemployee.Focus()
                Return
            End If
            If txtnationaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលឈ្មោះជាតិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtnationaddemployee.Focus()
                Return
            End If
            If txtnationalityaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលឈ្មោះសញ្ជាតិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtnationalityaddemployee.Focus()
                Return
            End If
            If cbogenderaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមជ្រើសរើសភេទ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbogenderaddemployee.Focus()
                Return
            End If
            If dtpdobaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមជ្រើសរើសថ្ងៃខែឆ្នាំកំណើត!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpdobaddemployee.Focus()
                Return
            End If
            If txtphonenumberaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលលេខទូរស័ព្ទ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtphonenumberaddemployee.Focus()
                Return
            End If
            If txtemailaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលអ៊ីម៉ែល!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtemailaddemployee.Focus()
                Return
            End If
            If dtpstartworkaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលថ្ងៃចាប់ផ្តើមធ្វើការ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpstartworkaddemployee.Focus()
                Return
            End If
            If pimageaddemployee.Image Is Nothing Then
                MessageBox.Show("សូមបញ្ចូលរូបភាព!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnimageaddemployee.Focus()
                Return
            End If
            If txtpobroadnoaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលលេខផ្លូវ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtpobroadnoaddemployee.Focus()
                Return
            End If
            If txtpobhomenoaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលលេខផ្ទះ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtpobhomenoaddemployee.Focus()
                Return
            End If
            If txtpobvillageaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលឈ្មោះភូមិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtpobvillageaddemployee.Focus()
                Return
            End If
            If txtpobcommuneaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលឈ្មោះឃុំ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtpobcommuneaddemployee.Focus()
                Return
            End If
            If txtpobdistrictaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលឈ្មោះស្រុក/ក្រុង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtpobdistrictaddemployee.Focus()
                Return
            End If
            If txtpobprovinceaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលឈ្មោះខេត្ត/រាជធានី!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtpobprovinceaddemployee.Focus()
                Return
            End If
            If txtadnroadnoaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលលេខផ្លូវ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtadnroadnoaddemployee.Focus()
                Return
            End If
            If txtadnhomenoaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលលេខផ្ទះ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtadnhomenoaddemployee.Focus()
                Return
            End If
            If txtadnvillageaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលឈ្មោះភូមិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtadnvillageaddemployee.Focus()
                Return
            End If
            If txtadncommuneaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលឈ្មោះឃុំ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtadncommuneaddemployee.Focus()
                Return
            End If
            If txtadndistrictaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលឈ្មោះស្រុក/ក្រុង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtadndistrictaddemployee.Focus()
                Return
            End If
            If txtadnprovinceaddemployee.Text.Equals("") Then
                MessageBox.Show("សូមបញ្ចូលឈ្មោះខេត្ត/រាជធានី!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtadnprovinceaddemployee.Focus()
                Return
            End If
            Call Filltxtstopworkid()
            Call Filltxtdetailempid()
            Call Filltxtdetailsrid()
            Call Filltxtsrid()
            For i = 0 To DALEmployee.listallemployee.Count - 1
                If DALEmployee.listallemployee.Item(i).ID = txtidaddemployee.Text Then
                    MsgBox("ទិន្នន័យស្ទួន មិនអាចបញ្ចូលទៅកាន់ Database ទេ")
                    Filltxtempid()
                    txtidaddemployee.Text = txtemployeeid
                    Return
                End If
            Next
            Dim ms As New MemoryStream
            pimageaddemployee.Image.Save(ms, pimageaddemployee.Image.RawFormat)
            Dim im() As Byte
            im = ms.ToArray
            DALEmployee.addupdateEmployeetodatabase("addemployee", "ទិន្នន័យត្រូវបានរក្សាទុកទៅក្នុង Database រួចរាល់!", txtidaddemployee.Text.ToString, txtidcardaddemployee.Text.ToString, txtkhmernameaddemployee.Text.ToString, txtlatinnameaddemployee.Text.ToString, txtnationaddemployee.Text.ToString, txtnationalityaddemployee.Text.ToString, cbogenderaddemployee.Text.ToString, dtpdobaddemployee.Text.ToString, txtpobroadnoaddemployee.Text.ToString, txtpobhomenoaddemployee.Text.ToString, txtpobvillageaddemployee.Text.ToString, txtpobcommuneaddemployee.Text.ToString, txtpobdistrictaddemployee.Text.ToString, txtpobprovinceaddemployee.Text.ToString, txtphonenumberaddemployee.Text.ToString, txtemailaddemployee.Text.ToString, txtadnroadnoaddemployee.Text.ToString, txtadnhomenoaddemployee.Text.ToString, txtadnvillageaddemployee.Text.ToString, txtadncommuneaddemployee.Text.ToString, txtadndistrictaddemployee.Text.ToString, txtadnprovinceaddemployee.Text.ToString, im)
            DALEmployee.addUpdatesalarytodatabase("addsalary", txtsalaryid, "", "")
            DALEmployee.addUpdatedetailsalarytpdatabase("addsalarydetail", txtsalarydetailid, txtsalaryid, 0, "", "")
            DALStudent.adddatatermtodatabase("adddataterm", txtstopworkid, dtpstartworkaddemployee.Text.ToString, "", "", "", "", "Active")
            DALEmployee.addUpdateDetailemployeetodatabase("adddetailemployee", txtdetailemployeeid, txtstopworkid, txtemployeeid, txtsalaryid, "")
            DALEmployee.listallemployee.Clear()
            Call clearpaddemployee()
            Call Filltxtempid()
            txtidaddemployee.Text = txtemployeeid
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cbogenderaddemployee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbogenderaddemployee.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnclearaddemployee_Click(sender As Object, e As EventArgs) Handles btnclearaddemployee.Click
        Call clearpaddemployee()
    End Sub

    Private Sub btncloseaddemployee_Click(sender As Object, e As EventArgs) Handles btncloseaddemployee.Click
        Call HidePanel()
        pbackgroundss.Show()
    End Sub

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint

    End Sub

    Private Sub Panel15_Paint(sender As Object, e As PaintEventArgs) Handles Panel15.Paint

    End Sub

    Private Sub dgvmanagedataemployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmanagedataemployee.CellContentClick
        Dim img() As Byte
        txtidmanagedataemployee.Text = dgvmanagedataemployee.CurrentRow.Cells(1).Value.ToString
        txtidcardmanagedataemployee.Text = dgvmanagedataemployee.CurrentRow.Cells(2).Value
        txtkhmernamemanagedataemployee.Text = dgvmanagedataemployee.CurrentRow.Cells(3).Value
        txtlatinnamemanagedataemployee.Text = dgvmanagedataemployee.CurrentRow.Cells(4).Value
        txtnationmanagedataemployee.Text = dgvmanagedataemployee.CurrentRow.Cells(5).Value
        txtnationalitymanagedataemployee.Text = dgvmanagedataemployee.CurrentRow.Cells(6).Value
        cbogendermanagedataemployee.Text = dgvmanagedataemployee.CurrentRow.Cells(7).Value
        dtpdobmanagedataemployee.Text = dgvmanagedataemployee.CurrentRow.Cells(8).Value
        Dim Str As String = dgvmanagedataemployee.CurrentRow.Cells(9).Value
        Dim strArr() As String
        Dim count As Integer
        strArr = Str.Split(",")
        For count = 0 To strArr.Length - 1
            txtpobroadnomanagedataemployee.Text = strArr(0)
            txtpobhomnomanagedataemployee.Text = strArr(1)
            txtpobvillagemanagedataemployee.Text = strArr(2)
            txtpobcommunemanagedataemployee.Text = strArr(3)
            txtpobdistrictmanagedataemployee.Text = strArr(4)
            txtpobprovincemanagedataemployee.Text = strArr(5)
        Next
        txtphonenumbermanagedataemployee.Text = dgvmanagedataemployee.CurrentRow.Cells(10).Value
        txtemailmanagedataemployee.Text = dgvmanagedataemployee.CurrentRow.Cells(11).Value
        Dim StrA As String = dgvmanagedataemployee.CurrentRow.Cells(12).Value
        Dim strArrA() As String
        Dim countA As Integer
        strArrA = StrA.Split(",")
        For countA = 0 To strArrA.Length - 1
            txtadnroadnomanagedataemployee.Text = strArrA(0)
            txtadnhomenomanagedataemployee.Text = strArrA(1)
            txtadnvillagemanagedataemployee.Text = strArrA(2)
            txtadncommunemanagedataemployee.Text = strArrA(3)
            txtadndistrictmanagedataemployee.Text = strArrA(4)
            txtadnprovincemanagedataemployee.Text = strArrA(5)
        Next
        dtpstartworkmanagedataemployee.Text = dgvmanagedataemployee.CurrentRow.Cells(13).Value
        img = dgvmanagedataemployee.CurrentRow.Cells(0).Value
        Dim ms As New MemoryStream(img)
        pimagemanagedataemployee.Image = Image.FromStream(ms)
    End Sub

    Private Sub txtsearchmanagedataemployee_TextChanged(sender As Object, e As EventArgs) Handles txtsearchmanagedataemployee.TextChanged
        dgvmanagedataemployee.Rows.Clear()
        DALEmployee.listallemployeeactive.Clear()
        DALEmployee.GetAllDataEmployeeFromDatabase()
        DALEmployee.GetAllDataEmployeeActiveFromDatabase()

        If Not txtsearchmanagedataemployee.Text = "" Then
            Dim i As Integer
            For i = 0 To DALEmployee.listallemployeeactive.Count - 1
                If (DALEmployee.listallemployeeactive.Item(i).Khmername.ToUpper.Contains(txtsearchmanagedataemployee.Text.ToUpper) Or DALEmployee.listallemployeeactive.Item(i).Latinname.ToUpper.Contains(txtsearchmanagedataemployee.Text.ToUpper)) Then
                    dgvmanagedataemployee.Rows.Add(DALEmployee.listallemployeeactive.Item(i).Image, DALEmployee.listallemployee.Item(i).ID, DALEmployee.listallemployeeactive.Item(i).IDcard, DALEmployee.listallemployeeactive.Item(i).Khmername, DALEmployee.listallemployeeactive.Item(i).Latinname, DALEmployee.listallemployeeactive.Item(i).Nation, DALEmployee.listallemployeeactive.Item(i).Nationality, DALEmployee.listallemployeeactive.Item(i).Gender, DALEmployee.listallemployeeactive.Item(i).DOB, DALEmployee.listallemployeeactive.Item(i).Pobroadno & "," & DALEmployee.listallemployeeactive.Item(i).Pobhomeno & "," & DALEmployee.listallemployeeactive.Item(i).Pobvillage & "," & DALEmployee.listallemployeeactive.Item(i).Pobcommube & "," & DALEmployee.listallemployeeactive.Item(i).Pobdistrict & "," & DALEmployee.listallemployeeactive.Item(i).PobProvince, DALEmployee.listallemployeeactive.Item(i).PhoneNumber, DALEmployee.listallemployeeactive.Item(i).Emailaddress, DALEmployee.listallemployeeactive.Item(i).Adnroadno & "," & DALEmployee.listallemployeeactive.Item(i).Adnhomeno & "," & DALEmployee.listallemployeeactive.Item(i).Adnvillage & "," & DALEmployee.listallemployeeactive.Item(i).Adncommune & "," & DALEmployee.listallemployeeactive.Item(i).Adndistrict & "," & DALEmployee.listallemployeeactive.Item(i).Adnprovince, DALEmployee.listallemployeeactive.Item(i).startwork)
                End If
            Next
        End If
        If txtsearchmanagedataemployee.Text = "" Then
            DALEmployee.listallemployeeactive.Clear()
            DALEmployee.ShowdataactiveemployeeFromDatabase(dgvmanagedataemployee)
        End If
    End Sub

    Private Sub txtclearmanagedataemployee_Click(sender As Object, e As EventArgs) Handles txtclearmanagedataemployee.Click
        Call clearmanagedataemployee()
    End Sub

    Private Sub btnmodifymanagedataemployee_Click(sender As Object, e As EventArgs) Handles btnmodifymanagedataemployee.Click
        If txtidmanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសទិន្នន័យដើម្បីធ្វើការកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtidmanagedataemployee.Focus()
            Return
        End If
        If txtidcardmanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខអត្តសញ្ញាណប័ណ្ណ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtidcardmanagedataemployee.Focus()
            Return
        End If
        If txtkhmernamemanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចលឈ្មោះជាភាសាខ្មែរ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtkhmernamemanagedataemployee.Focus()
            Return
        End If
        If txtlatinnamemanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះជាអក្សរឡាតាំង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtlatinnamemanagedataemployee.Focus()
            Return
        End If
        If txtnationmanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះជាតិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnationmanagedataemployee.Focus()
            Return
        End If
        If txtnationalitymanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះសញ្ជាតិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnationalitymanagedataemployee.Focus()
            Return
        End If
        If cbogendermanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសភេទ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbogendermanagedataemployee.Focus()
            Return
        End If
        If dtpdobmanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសថ្ងៃខែឆ្នាំកំណើត!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpdobmanagedataemployee.Focus()
            Return
        End If
        If txtphonenumbermanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខទូរស័ព្ទ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtphonenumbermanagedataemployee.Focus()
            Return
        End If
        If txtemailmanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអ៊ីម៉ែល!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtemailmanagedataemployee.Focus()
            Return
        End If
        If dtpstartworkmanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលថ្ងៃចាប់ផ្តើមធ្វើការ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpstartworkmanagedataemployee.Focus()
            Return
        End If
        If pimagemanagedataemployee.Image Is Nothing Then
            MessageBox.Show("សូមបញ្ចូលរូបភាព!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnpicturemanagedataemployee.Focus()
            Return
        End If
        If txtpobroadnomanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខផ្លូវ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpobroadnomanagedataemployee.Focus()
            Return
        End If
        If txtpobhomnomanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខផ្ទះ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpobhomnomanagedataemployee.Focus()
            Return
        End If
        If txtpobvillagemanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះភូមិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpobvillagemanagedataemployee.Focus()
            Return
        End If
        If txtpobcommunemanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះឃុំ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpobcommunemanagedataemployee.Focus()
            Return
        End If
        If txtpobdistrictmanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះស្រុក/ក្រុង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpobdistrictmanagedataemployee.Focus()
            Return
        End If
        If txtpobprovincemanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះខេត្ត/រាជធានី!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpobprovincemanagedataemployee.Focus()
            Return
        End If
        If txtadnroadnomanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខផ្លូវ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtadnroadnomanagedataemployee.Focus()
            Return
        End If
        If txtadnhomenomanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលលេខផ្ទះ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtadnhomenomanagedataemployee.Focus()
            Return
        End If
        If txtadnvillagemanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះភូមិ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtadnvillagemanagedataemployee.Focus()
            Return
        End If
        If txtadncommunemanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះឃុំ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtadncommunemanagedataemployee.Focus()
            Return
        End If
        If txtadndistrictmanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះស្រុក/ក្រុង!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtadndistrictmanagedataemployee.Focus()
            Return
        End If
        If txtadnprovincemanagedataemployee.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះខេត្ត/រាជធានី!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtadnprovincemanagedataemployee.Focus()
            Return
        End If
        If DALEmployee.listallemployeeactive.Count <= 0 Then
            MessageBox.Show("ទិន្នន័យនេះមិនមាននៅក្នុង Database ទេ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        DALEmployee.GetAllDataEmployeeActiveFromDatabase()

        'For i = 0 To DALEmployee.listallemployeeactive.Count - 1
        '    If DALEmployee.listallemployeeactive.Item(i).ID.Equals(txtidmanagedataemployee.Text.ToString) Then
        '    Else
        '        MessageBox.Show("អត្តលេខមិនត្រឹមត្រូវ សូមជ្រើសរើសទិន្នន័យដើម្បីកែប្រែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        txtidmanagedataemployee.Clear()
        '        Call clearmanagedataemployee()
        '        txtidcardmanagedataemployee.Focus()
        '        Return
        '    End If
        'Next
        Filltxttermidmanagedatastudent()
        Dim ms As New MemoryStream
        pimagemanagedataemployee.Image.Save(ms, pimagemanagedataemployee.Image.RawFormat)
        Dim img As Byte()
        img = ms.ToArray
        DALEmployee.addupdateEmployeetodatabase("Updatedataemployee", "ទិន្នន័យត្រូវបានកែប្រែរួចរាល់!", txtidmanagedataemployee.Text, txtidcardmanagedataemployee.Text, txtkhmernamemanagedataemployee.Text, txtlatinnamemanagedataemployee.Text, txtnationmanagedataemployee.Text.ToString, txtnationalitymanagedataemployee.Text.ToString, cbogendermanagedataemployee.Text.ToString, dtpdobmanagedataemployee.Text.ToString, txtpobroadnomanagedataemployee.Text.ToString, txtpobhomnomanagedataemployee.Text.ToString, txtpobvillagemanagedataemployee.Text.ToString, txtpobcommunemanagedataemployee.Text.ToString, txtpobdistrictmanagedataemployee.Text.ToString, txtpobprovincemanagedataemployee.Text.ToString, txtphonenumbermanagedataemployee.Text.ToString, txtemailmanagedataemployee.Text.ToString, txtadnroadnomanagedataemployee.Text.ToString, txtadnhomenomanagedataemployee.Text.ToString, txtadnvillagemanagedataemployee.Text.ToString, txtadncommunemanagedataemployee.Text.ToString, txtadndistrictmanagedataemployee.Text.ToString, txtadnprovincemanagedataemployee.Text.ToString, img)
        DALStudent.adddatatermtodatabase("updatedataterm", txttermidmanagedataemployee, dtpstartworkmanagedataemployee.Text, "", "", "", "", "Active")
        DALEmployee.listallemployeeactive.Clear()
        DALEmployee.ShowdataactiveemployeeFromDatabase(dgvmanagedataemployee)
        Call clearmanagedataemployee()
        txtidmanagedataemployee.Clear()
    End Sub

    Private Sub btnpicturemanagedataemployee_Click(sender As Object, e As EventArgs) Handles btnpicturemanagedataemployee.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "choose image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            pimagemanagedataemployee.Image = Image.FromFile(opf.FileName)
        End If
        Dim ms As New MemoryStream
        pimagemanagedataemployee.Image.Save(ms, pimagemanagedataemployee.Image.RawFormat)
    End Sub

    Private Sub cbogendermanagedataemployee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbogendermanagedataemployee.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtdeletemanagedataemployee_Click(sender As Object, e As EventArgs) Handles txtdeletemanagedataemployee.Click
        Try
            If txtidmanagedataemployee.Text.Equals("") Then
                MessageBox.Show("សូមជ្រើសរើសទិន្នន័យដើម្បីធ្វើការលុប!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtidmanagedataemployee.Focus()
                Return
            End If
            DALEmployee.DeleteDataemployee("deletedataemployee", "Delete", txtidmanagedataemployee.Text)
            MessageBox.Show("ទិន្នន័យត្រូវបានលុបចេញពី Database!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clearmanagedataemployee()
            DALEmployee.ShowdataactiveemployeeFromDatabase(dgvmanagedataemployee)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtclosemanagedataemployee_Click(sender As Object, e As EventArgs) Handles txtclosemanagedataemployee.Click
        Call HidePanel()
        pbackgroundss.Show()
    End Sub

    Private Sub សសសបញចបករសកសToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles សសសបញចបករសកសToolStripMenuItem.Click
        Dim x As New Frmstudentgraduate
        x.ShowDialog()
    End Sub

    Private Sub គរបគរងទនននយគណនToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmmanageuseraccount.Click
        Dim x As New ManageUserAccount
        x.ShowDialog()
    End Sub

    Private Sub ទនននយគណនទងអសToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ទនននយគណនទងអសToolStripMenuItem.Click
        Dim frmau As New Frmalluseraccount
        frmau.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call clearpmanagedatastudent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call clearpaddstudent()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub cbopartstudymanagedatastudent_Click(sender As Object, e As EventArgs) Handles cbopartstudymanagedatastudent.Click
        DALSubject.listpartsubjectfromdatabase.Clear()
        DALSubject.FilldatatoCombobox(cbopartstudymanagedatastudent)
    End Sub

    Private Sub cbosubjectmanagedatastudent_Click(sender As Object, e As EventArgs) Handles cbosubjectmanagedatastudent.Click
        DALSubject.listsubjectfromdatabase.Clear()
        DALSchedule.FilldatasubjecttoCombobox(cbosubjectmanagedatastudent)
    End Sub

    Private Sub cbodaystudymanagedatastudent_Click(sender As Object, e As EventArgs) Handles cbodaystudymanagedatastudent.Click
        DALSchedule.listdayfromdatabase.Clear()
        DALSchedule.FilldatadaytoCombobox(cbodaystudymanagedatastudent)
    End Sub

    Private Sub cbotimenammanagedatastudent_Click(sender As Object, e As EventArgs) Handles cbotimenammanagedatastudent.Click
        DALSchedule.listtimenamefromdatabase.Clear()
        DALSchedule.FilldatatimenametoCombobox(cbotimestudymanagedatastudent)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub cbotimestudymanagedatastudent_Click(sender As Object, e As EventArgs) Handles cbotimestudymanagedatastudent.Click
        DALSchedule.listtimefromdatabase.Clear()
        DALSchedule.FilldatatimetoCombobox(cbotimestudymanagedatastudent)
    End Sub
End Class
