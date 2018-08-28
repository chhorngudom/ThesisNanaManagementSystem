Public Class ClsSubject
    Private _id As String
    Private _partid As String
    Private _subject As String
    Private _desc As String

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            Me._id = value
        End Set
    End Property
    Public Property partid As String
        Get
            Return _partid
        End Get
        Set(value As String)
            Me._partid = value
        End Set
    End Property
    Public Property subject As String
        Get
            Return _subject
        End Get
        Set(value As String)
            Me._subject = value
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
End Class
