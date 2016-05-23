'Imports Ascii_Art_Composer.RTBSettings

Public Class frmArt
    Dim rtbAggregate As RTBAggregateSource

    Private Sub frmArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbAggregate = New RTBAggregateSource(Me, Me.rtbArtBox)
        rtbAggregate.TextEditor.ResetAndFill()

        'Dim setting As Settings = New Settings
        'setting.Show()
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        FileConnection.Save(rtbArtBox)
    End Sub
End Class
