Imports System.IO
Public Class FrmDetailSalary
    Private txtdetailid As String
    Private txtsalarydetailid As String
    Private Sub FrmDetailSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALEmployee.listalldetailsalary.Clear()
        DALEmployee.ShowdatadetailsalaryFromDatabase(dgvdetailsalary, FrmSalary.txtsalaryid.ToString)
    End Sub
    Private Sub Filltxtdetailsalaryid()
        Try
            'DALEmployee.listallstopwork.Clear()
            'DALEmployee.getalldatastopworkfromdatabase()
            Dim i As Integer
            For i = 0 To DALEmployee.listalldetailsalary.Count - 1
                If DALEmployee.listalldetailsalary.Item(i).ID = txtid.Text.ToString Then
                    txtdetailid = DALEmployee.listalldetailsalary.Item(i).DetailSalaryID
                    Return
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Filltxtdetailsrid()
        DALEmployee.listalldetailsalary.Clear()
        DALEmployee.getallDetailSalaryfromdatabase()
        txtsalarydetailid = "បខល" & DALEmployee.listalldetailsalary.Count + 1
    End Sub
    Public Sub clear()
        txtid.Clear()
        txtname.Clear()
        nation.Clear()
        cbogender.Text = ""
        dtpstartwork.Text = ""
        txtamount.Clear()
        dtpdategetsalary.Text = ""
        txtdesc.Clear()
        pimage.Image = Nothing
        dtpstartwork.Focus()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសទិន្នន័យដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If txtamount.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលចំនួនប្រាក់ខែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtamount.Focus()
            Return
        End If
        Filltxtdetailsalaryid()
        DALEmployee.addUpdatedetailsalarytpdatabase("updatedatadetailsalary", txtdetailid.ToString, FrmSalary.txtsalaryid.ToString, txtamount.Text.ToString, dtpdategetsalary.Text.ToString, txtdesc.Text.ToString)
        MessageBox.Show("ទិន្នន័យត្រូវបានរក្សាទុកនៅក្នុង Database រួចរាល់!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DALEmployee.listalldetailsalary.Clear()
        DALEmployee.ShowdatadetailsalaryFromDatabase(dgvdetailsalary, FrmSalary.txtsalaryid.ToString)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgvdetailsalary_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdetailsalary.CellContentClick
        Dim img() As Byte
        img = dgvdetailsalary.CurrentRow.Cells(0).Value
        Dim ms As New MemoryStream(img)
        pimage.Image = Image.FromStream(ms)
        txtid.Text = dgvdetailsalary.CurrentRow.Cells(1).Value
        txtname.Text = dgvdetailsalary.CurrentRow.Cells(3).Value
        nation.Text = dgvdetailsalary.CurrentRow.Cells(4).Value
        cbogender.Text = dgvdetailsalary.CurrentRow.Cells(5).Value
        dtpstartwork.Text = dgvdetailsalary.CurrentRow.Cells(9).Value
        txtamount.Text = dgvdetailsalary.CurrentRow.Cells(10).Value
        dtpdategetsalary.Text = dgvdetailsalary.CurrentRow.Cells(11).Value
        txtdesc.Text = dgvdetailsalary.CurrentRow.Cells(12).Value

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbogender.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសទិន្នន័យដើម្បីធ្វើការបន្ថែមទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If txtamount.Text.Equals("") Then
            MessageBox.Show("សូមបញ្ចូលចំនួនប្រាក់ខែ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtamount.Focus()
            Return
        End If
        Filltxtdetailsalaryid()
        Call Filltxtdetailsrid()
        DALEmployee.addUpdatedetailsalarytpdatabase("addsalarydetail", txtsalarydetailid.ToString, FrmSalary.txtsalaryid.ToString, txtamount.Text.ToString, dtpdategetsalary.Text.ToString, txtdesc.Text.ToString)
        MessageBox.Show("ទិន្នន័យត្រូវបានបន្ថែមទៅក្នុង Database រួចរាល់!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DALEmployee.listalldetailsalary.Clear()
        DALEmployee.ShowdatadetailsalaryFromDatabase(dgvdetailsalary, FrmSalary.txtsalaryid.ToString)
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
        For i = 0 To dgvdetailsalary.RowCount - 1
            For j = 0 To dgvdetailsalary.ColumnCount - 1
                For k As Integer = 1 To dgvdetailsalary.Columns.Count
                    xlworksheet.Cells(1, k) = dgvdetailsalary.Columns(k - 1).HeaderText
                    xlworksheet.Cells(i + 2, j + 1) = dgvdetailsalary(j, i).Value.ToString
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