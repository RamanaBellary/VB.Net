Public Class SampleClass
    Public Property MyProperty As Integer

    Private localVar As String
    Public Function Method1(ByVal str As String) As String
        localVar = "you have set local var to " & str
        Return localVar
    End Function
End Class
