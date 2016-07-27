Imports System.IO

Public Class FileSettings
    Inherits SettingsSource

    Public Sub New()
    End Sub

#Region "File Settings: Variables and Properties"
    Protected _ArtSaveFilePath As String
    Protected _ArtLoadFilePath As String
    Protected _ArtSettingsFilePath As String
    Protected _ImageFilePath As String

    Public Property ArtSavePath As String
        Get
            Return _ArtSaveFilePath
        End Get
        Set(value As String)
            _ArtSaveFilePath = value
        End Set
    End Property

    Public Property ArtLoadPath As String
        Get
            Return _ArtLoadFilePath
        End Get
        Set(value As String)
            _ArtLoadFilePath = value
        End Set
    End Property

    Public Property SettingsPath As String
        Get
            Return _ArtSettingsFilePath
        End Get
        Set(value As String)
            _ArtSettingsFilePath = value
        End Set
    End Property

    Public Property ImagePath As String
        Get
            Return _ImageFilePath
        End Get
        Set(value As String)
            _ImageFilePath = value
        End Set
    End Property
#End Region

    Public Function Open() As Boolean

        Return True
    End Function

    Public Function Save() As Boolean

        ' Create a string array with the lines of text
        Dim text As String = _rtbArtbox.Text

        ' Set a variable to the My Documents path.
        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        ' Write the text to a new file named "WriteFile.txt".
        File.WriteAllText(mydocpath & Convert.ToString("\AsciiArtFile.txt"), text)
        Return True
    End Function

    Public Function Open(ByRef richTextBox As RichTextBox)
        Return True
    End Function
End Class
