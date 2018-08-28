Public Class ClsDetailstudent
    Inherits ClsStudent
    Private _detailstudentid As String
    Private _sdid As String
    Private _Teacherid As String
    Private _studentid As String
    Private _termid As String
    Private _attid As String
    Private _scoreid As String
    Private _paymentid As String
    Private _description As String
    Private _status As String
    Public Property detailstudentid As String
        Get
            Return _detailstudentid
        End Get
        Set(value As String)
            Me._detailstudentid = value
        End Set
    End Property
    Public Property sdid As String
        Get
            Return _sdid
        End Get
        Set(value As String)
            Me._sdid = value
        End Set
    End Property
    Public Property teacherid As String
        Get
            Return _Teacherid
        End Get
        Set(value As String)
            Me._Teacherid = value
        End Set
    End Property
    Public Property studentid As String
        Get
            Return _studentid
        End Get
        Set(value As String)
            Me._studentid = value
        End Set
    End Property
    Public Property termid As String
        Get
            Return _termid
        End Get
        Set(value As String)
            Me._termid = value
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
    Public Property scoreid As String
        Get
            Return _scoreid
        End Get
        Set(value As String)
            Me._scoreid = value
        End Set
    End Property
    Public Property paymentid As String
        Get
            Return _paymentid
        End Get
        Set(value As String)
            Me._paymentid = value
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
