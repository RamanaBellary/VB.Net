Public Class GenericsEx
    Public Shared Sub [Do]()
#Region "Example1"
        'Dim s As String = getDefaultValue(Of String)()
        'Dim i As Int32 = getDefaultValue(Of Int32)()
        'Dim n As Object = getDefaultValue(Of Object)()
        'Dim b As Boolean = getDefaultValue(Of Boolean)()
#End Region

#Region "Example2"
        Dim iSum As Integer = add(Of Integer)({10, 20})
        Dim dSum As Double = add(Of Double)({10.15, 20.65})
#End Region
    End Sub

    Private Shared Function getDefaultValue(Of T)() As T
        Dim val As Object = Nothing

        Select Case GetType(T).Name
            Case "Int32"
                val = -1
                Exit Select
            Case "String"
                val = String.Empty
                Exit Select
            Case "Boolean"
                val = False
                Exit Select
        End Select

        Return CType(val, T)
    End Function

    Private Shared Function add(Of T)(ByVal args As T()) As T
        Dim sum As Object = Nothing
        For Each v In args
            sum = sum + v
        Next
        Return sum
    End Function
End Class
