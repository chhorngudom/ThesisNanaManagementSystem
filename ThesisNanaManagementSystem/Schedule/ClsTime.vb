Public Class ClsTime
    Private _Timeid As String
    Private _startstudy As String
    Private _endtime As String
    Private _desc As String

    Public Property TimeId() As String
        Get
            Return _Timeid
        End Get
        Set(value As String)
            Me._Timeid = value
        End Set
    End Property
    Public Property starttime As String
        Get
            Return _startstudy
        End Get
        Set(value As String)
            Me._startstudy = value
        End Set
    End Property
    Public Property endtime As String
        Get
            Return _endtime
        End Get
        Set(value As String)
            Me._endtime = value
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
