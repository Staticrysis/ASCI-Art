'Imports Ascii_Art_Composer.RTBSettings
<Serializable>
Public Class frmArt
    Private Settings As SettingsAggregate = Open(New SettingsAggregate, Nothing)
    Private WithEvents FrmSettings As New frmSettings(Settings)

    Sub New()
        ' This call is required by the designer. 
        InitializeComponent()
        rtbCanvas.Build(Settings)
        rtbCanvas.RefillCanvas()

        BindUI()
    End Sub

#Region "Settings"
    Private Sub BindUI()
        AddHandler Me.tsbReset.Click, AddressOf Me.rtbCanvas.RefillCanvas
    End Sub

    Private Sub SaveSettings()
        Serialization.Save(Settings, Nothing)
    End Sub

    Private Sub OpenSettings()
        Settings = Serialization.Open(Settings, Nothing)
    End Sub

    Private Sub ShowTextSettings() Handles tsmiText.Click
        FrmSettings.tcSettings.SelectTab(0) : FrmSettings.ShowDialog()
    End Sub

    Private Sub ShowColorSettings() Handles tsmiColors.Click
        FrmSettings.tcSettings.SelectTab(1) : FrmSettings.ShowDialog()
    End Sub

    Private Sub ShowFileSettings() Handles tsmiFiles.Click
        FrmSettings.tcSettings.SelectTab(2) : FrmSettings.ShowDialog()
    End Sub
#End Region

#Region "RTB Text"
#End Region

#Region "Drawing Settings"
#End Region

#Region "ColorSettings"
#End Region
End Class
