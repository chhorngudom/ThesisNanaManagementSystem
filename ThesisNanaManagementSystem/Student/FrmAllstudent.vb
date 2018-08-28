Public Class FrmAllstudent
    Private Sub FrmAllstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALStudent.listscoredetailfromdatabaseactive.Clear()
        DALStudent.GetAllDatastudentFromDatabase()
        DALStudent.ShowalldatastudentFromDatabase(dgvmanagedatastudent)
    End Sub

    Private Sub txtsearchmanagedatastudent_TextChanged(sender As Object, e As EventArgs) Handles txtsearchmanagedatastudent.TextChanged
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim xlapp As Microsoft.Office.Interop.Excel.Application
        Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misvalue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlapp = New Microsoft.Office.Interop.Excel.Application
        xlworkbook = xlapp.Workbooks.Add(misvalue)
        xlworksheet = xlworkbook.Sheets("sheet1")
        For i = 0 To dgvmanagedatastudent.RowCount - 1
            For j = 0 To dgvmanagedatastudent.ColumnCount - 1
                For k As Integer = 1 To dgvmanagedatastudent.Columns.Count
                    xlworksheet.Cells(1, k) = dgvmanagedatastudent.Columns(k - 1).HeaderText
                    xlworksheet.Cells(i + 2, j + 1) = dgvmanagedatastudent(j, i).Value.ToString
                Next
            Next
        Next
        xlworksheet.Rows.Item(1).Font.Bold = 1
        xlworksheet.Rows.Item(1).HorizontalAlignment = 3
        xlworksheet.Columns.AutoFit()
        xlapp.Application.Visible = True
        xlapp.Application.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
    End Sub
End Class