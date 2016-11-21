Imports System.ComponentModel
Imports System.Attribute
Imports System.ComponentModel.DataAnnotations


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
    <Required> Public Property ArtLoadPath As String = ""
    <Required> Public Property ArtSavePath As String = ""
    <Required> Public Property SettingsPath As String = ""
    <Required> Public Property ImagePath As String = ""
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
    <Required> <Range(1, 60)> Public Property NumberOfLines = 60
    <Required> <Range(1, 300)> Public Property NumberOfCharacters = 300
    <Required(AllowEmptyStrings:=True)> <StringLength(1)> Public Property CursorCharacter As String = " "
    <Required(AllowEmptyStrings:=True)> <StringLength(1)> Public Property FillCharacter As String = " "
    <Required(AllowEmptyStrings:=True)> <StringLength(1)> Public Property DrawSymbol As String = " "
    Public Property ShowBackgroundTextColor As Boolean = False
    Public Property ShowBackgroundImage As Boolean = False
    Public Property ShowHiddenTextColor As Color 'made some changes that may have broke it, work on it later
    Public Property ShowHiddenText As Boolean = False
End Class

<Serializable>
Public Class Colors
    Inherits SettingSource
    Implements INotifyPropertyChanged
#Region "Color Settings: Variables and Properties"
    <Required> Public Property RTBForeColors As Color = Color.LimeGreen
    <Required> Public Property RTBBackColors As Color = Color.Black
    <Required> Public Property RTBTextHighlightColors As Color = Color.SkyBlue
    <Required> Public Property GUIForeColors As Color = Color.LimeGreen
    <Required> Public Property GUIBackColors As Color = Color.Black
    <Required> Public Property GUITextColors As Color = Color.LimeGreen
#End Region
End Class