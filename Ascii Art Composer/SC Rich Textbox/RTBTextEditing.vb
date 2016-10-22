Imports System.Threading

Module RTBTextHandler
#Region "Has Handles?"
    Public WriteOnly Property HandlesResetAndFill As Boolean
        Set(value As Boolean)
            If value = True Then
                AddHandler Me.MAINFORM.tsbReset.Click, AddressOf ResetAndFill
            Else
                RemoveHandler Me.MAINFORM.tsbReset.Click, AddressOf ResetAndFill
            End If
        End Set
    End Property

    Public WriteOnly Property HandlesArtBoxLines As Boolean
        Set(value As Boolean)
            If value = True Then
                AddHandler Me.MAINFORM.tstbLines.TextChanged, AddressOf Lines_TextChanged
            Else
                RemoveHandler Me.MAINFORM.tstbLines.TextChanged, AddressOf Lines_TextChanged
            End If
        End Set
    End Property

    Public WriteOnly Property HandlesSymbols As Boolean
        Set(value As Boolean)
            If value = True Then
                AddHandler Me.MAINFORM.tstbSymbol.TextChanged, AddressOf Characters_TextChanged
            Else
                RemoveHandler Me.MAINFORM.tstbSymbol.TextChanged, AddressOf Characters_TextChanged
            End If
        End Set
    End Property

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

    Dim rtbGraphics As Graphics
    Dim rtbRectangle As Rectangle
    Dim rtbPen As Pen


    Function Build(ByRef settings As SettingsAggregate, RTB As RichTextBox)

    End Function

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

    Public Sub ResetAndFill()
        Dim row As Int16 = If(Not Me.MAINFORM.tstbLines.Text = "", Integer.Parse(Me.MAINFORM.tstbLines.Text), 60)
        Dim chars As Int16 = If(Not Me.MAINFORM.tstbCharacters.Text = "", Integer.Parse(Me.MAINFORM.tstbCharacters.Text), 350)
        'Dim symbol As Char = " " ' Me.MAINFORM.tstbSymbol.Text.FirstOrDefault
        Dim symbolContainer As Char() = New Char(row * chars) {}
        RTB.Text = String.Empty

        For y As Int16 = 0 To row
            For x As Int16 = 0 To chars - 1
                symbolContainer(x) = " " 'Symbol TODO: this is for the future maybe. So the user can change all the text to match the current symbol.
            Next
            RTB.Text += Chr(10)
            RTB.Text += New String(symbolContainer)
        Next
    End Sub

    Public Function BoxText(ByVal text As String, Optional ByVal boxChar As Char = "#") As String
        Dim length As Int16 = text.Length

        'For closer As Int16 = 0 To 
        '        RichTextBox.Text += "#"
        'Next
        'For closer As Int16 = 0 To row * 4
        '    RichTextBox.Text += "#"
        'Next

        Return ""
    End Function

#Region "Behavior Methods"
    Sub Zoom(sender As Object, e As MouseEventArgs)
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
    Public Sub Draw(sender As Object, e As MouseEventArgs)
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

    'Todo: not sure but I think I sould bring the mouse will editing back
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
End Module