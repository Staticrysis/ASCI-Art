Imports Ascii_Art_Composer

Public Class TextEditingSettings
    Inherits SettingsSource

    Public Sub New(ByRef mainForm As frmArt, ByRef settingsForm As frmSettings)
        MyBase.New(mainForm, settingsForm)
    End Sub

#Region "Settings Variables"
    Dim _symbol As String
    Dim _textLines As Int16
    Dim _textCharacters As Int16
    Dim _hiddenTextBackColor As Color
    Dim _showHiddenText As Boolean
#End Region

#Region "Class Properties"
#End Region

#Region "Setting Properties"
    Public Property Symbol As String
        Get
            Return _symbol
        End Get
        Set(value As String)
            _symbol = value
        End Set
    End Property

    Public Property TextLines As Int16
        Get
            Return _textLines
        End Get
        Set(value As Int16)    'Restricted: max 100 characters 
            If value >= 0 AndAlso value <= 100 Then
                _textLines = value
            End If
        End Set
    End Property

    Public Property TextCharacters As Int16
        Get
            Return _textCharacters
        End Get
        Set(value As Int16)    'Restricted: max 300 characters
            If value >= 0 AndAlso value <= 300 Then
                _textCharacters = value
            End If
        End Set
    End Property

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
            Return _showHiddenText
        End Get
        Set(value As Boolean)
            If value = False Then
                _RTB.SelectionBackColor = Color.Black
                _RTB.Update()
            Else
                _RTB.SelectAll()
                _RTB.SelectionBackColor = Color.Gray
            End If

            _showHiddenText = value
        End Set
    End Property
#End Region

#Region "Settings Methods"
#End Region
End Class
