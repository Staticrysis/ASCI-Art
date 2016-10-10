Imports System.Text
Imports System.Xml.Serialization
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Soap
Imports System.IO.WindowsRuntimeStreamExtensions


Module Serialization
    Const DEFAULTPATH As String = "C:\Users\Staticrysis\Desktop\Ascii Art Settings\"

    Async Sub Save(ByVal aggregate As Object, ByVal name As String, ByVal path As String)
        Try
            Dim serializer As New SoapFormatter()
            serializer.TypeFormat = FormatterTypeStyle.TypesAlways
            Using fileStream As New FileStream(If(path Is Nothing, DEFAULTPATH, path) & name & ".dat", FileMode.Create, FileAccess.Write)
                ' Dim writer As New StreamWriter(fileStream, New UTF8Encoding)
                serializer.Serialize(fileStream, aggregate)
            End Using

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function Open(ByRef aggregate As Object, ByVal name As String, ByVal path As String) As Object
        Try
            If File.Exists(If(path Is Nothing, DEFAULTPATH, path) & name & ".dat") Then
                Dim serializer As New SoapFormatter()
                Dim FileStream As New FileStream(If(path Is Nothing, DEFAULTPATH, path) & name & ".dat", FileMode.Open) With {.Position = 0}
                Dim obj = serializer.Deserialize(FileStream)
                FileStream.Close()
                Return obj
            Else
                Save(aggregate, name, path)
                Open(aggregate, name, path)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
End Module
