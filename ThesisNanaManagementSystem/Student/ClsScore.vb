Public Class ClsScore
    Inherits ClsStudent
    Private _scoreid As String
    Private _score As Double
    Private _desc As String
    Private _status As String
    Public Property scoreid As String
        Get
            Return _scoreid
        End Get
        Set(value As String)
            Me._scoreid = value
        End Set
    End Property
    Public Property score As Double
        Get
            Return _score
        End Get
        Set(value As Double)
            Me._score = value
        End Set
    End Property
    Public Property description As String
        Get
            Return _desc
        End Get
        Set(value As String)
            Me._desc = value
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
