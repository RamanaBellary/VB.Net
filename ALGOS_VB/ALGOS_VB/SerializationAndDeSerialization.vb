Imports System.IO
Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Public Class SerializationAndDeSerialization
    Public Shared Sub [Do]()
        Dim emp As Entity3 = New Entity3() With {
            .Id = 1,
            .Name = "Ram",
            .Salary = 100.0
        }
        Dim xml = Serialize(emp)
        Dim obj = DeSerialize(xml)
    End Sub

    Private Shared Function Serialize(ByVal emp As Entity3) As String
        Dim serializer As XmlSerializer = New XmlSerializer(GetType(Entity3))
        Dim xml As String

        Using sw = New StringWriter()
            serializer.Serialize(sw, emp)
            xml = sw.ToString()
        End Using

        Return xml
    End Function

    Private Shared Function DeSerialize(ByVal xml As String) As Object
        Dim serializer As XmlSerializer = New XmlSerializer(GetType(Entity3))
        Dim obj As Object = Nothing

        Using sr = New StringReader(xml)
            obj = serializer.Deserialize(sr)
        End Using

        Return obj
    End Function
End Class

<Serializable>
Public Class Entity3
    Public Id As Integer
    Public Name As String
    <XmlIgnore>
    Public Salary As Double
    <OptionalField(VersionAdded:=2)>
    Public Address As Address
End Class

Public Class Address
    Public No As Integer
    Public Street As String
    Public Area As String
    Public City As String
    Public PinCode As Integer
    Public Country As String
End Class
