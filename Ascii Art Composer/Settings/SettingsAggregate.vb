Imports System.ComponentModel

<Serializable>
Public Class SettingsAggregate
#Region "Class Properties"
    Public Property Files As New Files
    Public Property Canvas As New CanvasText
    Public Property Colors As New Colors
#End Region
End Class

<Serializable>
Public Class SettingSource
    Implements INotifyPropertyChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub
End Class

<Serializable>
Public Class Files
    Inherits SettingSource
#Region "File Settings: Variables and Properties"
    Public Property ArtLoadPath As String = ""
    Public Property ArtSavePath As String = ""
    Public Property SettingsPath As String = ""
    Public Property ImagePath As String = ""
#End Region
End Class

<Serializable>
Public Class CanvasText
    Enum WebsitePresets
        None
        Facebook
        Youtube
    End Enum

    Public Property WebPresets As String() = [Enum].GetNames(GetType(WebsitePresets)).ToArray
    Public Property WebPreset As String
    Public Property NumberOfLines As Integer = 60
    Public Property NumberOfCharacters As Integer = 300
    Public Property CursorCharacter As String = " "
    Public Property FillCharacter As String = " "
    Public Property ShowBackgroundTextColor As Boolean
    Public Property ShowBackgroundImage As Boolean
    Public Property ShowHiddenTextColor As Color 'made some changes that may have broke it, work on it later
    Public Property ShowHiddenText As Boolean
End Class

<Serializable>
Public Class Colors
    Inherits SettingSource
#Region "Color Settings: Variables and Properties"
    Public Property RTBForeColors As New Color
    Public Property RTBBackColors As New Color
    Public Property RTBTextHighlightColors As New Color
    Public Property GUIForeColors As New Color
    Public Property GUIBackColors As New Color
    Public Property GUITextColors As New Color
#End Region
End Class