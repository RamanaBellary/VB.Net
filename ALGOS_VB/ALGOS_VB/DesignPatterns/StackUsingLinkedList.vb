Public Class StackUsingLinkedList
    Public Shared Sub [Do]()
        Dim stack As New MyCustomStack(Of Integer)

        Dim i1 = stack.Peek()
        stack.Push(3)
        stack.Push(2)
        stack.Push(1)
        Dim i2 = stack.Pop()
        i1 = stack.Peek()
    End Sub
End Class

Public Class MyCustomStack(Of T)
    Dim stack As New LinkedList(Of T)

    Public Sub Push(item As T)
        stack.AddLast(item)
    End Sub

    Public Function Pop() As T
        If stack.Any() = False Then
            Return Nothing
        End If
        Dim last = stack.Last()
        stack.RemoveLast()
        Return last.Value
    End Function

    Public Function Peek() As T
        If stack.Any() = False Then
            Return Nothing
        End If
        Return stack.Last.Value
    End Function
End Class
