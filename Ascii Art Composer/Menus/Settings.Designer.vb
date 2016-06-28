<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.tcSettings = New System.Windows.Forms.TabControl()
        Me.tpColors = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.gbTextBoxColors = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbBackgroundColors = New System.Windows.Forms.ComboBox()
        Me.ColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTextBoxColors = New System.Windows.Forms.ComboBox()
        Me.tpTextEditingSettings = New System.Windows.Forms.TabPage()
        Me.gbWebPresets = New System.Windows.Forms.GroupBox()
        Me.cbWebPresets = New System.Windows.Forms.ComboBox()
        Me.gbBackImage = New System.Windows.Forms.GroupBox()
        Me.buttonImageUp = New System.Windows.Forms.Button()
        Me.lbLoadingImages = New System.Windows.Forms.Label()
        Me.pbLoadingImages = New System.Windows.Forms.ProgressBar()
        Me.pbCurrentBackImage = New System.Windows.Forms.PictureBox()
        Me.gbTextDimensions = New System.Windows.Forms.GroupBox()
        Me.gbShowBackground = New System.Windows.Forms.GroupBox()
        Me.cbBackgroundImage = New System.Windows.Forms.CheckBox()
        Me.cbBackgroundTextColor = New System.Windows.Forms.CheckBox()
        Me.gbFillCharacter = New System.Windows.Forms.GroupBox()
        Me.cbFillCharacter = New System.Windows.Forms.ComboBox()
        Me.gbCharacters = New System.Windows.Forms.GroupBox()
        Me.nudCharacters = New System.Windows.Forms.NumericUpDown()
        Me.gbLines = New System.Windows.Forms.GroupBox()
        Me.nudLines = New System.Windows.Forms.NumericUpDown()
        Me.tbFiles = New System.Windows.Forms.TabPage()
        Me.gbSettingsFileLocation = New System.Windows.Forms.GroupBox()
        Me.gbSettingsFile = New System.Windows.Forms.GroupBox()
        Me.tbSettingsFileLocation = New System.Windows.Forms.TextBox()
        Me.buttonSetSettingsFileLocation = New System.Windows.Forms.Button()
        Me.gbImageFile = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbImageFileLocation = New System.Windows.Forms.TextBox()
        Me.buttonSetImageFileLocation = New System.Windows.Forms.Button()
        Me.gbFileLocations = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbArtFile = New System.Windows.Forms.GroupBox()
        Me.buttonSetSaveArtFileLocation = New System.Windows.Forms.Button()
        Me.tbSaveArtFileLocation = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.buttonImageDown = New System.Windows.Forms.Button()
        Me.tcSettings.SuspendLayout()
        Me.tpColors.SuspendLayout()
        Me.gbTextBoxColors.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpTextEditingSettings.SuspendLayout()
        Me.gbWebPresets.SuspendLayout()
        Me.gbBackImage.SuspendLayout()
        CType(Me.pbCurrentBackImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTextDimensions.SuspendLayout()
        Me.gbShowBackground.SuspendLayout()
        Me.gbFillCharacter.SuspendLayout()
        Me.gbCharacters.SuspendLayout()
        CType(Me.nudCharacters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLines.SuspendLayout()
        CType(Me.nudLines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbFiles.SuspendLayout()
        Me.gbSettingsFileLocation.SuspendLayout()
        Me.gbSettingsFile.SuspendLayout()
        Me.gbImageFile.SuspendLayout()
        Me.gbFileLocations.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbArtFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcSettings
        '
        Me.tcSettings.Controls.Add(Me.tpColors)
        Me.tcSettings.Controls.Add(Me.tpTextEditingSettings)
        Me.tcSettings.Controls.Add(Me.tbFiles)
        Me.tcSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcSettings.Location = New System.Drawing.Point(0, 0)
        Me.tcSettings.Name = "tcSettings"
        Me.tcSettings.SelectedIndex = 0
        Me.tcSettings.Size = New System.Drawing.Size(549, 299)
        Me.tcSettings.TabIndex = 0
        '
        'tpColors
        '
        Me.tpColors.BackColor = System.Drawing.Color.Silver
        Me.tpColors.Controls.Add(Me.GroupBox2)
        Me.tpColors.Controls.Add(Me.GroupBox3)
        Me.tpColors.Controls.Add(Me.gbTextBoxColors)
        Me.tpColors.Location = New System.Drawing.Point(4, 22)
        Me.tpColors.Name = "tpColors"
        Me.tpColors.Padding = New System.Windows.Forms.Padding(3)
        Me.tpColors.Size = New System.Drawing.Size(541, 273)
        Me.tpColors.TabIndex = 0
        Me.tpColors.Text = "Colors"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(8, 116)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'gbTextBoxColors
        '
        Me.gbTextBoxColors.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbTextBoxColors.Controls.Add(Me.TableLayoutPanel2)
        Me.gbTextBoxColors.Location = New System.Drawing.Point(8, 6)
        Me.gbTextBoxColors.Name = "gbTextBoxColors"
        Me.gbTextBoxColors.Size = New System.Drawing.Size(242, 104)
        Me.gbTextBoxColors.TabIndex = 0
        Me.gbTextBoxColors.TabStop = False
        Me.gbTextBoxColors.Text = "Textbox Colors"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.18919!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.81081!))
        Me.TableLayoutPanel2.Controls.Add(Me.cbBackgroundColors, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cbTextBoxColors, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(222, 75)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'cbBackgroundColors
        '
        Me.cbBackgroundColors.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBackgroundColors.DataSource = Me.ColorBindingSource
        Me.cbBackgroundColors.FormattingEnabled = True
        Me.cbBackgroundColors.Location = New System.Drawing.Point(90, 45)
        Me.cbBackgroundColors.Name = "cbBackgroundColors"
        Me.cbBackgroundColors.Size = New System.Drawing.Size(129, 21)
        Me.cbBackgroundColors.TabIndex = 3
        '
        'ColorBindingSource
        '
        Me.ColorBindingSource.DataSource = GetType(System.Drawing.Color)
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Textbox Color"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Background Color"
        '
        'cbTextBoxColors
        '
        Me.cbTextBoxColors.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTextBoxColors.DataSource = Me.ColorBindingSource
        Me.cbTextBoxColors.FormattingEnabled = True
        Me.cbTextBoxColors.Location = New System.Drawing.Point(90, 8)
        Me.cbTextBoxColors.Name = "cbTextBoxColors"
        Me.cbTextBoxColors.Size = New System.Drawing.Size(129, 21)
        Me.cbTextBoxColors.TabIndex = 2
        '
        'tpTextEditingSettings
        '
        Me.tpTextEditingSettings.BackColor = System.Drawing.Color.DarkRed
        Me.tpTextEditingSettings.Controls.Add(Me.gbWebPresets)
        Me.tpTextEditingSettings.Controls.Add(Me.gbBackImage)
        Me.tpTextEditingSettings.Controls.Add(Me.gbTextDimensions)
        Me.tpTextEditingSettings.Location = New System.Drawing.Point(4, 22)
        Me.tpTextEditingSettings.Name = "tpTextEditingSettings"
        Me.tpTextEditingSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTextEditingSettings.Size = New System.Drawing.Size(541, 273)
        Me.tpTextEditingSettings.TabIndex = 1
        Me.tpTextEditingSettings.Text = "Text Editing"
        '
        'gbWebPresets
        '
        Me.gbWebPresets.BackColor = System.Drawing.Color.DarkGray
        Me.gbWebPresets.Controls.Add(Me.cbWebPresets)
        Me.gbWebPresets.Location = New System.Drawing.Point(184, 7)
        Me.gbWebPresets.Name = "gbWebPresets"
        Me.gbWebPresets.Size = New System.Drawing.Size(165, 44)
        Me.gbWebPresets.TabIndex = 2
        Me.gbWebPresets.TabStop = False
        Me.gbWebPresets.Text = "Web Presets"
        '
        'cbWebPresets
        '
        Me.cbWebPresets.FormattingEnabled = True
        Me.cbWebPresets.Location = New System.Drawing.Point(6, 14)
        Me.cbWebPresets.Name = "cbWebPresets"
        Me.cbWebPresets.Size = New System.Drawing.Size(150, 21)
        Me.cbWebPresets.TabIndex = 0
        '
        'gbBackImage
        '
        Me.gbBackImage.BackColor = System.Drawing.Color.DarkGray
        Me.gbBackImage.Controls.Add(Me.buttonImageUp)
        Me.gbBackImage.Controls.Add(Me.buttonImageDown)
        Me.gbBackImage.Controls.Add(Me.lbLoadingImages)
        Me.gbBackImage.Controls.Add(Me.pbLoadingImages)
        Me.gbBackImage.Controls.Add(Me.pbCurrentBackImage)
        Me.gbBackImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBackImage.Location = New System.Drawing.Point(183, 57)
        Me.gbBackImage.Name = "gbBackImage"
        Me.gbBackImage.Size = New System.Drawing.Size(355, 213)
        Me.gbBackImage.TabIndex = 1
        Me.gbBackImage.TabStop = False
        Me.gbBackImage.Text = "Back Image: "
        '
        'buttonImageUp
        '
        Me.buttonImageUp.Image = Global.Ascii_Art_Composer.My.Resources.Resources.upbutton
        Me.buttonImageUp.Location = New System.Drawing.Point(277, 33)
        Me.buttonImageUp.Name = "buttonImageUp"
        Me.buttonImageUp.Size = New System.Drawing.Size(72, 86)
        Me.buttonImageUp.TabIndex = 4
        Me.buttonImageUp.UseVisualStyleBackColor = True
        '
        'lbLoadingImages
        '
        Me.lbLoadingImages.AutoSize = True
        Me.lbLoadingImages.BackColor = System.Drawing.Color.White
        Me.lbLoadingImages.Location = New System.Drawing.Point(91, 133)
        Me.lbLoadingImages.Name = "lbLoadingImages"
        Me.lbLoadingImages.Size = New System.Drawing.Size(91, 13)
        Me.lbLoadingImages.TabIndex = 2
        Me.lbLoadingImages.Text = "Loading Images..."
        '
        'pbLoadingImages
        '
        Me.pbLoadingImages.ForeColor = System.Drawing.Color.Lime
        Me.pbLoadingImages.Location = New System.Drawing.Point(58, 96)
        Me.pbLoadingImages.Name = "pbLoadingImages"
        Me.pbLoadingImages.Size = New System.Drawing.Size(156, 23)
        Me.pbLoadingImages.TabIndex = 1
        '
        'pbCurrentBackImage
        '
        Me.pbCurrentBackImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbCurrentBackImage.BackColor = System.Drawing.Color.White
        Me.pbCurrentBackImage.Location = New System.Drawing.Point(6, 33)
        Me.pbCurrentBackImage.Name = "pbCurrentBackImage"
        Me.pbCurrentBackImage.Size = New System.Drawing.Size(265, 174)
        Me.pbCurrentBackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCurrentBackImage.TabIndex = 0
        Me.pbCurrentBackImage.TabStop = False
        '
        'gbTextDimensions
        '
        Me.gbTextDimensions.BackColor = System.Drawing.Color.DarkGray
        Me.gbTextDimensions.Controls.Add(Me.gbShowBackground)
        Me.gbTextDimensions.Controls.Add(Me.gbFillCharacter)
        Me.gbTextDimensions.Controls.Add(Me.gbCharacters)
        Me.gbTextDimensions.Controls.Add(Me.gbLines)
        Me.gbTextDimensions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTextDimensions.Location = New System.Drawing.Point(3, 4)
        Me.gbTextDimensions.Name = "gbTextDimensions"
        Me.gbTextDimensions.Size = New System.Drawing.Size(174, 266)
        Me.gbTextDimensions.TabIndex = 0
        Me.gbTextDimensions.TabStop = False
        Me.gbTextDimensions.Text = "Text Dimensions"
        '
        'gbShowBackground
        '
        Me.gbShowBackground.BackColor = System.Drawing.Color.Silver
        Me.gbShowBackground.Controls.Add(Me.cbBackgroundImage)
        Me.gbShowBackground.Controls.Add(Me.cbBackgroundTextColor)
        Me.gbShowBackground.Location = New System.Drawing.Point(6, 187)
        Me.gbShowBackground.Name = "gbShowBackground"
        Me.gbShowBackground.Size = New System.Drawing.Size(162, 76)
        Me.gbShowBackground.TabIndex = 4
        Me.gbShowBackground.TabStop = False
        Me.gbShowBackground.Text = "Show BackGround"
        '
        'cbBackgroundImage
        '
        Me.cbBackgroundImage.AutoSize = True
        Me.cbBackgroundImage.Location = New System.Drawing.Point(6, 42)
        Me.cbBackgroundImage.Name = "cbBackgroundImage"
        Me.cbBackgroundImage.Size = New System.Drawing.Size(55, 17)
        Me.cbBackgroundImage.TabIndex = 5
        Me.cbBackgroundImage.Text = "Image"
        Me.cbBackgroundImage.UseVisualStyleBackColor = True
        '
        'cbBackgroundTextColor
        '
        Me.cbBackgroundTextColor.AutoSize = True
        Me.cbBackgroundTextColor.Location = New System.Drawing.Point(6, 19)
        Me.cbBackgroundTextColor.Name = "cbBackgroundTextColor"
        Me.cbBackgroundTextColor.Size = New System.Drawing.Size(74, 17)
        Me.cbBackgroundTextColor.TabIndex = 4
        Me.cbBackgroundTextColor.Text = "Text Color"
        Me.cbBackgroundTextColor.UseVisualStyleBackColor = True
        '
        'gbFillCharacter
        '
        Me.gbFillCharacter.BackColor = System.Drawing.Color.Silver
        Me.gbFillCharacter.Controls.Add(Me.cbFillCharacter)
        Me.gbFillCharacter.Location = New System.Drawing.Point(6, 130)
        Me.gbFillCharacter.Name = "gbFillCharacter"
        Me.gbFillCharacter.Size = New System.Drawing.Size(162, 43)
        Me.gbFillCharacter.TabIndex = 3
        Me.gbFillCharacter.TabStop = False
        Me.gbFillCharacter.Text = "Fill Character"
        '
        'cbFillCharacter
        '
        Me.cbFillCharacter.FormattingEnabled = True
        Me.cbFillCharacter.Location = New System.Drawing.Point(6, 16)
        Me.cbFillCharacter.Name = "cbFillCharacter"
        Me.cbFillCharacter.Size = New System.Drawing.Size(144, 21)
        Me.cbFillCharacter.TabIndex = 2
        '
        'gbCharacters
        '
        Me.gbCharacters.BackColor = System.Drawing.Color.Silver
        Me.gbCharacters.Controls.Add(Me.nudCharacters)
        Me.gbCharacters.Location = New System.Drawing.Point(6, 76)
        Me.gbCharacters.Name = "gbCharacters"
        Me.gbCharacters.Size = New System.Drawing.Size(162, 48)
        Me.gbCharacters.TabIndex = 2
        Me.gbCharacters.TabStop = False
        Me.gbCharacters.Text = "Characters "
        '
        'nudCharacters
        '
        Me.nudCharacters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudCharacters.Location = New System.Drawing.Point(6, 19)
        Me.nudCharacters.Name = "nudCharacters"
        Me.nudCharacters.Size = New System.Drawing.Size(150, 20)
        Me.nudCharacters.TabIndex = 1
        '
        'gbLines
        '
        Me.gbLines.BackColor = System.Drawing.Color.Silver
        Me.gbLines.Controls.Add(Me.nudLines)
        Me.gbLines.Location = New System.Drawing.Point(6, 17)
        Me.gbLines.Name = "gbLines"
        Me.gbLines.Size = New System.Drawing.Size(162, 53)
        Me.gbLines.TabIndex = 1
        Me.gbLines.TabStop = False
        Me.gbLines.Text = "Lines"
        '
        'nudLines
        '
        Me.nudLines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudLines.Location = New System.Drawing.Point(6, 19)
        Me.nudLines.Name = "nudLines"
        Me.nudLines.Size = New System.Drawing.Size(150, 20)
        Me.nudLines.TabIndex = 0
        '
        'tbFiles
        '
        Me.tbFiles.BackColor = System.Drawing.Color.DarkRed
        Me.tbFiles.Controls.Add(Me.gbSettingsFileLocation)
        Me.tbFiles.Controls.Add(Me.gbFileLocations)
        Me.tbFiles.Location = New System.Drawing.Point(4, 22)
        Me.tbFiles.Name = "tbFiles"
        Me.tbFiles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFiles.Size = New System.Drawing.Size(541, 273)
        Me.tbFiles.TabIndex = 2
        Me.tbFiles.Text = "Files"
        '
        'gbSettingsFileLocation
        '
        Me.gbSettingsFileLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSettingsFileLocation.BackColor = System.Drawing.Color.DarkGray
        Me.gbSettingsFileLocation.Controls.Add(Me.gbSettingsFile)
        Me.gbSettingsFileLocation.Controls.Add(Me.gbImageFile)
        Me.gbSettingsFileLocation.Location = New System.Drawing.Point(3, 139)
        Me.gbSettingsFileLocation.Name = "gbSettingsFileLocation"
        Me.gbSettingsFileLocation.Size = New System.Drawing.Size(535, 131)
        Me.gbSettingsFileLocation.TabIndex = 5
        Me.gbSettingsFileLocation.TabStop = False
        Me.gbSettingsFileLocation.Text = "Settings File Location"
        '
        'gbSettingsFile
        '
        Me.gbSettingsFile.BackColor = System.Drawing.Color.Silver
        Me.gbSettingsFile.Controls.Add(Me.tbSettingsFileLocation)
        Me.gbSettingsFile.Controls.Add(Me.buttonSetSettingsFileLocation)
        Me.gbSettingsFile.Location = New System.Drawing.Point(6, 19)
        Me.gbSettingsFile.Name = "gbSettingsFile"
        Me.gbSettingsFile.Size = New System.Drawing.Size(526, 46)
        Me.gbSettingsFile.TabIndex = 3
        Me.gbSettingsFile.TabStop = False
        Me.gbSettingsFile.Text = "Settings File"
        '
        'tbSettingsFileLocation
        '
        Me.tbSettingsFileLocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSettingsFileLocation.Location = New System.Drawing.Point(116, 19)
        Me.tbSettingsFileLocation.Name = "tbSettingsFileLocation"
        Me.tbSettingsFileLocation.Size = New System.Drawing.Size(404, 20)
        Me.tbSettingsFileLocation.TabIndex = 1
        '
        'buttonSetSettingsFileLocation
        '
        Me.buttonSetSettingsFileLocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSetSettingsFileLocation.Location = New System.Drawing.Point(7, 19)
        Me.buttonSetSettingsFileLocation.Name = "buttonSetSettingsFileLocation"
        Me.buttonSetSettingsFileLocation.Size = New System.Drawing.Size(103, 21)
        Me.buttonSetSettingsFileLocation.TabIndex = 0
        Me.buttonSetSettingsFileLocation.Text = "Set"
        Me.buttonSetSettingsFileLocation.UseVisualStyleBackColor = True
        '
        'gbImageFile
        '
        Me.gbImageFile.BackColor = System.Drawing.Color.Silver
        Me.gbImageFile.Controls.Add(Me.Label3)
        Me.gbImageFile.Controls.Add(Me.Button2)
        Me.gbImageFile.Controls.Add(Me.tbImageFileLocation)
        Me.gbImageFile.Controls.Add(Me.buttonSetImageFileLocation)
        Me.gbImageFile.Location = New System.Drawing.Point(6, 71)
        Me.gbImageFile.Name = "gbImageFile"
        Me.gbImageFile.Size = New System.Drawing.Size(526, 46)
        Me.gbImageFile.TabIndex = 4
        Me.gbImageFile.TabStop = False
        Me.gbImageFile.Text = "Image File"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "or"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(69, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 21)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Local"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbImageFileLocation
        '
        Me.tbImageFileLocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbImageFileLocation.Location = New System.Drawing.Point(116, 19)
        Me.tbImageFileLocation.Name = "tbImageFileLocation"
        Me.tbImageFileLocation.Size = New System.Drawing.Size(404, 20)
        Me.tbImageFileLocation.TabIndex = 1
        '
        'buttonSetImageFileLocation
        '
        Me.buttonSetImageFileLocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSetImageFileLocation.Location = New System.Drawing.Point(7, 18)
        Me.buttonSetImageFileLocation.Name = "buttonSetImageFileLocation"
        Me.buttonSetImageFileLocation.Size = New System.Drawing.Size(41, 21)
        Me.buttonSetImageFileLocation.TabIndex = 0
        Me.buttonSetImageFileLocation.Text = "WEB"
        Me.buttonSetImageFileLocation.UseVisualStyleBackColor = True
        '
        'gbFileLocations
        '
        Me.gbFileLocations.BackColor = System.Drawing.Color.DarkGray
        Me.gbFileLocations.Controls.Add(Me.GroupBox1)
        Me.gbFileLocations.Controls.Add(Me.gbArtFile)
        Me.gbFileLocations.Location = New System.Drawing.Point(3, 3)
        Me.gbFileLocations.Name = "gbFileLocations"
        Me.gbFileLocations.Size = New System.Drawing.Size(535, 130)
        Me.gbFileLocations.TabIndex = 4
        Me.gbFileLocations.TabStop = False
        Me.gbFileLocations.Text = "Art File Locations"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 46)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Art Load File"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(116, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(404, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(7, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 21)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Set"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gbArtFile
        '
        Me.gbArtFile.BackColor = System.Drawing.Color.Silver
        Me.gbArtFile.Controls.Add(Me.buttonSetSaveArtFileLocation)
        Me.gbArtFile.Controls.Add(Me.tbSaveArtFileLocation)
        Me.gbArtFile.Location = New System.Drawing.Point(6, 19)
        Me.gbArtFile.Name = "gbArtFile"
        Me.gbArtFile.Size = New System.Drawing.Size(526, 46)
        Me.gbArtFile.TabIndex = 2
        Me.gbArtFile.TabStop = False
        Me.gbArtFile.Text = "Art Save File"
        '
        'buttonSetSaveArtFileLocation
        '
        Me.buttonSetSaveArtFileLocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSetSaveArtFileLocation.Location = New System.Drawing.Point(6, 20)
        Me.buttonSetSaveArtFileLocation.Name = "buttonSetSaveArtFileLocation"
        Me.buttonSetSaveArtFileLocation.Size = New System.Drawing.Size(104, 20)
        Me.buttonSetSaveArtFileLocation.TabIndex = 4
        Me.buttonSetSaveArtFileLocation.Text = "Set"
        Me.buttonSetSaveArtFileLocation.UseVisualStyleBackColor = True
        '
        'tbSaveArtFileLocation
        '
        Me.tbSaveArtFileLocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSaveArtFileLocation.Location = New System.Drawing.Point(116, 20)
        Me.tbSaveArtFileLocation.Name = "tbSaveArtFileLocation"
        Me.tbSaveArtFileLocation.Size = New System.Drawing.Size(404, 20)
        Me.tbSaveArtFileLocation.TabIndex = 0
        '
        'ColorDialog1
        '
        Me.ColorDialog1.FullOpen = True
        '
        'buttonImageDown
        '
        Me.buttonImageDown.Image = Global.Ascii_Art_Composer.My.Resources.Resources.downbutton
        Me.buttonImageDown.Location = New System.Drawing.Point(277, 125)
        Me.buttonImageDown.Name = "buttonImageDown"
        Me.buttonImageDown.Size = New System.Drawing.Size(72, 82)
        Me.buttonImageDown.TabIndex = 3
        Me.buttonImageDown.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(549, 299)
        Me.Controls.Add(Me.tcSettings)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.tcSettings.ResumeLayout(False)
        Me.tpColors.ResumeLayout(False)
        Me.gbTextBoxColors.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpTextEditingSettings.ResumeLayout(False)
        Me.gbWebPresets.ResumeLayout(False)
        Me.gbBackImage.ResumeLayout(False)
        Me.gbBackImage.PerformLayout()
        CType(Me.pbCurrentBackImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTextDimensions.ResumeLayout(False)
        Me.gbShowBackground.ResumeLayout(False)
        Me.gbShowBackground.PerformLayout()
        Me.gbFillCharacter.ResumeLayout(False)
        Me.gbCharacters.ResumeLayout(False)
        CType(Me.nudCharacters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLines.ResumeLayout(False)
        CType(Me.nudLines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbFiles.ResumeLayout(False)
        Me.gbSettingsFileLocation.ResumeLayout(False)
        Me.gbSettingsFile.ResumeLayout(False)
        Me.gbSettingsFile.PerformLayout()
        Me.gbImageFile.ResumeLayout(False)
        Me.gbImageFile.PerformLayout()
        Me.gbFileLocations.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbArtFile.ResumeLayout(False)
        Me.gbArtFile.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcSettings As TabControl
    Friend WithEvents tpColors As TabPage
    Friend WithEvents tpTextEditingSettings As TabPage
    Friend WithEvents gbTextBoxColors As GroupBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbBackgroundColors As ComboBox
    Friend WithEvents cbTextBoxColors As ComboBox
    Friend WithEvents ColorBindingSource As BindingSource
    Friend WithEvents tbFiles As TabPage
    Friend WithEvents gbArtFile As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents gbBackImage As GroupBox
    Friend WithEvents gbTextDimensions As GroupBox
    Friend WithEvents gbFillCharacter As GroupBox
    Friend WithEvents cbFillCharacter As ComboBox
    Friend WithEvents gbCharacters As GroupBox
    Friend WithEvents nudCharacters As NumericUpDown
    Friend WithEvents gbLines As GroupBox
    Friend WithEvents nudLines As NumericUpDown
    Friend WithEvents gbFileLocations As GroupBox
    Friend WithEvents gbImageFile As GroupBox
    Friend WithEvents tbImageFileLocation As TextBox
    Friend WithEvents buttonSetImageFileLocation As Button
    Friend WithEvents buttonSetSaveArtFileLocation As Button
    Friend WithEvents tbSaveArtFileLocation As TextBox
    Friend WithEvents gbSettingsFile As GroupBox
    Friend WithEvents tbSettingsFileLocation As TextBox
    Friend WithEvents buttonSetSettingsFileLocation As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents gbSettingsFileLocation As GroupBox
    Friend WithEvents gbWebPresets As GroupBox
    Friend WithEvents pbCurrentBackImage As PictureBox
    Friend WithEvents gbShowBackground As GroupBox
    Friend WithEvents cbBackgroundImage As CheckBox
    Friend WithEvents cbBackgroundTextColor As CheckBox
    Friend WithEvents cbWebPresets As ComboBox
    Friend WithEvents pbLoadingImages As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lbLoadingImages As Label
    Friend WithEvents buttonImageUp As Button
    Friend WithEvents buttonImageDown As Button
End Class
