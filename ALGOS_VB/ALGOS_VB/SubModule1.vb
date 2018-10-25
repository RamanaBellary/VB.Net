Imports System.Runtime.CompilerServices

Namespace ALGOS_VB.SubModule1
    Module SubModule1
        <Extension()>
        Function IsRange(ByVal val As Integer, ByVal lowerBound As Integer, ByVal upperBound As Integer) As Boolean
            Return lowerBound <= val AndAlso val <= upperBound
        End Function

        Function GetFullName(ByVal fName As String, ByVal mName As String, ByVal lName As String) As String
            Return fName + " " + mName + " " + lName
        End Function

        Public Class Customer
            Private _name As String
            Public Property Name() As String
                Get
                    Return _name
                End Get
                Set(ByVal value As String)
                    _name = value
                End Set
            End Property
        End Class
    End Module
End Namespace
