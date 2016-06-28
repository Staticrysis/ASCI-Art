'Note: This Source class is the parent class for all child setting classes
'It also contains all relivent properties for child classes to use
Public Class SettingsSource
    'RTB text editing constuctor
    Public Sub New(ByRef RTB As RichTextBox)
        _RTB = RTB
        _RTBTextEditingSettings = New RTBSettings(RTB)
    End Sub

    'General UI Settings constructor
    Public Sub New(ByRef MainForm As frmArt)
        _mainForm = MainForm
        _UISettings = New UISettings(MainForm)
    End Sub

    'General file settings constructor
    Public Sub New()
        _FileSettings = New FileSettings
    End Sub

#Region "Class Variables"
    Protected _mainForm As frmArt
    Protected _RTB As RichTextBox
    Protected _UISettings As UISettings
    Protected _FileSettings As FileSettings
    Protected _RTBTextEditingSettings As RTBSettings
#End Region
End Class
