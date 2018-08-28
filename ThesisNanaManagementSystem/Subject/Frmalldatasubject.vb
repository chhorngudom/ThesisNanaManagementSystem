Public Class Frmalldatasubject
    Private Sub Frmalldatasubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALSubject.listsubjectfromdatabase.Clear()
        DALSubject.ShowdatasubjectFromDatabase(dgvsubject)
        DALSubject.FilldatatoCombobox(cbosortpartname)
    End Sub

    Private Sub cbosortpartname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbosortpartname.KeyPress

    End Sub

    Private Sub cbosortpartname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosortpartname.SelectedIndexChanged
        dgvsubject.Rows.Clear()
        DALSubject.listsubjectfromdatabase.Clear()
        DALSubject.GetDatasubjectFromDatabase()

        If Not cbosortpartname.Text = "" Then
            Dim i As Integer
            For i = 0 To DALSubject.listsubjectfromdatabase.Count - 1
                If DALSubject.listsubjectfromdatabase.Item(i).partid.ToUpper.Contains(cbosortpartname.Text.ToString.ToUpper) Then
                    dgvsubject.Rows.Add(DALSubject.listsubjectfromdatabase.Item(i).Id, DALSubject.listsubjectfromdatabase.Item(i).partid, DALSubject.listsubjectfromdatabase.Item(i).subject, DALSubject.listsubjectfromdatabase.Item(i).description)
                End If

            Next
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
        For i = 0 To dgvsubject.RowCount - 1
            For j = 0 To dgvsubject.ColumnCount - 1
                For k As Integer = 1 To dgvsubject.Columns.Count
                    xlworksheet.Cells(1, k) = dgvsubject.Columns(k - 1).HeaderText
                    xlworksheet.Cells(i + 2, j + 1) = dgvsubject(j, i).Value.ToString
                Next
            Next
        Next
        xlworksheet.Rows.Item(1).Font.Bold = 1
        xlworksheet.Rows.Item(1).HorizontalAlignment = 3
        xlworksheet.Columns.AutoFit()
        xlapp.Application.Visible = True
        xlapp.Application.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
    End Sub

    Private Sub cbosortpartname_TextChanged(sender As Object, e As EventArgs) Handles cbosortpartname.TextChanged
        If cbosortpartname.Text = "" Then
            dgvsubject.Rows.Clear()
            DALSubject.listsubjectfromdatabase.Clear()
            DALSubject.ShowdatasubjectFromDatabase(dgvsubject)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As New FrmReportSubject
        x.ShowDialog()
    End Sub
End Class