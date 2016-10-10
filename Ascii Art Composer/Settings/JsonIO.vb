'Imports Newtonsoft
'Imports System.IO
'Imports Newtonsoft.Json

'Imports System.Runtime.Serialization.Formatters.Binary

'Public Class JsonIO
'    Private Shared Serializer As JsonSerializer = New JsonSerializer

'    Dim _binaryFormatter = New BinaryFormatter

'#Region "IO Serialization"
'    'Might break here on the object parameter 
'    Public Shared Function SerialSave(ByRef aggregate As Object, ByVal name As String, ByVal path As String) As Boolean
'        Try
'            Dim binaryFormatter = New BinaryFormatter
'            Dim fileMode = If(File.Exists("C:\Users\Staticrysis\Desktop\" & name & ".bin"), System.IO.FileMode.Create, System.IO.FileMode.CreateNew)

'            Using fileStream = New FileStream("C:\Users\Staticrysis\Desktop\" & name & ".bin", fileMode)
'                binaryFormatter.Serialize(fileStream, New Color()) 'aggregate)
'            End Using
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        End Try
'        Return False
'    End Function

'    Public Shared Function SerialOpen(ByRef aggregate As Object, ByVal name As String, ByVal path As String) As Boolean
'        Try
'            Dim binaryFormatter = New BinaryFormatter

'            Dim fileMode = If(File.Exists("C:\Users\Staticrysis\Desktop\" & name & ".bin"), System.IO.FileMode.Create, System.IO.FileMode.CreateNew)

'            Using filestream = New FileStream("C:\Users\Staticrysis\Desktop\" & name & ".bin", fileMode)
'                Try
'                    aggregate = binaryFormatter.Deserialize(filestream)
'                    If IsNothing(aggregate) Then
'                        Return False
'                    Else
'                        Return True
'                    End If
'                Catch ex As Exception
'                    MsgBox(ex.Message)
'                End Try
'            End Using
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        End Try
'        Return False
'    End Function

'    'Public Shared Sub SerialTest()

'    '    'File.Create("C:\Users\Staticrysis\Desktop\" & "Color" & ".Json")
'    '    System.Threading.Thread.Sleep(100)
'    '    File.WriteAllText("Color", JsonConvert.SerializeObject(New String("Here is some text")))
'    '    System.Threading.Thread.Sleep(1000)
'    '    'Dim test = JsonConvert.DeserializeObject(Of Color)(File.ReadAllText("C:\Users\Staticrysis\Desktop\" & "Color" & ".Json"))
'    'End Sub
'#End Region
'End Class
