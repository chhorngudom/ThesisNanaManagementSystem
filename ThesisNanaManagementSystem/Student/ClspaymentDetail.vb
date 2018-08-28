Public Class ClspaymentDetail
    Inherits ClsStudent
    Private _paymentdetailid As String
    Private _paymentid As String
    Private _price As Double
    Private _fee As Double
    Private _remainfee As Double
    Private _description As String
    Private _status As String
    Public Property paymentdetailid As String
        Get
            Return _paymentdetailid
        End Get
        Set(value As String)
            Me._paymentdetailid = value
        End Set
    End Property
    Public Property paymentid As String
        Get
            Return _paymentid
        End Get
        Set(value As String)
            Me._paymentid = value
        End Set
    End Property
    Public Property price As Double
        Get
            Return _price
        End Get
        Set(value As Double)
            Me._price = value
        End Set
    End Property
    Public Property fee As Double
        Get
            Return _fee
        End Get
        Set(value As Double)
            Me._fee = value
        End Set
    End Property
    Public Property remainfee As Double
        Get
            Return _remainfee
        End Get
        Set(value As Double)
            Me._remainfee = value
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
