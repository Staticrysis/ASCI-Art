﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASCIIEditorTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorBackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPanelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.rtbArtBox = New Ascii_Art_Composer.RTBARTBox_MouseMove()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(779, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiMenu
        '
        Me.tsmiMenu.BackColor = System.Drawing.Color.Black
        Me.tsmiMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveToolStripMenuItem1})
        Me.tsmiMenu.ForeColor = System.Drawing.Color.Lime
        Me.tsmiMenu.Name = "tsmiMenu"
        Me.tsmiMenu.Size = New System.Drawing.Size(50, 20)
        Me.tsmiMenu.Text = "Menu"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem1.Text = "Save"
        '
        'tsmiSettings
        '
        Me.tsmiSettings.BackColor = System.Drawing.Color.Black
        Me.tsmiSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EditorToolStripMenuItem, Me.FilesToolStripMenuItem})
        Me.tsmiSettings.ForeColor = System.Drawing.Color.Lime
        Me.tsmiSettings.Name = "tsmiSettings"
        Me.tsmiSettings.Size = New System.Drawing.Size(61, 20)
        Me.tsmiSettings.Text = "Settings"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuTextToolStripMenuItem, Me.ASCIIEditorTextToolStripMenuItem, Me.EditorBackgroundToolStripMenuItem, Me.MenuPanelsToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "Colors"
        '
        'MenuTextToolStripMenuItem
        '
        Me.MenuTextToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.MenuTextToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MenuTextToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.MenuTextToolStripMenuItem.Name = "MenuTextToolStripMenuItem"
        Me.MenuTextToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.MenuTextToolStripMenuItem.Text = "Menu Text"
        '
        'ASCIIEditorTextToolStripMenuItem
        '
        Me.ASCIIEditorTextToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ASCIIEditorTextToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ASCIIEditorTextToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.ASCIIEditorTextToolStripMenuItem.Name = "ASCIIEditorTextToolStripMenuItem"
        Me.ASCIIEditorTextToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ASCIIEditorTextToolStripMenuItem.Text = "Editor Text"
        '
        'EditorBackgroundToolStripMenuItem
        '
        Me.EditorBackgroundToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.EditorBackgroundToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EditorBackgroundToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.EditorBackgroundToolStripMenuItem.Name = "EditorBackgroundToolStripMenuItem"
        Me.EditorBackgroundToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EditorBackgroundToolStripMenuItem.Text = "Editor Background"
        '
        'MenuPanelsToolStripMenuItem
        '
        Me.MenuPanelsToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.MenuPanelsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MenuPanelsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.MenuPanelsToolStripMenuItem.Name = "MenuPanelsToolStripMenuItem"
        Me.MenuPanelsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.MenuPanelsToolStripMenuItem.Text = "Menu Panels"
        '
        'EditorToolStripMenuItem
        '
        Me.EditorToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.EditorToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EditorToolStripMenuItem.Name = "EditorToolStripMenuItem"
        Me.EditorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditorToolStripMenuItem.Text = "ASCII Editor"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'tsSettings
        '
        Me.tsSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsSettings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbReset, Me.ToolStripSeparator1, Me.tslSymbol, Me.tstbSymbol, Me.tslLines, Me.tstbLines, Me.tslChars, Me.tstbCharacters, Me.ToolStripSeparator2, Me.tsbShowHiddenSpace})
        Me.tsSettings.Location = New System.Drawing.Point(0, 614)
        Me.tsSettings.Name = "tsSettings"
        Me.tsSettings.Size = New System.Drawing.Size(779, 25)
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
        Me.tbZoom.Location = New System.Drawing.Point(669, 614)
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
        'rtbArtBox
        '
        Me.rtbArtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbArtBox.BackColor = System.Drawing.Color.Black
        Me.rtbArtBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.rtbArtBox.EnableAutoDragDrop = True
        Me.rtbArtBox.Font = New System.Drawing.Font("Tahoma", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbArtBox.ForeColor = System.Drawing.Color.Yellow
        Me.rtbArtBox.Location = New System.Drawing.Point(0, 24)
        Me.rtbArtBox.Name = "rtbArtBox"
        Me.rtbArtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbArtBox.Size = New System.Drawing.Size(779, 584)
        Me.rtbArtBox.TabIndex = 4
        Me.rtbArtBox.Text = ""
        Me.rtbArtBox.WordWrap = False
        '
        'frmArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(779, 639)
        Me.Controls.Add(Me.rtbArtBox)
        Me.Controls.Add(Me.tbZoom)
        Me.Controls.Add(Me.tsSettings)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("39251", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "frmArt"
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
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tsmiSettings As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASCIIEditorTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorBackgroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuPanelsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tstbLines As ToolStripTextBox
    Friend WithEvents tslChars As ToolStripLabel
    Friend WithEvents tstbCharacters As ToolStripTextBox
    Friend WithEvents tbZoom As TrackBar
    Friend WithEvents FilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents rtbArtBox As RTBARTBox_MouseMove
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tstbSymbol As ToolStripTextBox
    Friend WithEvents tsbShowHiddenSpace As ToolStripButton
    Friend WithEvents TForShowBorders As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class