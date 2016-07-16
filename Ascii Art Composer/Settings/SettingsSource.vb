'Note: This Source class is the parent class for all child setting classes
'It also contains all relivent properties for child classes to use

Imports System.ComponentModel

Public Class SettingsSource
    Implements INotifyPropertyChanged
#Region "Class Variables"
    Protected _mainForm As frmArt
    Protected _frmSettings As frmSettings
    Protected _tabControlSettings As TabControl
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private _serializer As System.Web.Script.Serialization.JavaScriptSerializer
#End Region

    'General Settings constructor
    Public Sub New(ByRef mainForm As frmArt)
        _mainForm = mainForm
    End Sub

#Region "Form Component as Properties"
    Protected _tabFileSettings As TabPage
    Protected _tabTextEditingSettings As TabPage
    Protected _tabColorSettings As TabPage

    Public Property FileSettings As TabPage
        Get
            Return _mainForm._SettingsForm.tpFiles
        End Get
        Set(value As TabPage)
            _mainForm._SettingsForm.tpFiles = value
        End Set
    End Property

    Public Property TextEditingSettings As TabPage
        Get
            Return _mainForm._SettingsForm.tpTextEditingSettings
        End Get
        Set(value As TabPage)
            _mainForm._SettingsForm.tpTextEditingSettings = value
        End Set
    End Property

    Public Property ColorSettings As TabPage
        Get
            Return _mainForm._SettingsForm.tpColors
        End Get
        Set(value As TabPage)
            _mainForm._SettingsForm.tpColors = value
        End Set
    End Property
#End Region

#Region "IO Serialization"

#End Region

    Protected Sub OnPropertyChanged(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub
End Class
