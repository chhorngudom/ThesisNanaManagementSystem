Public Class Clsdaystudy
    Private _id As String
    Private _startday As String
    Private _endday As String
    Private _des As String
    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            Me._id = value
        End Set
    End Property
    Public Property startday As String
        Get
            Return _startday
        End Get
        Set(value As String)
            Me._startday = value
        End Set
    End Property
    Public Property endday As String
        Get
            Return _endday
        End Get
        Set(value As String)
            Me._endday = value
        End Set
    End Property
    Public Property Desc As String
        Get
            Return _des
        End Get
        Set(value As String)
            Me._des = value
        End Set
    End Property
End Class
