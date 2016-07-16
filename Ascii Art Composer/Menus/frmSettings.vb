Public Class frmSettings
    Public _settingsAggregate As SettingsAggregate
    Public _artForm As frmArt
    Public _colorDialog As ColorDialog = New ColorDialog

    Public Sub New(ByRef settingsAggregate As SettingsAggregate)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._settingsAggregate = settingsAggregate
        Me.ColorBindingSource.DataSource = settingsAggregate.ColorSettings
        Me.FileSettingsBindingSource.DataSource = settingsAggregate.FileSettings
        Me.TextEditingSettingsBindingSource.DataSource = settingsAggregate.TextEditingSettings
        Me.WebPresetsBindingSource.DataSource = New Color
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub HideForm() Handles Me.Closing
        Me.Hide()
    End Sub

#Region "Event Handlers For Color settings"
    Private Sub RTBForeColorClick() Handles buttonRTBTextForeColor.Click
        If _colorDialog.ShowDialog() = DialogResult.OK Then
            _settingsAggregate.ColorSettings.RTBForeColors = _colorDialog.Color
            buttonRTBTextForeColor.BackColor = _colorDialog.Color
        End If
    End Sub

    Private Sub RTBBackColorClick() Handles buttonRTBTextBackColors.Click
        If _colorDialog.ShowDialog() = DialogResult.OK Then
            _settingsAggregate.ColorSettings.RTBBackColors = _colorDialog.Color
            buttonRTBTextBackColors.BackColor = _colorDialog.Color
        End If
    End Sub

    Private Sub RTBTextHighlightColor() Handles buttonRTBTextHighlight.Click
        If _colorDialog.ShowDialog() = DialogResult.OK Then
            _settingsAggregate.ColorSettings.RTBTextHighlightColors = _colorDialog.Color
            buttonRTBTextHighlight.BackColor = _colorDialog.Color
        End If
    End Sub

    Private Sub GUIForeColorClick() Handles buttonGUIForeTextColors.Click
        If _colorDialog.ShowDialog() = DialogResult.OK Then
            _settingsAggregate.ColorSettings.GUIForeColors = _colorDialog.Color
            buttonGUIForeTextColors.BackColor = _colorDialog.Color
        End If
    End Sub

    Private Sub GUIBackColorClick() Handles buttonGUIBackTextColors.Click
        If _colorDialog.ShowDialog() = DialogResult.OK Then
            _settingsAggregate.ColorSettings.RTBBackColors = _colorDialog.Color
            buttonGUIBackTextColors.BackColor = _colorDialog.Color
        End If
    End Sub

    Private Sub GUITextColorClick() Handles buttonGUITextColors.Click
        If _colorDialog.ShowDialog() = DialogResult.OK Then
            _settingsAggregate.ColorSettings.GUITextColors = _colorDialog.Color
            buttonGUITextColors.BackColor = _colorDialog.Color
        End If
    End Sub
#End Region
End Class