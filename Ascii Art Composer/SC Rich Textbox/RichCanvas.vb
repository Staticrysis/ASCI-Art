Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Input.Keyboard
'Imports System.Windows.Input.Mouse ' PointToClient(MousePosition)
'Imports System.Windows.Input.MouseButtonState

Public Class RichCanvas
    Inherits RichTextBox

    Private WM_SETFOCUS As Integer = &H7
    Private Settings As SettingsAggregate

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Let everything through except for the WM_SETFOCUS message
        'TODO: need to stop redraw/update flickers here
        If (m.Msg <> WM_SETFOCUS) Then
            MyBase.WndProc(m)
        End If
    End Sub

    Public Sub New()
    End Sub 'Custom controls require an empty sub for editing

    Public Sub Build(ByRef settings As SettingsAggregate)
        Me.Settings = settings
        BindEvents()
    End Sub

#Region "Builders"
    Public Sub BindEvents()
        AddHandler MouseMove, AddressOf MouseMoveEvents
        AddHandler MouseDown, AddressOf MouseClicks
        AddHandler MouseUp, AddressOf MouseRelease
        AddHandler MouseWheel, AddressOf ZoomOnCanvas
    End Sub

    Public Sub UnbindEvents()
        RemoveHandler MouseMove, AddressOf MouseMoveEvents
        RemoveHandler MouseDown, AddressOf MouseClicks
        RemoveHandler MouseUp, AddressOf MouseRelease
        RemoveHandler MouseWheel, AddressOf ZoomOnCanvas
    End Sub
#End Region
#Region "Mouse Event Properties"
    'Public Property LeftIsDown As Boolean = False ': System.Windows.Input.Mouse.leftButton.Pressed
    'Public Property RightIsDown As Boolean = False
    'Public Property MiddleIsDown As Boolean = False

    Public Property CurrentKeyDown As Char = Nothing

    Public Property MiddleFirstClickPoint As Point
    Public Property MiddleClickPoint As Point
    Public Property MiddleReleasePoint As Point

    Public Property RightFirstClickPoint As Point
    Public Property RightClickPoint As Point
    Public Property RightReleasePoint As Point

    Public Property LeftFirstClickPoint As Point
    Public Property LeftClickPoint As Point
    Public Property LeftReleasePoint As Point

    Public Event Draw()
    Public Event Wipe()
    Public Event Crop()
    Public Event Zoom()
#End Region
#Region "Mouse Handlers"
    Private Sub MouseMoveEvents(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If LeftIsDown Then RaiseEvent Draw()
        If RightIsDown Then RaiseEvent Wipe()
        If MiddleIsDown Then RaiseEvent Crop()
    End Sub



    Private Sub MouseClicks(sender As Object, e As MouseEventArgs)
        Select Case (e.Button)
            Case MouseButtons.Left : LeftFirstClickPoint = e.Location : LeftClickPoint = e.Location : LeftIsDown = True
            Case MouseButtons.Right : RightFirstClickPoint = e.Location : RightClickPoint = e.Location : RightIsDown = True
            Case MouseButtons.Middle : MiddleFirstClickPoint = e.Location : MiddleClickPoint = e.Location : MiddleIsDown = True
        End Select
    End Sub

    Private Sub MouseRelease(sender As Object, e As MouseEventArgs)
        Select Case (e.Button)
            Case MouseButtons.Left : LeftReleasePoint = e.Location : LeftIsDown = False
            Case MouseButtons.Right : RightReleasePoint = e.Location : RightIsDown = False
            Case MouseButtons.Middle : MiddleReleasePoint = e.Location : MiddleIsDown = False : RaiseEvent Crop()
        End Select
    End Sub
#End Region

#Region "Draw Methods"
    Public Sub DrawCropLines()
        'TODO: If to crop for text within limits
        Dim Graphics As Graphics : Dim Rectangle As Rectangle : Dim Pen As New Pen(Color.Gold)
        Refresh()
        Rectangle.Location = MiddleClickPoint 'New Rectangle(MiddleClickPoint.X, MiddleClickPoint.Y, MouseCurrentPoint.X, MouseCurrentPoint.Y)
        Rectangle.Width = MouseCurrentPoint.X - Rectangle.X
        Rectangle.Height = MouseCurrentPoint.Y - Rectangle.Y
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
        Graphics.DrawRectangle(Pen, Rectangle)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
    End Sub

    'Cropping expansion limits
    Public Function GetFurthestCharX() As Integer
        Dim furthestChar As Integer = 0
        Dim position As Point

        For Each line In Lines
            If line.Length > furthestChar Then
                furthestChar = line.Length
                position = GetPositionFromCharIndex(line.Length)
            End If
        Next

        Return position.X
    End Function

    Public Function GetFurthestLineY() As Integer
        Dim length As Integer = Lines.Length
        Dim point As Point = GetPositionFromCharIndex(Text.Length)
        Return point.Y
    End Function
#End Region

#Region "Text Methods"
    Public Sub RefillCanvas()
        Dim symbolContainer As Char() = New Char(Settings.Canvas.NumberOfLines * Settings.Canvas.NumberOfCharacters) {}
        Text = String.Empty

        For y As Integer = 0 To Settings.Canvas.NumberOfLines
            For x As Integer = 0 To Settings.Canvas.NumberOfCharacters - 1
                symbolContainer(x) = Settings.Canvas.FillCharacter
            Next
            Text += Chr(10)
            Text += New String(symbolContainer)
        Next
    End Sub

    Sub ZoomOnCanvas(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        'Right now, ZoomFactor is hard-codded to be modified by 0.2
        If IsKeyDown(System.Windows.Input.Key.LeftCtrl) Or
           IsKeyDown(System.Windows.Input.Key.RightCtrl) Then
            If e.Delta >= 0 Then
                If ZoomFactor + 0.2 <= 64 Then
                    ZoomFactor += 0.2F
                End If
            ElseIf e.Delta <= 0 Then
                If ZoomFactor - 0.2 > 1 Then
                    ZoomFactor -= 0.2F
                End If
            End If
        End If
    End Sub

    Dim charPoint As Integer

    Public Sub DrawToCanvas(obj As Object, e As MouseEventArgs) Handles Me.MouseMove, Me.MouseClick
        charPoint = GetCharIndexFromPosition(e.Location)
        If e.Button = MouseButtons.Left _
            AndAlso CurrentKeyDown <> Nothing _
            AndAlso Text.ToCharArray()(charPoint) <> Chr(10) Then
            Dim sb As New StringBuilder(Text)
            sb(charPoint) = CurrentKeyDown
            Text = sb.ToString
        End If
    End Sub

    Public Sub WipeFromCanvas(obj As Object, e As MouseEventArgs) Handles Me.MouseMove, Me.MouseClick
        charPoint = GetCharIndexFromPosition(e.Location)
        If e.Button = MouseButtons.Right AndAlso Text.ToCharArray()(charPoint) <> Chr(10) Then
            Text = Text.Remove(charPoint, 1)
            Text = Text.Insert(charPoint, " ")

        End If
    End Sub

    Public Sub AlterCharacters(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        charPoint = GetCharIndexFromPosition(e.Location)

        If charPoint + Settings.Canvas.CursorCharacter.Length < Text.Length _
            AndAlso (charPoint + Settings.Canvas.CursorCharacter.Length <= Text.Length) _
            AndAlso (Text.IndexOf(Chr(10), charPoint, Settings.Canvas.CursorCharacter.Length) = -1) Then
            If e.Delta > 0 Then
                Text = Text.Insert(charPoint, " ")
            ElseIf e.Delta < 0 Then
                Text = Text.Remove(charPoint, 1)
            End If
        End If
    End Sub

    Public Sub KeyDownEvent(obj As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case (e.KeyCode)
            Case Keys.Enter
            Case Keys.ControlKey
            Case Keys.CapsLock
            Case Keys.Tab
            Case Keys.ShiftKey
            Case Else : CurrentKeyDown = Chr(e.KeyValue)
        End Select
        e.SuppressKeyPress = True
    End Sub

    Public Sub KeyUpEvent(obj As Object, e As KeyEventArgs) Handles Me.KeyUp
        CurrentKeyDown = Nothing
    End Sub
#End Region
End Class
