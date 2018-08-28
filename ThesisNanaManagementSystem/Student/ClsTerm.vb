Public Class ClsTerm
    Inherits ClsStudent
    Private _termid As String
    Private _startdate As String
    Private _enddate As String
    Private _certificate As String
    Private _dategetcertificate As String
    Private _description As String
    Private _status As String
    Public Property termid As String
        Get
            Return _termid
        End Get
        Set(value As String)
            Me._termid = value
        End Set
    End Property
    Public Property startdate As String
        Get
            Return _startdate
        End Get
        Set(value As String)
            Me._startdate = value
        End Set
    End Property
    Public Property enddate As String
        Get
            Return _enddate
        End Get
        Set(value As String)
            Me._enddate = value
        End Set
    End Property
    Public Property certificate As String
        Get
            Return _certificate
        End Get
        Set(value As String)
            Me._certificate = value
        End Set
    End Property
    Public Property dategetcertificate As String
        Get
            Return _dategetcertificate
        End Get
        Set(value As String)
            Me._dategetcertificate = value
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
