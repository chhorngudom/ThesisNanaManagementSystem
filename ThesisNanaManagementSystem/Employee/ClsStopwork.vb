Public Class ClsStopwork
    Inherits ClsEmploye
    Private _swid As String
    Private _startwork As String
    Private _stopwork As String
    Private _certificate As String
    Private _dategetcertificate As String
    Private _desc As String

    Public Property StopworkId As String
        Get
            Return _swid
        End Get
        Set(value As String)
            Me._swid = value
        End Set
    End Property
    Public Property Startworksw As String
        Get
            Return _startwork
        End Get
        Set(value As String)
            Me._startwork = value
        End Set
    End Property
    Public Property Stopwork As String
        Get
            Return _stopwork
        End Get
        Set(value As String)
            Me._stopwork = value
        End Set
    End Property
    Public Property Certificate As String
        Get
            Return _certificate
        End Get
        Set(value As String)
            Me._certificate = value
        End Set
    End Property
    Public Property Dateget As String
        Get
            Return _dategetcertificate
        End Get
        Set(value As String)
            Me._dategetcertificate = value
        End Set
    End Property
    Public Property Descriptionsw As String
        Get
            Return _desc
        End Get
        Set(value As String)
            Me._desc = value
        End Set
    End Property

End Class
