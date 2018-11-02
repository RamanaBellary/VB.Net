Public Class LinkedListEx
    Public Shared Sub [Do]()
        Dim dll As New DoubleLinkedList(Of Integer)
        Dim n2 As New Node(Of Integer)(2)
        Dim n1 As New Node(Of Integer)(1)
        Dim n3 As New Node(Of Integer)(3)

        dll.AddFirst(n2)
        dll.AddFirst(n1)
        dll.AddLast(n3)
    End Sub
End Class

Public Class Node(Of T)
    Private _previous As Node(Of T)
    Private _next As Node(Of T)
    Private _data As T

    Public Sub New(ByVal data As T)
        _data = data
        _previous = Nothing
        _next = Nothing
    End Sub

    Public Property Previous As Node(Of T)
        Get
            Return _previous
        End Get
        Set(value As Node(Of T))
            _previous = value
        End Set
    End Property

    Public Property [Next] As Node(Of T)
        Get
            Return _next
        End Get
        Set(value As Node(Of T))
            _next = value
        End Set
    End Property
End Class

Public Class DoubleLinkedList(Of T)

    Private _first As Node(Of T)
    Public Property First() As Node(Of T)
        Get
            Return _first
        End Get
        Set(ByVal value As Node(Of T))
            _first = value
        End Set
    End Property

    Private _last As Node(Of T)
    Public Property Last() As Node(Of T)
        Get
            Return _last
        End Get
        Set(ByVal value As Node(Of T))
            _last = value
        End Set
    End Property

    Public Function AddFirst(newNode As Node(Of T)) As Node(Of T)
        If First Is Nothing Then
            First = newNode
            Last = newNode
        Else
            Dim f = First
            f.Previous = newNode
            newNode.Next = f
            First = newNode
        End If

        Return First
    End Function

    Public Function AddLast(newNode As Node(Of T)) As Node(Of T)
        If Last Is Nothing Then
            First = newNode
            Last = newNode
        Else
            Dim l = Last
            l.Next = newNode
            newNode.Previous = l
            Last = newNode
        End If
        Return Last
    End Function
End Class
