Public Class ClsDetailSalary
    Inherits ClsEmploye
    Private _dtsid As String
    Private _srids As String
    Private _amount As Double
    Private _dategetsalary As String
    Private _des As String
    Private _status As String

    Public Property DetailSalaryID As String
        Get
            Return _dtsid
        End Get
        Set(value As String)
            Me._dtsid = value
        End Set
    End Property
    Public Property srid As String
        Get
            Return _srids
        End Get
        Set(value As String)
            Me._srids = value
        End Set
    End Property
    Public Property Amount As Double
        Get
            Return _amount
        End Get
        Set(value As Double)
            Me._amount = value
        End Set
    End Property
    Public Property dategetsalary As String
        Get
            Return _dategetsalary
        End Get
        Set(value As String)
            Me._dategetsalary = value
        End Set
    End Property
    Public Property Descriptiondts As String
        Get
            Return _des
        End Get
        Set(value As String)
            Me._des = value
        End Set
    End Property
    Public Property Statusds As String
        Get
            Return _status
        End Get
        Set(value As String)
            Me._status = value
        End Set
    End Property
End Class
