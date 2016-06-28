'Note: This aggregate class contains all the helper classes for settings
Public Class SettingsAggregate
#Region "Class Variables"
    Dim _fileSettings As FileSettings
    Dim _textEditingSettings As TextEditingSettings
    Dim _colorSettings As ColorSettings
#End Region

#Region "Class Properties"

#End Region

    Public Sub New(ByRef frmArt As frmArt, ByRef frmSettings As frmSettings)
        _fileSettings = New FileSettings(frmArt, frmSettings)
        _textEditingSettings = New TextEditingSettings(frmArt, frmSettings)
        _colorSettings = New ColorSettings(frmArt, frmSettings)
    End Sub
End Class
