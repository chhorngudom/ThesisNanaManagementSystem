Public Class ClsPartsubject
    Private _id As String
    Private _partname As String
    Private _desc As String

    Public Property ID As String
        Get
            Return _id
        End Get
        Set(value As String)
            Me._id = value
        End Set
    End Property
    Public Property partname As String
        Get
            Return _partname
        End Get
        Set(value As String)
            Me._partname = value
        End Set
    End Property
    Public Property des As String
        Get
            Return _desc
        End Get
        Set(value As String)
            Me._desc = value
        End Set
    End Property
End Class


