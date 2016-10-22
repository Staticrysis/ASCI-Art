Imports System.IO
Imports Newtonsoft.Json

<Serializable>
Public Class frmSettings
    Public _settings As New SettingsAggregate
    Public _colorDialog As New ColorDialog

    Public Sub New(ByRef settingsAggregate As SettingsAggregate)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _settings = settingsAggregate 'By-ref so local settings uses the mainForm's settings
        LoadSettings()
        BindUI()
        LoadUI()
    End Sub

#Region "IO"
    Public Sub SaveSettings()
        Serialization.Save(Me._settings, "Settings", Nothing) ', _settingsAggregate.FileSettings.SettingsPath)
    End Sub

    Public Function LoadSettings() As Boolean
        Try
            Me._settings = Serialization.Open(Me._settings, "Settings", Nothing) ', _settingsAggregate.FileSettings.SettingsPath)
            Return True
        Catch ex As Exception
            MsgBox("File could not be found.")
            Return False
        End Try
    End Function

    Private Sub SaveOnClose() Handles Me.Closing
        _settings.Canvas = DirectCast(TextEditingSettingsBindingSource.Item(0), CanvasText)
        _settings.Files = DirectCast(FileSettingsBindingSource.Item(0), Files)
        _settings.Colors = DirectCast(ColorSettingsBindingSource.Item(0), Colors)
        SaveSettings()
    End Sub

    Private Sub LoadOnOpen() Handles Me.Load
        LoadSettings()
    End Sub
#End Region

#Region "Bind & Load"
    Private Sub BindUI()
        Me.ColorSettingsBindingSource.DataSource = _settings.Colors
        Me.FileSettingsBindingSource.DataSource = _settings.Files
        Me.TextEditingSettingsBindingSource.DataSource = _settings.Canvas
    End Sub

    Private Sub LoadUI()
        buttonRTBTextForeColor.BackColor = _settings.Colors.RTBForeColors
        buttonRTBTextBackColors.BackColor = _settings.Colors.RTBBackColors
        buttonRTBTextHighlight.BackColor = _settings.Colors.RTBTextHighlightColors
        buttonGUIForeTextColors.BackColor = _settings.Colors.GUIForeColors
        buttonGUIBackTextColors.BackColor = _settings.Colors.GUIBackColors
        buttonGUITextColors.BackColor = _settings.Colors.GUITextColors
    End Sub
#End Region

#Region "Event For Color settings"
    Private Sub RTBForeColorClick() Handles buttonRTBTextForeColor.Click
        If _colorDialog.ShowDialog() = DialogResult.OK Then
            buttonRTBTextForeColor.BackColor = _colorDialog.Color
        End If
    End Sub

    Private Sub RTBBackColorClick() Handles buttonRTBTextBackColors.Click
        If _colorDialog.ShowDialog() = DialogResult.OK Then
            buttonRTBTextBackColors.BackColor = _colorDialog.Color
        End If
    End Sub

    Private Sub RTBTextHighlightColor() Handles buttonRTBTextHighlight.Click
        If _colorDialog.ShowDialog() = DialogResult.OK Then
            buttonRTBTextHighlight.BackColor = _colorDialog.Color
        End If
    End Sub

    Private Sub GUIForeColorClick() Handles buttonGUIForeTextColors.Click
        If _colorDialog.ShowDialog() = DialogResult.OK Then
            buttonGUIForeTextColors.BackColor = _colorDialog.Color
        End If
    End Sub

    Private Sub GUIBackColorClick() Handles buttonGUIBackTextColors.Click
        If _colorDialog.ShowDialog() = DialogResult.OK Then
            buttonGUIBackTextColors.BackColor = _colorDialog.Color
        End If
    End Sub

    Private Sub GUITextColorClick() Handles buttonGUITextColors.Click
        If _colorDialog.ShowDialog() = DialogResult.OK Then
            buttonGUITextColors.BackColor = _colorDialog.Color
        End If
    End Sub
#End Region

#Region "File Settings"
    Private Sub buttonSetSaveArtFileLocation_Click(sender As Object, e As EventArgs) Handles buttonSetSaveArtFileLocation.Click
        Using folderBrowser As FolderBrowserDialog = New FolderBrowserDialog()
            If folderBrowser.ShowDialog = DialogResult.OK Then tbSaveArtFileLocation.Text = folderBrowser.SelectedPath
        End Using
    End Sub

    Private Sub buttonSetSaveLoadFile_Click(sender As Object, e As EventArgs) Handles buttonSetSaveLoadFile.Click
        Using folderBrowser As FolderBrowserDialog = New FolderBrowserDialog()
            If folderBrowser.ShowDialog = DialogResult.OK Then tbSaveLoadArtFile.Text = folderBrowser.SelectedPath
        End Using
    End Sub

    Private Sub buttonSetSettingsFileLocation_Click(sender As Object, e As EventArgs) Handles buttonSetSettingsFileLocation.Click
        Using folderBrowser As FolderBrowserDialog = New FolderBrowserDialog()
            If folderBrowser.ShowDialog = DialogResult.OK Then tbSettingsFileLocation.Text = folderBrowser.SelectedPath
        End Using
    End Sub

    Private Sub buttonSetSaveWEBImageFile_Click(sender As Object, e As EventArgs) Handles buttonSetSaveWEBImageFile.Click
        'Needs implementation in the future
    End Sub

    Private Sub buttonSetSaveLocalImageFile_Click(sender As Object, e As EventArgs) Handles buttonSetSaveLocalImageFile.Click
        Using folderBrowser As FolderBrowserDialog = New FolderBrowserDialog()
            If folderBrowser.ShowDialog = DialogResult.OK Then tbImageFileLocation.Text = folderBrowser.SelectedPath
        End Using
    End Sub

    Private Sub tbSaveArtFileLocation_TextChanged(sender As Object, e As EventArgs) Handles tbSaveArtFileLocation.TextChanged
        tbSaveArtFileLocation.Text = sender.text
    End Sub

    Private Sub tbSaveLoadArtFile_TextChanged(sender As Object, e As EventArgs) Handles tbSaveLoadArtFile.TextChanged
        tbSaveLoadArtFile.Text = sender.text
    End Sub

    Private Sub tbSettingsFileLocation_TextChanged(sender As Object, e As EventArgs) Handles tbSettingsFileLocation.TextChanged
        tbSettingsFileLocation.Text = sender.text
    End Sub

    Private Sub tbImageFileLocation_TextChanged(sender As Object, e As EventArgs) Handles tbImageFileLocation.TextChanged
        tbImageFileLocation.Text = sender.text
    End Sub
#End Region

#Region "Events for Text Settings"
    'Private Sub nudLines_ValueChanged(sender As Object, e As EventArgs) Handles nudLines.ValueChanged

    'End Sub

    'Private Sub nudCharacters_ValueChanged(sender As Object, e As EventArgs) Handles nudCharacters.ValueChanged

    'End Sub

    'Private Sub tbFillCharacter_TextChanged(sender As Object, e As EventArgs) Handles tbFillCharacter.TextChanged

    'End Sub

    'Private Sub cbBackgroundTextColor_CheckedChanged(sender As Object, e As EventArgs) Handles cbBackgroundTextColor.CheckedChanged

    'End Sub

    'Private Sub cbBackgroundImage_CheckedChanged(sender As Object, e As EventArgs) Handles cbBackgroundImage.CheckedChanged

    'End Sub

    'Private Sub cbWebPresets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWebPresets.SelectedIndexChanged

    'End Sub

    'Private Sub buttonImageUp_Click(sender As Object, e As EventArgs) Handles buttonImageUp.Click

    'End Sub

    'Private Sub buttonImageDown_Click(sender As Object, e As EventArgs) Handles buttonImageDown.Click

    'End Sub
#End Region
End Class