'Imports Ascii_Art_Composer.RTBSettings
<Serializable>
Public Class frmArt
#Region "Forms and Aggregates"
    'Containing these aggregates in the main form class insures that it will persist 
    Public _rtbAggregate As RTBAggregate 'this one is different
    Public _SettingsAggregate As New SettingsAggregate

    Private FrmSettings As New frmSettings(_SettingsAggregate)
#End Region

    Sub New()
        ' This call is required by the designer. 
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _rtbAggregate = New RTBAggregate(Me, Me.rtbArtBox)
        _SettingsAggregate = Serialization.Open(_SettingsAggregate, "Settings", Nothing)
    End Sub

    Private Sub SterilizePath(ByRef agg As Object)
        Select Case agg
            Case GetType(SettingsAggregate)

            Case GetType(RTBAggregate)

        End Select
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles tsmiSave.Click
        Serialization.Save(_SettingsAggregate, "Settings", Nothing)
    End Sub

    Private Sub OpenFile_Click(sender As Object, e As EventArgs) Handles tsmiOpen.Click

    End Sub

    Private Sub ShowTextSettings() Handles tsmiText.Click
        FrmSettings.tcSettings.SelectTab(0)
        FrmSettings.ShowDialog()
    End Sub

    Private Sub ShowColorSettings() Handles tsmiColors.Click
        FrmSettings.tcSettings.SelectTab(1)
        FrmSettings.ShowDialog()
    End Sub

    Private Sub ShowFileSettings() Handles tsmiFiles.Click
        FrmSettings.tcSettings.SelectTab(2)
        FrmSettings.ShowDialog()
    End Sub
End Class
