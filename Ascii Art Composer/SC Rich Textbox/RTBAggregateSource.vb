Public Class RTBAggregateSource
    Private _behaviors As RTBBehaviors
    Private _drawings As RTBDrawings
    Private _textEditor As RTBTextEditor

    'Main perpose: using the helper class methods and properties
#Region "Properties"
    Public ReadOnly Property Behaviors As RTBBehaviors
        Get
            Return _behaviors
        End Get
    End Property

    Public ReadOnly Property DrawOptions As RTBDrawings
        Get
            Return _drawings
        End Get
    End Property

    Public ReadOnly Property TextEditor As RTBTextEditor
        Get
            Return _textEditor
        End Get
    End Property
#End Region

    Public Sub New(ByRef MainForm As Ascii_Art_Composer.frmArt, ByRef RTB As RichTextBox)
        _behaviors = New RTBBehaviors(MainForm, RTB)
        _drawings = New RTBDrawings(MainForm, RTB)
        _textEditor = New RTBTextEditor(MainForm, RTB)
    End Sub
End Class
