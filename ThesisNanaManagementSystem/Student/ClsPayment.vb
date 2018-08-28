Public Class ClsPayment
    Inherits ClsStudent
    Private _paymentid As String
    Private _description As String
    Private _status As String
    Public Property paymentid As String
        Get
            Return _paymentid
        End Get
        Set(value As String)
            Me._paymentid = value
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
