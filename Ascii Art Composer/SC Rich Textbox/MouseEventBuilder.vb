'This class is a binding aggregate for all mouse clicks events of a control. 
'It extends and binds new properties to the given control.
Module MouseEventBuilder
#Region "Builders"
    Public Sub BindEvents(ByRef control As Control)
        AddHandler control.MouseMove, AddressOf MouseMoveEvents
        AddHandler control.MouseDown, AddressOf MouseClicks
        AddHandler control.MouseUp, AddressOf MouseRelease
        AddHandler control.MouseWheel, AddressOf MouseWheelEvents
    End Sub

    Public Sub UnbindEvents(ByRef control As Control)
        RemoveHandler control.MouseMove, AddressOf MouseMoveEvents
        RemoveHandler control.MouseDown, AddressOf MouseClicks
        RemoveHandler control.MouseUp, AddressOf MouseRelease
        RemoveHandler control.MouseWheel, AddressOf MouseWheelEvents
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
End Module
