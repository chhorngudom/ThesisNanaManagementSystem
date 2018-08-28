Public Class FrmAllEmployee
    Private Sub FrmAllEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvmanagedataemployee.Columns(0).Width = 50
        '    DALEmployee.GetAllDataEmployeeActiveFromDatabase()
        DALEmployee.listallemployeeactive.Clear()
        DALEmployee.ShowdataactiveemployeeFromDatabase(dgvmanagedataemployee)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        dgvmanagedataemployee.Rows.Clear()
        DALEmployee.listallemployeeactive.Clear()
        DALEmployee.GetAllDataEmployeeFromDatabase()
        DALEmployee.GetAllDataEmployeeActiveFromDatabase()

        If Not txtsearch.Text = "" Then
            Dim i As Integer
            For i = 0 To DALEmployee.listallemployeeactive.Count - 1
                If (DALEmployee.listallemployeeactive.Item(i).Khmername.ToUpper.Contains(txtsearch.Text.ToUpper) Or DALEmployee.listallemployeeactive.Item(i).Latinname.ToUpper.Contains(txtsearch.Text.ToUpper)) Then
                    dgvmanagedataemployee.Rows.Add(DALEmployee.listallemployeeactive.Item(i).Image, DALEmployee.listallemployee.Item(i).ID, DALEmployee.listallemployeeactive.Item(i).IDcard, DALEmployee.listallemployeeactive.Item(i).Khmername, DALEmployee.listallemployeeactive.Item(i).Latinname, DALEmployee.listallemployeeactive.Item(i).Nation, DALEmployee.listallemployeeactive.Item(i).Nationality, DALEmployee.listallemployeeactive.Item(i).Gender, DALEmployee.listallemployeeactive.Item(i).DOB, DALEmployee.listallemployeeactive.Item(i).Pobroadno & "," & DALEmployee.listallemployeeactive.Item(i).Pobhomeno & "," & DALEmployee.listallemployeeactive.Item(i).Pobvillage & "," & DALEmployee.listallemployeeactive.Item(i).Pobcommube & "," & DALEmployee.listallemployeeactive.Item(i).Pobdistrict & "," & DALEmployee.listallemployeeactive.Item(i).PobProvince, DALEmployee.listallemployeeactive.Item(i).PhoneNumber, DALEmployee.listallemployeeactive.Item(i).Emailaddress, DALEmployee.listallemployeeactive.Item(i).Adnroadno & "," & DALEmployee.listallemployeeactive.Item(i).Adnhomeno & "," & DALEmployee.listallemployeeactive.Item(i).Adnvillage & "," & DALEmployee.listallemployeeactive.Item(i).Adncommune & "," & DALEmployee.listallemployeeactive.Item(i).Adndistrict & "," & DALEmployee.listallemployeeactive.Item(i).Adnprovince, DALEmployee.listallemployeeactive.Item(i).startwork)
                End If
            Next
        End If
        If txtsearch.Text = "" Then
            DALEmployee.listallemployeeactive.Clear()
            DALEmployee.ShowdataactiveemployeeFromDatabase(dgvmanagedataemployee)
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
        For i = 0 To dgvmanagedataemployee.RowCount - 1
            For j = 0 To dgvmanagedataemployee.ColumnCount - 1
                For k As Integer = 1 To dgvmanagedataemployee.Columns.Count
                    xlworksheet.Cells(1, k) = dgvmanagedataemployee.Columns(k - 1).HeaderText
                    xlworksheet.Cells(i + 2, j + 1) = dgvmanagedataemployee(j, i).Value.ToString
                Next
            Next
        Next
        xlworksheet.Rows.Item(1).Font.Bold = 1
        xlworksheet.Rows.Item(1).HorizontalAlignment = 3
        xlworksheet.Columns.AutoFit()
        xlapp.Application.Visible = True
        xlapp.Application.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As New Frmreportallemployee
        x.ShowDialog()
    End Sub
End Class