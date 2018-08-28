Public Class ClsAttandant
    Inherits ClsStudent
    Private _attid As String
    Private _description As String
    Private _status As String
    Public Property atttid As String
        Get
            Return _attid
        End Get
        Set(value As String)
            Me._attid = value
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
