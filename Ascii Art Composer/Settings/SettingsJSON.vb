Imports Newtonsoft
Imports System.IO
Imports System.Web.Script.Serialization
Public Class SettingsJSON
    Dim _JWriter As Json.JsonTextWriter
    Dim _JReader As Json.JsonTextReader
    Dim _settingsAggregate As SettingsAggregate
    Dim _JsonSetting As String = ""


    Sub New(ByRef settingsAggregate As SettingsAggregate)
        _settingsAggregate = settingsAggregate
    End Sub

    Public Sub ExtractJsonSettings()
        'todo: this needs to be part of the file settings 
        ' _settingsAggregate.FileSettings.GetType.GetProperties.
        _JsonSetting = File.ReadAllText("C:\Users\Staticrysis\Desktop\Technomancy\Program Developments\Visual Basic\Ascii Art Composer\Ascii Art Composer\General Settings\Ascii_Art_ComposerSettings.json")
    End Sub

    Public Sub InsertJsonSettings()

    End Sub
End Class
