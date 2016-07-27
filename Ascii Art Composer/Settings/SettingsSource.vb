'Note: I made this source class to t

Imports System.ComponentModel

Public Class SettingsSource
    Implements INotifyPropertyChanged
#Region "Class Variables"
    Protected _mainForm As frmArt
    Protected _rtbArtbox As RTBArtBox
    Protected _frmSettings As frmSettings
    Protected _tabControlSettings As TabControl
    Public Event PropertyChanged As PropertyChangedEventHandler
    Private Event INotifyPropertyChanged_PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private _serializer As System.Web.Script.Serialization.JavaScriptSerializer
#End Region

    Public Sub New()
    End Sub

#Region "Form Component as Properties"
    Protected _tabFileSettings As TabPage
    Protected _tabTextEditingSettings As TabPage
    Protected _tabColorSettings As TabPage
#End Region

    Protected Sub OnPropertyChanged(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub
End Class
