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
        Dim ArtLoadPathLabel As System.Windows.Forms.Label
        Dim ArtSavePathLabel As System.Windows.Forms.Label
        Dim ImagePathLabel As System.Windows.Forms.Label
        Dim SettingsPathLabel As System.Windows.Forms.Label
        Dim NumberOfCharactersLabel As System.Windows.Forms.Label
        Dim NumberOfLinesLabel As System.Windows.Forms.Label
        Dim ShowBackgroundTextColorLabel As System.Windows.Forms.Label
        Dim DrawSymbolLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArt))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.gbTextDesigner = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ValidationResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tsmiMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiText = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiColors = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tpTextSettings = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NumberOfCharactersTextBox = New System.Windows.Forms.TextBox()
        Me.SettingsAggregateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DrawSymbolTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfLinesTextBox = New System.Windows.Forms.TextBox()
        Me.tpColorSettings = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.SettingsPathTextBox = New System.Windows.Forms.TextBox()
        Me.ArtSavePathTextBox = New System.Windows.Forms.TextBox()
        Me.ArtLoadPathTextBox = New System.Windows.Forms.TextBox()
        Me.ImagePathTextBox = New System.Windows.Forms.TextBox()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.ErrorMessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbErrorList = New System.Windows.Forms.GroupBox()
        Me.gvErrorList = New System.Windows.Forms.DataGridView()
        Me.ErrorMessageDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rtbCanvas = New Ascii_Art_Composer.RichCanvas()
        ArtLoadPathLabel = New System.Windows.Forms.Label()
        ArtSavePathLabel = New System.Windows.Forms.Label()
        ImagePathLabel = New System.Windows.Forms.Label()
        SettingsPathLabel = New System.Windows.Forms.Label()
        NumberOfCharactersLabel = New System.Windows.Forms.Label()
        NumberOfLinesLabel = New System.Windows.Forms.Label()
        ShowBackgroundTextColorLabel = New System.Windows.Forms.Label()
        DrawSymbolLabel = New System.Windows.Forms.Label()
        Me.gbTextDesigner.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidationResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.tpTextSettings.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SettingsAggregateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.gbSettings.SuspendLayout()
        Me.gbErrorList.SuspendLayout()
        CType(Me.gvErrorList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ArtLoadPathLabel
        '
        ArtLoadPathLabel.AutoSize = True
        ArtLoadPathLabel.Location = New System.Drawing.Point(3, 0)
        ArtLoadPathLabel.Name = "ArtLoadPathLabel"
        ArtLoadPathLabel.Size = New System.Drawing.Size(109, 15)
        ArtLoadPathLabel.TabIndex = 0
        ArtLoadPathLabel.Text = "Art Load Path:"
        '
        'ArtSavePathLabel
        '
        ArtSavePathLabel.AutoSize = True
        ArtSavePathLabel.Location = New System.Drawing.Point(3, 27)
        ArtSavePathLabel.Name = "ArtSavePathLabel"
        ArtSavePathLabel.Size = New System.Drawing.Size(108, 15)
        ArtSavePathLabel.TabIndex = 2
        ArtSavePathLabel.Text = "Art Save Path:"
        '
        'ImagePathLabel
        '
        ImagePathLabel.AutoSize = True
        ImagePathLabel.Location = New System.Drawing.Point(3, 54)
        ImagePathLabel.Name = "ImagePathLabel"
        ImagePathLabel.Size = New System.Drawing.Size(86, 15)
        ImagePathLabel.TabIndex = 4
        ImagePathLabel.Text = "Image Path:"
        '
        'SettingsPathLabel
        '
        SettingsPathLabel.AutoSize = True
        SettingsPathLabel.Location = New System.Drawing.Point(3, 81)
        SettingsPathLabel.Name = "SettingsPathLabel"
        SettingsPathLabel.Size = New System.Drawing.Size(101, 15)
        SettingsPathLabel.TabIndex = 6
        SettingsPathLabel.Text = "Settings Path:"
        '
        'NumberOfCharactersLabel
        '
        NumberOfCharactersLabel.AutoSize = True
        NumberOfCharactersLabel.Location = New System.Drawing.Point(3, 54)
        NumberOfCharactersLabel.Name = "NumberOfCharactersLabel"
        NumberOfCharactersLabel.Size = New System.Drawing.Size(92, 15)
        NumberOfCharactersLabel.TabIndex = 6
        NumberOfCharactersLabel.Text = "Char Lemmit"
        '
        'NumberOfLinesLabel
        '
        NumberOfLinesLabel.AutoSize = True
        NumberOfLinesLabel.Location = New System.Drawing.Point(3, 27)
        NumberOfLinesLabel.Name = "NumberOfLinesLabel"
        NumberOfLinesLabel.Size = New System.Drawing.Size(123, 15)
        NumberOfLinesLabel.TabIndex = 2
        NumberOfLinesLabel.Text = "Number Of Lines:"
        '
        'ShowBackgroundTextColorLabel
        '
        ShowBackgroundTextColorLabel.AutoSize = True
        ShowBackgroundTextColorLabel.Location = New System.Drawing.Point(3, 81)
        ShowBackgroundTextColorLabel.Name = "ShowBackgroundTextColorLabel"
        ShowBackgroundTextColorLabel.Size = New System.Drawing.Size(135, 30)
        ShowBackgroundTextColorLabel.TabIndex = 4
        ShowBackgroundTextColorLabel.Text = "Show Background Text Color:"
        '
        'DrawSymbolLabel
        '
        DrawSymbolLabel.AutoSize = True
        DrawSymbolLabel.Location = New System.Drawing.Point(3, 0)
        DrawSymbolLabel.Name = "DrawSymbolLabel"
        DrawSymbolLabel.Size = New System.Drawing.Size(102, 15)
        DrawSymbolLabel.TabIndex = 0
        DrawSymbolLabel.Text = "Draw Symbol:"
        '
        'btnReset
        '
        Me.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("SketchFlow Print", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Lime
        Me.btnReset.Location = New System.Drawing.Point(6, 21)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(105, 26)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset Text"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'gbTextDesigner
        '
        Me.gbTextDesigner.BackColor = System.Drawing.Color.Transparent
        Me.gbTextDesigner.Controls.Add(Me.btnReset)
        Me.gbTextDesigner.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbTextDesigner.Font = New System.Drawing.Font("SketchFlow Print", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTextDesigner.ForeColor = System.Drawing.Color.Lime
        Me.gbTextDesigner.Location = New System.Drawing.Point(0, 24)
        Me.gbTextDesigner.Name = "gbTextDesigner"
        Me.gbTextDesigner.Size = New System.Drawing.Size(117, 615)
        Me.gbTextDesigner.TabIndex = 4
        Me.gbTextDesigner.TabStop = False
        Me.gbTextDesigner.Text = "Designer"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        Me.ErrorProvider1.RightToLeft = True
        '
        'ValidationResultBindingSource
        '
        Me.ValidationResultBindingSource.DataSource = GetType(System.ComponentModel.DataAnnotations.ValidationResult)
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
        Me.tsmiSettings.Size = New System.Drawing.Size(117, 20)
        Me.tsmiSettings.Text = "Advanced Settings"
        '
        'tsmiText
        '
        Me.tsmiText.BackColor = System.Drawing.Color.White
        Me.tsmiText.ForeColor = System.Drawing.Color.Black
        Me.tsmiText.Name = "tsmiText"
        Me.tsmiText.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.tsmiText.Size = New System.Drawing.Size(150, 22)
        Me.tsmiText.Text = "Text"
        '
        'tsmiColors
        '
        Me.tsmiColors.BackColor = System.Drawing.Color.White
        Me.tsmiColors.ForeColor = System.Drawing.Color.Black
        Me.tsmiColors.Name = "tsmiColors"
        Me.tsmiColors.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsmiColors.Size = New System.Drawing.Size(150, 22)
        Me.tsmiColors.Text = "Colors"
        '
        'tsmiFiles
        '
        Me.tsmiFiles.Name = "tsmiFiles"
        Me.tsmiFiles.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.tsmiFiles.Size = New System.Drawing.Size(150, 22)
        Me.tsmiFiles.Text = "Files"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMenu, Me.tsmiSettings, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(932, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tpTextSettings)
        Me.tabControl.Controls.Add(Me.tpColorSettings)
        Me.tabControl.Controls.Add(Me.TabPage1)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(3, 17)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(265, 595)
        Me.tabControl.TabIndex = 0
        '
        'tpTextSettings
        '
        Me.tpTextSettings.AutoScroll = True
        Me.tpTextSettings.BackColor = System.Drawing.Color.Black
        Me.tpTextSettings.Controls.Add(Me.TableLayoutPanel1)
        Me.tpTextSettings.Location = New System.Drawing.Point(4, 24)
        Me.tpTextSettings.Name = "tpTextSettings"
        Me.tpTextSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTextSettings.Size = New System.Drawing.Size(257, 567)
        Me.tpTextSettings.TabIndex = 0
        Me.tpTextSettings.Text = "Text"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(DrawSymbolLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(ShowBackgroundTextColorLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NumberOfCharactersTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DrawSymbolTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(NumberOfLinesLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(NumberOfCharactersLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NumberOfLinesTextBox, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(251, 561)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'NumberOfCharactersTextBox
        '
        Me.NumberOfCharactersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsAggregateBindingSource, "Canvas.NumberOfCharacters", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NumberOfCharactersTextBox.Location = New System.Drawing.Point(165, 57)
        Me.NumberOfCharactersTextBox.Name = "NumberOfCharactersTextBox"
        Me.NumberOfCharactersTextBox.Size = New System.Drawing.Size(83, 21)
        Me.NumberOfCharactersTextBox.TabIndex = 7
        '
        'SettingsAggregateBindingSource
        '
        Me.SettingsAggregateBindingSource.DataSource = GetType(Ascii_Art_Composer.SettingsAggregate)
        '
        'DrawSymbolTextBox
        '
        Me.DrawSymbolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsAggregateBindingSource, "Canvas.DrawSymbol", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DrawSymbolTextBox.Location = New System.Drawing.Point(165, 3)
        Me.DrawSymbolTextBox.Name = "DrawSymbolTextBox"
        Me.DrawSymbolTextBox.Size = New System.Drawing.Size(63, 21)
        Me.DrawSymbolTextBox.TabIndex = 1
        '
        'NumberOfLinesTextBox
        '
        Me.NumberOfLinesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsAggregateBindingSource, "Canvas.NumberOfLines", True))
        Me.NumberOfLinesTextBox.Location = New System.Drawing.Point(165, 30)
        Me.NumberOfLinesTextBox.Name = "NumberOfLinesTextBox"
        Me.NumberOfLinesTextBox.Size = New System.Drawing.Size(83, 21)
        Me.NumberOfLinesTextBox.TabIndex = 3
        '
        'tpColorSettings
        '
        Me.tpColorSettings.BackColor = System.Drawing.Color.Black
        Me.tpColorSettings.Location = New System.Drawing.Point(4, 24)
        Me.tpColorSettings.Name = "tpColorSettings"
        Me.tpColorSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpColorSettings.Size = New System.Drawing.Size(257, 567)
        Me.tpColorSettings.TabIndex = 1
        Me.tpColorSettings.Text = "Colors"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(257, 567)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Files"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(SettingsPathLabel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.SettingsPathTextBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(ImagePathLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(ArtSavePathLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ArtSavePathTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(ArtLoadPathLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ArtLoadPathTextBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ImagePathTextBox, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(251, 561)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'SettingsPathTextBox
        '
        Me.SettingsPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsPathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsAggregateBindingSource, "Files.SettingsPath", True))
        Me.SettingsPathTextBox.Location = New System.Drawing.Point(128, 84)
        Me.SettingsPathTextBox.Name = "SettingsPathTextBox"
        Me.SettingsPathTextBox.Size = New System.Drawing.Size(120, 21)
        Me.SettingsPathTextBox.TabIndex = 7
        '
        'ArtSavePathTextBox
        '
        Me.ArtSavePathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArtSavePathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsAggregateBindingSource, "Files.ArtSavePath", True))
        Me.ArtSavePathTextBox.Location = New System.Drawing.Point(128, 30)
        Me.ArtSavePathTextBox.Name = "ArtSavePathTextBox"
        Me.ArtSavePathTextBox.Size = New System.Drawing.Size(120, 21)
        Me.ArtSavePathTextBox.TabIndex = 3
        '
        'ArtLoadPathTextBox
        '
        Me.ArtLoadPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArtLoadPathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsAggregateBindingSource, "Files.ArtLoadPath", True))
        Me.ArtLoadPathTextBox.Location = New System.Drawing.Point(128, 3)
        Me.ArtLoadPathTextBox.Name = "ArtLoadPathTextBox"
        Me.ArtLoadPathTextBox.Size = New System.Drawing.Size(120, 21)
        Me.ArtLoadPathTextBox.TabIndex = 1
        '
        'ImagePathTextBox
        '
        Me.ImagePathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImagePathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsAggregateBindingSource, "Files.ImagePath", True))
        Me.ImagePathTextBox.Location = New System.Drawing.Point(128, 57)
        Me.ImagePathTextBox.Name = "ImagePathTextBox"
        Me.ImagePathTextBox.Size = New System.Drawing.Size(120, 21)
        Me.ImagePathTextBox.TabIndex = 5
        '
        'gbSettings
        '
        Me.gbSettings.BackColor = System.Drawing.Color.Transparent
        Me.gbSettings.Controls.Add(Me.tabControl)
        Me.gbSettings.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbSettings.Font = New System.Drawing.Font("SketchFlow Print", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSettings.ForeColor = System.Drawing.Color.Lime
        Me.gbSettings.Location = New System.Drawing.Point(661, 24)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Size = New System.Drawing.Size(271, 615)
        Me.gbSettings.TabIndex = 5
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Settings"
        '
        'ErrorMessageDataGridViewTextBoxColumn
        '
        Me.ErrorMessageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ErrorMessageDataGridViewTextBoxColumn.DataPropertyName = "ErrorMessage"
        Me.ErrorMessageDataGridViewTextBoxColumn.HeaderText = "ErrorMessage"
        Me.ErrorMessageDataGridViewTextBoxColumn.Name = "ErrorMessageDataGridViewTextBoxColumn"
        '
        'gbErrorList
        '
        Me.gbErrorList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbErrorList.BackColor = System.Drawing.Color.Black
        Me.gbErrorList.Controls.Add(Me.gvErrorList)
        Me.gbErrorList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.gbErrorList.ForeColor = System.Drawing.Color.LimeGreen
        Me.gbErrorList.Location = New System.Drawing.Point(123, 484)
        Me.gbErrorList.Name = "gbErrorList"
        Me.gbErrorList.Size = New System.Drawing.Size(532, 145)
        Me.gbErrorList.TabIndex = 1
        Me.gbErrorList.TabStop = False
        Me.gbErrorList.Text = "Error List"
        Me.gbErrorList.Visible = False
        '
        'gvErrorList
        '
        Me.gvErrorList.AutoGenerateColumns = False
        Me.gvErrorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvErrorList.BackgroundColor = System.Drawing.Color.Black
        Me.gvErrorList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gvErrorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvErrorList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ErrorMessageDataGridViewTextBoxColumn1})
        Me.gvErrorList.DataSource = Me.ValidationResultBindingSource
        Me.gvErrorList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvErrorList.GridColor = System.Drawing.Color.Red
        Me.gvErrorList.Location = New System.Drawing.Point(3, 18)
        Me.gvErrorList.Name = "gvErrorList"
        Me.gvErrorList.Size = New System.Drawing.Size(526, 124)
        Me.gvErrorList.TabIndex = 0
        '
        'ErrorMessageDataGridViewTextBoxColumn1
        '
        Me.ErrorMessageDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ErrorMessageDataGridViewTextBoxColumn1.DataPropertyName = "ErrorMessage"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ErrorMessageDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.ErrorMessageDataGridViewTextBoxColumn1.HeaderText = "ErrorMessage"
        Me.ErrorMessageDataGridViewTextBoxColumn1.Name = "ErrorMessageDataGridViewTextBoxColumn1"
        Me.ErrorMessageDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'rtbCanvas
        '
        Me.rtbCanvas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbCanvas.BackColor = System.Drawing.Color.Black
        Me.rtbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbCanvas.CurrentKeyDown = Global.Microsoft.VisualBasic.ChrW(0)
        Me.rtbCanvas.Cursor = System.Windows.Forms.Cursors.Cross
        Me.rtbCanvas.DetectUrls = False
        Me.rtbCanvas.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCanvas.ForeColor = System.Drawing.Color.LimeGreen
        Me.rtbCanvas.LeftClickPoint = New System.Drawing.Point(0, 0)
        Me.rtbCanvas.LeftFirstClickPoint = New System.Drawing.Point(0, 0)
        Me.rtbCanvas.LeftReleasePoint = New System.Drawing.Point(0, 0)
        Me.rtbCanvas.Location = New System.Drawing.Point(123, 27)
        Me.rtbCanvas.MiddleClickPoint = New System.Drawing.Point(0, 0)
        Me.rtbCanvas.MiddleFirstClickPoint = New System.Drawing.Point(0, 0)
        Me.rtbCanvas.MiddleReleasePoint = New System.Drawing.Point(0, 0)
        Me.rtbCanvas.Name = "rtbCanvas"
        Me.rtbCanvas.ReadOnly = True
        Me.rtbCanvas.RightClickPoint = New System.Drawing.Point(0, 0)
        Me.rtbCanvas.RightFirstClickPoint = New System.Drawing.Point(0, 0)
        Me.rtbCanvas.RightReleasePoint = New System.Drawing.Point(0, 0)
        Me.rtbCanvas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbCanvas.Size = New System.Drawing.Size(532, 451)
        Me.rtbCanvas.TabIndex = 3
        Me.rtbCanvas.Text = ""
        Me.rtbCanvas.WordWrap = False
        '
        'frmArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(932, 639)
        Me.Controls.Add(Me.gbErrorList)
        Me.Controls.Add(Me.gbSettings)
        Me.Controls.Add(Me.gbTextDesigner)
        Me.Controls.Add(Me.rtbCanvas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("39251", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "frmArt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ascii Composer"
        Me.gbTextDesigner.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidationResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabControl.ResumeLayout(False)
        Me.tpTextSettings.ResumeLayout(False)
        Me.tpTextSettings.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.SettingsAggregateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.gbSettings.ResumeLayout(False)
        Me.gbErrorList.ResumeLayout(False)
        CType(Me.gvErrorList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbArtBox As RichCanvas
    Friend WithEvents rtbCanvas As RichCanvas
    Friend WithEvents btnReset As Button
    Friend WithEvents gbTextDesigner As GroupBox
    Friend WithEvents SettingsAggregateBindingSource As BindingSource
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Public WithEvents ValidationResultBindingSource As BindingSource
    Friend WithEvents gbSettings As GroupBox
    Friend WithEvents tabControl As TabControl
    Friend WithEvents tpTextSettings As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NumberOfCharactersTextBox As TextBox
    Friend WithEvents DrawSymbolTextBox As TextBox
    Friend WithEvents NumberOfLinesTextBox As TextBox
    Friend WithEvents tpColorSettings As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents SettingsPathTextBox As TextBox
    Friend WithEvents ArtSavePathTextBox As TextBox
    Friend WithEvents ArtLoadPathTextBox As TextBox
    Friend WithEvents ImagePathTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmiMenu As ToolStripMenuItem
    Friend WithEvents tsmiOpen As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiSettings As ToolStripMenuItem
    Friend WithEvents tsmiText As ToolStripMenuItem
    Friend WithEvents tsmiColors As ToolStripMenuItem
    Friend WithEvents tsmiFiles As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbErrorList As GroupBox
    Friend WithEvents gvErrorList As DataGridView
    Friend WithEvents ErrorMessageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ErrorMessageDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
