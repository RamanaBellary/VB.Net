Imports System
Imports System.Console
Imports ALGOS_VB

Public Class IEquitableEx
    Public Shared Sub [Do]()
        Dim e1 As New Entity2() With {.Id = 1, .Name = "Name1"}
        Dim e2 As New Entity2() With {.Id = 2, .Name = "Name2"}
        Dim e3 As New Entity2() With {.Id = 1, .Name = "Name1"}
        Dim e4 As Entity2 = e1

        WriteLine($"e1.Equals(e2): {e1.Equals(e2)}")
        WriteLine($"e1.Equals(e3): {e1.Equals(e3)}")
        WriteLine($"e1.Equals(e4): {e1.Equals(e4)}")
        WriteLine($"e1 = e2: {(e1 Is e2)}")
        WriteLine($"e1 = e3: {(e1 Is e3)}")
        WriteLine($"e1 = e4: {(e1 Is e4)}")
    End Sub
End Class

Public Class Entity2
    Implements IEquatable(Of Entity2)

    Public Property Id As Integer
    Public Property Name As String

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        End If

        If ReferenceEquals(Me, obj) Then
            Return True
        End If

        If Me.[GetType]() <> obj.[GetType]() Then
            Return False
        End If

        Return Equals(CType(obj, Entity2))
    End Function

    Public Overloads Function Equals(other As Entity2) As Boolean Implements IEquatable(Of Entity2).Equals
        If other Is Nothing Then
            Return False
        End If

        If ReferenceEquals(Me, other) Then
            Return True
        End If

        If Me.GetType() <> other.GetType() Then
            Return False
        End If

        Return Id = other.Id And Name = other.Name
    End Function

End Class