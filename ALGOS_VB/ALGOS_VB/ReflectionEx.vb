Imports System.Reflection

Public Class ReflectionEx
    Public Shared Sub [Do]()
        Dim dll = Assembly.LoadFile("D:\Mine\Samples\ALGOS\SampleLibrary\bin\Debug\SampleLibrary.dll")
        Dim classType = dll.[GetType]("SampleLibrary.SampleClass")
        Dim classInstance = Activator.CreateInstance(classType)
        Dim resp = classType.InvokeMember("Method1", BindingFlags.[Public] Or BindingFlags.InvokeMethod Or BindingFlags.Instance, Nothing, classInstance, New Object() {"MyValue"})
        Dim prop = classType.GetProperty("MyProperty")
        prop.SetValue(classInstance, 100)
        Dim val = prop.GetValue(classInstance)
    End Sub
End Class
