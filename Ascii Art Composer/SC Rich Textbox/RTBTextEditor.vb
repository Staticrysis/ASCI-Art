Public Class RTBTextEditor
    Inherits RTBSource

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
#End Region

    Sub New(ByRef mainForm As frmArt, ByRef RTB As RichTextBox)
        MyBase.New(mainForm, RTB)
        AddHandler Me.MAINFORM.tstbCharacters.TextChanged, AddressOf Characters_TextChanged
        AddHandler Me.MAINFORM.tstbLines.TextChanged, AddressOf Lines_TextChanged
        AddHandler Me.MAINFORM.tsbReset.Click, AddressOf ResetAndFill
        AddHandler Me.MAINFORM.tsbShowHiddenSpace.Click, AddressOf ChangeBackColor
    End Sub

    Public Sub SetSymbol_TextChanged(sender As Object, e As EventArgs)

    End Sub

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
        Dim symbol As Char = " " ' Me.MAINFORM.tstbSymbol.Text.FirstOrDefault
        Dim symbolContainer As Char() = New Char(row * chars) {}
        RTB.Text = String.Empty

        For y As Int16 = 0 To row
            For x As Int16 = 0 To chars - 1
                symbolContainer(x) = symbol
            Next
            RTB.Text += Chr(10)
            RTB.Text += New String(symbolContainer)
        Next
    End Sub

    Public Sub ChangeBackColor()
        If Not Equals(RTB.SelectionBackColor, Color.Black) Then
            RTB.SelectionBackColor = Color.Black
            RTB.Update()
            MAINFORM.tsbShowHiddenSpace.Text = "Show Hidden Space"
        Else
            RTB.SelectAll()
            RTB.SelectionBackColor = Color.Gray
            MAINFORM.tsbShowHiddenSpace.Text = "Hide Hidden Space"
        End If
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
End Class