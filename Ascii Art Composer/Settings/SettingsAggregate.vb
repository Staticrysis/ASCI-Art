'Note: This aggregate is a wrapper for all the frmSettings data classes 

Public Class SettingsAggregate
#Region "Class Variables"
    Dim _fileSettings As FileSettings
    Dim _textEditingSettings As TextEditingSettings
    Dim _colorSettings As ColorSettings
#End Region

#Region "Class Properties"
    Public Property FileSettings As FileSettings
        Get
            Return _fileSettings
        End Get
        Set(value As FileSettings)
            _fileSettings = value
        End Set
    End Property

    Public Property TextEditingSettings As TextEditingSettings
        Get
            Return _textEditingSettings
        End Get
        Set(value As TextEditingSettings)
            _textEditingSettings = value
        End Set
    End Property

    Public Property ColorSettings As ColorSettings
        Get
            Return _colorSettings
        End Get
        Set(value As ColorSettings)
            _colorSettings = value
        End Set
    End Property
#End Region

    Public Sub New()
        _fileSettings = New FileSettings()
        _textEditingSettings = New TextEditingSettings()
        _colorSettings = New ColorSettings()
    End Sub
End Class
