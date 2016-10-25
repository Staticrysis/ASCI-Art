'Imports Ascii_Art_Composer.RTBSettings
<Serializable>
Public Class frmArt
    Private Settings As New SettingsAggregate
    Private WithEvents FrmSettings As New frmSettings(Settings)

    Sub New()
        ' This call is required by the designer. 
        InitializeComponent()
    End Sub



#Region "Settings"
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles tsmiSave.Click
        Serialization.Save(Settings, "Settings", Nothing)
    End Sub

    Private Sub OpenFile_Click(sender As Object, e As EventArgs) Handles tsmiOpen.Click

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

    Private Sub frmArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "RTB Text"
#End Region

#Region "Drawing Settings"
#End Region

#Region "ColorSettings"
#End Region
End Class
