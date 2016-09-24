Public Class Booksale

    'Private attributes:
    Private _intQuantity As Integer
    Private _dblPrice As Double
    Private _dblTotalDue As Double

    'Get and Set:
    Public Property Quantity As Integer
        Get
            Return _intQuantity
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intQuantity = value
            Else
                _intQuantity = 0
            End If
        End Set
    End Property

    'Get and Set:
    Public Property Price As Double
        Get
            Return _dblPrice
        End Get
        Set(value As Double)
            If value > 0.0 Then
                _dblPrice = value
            Else
                _dblPrice = 0
            End If
        End Set
    End Property

    'Get and Set:
    Public Property TotalDue As Double
        Get
            Return _dblTotalDue
        End Get
        Set(value As Double)
            If value > 0.0 Then
                _dblTotalDue = value
            Else
                _dblTotalDue = 0
            End If
        End Set
    End Property

    'Constructor:
    Public Sub New()

        _intQuantity = 0
        _dblPrice = 0.0
        _dblTotalDue = 0.0

    End Sub

    'Method to keep a running total:
    Public Function KeepRunningTotal() As Double

        Dim dblInterimPrice As Double

        dblInterimPrice = _dblPrice * _intQuantity
        _dblTotalDue = _dblTotalDue + dblInterimPrice
        Return _dblTotalDue

    End Function

    'Clears the total:
    Public Sub ClearTotal()

        _intQuantity = 0
        _dblPrice = 0.0
        _dblTotalDue = 0.0

    End Sub

End Class
