Public Class ClsStudent
    Private _id As String
    Private _idcard As String
    Private _namekhmer As String
    Private _namelatin As String
    Private _nation As String
    Private _nationality As String
    Private _gender As String
    Private _dob As String
    Private _phonenumber As String
    Private _emailaddress As String
    Private _roadnopob As String
    Private _homenopob As String
    Private _villagepob As String
    Private _commubepob As String
    Private _districtpob As String
    Private _provincepob As String
    Private _roadnoadn As String
    Private _homenoadn As String
    Private _villageadn As String
    Private _commubeadn As String
    Private _districtadn As String
    Private _provinceadn As String
    Private _image As Byte()
    Public Property id As String
        Get
            Return _id
        End Get
        Set(value As String)
            Me._id = value
        End Set
    End Property
    Public Property idcard As String
        Get
            Return _idcard
        End Get
        Set(value As String)
            Me._idcard = value
        End Set
    End Property
    Public Property namekhmer As String
        Get
            Return _namekhmer
        End Get
        Set(value As String)
            Me._namekhmer = value
        End Set
    End Property
    Public Property namelatin As String
        Get
            Return _namelatin
        End Get
        Set(value As String)
            Me._namelatin = value
        End Set
    End Property
    Public Property Nation As String
        Get
            Return _nation
        End Get
        Set(value As String)
            Me._nation = value
        End Set
    End Property

    Public Property Nationalty As String
        Get
            Return _nationality
        End Get
        Set(value As String)
            Me._nationality = value
        End Set
    End Property
    Public Property gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            Me._gender = value
        End Set
    End Property
    Public Property dob As String
        Get
            Return _dob
        End Get
        Set(value As String)
            Me._dob = value
        End Set
    End Property
    Public Property phonenumber As String
        Get
            Return _phonenumber
        End Get
        Set(value As String)
            Me._phonenumber = value
        End Set
    End Property
    Public Property emailaddress As String
        Get
            Return _emailaddress
        End Get
        Set(value As String)
            Me._emailaddress = value
        End Set
    End Property
    Public Property roadnopob As String
        Get
            Return _roadnopob
        End Get
        Set(value As String)
            Me._roadnopob = value
        End Set
    End Property
    Public Property homenopob As String
        Get
            Return _homenopob
        End Get
        Set(value As String)
            Me._homenopob = value
        End Set
    End Property
    Public Property villagepob As String
        Get
            Return _villagepob
        End Get
        Set(value As String)
            Me._villagepob = value
        End Set
    End Property
    Public Property communepob As String
        Get
            Return _commubepob
        End Get
        Set(value As String)
            Me._commubepob = value
        End Set
    End Property
    Public Property Districtpob As String
        Get
            Return _districtpob
        End Get
        Set(value As String)
            Me._districtpob = value
        End Set
    End Property
    Public Property provincepob As String
        Get
            Return _provincepob
        End Get
        Set(value As String)
            Me._provincepob = value
        End Set
    End Property
    Public Property roadnoadn As String
        Get
            Return _roadnoadn
        End Get
        Set(value As String)
            Me._roadnoadn = value
        End Set
    End Property
    Public Property homenoadn As String
        Get
            Return _homenoadn
        End Get
        Set(value As String)
            Me._homenoadn = value
        End Set
    End Property
    Public Property villageadn As String
        Get
            Return _villageadn
        End Get
        Set(value As String)
            Me._villageadn = value
        End Set
    End Property
    Public Property communeadn As String
        Get
            Return _commubeadn
        End Get
        Set(value As String)
            Me._commubeadn = value
        End Set
    End Property
    Public Property Districtadn As String
        Get
            Return _districtadn
        End Get
        Set(value As String)
            Me._districtadn = value
        End Set
    End Property
    Public Property provinceadn As String
        Get
            Return _provinceadn
        End Get
        Set(value As String)
            Me._provinceadn = value
        End Set
    End Property
    Public Property Image As Byte()
        Get
            Return _image
        End Get
        Set(value As Byte())
            Me._image = value
        End Set
    End Property
End Class
