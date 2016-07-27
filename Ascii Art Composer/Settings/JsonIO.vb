Imports Newtonsoft
Imports System.IO
Imports Newtonsoft.Json

Public Class JsonIO

#Region "IO Serialization"
    'Might break here on the object parameter 
    Public Shared Function SerialSave(ByRef aggregate As Object, ByVal name As String, ByVal path As String) As Boolean
        Try
            If File.Exists("C:\Users\Staticrysis\Desktop\" & name & ".Json") Then
                File.WriteAllText(name, JsonConvert.SerializeObject(aggregate))
                Return True
            Else
                File.Create("C:\Users\Staticrysis\Desktop\" & name & ".Json")
                File.WriteAllText(name, JsonConvert.SerializeObject(aggregate))
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Shared Function SerialOpen(ByRef aggregate As Object, ByVal name As String, ByVal path As String) As Boolean
        Try
            If File.Exists("C:\Users\Staticrysis\Desktop\" & name & ".Json") Then
                aggregate = JsonConvert.DeserializeObject(Of Object)(File.ReadAllText("C:\Users\Staticrysis\Desktop\" & name & ".Json"))
                If IsNothing(aggregate) Then
                    Return False
                End If
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace)
        End Try
        Return False
    End Function
#End Region
End Class
