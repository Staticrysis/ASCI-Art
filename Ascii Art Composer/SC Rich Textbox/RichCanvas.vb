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

    Public Sub New(ByRef settings As SettingsAggregate)
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
    Public Property LeftIsDown As Boolean = False
    Public Property RightIsDown As Boolean = False
    Public Property MiddleIsDown As Boolean = False

    Public Property MouseCurrentPoint As Point

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
    Private Sub MouseMoveEvents(sender As Object, e As MouseEventArgs)
        MouseCurrentPoint = e.Location
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
    Private Sub Characters_TextChanged(sender As Object, e As EventArgs)
        Dim result As Int16
        If Not sender.Text = "" AndAlso Not Integer.TryParse(sender.text, result) AndAlso Not result <= 300 Then
            sender.Text = ""
        End If
    End Sub

    Private Sub Lines_TextChanged(sender As Object, e As EventArgs)
        Dim result As Boolean = False
        If Not sender.Text = "" AndAlso Not Integer.TryParse(sender.text, result) AndAlso Not result <= 100 Then
            sender.Text = ""
        End If
    End Sub

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
        If e.Delta >= 0 Then
            If ZoomFactor + 0.2 <= 64 Then
                ZoomFactor += 0.2F
            End If
        ElseIf e.Delta <= 0 Then
            If ZoomFactor - 0.2 > 1 Then
                ZoomFactor -= 0.2F
            End If
        End If
    End Sub

    Dim _pointIntegerSelectedCharacter As Integer
    'Handles inserting characters on a Mousemove event
    Public Sub DrawToCanvas() Handles Me.Draw
        _pointIntegerSelectedCharacter = GetCharIndexFromPosition(MouseCurrentPoint)
        If RightClickPoint <> MouseCurrentPoint _
            AndAlso _pointIntegerSelectedCharacter + Settings.Canvas.CursorCharacter.Length < Text.Length _
            AndAlso (_pointIntegerSelectedCharacter + Settings.Canvas.CursorCharacter.Length <= Text.Length) _
            AndAlso (Text.IndexOf(Chr(10), _pointIntegerSelectedCharacter, Settings.Canvas.CursorCharacter.Length) = -1) Then
            'ThreadPool.QueueUserWorkItem(New WaitCallback(
            '                             Sub()
            'Invoke(Sub()
            Text.Remove(_pointIntegerSelectedCharacter, Settings.Canvas.CursorCharacter.Length)
            Text = Text.Insert(_pointIntegerSelectedCharacter, Settings.Canvas.CursorCharacter)
            '        End Sub)

            'todo: needs some sortof way to avoid char(10)
            'End Sub))
        End If
    End Sub

    Public Sub WipeFromCanvas() Handles Me.Wipe
        _pointIntegerSelectedCharacter = GetCharIndexFromPosition(MouseCurrentPoint)
        If LeftClickPoint <> MouseCurrentPoint _
            AndAlso Not Text.IndexOf(ChrW(10)) = _pointIntegerSelectedCharacter Then
            'ThreadPool.QueueUserWorkItem(New WaitCallback(
            'Sub()
            ' Invoke(Sub()
            Text = Text.Remove(_pointIntegerSelectedCharacter, 1)
            Text = Text.Insert(_pointIntegerSelectedCharacter, " ")
            '      End Sub)
            'End Sub))
        End If
    End Sub

    'Todo: not sure but I think I should bring the mouse wheel editing back
    Public Sub AlterCharacters(sender As Object, e As MouseEventArgs)
        _pointIntegerSelectedCharacter = GetCharIndexFromPosition(MouseCurrentPoint)

        If _pointIntegerSelectedCharacter + Settings.Canvas.CursorCharacter.Length < Text.Length _
            AndAlso (_pointIntegerSelectedCharacter + Settings.Canvas.CursorCharacter.Length <= Text.Length) _
            AndAlso (Text.IndexOf(Chr(10), _pointIntegerSelectedCharacter, Settings.Canvas.CursorCharacter.Length) = -1) Then
            If e.Delta > 0 Then
                Text = Text.Insert(_pointIntegerSelectedCharacter, " ")
            ElseIf e.Delta < 0 Then
                Text = Text.Remove(_pointIntegerSelectedCharacter, 1)
            End If
        End If
    End Sub
#End Region
End Class
