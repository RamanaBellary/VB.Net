Public Class OperatorEx
    Public Shared Sub [Do]()
        Dim a As New Box(10, 20, 30)
        Dim b As New Box(40, 50, 60)
        Dim c As Box = a + b
    End Sub
End Class

Public Class Box
    Dim _l, _b, _h As Integer

    Public Sub New(ByVal l As Integer, ByVal b As Integer, ByVal h As Integer)
        _l = l
        _b = b
        _h = h
    End Sub

    Public Shared Operator +(ByVal a As Box, ByVal b As Box) As Box
        Return New Box(a._l + b._l, a._b + b._b, a._h + b._h)
    End Operator
End Class
