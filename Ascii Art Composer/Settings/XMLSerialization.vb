Imports System.Text
Imports System.Xml.Serialization
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Soap
Imports System.IO.WindowsRuntimeStreamExtensions


Module Serialization
    Public Const DEFAULTPATH As String = "C:\Users\Staticrysis\Desktop\Ascii Art Settings\"

    Function GetName(ByRef obj As Object) As String
        Return obj.GetType.Name
    End Function

    Sub Save(ByRef objFile As Object, path As String)
        Try
            If path Is Nothing Then path = DEFAULTPATH
            Dim serializer As New BinaryFormatter()
            Using fileStream As New FileStream(path & GetName(objFile) & ".dat", FileMode.Create, FileAccess.Write)
                serializer.Serialize(fileStream, objFile)
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function Open(ByRef objFile As Object, ByVal path As String) As Object
        Try
            If path Is Nothing Then path = DEFAULTPATH
            If Not File.Exists(path & GetName(objFile) & ".dat") Then Save(objFile, path)

            Dim serializer As New BinaryFormatter()
            Using FileStream As New FileStream(path & GetName(objFile) & ".dat", FileMode.Open) With {.Position = 0}
                Return serializer.Deserialize(FileStream)
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths
End Module
