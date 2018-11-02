Imports System.Console

Imports ALGOS_VB.ALGOS_VB.SubModule1
Imports ALGOS_VB.DelegatesEx

Class Program
    Shared Sub Main()
#Region "Extensions"
        'Dim i As Integer = 10
        'Dim b = i.IsRange(10, 500)
#End Region

#Region "Sub-Module"
        'Dim fName As String = GetFullName("Ramana", Nothing, "Bellary")
        'Dim c As New Customer With {.Name = "Vishal Vimal"}
        'WriteLine(c.Name)
#End Region

        'DelegatesEx.Do()
        'GenericsEx.Do()
        'IComparerEx.Do()
        'IEquitableEx.Do()
        'OperatorEx.Do()
        'ReflectionEx.Do()
        'SerializationAndDeSerialization.Do()
        WriteLine("Press any key to exit.")
        ReadLine()
    End Sub
End Class

Module MainModule
    Sub Main()
        WriteLine("Press any key to exit.")
        ReadLine()
    End Sub

End Module