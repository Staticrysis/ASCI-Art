'Imports Ascii_Art_Composer.RTBSettings

Public Class frmArt
    Public _rtbAggregate As RTBAggregate
    Public _SettingsAggregate As SettingsAggregate
    Public _SettingsForm As frmSettings
    Private _frmSettingsStack As Stack

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _rtbAggregate = New RTBAggregate(Me, Me.rtbArtBox)
        _SettingsAggregate = New SettingsAggregate(Me)
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles tsmiSave.Click
        _SettingsAggregate.FileSettings.Save()
    End Sub

    Private Sub OpenFile_Click(sender As Object, e As EventArgs) Handles tsmiOpen.Click
        _SettingsAggregate.FileSettings.Open()
    End Sub

    Private Sub ShowTextSettings() Handles tsmiText.Click
        _SettingsForm = New frmSettings(_SettingsAggregate)
        _SettingsForm.tpTextEditing.Focus()
        _SettingsForm.Show()
    End Sub

    Private Sub ShowColorSettings() Handles tsmiColors.Click
        _SettingsForm = New frmSettings(_SettingsAggregate)
        _SettingsForm.tpColors.Focus()
        _SettingsForm.Show()
    End Sub

    Private Sub ShowFileSettings() Handles tsmiFiles.Click
        _SettingsForm = New frmSettings(_SettingsAggregate)
        _SettingsForm.tpFiles.Focus()
        _SettingsForm.Show()
    End Sub
End Class
