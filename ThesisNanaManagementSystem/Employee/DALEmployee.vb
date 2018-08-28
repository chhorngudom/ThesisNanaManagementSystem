Imports System.Data.SqlClient
Imports System.IO
Public Class DALEmployee
    Public Shared cle As New ClsEmploye
    Public Shared cls As New ClsSalary
    Public Shared clsds As New ClsDetailSalary
    Public Shared clssw As New ClsStopwork
    Public Shared clsdemp As New ClsDetailEmployee
    ' list all date active
    Public Shared listallemployeeactive As New List(Of ClsEmploye)
    Public Shared listallsalarydetailactive As New List(Of ClsDetailSalary)
    Public Shared listallstopworkactive As New List(Of ClsStopwork)

    ' list all data delete
    Public Shared listallemployeedelete As New List(Of ClsEmploye)
    Public Shared listalldatastopworkDelete As New List(Of ClsStopwork)

    ' list all data
    Public Shared listallemployee As New List(Of ClsEmploye)
    Public Shared listallsalary As New List(Of ClsSalary)
    Public Shared listalldetailsalary As New List(Of ClsDetailSalary)
    Public Shared listallstopwork As New List(Of ClsStopwork)
    Public Shared listalldetailemployee As New List(Of ClsDetailEmployee)

    ' Access database
    Shared connection As New SqlConnection(ClsConnection.ConnectDb)
    Public Shared command As New SqlCommand
    Public Shared reader As SqlDataReader

    ' add data active from database to list
    Private Shared Sub AddDataemployeeactiveFromDatabasetolist(ByVal cle As ClsEmploye)
        listallemployeeactive.Add(cle)
    End Sub
    Private Shared Sub AddDatasalarydetialactiveFromDatabasetolist(ByVal cls As ClsDetailSalary)
        listallsalarydetailactive.Add(cls)
    End Sub

    Private Shared Sub AddDatastopworkavtivefromdatabasetolist(ByVal clsw As ClsStopwork)
        listallstopworkactive.Add(clsw)
    End Sub

    ' add data delete from database to list
    Private Shared Sub AddDatadeleteFromDatabasetolist(ByVal cle As ClsEmploye)
        listallemployeedelete.Add(cle)
    End Sub
    Private Shared Sub Adddatadeletestopworkdeletetolist(ByVal clssw As ClsStopwork)
        listalldatastopworkDelete.Add(clssw)
    End Sub

    ' add all data from database to list
    Private Shared Sub AddallDataemployeeFromDatabasetolist(ByVal cle As ClsEmploye)
        listallemployee.Add(cle)
    End Sub
    Private Shared Sub AddallDataSalaryFromDatabasetolist(ByVal cls As ClsSalary)
        listallsalary.Add(cls)
    End Sub
    Private Shared Sub AddallDataDetailSalaryFromDatabasetolist(ByVal clsds As ClsDetailSalary)
        listalldetailsalary.Add(clsds)
    End Sub
    Private Shared Sub AddallDataDetailemployeeFromDatabasetolist(ByVal clse As ClsDetailEmployee)
        listalldetailemployee.Add(clse)
    End Sub
    Private Shared Sub AddallDataStopworkFromDatabasetolist(ByVal cls As ClsStopwork)
        listallstopwork.Add(cls)
    End Sub
    ' Add data to datagridview
    Public Shared Sub ShowdataactiveemployeeFromDatabase(ByVal dgv As DataGridView)
        '  listallemployeeactive.Clear()
        dgv.Rows.Clear()
        dgv.RowTemplate.Height = 50
        dgv.Columns(0).Width = 50
        GetAllDataEmployeeActiveFromDatabase()
        Dim i As Integer
        For i = 0 To listallemployeeactive.Count - 1
            dgv.Rows.Add(listallemployeeactive.Item(i).Image, listallemployeeactive.Item(i).ID, listallemployeeactive.Item(i).IDcard, listallemployeeactive.Item(i).Khmername, listallemployeeactive.Item(i).Latinname, listallemployeeactive.Item(i).Nation, listallemployeeactive.Item(i).Nationality, listallemployeeactive.Item(i).Gender, listallemployeeactive.Item(i).DOB, listallemployeeactive.Item(i).Pobroadno & "," & listallemployeeactive.Item(i).Pobhomeno & "," & listallemployeeactive.Item(i).Pobvillage & "," & listallemployeeactive.Item(i).Pobcommube & "," & listallemployeeactive.Item(i).Pobdistrict & "," & listallemployeeactive.Item(i).PobProvince, listallemployeeactive.Item(i).PhoneNumber, listallemployeeactive.Item(i).Emailaddress, listallemployeeactive.Item(i).Adnroadno & "," & listallemployeeactive.Item(i).Adnhomeno & "," & listallemployeeactive.Item(i).Adnvillage & "," & listallemployeeactive.Item(i).Adncommune & "," & listallemployeeactive.Item(i).Adndistrict & "," & listallemployeeactive.Item(i).Adnprovince, listallemployeeactive.Item(i).startwork)
        Next
    End Sub
    Public Shared Sub ShowdatastopworkFromDatabase(ByVal dgv As DataGridView, ByVal pro As String)
        '  listallemployeeactive.Clear()
        dgv.Rows.Clear()
        dgv.RowTemplate.Height = 50
        dgv.Columns(0).Width = 50
        getalldatastopworkfromdatabase(pro)
        Dim i As Integer
        For i = 0 To listallstopwork.Count - 1
            dgv.Rows.Add(listallstopwork.Item(i).Image, listallstopwork.Item(i).ID, listallstopwork.Item(i).IDcard, listallstopwork.Item(i).Khmername, listallstopwork.Item(i).Nation, listallstopwork.Item(i).Gender, listallstopwork.Item(i).DOB, listallstopwork.Item(i).PhoneNumber, listallstopwork.Item(i).Emailaddress, listallstopwork.Item(i).Startworksw, listallstopwork.Item(i).Stopwork, listallstopwork.Item(i).Certificate, listallstopwork.Item(i).Dateget, listallstopwork.Item(i).Descriptionsw)
        Next
    End Sub
    Public Shared Sub ShowdatastopworkdeleteFromDatabase(ByVal dgv As DataGridView)
        '  listallemployeeactive.Clear()
        dgv.Rows.Clear()
        dgv.RowTemplate.Height = 50
        dgv.Columns(0).Width = 50
        getalldatastopworkdeletefromdatabase()
        Dim i As Integer
        For i = 0 To listalldatastopworkDelete.Count - 1
            dgv.Rows.Add(listalldatastopworkDelete.Item(i).Image, listalldatastopworkDelete.Item(i).ID, listalldatastopworkDelete.Item(i).IDcard, listalldatastopworkDelete.Item(i).Khmername, listalldatastopworkDelete.Item(i).Nation, listalldatastopworkDelete.Item(i).Gender, listalldatastopworkDelete.Item(i).DOB, listalldatastopworkDelete.Item(i).PhoneNumber, listalldatastopworkDelete.Item(i).Emailaddress, listalldatastopworkDelete.Item(i).Startworksw, listalldatastopworkDelete.Item(i).Stopwork, listalldatastopworkDelete.Item(i).Certificate, listalldatastopworkDelete.Item(i).Dateget, listalldatastopworkDelete.Item(i).Descriptionsw)
        Next
    End Sub
    Public Shared Sub ShowtotalsalaryFromDatabase(ByVal dgv As DataGridView)
        '  listallemployeeactive.Clear()
        dgv.Rows.Clear()
        dgv.RowTemplate.Height = 50
        dgv.Columns(0).Width = 50
        getallSalaryfromdatabase()
        Dim i As Integer
        For i = 0 To listallsalary.Count - 1
            dgv.Rows.Add(listallsalary.Item(i).Image, listallsalary.Item(i).ID, listallsalary.Item(i).IDcard, listallsalary.Item(i).Khmername, listallsalary.Item(i).Latinname, listallsalary.Item(i).Nation, listallsalary.Item(i).Gender, listallsalary.Item(i).DOB, listallsalary.Item(i).startwork, listallsalary.Item(i).totalsalary, listallsalary.Item(i).Descriptions)
        Next
    End Sub
    Public Shared Sub ShowdatadetailsalaryFromDatabase(ByVal dgv As DataGridView, ByVal txtsalaryid As String)
        '  listallemployeeactive.Clear()
        dgv.Rows.Clear()
        dgv.RowTemplate.Height = 50
        dgv.Columns(0).Width = 50
        getallDetailSalaryfromdatabase()
        Dim i As Integer
        For i = 0 To listalldetailsalary.Count - 1
            If (DALEmployee.listalldetailsalary.Item(i).srid.ToUpper.Contains(txtsalaryid.ToUpper)) Then
                dgv.Rows.Add(listalldetailsalary.Item(i).Image, listalldetailsalary.Item(i).ID, listalldetailsalary.Item(i).IDcard, listalldetailsalary.Item(i).Khmername, listalldetailsalary.Item(i).Nation, listalldetailsalary.Item(i).Gender, listalldetailsalary.Item(i).DOB, listalldetailsalary.Item(i).PhoneNumber, listalldetailsalary.Item(i).Emailaddress, listalldetailsalary.Item(i).startwork, listalldetailsalary.Item(i).Amount, listalldetailsalary.Item(i).dategetsalary, listalldetailsalary.Item(i).Descriptiondts)
            End If
        Next
    End Sub

    ' Get all data from database
    Public Shared Sub getallSalaryfromdatabase()
        connection.Open()
        command = New SqlCommand("getTotalsalary", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            cls = New ClsSalary
            cls.ID = reader.Item(0)
            cls.IDcard = reader.Item(1)
            cls.Khmername = reader.Item(2)
            cls.Latinname = reader.Item(3)
            cls.Nation = reader.Item(4)
            cls.Gender = reader.Item(5)
            cls.DOB = reader.Item(6)
            cls.startwork = reader.Item(7)
            cls.totalsalary = reader.Item(8)
            cls.Descriptions = reader.Item(9)
            cls.Image = reader.Item(10)
            cls.Srid = reader.Item(11)
            AddallDataSalaryFromDatabasetolist(cls)
        End While
        connection.Close()
    End Sub

    Public Shared Sub getallDetailSalaryfromdatabase()
        connection.Open()
        command = New SqlCommand("getdatadetailsalary", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clsds = New ClsDetailSalary
            clsds.ID = reader.Item(0)
            clsds.IDcard = reader.Item(1)
            clsds.Khmername = reader.Item(2)
            clsds.Nation = reader.Item(3)
            clsds.Gender = reader.Item(4)
            clsds.DOB = reader.Item(5)
            clsds.PhoneNumber = reader.Item(6)
            clsds.Emailaddress = reader.Item(7)
            clsds.startwork = reader.Item(8)
            clsds.Amount = reader.Item(9)
            clsds.dategetsalary = reader.Item(10)
            clsds.Descriptiondts = reader.Item(11)
            clsds.srid = reader.Item(12)
            clsds.Image = reader.Item(13)
            clsds.DetailSalaryID = reader.Item(14)
            AddallDataDetailSalaryFromDatabasetolist(clsds)
        End While
        connection.Close()
    End Sub

    Public Shared Sub getallDetailemployeefromdatabase()
        connection.Open()
        command = New SqlCommand("getalldatadetailemployee", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clsdemp = New ClsDetailEmployee
            clsdemp.Dtempid = reader.Item(0)
            clsdemp.empid = reader.Item(1)
            AddallDataDetailemployeeFromDatabasetolist(clsdemp)
        End While
        connection.Close()
    End Sub

    Public Shared Sub getalldatastopworkfromdatabase(ByVal pro As String)
        connection.Open()
        command = New SqlCommand(pro, connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clssw = New ClsStopwork
            clssw.StopworkId = reader.Item(0)
            clssw.ID = reader.Item(1)
            clssw.IDcard = reader.Item(2)
            clssw.Khmername = reader.Item(3)
            clssw.Nation = reader.Item(4)
            clssw.Gender = reader.Item(5)
            clssw.DOB = reader.Item(6)
            clssw.PhoneNumber = reader.Item(7)
            clssw.Emailaddress = reader.Item(8)
            clssw.Startworksw = reader.Item(9)
            clssw.Stopwork = reader.Item(10)
            clssw.Certificate = reader.Item(11)
            clssw.Dateget = reader.Item(12)
            clssw.Descriptionsw = reader.Item(13)
            clssw.Image = reader.Item(14)
            AddallDataStopworkFromDatabasetolist(clssw)
        End While
        connection.Close()
    End Sub
    Public Shared Sub getalldatastopworkdeletefromdatabase()
        connection.Open()
        command = New SqlCommand("getdatastopworkdelete", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            clssw = New ClsStopwork
            clssw.StopworkId = reader.Item(0)
            clssw.ID = reader.Item(1)
            clssw.IDcard = reader.Item(2)
            clssw.Khmername = reader.Item(3)
            clssw.Nation = reader.Item(4)
            clssw.Gender = reader.Item(5)
            clssw.DOB = reader.Item(6)
            clssw.PhoneNumber = reader.Item(7)
            clssw.Emailaddress = reader.Item(8)
            clssw.Startworksw = reader.Item(9)
            clssw.Stopwork = reader.Item(10)
            clssw.Certificate = reader.Item(11)
            clssw.Dateget = reader.Item(12)
            clssw.Descriptionsw = reader.Item(13)
            clssw.Image = reader.Item(14)
            Adddatadeletestopworkdeletetolist(clssw)
        End While
        connection.Close()
    End Sub
    Public Shared Sub GetAllDataEmployeeActiveFromDatabase()
        connection.Open()
        command = New SqlCommand("GetalldataemployeeActive", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            cle = New ClsEmploye
            cle.ID = reader.Item(0)
            cle.IDcard = reader.Item(1)
            cle.Khmername = reader.Item(2)
            cle.Latinname = reader.Item(3)
            cle.Nation = reader.Item(4)
            cle.Nationality = reader.Item(5)
            cle.Gender = reader.Item(6)
            cle.DOB = reader.Item(7)
            cle.Pobroadno = reader.Item(8)
            cle.Pobhomeno = reader.Item(9)
            cle.Pobvillage = reader.Item(10)
            cle.Pobcommube = reader.Item(11)
            cle.Pobdistrict = reader.Item(12)
            cle.PobProvince = reader.Item(13)
            cle.PhoneNumber = reader.Item(14)
            cle.Emailaddress = reader.Item(15)
            cle.Adnroadno = reader.Item(16)
            cle.Adnhomeno = reader.Item(17)
            cle.Adnvillage = reader.Item(18)
            cle.Adncommune = reader.Item(19)
            cle.Adndistrict = reader.Item(20)
            cle.Adnprovince = reader.Item(21)
            cle.Termid = reader.Item(22)
            cle.startwork = reader.Item(23)
            cle.Image = reader.Item(24)
            AddDataemployeeactiveFromDatabasetolist(cle)
        End While
        connection.Close()
    End Sub
    Public Shared Sub GetAllDataEmployeeFromDatabase()
        connection.Open()
        command = New SqlCommand("Getalldataemployee", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            cle = New ClsEmploye
            cle.ID = reader.Item(0)
            cle.IDcard = reader.Item(1)
            cle.Khmername = reader.Item(2)
            cle.Latinname = reader.Item(3)
            cle.Nation = reader.Item(4)
            cle.Nationality = reader.Item(5)
            cle.Gender = reader.Item(6)
            cle.DOB = reader.Item(7)
            cle.Pobroadno = reader.Item(8)
            cle.Pobhomeno = reader.Item(9)
            cle.Pobvillage = reader.Item(10)
            cle.Pobcommube = reader.Item(11)
            cle.Pobdistrict = reader.Item(12)
            cle.PobProvince = reader.Item(13)
            cle.PhoneNumber = reader.Item(14)
            cle.Emailaddress = reader.Item(15)
            cle.Adnroadno = reader.Item(16)
            cle.Adnhomeno = reader.Item(17)
            cle.Adnvillage = reader.Item(18)
            cle.Adncommune = reader.Item(19)
            cle.Adndistrict = reader.Item(20)
            cle.Adnprovince = reader.Item(21)
            cle.startwork = reader.Item(22)
            'cle.Description = reader.Item(26)
            cle.Image = reader.Item(23)
            AddallDataemployeeFromDatabasetolist(cle)
        End While
        connection.Close()
    End Sub
    ' Sub procedure delete data from database
    Public Shared Sub DeleteDataemployee(ByVal pro As String, ByVal status As String, ByVal txtid As String)
        Try
            connection.Open()
            command = New SqlCommand(pro, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status
            command.ExecuteNonQuery()

            connection.Close()
            ' listdayfromdatabase.Clear()
            GetAllDataEmployeeActiveFromDatabase()
            listallemployeeactive.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    ' Sub procedure add or update data in database
    Public Shared Sub addUpdateDetailemployeetodatabase(ByVal sql As String, ByVal dtempid As String, ByVal termid As String, ByVal empid As String, ByVal srid As String, ByVal desc As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@dtempid", SqlDbType.NVarChar).Value = dtempid
            command.Parameters.Add("termid", SqlDbType.NVarChar).Value = termid
            command.Parameters.Add("@empid", SqlDbType.NVarChar).Value = empid
            command.Parameters.Add("@srid", SqlDbType.NVarChar).Value = srid
            command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = desc
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Active"
            command.ExecuteNonQuery()
            'MessageBox.Show(Message,"ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            ' GetDatatermFromDatabaseActive()
            ' listalltermfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Shared Sub addUpdatedetailsalarytpdatabase(ByVal sql As String, ByVal dtsrid As String, ByVal srid As String, ByVal amount As Double, ByVal dates As String, ByVal desc As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@detailsrid", SqlDbType.NVarChar).Value = dtsrid
            command.Parameters.Add("@srid", SqlDbType.NVarChar).Value = srid
            command.Parameters.Add("@amount", SqlDbType.Float).Value = amount
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = dates
            command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = desc
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Active"
            command.ExecuteNonQuery()
            ' MessageBox.Show(Message, "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            ' GetDatatermFromDatabaseActive()
            ' listalltermfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Shared Sub addUpdatesalarytodatabase(ByVal sql As String, ByVal srid As String, ByVal desc As String, ByVal status As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@srid", SqlDbType.NVarChar).Value = srid
            command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = desc
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Active"
            command.ExecuteNonQuery()
            ' MessageBox.Show(Message, "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            ' GetDatatermFromDatabaseActive()
            ' listalltermfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Shared Sub addupdateEmployeetodatabase(ByVal sql As String, ByVal message As String, ByVal txtid As String, ByVal txtidcard As String, ByVal txtkhmername As String, ByVal latinname As String, ByVal nation As String, ByVal nationality As String, ByVal gender As String, ByVal dob As String, ByVal roadpob As String, ByVal homepob As String, ByVal villagepob As String, ByVal communepob As String, ByVal districtpob As String, ByVal provincepob As String, ByVal phonenumber As String, ByVal emaill As String, ByVal roadadn As String, ByVal homeadn As String, ByVal villageadn As String, ByVal communeadn As String, ByVal districtadn As String, ByVal provinceadn As String, ByVal image As Byte())
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@empid", SqlDbType.NVarChar).Value = txtid
            command.Parameters.Add("@idcard", SqlDbType.NVarChar).Value = txtidcard
            command.Parameters.Add("@khmername", SqlDbType.NVarChar).Value = txtkhmername
            command.Parameters.Add("@latinname", SqlDbType.NVarChar).Value = latinname
            command.Parameters.Add("@nation", SqlDbType.NVarChar).Value = nation
            command.Parameters.Add("@nationality", SqlDbType.NVarChar).Value = nationality
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender
            command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob
            command.Parameters.Add("@roadnopob", SqlDbType.NVarChar).Value = roadpob
            command.Parameters.Add("@homenopob", SqlDbType.NVarChar).Value = homepob
            command.Parameters.Add("@villagepob", SqlDbType.NVarChar).Value = villagepob
            command.Parameters.Add("@communepob", SqlDbType.NVarChar).Value = communepob
            command.Parameters.Add("@districtpob", SqlDbType.NVarChar).Value = districtpob
            command.Parameters.Add("@provincepob", SqlDbType.NVarChar).Value = provincepob
            command.Parameters.Add("@phonenumber", SqlDbType.NVarChar).Value = phonenumber
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = emaill
            command.Parameters.Add("@roadnoadn", SqlDbType.NVarChar).Value = roadadn
            command.Parameters.Add("@homenoadn", SqlDbType.VarChar).Value = homeadn
            command.Parameters.Add("@villageadn", SqlDbType.NVarChar).Value = villageadn
            command.Parameters.Add("@communeadn", SqlDbType.NVarChar).Value = communeadn
            command.Parameters.Add("@districtadn", SqlDbType.NVarChar).Value = districtadn
            command.Parameters.Add("@provinceadn", SqlDbType.NVarChar).Value = provinceadn
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Active"
            command.Parameters.Add("@image", SqlDbType.Image).Value = image
            command.ExecuteNonQuery()
            MessageBox.Show(message, "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            'GetDatastudentFromDatabase()
            'liststudentfromdatabaseactive.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
End Class
