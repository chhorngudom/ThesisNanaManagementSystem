Imports System.Data.SqlClient
Imports System.IO
Public Class DAL
    Public Shared listuseraccount As New List(Of ClsUserAccount)
    Public Shared listuserfromdatabase As New List(Of ClsUserAccount)
    Public Shared cua As New ClsUserAccount
    Shared connection As New SqlConnection(ClsConnection.ConnectDb)
    Public Shared command As New SqlCommand
    Public Shared reader As SqlDataReader
    Public Shared Logins As String = ""
    Public Shared userid As String = ""

    Public Shared Function CheckPictureBox(ByVal pb As PictureBox, ByVal message As String) As Boolean
        If (pb.Image Is Nothing) Then
            MessageBox.Show(message, "ព័ត៏មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        End If
        Return False
    End Function

    Public Shared Sub DeleteUser(ByVal txtid As TextBox, ByVal dgv As DataGridView)
        If CheckText(txtid, "សូមបញ្ចូលលេខរៀង​ គណនី") Then
            Return
        End If
        If listuseraccount.Count <= 0 Then
            MessageBox.Show("គ្មានទិន្នន័យ", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        listuseraccount = getuserlist()
        For Each user As ClsUserAccount In listuseraccount
            If user.id.ToString.Equals(txtid.Text) Then
            Else
                MessageBox.Show("លេខសម្គាល់គណនីមិនត្រឹមត្រូវ សួមជ្រើសរើសទិន្នន័យដើម្បីលុប!")
                dgv.Rows.Clear()
                Call Showuserlist(dgv)
                Return
            End If
        Next
        For Each user As ClsUserAccount In listuseraccount
            If user.id.Equals(txtid.Text) Then
                listuseraccount.Remove(user)
                MessageBox.Show("ទិន្នន័យត្រូវបានលុប!")
                dgv.Rows.Clear()
                Call Showuserlist(dgv)
                Return
            End If
        Next
    End Sub
    Public Shared Sub UpdateUser(ByVal txtid As String, ByVal txtname As String, ByVal txtpwd As String, ByVal usertype As String, ByVal manageuseraccount As String, ByVal managedatastudent As String, ByVal managedataemployee As String, ByVal managedatasubject As String, ByVal managedataschedule As String, ByVal managedata As String, ByVal pb As PictureBox, ByVal dgv As DataGridView)
        If txtid.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលអត្តលេខគណនី!")
            Return
        End If
        If txtname.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះគណនី!")
            Return
        End If

        If usertype.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលប្រភេទគណនី!")
            Return
        End If
        If pb.Image Is Nothing Then
            MessageBox.Show("សូមបញ្ចូលរូបភាពគណនី!")
            Return
        End If

        listuseraccount = getuserlist()
        Dim i As Integer
        Dim ms As New MemoryStream
        pb.Image.Save(ms, pb.Image.RawFormat)
        Dim imc As Byte()
        imc = ms.ToArray
        For i = 0 To listuseraccount.Count - 1
            If (listuseraccount.Item(i).id.Equals(txtid)) Then
                listuseraccount.Item(i).username = txtname
                listuseraccount.Item(i).password = txtpwd
                listuseraccount.Item(i).usertype = usertype
                listuseraccount.Item(i).manageuseraccount = manageuseraccount
                listuseraccount.Item(i).managedatastudent = managedatastudent
                listuseraccount.Item(i).managedataemployee = managedataemployee
                listuseraccount.Item(i).managedatasubject = managedatasubject
                listuseraccount.Item(i).managedataschedule = managedataschedule
                listuseraccount.Item(i).managedata = managedata
                listuseraccount.Item(i).Image = imc
            End If
        Next
        MessageBox.Show("ទិន្នន័យត្រូវបាបកែប្រែរួចរាល់!", "ព័ត៏មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Showuserlist(dgv)
    End Sub
    Public Shared Function CheckCombobox(ByVal cbb As ComboBox, ByVal message As String) As Boolean
        If cbb.Text = "" Then
            MessageBox.Show(message, "ព័ត៏មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbb.Focus()
            Return True
        End If
        Return False
    End Function
    Public Shared Sub Login(ByVal txtname As String, ByVal txtpwd As String, ByVal txtusertype As String)
        listuserfromdatabase.Clear()
        GetDataFromDatabase()
        If txtusertype.Equals("បុគ្គលិក") Then
            For x = 0 To listuserfromdatabase.Count - 1
                If (listuserfromdatabase.Item(x).username.Equals(txtname) And listuserfromdatabase.Item(x).password.Equals(txtpwd) And listuserfromdatabase.Item(x).usertype.Equals(txtusertype)) Then
                    Logins = "true"
                    userid = listuserfromdatabase.Item(x).id
                    FrmMain.Show()
                    Return
                End If
            Next
            listuserfromdatabase.Clear()
            GetDataFromDatabase()
            For x = 0 To listuserfromdatabase.Count - 1
                If (listuserfromdatabase.Item(x).username IsNot txtname And listuserfromdatabase.Item(x).password IsNot txtpwd And listuserfromdatabase.Item(x).usertype IsNot txtusertype) Then
                    MessageBox.Show("ឈ្មោះ ឫ ពាក្យសម្ងាត់ មិនត្រឹមត្រូវ សូមបញ្ខូលម្តងទៀត!", "ព័ត៏មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Logins = "fail"
                    Return
                End If
            Next
        End If
        listuserfromdatabase.Clear()
        GetDataFromDatabase()
        If txtusertype.Equals("អ្នកគ្រប់គ្រង") Then
            For x = 0 To listuserfromdatabase.Count - 1
                If (listuserfromdatabase.Item(x).username.Equals(txtname) And listuserfromdatabase.Item(x).password.Equals(txtpwd) And listuserfromdatabase.Item(x).usertype.Equals(txtusertype)) Then
                    Logins = "true"
                    userid = listuserfromdatabase.Item(x).id
                    FrmMain.Show()
                    Return
                End If

            Next
            listuserfromdatabase.Clear()
            GetDataFromDatabase()
            For x = 0 To listuserfromdatabase.Count - 1
                If (listuserfromdatabase.Item(x).username IsNot txtname And listuserfromdatabase.Item(x).password IsNot txtpwd And listuserfromdatabase.Item(x).usertype IsNot txtusertype) Then
                    MessageBox.Show("ឈ្មោះ ឫ ពាក្យសម្ងាត់ មិនត្រឹមត្រូវ សូមបញ្ខូលម្តងទៀត!", "ព័ត៏មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Logins = "fail"
                    Return
                End If
            Next
        End If


    End Sub
    Public Shared Function ClearPictureBox(ByVal pb As PictureBox)
        pb.Image = Nothing
    End Function
    Public Shared Function ClearCombobox(ByVal cbo As ComboBox)
        cbo.Text = ""
    End Function
    Public Shared Sub SetIDuser(ByVal t As TextBox)
        listuserfromdatabase.Clear()
        GetDataFromDatabase()
        t.Text = "លរគ" & listuserfromdatabase.Count + 1
    End Sub
    Public Shared Sub ClearText(ByVal t As TextBox)
        t.Clear()
    End Sub
    Public Shared Sub GetDataFromDatabase()
        Dim i As Integer
        connection.Open()
        command = New SqlCommand("Getuser", connection)
        command.CommandType = CommandType.StoredProcedure
        reader = command.ExecuteReader
        While reader.Read
            '     MsgBox(reader.Item(0))
            cua = New ClsUserAccount()
            cua.id = reader.Item(0)
            cua.username = reader.Item(1)
            cua.password = reader.Item(2)
            cua.usertype = reader.Item(3)
            cua.manageuseraccount = reader.Item(4)
            cua.managedatastudent = reader.Item(5)
            cua.managedataemployee = reader.Item(6)
            cua.managedatasubject = reader.Item(7)
            cua.managedataschedule = reader.Item(8)
            cua.managedata = reader.Item(9)
            cua.Image = reader.Item(10)
            AddDataFromDatabase(cua)
        End While
        connection.Close()
    End Sub
    Public Shared Sub Deleteuserfromdatabase(ByVal id As String)
        Try
            connection.Open()
            command = New SqlCommand("Deleteuseraccount", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id
            command.ExecuteNonQuery()
            MessageBox.Show("ទិន្នន័យត្រូវបានលុបចេញពី Database រួចរាល់!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    Public Shared Sub AddDataToDatabase()
        If listuseraccount.Count <= 0 Then
            MessageBox.Show("គ្មានទិន្នន័យ", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim i As Integer
            connection.Open()
            For i = 0 To listuseraccount.Count - 1
                command = New SqlCommand("Adduser", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = listuseraccount.Item(i).id
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = listuseraccount.Item(i).username
                command.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = listuseraccount.Item(i).password
                command.Parameters.Add("@usertype", SqlDbType.NVarChar).Value = listuseraccount.Item(i).usertype
                command.Parameters.Add("@manageuseraccount", SqlDbType.NVarChar).Value = listuseraccount.Item(i).manageuseraccount
                command.Parameters.Add("@managedatastudent", SqlDbType.NVarChar).Value = listuseraccount.Item(i).managedatastudent
                command.Parameters.Add("@managedataemployee", SqlDbType.NVarChar).Value = listuseraccount.Item(i).managedataemployee
                command.Parameters.Add("@managedatasubject", SqlDbType.NVarChar).Value = listuseraccount.Item(i).managedatasubject
                command.Parameters.Add("@managedataschedule", SqlDbType.NVarChar).Value = listuseraccount.Item(i).managedataschedule
                command.Parameters.Add("@managedata", SqlDbType.NVarChar).Value = listuseraccount.Item(i).managedata
                command.Parameters.Add("@img", SqlDbType.Image).Value = listuseraccount.Item(i).Image
                command.ExecuteNonQuery()
            Next
            MessageBox.Show("ទិន្នន័យត្រូវបានបញ្ជួនទៅកាន Database រួចរាល់", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            listuseraccount.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub
    Public Shared Sub UpdateDataToDatabase(ByVal txtid As String, ByVal txtusername As String, ByVal txtpassword As String, ByVal txtusertype As String, ByVal txtmanageuseraccount As String, ByVal txtmanagedatastudent As String, ByVal txtmanagedataemployee As String, ByVal txtmanagedatasubect As String, ByVal txtmanagedataschedule As String, ByVal txtmanagedata As String, ByVal img As Byte())
        If listuserfromdatabase.Count <= 0 Then
            MessageBox.Show("គ្មានទិន្នន័យ", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim i As Integer
            connection.Open()
            command = New SqlCommand("upadatedatauser", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtid
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtusername
            command.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = txtpassword
            command.Parameters.Add("@usertype", SqlDbType.NVarChar).Value = txtusertype
            command.Parameters.Add("@manageuseraccount", SqlDbType.NVarChar).Value = txtmanageuseraccount
            command.Parameters.Add("@managedatastudent", SqlDbType.NVarChar).Value = txtmanagedatastudent
            command.Parameters.Add("@managedataemployee", SqlDbType.NVarChar).Value = txtmanagedataemployee
            command.Parameters.Add("@managedatasubject", SqlDbType.NVarChar).Value = txtmanagedatasubect
            command.Parameters.Add("@managedataschedule", SqlDbType.NVarChar).Value = txtmanagedataschedule
            command.Parameters.Add("@managedata", SqlDbType.NVarChar).Value = txtmanagedata
            command.Parameters.Add("@img", SqlDbType.Image).Value = img
            command.ExecuteNonQuery()
            MessageBox.Show("ទិន្នន័យត្រូវបានកែប្រែរួចរាល់", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            listuseraccount.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try
    End Sub


    Private Shared Sub AddDataFromDatabase(ByVal cf As ClsUserAccount)
        listuserfromdatabase.Add(cf)
    End Sub
    Public Shared Sub adduserlist(ByVal cua As ClsUserAccount, ByVal t As TextBox)
        For i As Integer = 0 To listuseraccount.Count - 1
            If listuseraccount.Item(i).id.Equals(t.Text) Then
                MessageBox.Show("លេខរៀងអ្នកប្រើប្រាស់មិនអាចស្ទួន សូមបញ្ខូលផ្សេងទៀត! ", "ប្រព័ន្ធគ្រប់គ្រងទិន្នន័យមជ្ឈមណ្ឌលណាណា កុំព្យូទ័រ និង​ ភាសាអង់គ្លេស", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next
        listuseraccount.Add(cua)
    End Sub
    Public Shared Function getuserlist() As List(Of ClsUserAccount)
        Return listuseraccount
    End Function
    Public Shared Sub Showuserlist(ByVal dgvuser As DataGridView)
        If listuseraccount.Count <= 0 Then
            Return
        End If
        dgvuser.Rows.Clear()
        dgvuser.RowTemplate.Height = 50
        dgvuser.Columns(0).Width = 50
        listuseraccount = getuserlist()
        Dim i As Integer
        For i = 0 To getuserlist.Count - 1
            dgvuser.Rows.Add(getuserlist.Item(i).Image, getuserlist.Item(i).id, getuserlist.Item(i).username, getuserlist.Item(i).password, getuserlist.Item(i).usertype, getuserlist.Item(i).manageuseraccount, getuserlist.Item(i).managedatastudent, getuserlist.Item(i).managedataemployee, getuserlist.Item(i).managedatasubject, getuserlist.Item(i).managedataschedule, getuserlist.Item(i).managedata)
        Next

        Dim imc As New DataGridViewImageColumn
        imc = dgvuser.Columns(0)
        imc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub
    Public Shared Sub Showuserfrordatabase(ByVal dgvuser As DataGridView, ByVal txtsearch As String)
        If listuserfromdatabase.Count <= 0 Then
            Return
        End If
        dgvuser.Rows.Clear()
        dgvuser.RowTemplate.Height = 50
        dgvuser.Columns(0).Width = 50
        listuserfromdatabase.Clear()
        GetDataFromDatabase()
        Dim i As Integer
        For i = 0 To listuserfromdatabase.Count - 1
            If listuserfromdatabase.Item(i).username.ToUpper.Contains(txtsearch.ToString.ToUpper) Then

                dgvuser.Rows.Add(listuserfromdatabase.Item(i).Image, listuserfromdatabase.Item(i).id, listuserfromdatabase.Item(i).username, listuserfromdatabase.Item(i).password, listuserfromdatabase.Item(i).usertype, listuserfromdatabase.Item(i).manageuseraccount, listuserfromdatabase.Item(i).managedatastudent, listuserfromdatabase.Item(i).managedataemployee, listuserfromdatabase.Item(i).managedatasubject, listuserfromdatabase.Item(i).managedataschedule, listuserfromdatabase.Item(i).managedata)
            ElseIf txtsearch.ToString = "" Then
                dgvuser.Rows.Add(listuserfromdatabase.Item(i).Image, listuserfromdatabase.Item(i).id, listuserfromdatabase.Item(i).username, listuserfromdatabase.Item(i).password, listuserfromdatabase.Item(i).usertype, listuserfromdatabase.Item(i).manageuseraccount, listuserfromdatabase.Item(i).managedatastudent, listuserfromdatabase.Item(i).managedataemployee, listuserfromdatabase.Item(i).managedatasubject, listuserfromdatabase.Item(i).managedataschedule, listuserfromdatabase.Item(i).managedata)
            End If

        Next

        Dim imc As New DataGridViewImageColumn
        imc = dgvuser.Columns(0)
        imc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub
    Public Shared Function CheckText(ByVal t As TextBox, ByVal message As String) As Boolean
        If t.Text = "" Then
            MessageBox.Show(message, "ប្រព័ន្ធគ្រប់គ្រងទិន្នន័យមជ្ឈមណ្ឌលណាណា កុំព្យូទ័រ និង​ ភាសាអង់គ្លេស", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            t.Focus()
            Return True
        End If
        Return False
    End Function
    Public Shared Function CheckCombo(ByVal cbo As ComboBox, ByVal message As String) As Boolean
        If cbo.Text = "" Then
            MessageBox.Show(message, "ប្រព័ន្ធគ្រប់គ្រងទិន្នន័យមជ្ឈមណ្ឌលណាណា កុំព្យូទ័រ និង​ ភាសាអង់គ្លេស", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbo.Focus()
            Return True
        End If
        Return False
    End Function
End Class
