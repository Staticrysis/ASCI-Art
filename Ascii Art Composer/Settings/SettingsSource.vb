'Note: I made this source class to t

Imports System.ComponentModel

<Serializable>
Public Class SettingsSource
    Implements INotifyPropertyChanged
#Region "Class Variables"
    'Protected _mainForm As frmArt
    'Protected _rtbArtbox As RTBArtBox
    'Protected _frmSettings As frmSettings
    'Protected _tabControlSettings As TabControl
#End Region

    Public Sub New()
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub

#Region "Form Component as Properties"
    'Protected _tabFileSettings As TabPage
    'Protected _tabTextEditingSettings As TabPage
    'Protected _tabColorSettings As TabPage
#End Region
End Class
