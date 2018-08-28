Public Class ClsAttDetail
    Inherits ClsStudent
    Private _attdetailid As String
    Private _attid As String
    Private _att As String
    Private _date As String
    Private _description As String
    Private _status As String
    Public Property attdetailid As String
        Get
            Return _attdetailid
        End Get
        Set(value As String)
            Me._attdetailid = value
        End Set
    End Property
    Public Property attid As String
        Get
            Return _attid
        End Get
        Set(value As String)
            Me._attid = value
        End Set
    End Property
    Public Property att As String
        Get
            Return _att
        End Get
        Set(value As String)
            Me._att = value
        End Set
    End Property
    Public Property dates As String
        Get
            Return _date
        End Get
        Set(value As String)
            Me._date = value
        End Set
    End Property
    Public Property description As String
        Get
            Return _description
        End Get
        Set(value As String)
            Me._description = value
        End Set
    End Property
    Public Property status As String
        Get
            Return _status
        End Get
        Set(value As String)
            Me._status = value
        End Set
    End Property
End Class
