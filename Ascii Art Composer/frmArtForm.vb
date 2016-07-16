'Imports Ascii_Art_Composer.RTBSettings

Public Class frmArt
    Public _rtbAggregate As RTBAggregate
    Public _SettingsAggerate As SettingsAggregate
    Public _SettingsForm As frmSettings
    Private _frmSettingsStack As Stack

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _rtbAggregate = New RTBAggregate(Me, Me.rtbArtBox)
        _SettingsAggerate = New SettingsAggregate(Me)
        _SettingsForm = New frmSettings(_SettingsAggerate)
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        FileSettings.Save(rtbArtBox)
    End Sub

    Private Sub SettingsShow() Handles tsmiSettings.Click
        _SettingsForm = New frmSettings(_SettingsAggerate)
        _SettingsForm.Show()
    End Sub
End Class
