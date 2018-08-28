Public Class Frmtimetable
    Private Sub Frmtimetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALSchedule.listschedulefromdatabase.Clear()
        DALSchedule.ShowdatascheduleFromDatabase(dgvschedule)
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
        For i = 0 To dgvschedule.RowCount - 1
            For j = 0 To dgvschedule.ColumnCount - 1
                For k As Integer = 1 To dgvschedule.Columns.Count
                    xlworksheet.Cells(1, k) = dgvschedule.Columns(k - 1).HeaderText
                    xlworksheet.Cells(i + 2, j + 1) = dgvschedule(j, i).Value.ToString
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
        Dim x As New FrmReportSchedule
        x.ShowDialog()
    End Sub
End Class