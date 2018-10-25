Imports System.Console

Public Delegate Sub PassMessage(ByVal msg As String)

Public Class DelegatesEx
    Public Shared Sub [Do]()
        Dim sub1 As New Subscriber1
        Dim sub2 As New Subscriber2
        Dim pub As New Publisher
        pub.InvokeDelegate()
    End Sub
End Class

Public Class Publisher
    Public Shared Event passMessageDel As PassMessage

    Public Shared passMessageDel1 As PassMessage
    Public Shared passMessageDel2 As PassMessage
    Dim del As [Delegate]

    Public Sub New()
        'del = MulticastDelegate.Combine(passMessageDel1, passMessageDel2)
    End Sub

    Public Sub InvokeDelegate()
        RaiseEvent passMessageDel("Message from publisher")
        'del.DynamicInvoke("Message from publisher")
    End Sub
End Class

Public Class Subscriber1
    Public Sub New()
        AddHandler Publisher.passMessageDel, AddressOf GetMessage
        'Publisher.passMessageDel1 = AddressOf GetMessage
    End Sub
    Private Sub GetMessage(ByVal msg As String)
        WriteLine(msg + " inside Subscriber1")
    End Sub
End Class

Public Class Subscriber2
    Public Sub New()
        AddHandler Publisher.passMessageDel, AddressOf GetMessage
        'Publisher.passMessageDel2 = AddressOf GetMessage
    End Sub
    Private Sub GetMessage(ByVal msg As String)
        WriteLine(msg + " inside Subscriber2")
    End Sub
End Class
