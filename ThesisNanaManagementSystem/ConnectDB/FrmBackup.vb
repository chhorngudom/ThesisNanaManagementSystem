Imports System.Data.SqlClient
Public Class FrmBackup
    Private connection As New SqlConnection(ClsConnection.ConnectDb)
    Private sqlcommand As SqlCommand
    Private sqlreader As SqlDataReader
    Dim connect As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection.Open()
        Dim slq As String = "Select * from sys.databases d where d.database_id>6"
        sqlcommand = New SqlCommand(slq, connection)
        sqlreader = sqlcommand.ExecuteReader
        While sqlreader.Read
            cbodatabase.Items.Add(sqlreader.Item(0).ToString)
        End While
        connection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cbodatabase.Text = "" Then
            MsgBox("សូមជ្រើសរើស Database ដើម្បី BackUp!")
        End If
        Try
            connection.Open()
            Dim sql As String = "BACKUP DATABASE " & cbodatabase.Text.ToString & " TO DISK = '" & txtbackup.Text.ToString & "\\" & cbodatabase.Text.ToString & "-" & DateTime.Now.Day.ToString & "-" & DateTime.Now.Month.ToString & "-" & DateTime.Now.Year.ToString & "-" & DateTime.Now.Hour.ToString & "-" & DateTime.Now.Minute.ToString & "-" & DateTime.Now.Second.ToString & ".bak'"
            sqlcommand = New SqlCommand(sql, connection)
            sqlcommand.ExecuteNonQuery()
            MsgBox("Database Backup Successfully")
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As New FolderBrowserDialog
        If (x.ShowDialog() = DialogResult.OK) Then
            txtbackup.Text = x.SelectedPath
        End If
    End Sub

    Private Sub FrmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class