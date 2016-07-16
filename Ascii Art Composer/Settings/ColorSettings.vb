Public Class ColorSettings
    Inherits SettingsSource 

    Public Sub New(ByRef mainForm As frmArt)
        MyBase.New(mainForm)
    End Sub

#Region "Color Settings: Variables and Properties"
    Private _rtbForeColors As Color
    Private _rtbBackColors As Color
    Private _rtbTextHighlightColor As Color
    Private _guiForeColors As Color
    Private _guiBackColors As Color
    Private _guiTextColors As Color

    Public Property RTBForeColors As Color
        Get
            Return _rtbForeColors
        End Get
        Set(value As Color)
            _rtbForeColors = value
        End Set
    End Property

    Public Property RTBBackColors As Color
        Get
            Return _rtbBackColors
        End Get
        Set(value As Color)
            _rtbBackColors = value
        End Set
    End Property

    Public Property RTBTextHighlightColors As Color
        Get
            Return _rtbTextHighLightColor
        End Get
        Set(value As Color)
            _rtbTextHighLightColor = value
        End Set
    End Property

    Public Property GUIForeColors As Color
        Get
            Return _guiForeColors
        End Get
        Set(value As Color)
            _guiForeColors = value
        End Set
    End Property

    Public Property GUIBackColors As Color
        Get
            Return _guiBackColors
        End Get
        Set(value As Color)
            _guiBackColors = value
        End Set
    End Property

    Public Property GUITextColors As Color
        Get
            Return _guiTextColors
        End Get
        Set(value As Color)
            _guiTextColors = value
        End Set
    End Property
#End Region
End Class
