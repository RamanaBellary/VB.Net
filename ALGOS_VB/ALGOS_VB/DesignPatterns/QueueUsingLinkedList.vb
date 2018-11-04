Public Class QueueUsingLinkedList
    Public Shared Sub [Do]()
        Dim mcq As New MyCustomQueue(Of Integer)
        mcq.Enqueu(1)
        mcq.Enqueu(2)
        mcq.Enqueu(3)
        mcq.Dequeu()
        Dim i1 = mcq.Peek
    End Sub
End Class

Public Class MyCustomQueue(Of T)
    Dim queue As New LinkedList(Of T)

    Public Sub Enqueu(item As T)
        queue.AddLast(item)
    End Sub

    Public Function Dequeu() As T
        Dim firstItem = queue.First
        queue.RemoveFirst()
        Return firstItem.Value
    End Function

    Public Function Peek() As T
        Return queue.First.Value
    End Function
End Class
