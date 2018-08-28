Public Class ClsSalary
    Inherits ClsEmploye
    Private _srid As String
    Private _totalsalary As Double
    Private _description As String
    Private _status As String
    Public Property Srid As String
        Get
            Return _srid
        End Get
        Set(value As String)
            Me._srid = value
        End Set
    End Property
    Public Property totalsalary As String
        Get
            Return _totalsalary
        End Get
        Set(value As String)
            Me._totalsalary = value
        End Set
    End Property
    Public Property Descriptions As String
        Get
            Return _description
        End Get
        Set(value As String)
            Me._description = value
        End Set
    End Property
    Public Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            Me._status = value
        End Set
    End Property
End Class
