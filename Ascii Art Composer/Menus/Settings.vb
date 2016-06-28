Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbBackgroundColors.DataSource = New System.Drawing.Color
        'dgvColors.DataSource = New Color
    End Sub
End Class