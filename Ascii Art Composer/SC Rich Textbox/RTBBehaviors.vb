Public Class RTBBehaviors
    Inherits RTBSource

    Private _handlesAlterCharacters As Boolean = True
    Private _handlesRightMouseButtonDown As Boolean = True
    Private _handlesLeftMouseButtonDown As Boolean = True
    Private _handlesMouseMove As Boolean = True


#Region "Handlers: Set"
    Public WriteOnly Property HandlesRightMouseButtonDown As Boolean
        Set(value As Boolean)
            If value = True Then
                'AddHandler Me.RTB.MouseWheel, AddressOf 
            Else
                'RemoveHandler Me.RTB.MouseWheel, AddressOf 
            End If
            _handlesRightMouseButtonDown = value
        End Set
    End Property

    Public WriteOnly Property HandlesLeftMouseButtonDown As Boolean
        Set(value As Boolean)
            If value = True Then
                'AddHandler Me.RTB.MouseWheel, AddressOf
            Else
                'RemoveHandler Me.RTB.MouseWheel, AddressOf
            End If
            _handlesLeftMouseButtonDown = value
        End Set
    End Property

    Public WriteOnly Property HandlesMouseMove As Boolean
        Set(value As Boolean)
            If value = True Then
                AddHandler Me.RTB.MouseMove, AddressOf RTBARTBox_MouseMove
            Else
                RemoveHandler Me.RTB.MouseMove, AddressOf RTBARTBox_MouseMove
            End If
            _handlesMouseMove = value
        End Set
    End Property

    Public WriteOnly Property HandlesAlterCharacters As Boolean
        Set(value As Boolean)
            If value = True Then
                AddHandler Me.RTB.MouseWheel, AddressOf AlterCharacters
            Else
                RemoveHandler Me.RTB.MouseWheel, AddressOf AlterCharacters
            End If
            _handlesAlterCharacters = value
        End Set
    End Property
#End Region

    Sub New(ByRef mainform As frmArt, ByRef RTB As RTBArtBox)
        MyBase.New(mainform, RTB)


#Region "Adding Handlers"
        AddHandler Me.RTB.MouseDown, AddressOf RightMouseButtonDown
        AddHandler Me.RTB.MouseDown, AddressOf LeftMouseButtonDown
        AddHandler Me.RTB.MouseMove, AddressOf RTBARTBox_MouseMove
        AddHandler Me.RTB.MouseWheel, AddressOf Zoom
#End Region
    End Sub

#Region "Behavior Methods"
    'TODO
    Private Sub RightMouseButtonDown(sender As Object, e As MouseEventArgs)

    End Sub

    'TODO
    Private Sub LeftMouseButtonDown(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Zoom(sender As Object, e As MouseEventArgs)
        'Right now, ZoomFactor is hard-codded to be modified by 0.2
        'This could be a property in the future that allows the user to change but idk if i want that
        If e.Delta >= 0 Then
            If Me.RTB.ZoomFactor + 0.2 <= 64 Then
                Me.RTB.ZoomFactor += 0.2F
            End If
        ElseIf e.Delta <= 0 Then
            If Me.RTB.ZoomFactor - 0.2 > 1 Then
                Me.RTB.ZoomFactor -= 0.2F
            End If
        End If
    End Sub

    'Handles inserting characters on a Mousemove event
    Private Sub RTBARTBox_MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right AndAlso Not RightClickPoint = e.Location Then
            MouseCurrentPoint = e.Location
            InsertCharacters(e)
        ElseIf e.Button = MouseButtons.Left Then

        End If
    End Sub

    'sub method
    'Inserts the current symbol into the RGB at a x,y co-ordinate 
    'TODO: this symbol @ will cause a crash
    Public Sub InsertCharacters(ByRef e As MouseEventArgs)
        Dim currentChar As Integer = RTB.GetCharIndexFromPosition(MouseCurrentPoint)

        If currentChar + Symbol.Length < RTB.Text.Length _
            AndAlso (currentChar + Symbol.Length <= RTB.Text.Length) _
            AndAlso (RTB.Text.IndexOf(Chr(10), currentChar, Symbol.Length) = -1) Then

            If e.Button = MouseButtons.Right Then
                RTB.Text = RTB.Text.Remove(currentChar, Symbol.Length)
                RTB.Text = RTB.Text.Insert(currentChar, Symbol)
            ElseIf e.Button = MouseButtons.Left Then
                RTB.Text = RTB.Text.Remove(currentChar, Symbol.Length)
            End If
        End If
        RTB.Refresh()
    End Sub

    'Todo
    '
    Public Sub AlterCharacters(sender As Object, e As MouseEventArgs)
        Dim currentChar As Integer = RTB.GetCharIndexFromPosition(New Point(e.X, e.Y))

        If currentChar + Symbol.Length < RTB.Text.Length _
            AndAlso (currentChar + Symbol.Length <= RTB.Text.Length) _
            AndAlso (RTB.Text.IndexOf(Chr(10), currentChar, Symbol.Length) = -1) Then

            If e.Delta > 0 Then
                RTB.Text = RTB.Text.Insert(currentChar, " ")
            ElseIf e.Delta < 0 Then
                RTB.Text = RTB.Text.Remove(currentChar, 1)
            End If
        End If
    End Sub
#End Region
End Class