Public Class RichCanvas
    Inherits RichTextBox
    Private WM_SETFOCUS As Integer = &H7

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Let everything through except for the WM_SETFOCUS message
        'TODO: need to stop redraw/update flickers here
        If (m.Msg <> WM_SETFOCUS) Then
            MyBase.WndProc(m)
        End If
    End Sub

    Public Sub New()
        BindEvents()
    End Sub

#Region "Builders"
    Public Sub BindEvents()
        AddHandler MouseMove, AddressOf MouseMoveEvents
        AddHandler MouseDown, AddressOf MouseClicks
        AddHandler MouseUp, AddressOf MouseRelease
        AddHandler MouseWheel, AddressOf MouseWheelEvents
    End Sub

    Public Sub UnbindEvents()
        RemoveHandler MouseMove, AddressOf MouseMoveEvents
        RemoveHandler MouseDown, AddressOf MouseClicks
        RemoveHandler MouseUp, AddressOf MouseRelease
        RemoveHandler MouseWheel, AddressOf MouseWheelEvents
    End Sub
#End Region
#Region "Mouse Event Properties"
    Public Property LeftIsDown As Boolean = False
    Public Property RightIsDown As Boolean = False
    Public Property MiddleIsDown As Boolean = False

    Public Property MouseCurrentPoint As Point
    Public Property MiddleClickPoint As Point
    Public Property MiddleReleasePoint As Point
    Public Property RightClickPoint As Point
    Public Property RightReleasePoint As Point
    Public Property LeftClickPoint As Point
    Public Property LeftReleasePoint As Point

    Public Event Draw(e As MouseEventArgs)
    Public Event Wipe(e As MouseEventArgs)
    Public Event Crop(e As MouseEventArgs)
    Public Event Zoom(e As MouseEventArgs)
#End Region

#Region "Mouse Handlers"
    Private Sub MouseMoveEvents(sender As Object, e As MouseEventArgs)
        MouseCurrentPoint = e.Location
        If LeftIsDown Then RaiseEvent Wipe(e)
        If RightIsDown Then RaiseEvent Draw(e)
        If MiddleIsDown Then RaiseEvent Crop(e)
    End Sub

    Private Sub MouseWheelEvents(sender As Object, e As MouseEventArgs)
        RaiseEvent Zoom(e)
    End Sub

    Private Sub MouseClicks(sender As Object, e As MouseEventArgs)
        Select Case (e.Button)
            Case MouseButtons.Left : LeftClickPoint = e.Location : LeftIsDown = True
            Case MouseButtons.Right : RightClickPoint = e.Location : RightIsDown = True
            Case MouseButtons.Middle : MiddleClickPoint = e.Location : MiddleIsDown = True
        End Select
    End Sub

    Private Sub MouseRelease(sender As Object, e As MouseEventArgs)
        Select Case (e.Button)
            Case MouseButtons.Left : LeftReleasePoint = e.Location : LeftIsDown = False
            Case MouseButtons.Right : RightReleasePoint = e.Location : RightIsDown = False
            Case MouseButtons.Middle : MiddleReleasePoint = e.Location : MiddleIsDown = False
        End Select
    End Sub
#End Region
End Class
