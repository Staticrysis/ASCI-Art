'Note: This Source class is the parent class for all child setting classes
'It also contains all relivent properties for child classes to use
Public Class SettingsSource
#Region "Class Variables"
    Protected _mainForm As frmArt
    Protected _settingsForm As frmSettings
    Protected _tabControlSettings As TabControl

    Protected _tabFileSettings As TabControl
    Protected _tabColorSettings As TabControl
    Protected _tabEditingSettings As TabControl
#End Region

    'General Settings constructor
    Public Sub New(ByRef mainForm As frmArt, ByRef settingsForm As frmSettings)
        _mainForm = mainForm
        _settingsForm = settingsForm
    End Sub
End Class
