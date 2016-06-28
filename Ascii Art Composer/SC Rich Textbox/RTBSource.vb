Public Class RTBSource
    Sub New(ByRef mainForm As frmArt, ByRef rtb As RTBARTBox_MouseMove)
        Me.MAINFORM = mainForm
        Me.RTB = rtb

        AddHandler Me.MAINFORM.tstbSymbol.TextChanged, AddressOf HandlesCurrentSymbol

        AddHandler Me.RTB.MouseMove, AddressOf HandlesCurrentMouseLocation
        AddHandler Me.RTB.MouseDown, AddressOf HandlesMiddleClickLocation
        AddHandler Me.RTB.MouseUp, AddressOf HandlesMiddleReleaseLocation

        AddHandler Me.RTB.MouseDown, AddressOf HandlesRightClickLocation
        AddHandler Me.RTB.MouseUp, AddressOf HandlesRightReleaseLocation

        AddHandler Me.RTB.MouseDown, AddressOf HandlesLeftClickLocation
        AddHandler Me.RTB.MouseUp, AddressOf HandlesLeftReleaseLocation
    End Sub
#Region "Event Variables"
    Protected MAINFORM As Ascii_Art_Composer.frmArt
    Protected RTB As Ascii_Art_Composer.RTBARTBox_MouseMove

    Private Shared _symbol As String ' = " " 'TODO: don't know if i want this to be global to the derivede classes yet

    Private Shared _mouseCurrentPoint As Point

    Private Shared _middleClickPoint As Point
    Private Shared _middleReleasePoint As Point
    Private Shared _middleIsDown As Boolean = False

    Private Shared _rightClickPoint As Point
    Private Shared _rightReleasePoint As Point
    Private Shared _rightIsDown As Boolean = False

    Private Shared _leftClickPoint As Point
    Private Shared _leftReleasePoint As Point
    Private Shared _leftIsDown As Boolean = False
#End Region

#Region "Properties"
    Public Property Symbol As String
        Get
            Return _symbol
        End Get
        Set(value As String)
            _symbol = value
        End Set
    End Property

    Public Property MouseCurrentPoint As Point
        Get
            Return _mouseCurrentPoint
        End Get
        Set(value As Point)
            _mouseCurrentPoint = value
        End Set
    End Property

    Public Property MiddleClickPoint As Point
        Get
            Return _middleClickPoint
        End Get
        Set(value As Point)
            _middleClickPoint = value
            _middleIsDown = True
        End Set
    End Property

    Public Property MiddleReleasePoint As Point
        Get
            Return _middleReleasePoint
        End Get
        Set(value As Point)
            _middleReleasePoint = value
            _middleIsDown = False
        End Set
    End Property

    Public Property RightClickPoint As Point
        Get
            Return _rightClickPoint
        End Get
        Set(value As Point)
            _rightClickPoint = value
            _rightIsDown = True
        End Set
    End Property

    Public Property RightReleasePoint As Point
        Get
            Return _rightReleasePoint
        End Get
        Set(value As Point)
            _rightReleasePoint = value
            _rightIsDown = False
        End Set
    End Property

    Public Property LeftClickPoint As Point
        Get
            Return _leftClickPoint
        End Get
        Set(value As Point)
            _leftClickPoint = value
            _rightIsDown = True
        End Set
    End Property

    Public Property LeftReleasePoint As Point
        Get
            Return _leftReleasePoint
        End Get
        Set(value As Point)
            _leftReleasePoint = value
            _leftIsDown = False
        End Set
    End Property
#End Region


#Region "Editor Settings"
    Private Sub HandlesCurrentSymbol(sender As ToolStripTextBox, e As EventArgs)
        Symbol = sender.Text
    End Sub
#End Region

#Region "Mouse Handlers"
     Private Sub HandlesCurrentMouseLocation(sender As Object, e As MouseEventArgs)
        'todo: preformence could be improved if i make a seperate thread to handles all the 
        'incomming mouse pointer locations 
        MouseCurrentPoint = e.Location
    End Sub

    Private Sub HandlesMiddleClickLocation(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Middle Then
            MiddleClickPoint = e.Location
        End If
    End Sub

    Private Sub HandlesMiddleReleaseLocation(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Middle Then
            MiddleReleasePoint = e.Location
        End If
    End Sub

    Private Sub HandlesRightClickLocation(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            RightClickPoint = e.Location
        End If
    End Sub

    Private Sub HandlesRightReleaseLocation(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            RightReleasePoint = e.Location
        End If
    End Sub

    Private Sub HandlesLeftClickLocation(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            LeftClickPoint = e.Location
        End If
    End Sub

    Private Sub HandlesLeftReleaseLocation(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            LeftReleasePoint = e.Location
        End If
    End Sub
#End Region
End Class
