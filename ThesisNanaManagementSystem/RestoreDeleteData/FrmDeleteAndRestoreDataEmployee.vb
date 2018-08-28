Imports System.IO
Public Class FrmDeleteAndRestoreDataEmployee
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FrmDeleteAndRestoreDataEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DALEmployee.listallstopwork.Clear()
        DALEmployee.ShowdatastopworkFromDatabase(dgvdeleteemployee, "getdataemployeedelete")
    End Sub

    Private Sub dgvdeleteemployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdeleteemployee.CellContentClick
        Dim img() As Byte
        img = dgvdeleteemployee.CurrentRow.Cells(0).Value
        Dim ms As New MemoryStream(img)
        PictureBox1.Image = Image.FromStream(ms)
        txtid.Text = dgvdeleteemployee.CurrentRow.Cells(1).Value
        txtidcard.Text = dgvdeleteemployee.CurrentRow.Cells(2).Value
        txtname.Text = dgvdeleteemployee.CurrentRow.Cells(3).Value
        txtnation.Text = dgvdeleteemployee.CurrentRow.Cells(4).Value
        cbogender.Text = dgvdeleteemployee.CurrentRow.Cells(5).Value
        dtpdob.Text = dgvdeleteemployee.CurrentRow.Cells(6).Value
        dtpstartwork.Text = dgvdeleteemployee.CurrentRow.Cells(9).Value
        dtpstopwork.Text = dgvdeleteemployee.CurrentRow.Cells(10).Value
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.Image = Nothing
        txtid.Clear()
        txtidcard.Clear()
        txtname.Clear()
        txtnation.Clear()
        cbogender.Text = ""
        dtpdob.Text = ""
        dtpstartwork.Text = ""
        dtpstopwork.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtid.Text.Equals("") Then
                MessageBox.Show("សូមជ្រើសរើសទិន្នន័យដើម្បីធ្វើការលុប!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            DALEmployee.DeleteDataemployee("deletedataemployee", "Delete Permanently", txtid.Text)
            MessageBox.Show("ទិន្នន័យត្រូវបានលុបចេញពី Database!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DALEmployee.listallstopwork.Clear()
            DALEmployee.ShowdatastopworkFromDatabase(dgvdeleteemployee, "getdataemployeedelete")
            PictureBox1.Image = Nothing
            txtid.Clear()
            txtidcard.Clear()
            txtname.Clear()
            txtnation.Clear()
            cbogender.Text = ""
            dtpdob.Text = ""
            dtpstartwork.Text = ""
            dtpstopwork.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtid.Text.Equals("") Then
                MessageBox.Show("សូមជ្រើសរើសទិន្នន័យដើម្បីធ្វើការ RESTORE!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            DALEmployee.DeleteDataemployee("deletedataemployee", "Active", txtid.Text)
            MessageBox.Show("ទិន្នន័យត្រូវបាន RESTORE!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DALEmployee.listallstopwork.Clear()
            DALEmployee.ShowdatastopworkFromDatabase(dgvdeleteemployee, "getdataemployeedelete")
            PictureBox1.Image = Nothing
            txtid.Clear()
            txtidcard.Clear()
            txtname.Clear()
            txtnation.Clear()
            cbogender.Text = ""
            dtpdob.Text = ""
            dtpstartwork.Text = ""
            dtpstopwork.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class