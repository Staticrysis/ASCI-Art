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
        SettingsAggregateBindingSource.DataSource = Settings
    End Sub

#Region "Settings"
    Private Sub BindUI() Handles Me.Load
        BindValidatingToValidator(Me)
        ValidationResultBindingSource.DataSource = ControlValidator.ValidationResults
        gvErrorList.DataSource = ControlValidator.ValidationResults
        AddHandler Me.btnReset.Click, AddressOf Me.rtbCanvas.RefillCanvas

        'AddHandler Me.NumberOfCharactersTextBox.Validating, AddressOf ControlValidator.ValidateProperty
    End Sub

    Private Sub SaveSettings(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        If Not ValidateAllObjectProperties(Settings) Then
            Select Case (MsgBox("Unable to save your settings. Do you still want to continue?", MsgBoxStyle.YesNo, "Validation Error Found"))
                Case MsgBoxResult.Yes : Exit Sub
                Case MsgBoxResult.No : e.Cancel = True
            End Select
        Else
            Serialization.Save(Settings, Nothing)
        End If
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

    Private Sub ShowTextSettings(sender As Object, e As EventArgs) Handles tsmiText.Click

    End Sub

    Private Sub ShowColorSettings(sender As Object, e As EventArgs) Handles tsmiColors.Click

    End Sub

    Private Sub ShowFileSettings(sender As Object, e As EventArgs) Handles tsmiFiles.Click

    End Sub

    'Private Sub DrawSymbolTextBox_TextChanged(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DrawSymbolTextBox.Validating
    '    e.Cancel = Not ControlPropertyValid(sender, ErrorProvider1, sender)
    'End Sub

    'Private Sub NumberOfLinesTextBox_TextChanged(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NumberOfLinesTextBox.Validating
    '    e.Cancel = Not ControlPropertyValid(sender, ErrorProvider1, sender)
    'End Sub
#End Region

#Region "RTB Text"
#End Region

#Region "Drawing Settings"
#End Region

#Region "ColorSettings"
#End Region
End Class
