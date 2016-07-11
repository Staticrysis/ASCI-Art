Public Class frmSettings
    Public _settingsAggregate As SettingsAggregate
    Public _artForm As frmArt

    Public Sub New(ByRef settingsAggregate As SettingsAggregate)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class