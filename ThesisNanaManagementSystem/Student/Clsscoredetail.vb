Public Class Clsscoredetail
    Inherits ClsStudent
    Private _scoredetailid As String
    Private _scoreid As String
    Private _typeexam As String
    Private _score As Double
    Private _date As String
    Private _description As String
    Private _status As String
    Public Property scoredetailid As String
        Get
            Return _scoredetailid
        End Get
        Set(value As String)
            Me._scoredetailid = value
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
    Public Property typeexam As String
        Get
            Return _typeexam
        End Get
        Set(value As String)
            Me._typeexam = value
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
    Public Property Dates As String
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
