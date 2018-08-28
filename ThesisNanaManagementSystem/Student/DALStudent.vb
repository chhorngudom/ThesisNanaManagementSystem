Imports System.Data.SqlClient
Public Class DALStudent
    Public Shared cls As New ClsStudent
    Public Shared clt As New ClsTerm
    Public Shared clsd As New ClsDetailstudent
    Public Shared clatt As New ClsAttandant
    Public Shared clattd As New ClsAttDetail
    Public Shared clpm As New ClsPayment
    Public Shared clpmd As New ClspaymentDetail
    Public Shared clc As New ClsScore
    Public Shared clsscdetail As New Clsscoredetail
    Public Shared clssd As New ClsSchedule
    ' List get data active from database
    Public Shared liststudentfromdatabaseactive As New List(Of ClsSchedule)
    Public Shared listtermfromdatabaseactive As New List(Of ClsTerm)
    Public Shared listdetailstudentfromdatabaseactive As New List(Of ClsDetailstudent)
    Public Shared listattfromdatabaseactive As New List(Of ClsAttandant)
    Public Shared listattdetailfromdatabaseactive As New List(Of ClsAttDetail)
    Public Shared listpaymentfromdatabaseactive As New List(Of ClsPayment)
    Public Shared listpaymentdetailfromdatabaseaactive As New List(Of ClspaymentDetail)
    Public Shared listscorefromdatabaseactive As New List(Of ClsScore)
    Public Shared listscoredetailfromdatabaseactive As New List(Of Clsscoredetail)
    ' list get data delete from database
    Public Shared listgetalldatastudentdelete As New List(Of ClsSchedule)
    ' list get all data from database
    Public Shared listallstudentfromdatabase As New List(Of ClsStudent)
    Public Shared listalltermfromdatabase As New List(Of ClsTerm)
    Public Shared listalldetailstudentfromdatabase As New List(Of ClsDetailstudent)
    Public Shared listallattfromdatabase As New List(Of ClsAttandant)
    Public Shared listallattdetailfromdatabase As New List(Of ClsAttDetail)
    Public Shared listallpaymentfromdatabase As New List(Of ClsPayment)
    Public Shared listallpaymentdetailfromdatabase As New List(Of ClspaymentDetail)
    Public Shared listallscorefromdatabase As New List(Of ClsScore)
    Public Shared listallscoredetailfromdatabase As New List(Of Clsscoredetail)
    ' Execute with database
    Shared connection As New SqlConnection(ClsConnection.ConnectDb)
    Public Shared command As New SqlCommand
    Public Shared reader As SqlDataReader

    ' Add All Data from database to list
    Private Shared Sub AddallDatastudentFromDatabase(ByVal cls As ClsStudent)
        listallstudentfromdatabase.Add(cls)
    End Sub
    Private Shared Sub addalldatatermfromdatabasetolist(ByVal clt As ClsTerm)
        listalltermfromdatabase.Add(clt)
    End Sub
    Private Shared Sub addalldatadetailstudentfromdatabasetolist(ByVal clsd As ClsDetailstudent)
        listalldetailstudentfromdatabase.Add(clsd)
    End Sub
    Private Shared Sub addalldatatandantfromdatabasetolist(ByVal clsatt As ClsAttandant)
        listallattfromdatabase.Add(clsatt)
    End Sub
    Private Shared Sub addalldataattdetailfromdatabasetolist(ByVal clsd As ClsAttDetail)
        listallattdetailfromdatabase.Add(clsd)
    End Sub
    Private Shared Sub addalldatapaymentfromdatabasetolist(ByVal clsd As ClsPayment)
        listallpaymentfromdatabase.Add(clsd)
    End Sub
    Private Shared Sub addalldatapaymentdetailfromdatabasetolist(ByVal clsd As ClspaymentDetail)
        listallpaymentdetailfromdatabase.Add(clsd)
    End Sub
    Private Shared Sub addalldatascorefromdatabaseactivetolist(ByVal clsd As ClsScore)
        listallscorefromdatabase.Add(clsd)
    End Sub
    Private Shared Sub addalldatascoredetailfromdatabaseactivetolist(ByVal clsd As Clsscoredetail)
        listallscoredetailfromdatabase.Add(clsd)
    End Sub

    ' Add all data fromdatabase to list where Active
    Private Shared Sub adddatastudentfromdatabaseactive(ByVal cls As ClsSchedule)
        liststudentfromdatabaseactive.Add(cls)
    End Sub
    Private Shared Sub adddatatermfromdatabaseactivetolist(ByVal clt As ClsTerm)
        listtermfromdatabaseactive.Add(clt)
    End Sub
    Private Shared Sub addatadetaillstudentfromdatabaseactivetolist(ByVal clsd As ClsDetailstudent)
        listdetailstudentfromdatabaseactive.Add(clsd)
    End Sub
    Private Shared Sub addataaddtandantfromdatabaseactivetolist(ByVal clsatt As ClsAttandant)
        listattfromdatabaseactive.Add(clsatt)
    End Sub
    Private Shared Sub addataattdetailfromdatabaseactivetolist(ByVal clsd As ClsAttDetail)
        listattdetailfromdatabaseactive.Add(clsd)
    End Sub
    Private Shared Sub addatapaymentfromdatabaseactivetolist(ByVal clsd As ClsPayment)
        listpaymentfromdatabaseactive.Add(clsd)
    End Sub
    Private Shared Sub addatapaymentdetailfromdatabaseactivetolist(ByVal clsd As ClspaymentDetail)
        listpaymentdetailfromdatabaseaactive.Add(clsd)
    End Sub
    Private Shared Sub addatascorefromdatabaseactivetolist(ByVal clsd As ClsScore)
        listscorefromdatabaseactive.Add(clsd)
    End Sub
    Private Shared Sub addatascoredetailfromdatabaseactivetolist(ByVal clsd As Clsscoredetail)
        listscoredetailfromdatabaseactive.Add(clsd)
    End Sub
    Private Shared Sub adddatastudentdelete(ByVal clsd As ClsSchedule)
        listgetalldatastudentdelete.Add(clsd)
    End Sub
    Public Shared Sub SetIDStudent(ByVal t As TextBox)
        listallstudentfromdatabase.Clear()
        GetAllDatastudentFromDatabase()
        t.Text = "លរស" & listallstudentfromdatabase.Count + 1
    End Sub
    Public Shared Sub ShowalldatastudentFromDatabase(ByVal dgv As DataGridView)
        dgv.Rows.Clear()
        dgv.RowTemplate.Height = 50
        dgv.Columns(0).Width = 50
        GetDatastudentFromDatabaseActive()
        Dim i As Integer
        For i = 0 To DALStudent.liststudentfromdatabaseactive.Count - 1
            dgv.Rows.Add(liststudentfromdatabaseactive.Item(i).Image, liststudentfromdatabaseactive.Item(i).id, liststudentfromdatabaseactive.Item(i).idcard, liststudentfromdatabaseactive.Item(i).namekhmer, liststudentfromdatabaseactive.Item(i).namelatin, liststudentfromdatabaseactive.Item(i).Nation, liststudentfromdatabaseactive.Item(i).Nationalty, liststudentfromdatabaseactive.Item(i).gender, liststudentfromdatabaseactive.Item(i).dob, liststudentfromdatabaseactive.Item(i).roadnopob & "," & liststudentfromdatabaseactive.Item(i).homenopob & "," & liststudentfromdatabaseactive.Item(i).villagepob & "," & liststudentfromdatabaseactive.Item(i).communepob & "," & liststudentfromdatabaseactive.Item(i).Districtpob & "," & liststudentfromdatabaseactive.Item(i).provincepob, liststudentfromdatabaseactive.Item(i).phonenumber, liststudentfromdatabaseactive.Item(i).emailaddress, liststudentfromdatabaseactive.Item(i).roadnoadn & "," & liststudentfromdatabaseactive.Item(i).homenoadn & "," & liststudentfromdatabaseactive.Item(i).villageadn & "," & liststudentfromdatabaseactive.Item(i).communeadn & "," & liststudentfromdatabaseactive.Item(i).Districtadn & "," & liststudentfromdatabaseactive.Item(i).provinceadn, liststudentfromdatabaseactive.Item(i).dayid, liststudentfromdatabaseactive.Item(i).timenameid, liststudentfromdatabaseactive.Item(i).timeid, liststudentfromdatabaseactive.Item(i).desc, liststudentfromdatabaseactive.Item(i).subid, liststudentfromdatabaseactive.Item(i).Startdate)
        Next
    End Sub
    Public Shared Sub ShowalldatastudentFromDatabasedelete(ByVal dgv As DataGridView)
        dgv.Rows.Clear()
        dgv.RowTemplate.Height = 50
        dgv.Columns(0).Width = 50
        GetDatastudentFromDatabasedelete()
        Dim i As Integer
        For i = 0 To DALStudent.listgetalldatastudentdelete.Count - 1
            dgv.Rows.Add(listgetalldatastudentdelete.Item(i).Image, listgetalldatastudentdelete.Item(i).id, listgetalldatastudentdelete.Item(i).idcard, listgetalldatastudentdelete.Item(i).namekhmer, listgetalldatastudentdelete.Item(i).namelatin, listgetalldatastudentdelete.Item(i).Nation, listgetalldatastudentdelete.Item(i).Nationalty, listgetalldatastudentdelete.Item(i).gender, listgetalldatastudentdelete.Item(i).dob, listgetalldatastudentdelete.Item(i).roadnopob & "," & listgetalldatastudentdelete.Item(i).homenopob & "," & listgetalldatastudentdelete.Item(i).villagepob & "," & listgetalldatastudentdelete.Item(i).communepob & "," & listgetalldatastudentdelete.Item(i).Districtpob & "," & listgetalldatastudentdelete.Item(i).provincepob, listgetalldatastudentdelete.Item(i).phonenumber, listgetalldatastudentdelete.Item(i).emailaddress, listgetalldatastudentdelete.Item(i).roadnoadn & "," & listgetalldatastudentdelete.Item(i).homenoadn & "," & listgetalldatastudentdelete.Item(i).villageadn & "," & listgetalldatastudentdelete.Item(i).communeadn & "," & listgetalldatastudentdelete.Item(i).Districtadn & "," & listgetalldatastudentdelete.Item(i).provinceadn, listgetalldatastudentdelete.Item(i).dayid, listgetalldatastudentdelete.Item(i).timenameid, listgetalldatastudentdelete.Item(i).timeid, listgetalldatastudentdelete.Item(i).desc, listgetalldatastudentdelete.Item(i).subid, listgetalldatastudentdelete.Item(i).Startdate)
        Next
    End Sub
    ' This sub use for get data from database where Active
    Public Shared Sub GetDatastudentFromDatabaseActive()
        connection.Open()
        command = New SqlCommand("getalldatastudentactive", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clssd = New ClsSchedule
            clssd.id = reader.Item(0)
            clssd.idcard = reader.Item(1)
            clssd.namekhmer = reader.Item(2)
            clssd.namelatin = reader.Item(3)
            clssd.Nation = reader.Item(4)
            clssd.Nationalty = reader.Item(5)
            clssd.gender = reader.Item(6)
            clssd.dob = reader.Item(7)
            clssd.roadnopob = reader.Item(8)
            clssd.homenopob = reader.Item(9)
            clssd.villagepob = reader.Item(10)
            clssd.communepob = reader.Item(11)
            clssd.Districtpob = reader.Item(12)
            clssd.provincepob = reader.Item(13)
            clssd.phonenumber = reader.Item(14)
            clssd.emailaddress = reader.Item(15)
            clssd.roadnoadn = reader.Item(16)
            clssd.homenoadn = reader.Item(17)
            clssd.villageadn = reader.Item(18)
            clssd.communeadn = reader.Item(19)
            clssd.Districtadn = reader.Item(20)
            clssd.provinceadn = reader.Item(21)
            clssd.sdid = reader.Item(22)
            clssd.dayid = reader.Item(23) & " - " & reader.Item(24)
            clssd.timenameid = reader.Item(25)
            clssd.timeid = reader.Item(26) & " - " & reader.Item(27)
            clssd.desc = reader.Item(28)
            clssd.subid = reader.Item(29)
            clssd.Startdate = reader.Item(30)
            clssd.Image = reader.Item(31)
            adddatastudentfromdatabaseactive(clssd)
        End While
        connection.Close()
    End Sub
    Public Shared Sub GetDatastudentFromDatabasedelete()
        connection.Open()
        command = New SqlCommand("getdatastudentdelete", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clssd = New ClsSchedule
            clssd.id = reader.Item(0)
            clssd.idcard = reader.Item(1)
            clssd.namekhmer = reader.Item(2)
            clssd.namelatin = reader.Item(3)
            clssd.Nation = reader.Item(4)
            clssd.Nationalty = reader.Item(5)
            clssd.gender = reader.Item(6)
            clssd.dob = reader.Item(7)
            clssd.roadnopob = reader.Item(8)
            clssd.homenopob = reader.Item(9)
            clssd.villagepob = reader.Item(10)
            clssd.communepob = reader.Item(11)
            clssd.Districtpob = reader.Item(12)
            clssd.provincepob = reader.Item(13)
            clssd.phonenumber = reader.Item(14)
            clssd.emailaddress = reader.Item(15)
            clssd.roadnoadn = reader.Item(16)
            clssd.homenoadn = reader.Item(17)
            clssd.villageadn = reader.Item(18)
            clssd.communeadn = reader.Item(19)
            clssd.Districtadn = reader.Item(20)
            clssd.provinceadn = reader.Item(21)
            clssd.sdid = reader.Item(22)
            clssd.dayid = reader.Item(23) & " - " & reader.Item(24)
            clssd.timenameid = reader.Item(25)
            clssd.timeid = reader.Item(26) & " - " & reader.Item(27)
            clssd.desc = reader.Item(28)
            clssd.subid = reader.Item(29)
            clssd.Startdate = reader.Item(30)
            clssd.Image = reader.Item(31)
            adddatastudentdelete(clssd)
        End While
        connection.Close()
    End Sub
    ' get all data from database to list
    Public Shared Sub getalldatatermfromdatabase()
        connection.Open()
        command = New SqlCommand("getalldataterm", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clt = New ClsTerm
            clt.termid = reader.Item(0)
            clt.startdate = reader.Item(1)
            clt.enddate = reader.Item(2)
            clt.description = reader.Item(3)
            clt.status = reader.Item(4)
            addalldatatermfromdatabasetolist(clt)
        End While
        connection.Close()
    End Sub
    Public Shared Sub getalldatadetailstudent()
        connection.Open()
        command = New SqlCommand("getalldatadetailstudent", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clsd = New ClsDetailstudent
            clsd.detailstudentid = reader.Item(0)
            addalldatadetailstudentfromdatabasetolist(clsd)
        End While
        connection.Close()
    End Sub
    Public Shared Sub DeleteRestoredataStudent(ByVal pro As String, ByVal status As String, ByVal txtid As String)
        Try
            connection.Open()
            command = New SqlCommand(pro, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status
            command.ExecuteNonQuery()
            connection.Close()
            ' listdayfromdatabase.Clear()
            liststudentfromdatabaseactive.Clear()

        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    Public Shared Sub getalldataattandant()
        connection.Open()
        command = New SqlCommand("getalldataattandant", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clatt = New ClsAttandant
            clatt.atttid = reader.Item(0)
            addalldatatandantfromdatabasetolist(clatt)
        End While
        connection.Close()
    End Sub
    Public Shared Sub getalldatadetailattandant()
        connection.Open()
        command = New SqlCommand("getalldatadetailattandant", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clattd = New ClsAttDetail
            clattd.attid = reader.Item(0)
            addalldataattdetailfromdatabasetolist(clattd)
        End While
        connection.Close()
    End Sub
    Public Shared Sub getalldatascore()
        connection.Open()
        command = New SqlCommand("getalldatascore", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clc = New ClsScore
            clc.scoreid = reader.Item(0)
            addalldatascorefromdatabaseactivetolist(clc)
        End While
        connection.Close()
    End Sub
    Public Shared Sub getalldatadetailscore()
        connection.Open()
        command = New SqlCommand("getalldatadetailscore", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clsscdetail = New Clsscoredetail
            clsscdetail.scoredetailid = reader.Item(0)
            addalldatascoredetailfromdatabaseactivetolist(clsscdetail)
        End While
        connection.Close()
    End Sub
    Public Shared Sub getalldatapayment()
        connection.Open()
        command = New SqlCommand("getalldatapayment", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clpm = New ClsPayment
            clpm.paymentid = reader.Item(0)
            addalldatapaymentfromdatabasetolist(clpm)
        End While
        connection.Close()
    End Sub
    Public Shared Sub getalldatadetailpayment()
        connection.Open()
        command = New SqlCommand("getalldatadetailpayment", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clpmd = New ClspaymentDetail
            clpmd.paymentdetailid = reader.Item(0)
            addalldatapaymentdetailfromdatabasetolist(clpmd)
        End While
        connection.Close()
    End Sub
    Public Shared Sub GetAllDatastudentFromDatabase()
        connection.Open()
        command = New SqlCommand("getalldatastudent", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            cls = New ClsStudent
            cls.id = reader.Item(0)
            cls.idcard = reader.Item(1)
            'cls.namekhmer = reader.Item(2)
            'cls.namelatin = reader.Item(3)
            'cls.gender = reader.Item(4)
            'cls.dob = reader.Item(5)
            'cls.villagepob = reader.Item(6)
            'cls.communepob = reader.Item(7)
            'cls.Districtpob = reader.Item(8)
            'cls.villagepob = reader.Item(9)
            'cls.phonenumber = reader.Item(10)
            'cls.emailaddress = reader.Item(11)
            'cls.villageadn = reader.Item(12)
            'cls.communeadn = reader.Item(13)
            'cls.Districtadn = reader.Item(14)
            'cls.villageadn = reader.Item(15)
            AddallDatastudentFromDatabase(cls)
        End While
        connection.Close()
    End Sub
    Public Shared Sub ShowdatastudentFromDatabase(ByVal dgv As DataGridView)
        dgv.Rows.Clear()
        GetDatastudentFromDatabaseActive()
        Dim i As Integer
        For i = 0 To liststudentfromdatabaseactive.Count - 1
            dgv.Rows.Add(liststudentfromdatabaseactive.Item(i).id, liststudentfromdatabaseactive.Item(i).idcard, liststudentfromdatabaseactive.Item(i).namekhmer, liststudentfromdatabaseactive.Item(i).namelatin, liststudentfromdatabaseactive.Item(i).gender, liststudentfromdatabaseactive.Item(i).dob, liststudentfromdatabaseactive.Item(i).villagepob, liststudentfromdatabaseactive.Item(i).communepob, liststudentfromdatabaseactive.Item(i).Districtpob, liststudentfromdatabaseactive.Item(i).provincepob, liststudentfromdatabaseactive.Item(i).phonenumber, liststudentfromdatabaseactive.Item(i).emailaddress, liststudentfromdatabaseactive.Item(i).villageadn, liststudentfromdatabaseactive.Item(i).communeadn, liststudentfromdatabaseactive.Item(i).Districtadn, liststudentfromdatabaseactive.Item(i).provinceadn)
        Next
    End Sub
    Public Shared Sub adddatadetailstudent(ByVal sql As String, ByVal detailstudentid As String, ByVal sdid As String, ByVal stuid As String, ByVal termid As String, ByVal attid As String, ByVal scoreid As String, ByVal paymentid As String, ByVal des As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@detailstudentid", SqlDbType.NVarChar).Value = detailstudentid
            command.Parameters.Add("@sdid", SqlDbType.NVarChar).Value = sdid
            command.Parameters.Add("@stuid", SqlDbType.NVarChar).Value = stuid
            command.Parameters.Add("@termid", SqlDbType.NVarChar).Value = termid
            command.Parameters.Add("@attid", SqlDbType.NVarChar).Value = attid
            command.Parameters.Add("@scoreid", SqlDbType.NVarChar).Value = scoreid
            command.Parameters.Add("@paymentid", SqlDbType.NVarChar).Value = paymentid
            command.Parameters.Add("@description", SqlDbType.NVarChar).Value = des
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Active"
            command.ExecuteNonQuery()
            connection.Close()
            ' GetDatatermFromDatabaseActive()
            listalldetailstudentfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Shared Sub adddatadetailattandant(ByVal sql As String, ByVal attdetail As String, ByVal attid As String, ByVal attandant As String, ByVal dates As String, ByVal desc As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@attdetailid", SqlDbType.NVarChar).Value = attdetail
            command.Parameters.Add("@attid", SqlDbType.NVarChar).Value = attid
            command.Parameters.Add("@attandant", SqlDbType.NVarChar).Value = attandant
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = dates
            command.Parameters.Add("@Desc", SqlDbType.NVarChar).Value = desc
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Active"
            command.ExecuteNonQuery()
            connection.Close()
            ' GetDatatermFromDatabaseActive()
            listallattdetailfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Shared Sub adddatadetailscore(ByVal sql As String, ByVal detailscoreid As String, ByVal scoreid As String, ByVal typeexam As String, ByVal score As Double, ByVal dates As String, ByVal desc As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@scoredetailid", SqlDbType.NVarChar).Value = detailscoreid
            command.Parameters.Add("@scoreid", SqlDbType.NVarChar).Value = scoreid
            command.Parameters.Add("@typeexam", SqlDbType.NVarChar).Value = typeexam
            command.Parameters.Add("@score", SqlDbType.Float).Value = score
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = dates
            command.Parameters.Add("@Desc", SqlDbType.NVarChar).Value = desc
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Active"
            command.ExecuteNonQuery()
            connection.Close()
            ' GetDatatermFromDatabaseActive()
            listallscoredetailfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Shared Sub adddatadetailpayment(ByVal sql As String, ByVal detailpaymentid As String, ByVal paymentid As String, ByVal price As Double, ByVal feeprice As String, ByVal remainfee As String, ByVal dates As String, ByVal desc As String, ByVal empid As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@detailpaymentid", SqlDbType.NVarChar).Value = detailpaymentid
            command.Parameters.Add("@paymentid", SqlDbType.NVarChar).Value = paymentid
            command.Parameters.Add("@price", SqlDbType.Float).Value = price
            command.Parameters.Add("@feeprice", SqlDbType.Float).Value = feeprice
            command.Parameters.Add("@remainfee", SqlDbType.Float).Value = remainfee
            command.Parameters.Add("@datefee", SqlDbType.NVarChar).Value = dates
            command.Parameters.Add("@Desc", SqlDbType.NVarChar).Value = desc
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Active"
            command.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = empid
            command.ExecuteNonQuery()
            connection.Close()
            ' GetDatatermFromDatabaseActive()
            listallscoredetailfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Shared Sub addupdatedatapayment(ByVal sql As String, ByVal paymentid As String, ByVal desc As String, ByVal status As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@paymentid", SqlDbType.NVarChar).Value = paymentid
            command.Parameters.Add("@Desc", SqlDbType.NVarChar).Value = desc
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Active"
            command.ExecuteNonQuery()
            connection.Close()
            ' GetDatatermFromDatabaseActive()
            listallpaymentfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Shared Sub addupdatedataattandant(ByVal sql As String, ByVal att As String, ByVal desc As String, ByVal status As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@attid", SqlDbType.NVarChar).Value = att
            command.Parameters.Add("@Desc", SqlDbType.NVarChar).Value = desc
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Active"
            command.ExecuteNonQuery()
            connection.Close()
            ' GetDatatermFromDatabaseActive()
            listallattfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Shared Sub addupdatedatascore(ByVal sql As String, ByVal scoreid As String, ByVal desc As String, ByVal status As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@scoreid", SqlDbType.NVarChar).Value = scoreid
            command.Parameters.Add("@Desc", SqlDbType.NVarChar).Value = desc
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Active"
            command.ExecuteNonQuery()
            connection.Close()
            ' GetDatatermFromDatabaseActive()
            listallscorefromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Shared Sub adddatatermtodatabase(ByVal sql As String, ByVal termid As String, ByVal startdate As String, ByVal enddate As String, ByVal certificate As String, ByVal dategetcertificate As String, ByVal desc As String, ByVal status As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = termid
            command.Parameters.Add("@startdate", SqlDbType.NVarChar).Value = startdate
            command.Parameters.Add("@enddate", SqlDbType.NVarChar).Value = enddate
            command.Parameters.Add("@certificate", SqlDbType.NVarChar).Value = certificate
            command.Parameters.Add("@dategetcertificate", SqlDbType.NVarChar).Value = dategetcertificate
            command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = desc
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status
            command.ExecuteNonQuery()
            ' MessageBox.Show(Message, "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            ' GetDatatermFromDatabaseActive()
            listalltermfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Shared Sub addupdatestudenttodatabase(ByVal sql As String, ByVal message As String, ByVal txtid As String, ByVal txtidcard As String, ByVal txtkhmername As String, ByVal latinname As String, ByVal nation As String, ByVal nationality As String, ByVal gender As String, ByVal dob As String, ByVal phonenumber As String, ByVal emaill As String, ByVal roadpob As String, ByVal homepob As String, ByVal villagepob As String, ByVal communepob As String, ByVal districtpob As String, ByVal provincepob As String, ByVal roadadn As String, ByVal homeadn As String, ByVal villageadn As String, ByVal communeadn As String, ByVal districtadn As String, ByVal provinceadn As String, ByVal image As Byte())
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@stuid", SqlDbType.NVarChar).Value = txtid
            command.Parameters.Add("@idcard", SqlDbType.NVarChar).Value = txtidcard
            command.Parameters.Add("@khmername", SqlDbType.NVarChar).Value = txtkhmername
            command.Parameters.Add("@latinname", SqlDbType.NVarChar).Value = latinname
            command.Parameters.Add("@nation", SqlDbType.NVarChar).Value = nation
            command.Parameters.Add("@nationality", SqlDbType.NVarChar).Value = nationality
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender
            command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob
            command.Parameters.Add("@phonenumber", SqlDbType.NVarChar).Value = phonenumber
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = emaill
            command.Parameters.Add("@roadnopob", SqlDbType.NVarChar).Value = roadpob
            command.Parameters.Add("@homenopob", SqlDbType.NVarChar).Value = homepob
            command.Parameters.Add("@villagepob", SqlDbType.NVarChar).Value = villagepob
            command.Parameters.Add("@communepob", SqlDbType.NVarChar).Value = communepob
            command.Parameters.Add("@districtpob", SqlDbType.NVarChar).Value = districtpob
            command.Parameters.Add("@provincepob", SqlDbType.NVarChar).Value = provincepob
            command.Parameters.Add("@roadnoadn", SqlDbType.NVarChar).Value = roadadn
            command.Parameters.Add("@homenoadn", SqlDbType.VarChar).Value = homeadn
            command.Parameters.Add("@villageadn", SqlDbType.NVarChar).Value = villageadn
            command.Parameters.Add("@communeadn", SqlDbType.NVarChar).Value = communeadn
            command.Parameters.Add("@districtadn", SqlDbType.NVarChar).Value = districtadn
            command.Parameters.Add("@provinceadn", SqlDbType.NVarChar).Value = provincepob
            command.Parameters.Add("@image", SqlDbType.Image).Value = image
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Active"
            command.ExecuteNonQuery()
            MessageBox.Show(message, "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            GetDatastudentFromDatabaseActive()
            liststudentfromdatabaseactive.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
End Class
