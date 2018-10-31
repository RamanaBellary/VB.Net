Imports ALGOS_VB

Public Class IComparerEx
    Public Shared Sub [Do]()
        Dim vis As New Entity1 With {.Id = 1, .FirstName = "Vishal", .LastName = "Bellary"}
        Dim vim As New Entity1 With {.Id = 2, .FirstName = "Vimal", .LastName = "Bellary"}
        Dim i As Integer = vis.CompareTo(vim)

        Dim lst As New List(Of Entity1) From
            {
             New Entity1() With {.Id = 3, .FirstName = "Mouni", .LastName = "Bollipalli"},
             vis,
             vim
            }
        lst.Sort()
        Dim arr = lst.ToArray()
        Array.Sort(arr, Entity1.SortbyIdDescendingOrder)
        Array.Sort(arr, Entity1.SortbyNameAscendingOrder)
        Array.Sort(arr, Entity1.SortbyNameDescendingOrder)
    End Sub
End Class

Public Class Entity1
    Implements IComparable(Of Entity1)

    Public Property Id As Integer
    Public Property FirstName As String
    Public Property LastName As String

    Public Function CompareTo(other As Entity1) As Integer Implements IComparable(Of Entity1).CompareTo
        Return Id.CompareTo(other.Id)
    End Function

    Public Shared Function SortbyIdDescendingOrder() As IComparer
        Return New sortbyIdDesOrder
    End Function

    Public Shared Function SortbyNameAscendingOrder() As IComparer
        Return New sortybyNameAsc
    End Function

    Public Shared Function SortbyNameDescendingOrder() As IComparer
        Return New sortybyNameDesc
    End Function

    Private Class sortbyIdDesOrder
        Implements IComparer

        Private Function IComparer_Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            If (CType(x, Entity1)).Id > (CType(y, Entity1)).Id Then Return -1
            If (CType(x, Entity1)).Id < (CType(y, Entity1)).Id Then Return 1
            Return 0
        End Function
    End Class

    Private Class sortybyNameAsc
        Implements IComparer

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            If x Is Nothing Or y Is Nothing Then
                Return 0
            End If

            Dim result = String.Compare(CType(x, Entity1).FirstName, CType(y, Entity1).FirstName)

            If result = 0 Then
                result = String.Compare(CType(x, Entity1).LastName, CType(y, Entity1).LastName)
            End If
            Return result
        End Function
    End Class

    Private Class sortybyNameDesc
        Implements IComparer

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            If x Is Nothing Or y Is Nothing Then
                Return 0
            End If

            Dim result = String.Compare(CType(y, Entity1).FirstName, CType(x, Entity1).FirstName)

            If result = 0 Then
                result = String.Compare(CType(y, Entity1).LastName, CType(x, Entity1).LastName)
            End If
            Return result
        End Function
    End Class
End Class
