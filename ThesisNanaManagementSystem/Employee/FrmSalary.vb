Public Class FrmSalary
    Public Shared txtsalaryid As String
    Private Sub FrmSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALEmployee.listallsalary.Clear()
        DALEmployee.ShowtotalsalaryFromDatabase(DataGridView1)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        DataGridView1.Rows.Clear()
        DALEmployee.listallsalary.Clear()
        DALEmployee.getallSalaryfromdatabase()
        If Not txtsearch.Text = "" Then
            Dim i As Integer
            For i = 0 To DALEmployee.listallsalary.Count - 1
                If (DALEmployee.listallsalary.Item(i).Khmername.ToUpper.Contains(txtsearch.Text.ToUpper) Or DALEmployee.listallsalary.Item(i).Latinname.ToUpper.Contains(txtsearch.Text.ToUpper)) Then
                    DataGridView1.Rows.Add(DALEmployee.listallsalary.Item(i).Image, DALEmployee.listallsalary.Item(i).ID, DALEmployee.listallsalary.Item(i).IDcard, DALEmployee.listallsalary.Item(i).Khmername, DALEmployee.listallsalary.Item(i).Latinname, DALEmployee.listallsalary.Item(i).Nation, DALEmployee.listallsalary.Item(i).Gender, DALEmployee.listallsalary.Item(i).DOB, DALEmployee.listallsalary.Item(i).startwork, DALEmployee.listallsalary.Item(i).totalsalary, DALEmployee.listallsalary.Item(i).Descriptions)
                End If

            Next
        End If
        If txtsearch.Text = "" Then
            DALEmployee.listallsalary.Clear()
            DALEmployee.ShowtotalsalaryFromDatabase(DataGridView1)
        End If
    End Sub
    Private Sub Filldatatxtempid()
        Dim empid As String = DataGridView1.CurrentRow.Cells(1).Value
        Try
            DALEmployee.listallsalary.Clear()
            DALEmployee.getallSalaryfromdatabase()
            Dim i As Integer
            For i = 0 To DALEmployee.listallsalary.Count - 1
                If DALEmployee.listallsalary.Item(i).ID = empid.ToString Then
                    txtsalaryid = DALEmployee.listallsalary.Item(i).Srid
                    Return
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call Filldatatxtempid()
        Dim frm As New FrmDetailSalary
        frm.ShowDialog()


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        DALEmployee.listallsalary.Clear()
        DALEmployee.getallSalaryfromdatabase()
        If Not txtsearch.Text = "" Then
            Dim i As Integer
            For i = 0 To DALEmployee.listallsalary.Count - 1
                If (DALEmployee.listallsalary.Item(i).Khmername.ToUpper.Contains(txtsearch.Text.ToUpper) Or DALEmployee.listallsalary.Item(i).Latinname.ToUpper.Contains(txtsearch.Text.ToUpper)) Then
                    DataGridView1.Rows.Add(DALEmployee.listallsalary.Item(i).Image, DALEmployee.listallsalary.Item(i).ID, DALEmployee.listallsalary.Item(i).IDcard, DALEmployee.listallsalary.Item(i).Khmername, DALEmployee.listallsalary.Item(i).Latinname, DALEmployee.listallsalary.Item(i).Nation, DALEmployee.listallsalary.Item(i).Gender, DALEmployee.listallsalary.Item(i).DOB, DALEmployee.listallsalary.Item(i).startwork, DALEmployee.listallsalary.Item(i).totalsalary, DALEmployee.listallsalary.Item(i).Descriptions)
                End If

            Next
        End If
        If txtsearch.Text = "" Then
            DALEmployee.listallsalary.Clear()
            DALEmployee.ShowtotalsalaryFromDatabase(DataGridView1)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Rows.Clear()
        DALEmployee.listallsalary.Clear()
        DALEmployee.getallSalaryfromdatabase()
        If Not txtsearch.Text = "" Then
            Dim i As Integer
            For i = 0 To DALEmployee.listallsalary.Count - 1
                If (DALEmployee.listallsalary.Item(i).Khmername.ToUpper.Contains(txtsearch.Text.ToUpper) Or DALEmployee.listallsalary.Item(i).Latinname.ToUpper.Contains(txtsearch.Text.ToUpper)) Then
                    DataGridView1.Rows.Add(DALEmployee.listallsalary.Item(i).Image, DALEmployee.listallsalary.Item(i).ID, DALEmployee.listallsalary.Item(i).IDcard, DALEmployee.listallsalary.Item(i).Khmername, DALEmployee.listallsalary.Item(i).Latinname, DALEmployee.listallsalary.Item(i).Nation, DALEmployee.listallsalary.Item(i).Gender, DALEmployee.listallsalary.Item(i).DOB, DALEmployee.listallsalary.Item(i).startwork, DALEmployee.listallsalary.Item(i).totalsalary, DALEmployee.listallsalary.Item(i).Descriptions)
                End If

            Next
        End If
        If txtsearch.Text = "" Then
            DALEmployee.listallsalary.Clear()
            DALEmployee.ShowtotalsalaryFromDatabase(DataGridView1)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xlapp As Microsoft.Office.Interop.Excel.Application
        Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misvalue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlapp = New Microsoft.Office.Interop.Excel.Application
        xlworkbook = xlapp.Workbooks.Add(misvalue)
        xlworksheet = xlworkbook.Sheets("sheet1")
        For i = 0 To DataGridView1.RowCount - 1
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlworksheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlworksheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString
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