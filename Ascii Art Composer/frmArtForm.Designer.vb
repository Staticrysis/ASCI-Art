<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArt))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmiMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiText = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiColors = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettings = New System.Windows.Forms.ToolStrip()
        Me.tsbReset = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslSymbol = New System.Windows.Forms.ToolStripLabel()
        Me.tstbSymbol = New System.Windows.Forms.ToolStripTextBox()
        Me.tslLines = New System.Windows.Forms.ToolStripLabel()
        Me.tstbLines = New System.Windows.Forms.ToolStripTextBox()
        Me.tslChars = New System.Windows.Forms.ToolStripLabel()
        Me.tstbCharacters = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbShowHiddenSpace = New System.Windows.Forms.ToolStripButton()
        Me.tbZoom = New System.Windows.Forms.TrackBar()
        Me.TForShowBorders = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.tsSettings.SuspendLayout()
        CType(Me.tbZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMenu, Me.tsmiSettings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(905, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiMenu
        '
        Me.tsmiMenu.BackColor = System.Drawing.Color.Black
        Me.tsmiMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiOpen, Me.tsmiSave})
        Me.tsmiMenu.ForeColor = System.Drawing.Color.Lime
        Me.tsmiMenu.Name = "tsmiMenu"
        Me.tsmiMenu.Size = New System.Drawing.Size(50, 20)
        Me.tsmiMenu.Text = "Menu"
        '
        'tsmiOpen
        '
        Me.tsmiOpen.Name = "tsmiOpen"
        Me.tsmiOpen.Size = New System.Drawing.Size(103, 22)
        Me.tsmiOpen.Text = "Open"
        '
        'tsmiSave
        '
        Me.tsmiSave.Name = "tsmiSave"
        Me.tsmiSave.Size = New System.Drawing.Size(103, 22)
        Me.tsmiSave.Text = "Save"
        '
        'tsmiSettings
        '
        Me.tsmiSettings.BackColor = System.Drawing.Color.Black
        Me.tsmiSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiText, Me.tsmiColors, Me.tsmiFiles})
        Me.tsmiSettings.ForeColor = System.Drawing.Color.Lime
        Me.tsmiSettings.Name = "tsmiSettings"
        Me.tsmiSettings.Size = New System.Drawing.Size(61, 20)
        Me.tsmiSettings.Text = "Settings"
        '
        'tsmiText
        '
        Me.tsmiText.BackColor = System.Drawing.Color.White
        Me.tsmiText.ForeColor = System.Drawing.Color.Black
        Me.tsmiText.Name = "tsmiText"
        Me.tsmiText.Size = New System.Drawing.Size(108, 22)
        Me.tsmiText.Text = "Text"
        '
        'tsmiColors
        '
        Me.tsmiColors.BackColor = System.Drawing.Color.White
        Me.tsmiColors.ForeColor = System.Drawing.Color.Black
        Me.tsmiColors.Name = "tsmiColors"
        Me.tsmiColors.Size = New System.Drawing.Size(108, 22)
        Me.tsmiColors.Text = "Colors"
        '
        'tsmiFiles
        '
        Me.tsmiFiles.Name = "tsmiFiles"
        Me.tsmiFiles.Size = New System.Drawing.Size(108, 22)
        Me.tsmiFiles.Text = "Files"
        '
        'tsSettings
        '
        Me.tsSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsSettings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbReset, Me.ToolStripSeparator1, Me.tslSymbol, Me.tstbSymbol, Me.tslLines, Me.tstbLines, Me.tslChars, Me.tstbCharacters, Me.ToolStripSeparator2, Me.tsbShowHiddenSpace})
        Me.tsSettings.Location = New System.Drawing.Point(0, 614)
        Me.tsSettings.Name = "tsSettings"
        Me.tsSettings.Size = New System.Drawing.Size(905, 25)
        Me.tsSettings.TabIndex = 2
        Me.tsSettings.Text = "  "
        '
        'tsbReset
        '
        Me.tsbReset.BackColor = System.Drawing.Color.Black
        Me.tsbReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbReset.ForeColor = System.Drawing.Color.Lime
        Me.tsbReset.Image = CType(resources.GetObject("tsbReset.Image"), System.Drawing.Image)
        Me.tsbReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReset.Name = "tsbReset"
        Me.tsbReset.Size = New System.Drawing.Size(39, 22)
        Me.tsbReset.Text = "Reset"
        Me.tsbReset.ToolTipText = "Resets the ascii image to the onload setting" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tslSymbol
        '
        Me.tslSymbol.ForeColor = System.Drawing.Color.Lime
        Me.tslSymbol.LinkVisited = True
        Me.tslSymbol.Name = "tslSymbol"
        Me.tslSymbol.Size = New System.Drawing.Size(90, 22)
        Me.tslSymbol.Text = "Current Symbol"
        '
        'tstbSymbol
        '
        Me.tstbSymbol.MaxLength = 10
        Me.tstbSymbol.Name = "tstbSymbol"
        Me.tstbSymbol.Size = New System.Drawing.Size(94, 25)
        Me.tstbSymbol.Text = "z"
        '
        'tslLines
        '
        Me.tslLines.ForeColor = System.Drawing.Color.Lime
        Me.tslLines.Name = "tslLines"
        Me.tslLines.Size = New System.Drawing.Size(34, 22)
        Me.tslLines.Text = "Lines"
        '
        'tstbLines
        '
        Me.tstbLines.MaxLength = 3
        Me.tstbLines.Name = "tstbLines"
        Me.tstbLines.Size = New System.Drawing.Size(94, 25)
        Me.tstbLines.Text = "60"
        '
        'tslChars
        '
        Me.tslChars.ForeColor = System.Drawing.Color.Lime
        Me.tslChars.Name = "tslChars"
        Me.tslChars.Size = New System.Drawing.Size(63, 22)
        Me.tslChars.Text = "Characters"
        '
        'tstbCharacters
        '
        Me.tstbCharacters.MaxLength = 3
        Me.tstbCharacters.Name = "tstbCharacters"
        Me.tstbCharacters.Size = New System.Drawing.Size(94, 25)
        Me.tstbCharacters.Text = "300"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbShowHiddenSpace
        '
        Me.tsbShowHiddenSpace.BackColor = System.Drawing.Color.Black
        Me.tsbShowHiddenSpace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbShowHiddenSpace.ForeColor = System.Drawing.Color.Lime
        Me.tsbShowHiddenSpace.Image = CType(resources.GetObject("tsbShowHiddenSpace.Image"), System.Drawing.Image)
        Me.tsbShowHiddenSpace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbShowHiddenSpace.Name = "tsbShowHiddenSpace"
        Me.tsbShowHiddenSpace.Size = New System.Drawing.Size(116, 22)
        Me.tsbShowHiddenSpace.Text = "Show Hidden Space"
        '
        'tbZoom
        '
        Me.tbZoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbZoom.LargeChange = 1
        Me.tbZoom.Location = New System.Drawing.Point(795, 614)
        Me.tbZoom.Name = "tbZoom"
        Me.tbZoom.Size = New System.Drawing.Size(110, 45)
        Me.tbZoom.TabIndex = 3
        Me.tbZoom.Visible = False
        '
        'TForShowBorders
        '
        Me.TForShowBorders.Interval = 500
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'frmArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(905, 639)
        Me.Controls.Add(Me.tbZoom)
        Me.Controls.Add(Me.tsSettings)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("39251", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "frmArt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ascii Composer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tsSettings.ResumeLayout(False)
        Me.tsSettings.PerformLayout()
        CType(Me.tbZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmiMenu As ToolStripMenuItem
    Friend WithEvents tsSettings As ToolStrip
    Friend WithEvents tslSymbol As ToolStripLabel
    Friend WithEvents tslLines As ToolStripLabel
    Friend WithEvents tsbReset As ToolStripButton
    Friend WithEvents tsmiOpen As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiSettings As ToolStripMenuItem
    Friend WithEvents tsmiColors As ToolStripMenuItem
    Friend WithEvents tsmiText As ToolStripMenuItem
    Friend WithEvents tstbLines As ToolStripTextBox
    Friend WithEvents tslChars As ToolStripLabel
    Friend WithEvents tstbCharacters As ToolStripTextBox
    Friend WithEvents tbZoom As TrackBar
    Friend WithEvents tsmiFiles As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents rtbArtBox As RichCanvas
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tstbSymbol As ToolStripTextBox
    Friend WithEvents tsbShowHiddenSpace As ToolStripButton
    Friend WithEvents TForShowBorders As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
End Class
