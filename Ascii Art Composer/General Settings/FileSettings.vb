Imports System.IO

Public Class FileSettings
    Public Shared Function Save(ByRef richTextBox As RichTextBox)
        ' Create a string array with the lines of text
        Dim text As String = richTextBox.Text

        ' Set a variable to the My Documents path.
        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        ' Write the text to a new file named "WriteFile.txt".
        File.WriteAllText(mydocpath & Convert.ToString("\AsciiArtFile.txt"), text)
    End Function

    Public Function Open(ByRef richTextBox As RichTextBox)

    End Function
End Class
