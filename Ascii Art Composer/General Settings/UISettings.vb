Public Class UISettings
    Inherits SettingsSource

    Public Sub New(ByRef MainForm As frmArt)
        MyBase.New(MainForm)
    End Sub

#Region "Settings Variables"
    Dim _GlobalUIColors As Color
#End Region

#Region "Setting Properties"
    Public Property GlobalUIColors As Color
        Get
            Return _GlobalUIColors
        End Get
        Set(value As Color)
            _GlobalUIColors = value
        End Set
    End Property
#End Region
End Class
