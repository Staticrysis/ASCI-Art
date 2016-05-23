Public Class RTBDrawings
    Inherits RTBSource

    Dim rtbGraphics As Graphics
    Dim rtbRectangle As Rectangle
    Dim rtbPen As Pen

    Public _showDrawBox As Boolean = False

    Public Property ShowDrawBox As Boolean
        Get
            Return _showDrawBox
        End Get
        Set(value As Boolean)
            _showDrawBox = value
        End Set
    End Property

    Sub New(ByRef mainForm As frmArt, ByRef RTB As RichTextBox)
        MyBase.New(mainForm, RTB)
        rtbGraphics = RTB.CreateGraphics
        rtbPen = New Pen(Color.Green)

        'AddHandler Me.MAINFORM.TForShowBorders.Tick, AddressOf DrawBorderBox
        'AddHandler Me.MAINFORM.tsbShowHiddenSpace.Click, AddressOf ShowBox
        'AddHandler Me.MAINFORM.tsbShowHiddenSpace.Click, AddressOf DrawBorderBox
        'AddHandler Me.RTB.MouseUp, AddressOf DrawBoxLines
        AddHandler Me.RTB.MouseMove, AddressOf DrawBoxLines
    End Sub

    'TODO: IDK, I just want to make it so the user can see the edges of the txt editor
    'One way of doing this is to change background color font so the user will see all text (even spaces) that makes the RTB art
#Region "Draw Border Box Methods"
    Public Sub ShowBox()
        ShowDrawBox = If(ShowDrawBox = False, True, False)
    End Sub


    Public Sub DrawBoxLines(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Middle Then
            RTB.Refresh()
            rtbRectangle.Location = MiddleClickPoint 'New Rectangle(MiddleClickPoint.X, MiddleClickPoint.Y, MouseCurrentPoint.X, MouseCurrentPoint.Y)
            rtbRectangle.Width = MouseCurrentPoint.X - rtbRectangle.X
            rtbRectangle.Height = MouseCurrentPoint.Y - rtbRectangle.Y
            rtbGraphics.DrawRectangle(rtbPen, rtbRectangle)

        End If
    End Sub
#End Region

#Region "Utilities"
    Public Function GetFurthestCharX() As Int16
        Dim furthestChar As Int16 = 0
        Dim position As Point

        For Each line In rtb.Lines
            If line.Length > furthestChar Then
                furthestChar = line.Length
                position = rtb.GetPositionFromCharIndex(line.Length)
            End If
        Next

        Return position.X
    End Function

    Public Function GetFurthestLineY() As Int16
        Dim length As Int16 = rtb.Lines.Length
        Dim point As Point = rtb.GetPositionFromCharIndex(rtb.Text.Length)
        Return point.Y
    End Function
#End Region
End Class

