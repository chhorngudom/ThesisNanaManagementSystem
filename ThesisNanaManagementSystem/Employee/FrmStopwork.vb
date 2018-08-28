Imports System.IO
Public Class FrmStopwork
    Private txttermid As String
    Private Sub FrmStopwork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALEmployee.listallstopwork.Clear()
        DALEmployee.ShowdatastopworkFromDatabase(dgvstopwork, "getdatastopwork")
        cboshowdata.Text = "បុគ្គលិកទាំងអស់"
        dtpdategetcertificate.Text.Equals("")
    End Sub
    Private Sub Filltxttermid()
        Try
            'DALEmployee.listallstopwork.Clear()
            'DALEmployee.getalldatastopworkfromdatabase()
            Dim i As Integer
            For i = 0 To DALEmployee.listallstopwork.Count - 1
                If DALEmployee.listallstopwork.Item(i).ID = txtid.Text.ToString Then
                    txttermid = DALEmployee.listallstopwork.Item(i).StopworkId
                    Return
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbocertificate.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub dgvstopwork_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvstopwork.CellContentClick
        Dim img() As Byte
        img = dgvstopwork.CurrentRow.Cells(0).Value
        Dim ms As New MemoryStream(img)
        pimage.Image = Image.FromStream(ms)
        txtid.Text = dgvstopwork.CurrentRow.Cells(1).Value
        txtidcard.Text = dgvstopwork.CurrentRow.Cells(2).Value
        txtname.Text = dgvstopwork.CurrentRow.Cells(3).Value
        txtnation.Text = dgvstopwork.CurrentRow.Cells(4).Value
        txtgender.Text = dgvstopwork.CurrentRow.Cells(5).Value
        dtpstartwork.Text = dgvstopwork.CurrentRow.Cells(9).Value
        dtpstopwork.Text = dgvstopwork.CurrentRow.Cells(10).Value
        cbocertificate.Text = dgvstopwork.CurrentRow.Cells(11).Value
        dtpdategetcertificate.Text = dgvstopwork.CurrentRow.Cells(12).Value
        txtdesc.Text = dgvstopwork.CurrentRow.Cells(13).Value

    End Sub

    Private Sub cboshowdata_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboshowdata.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboshowdata_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboshowdata.SelectedIndexChanged
        If cboshowdata.Text = "បុគ្គលិកឈប់ធ្វើការ" Then
            DALEmployee.listalldatastopworkDelete.Clear()
            DALEmployee.ShowdatastopworkdeleteFromDatabase(dgvstopwork)
        Else
            DALEmployee.listallstopwork.Clear()
            DALEmployee.ShowdatastopworkFromDatabase(dgvstopwork, "getdatastopwork")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        dgvstopwork.Rows.Clear()
        DALEmployee.listallstopwork.Clear()
        DALEmployee.listalldatastopworkDelete.Clear()
        DALEmployee.getalldatastopworkdeletefromdatabase()
        DALEmployee.getalldatastopworkfromdatabase("getdatastopwork")
        If cboshowdata.Text = "បុគ្គលិកឈប់ធ្វើការ" Then
            If Not txtsearch.Text = "" Then
                Dim i As Integer
                For i = 0 To DALEmployee.listalldatastopworkDelete.Count - 1
                    If (DALEmployee.listalldatastopworkDelete.Item(i).Khmername.ToUpper.Contains(txtsearch.Text.ToUpper)) Then
                        dgvstopwork.Rows.Add(DALEmployee.listalldatastopworkDelete.Item(i).Image, DALEmployee.listalldatastopworkDelete.Item(i).ID, DALEmployee.listalldatastopworkDelete.Item(i).IDcard, DALEmployee.listalldatastopworkDelete.Item(i).Khmername, DALEmployee.listalldatastopworkDelete.Item(i).Nation, DALEmployee.listalldatastopworkDelete.Item(i).Gender, DALEmployee.listalldatastopworkDelete.Item(i).DOB, DALEmployee.listalldatastopworkDelete.Item(i).PhoneNumber, DALEmployee.listalldatastopworkDelete.Item(i).Emailaddress, DALEmployee.listalldatastopworkDelete.Item(i).Startworksw, DALEmployee.listalldatastopworkDelete.Item(i).Stopwork, DALEmployee.listalldatastopworkDelete.Item(i).Certificate, DALEmployee.listalldatastopworkDelete.Item(i).Dateget, DALEmployee.listalldatastopworkDelete.Item(i).Descriptionsw)
                    End If

                Next
            End If
            If txtsearch.Text = "" Then
                DALEmployee.listalldatastopworkDelete.Clear()
                DALEmployee.ShowdatastopworkdeleteFromDatabase(dgvstopwork)
            End If
        End If
        If cboshowdata.Text = "បុគ្គលិកទាំងអស់" Then
            If Not txtsearch.Text = "" Then
                Dim i As Integer
                For i = 0 To DALEmployee.listallstopwork.Count - 1
                    If (DALEmployee.listallstopwork.Item(i).Khmername.ToUpper.Contains(txtsearch.Text.ToUpper)) Then
                        dgvstopwork.Rows.Add(DALEmployee.listallstopwork.Item(i).Image, DALEmployee.listallstopwork.Item(i).ID, DALEmployee.listallstopwork.Item(i).IDcard, DALEmployee.listallstopwork.Item(i).Khmername, DALEmployee.listallstopwork.Item(i).Nation, DALEmployee.listallstopwork.Item(i).Gender, DALEmployee.listallstopwork.Item(i).DOB, DALEmployee.listallstopwork.Item(i).PhoneNumber, DALEmployee.listallstopwork.Item(i).Emailaddress, DALEmployee.listallstopwork.Item(i).Startworksw, DALEmployee.listallstopwork.Item(i).Stopwork, DALEmployee.listallstopwork.Item(i).Certificate, DALEmployee.listallstopwork.Item(i).Dateget, DALEmployee.listallstopwork.Item(i).Descriptionsw)
                    End If

                Next
            End If
            If txtsearch.Text = "" Then
                DALEmployee.listallstopwork.Clear()
                DALEmployee.ShowdatastopworkFromDatabase(dgvstopwork, "getdatastopwork")
            End If
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtid.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសទិន្នន័យដើម្បីធ្វើការកែប្រែទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If cbocertificate.Text.Equals("") Then
            MessageBox.Show("សូមជ្រើសរើសទិន្នន័យ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbocertificate.Focus()
            Return
        End If
        Filltxttermid()
        DALStudent.adddatatermtodatabase("updatedataterm", txttermid, dtpstartwork.Text.ToString, dtpstopwork.Text.ToString, cbocertificate.Text.ToString, dtpdategetcertificate.Text.ToString, txtdesc.Text.ToString, "Delete")
        MessageBox.Show("ទិន្នន័យត្រូវបានរក្សាទុកនៅក្នុង Database រួចរាល់!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If cboshowdata.Text = "បុគ្គលិកឈប់ធ្វើការ" Then

            DALEmployee.listalldatastopworkDelete.Clear()
            DALEmployee.ShowdatastopworkdeleteFromDatabase(dgvstopwork)
        Else
            DALEmployee.listallstopwork.Clear()
            DALEmployee.ShowdatastopworkFromDatabase(dgvstopwork, "getdatastopwork")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtid.Clear()
        txtidcard.Clear()
        txtname.Clear()
        txtnation.Clear()
        txtgender.Clear()
        dtpstartwork.Text = ""
        dtpstopwork.Text = ""
        cbocertificate.Text = ""
        dtpdategetcertificate.Text = ""
        txtdesc.Clear()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

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
        For i = 0 To dgvstopwork.RowCount - 1
            For j = 0 To dgvstopwork.ColumnCount - 1
                For k As Integer = 1 To dgvstopwork.Columns.Count
                    xlworksheet.Cells(1, k) = dgvstopwork.Columns(k - 1).HeaderText
                    xlworksheet.Cells(i + 2, j + 1) = dgvstopwork(j, i).Value.ToString
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