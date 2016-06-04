Imports System.Threading

Public Class RTBBehaviors
    Inherits RTBSource

    Dim _pointIntegerSelectedCharacter As Integer

    Private _handlesAlterCharacters As Boolean = True
    Private _handlesRightMouseButtonDown As Boolean = True
    Private _handlesLeftMouseButtonDown As Boolean = True
    Private _handlesMouseMove As Boolean = True
    Private _threadPool As Threading.ThreadPool

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

    Sub New(ByRef mainform As frmArt, ByRef RTB As RTBARTBox_MouseMove)
        MyBase.New(mainform, RTB)

#Region "Adding Handlers"
        AddHandler Me.RTB.MouseMove, AddressOf RTBARTBox_MouseMove
        AddHandler Me.RTB.MouseWheel, AddressOf Zoom
#End Region
    End Sub

#Region "Behavior Methods"
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
        If e.Button = MouseButtons.Right Then
            _pointIntegerSelectedCharacter = RTB.GetCharIndexFromPosition(MouseCurrentPoint)
            If RightClickPoint <> e.Location _
            AndAlso _pointIntegerSelectedCharacter + Symbol.Length < RTB.Text.Length _
            AndAlso (_pointIntegerSelectedCharacter + Symbol.Length <= RTB.Text.Length) _
            AndAlso (RTB.Text.IndexOf(Chr(10), _pointIntegerSelectedCharacter, Symbol.Length) = -1) Then
                ThreadPool.QueueUserWorkItem(New WaitCallback(
                                             Sub()
                                                 RTB.Invoke(Sub()
                                                                RTB.Text.Remove(_pointIntegerSelectedCharacter, Symbol.Length)
                                                                RTB.Text = RTB.Text.Insert(_pointIntegerSelectedCharacter, Symbol)
                                                            End Sub)
                                                 MouseCurrentPoint = e.Location
                                                 'todo: needs some sortof way to avoid char(10)
                                             End Sub))
            End If
        ElseIf e.Button = MouseButtons.Left Then
            _pointIntegerSelectedCharacter = RTB.GetCharIndexFromPosition(MouseCurrentPoint)
            If LeftClickPoint <> e.Location _
                AndAlso Not RTB.Text.IndexOf(ChrW(10)) = _pointIntegerSelectedCharacter Then
                ThreadPool.QueueUserWorkItem(New WaitCallback(
                                             Sub()
                                                 RTB.Invoke(Sub()
                                                                RTB.Text = RTB.Text.Remove(_pointIntegerSelectedCharacter, 1)
                                                                RTB.Text = RTB.Text.Insert(_pointIntegerSelectedCharacter, " ")
                                                            End Sub)
                                             End Sub))
            End If
        End If
    End Sub

    'Todo
    '
    Public Sub AlterCharacters(sender As Object, e As MouseEventArgs)
        _pointIntegerSelectedCharacter = RTB.GetCharIndexFromPosition(MouseCurrentPoint)

        If _pointIntegerSelectedCharacter + Symbol.Length < RTB.Text.Length _
            AndAlso (_pointIntegerSelectedCharacter + Symbol.Length <= RTB.Text.Length) _
            AndAlso (RTB.Text.IndexOf(Chr(10), _pointIntegerSelectedCharacter, Symbol.Length) = -1) Then
            If e.Delta > 0 Then
                RTB.Text = RTB.Text.Insert(_pointIntegerSelectedCharacter, " ")
            ElseIf e.Delta < 0 Then
                RTB.Text = RTB.Text.Remove(_pointIntegerSelectedCharacter, 1)
            End If
        End If
    End Sub
#End Region
End Class