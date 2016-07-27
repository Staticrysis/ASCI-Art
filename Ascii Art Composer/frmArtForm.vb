'Imports Ascii_Art_Composer.RTBSettings

Public Class frmArt
#Region "Forms and Aggregates"
    'Containing these aggregates in the main form class insures that it will prosist
    Public _rtbAggregate As RTBAggregate 'this one is different
    Public _SettingsAggregate As SettingsAggregate
#End Region

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _rtbAggregate = New RTBAggregate(Me, Me.rtbArtBox)
        _SettingsAggregate = New SettingsAggregate()
    End Sub

    Private Sub SterilizePath(ByRef agg As Object)
        Select Case agg
            Case GetType(SettingsAggregate)

            Case GetType(RTBAggregate)

        End Select
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles tsmiSave.Click
        JsonIO.SerialSave(_SettingsAggregate, "RTB", _SettingsAggregate.FileSettings.SettingsPath)
    End Sub

    Private Sub OpenFile_Click(sender As Object, e As EventArgs) Handles tsmiOpen.Click
        JsonIO.SerialOpen(_SettingsAggregate, "RTB", _SettingsAggregate.FileSettings.SettingsPath)
    End Sub

    Private Sub ShowTextSettings() Handles tsmiText.Click
        Using _SettingsForm = New frmSettings(_SettingsAggregate)
            _SettingsForm.ShowDialog()
        End Using
    End Sub

    Private Sub ShowColorSettings() Handles tsmiColors.Click
        Using _SettingsForm = New frmSettings(_SettingsAggregate)
            _SettingsForm.Show()
        End Using
    End Sub

    Private Sub ShowFileSettings() Handles tsmiFiles.Click
        Using _SettingsForm = New frmSettings(_SettingsAggregate)
            _SettingsForm.Show()
        End Using
    End Sub
End Class
