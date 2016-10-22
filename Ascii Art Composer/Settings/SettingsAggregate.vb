Imports System.ComponentModel

<Serializable>
Public Class SettingsAggregate
#Region "Class Properties"
    Public Property FileSettings As New FileSettings
    Public Property TextEditingSettings As New TextEditingSettings
    Public Property ColorSettings As New ColorSettings
#End Region
End Class

Public Class SettingSource
    Implements INotifyPropertyChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub
End Class

<Serializable>
Public Class FileSettings
    Inherits SettingSource
    Public Sub New()
    End Sub

#Region "File Settings: Variables and Properties"
    ' Public Property ArtSavePath As String : Get : Return "" : End Get : Set : OnPropertyChanged("ArtSavePath") : End Set


    Public Property ArtLoadPath As String
    Public Property SettingsPath As String
    Public Property ImagePath As String
#End Region
End Class

<Serializable>
Public Class TextEditingSettings
    Public Sub New()
    End Sub

    Enum WebsitePresets
        None
        Facebook
        Youtube
    End Enum

    Public Property WebPresets As String() = [Enum].GetNames(GetType(WebsitePresets)).ToArray
    Public Property WebPreset As String
    Public Property NumberOfLines As Integer
    Public Property NumberOfCharacters As Integer
    Public Property CursorCharacter As String = " "
    Public Property FillCharacter As String = " "
    Public Property ShowBackgroundTextColor As Boolean
    Public Property ShowBackgroundImage As Boolean

    Public Property ShowHiddenTextColor As Color 'made some changes that may have broke it, work on it later
    Public Property ShowHiddenText As Boolean

#Region "Settings Methods"
#End Region
End Class

<Serializable>
Public Class ColorSettings
    Public Sub New()
    End Sub

#Region "Color Settings: Variables and Properties"
    Public Property RTBForeColors As Color
    Public Property RTBBackColors As New Color
    Public Property RTBTextHighlightColors As New Color
    Public Property GUIForeColors As Color
    Public Property GUIBackColors As New Color
    Public Property GUITextColors As New Color
#End Region
End Class