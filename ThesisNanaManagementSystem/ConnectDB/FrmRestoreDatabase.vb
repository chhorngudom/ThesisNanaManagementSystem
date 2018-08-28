Imports System.Data.SqlClient
Public Class FrmRestoreDatabase
    Private connection As New SqlConnection(ClsConnection.ConnectDb)
    Private sqlcommand As SqlCommand
    Private sqlreader As SqlDataReader
    Private Sub FrmRestoreDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As New OpenFileDialog
        If (x.ShowDialog() = DialogResult.OK) Then
            txtrestore.Text = x.FileName
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cbodatabase.Text = "" Then
            MessageBox.Show("សូមជ្រើសរើស Database ដើម្បី Restore!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Try
            connection.Close()
            Dim ConnectDb As String = "Server = .;Initial Catalog = master;Integrated Security = true"
            Dim sqlcon As New SqlConnection(ConnectDb)
            sqlcon.Open()
            sqlcommand = New SqlCommand("ALTER DATABASE " & cbodatabase.Text & " SET SINGLE_USER WITH ROLLBACK IMMEDIATE", sqlcon)
            sqlcommand.ExecuteNonQuery()
            sqlcon.Close()
            sqlcon.Open()
            sqlcommand = New SqlCommand("RESTORE DATABASE " & cbodatabase.Text & " FROM DISK ='" & txtrestore.Text & "'", sqlcon)
            sqlcommand.ExecuteNonQuery()
            MessageBox.Show(" Database " & cbodatabase.Text & " has been restore successfully!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sqlcon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

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
End Class