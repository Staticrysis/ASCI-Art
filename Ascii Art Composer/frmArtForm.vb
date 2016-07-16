'Imports Ascii_Art_Composer.RTBSettings

Public Class frmArt
    Public _rtbAggregate As RTBAggregate
    Public _SettingsAggerate As SettingsAggregate
    Public _SettingsForm As frmSettings

    Private Sub frmArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _rtbAggregate = New RTBAggregate(Me, Me.rtbArtBox)
        _SettingsForm = New frmSettings(_SettingsAggerate)
        _SettingsAggerate = New SettingsAggregate(Me)

    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        FileSettings.Save(rtbArtBox)
    End Sub

    Private Sub Settings() Handles tsmiSettings.Click
        _SettingsForm.Show()
    End Sub
End Class
