Imports System.Data.SqlClient
Public Class DALSubject
    Public Shared cps As New ClsPartsubject
    Public Shared cs As New ClsSubject
    Public Shared listsubjectfromdatabase As New List(Of ClsSubject)
    Public Shared listpartsubjectfromdatabase As New List(Of ClsPartsubject)
    Public Shared listalldatasubject As New List(Of ClsSubject)
    Public Shared listalldatapartsubject As New List(Of ClsPartsubject)
    Public Shared listdatasubjectdelete As New List(Of ClsSubject)
    Public Shared listdatapartstudydelete As New List(Of ClsPartsubject)
    Shared connection As New SqlConnection(ClsConnection.ConnectDb)
    Public Shared command As New SqlCommand
    Public Shared reader As SqlDataReader
    ' Get all data part study from database
    Private Shared Sub AddallDatapartstudyFromDatabase(ByVal cp As ClsPartsubject)
        listalldatapartsubject.Add(cp)
    End Sub

    Public Shared Sub selectpartstudy(ByVal cbopartstudy As ComboBox)

    End Sub
    ' Get all data Subject from database
    Private Shared Sub AddallDatasubjectFromDatabase(ByVal cs As ClsSubject)
        listalldatasubject.Add(cs)
    End Sub
    ' Get all data part study from database where Active
    Private Shared Sub AddDatapartstudyFromDatabase(ByVal cp As ClsPartsubject)
        listpartsubjectfromdatabase.Add(cp)
    End Sub
    ' Get all data subject from database where Active
    Private Shared Sub AddDatasubjectFromDatabase(ByVal cs As ClsSubject)
        listsubjectfromdatabase.Add(cs)
    End Sub
    ' Get all data part study from database where delete
    Private Shared Sub AddDataSubjectFromDatabaseDelete(ByVal cp As ClsPartsubject)
        listdatapartstudydelete.Add(cp)
    End Sub
    ' Get all data Subject from database where delete
    Private Shared Sub AddDatapartstudyFromDatabaseDelete(ByVal cs As ClsSubject)
        listdatasubjectdelete.Add(cs)
    End Sub
    ' Set Auto ID to part study ID
    Public Shared Sub SetIDFaculty(ByVal t As TextBox)
        listalldatapartsubject.Clear()
        GetAllDatapartsubjectFromDatabase()
        t.Text = "លរផ" & listalldatapartsubject.Count + 1
    End Sub
    ' Set Auto ID to part study ID
    Public Shared Sub SetIDSubject(ByVal t As TextBox)
        listalldatasubject.Clear()
        GetAllDatasubjectFromDatabase()
        t.Text = "លរម" & listalldatasubject.Count + 1
    End Sub
    ' This Sub use for add or update data part study in database
    Public Shared Sub addupdatepartstudytodatabase(ByVal sql As String, ByVal message As String, ByVal txtid As String, ByVal txtpartstudy As String, ByVal txtdesc As String, ByVal txtstatus As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.Parameters.Add("@partname", SqlDbType.NVarChar).Value = txtpartstudy
            command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = txtdesc
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = txtstatus
            command.ExecuteNonQuery()
            MessageBox.Show(message, "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            GetDataFromDatabase()
            listpartsubjectfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    ' This Sub Use for add or upate data subject in database
    Public Shared Sub addupdatesubjecttodatabase(ByVal sql As String, ByVal message As String, ByVal txtid As String, ByVal txtpartid As String, ByVal txtsubject As String, ByVal txtdesc As String)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.Parameters.Add("@partid", SqlDbType.NVarChar).Value = txtpartid
            command.Parameters.Add("@subject", SqlDbType.NVarChar).Value = txtsubject
            command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = txtdesc
            command.ExecuteNonQuery()
            MessageBox.Show(message, "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            GetDatasubjectFromDatabase()
            listsubjectfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    ' This sub use for fill data part study to datagridview
    Public Shared Sub ShowdataFromDatabase(ByVal dgv As DataGridView)
        dgv.Rows.Clear()
        GetDataFromDatabase()
        Dim i As Integer
        For i = 0 To listpartsubjectfromdatabase.Count - 1
            dgv.Rows.Add(listpartsubjectfromdatabase.Item(i).ID, listpartsubjectfromdatabase.Item(i).partname, listpartsubjectfromdatabase.Item(i).des)
        Next
    End Sub
    ' This sub use for fill data subject to datagridview
    Public Shared Sub ShowdatasubjectFromDatabase(ByVal dgv As DataGridView)
        dgv.Rows.Clear()
        listpartsubjectfromdatabase.Clear()
        GetDatasubjectFromDatabase()
        Dim i As Integer
        For i = 0 To listsubjectfromdatabase.Count - 1
            dgv.Rows.Add(listsubjectfromdatabase.Item(i).Id, listsubjectfromdatabase.Item(i).partid, listsubjectfromdatabase.Item(i).subject, listsubjectfromdatabase.Item(i).description)
        Next
    End Sub
    ' This sub use for get data part Study from database where Active
    Public Shared Sub GetDataFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("showdatapartstudy", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            cps = New ClsPartsubject
            cps.ID = reader.Item(0)
            cps.partname = reader.Item(1)
            cps.des = reader.Item(2)
            AddDatapartstudyFromDatabase(cps)
        End While
        connection.Close()
    End Sub
    ' This sub use for get all data part subject from database
    Public Shared Sub GetAllDatapartsubjectFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("getalldatapartstudy", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            cps = New ClsPartsubject
            cps.ID = reader.Item(0)
            cps.partname = reader.Item(1)
            cps.des = reader.Item(2)
            AddallDatapartstudyFromDatabase(cps)
        End While
        connection.Close()
    End Sub
    ' This sub use for get data subject from database where Active
    Public Shared Sub GetDatasubjectFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("showdatasubjects", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            '  MsgBox(reader.Item(0))
            cs = New ClsSubject
            cs.Id = reader.Item(0)
            cs.partid = reader.Item(1)
            cs.subject = reader.Item(2)
            cs.description = reader.Item(3)
            AddDatasubjectFromDatabase(cs)
        End While
        connection.Close()
    End Sub
    ' This sub use for get all data subject from database
    Public Shared Sub GetAllDatasubjectFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("getalldatasubject", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            cs = New ClsSubject
            cs.Id = reader.Item(0)
            cs.partid = reader.Item(1)
            cs.subject = reader.Item(2)
            cs.description = reader.Item(3)
            AddallDatasubjectFromDatabase(cs)
        End While
        connection.Close()
    End Sub
    ' This sub use for fill data part study.partname to Combobox
    Public Shared Sub FilldatatoCombobox(ByVal cbo As ComboBox)
        GetDataFromDatabase()
        cbo.Items.Clear()
        Dim i As Integer
        For i = 0 To listpartsubjectfromdatabase.Count - 1
            cbo.Items.Add(listpartsubjectfromdatabase.Item(i).partname)
        Next
    End Sub
    ' This Sub use for Delete data part study
    Public Shared Sub Deletepartstudy(ByVal txtid As String)
        Try
            connection.Open()
            command = New SqlCommand("deletedatapartstudy", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.ExecuteNonQuery()
            MessageBox.Show("ទិន្នន័យផ្នែកសិក្សាត្រូវបានលុបចេញពី Database!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            GetDataFromDatabase()
            listpartsubjectfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    ' This Sub use for delete subject
    Public Shared Sub DeleteSubject(ByVal txtid As String)
        Try
            connection.Open()
            command = New SqlCommand("deletedatasubject", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.ExecuteNonQuery()
            MessageBox.Show("ទិន្នន័យមុខវិជ្ជាសិក្សាត្រូវបានលុបចេញពី Database!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            GetDatasubjectFromDatabase()
            listsubjectfromdatabase.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub

End Class
