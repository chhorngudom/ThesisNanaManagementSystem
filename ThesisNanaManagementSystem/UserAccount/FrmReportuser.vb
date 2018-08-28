Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Public Class FrmReportuser
    Dim cry As New ReportDocument
    Dim connection As New SqlConnection(ClsConnection.ConnectDb)
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        cry.Load("F:\Document Major Computer Science\Document Thesis\System Thesis NANAManagement information system\ThesisNanaManagementSystem\ThesisNanaManagementSystem\UserAccount\ReportAllUser.rpt")
        '      cry.Load("G:\Document\Documentation Programming\VB.Net Programming\Projects\EmployeeManagementSystemUsingVB.Net\EmployeeManagementSystemUsingVB.Net\CrystalReport1.rpt")
        'Dim StringSearchSql = "Select * from tblEmployee Where EmployeeID =N'" & Form1.ID & "'"
        'connection.Open()
        'Dim StringSearchSql = "Select * from tblUserAccount"
        'Dim adapter As New SqlDataAdapter(StringSearchSql, connection)
        'Dim ds As New DataSet
        'adapter.Fill(ds, "tblUserAccount")
        'cry.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = cry
    End Sub

    Private Sub FrmReportuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class