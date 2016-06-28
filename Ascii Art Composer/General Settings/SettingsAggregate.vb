'Note: This aggregate class contains all the helper classes for settings
Public Class SettingsAggregate
    Public Sub New(ByRef MainForm As frmArt, ByRef RTB As RichTextBox)
        _FileSettings = New FileSettings
        _RTBSettings = New RTBSettings(RTB)
        _UISettings = New UISettings(MainForm)
    End Sub

#Region "Class Variables"
    Dim _FileSettings As FileSettings
    Dim _RTBSettings As RTBSettings
    Dim _UISettings As UISettings
#End Region
End Class
