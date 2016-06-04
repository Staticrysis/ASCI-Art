Public Class RTBARTBox_MouseMove
    Inherits RichTextBox
    Private WM_SETFOCUS As Integer = &H7

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Let everything through except for the WM_SETFOCUS message
        'TODO: need to stop redraw/update flickers here
        If (m.Msg <> WM_SETFOCUS) Then
            MyBase.WndProc(m)
        End If
    End Sub
End Class
