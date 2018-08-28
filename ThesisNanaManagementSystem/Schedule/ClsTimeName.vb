Public Class ClsTimeName
    Private _idname As String
    Private _name As String
    Private _desc As String
    Public Property IdName() As String
        Get
            Return _idname
        End Get
        Set(value As String)
            Me._idname = value
        End Set
    End Property
    Public Property TimeName() As String
        Get
            Return _name
        End Get
        Set(value As String)
            Me._name = value
        End Set
    End Property
    Public Property Description() As String
        Get
            Return _desc
        End Get
        Set(value As String)
            Me._desc = value
        End Set
    End Property
End Class
