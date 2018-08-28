Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Public Class Frmreportallemployee
    Dim cry As New ReportDocument
    Dim connection As New SqlConnection(ClsConnection.ConnectDb)
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        cry.Load("C:\Users\Chhorng Udom\Documents\Visual Studio 2015\Projects\ThesisNanaManagementSystem\ThesisNanaManagementSystem\Employee\Reportallemployeee.rpt")
        'Dim StringSearchSql = "Select * from tblEmployee Where EmployeeID =N'" & Form1.ID & "'"
        ''   Dim commad As New SqlCommand(StringSearchSql, connection)
        'Dim adapter As New SqlDataAdapter(StringSearchSql, connection)
        ''  Dim adapter As New SqlDataAdapter("FilterDateEmployee", connection)
        '' adapter.SelectCommand.CommandType = CommandType.StoredProcedure
        ''   adapter.SelectCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = TextBox1.Text.ToString
        'Dim ds As New DataSet
        'adapter.Fill(ds, "tblEmployee")
        'cry.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = cry
    End Sub

    Private Sub Frmreportallemployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class