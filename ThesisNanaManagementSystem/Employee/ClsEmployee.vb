Public Class ClsEmploye
    Private _id As String
    Private _idcard As String
    Private _khmername As String
    Private _latinname As String
    Private _nation As String
    Private _nationality As String
    Private _gender As String
    Private _dob As String
    Private _pobroadno As String
    Private _pobhomeno As String
    Private _pobvillage As String
    Private _pobcommune As String
    Private _pobdistrict As String
    Private _pobprovince As String
    Private _phonenumber As String
    Private _emailaddress As String
    Private _adnroadno As String
    Private _adnhomeno As String
    Private _adnvillage As String
    Private _adncommune As String
    Private _adndistrict As String
    Private _adnprovince As String
    Private _termid As String
    Private _startwork As String
    Private _image As Byte()

    Public Property ID As String
        Get
            Return _id
        End Get
        Set(value As String)
            Me._id = value
        End Set
    End Property
    Public Property IDcard As String
        Get
            Return _idcard
        End Get
        Set(value As String)
            Me._idcard = value
        End Set
    End Property
    Public Property Khmername As String
        Get
            Return _khmername
        End Get
        Set(value As String)
            Me._khmername = value
        End Set
    End Property
    Public Property Latinname As String
        Get
            Return _latinname
        End Get
        Set(value As String)
            Me._latinname = value
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
    Public Property Nationality As String
        Get
            Return _nationality
        End Get
        Set(value As String)
            Me._nationality = value
        End Set
    End Property
    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            Me._gender = value
        End Set
    End Property
    Public Property DOB As String
        Get
            Return _dob
        End Get
        Set(value As String)
            Me._dob = value
        End Set
    End Property
    Public Property Pobroadno As String
        Get
            Return _pobroadno
        End Get
        Set(value As String)
            Me._pobroadno = value
        End Set
    End Property
    Public Property Pobhomeno As String
        Get
            Return _pobhomeno
        End Get
        Set(value As String)
            Me._pobhomeno = value
        End Set
    End Property
    Public Property Pobvillage As String
        Get
            Return _pobvillage
        End Get
        Set(value As String)
            Me._pobvillage = value
        End Set
    End Property
    Public Property Pobcommube As String
        Get
            Return _pobcommune
        End Get
        Set(value As String)
            Me._pobcommune = value
        End Set
    End Property
    Public Property Pobdistrict As String
        Get
            Return _pobdistrict
        End Get
        Set(value As String)
            Me._pobdistrict = value
        End Set
    End Property
    Public Property PobProvince As String
        Get
            Return _pobprovince
        End Get
        Set(value As String)
            Me._pobprovince = value
        End Set
    End Property
    Public Property PhoneNumber As String
        Get
            Return _phonenumber
        End Get
        Set(value As String)
            Me._phonenumber = value
        End Set
    End Property
    Public Property Emailaddress As String
        Get
            Return _emailaddress
        End Get
        Set(value As String)
            Me._emailaddress = value
        End Set
    End Property
    Public Property Adnroadno As String
        Get
            Return _adnroadno
        End Get
        Set(value As String)
            Me._adnroadno = value
        End Set
    End Property
    Public Property Adnhomeno As String
        Get
            Return _adnhomeno
        End Get
        Set(value As String)
            Me._adnhomeno = value
        End Set
    End Property
    Public Property Adnvillage As String
        Get
            Return _adnvillage
        End Get
        Set(value As String)
            Me._adnvillage = value
        End Set
    End Property
    Public Property Adncommune As String
        Get
            Return _adncommune
        End Get
        Set(value As String)
            Me._adncommune = value
        End Set
    End Property
    Public Property Adndistrict As String
        Get
            Return _adndistrict
        End Get
        Set(value As String)
            Me._adndistrict = value
        End Set
    End Property
    Public Property Adnprovince As String
        Get
            Return _adnprovince
        End Get
        Set(value As String)
            Me._adnprovince = value
        End Set
    End Property
    Public Property startwork As String
        Get
            Return _startwork
        End Get
        Set(value As String)
            Me._startwork = value
        End Set
    End Property
    Public Property Termid As String
        Get
            Return _termid
        End Get
        Set(value As String)
            Me._termid = value
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
