'Note: This aggregate class contains all the helper classes related to the RichTextBox
Public Class RTBAggregate
    Public Sub New(ByRef MainForm As Ascii_Art_Composer.frmArt, ByRef RTB As RichTextBox)
        _mainForm = MainForm
        _RTB = RTB
        _drawings = New RTBDrawings(MainForm, RTB)
        _textEditor = New RTBTextEditing(MainForm, RTB)
    End Sub

#Region "Class Variables"
    Private _mainForm As frmArt
    Private _RTB As RichTextBox
    Private _drawings As RTBDrawings
    Private _textEditor As RTBTextEditing
#End Region
End Class
