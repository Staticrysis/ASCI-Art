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
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pbLoadingImages = New System.Windows.Forms.ProgressBar()
        Me.pbCurrentBackImage = New System.Windows.Forms.PictureBox()
        Me.gbTextDimensions = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cbFillCharacter = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
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
        Me.lbLoadingImages = New System.Windows.Forms.Label()
        Me.tcSettings.SuspendLayout()
        Me.tpColors.SuspendLayout()
        Me.gbTextBoxColors.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpTextEditingSettings.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pbCurrentBackImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTextDimensions.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Me.tpTextEditingSettings.Controls.Add(Me.GroupBox8)
        Me.tpTextEditingSettings.Controls.Add(Me.GroupBox4)
        Me.tpTextEditingSettings.Controls.Add(Me.gbTextDimensions)
        Me.tpTextEditingSettings.Location = New System.Drawing.Point(4, 22)
        Me.tpTextEditingSettings.Name = "tpTextEditingSettings"
        Me.tpTextEditingSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTextEditingSettings.Size = New System.Drawing.Size(541, 273)
        Me.tpTextEditingSettings.TabIndex = 1
        Me.tpTextEditingSettings.Text = "Text Editing"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox8.Controls.Add(Me.ComboBox1)
        Me.GroupBox8.Location = New System.Drawing.Point(184, 7)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(163, 55)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Web Presets"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox4.Controls.Add(Me.lbLoadingImages)
        Me.GroupBox4.Controls.Add(Me.pbLoadingImages)
        Me.GroupBox4.Controls.Add(Me.pbCurrentBackImage)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(353, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(180, 261)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Character Defaults"
        '
        'pbLoadingImages
        '
        Me.pbLoadingImages.Location = New System.Drawing.Point(12, 75)
        Me.pbLoadingImages.Name = "pbLoadingImages"
        Me.pbLoadingImages.Size = New System.Drawing.Size(156, 23)
        Me.pbLoadingImages.TabIndex = 1
        '
        'pbCurrentBackImage
        '
        Me.pbCurrentBackImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbCurrentBackImage.Location = New System.Drawing.Point(6, 19)
        Me.pbCurrentBackImage.Name = "pbCurrentBackImage"
        Me.pbCurrentBackImage.Size = New System.Drawing.Size(168, 134)
        Me.pbCurrentBackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCurrentBackImage.TabIndex = 0
        Me.pbCurrentBackImage.TabStop = False
        '
        'gbTextDimensions
        '
        Me.gbTextDimensions.BackColor = System.Drawing.Color.DarkGray
        Me.gbTextDimensions.Controls.Add(Me.GroupBox7)
        Me.gbTextDimensions.Controls.Add(Me.GroupBox6)
        Me.gbTextDimensions.Controls.Add(Me.GroupBox5)
        Me.gbTextDimensions.Controls.Add(Me.gbLines)
        Me.gbTextDimensions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTextDimensions.Location = New System.Drawing.Point(8, 6)
        Me.gbTextDimensions.Name = "gbTextDimensions"
        Me.gbTextDimensions.Size = New System.Drawing.Size(169, 261)
        Me.gbTextDimensions.TabIndex = 0
        Me.gbTextDimensions.TabStop = False
        Me.gbTextDimensions.Text = "Text Dimensions"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Silver
        Me.GroupBox7.Controls.Add(Me.CheckBox2)
        Me.GroupBox7.Controls.Add(Me.CheckBox1)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 179)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(156, 76)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Show BackGround"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 42)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Image"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Text Color"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Silver
        Me.GroupBox6.Controls.Add(Me.cbFillCharacter)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 130)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(156, 43)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Fill Character"
        '
        'cbFillCharacter
        '
        Me.cbFillCharacter.FormattingEnabled = True
        Me.cbFillCharacter.Location = New System.Drawing.Point(6, 16)
        Me.cbFillCharacter.Name = "cbFillCharacter"
        Me.cbFillCharacter.Size = New System.Drawing.Size(144, 21)
        Me.cbFillCharacter.TabIndex = 2
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Silver
        Me.GroupBox5.Controls.Add(Me.nudCharacters)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 76)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(156, 48)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Characters "
        '
        'nudCharacters
        '
        Me.nudCharacters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudCharacters.Location = New System.Drawing.Point(6, 19)
        Me.nudCharacters.Name = "nudCharacters"
        Me.nudCharacters.Size = New System.Drawing.Size(144, 20)
        Me.nudCharacters.TabIndex = 1
        '
        'gbLines
        '
        Me.gbLines.BackColor = System.Drawing.Color.Silver
        Me.gbLines.Controls.Add(Me.nudLines)
        Me.gbLines.Location = New System.Drawing.Point(6, 17)
        Me.gbLines.Name = "gbLines"
        Me.gbLines.Size = New System.Drawing.Size(156, 53)
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
        Me.nudLines.Size = New System.Drawing.Size(144, 20)
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
        'lbLoadingImages
        '
        Me.lbLoadingImages.AutoSize = True
        Me.lbLoadingImages.Location = New System.Drawing.Point(45, 105)
        Me.lbLoadingImages.Name = "lbLoadingImages"
        Me.lbLoadingImages.Size = New System.Drawing.Size(91, 13)
        Me.lbLoadingImages.TabIndex = 2
        Me.lbLoadingImages.Text = "Loading Images..."
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
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pbCurrentBackImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTextDimensions.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
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
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents gbTextDimensions As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cbFillCharacter As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
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
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents pbCurrentBackImage As PictureBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents pbLoadingImages As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lbLoadingImages As Label
End Class
