﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
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
        Me.tpFiles = New System.Windows.Forms.TabPage()
        Me.gbSettingsFileLocation = New System.Windows.Forms.GroupBox()
        Me.gbSettingsFile = New System.Windows.Forms.GroupBox()
        Me.tbSettingsFileLocation = New System.Windows.Forms.TextBox()
        Me.buttonSetSettingsFileLocation = New System.Windows.Forms.Button()
        Me.gbImageFile = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buttonSetSaveLocalImageFile = New System.Windows.Forms.Button()
        Me.tbImageFileLocation = New System.Windows.Forms.TextBox()
        Me.buttonSetSaveWEBImageFile = New System.Windows.Forms.Button()
        Me.gbFileLocations = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbSaveLoadArtFile = New System.Windows.Forms.TextBox()
        Me.buttonSetSaveLoadFile = New System.Windows.Forms.Button()
        Me.gbArtFile = New System.Windows.Forms.GroupBox()
        Me.buttonSetSaveArtFileLocation = New System.Windows.Forms.Button()
        Me.tbSaveArtFileLocation = New System.Windows.Forms.TextBox()
        Me.tpTextEditingSettings = New System.Windows.Forms.TabPage()
        Me.gbWebPresets = New System.Windows.Forms.GroupBox()
        Me.cbWebPresets = New System.Windows.Forms.ComboBox()
        Me.gbBackImage = New System.Windows.Forms.GroupBox()
        Me.buttonImageUp = New System.Windows.Forms.Button()
        Me.buttonImageDown = New System.Windows.Forms.Button()
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
        Me.tpColors = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gbGUITextColors = New System.Windows.Forms.GroupBox()
        Me.cbGUITextColors = New System.Windows.Forms.ComboBox()
        Me.buttonGUITextColors = New System.Windows.Forms.Button()
        Me.gbGUIBackColors = New System.Windows.Forms.GroupBox()
        Me.cbGUIBackTextColors = New System.Windows.Forms.ComboBox()
        Me.buttonGUIBackTextColors = New System.Windows.Forms.Button()
        Me.gbGUIForeColors = New System.Windows.Forms.GroupBox()
        Me.cbGUIForeTextColors = New System.Windows.Forms.ComboBox()
        Me.buttonGUIForeTextColors = New System.Windows.Forms.Button()
        Me.gbTextBox = New System.Windows.Forms.GroupBox()
        Me.gbRTBTextHighlight = New System.Windows.Forms.GroupBox()
        Me.cbRTBTextHighlight = New System.Windows.Forms.ComboBox()
        Me.buttonRTBTextHighlight = New System.Windows.Forms.Button()
        Me.gbRTBTextBackColors = New System.Windows.Forms.GroupBox()
        Me.cbRTBTextBackColors = New System.Windows.Forms.ComboBox()
        Me.buttonRTBTextBackColors = New System.Windows.Forms.Button()
        Me.gbRTBTextForeColors = New System.Windows.Forms.GroupBox()
        Me.cbRTBTextForeColor = New System.Windows.Forms.ComboBox()
        Me.buttonRTBTextForeColor = New System.Windows.Forms.Button()
        Me.BindingSourceColorSettings = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSourceTextEditSettings = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSourceFileSettings = New System.Windows.Forms.BindingSource(Me.components)
        Me.tcSettings.SuspendLayout()
        Me.tpFiles.SuspendLayout()
        Me.gbSettingsFileLocation.SuspendLayout()
        Me.gbSettingsFile.SuspendLayout()
        Me.gbImageFile.SuspendLayout()
        Me.gbFileLocations.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbArtFile.SuspendLayout()
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
        Me.tpColors.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbGUITextColors.SuspendLayout()
        Me.gbGUIBackColors.SuspendLayout()
        Me.gbGUIForeColors.SuspendLayout()
        Me.gbTextBox.SuspendLayout()
        Me.gbRTBTextHighlight.SuspendLayout()
        Me.gbRTBTextBackColors.SuspendLayout()
        Me.gbRTBTextForeColors.SuspendLayout()
        CType(Me.BindingSourceColorSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceTextEditSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceFileSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcSettings
        '
        Me.tcSettings.Controls.Add(Me.tpFiles)
        Me.tcSettings.Controls.Add(Me.tpTextEditingSettings)
        Me.tcSettings.Controls.Add(Me.tpColors)
        Me.tcSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcSettings.Location = New System.Drawing.Point(0, 0)
        Me.tcSettings.Name = "tcSettings"
        Me.tcSettings.SelectedIndex = 0
        Me.tcSettings.Size = New System.Drawing.Size(549, 299)
        Me.tcSettings.TabIndex = 0
        '
        'tpFiles
        '
        Me.tpFiles.BackColor = System.Drawing.Color.DarkRed
        Me.tpFiles.Controls.Add(Me.gbSettingsFileLocation)
        Me.tpFiles.Controls.Add(Me.gbFileLocations)
        Me.tpFiles.Location = New System.Drawing.Point(4, 22)
        Me.tpFiles.Name = "tpFiles"
        Me.tpFiles.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFiles.Size = New System.Drawing.Size(541, 273)
        Me.tpFiles.TabIndex = 2
        Me.tpFiles.Text = "Files"
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
        Me.gbImageFile.Controls.Add(Me.buttonSetSaveLocalImageFile)
        Me.gbImageFile.Controls.Add(Me.tbImageFileLocation)
        Me.gbImageFile.Controls.Add(Me.buttonSetSaveWEBImageFile)
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
        'buttonSetSaveLocalImageFile
        '
        Me.buttonSetSaveLocalImageFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSetSaveLocalImageFile.Location = New System.Drawing.Point(69, 18)
        Me.buttonSetSaveLocalImageFile.Name = "buttonSetSaveLocalImageFile"
        Me.buttonSetSaveLocalImageFile.Size = New System.Drawing.Size(41, 21)
        Me.buttonSetSaveLocalImageFile.TabIndex = 2
        Me.buttonSetSaveLocalImageFile.Text = "Local"
        Me.buttonSetSaveLocalImageFile.UseVisualStyleBackColor = True
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
        'buttonSetSaveWEBImageFile
        '
        Me.buttonSetSaveWEBImageFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSetSaveWEBImageFile.Location = New System.Drawing.Point(7, 18)
        Me.buttonSetSaveWEBImageFile.Name = "buttonSetSaveWEBImageFile"
        Me.buttonSetSaveWEBImageFile.Size = New System.Drawing.Size(41, 21)
        Me.buttonSetSaveWEBImageFile.TabIndex = 0
        Me.buttonSetSaveWEBImageFile.Text = "WEB"
        Me.buttonSetSaveWEBImageFile.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Controls.Add(Me.tbSaveLoadArtFile)
        Me.GroupBox1.Controls.Add(Me.buttonSetSaveLoadFile)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 46)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Art Load File"
        '
        'tbSaveLoadArtFile
        '
        Me.tbSaveLoadArtFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSaveLoadArtFile.Location = New System.Drawing.Point(116, 19)
        Me.tbSaveLoadArtFile.Name = "tbSaveLoadArtFile"
        Me.tbSaveLoadArtFile.Size = New System.Drawing.Size(404, 20)
        Me.tbSaveLoadArtFile.TabIndex = 1
        '
        'buttonSetSaveLoadFile
        '
        Me.buttonSetSaveLoadFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSetSaveLoadFile.Location = New System.Drawing.Point(7, 19)
        Me.buttonSetSaveLoadFile.Name = "buttonSetSaveLoadFile"
        Me.buttonSetSaveLoadFile.Size = New System.Drawing.Size(103, 21)
        Me.buttonSetSaveLoadFile.TabIndex = 0
        Me.buttonSetSaveLoadFile.Text = "Set"
        Me.buttonSetSaveLoadFile.UseVisualStyleBackColor = True
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
        'buttonImageDown
        '
        Me.buttonImageDown.Image = Global.Ascii_Art_Composer.My.Resources.Resources.downbutton
        Me.buttonImageDown.Location = New System.Drawing.Point(277, 125)
        Me.buttonImageDown.Name = "buttonImageDown"
        Me.buttonImageDown.Size = New System.Drawing.Size(72, 82)
        Me.buttonImageDown.TabIndex = 3
        Me.buttonImageDown.UseVisualStyleBackColor = True
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
        'tpColors
        '
        Me.tpColors.BackColor = System.Drawing.Color.DarkRed
        Me.tpColors.Controls.Add(Me.GroupBox4)
        Me.tpColors.Controls.Add(Me.gbTextBox)
        Me.tpColors.Location = New System.Drawing.Point(4, 22)
        Me.tpColors.Name = "tpColors"
        Me.tpColors.Padding = New System.Windows.Forms.Padding(3)
        Me.tpColors.Size = New System.Drawing.Size(541, 273)
        Me.tpColors.TabIndex = 0
        Me.tpColors.Text = "Colors"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox4.Controls.Add(Me.gbGUITextColors)
        Me.GroupBox4.Controls.Add(Me.gbGUIBackColors)
        Me.GroupBox4.Controls.Add(Me.gbGUIForeColors)
        Me.GroupBox4.Location = New System.Drawing.Point(275, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(263, 205)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GUI Colors"
        '
        'gbGUITextColors
        '
        Me.gbGUITextColors.BackColor = System.Drawing.Color.Silver
        Me.gbGUITextColors.Controls.Add(Me.cbGUITextColors)
        Me.gbGUITextColors.Controls.Add(Me.buttonGUITextColors)
        Me.gbGUITextColors.Location = New System.Drawing.Point(7, 141)
        Me.gbGUITextColors.Name = "gbGUITextColors"
        Me.gbGUITextColors.Size = New System.Drawing.Size(245, 54)
        Me.gbGUITextColors.TabIndex = 2
        Me.gbGUITextColors.TabStop = False
        Me.gbGUITextColors.Text = "Text Colors"
        '
        'cbGUITextColors
        '
        Me.cbGUITextColors.FormattingEnabled = True
        Me.cbGUITextColors.Location = New System.Drawing.Point(7, 20)
        Me.cbGUITextColors.Name = "cbGUITextColors"
        Me.cbGUITextColors.Size = New System.Drawing.Size(178, 21)
        Me.cbGUITextColors.TabIndex = 2
        '
        'buttonGUITextColors
        '
        Me.buttonGUITextColors.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonGUITextColors.Location = New System.Drawing.Point(191, 20)
        Me.buttonGUITextColors.Name = "buttonGUITextColors"
        Me.buttonGUITextColors.Size = New System.Drawing.Size(48, 23)
        Me.buttonGUITextColors.TabIndex = 1
        Me.buttonGUITextColors.UseVisualStyleBackColor = True
        '
        'gbGUIBackColors
        '
        Me.gbGUIBackColors.BackColor = System.Drawing.Color.Silver
        Me.gbGUIBackColors.Controls.Add(Me.cbGUIBackTextColors)
        Me.gbGUIBackColors.Controls.Add(Me.buttonGUIBackTextColors)
        Me.gbGUIBackColors.Location = New System.Drawing.Point(7, 81)
        Me.gbGUIBackColors.Name = "gbGUIBackColors"
        Me.gbGUIBackColors.Size = New System.Drawing.Size(245, 54)
        Me.gbGUIBackColors.TabIndex = 1
        Me.gbGUIBackColors.TabStop = False
        Me.gbGUIBackColors.Text = "Back Colors"
        '
        'cbGUIBackTextColors
        '
        Me.cbGUIBackTextColors.FormattingEnabled = True
        Me.cbGUIBackTextColors.Location = New System.Drawing.Point(7, 20)
        Me.cbGUIBackTextColors.Name = "cbGUIBackTextColors"
        Me.cbGUIBackTextColors.Size = New System.Drawing.Size(178, 21)
        Me.cbGUIBackTextColors.TabIndex = 2
        '
        'buttonGUIBackTextColors
        '
        Me.buttonGUIBackTextColors.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonGUIBackTextColors.Location = New System.Drawing.Point(191, 20)
        Me.buttonGUIBackTextColors.Name = "buttonGUIBackTextColors"
        Me.buttonGUIBackTextColors.Size = New System.Drawing.Size(48, 23)
        Me.buttonGUIBackTextColors.TabIndex = 1
        Me.buttonGUIBackTextColors.UseVisualStyleBackColor = True
        '
        'gbGUIForeColors
        '
        Me.gbGUIForeColors.BackColor = System.Drawing.Color.Silver
        Me.gbGUIForeColors.Controls.Add(Me.cbGUIForeTextColors)
        Me.gbGUIForeColors.Controls.Add(Me.buttonGUIForeTextColors)
        Me.gbGUIForeColors.Location = New System.Drawing.Point(7, 21)
        Me.gbGUIForeColors.Name = "gbGUIForeColors"
        Me.gbGUIForeColors.Size = New System.Drawing.Size(245, 54)
        Me.gbGUIForeColors.TabIndex = 0
        Me.gbGUIForeColors.TabStop = False
        Me.gbGUIForeColors.Text = "Fore Colors"
        '
        'cbGUIForeTextColors
        '
        Me.cbGUIForeTextColors.FormattingEnabled = True
        Me.cbGUIForeTextColors.Location = New System.Drawing.Point(7, 20)
        Me.cbGUIForeTextColors.Name = "cbGUIForeTextColors"
        Me.cbGUIForeTextColors.Size = New System.Drawing.Size(178, 21)
        Me.cbGUIForeTextColors.TabIndex = 2
        '
        'buttonGUIForeTextColors
        '
        Me.buttonGUIForeTextColors.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonGUIForeTextColors.Location = New System.Drawing.Point(191, 20)
        Me.buttonGUIForeTextColors.Name = "buttonGUIForeTextColors"
        Me.buttonGUIForeTextColors.Size = New System.Drawing.Size(48, 23)
        Me.buttonGUIForeTextColors.TabIndex = 1
        Me.buttonGUIForeTextColors.UseVisualStyleBackColor = True
        '
        'gbTextBox
        '
        Me.gbTextBox.BackColor = System.Drawing.Color.DarkGray
        Me.gbTextBox.Controls.Add(Me.gbRTBTextHighlight)
        Me.gbTextBox.Controls.Add(Me.gbRTBTextBackColors)
        Me.gbTextBox.Controls.Add(Me.gbRTBTextForeColors)
        Me.gbTextBox.Location = New System.Drawing.Point(3, 3)
        Me.gbTextBox.Name = "gbTextBox"
        Me.gbTextBox.Size = New System.Drawing.Size(263, 205)
        Me.gbTextBox.TabIndex = 2
        Me.gbTextBox.TabStop = False
        Me.gbTextBox.Text = "Rich Text Box Colors"
        '
        'gbRTBTextHighlight
        '
        Me.gbRTBTextHighlight.BackColor = System.Drawing.Color.Silver
        Me.gbRTBTextHighlight.Controls.Add(Me.cbRTBTextHighlight)
        Me.gbRTBTextHighlight.Controls.Add(Me.buttonRTBTextHighlight)
        Me.gbRTBTextHighlight.Location = New System.Drawing.Point(7, 141)
        Me.gbRTBTextHighlight.Name = "gbRTBTextHighlight"
        Me.gbRTBTextHighlight.Size = New System.Drawing.Size(245, 54)
        Me.gbRTBTextHighlight.TabIndex = 2
        Me.gbRTBTextHighlight.TabStop = False
        Me.gbRTBTextHighlight.Text = "Text Highlight Color"
        '
        'cbRTBTextHighlight
        '
        Me.cbRTBTextHighlight.FormattingEnabled = True
        Me.cbRTBTextHighlight.Location = New System.Drawing.Point(7, 20)
        Me.cbRTBTextHighlight.Name = "cbRTBTextHighlight"
        Me.cbRTBTextHighlight.Size = New System.Drawing.Size(178, 21)
        Me.cbRTBTextHighlight.TabIndex = 2
        '
        'buttonRTBTextHighlight
        '
        Me.buttonRTBTextHighlight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonRTBTextHighlight.Location = New System.Drawing.Point(191, 20)
        Me.buttonRTBTextHighlight.Name = "buttonRTBTextHighlight"
        Me.buttonRTBTextHighlight.Size = New System.Drawing.Size(48, 23)
        Me.buttonRTBTextHighlight.TabIndex = 1
        Me.buttonRTBTextHighlight.UseVisualStyleBackColor = True
        '
        'gbRTBTextBackColors
        '
        Me.gbRTBTextBackColors.BackColor = System.Drawing.Color.Silver
        Me.gbRTBTextBackColors.Controls.Add(Me.cbRTBTextBackColors)
        Me.gbRTBTextBackColors.Controls.Add(Me.buttonRTBTextBackColors)
        Me.gbRTBTextBackColors.Location = New System.Drawing.Point(7, 81)
        Me.gbRTBTextBackColors.Name = "gbRTBTextBackColors"
        Me.gbRTBTextBackColors.Size = New System.Drawing.Size(245, 54)
        Me.gbRTBTextBackColors.TabIndex = 1
        Me.gbRTBTextBackColors.TabStop = False
        Me.gbRTBTextBackColors.Text = "Back Colors"
        '
        'cbRTBTextBackColors
        '
        Me.cbRTBTextBackColors.FormattingEnabled = True
        Me.cbRTBTextBackColors.Location = New System.Drawing.Point(7, 20)
        Me.cbRTBTextBackColors.Name = "cbRTBTextBackColors"
        Me.cbRTBTextBackColors.Size = New System.Drawing.Size(178, 21)
        Me.cbRTBTextBackColors.TabIndex = 2
        '
        'buttonRTBTextBackColors
        '
        Me.buttonRTBTextBackColors.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonRTBTextBackColors.Location = New System.Drawing.Point(191, 20)
        Me.buttonRTBTextBackColors.Name = "buttonRTBTextBackColors"
        Me.buttonRTBTextBackColors.Size = New System.Drawing.Size(48, 23)
        Me.buttonRTBTextBackColors.TabIndex = 1
        Me.buttonRTBTextBackColors.UseVisualStyleBackColor = True
        '
        'gbRTBTextForeColors
        '
        Me.gbRTBTextForeColors.BackColor = System.Drawing.Color.Silver
        Me.gbRTBTextForeColors.Controls.Add(Me.cbRTBTextForeColor)
        Me.gbRTBTextForeColors.Controls.Add(Me.buttonRTBTextForeColor)
        Me.gbRTBTextForeColors.Location = New System.Drawing.Point(7, 21)
        Me.gbRTBTextForeColors.Name = "gbRTBTextForeColors"
        Me.gbRTBTextForeColors.Size = New System.Drawing.Size(245, 54)
        Me.gbRTBTextForeColors.TabIndex = 0
        Me.gbRTBTextForeColors.TabStop = False
        Me.gbRTBTextForeColors.Text = "Fore Colors"
        '
        'cbRTBTextForeColor
        '
        Me.cbRTBTextForeColor.FormattingEnabled = True
        Me.cbRTBTextForeColor.Location = New System.Drawing.Point(7, 20)
        Me.cbRTBTextForeColor.Name = "cbRTBTextForeColor"
        Me.cbRTBTextForeColor.Size = New System.Drawing.Size(178, 21)
        Me.cbRTBTextForeColor.TabIndex = 2
        '
        'buttonRTBTextForeColor
        '
        Me.buttonRTBTextForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonRTBTextForeColor.Location = New System.Drawing.Point(191, 20)
        Me.buttonRTBTextForeColor.Name = "buttonRTBTextForeColor"
        Me.buttonRTBTextForeColor.Size = New System.Drawing.Size(48, 23)
        Me.buttonRTBTextForeColor.TabIndex = 1
        Me.buttonRTBTextForeColor.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(549, 299)
        Me.Controls.Add(Me.tcSettings)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.tcSettings.ResumeLayout(False)
        Me.tpFiles.ResumeLayout(False)
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
        Me.tpColors.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.gbGUITextColors.ResumeLayout(False)
        Me.gbGUIBackColors.ResumeLayout(False)
        Me.gbGUIForeColors.ResumeLayout(False)
        Me.gbTextBox.ResumeLayout(False)
        Me.gbRTBTextHighlight.ResumeLayout(False)
        Me.gbRTBTextBackColors.ResumeLayout(False)
        Me.gbRTBTextForeColors.ResumeLayout(False)
        CType(Me.BindingSourceColorSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceTextEditSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceFileSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcSettings As TabControl
    Friend WithEvents tpColors As TabPage
    Friend WithEvents tpTextEditingSettings As TabPage
    Friend WithEvents tpFiles As TabPage
    Friend WithEvents gbArtFile As GroupBox
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
    Friend WithEvents buttonSetSaveWEBImageFile As Button
    Friend WithEvents buttonSetSaveArtFileLocation As Button
    Friend WithEvents tbSaveArtFileLocation As TextBox
    Friend WithEvents gbSettingsFile As GroupBox
    Friend WithEvents tbSettingsFileLocation As TextBox
    Friend WithEvents buttonSetSettingsFileLocation As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbSaveLoadArtFile As TextBox
    Friend WithEvents buttonSetSaveLoadFile As Button
    Friend WithEvents gbSettingsFileLocation As GroupBox
    Friend WithEvents gbWebPresets As GroupBox
    Friend WithEvents pbCurrentBackImage As PictureBox
    Friend WithEvents gbShowBackground As GroupBox
    Friend WithEvents cbBackgroundImage As CheckBox
    Friend WithEvents cbBackgroundTextColor As CheckBox
    Friend WithEvents cbWebPresets As ComboBox
    Friend WithEvents pbLoadingImages As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents buttonSetSaveLocalImageFile As Button
    Friend WithEvents lbLoadingImages As Label
    Friend WithEvents buttonImageUp As Button
    Friend WithEvents buttonImageDown As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents gbGUITextColors As GroupBox
    Friend WithEvents cbGUITextColors As ComboBox
    Friend WithEvents buttonGUITextColors As Button
    Friend WithEvents gbGUIBackColors As GroupBox
    Friend WithEvents cbGUIBackTextColors As ComboBox
    Friend WithEvents buttonGUIBackTextColors As Button
    Friend WithEvents gbGUIForeColors As GroupBox
    Friend WithEvents cbGUIForeTextColors As ComboBox
    Friend WithEvents buttonGUIForeTextColors As Button
    Friend WithEvents gbTextBox As GroupBox
    Friend WithEvents gbRTBTextHighlight As GroupBox
    Friend WithEvents cbRTBTextHighlight As ComboBox
    Friend WithEvents buttonRTBTextHighlight As Button
    Friend WithEvents gbRTBTextBackColors As GroupBox
    Friend WithEvents cbRTBTextBackColors As ComboBox
    Friend WithEvents buttonRTBTextBackColors As Button
    Friend WithEvents gbRTBTextForeColors As GroupBox
    Friend WithEvents cbRTBTextForeColor As ComboBox
    Friend WithEvents buttonRTBTextForeColor As Button
    Friend WithEvents BindingSourceColorSettings As BindingSource
    Friend WithEvents BindingSourceTextEditSettings As BindingSource
    Friend WithEvents BindingSourceFileSettings As BindingSource
End Class
