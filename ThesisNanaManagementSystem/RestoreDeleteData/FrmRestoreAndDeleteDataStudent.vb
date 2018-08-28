Public Class FrmRestoreAndDeleteDataStudent
    Private Sub FrmRestoreAndDeleteDataStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALStudent.listscoredetailfromdatabaseactive.Clear()
        DALStudent.GetDatastudentFromDatabasedelete()
        DALStudent.ShowalldatastudentFromDatabasedelete(dgvmanagedatastudent)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtsearchmanagedatastudent.TextChanged
        dgvmanagedatastudent.Rows.Clear()
        DALStudent.listgetalldatastudentdelete.Clear()
        DALStudent.GetDatastudentFromDatabasedelete()
        DALStudent.GetAllDatastudentFromDatabase()
        If Not txtsearchmanagedatastudent.Text = "" Then
            Dim i As Integer
            For i = 0 To DALStudent.listgetalldatastudentdelete.Count - 1
                If (DALStudent.listgetalldatastudentdelete.Item(i).namekhmer.ToUpper.Contains(txtsearchmanagedatastudent.Text.ToUpper) Or DALStudent.listgetalldatastudentdelete.Item(i).namelatin.ToUpper.Contains(txtsearchmanagedatastudent.Text.ToUpper)) Then
                    dgvmanagedatastudent.Rows.Add(DALStudent.listgetalldatastudentdelete.Item(i).Image, DALStudent.listgetalldatastudentdelete.Item(i).id, DALStudent.listgetalldatastudentdelete.Item(i).idcard, DALStudent.listgetalldatastudentdelete.Item(i).namekhmer, DALStudent.listgetalldatastudentdelete.Item(i).namelatin, DALStudent.listgetalldatastudentdelete.Item(i).Nation, DALStudent.listgetalldatastudentdelete.Item(i).Nationalty, DALStudent.listgetalldatastudentdelete.Item(i).gender, DALStudent.listgetalldatastudentdelete.Item(i).dob, DALStudent.listgetalldatastudentdelete.Item(i).roadnopob & "," & DALStudent.listgetalldatastudentdelete.Item(i).homenopob & "," & DALStudent.listgetalldatastudentdelete.Item(i).villagepob & "," & DALStudent.listgetalldatastudentdelete.Item(i).communepob & "," & DALStudent.listgetalldatastudentdelete.Item(i).Districtpob & "," & DALStudent.listgetalldatastudentdelete.Item(i).provincepob, DALStudent.listgetalldatastudentdelete.Item(i).phonenumber, DALStudent.listgetalldatastudentdelete.Item(i).emailaddress, DALStudent.listgetalldatastudentdelete.Item(i).roadnoadn & "," & DALStudent.listgetalldatastudentdelete.Item(i).homenoadn & "," & DALStudent.listgetalldatastudentdelete.Item(i).villageadn & "," & DALStudent.listgetalldatastudentdelete.Item(i).communeadn & "," & DALStudent.listgetalldatastudentdelete.Item(i).Districtadn & "," & DALStudent.listgetalldatastudentdelete.Item(i).provinceadn, DALStudent.listgetalldatastudentdelete.Item(i).dayid, DALStudent.listgetalldatastudentdelete.Item(i).timenameid, DALStudent.listgetalldatastudentdelete.Item(i).timeid, DALStudent.listgetalldatastudentdelete.Item(i).desc, DALStudent.listgetalldatastudentdelete.Item(i).subid, DALStudent.listgetalldatastudentdelete.Item(i).Startdate)
                End If
            Next
        End If
        If txtsearchmanagedatastudent.Text = "" Then
            DALStudent.liststudentfromdatabaseactive.Clear()
            DALStudent.ShowalldatastudentFromDatabase(dgvmanagedatastudent)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub dgvmanagedatastudent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmanagedatastudent.CellContentClick

    End Sub
End Class