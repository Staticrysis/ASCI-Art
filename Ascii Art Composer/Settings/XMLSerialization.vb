Imports System.Text
Imports System.Xml.Serialization
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Soap
Imports System.IO.WindowsRuntimeStreamExtensions


Module Serialization
    Public Const DEFAULTPATH As String = "C:\Users\Staticrysis\Desktop\Ascii Art Settings\"


    Sub Save(ByVal aggregate As Object, ByVal name As String, ByVal path As String)
        Try
            Dim serializer As New SoapFormatter()
            serializer.TypeFormat = FormatterTypeStyle.TypesAlways
            Using fileStream As New FileStream(If(path Is Nothing, DEFAULTPATH, path) & name & ".dat", FileMode.Create, FileAccess.Write)
                serializer.Serialize(fileStream, aggregate.GetType)
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function Open(ByRef aggregate As Object, ByVal name As String, ByVal path As String) As Object
        Try
            If Not File.Exists(If(path Is Nothing, DEFAULTPATH, path) & name & ".dat") Then Save(aggregate, name, path)
            Dim serializer As New SoapFormatter()
            Using FileStream As New FileStream(If(path Is Nothing, DEFAULTPATH, path) & name & ".dat", FileMode.Open) With {.Position = 0}
                Return serializer.Deserialize(FileStream)
            End Using

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths
End Module
