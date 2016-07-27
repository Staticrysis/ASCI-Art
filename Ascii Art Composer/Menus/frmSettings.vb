Imports System.IO
Imports Newtonsoft.Json
Public Class frmSettings
    Public _settingsAggregate As SettingsAggregate
    Public _artForm As frmArt
    Public _colorDialog As ColorDialog = New ColorDialog

    Public Sub New(ByRef settingsAggregate As SettingsAggregate)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._settingsAggregate = settingsAggregate
        If IsNothing(settingsAggregate) Then LoadSettings()
        Me.ColorBindingSource.DataSource = settingsAggregate.ColorSettings
        Me.FileSettingsBindingSource.DataSource = settingsAggregate.FileSettings
        Me.TextEditingSettingsBindingSource.DataSource = settingsAggregate.TextEditingSettings
        Me.WebPresetsBindingSource.DataSource = New Color
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

    Public Sub SaveSettings()
        JsonIO.SerialSave(Me._settingsAggregate, "Settings", _settingsAggregate.FileSettings.SettingsPath)
    End Sub

    Public Sub LoadSettings()
        If Not JsonIO.SerialOpen(Me._settingsAggregate, "Settings", _settingsAggregate.FileSettings.SettingsPath) Then
            Me._settingsAggregate = New SettingsAggregate()
        End If
    End Sub

    Private Sub SaveOnClose() Handles Me.Closing
        SaveSettings()
    End Sub

    Private Sub LoadOnOpen() Handles Me.Load
        LoadSettings()
    End Sub

    Private Sub buttonSetSaveArtFileLocation_Click(sender As Object, e As EventArgs) Handles buttonSetSaveArtFileLocation.Click
        Using folderBrowser As FolderBrowserDialog = New FolderBrowserDialog()
            If folderBrowser.ShowDialog = DialogResult.OK Then
                _settingsAggregate.FileSettings.ArtSavePath = folderBrowser.SelectedPath
            End If
        End Using
    End Sub

    Private Sub buttonSetSaveLoadFile_Click(sender As Object, e As EventArgs) Handles buttonSetSaveLoadFile.Click
        Using folderBrowser As FolderBrowserDialog = New FolderBrowserDialog()
            If folderBrowser.ShowDialog = DialogResult.OK Then
                _settingsAggregate.FileSettings.ArtLoadPath = folderBrowser.SelectedPath
            End If
        End Using
    End Sub

    Private Sub buttonSetSettingsFileLocation_Click(sender As Object, e As EventArgs) Handles buttonSetSettingsFileLocation.Click
        Using folderBrowser As FolderBrowserDialog = New FolderBrowserDialog()
            If folderBrowser.ShowDialog = DialogResult.OK Then
                _settingsAggregate.FileSettings.SettingsPath = folderBrowser.SelectedPath
            End If
        End Using
    End Sub

    Private Sub buttonSetSaveWEBImageFile_Click(sender As Object, e As EventArgs) Handles buttonSetSaveWEBImageFile.Click
        'Needs some implementation in the future
    End Sub

    Private Sub buttonSetSaveLocalImageFile_Click(sender As Object, e As EventArgs) Handles buttonSetSaveLocalImageFile.Click
        Using folderBrowser As FolderBrowserDialog = New FolderBrowserDialog()
            If folderBrowser.ShowDialog = DialogResult.OK Then
                _settingsAggregate.FileSettings.ImagePath = folderBrowser.SelectedPath
            End If
        End Using
    End Sub
End Class