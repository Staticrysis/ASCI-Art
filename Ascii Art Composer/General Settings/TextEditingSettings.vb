Imports Ascii_Art_Composer

Public Class TextEditingSettings
    Inherits SettingsSource

    Public Sub New(ByRef mainForm As frmArt)
        MyBase.New(mainForm)
        _rtb = mainForm.rtbArtBox
    End Sub

#Region "Text Editing Settings: Variables and Properties"
    Protected Enum WebPresets
        None
        Facebook
        Youtube
    End Enum

    Protected _rtb As RTBArtBox
    Protected _LineNumber As Integer
    Protected _CharacterNumber As Integer
    Protected _CursorCharactor As Char = " "
    Protected _FillCharacter As Char = " "
    Protected _BackgroundTextColor As Boolean = False
    Protected _BackgroundImage As Boolean = False

    Private _ShowHiddenText As Boolean
    Private _HiddenTextBackColor As Color

    Public Property LineNumber As Integer
        Get
            Return _LineNumber
        End Get
        Set(value As Integer)
            If value >= 0 AndAlso value <= 300 Then
                _CharacterNumber = value
            End If
        End Set
    End Property

    Public Property CharacterNumber As Integer
        Get
            Return _CharacterNumber
        End Get
        Set(value As Integer)
            If value >= 0 AndAlso value <= 100 Then
                _CharacterNumber = value
            End If
        End Set
    End Property

    Public Property CursorCharacter As Char
        Get
            Return _CursorCharactor
        End Get
        Set(value As Char)
            _CursorCharactor = value
        End Set
    End Property

    Public Property FillCharacter As Char
        Get
            Return _FillCharacter
        End Get
        Set(value As Char)
            _FillCharacter = value
        End Set
    End Property

    Public Property ShowBackgroundTextColor As Boolean
        Get
            Return _BackgroundTextColor
        End Get
        Set(value As Boolean)
            _BackgroundTextColor = value
        End Set
    End Property

    Public Property ShowBackgroundImage As Boolean
        Get
            Return _BackgroundImage
        End Get
        Set(value As Boolean)
            _BackgroundImage = value
        End Set
    End Property

    'made some changes that may have broke it, work on it later
    Public Property ShowHiddenTextColor As Color
        Get
            Return _hiddenTextBackColor
        End Get
        Set(value As Color)
            _hiddenTextBackColor = value
        End Set
    End Property

    Public Property ShowHiddenText As Boolean
        Get
            Return _ShowHiddenText
        End Get
        Set(value As Boolean)
            If value = False Then
                _rtb.SelectionBackColor = Color.Black
                _rtb.Update()
            Else
                _rtb.SelectAll()
                _rtb.SelectionBackColor = Color.Gray
            End If

            _ShowHiddenText = value
        End Set
    End Property
#End Region

#Region "Settings Methods"
#End Region
End Class
