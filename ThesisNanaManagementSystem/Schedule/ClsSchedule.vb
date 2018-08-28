Public Class ClsSchedule
    Inherits ClsStudent
    Private _sdid As String
    Private _dayid As String
    Private _timenameid As String
    Private _timeid As String
    Private _subid As String
    Private _date As String
    Private _desc As String
    Private _status As String

    Public Property sdid As String
        Get
            Return _sdid
        End Get
        Set(value As String)
            Me._sdid = value
        End Set
    End Property
    Public Property dayid As String
        Get
            Return _dayid
        End Get
        Set(value As String)
            Me._dayid = value
        End Set
    End Property
    Public Property timenameid As String
        Get
            Return _timenameid
        End Get
        Set(value As String)
            Me._timenameid = value
        End Set
    End Property
    Public Property timeid As String
        Get
            Return _timeid
        End Get
        Set(value As String)
            Me._timeid = value
        End Set
    End Property
    Public Property subid As String
        Get
            Return _subid
        End Get
        Set(value As String)
            Me._subid = value
        End Set
    End Property
    Public Property Startdate As String
        Get
            Return _date
        End Get
        Set(value As String)
            Me._date = value
        End Set
    End Property
    Public Property desc As String
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
