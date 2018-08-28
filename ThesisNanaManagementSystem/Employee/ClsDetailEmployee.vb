Public Class ClsDetailEmployee
    Private _dtempid As String
    Private _empid As String
    Private _srid As String
    Private _termid As String
    Private _desc As String
    Public Property Dtempid As String
        Get
            Return _dtempid
        End Get
        Set(value As String)
            Me._dtempid = value
        End Set
    End Property
    Public Property empid As String
        Get
            Return _empid
        End Get
        Set(value As String)
            Me._empid = value
        End Set
    End Property
    Public Property Termid As String
        Get
            Return _termid
        End Get
        Set(value As String)
            Me._termid = value
        End Set
    End Property
    Public Property Srid As String
        Get
            Return _srid
        End Get
        Set(value As String)
            Me._srid = value
        End Set
    End Property
    Public Property Description As String
        Get
            Return _desc
        End Get
        Set(value As String)
            Me._desc = value
        End Set
    End Property
End Class
