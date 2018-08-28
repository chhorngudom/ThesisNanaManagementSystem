Public Class ClsUserAccount
    Private _id As String
    Private _usertype As String
    Private _username As String
    Private _password As String
    Private _manageuseraccount As String
    Private _managedatastudent As String
    Private _managedataemployee As String
    Private _managedatasubject As String
    Private _managedataschedule As String
    Private _managedata As String
    Private _image As Byte()

    Public Property id() As String
        Get
            Return _id
        End Get
        Set(value As String)
            Me._id = value
        End Set
    End Property
    Public Property usertype() As String
        Get
            Return _usertype
        End Get
        Set(value As String)
            Me._usertype = value
        End Set
    End Property
    Public Property username() As String
        Get
            Return _username
        End Get
        Set(value As String)
            Me._username = value
        End Set
    End Property
    Public Property password() As String
        Get
            Return _password
        End Get
        Set(value As String)
            Me._password = value
        End Set
    End Property
    Public Property manageuseraccount() As String
        Get
            Return _manageuseraccount
        End Get
        Set(value As String)
            Me._manageuseraccount = value
        End Set
    End Property
    Public Property managedatastudent() As String
        Get
            Return _managedatastudent
        End Get
        Set(value As String)
            Me._managedatastudent = value
        End Set
    End Property
    Public Property managedataemployee() As String
        Get
            Return _managedataemployee
        End Get
        Set(value As String)
            Me._managedataemployee = value
        End Set
    End Property
    Public Property managedatasubject() As String
        Get
            Return _managedatasubject
        End Get
        Set(value As String)
            Me._managedatasubject = value
        End Set
    End Property
    Public Property managedataschedule() As String
        Get
            Return _managedataschedule
        End Get
        Set(value As String)
            Me._managedataschedule = value
        End Set
    End Property
    Public Property managedata() As String
        Get
            Return _managedata
        End Get
        Set(value As String)
            Me._managedata = value
        End Set
    End Property
    Public Property Image() As Byte()
        Get
            Return _image
        End Get
        Set(value As Byte())
            Me._image = value
        End Set
    End Property
End Class
