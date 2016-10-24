'Imports Ascii_Art_Composer.RTBSettings
<Serializable>
Public Class frmArt
    Private Settings As New SettingsAggregate
    'Private RTB_TextSettings As New RTBTextEditing(Settings, rtbArtBox)
    'Private RTB_DrawingSettings As New RTBDrawings(Me, rtbArtBox)
    Private WithEvents FrmSettings As New frmSettings(Settings)

    Sub New()
        ' This call is required by the designer. 
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Settings = Serialization.Open(Settings, "Settings", Nothing)
        ' MouseEventBuilder.BindEvents(rtbArtBox)
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

    'Private Sub ClosingFrmSettings() Handles FrmSettings.Closing
    '    Settings = Serialization.Open(Settings, Settings.ToString, Serialization.DEFAULTPATH)
    'End Sub
#End Region

#Region "RTB Text"
#End Region

#Region "Drawing Settings"
    Dim rtbGraphics As Graphics
    Dim rtbRectangle As Rectangle
    Dim rtbPen As Pen

    Public Sub DrawBoxLines(sender As Object, e As MouseEventArgs) Handles rtbArtBox.MouseMove
        If e.Button = MouseButtons.Middle Then
            rtbArtBox.Refresh()
            rtbRectangle.Location = MiddleClickPoint 'New Rectangle(MiddleClickPoint.X, MiddleClickPoint.Y, MouseCurrentPoint.X, MouseCurrentPoint.Y)
            rtbRectangle.Width = MouseCurrentPoint.X - rtbRectangle.X
            rtbRectangle.Height = MouseCurrentPoint.Y - rtbRectangle.Y
            rtbGraphics.DrawRectangle(rtbPen, rtbRectangle)
        End If
    End Sub

    Public Function GetFurthestCharX() As Int16
        Dim furthestChar As Int16 = 0
        Dim position As Point

        For Each line In rtbArtBox.Lines
            If line.Length > furthestChar Then
                furthestChar = line.Length
                position = rtbArtBox.GetPositionFromCharIndex(line.Length)
            End If
        Next

        Return position.X
    End Function

    Public Function GetFurthestLineY() As Int16
        Dim length As Int16 = rtbArtBox.Lines.Length
        Dim point As Point = rtbArtBox.GetPositionFromCharIndex(rtbArtBox.Text.Length)
        Return point.Y
    End Function
#End Region

#Region "ColorSettings"
#End Region
End Class
