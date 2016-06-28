'Imports Ascii_Art_Composer.RTBSettings

Public Class frmArt
    Dim rtbAggregate As RTBAggregate

    Private Sub frmArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbAggregate = New RTBAggregate(Me, Me.rtbArtBox)
        tstbSymbol.Text = " "
        'rtbAggregate.TextEditor.ResetAndFill()
        tstbSymbol.Text = "@"

        'Dim setting As Settings = New Settings
        'setting.Show()
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        FileSettings.Save(rtbArtBox)
    End Sub

    Private Sub Settings() Handles tsmiSettings.Click
        Dim setBox As New frmSettings(Me)
        setBox.ShowDialog()
    End Sub

End Class
