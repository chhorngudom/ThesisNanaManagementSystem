Imports System.Data.SqlClient
Imports System.IO
Public Class DALSchedule
    Public Shared cs As New Clsdaystudy
    Public Shared ctn As New ClsTimeName
    Public Shared ct As New ClsTime
    Public Shared csd As New ClsSchedule
    Public Shared listalldatatimefromdatabase As New List(Of ClsTime)
    Public Shared listalldatadayfromdatabase As New List(Of Clsdaystudy)
    Public Shared listalldatanametimefromdatabase As New List(Of ClsTimeName)
    Public Shared listalldataschedulefromdatabase As New List(Of ClsSchedule)
    Public Shared listtimefromdatabase As New List(Of ClsTime)
    Public Shared listdayfromdatabase As New List(Of Clsdaystudy)
    Public Shared listtimenamefromdatabase As New List(Of ClsTimeName)
    Public Shared listschedulefromdatabase As New List(Of ClsSchedule)
    Shared connection As New SqlConnection(ClsConnection.ConnectDb)
    Public Shared command As New SqlCommand
    Public Shared reader As SqlDataReader

    'Get all data day from database add to list
    Private Shared Sub addalldatadaytolist(ByVal cd As Clsdaystudy)
        listalldatadayfromdatabase.Add(cd)
    End Sub
    ' Get all data timename from database add to list
    Private Shared Sub addalldatatimenametolist(ByVal dt As ClsTimeName)
        listalldatanametimefromdatabase.Add(dt)
    End Sub
    ' Get all data time from database add to list
    Private Shared Sub addalldatatimetolist(ByVal ct As ClsTime)
        listalldatatimefromdatabase.Add(ct)
    End Sub
    ' Get all data schdule from database add to list
    Private Shared Sub addalldatascheduletolist(ByVal csd As ClsSchedule)
        listalldataschedulefromdatabase.Add(csd)
    End Sub
    ' Get data day from database where active add to list
    Private Shared Sub AddDataFromDatabase(ByVal cf As Clsdaystudy)
        listdayfromdatabase.Add(cf)
    End Sub
    ' Get data time from database where active add to list
    Private Shared Sub AddDatatimeFromDatabase(ByVal cf As ClsTime)
        listtimefromdatabase.Add(cf)
    End Sub
    ' Get data time name from database where active add to list
    Private Shared Sub AddDatatimenameFromDatabase(ByVal cf As ClsTimeName)
        listtimenamefromdatabase.Add(cf)
    End Sub
    ' Get data schdule from database add to list where Active
    Private Shared Sub adddatascheduletolist(ByVal csd As ClsSchedule)
        listschedulefromdatabase.Add(csd)
    End Sub
    Public Shared Sub addupdatedaytodatabase(ByVal sql As String, ByVal message As String, ByVal txtid As String, ByVal txtstartday As String, ByVal txtendday As String, ByVal txtdesc As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.Parameters.Add("@startday", SqlDbType.NVarChar).Value = txtstartday
            command.Parameters.Add("@endday", SqlDbType.NVarChar).Value = txtendday
            command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = txtdesc
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = "Active"
            command.ExecuteNonQuery()
            MessageBox.Show(message, "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            ' listdayfromdatabase.Clear()
            GetDataFromDatabase()
            listdayfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    Public Shared Sub addupdatetimenametodatabase(ByVal sql As String, ByVal message As String, ByVal txtid As String, ByVal txtdayname As String, ByVal txtdesc As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtdayname
            command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = txtdesc
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = "Active"
            command.ExecuteNonQuery()
            MessageBox.Show(message, "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            ' listdayfromdatabase.Clear()
            GetDatatimenameFromDatabase()
            listtimenamefromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    Public Shared Sub addupdatetimetodatabase(ByVal sql As String, ByVal message As String, ByVal txtid As String, ByVal txtstarttime As String, ByVal txtendtime As String, ByVal txtdesc As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.Parameters.Add("@starttime", SqlDbType.NVarChar).Value = txtstarttime
            command.Parameters.Add("@endtime", SqlDbType.NVarChar).Value = txtendtime
            command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = txtdesc
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = "Active"
            command.ExecuteNonQuery()
            MessageBox.Show(message, "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            ' listdayfromdatabase.Clear()
            GetDatatimeFromDatabase()
            listtimefromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    Public Shared Sub addupdatescheduletodatabase(ByVal sql As String, ByVal txtid As String, ByVal txtdayid As String, ByVal txttimenameid As String, ByVal timeid As String, ByVal txtsubid As String, ByVal datestart As String, ByVal txtdesc As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@sdid", SqlDbType.NVarChar).Value = txtid
            command.Parameters.Add("@dayid", SqlDbType.NVarChar).Value = txtdayid
            command.Parameters.Add("@timenameid", SqlDbType.NVarChar).Value = txttimenameid
            command.Parameters.Add("@timeid", SqlDbType.NVarChar).Value = timeid
            command.Parameters.Add("@subid", SqlDbType.NVarChar).Value = txtsubid
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = datestart
            command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = txtdesc
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = "Active"
            command.ExecuteNonQuery()
            MessageBox.Show("ទិន្នន័យត្រូវបានរក្សាទុកនៅក្នុង Database!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            ' listdayfromdatabase.Clear()
            GetDatascheduleFromDatabase()
            listschedulefromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    Public Shared Sub DeleteDataday(ByVal txtid As String)
        Try
            connection.Open()
            command = New SqlCommand("deletedataday", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.ExecuteNonQuery()
            MessageBox.Show("ទិន្នន័យថ្ងៃសិក្សាត្រូវបានលុបចេញពី Database!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            GetDataFromDatabase()
            listdayfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    Public Shared Sub DeleteDatatimename(ByVal txtid As String)
        Try
            connection.Open()
            command = New SqlCommand("deletedatatimename", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.ExecuteNonQuery()
            MessageBox.Show("ទិន្នន័យឈ្មោះពេលត្រូវបានលុបចេញពី Database!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            ' listdayfromdatabase.Clear()
            GetDatatimenameFromDatabase()
            listtimenamefromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    Public Shared Sub DeleteDatatime(ByVal txtid As String)
        Try
            connection.Open()
            command = New SqlCommand("deletedatatime", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.ExecuteNonQuery()
            MessageBox.Show("ទិន្នន័យពេលសិក្សាត្រូវបានលុបចេញពី Database!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            ' listdayfromdatabase.Clear()
            GetDatatimeFromDatabase()
            listtimefromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    Public Shared Sub DeleteDataschedule(ByVal txtid As String)
        Try
            connection.Open()
            command = New SqlCommand("deletedataschedule", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.ExecuteNonQuery()
            MessageBox.Show("ទិន្នន័យត្រូវបានលុបចេញពី Database!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            ' listdayfromdatabase.Clear()
            GetDatatimeFromDatabase()
            listtimefromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    Public Shared Sub SetIDdaystudy(ByVal t As TextBox)
        listalldatadayfromdatabase.Clear()
        GetAllDatadayFromDatabase()
        t.Text = "លរថ" & listalldatadayfromdatabase.Count + 1
    End Sub
    Public Shared Sub SetIDtimename(ByVal t As TextBox)
        listalldatanametimefromdatabase.Clear()
        GetAllDatatimenameFromDatabase()
        t.Text = "លរព" & listalldatanametimefromdatabase.Count + 1
    End Sub
    Public Shared Sub SetIDtime(ByVal t As TextBox)
        listalldatatimefromdatabase.Clear()
        GetAllDatatimeFromDatabase()
        t.Text = "លរព" & listalldatatimefromdatabase.Count + 1
    End Sub
    Public Shared Sub SetIDtschedule(ByVal t As TextBox)
        listalldataschedulefromdatabase.Clear()
        GetAllDatascheduleFromDatabase()
        t.Text = "លរព" & listalldataschedulefromdatabase.Count + 1
    End Sub
    Public Shared Sub GetAllDatadayFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("getalldataday", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            cs = New Clsdaystudy
            cs.Id = reader.Item(0)
            cs.startday = reader.Item(1)
            cs.endday = reader.Item(2)
            cs.Desc = reader.Item(3)
            addalldatadaytolist(cs)
        End While
        connection.Close()
    End Sub
    Public Shared Sub GetAllDatatimenameFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("getalldatatimename", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            ctn = New ClsTimeName
            ctn.IdName = reader.Item(0)
            ctn.TimeName = reader.Item(1)
            ctn.Description = reader.Item(2)
            addalldatatimenametolist(ctn)
        End While
        connection.Close()
    End Sub
    Public Shared Sub GetAllDatatimeFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("getalldatatime", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            ct = New ClsTime
            ct.TimeId = reader.Item(0)
            ct.starttime = reader.Item(1)
            ct.endtime = reader.Item(2)
            ct.Description = reader.Item(3)
            addalldatatimetolist(ct)
        End While
        connection.Close()
    End Sub
    Public Shared Sub GetAllDatascheduleFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("getalldataschedule", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            csd = New ClsSchedule
            csd.sdid = reader.Item(0)
            csd.dayid = reader.Item(1)
            csd.timenameid = reader.Item(2)
            csd.timeid = reader.Item(3)
            csd.subid = reader.Item(4)
            csd.Startdate = reader.Item(5)
            csd.desc = reader.Item(6)
            addalldatascheduletolist(csd)
        End While
        connection.Close()
    End Sub
    Public Shared Sub ShowdataFromDatabase(ByVal dgv As DataGridView)
        dgv.Rows.Clear()
        GetDataFromDatabase()
        Dim i As Integer
        For i = 0 To listdayfromdatabase.Count - 1
            dgv.Rows.Add(listdayfromdatabase.Item(i).Id, listdayfromdatabase.Item(i).startday, "ដល់", listdayfromdatabase.Item(i).endday, listdayfromdatabase.Item(i).Desc)
        Next
    End Sub
    Public Shared Sub ShowdatatimenameFromDatabase(ByVal dgv As DataGridView)
        dgv.Rows.Clear()
        GetDatatimenameFromDatabase()
        Dim i As Integer
        For i = 0 To listtimenamefromdatabase.Count - 1
            dgv.Rows.Add(listtimenamefromdatabase.Item(i).IdName, listtimenamefromdatabase.Item(i).TimeName, listtimenamefromdatabase.Item(i).Description)
        Next
    End Sub
    Public Shared Sub ShowdatatimeFromDatabase(ByVal dgv As DataGridView)
        dgv.Rows.Clear()
        GetDatatimeFromDatabase()
        Dim i As Integer
        For i = 0 To listtimefromdatabase.Count - 1
            dgv.Rows.Add(listtimefromdatabase.Item(i).TimeId, listtimefromdatabase.Item(i).starttime, "ដល់", listtimefromdatabase.Item(i).endtime, listtimefromdatabase.Item(i).Description)
        Next
    End Sub
    Public Shared Sub ShowdatascheduleFromDatabase(ByVal dgv As DataGridView)
        dgv.Rows.Clear()
        GetDatascheduleFromDatabase()
        Dim i As Integer
        For i = 0 To listschedulefromdatabase.Count - 1
            dgv.Rows.Add(listschedulefromdatabase.Item(i).sdid, listschedulefromdatabase.Item(i).dayid, listschedulefromdatabase.Item(i).timenameid, listschedulefromdatabase.Item(i).timeid, listschedulefromdatabase.Item(i).subid, listschedulefromdatabase.Item(i).Startdate, listschedulefromdatabase.Item(i).desc)
        Next
    End Sub
    Public Shared Sub GetDataFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("getdataday", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            '  MsgBox(reader.Item(0))
            cs = New Clsdaystudy
            cs.Id = reader.Item(0)
            cs.startday = reader.Item(1)
            cs.endday = reader.Item(2)
            cs.Desc = reader.Item(3)
            AddDataFromDatabase(cs)
        End While
        connection.Close()
    End Sub
    Public Shared Sub GetDatatimenameFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("getdatatimename", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            '  MsgBox(reader.Item(0))
            ctn = New ClsTimeName
            ctn.IdName = reader.Item(0)
            ctn.TimeName = reader.Item(1)
            ctn.Description = reader.Item(2)
            AddDatatimenameFromDatabase(ctn)
        End While
        connection.Close()
    End Sub
    Public Shared Sub GetDatatimeFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("getdatatime", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            '  MsgBox(reader.Item(0))
            ct = New ClsTime
            ct.TimeId = reader.Item(0)
            ct.starttime = reader.Item(1)
            ct.endtime = reader.Item(2)
            ct.Description = reader.Item(3)
            AddDatatimeFromDatabase(ct)
        End While
        connection.Close()
    End Sub
    Public Shared Sub GetDatascheduleFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("getdataschedule", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            csd = New ClsSchedule
            csd.sdid = reader.Item(0)
            csd.dayid = reader.Item(1) & " - " & reader.Item(2)
            csd.timenameid = reader.Item(3)
            csd.timeid = reader.Item(4) & " - " & reader.Item(5)
            csd.subid = reader.Item(6)
            csd.Startdate = reader.Item(7)
            csd.desc = reader.Item(8)
            adddatascheduletolist(csd)
        End While
        connection.Close()
    End Sub
    Public Shared Sub FilldatadaytoCombobox(ByVal cbo As ComboBox)
        GetDataFromDatabase()
        cbo.Items.Clear()
        Dim i As Integer
        For i = 0 To listdayfromdatabase.Count - 1
            cbo.Items.Add(listdayfromdatabase.Item(i).startday & " - " & listdayfromdatabase.Item(i).endday)
        Next
    End Sub
    Public Shared Sub FilldatatimetoCombobox(ByVal cbo As ComboBox)
        GetDatatimeFromDatabase()
        cbo.Items.Clear()
        Dim i As Integer
        For i = 0 To listtimefromdatabase.Count - 1
            cbo.Items.Add(listtimefromdatabase.Item(i).starttime & " - " & listtimefromdatabase.Item(i).endtime)
        Next
    End Sub
    Public Shared Sub FilldatasubjecttoCombobox(ByVal cbo As ComboBox)
        DALSubject.GetDatasubjectFromDatabase()
        cbo.Items.Clear()
        Dim i As Integer
        For i = 0 To DALSubject.listsubjectfromdatabase.Count - 1
            cbo.Items.Add(DALSubject.listsubjectfromdatabase.Item(i).subject)
        Next
    End Sub
    Public Shared Sub FilldatatimenametoCombobox(ByVal cbo As ComboBox)
        GetDatatimenameFromDatabase()
        cbo.Items.Clear()
        Dim i As Integer
        For i = 0 To listtimenamefromdatabase.Count - 1
            cbo.Items.Add(listtimenamefromdatabase.Item(i).TimeName)
        Next
    End Sub
End Class
