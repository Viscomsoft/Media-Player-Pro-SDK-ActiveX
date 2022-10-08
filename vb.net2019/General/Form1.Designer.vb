<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.label19 = New System.Windows.Forms.Label()
        Me.widthTextBox = New System.Windows.Forms.TextBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.positionTextBox = New System.Windows.Forms.TextBox()
        Me.groupBox10 = New System.Windows.Forms.GroupBox()
        Me.bothRadioButton = New System.Windows.Forms.RadioButton()
        Me.leftRadioButton = New System.Windows.Forms.RadioButton()
        Me.rightRadioButton = New System.Windows.Forms.RadioButton()
        Me.label23 = New System.Windows.Forms.Label()
        Me.label22 = New System.Windows.Forms.Label()
        Me.position = New System.Windows.Forms.NumericUpDown()
        Me.postionButton = New System.Windows.Forms.Button()
        Me.loopingCheckBox = New System.Windows.Forms.CheckBox()
        Me.ratioCheckBox = New System.Windows.Forms.CheckBox()
        Me.heightTextBox = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.durationTextBox = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.groupBox9 = New System.Windows.Forms.GroupBox()
        Me.label21 = New System.Windows.Forms.Label()
        Me.playbackRateButton = New System.Windows.Forms.Button()
        Me.playbackRate = New System.Windows.Forms.NumericUpDown()
        Me.resizeButton2 = New System.Windows.Forms.Button()
        Me.resizeButton1 = New System.Windows.Forms.Button()
        Me.pitchGroupBox = New System.Windows.Forms.GroupBox()
        Me.restoreTempoButton = New System.Windows.Forms.Button()
        Me.decTempoTrackBar = New System.Windows.Forms.TrackBar()
        Me.label28 = New System.Windows.Forms.Label()
        Me.incTempoTrackBar = New System.Windows.Forms.TrackBar()
        Me.label27 = New System.Windows.Forms.Label()
        Me.restorePitchButton = New System.Windows.Forms.Button()
        Me.label26 = New System.Windows.Forms.Label()
        Me.label25 = New System.Windows.Forms.Label()
        Me.label24 = New System.Windows.Forms.Label()
        Me.pitchTrackBar = New System.Windows.Forms.TrackBar()
        Me.snapshotToHBitButton = New System.Windows.Forms.Button()
        Me.snapshotToPicButton = New System.Windows.Forms.Button()
        Me.snapshotButton = New System.Windows.Forms.Button()
        Me.groupBox8 = New System.Windows.Forms.GroupBox()
        Me.soundTrackBar = New System.Windows.Forms.TrackBar()
        Me.fileButton = New System.Windows.Forms.Button()
        Me.groupBox7 = New System.Windows.Forms.GroupBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.usePitchCheckBox = New System.Windows.Forms.CheckBox()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbomousebutton = New System.Windows.Forms.ComboBox()
        Me.cbokey = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pauseButton = New System.Windows.Forms.Button()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.playButton = New System.Windows.Forms.Button()
        Me.trackBar1 = New System.Windows.Forms.TrackBar()
        Me.AxMoviePlayer1 = New AxMOVIEPLAYERLib.AxMoviePlayer()
        Me.ListBoxMP4Stream = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonStepBackward = New System.Windows.Forms.Button()
        Me.ButtonStepForward = New System.Windows.Forms.Button()
        Me.snapshot2bytearray = New System.Windows.Forms.Button()
        Me.chkshowspectrum = New System.Windows.Forms.CheckBox()
        Me.btnspectmono = New System.Windows.Forms.Button()
        Me.btnspectstereo = New System.Windows.Forms.Button()
        Me.btnspectseparator = New System.Windows.Forms.Button()
        Me.btnspectbar2 = New System.Windows.Forms.Button()
        Me.btnspectbar1 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.groupBox10.SuspendLayout()
        CType(Me.position, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox9.SuspendLayout()
        CType(Me.playbackRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pitchGroupBox.SuspendLayout()
        CType(Me.decTempoTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.incTempoTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pitchTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox8.SuspendLayout()
        CType(Me.soundTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox7.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxMoviePlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(266, 44)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(77, 12)
        Me.label19.TabIndex = 6
        Me.label19.Text = "Video Height"
        '
        'widthTextBox
        '
        Me.widthTextBox.Location = New System.Drawing.Point(353, 18)
        Me.widthTextBox.Name = "widthTextBox"
        Me.widthTextBox.ReadOnly = True
        Me.widthTextBox.Size = New System.Drawing.Size(100, 21)
        Me.widthTextBox.TabIndex = 5
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(266, 20)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(71, 12)
        Me.label20.TabIndex = 4
        Me.label20.Text = "Video Width"
        '
        'positionTextBox
        '
        Me.positionTextBox.Location = New System.Drawing.Point(93, 42)
        Me.positionTextBox.Name = "positionTextBox"
        Me.positionTextBox.ReadOnly = True
        Me.positionTextBox.Size = New System.Drawing.Size(100, 21)
        Me.positionTextBox.TabIndex = 3
        '
        'groupBox10
        '
        Me.groupBox10.Controls.Add(Me.bothRadioButton)
        Me.groupBox10.Controls.Add(Me.leftRadioButton)
        Me.groupBox10.Controls.Add(Me.rightRadioButton)
        Me.groupBox10.Controls.Add(Me.label23)
        Me.groupBox10.Controls.Add(Me.label22)
        Me.groupBox10.Controls.Add(Me.position)
        Me.groupBox10.Controls.Add(Me.postionButton)
        Me.groupBox10.Controls.Add(Me.loopingCheckBox)
        Me.groupBox10.Controls.Add(Me.ratioCheckBox)
        Me.groupBox10.Location = New System.Drawing.Point(14, 603)
        Me.groupBox10.Name = "groupBox10"
        Me.groupBox10.Size = New System.Drawing.Size(306, 78)
        Me.groupBox10.TabIndex = 22
        Me.groupBox10.TabStop = False
        Me.groupBox10.Text = "Misc"
        '
        'bothRadioButton
        '
        Me.bothRadioButton.AutoSize = True
        Me.bothRadioButton.Location = New System.Drawing.Point(121, 55)
        Me.bothRadioButton.Name = "bothRadioButton"
        Me.bothRadioButton.Size = New System.Drawing.Size(47, 16)
        Me.bothRadioButton.TabIndex = 10
        Me.bothRadioButton.Text = "Both"
        Me.bothRadioButton.UseVisualStyleBackColor = True
        '
        'leftRadioButton
        '
        Me.leftRadioButton.AutoSize = True
        Me.leftRadioButton.Location = New System.Drawing.Point(69, 55)
        Me.leftRadioButton.Name = "leftRadioButton"
        Me.leftRadioButton.Size = New System.Drawing.Size(47, 16)
        Me.leftRadioButton.TabIndex = 9
        Me.leftRadioButton.Text = "Left"
        Me.leftRadioButton.UseVisualStyleBackColor = True
        '
        'rightRadioButton
        '
        Me.rightRadioButton.AutoSize = True
        Me.rightRadioButton.Checked = True
        Me.rightRadioButton.Location = New System.Drawing.Point(9, 55)
        Me.rightRadioButton.Name = "rightRadioButton"
        Me.rightRadioButton.Size = New System.Drawing.Size(53, 16)
        Me.rightRadioButton.TabIndex = 8
        Me.rightRadioButton.TabStop = True
        Me.rightRadioButton.Text = "Right"
        Me.rightRadioButton.UseVisualStyleBackColor = True
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Location = New System.Drawing.Point(6, 41)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(149, 12)
        Me.label23.TabIndex = 7
        Me.label23.Text = "MPEG1 File Audio Channel"
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Location = New System.Drawing.Point(288, 18)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(11, 12)
        Me.label22.TabIndex = 6
        Me.label22.Text = "s"
        '
        'position
        '
        Me.position.Location = New System.Drawing.Point(239, 15)
        Me.position.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(43, 21)
        Me.position.TabIndex = 5
        '
        'postionButton
        '
        Me.postionButton.AutoSize = True
        Me.postionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.postionButton.Location = New System.Drawing.Point(169, 14)
        Me.postionButton.Name = "postionButton"
        Me.postionButton.Size = New System.Drawing.Size(69, 22)
        Me.postionButton.TabIndex = 4
        Me.postionButton.Text = "Go to Pos"
        Me.postionButton.UseVisualStyleBackColor = True
        '
        'loopingCheckBox
        '
        Me.loopingCheckBox.AutoSize = True
        Me.loopingCheckBox.Checked = True
        Me.loopingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.loopingCheckBox.Location = New System.Drawing.Point(99, 18)
        Me.loopingCheckBox.Name = "loopingCheckBox"
        Me.loopingCheckBox.Size = New System.Drawing.Size(66, 16)
        Me.loopingCheckBox.TabIndex = 1
        Me.loopingCheckBox.Text = "Looping"
        Me.loopingCheckBox.UseVisualStyleBackColor = True
        '
        'ratioCheckBox
        '
        Me.ratioCheckBox.AutoSize = True
        Me.ratioCheckBox.Checked = True
        Me.ratioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ratioCheckBox.Location = New System.Drawing.Point(6, 18)
        Me.ratioCheckBox.Name = "ratioCheckBox"
        Me.ratioCheckBox.Size = New System.Drawing.Size(96, 16)
        Me.ratioCheckBox.TabIndex = 0
        Me.ratioCheckBox.Text = "Aspect Ratio"
        Me.ratioCheckBox.UseVisualStyleBackColor = True
        '
        'heightTextBox
        '
        Me.heightTextBox.Location = New System.Drawing.Point(353, 42)
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.ReadOnly = True
        Me.heightTextBox.Size = New System.Drawing.Size(100, 21)
        Me.heightTextBox.TabIndex = 7
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(6, 44)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(101, 12)
        Me.label18.TabIndex = 2
        Me.label18.Text = "Current Position"
        '
        'durationTextBox
        '
        Me.durationTextBox.Location = New System.Drawing.Point(93, 18)
        Me.durationTextBox.Name = "durationTextBox"
        Me.durationTextBox.ReadOnly = True
        Me.durationTextBox.Size = New System.Drawing.Size(100, 21)
        Me.durationTextBox.TabIndex = 1
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(6, 20)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(89, 12)
        Me.label17.TabIndex = 0
        Me.label17.Text = "Total Duration"
        '
        'groupBox9
        '
        Me.groupBox9.Controls.Add(Me.label21)
        Me.groupBox9.Controls.Add(Me.playbackRateButton)
        Me.groupBox9.Controls.Add(Me.playbackRate)
        Me.groupBox9.Location = New System.Drawing.Point(14, 541)
        Me.groupBox9.Name = "groupBox9"
        Me.groupBox9.Size = New System.Drawing.Size(306, 56)
        Me.groupBox9.TabIndex = 21
        Me.groupBox9.TabStop = False
        Me.groupBox9.Text = "Playback rate"
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Location = New System.Drawing.Point(192, 15)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(101, 36)
        Me.label21.TabIndex = 3
        Me.label21.Text = "1 = normal speed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.5 = half speed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 = twice speed"
        '
        'playbackRateButton
        '
        Me.playbackRateButton.AutoSize = True
        Me.playbackRateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.playbackRateButton.Location = New System.Drawing.Point(153, 15)
        Me.playbackRateButton.Name = "playbackRateButton"
        Me.playbackRateButton.Size = New System.Drawing.Size(33, 22)
        Me.playbackRateButton.TabIndex = 2
        Me.playbackRateButton.Text = "Set"
        Me.playbackRateButton.UseVisualStyleBackColor = True
        '
        'playbackRate
        '
        Me.playbackRate.DecimalPlaces = 1
        Me.playbackRate.Location = New System.Drawing.Point(27, 18)
        Me.playbackRate.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.playbackRate.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.playbackRate.Name = "playbackRate"
        Me.playbackRate.Size = New System.Drawing.Size(120, 21)
        Me.playbackRate.TabIndex = 0
        Me.playbackRate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'resizeButton2
        '
        Me.resizeButton2.AutoSize = True
        Me.resizeButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.resizeButton2.Location = New System.Drawing.Point(185, 92)
        Me.resizeButton2.Name = "resizeButton2"
        Me.resizeButton2.Size = New System.Drawing.Size(117, 22)
        Me.resizeButton2.TabIndex = 9
        Me.resizeButton2.Text = "Resize to 200x200"
        Me.resizeButton2.UseVisualStyleBackColor = True
        '
        'resizeButton1
        '
        Me.resizeButton1.AutoSize = True
        Me.resizeButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.resizeButton1.Location = New System.Drawing.Point(74, 92)
        Me.resizeButton1.Name = "resizeButton1"
        Me.resizeButton1.Size = New System.Drawing.Size(117, 22)
        Me.resizeButton1.TabIndex = 8
        Me.resizeButton1.Text = "Resize to 100x100"
        Me.resizeButton1.UseVisualStyleBackColor = True
        '
        'pitchGroupBox
        '
        Me.pitchGroupBox.Controls.Add(Me.restoreTempoButton)
        Me.pitchGroupBox.Controls.Add(Me.decTempoTrackBar)
        Me.pitchGroupBox.Controls.Add(Me.label28)
        Me.pitchGroupBox.Controls.Add(Me.incTempoTrackBar)
        Me.pitchGroupBox.Controls.Add(Me.label27)
        Me.pitchGroupBox.Controls.Add(Me.restorePitchButton)
        Me.pitchGroupBox.Controls.Add(Me.label26)
        Me.pitchGroupBox.Controls.Add(Me.label25)
        Me.pitchGroupBox.Controls.Add(Me.label24)
        Me.pitchGroupBox.Controls.Add(Me.pitchTrackBar)
        Me.pitchGroupBox.Enabled = False
        Me.pitchGroupBox.Location = New System.Drawing.Point(326, 556)
        Me.pitchGroupBox.Name = "pitchGroupBox"
        Me.pitchGroupBox.Size = New System.Drawing.Size(466, 139)
        Me.pitchGroupBox.TabIndex = 23
        Me.pitchGroupBox.TabStop = False
        Me.pitchGroupBox.Text = "Pitch and Tempo"
        '
        'restoreTempoButton
        '
        Me.restoreTempoButton.AutoSize = True
        Me.restoreTempoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.restoreTempoButton.Location = New System.Drawing.Point(362, 98)
        Me.restoreTempoButton.Name = "restoreTempoButton"
        Me.restoreTempoButton.Size = New System.Drawing.Size(105, 22)
        Me.restoreTempoButton.TabIndex = 15
        Me.restoreTempoButton.Text = "Restore Default"
        Me.restoreTempoButton.UseVisualStyleBackColor = True
        '
        'decTempoTrackBar
        '
        Me.decTempoTrackBar.AutoSize = False
        Me.decTempoTrackBar.Location = New System.Drawing.Point(21, 117)
        Me.decTempoTrackBar.Name = "decTempoTrackBar"
        Me.decTempoTrackBar.Size = New System.Drawing.Size(328, 18)
        Me.decTempoTrackBar.TabIndex = 14
        '
        'label28
        '
        Me.label28.AutoSize = True
        Me.label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label28.Location = New System.Drawing.Point(6, 102)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(103, 13)
        Me.label28.TabIndex = 13
        Me.label28.Text = "Tempo Decrease"
        '
        'incTempoTrackBar
        '
        Me.incTempoTrackBar.AutoSize = False
        Me.incTempoTrackBar.Location = New System.Drawing.Point(21, 84)
        Me.incTempoTrackBar.Name = "incTempoTrackBar"
        Me.incTempoTrackBar.Size = New System.Drawing.Size(328, 18)
        Me.incTempoTrackBar.TabIndex = 12
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label27.Location = New System.Drawing.Point(6, 69)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(98, 13)
        Me.label27.TabIndex = 11
        Me.label27.Text = "Tempo Increase"
        '
        'restorePitchButton
        '
        Me.restorePitchButton.AutoSize = True
        Me.restorePitchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.restorePitchButton.Location = New System.Drawing.Point(362, 45)
        Me.restorePitchButton.Name = "restorePitchButton"
        Me.restorePitchButton.Size = New System.Drawing.Size(105, 22)
        Me.restorePitchButton.TabIndex = 10
        Me.restorePitchButton.Text = "Restore Default"
        Me.restorePitchButton.UseVisualStyleBackColor = True
        '
        'label26
        '
        Me.label26.AutoSize = True
        Me.label26.Location = New System.Drawing.Point(276, 33)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(107, 12)
        Me.label26.TabIndex = 3
        Me.label26.Text = "-> voice to child"
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Location = New System.Drawing.Point(18, 33)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(95, 12)
        Me.label25.TabIndex = 2
        Me.label25.Text = "voice to man <-"
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label24.Location = New System.Drawing.Point(6, 18)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(36, 13)
        Me.label24.TabIndex = 1
        Me.label24.Text = "Pitch"
        '
        'pitchTrackBar
        '
        Me.pitchTrackBar.AutoSize = False
        Me.pitchTrackBar.Location = New System.Drawing.Point(21, 48)
        Me.pitchTrackBar.Maximum = 24
        Me.pitchTrackBar.Name = "pitchTrackBar"
        Me.pitchTrackBar.Size = New System.Drawing.Size(328, 18)
        Me.pitchTrackBar.TabIndex = 0
        '
        'snapshotToHBitButton
        '
        Me.snapshotToHBitButton.AutoSize = True
        Me.snapshotToHBitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.snapshotToHBitButton.Location = New System.Drawing.Point(652, 318)
        Me.snapshotToHBitButton.Name = "snapshotToHBitButton"
        Me.snapshotToHBitButton.Size = New System.Drawing.Size(111, 22)
        Me.snapshotToHBitButton.TabIndex = 7
        Me.snapshotToHBitButton.Text = "Snapshot2HBITMAP"
        Me.snapshotToHBitButton.UseVisualStyleBackColor = True
        '
        'snapshotToPicButton
        '
        Me.snapshotToPicButton.AutoSize = True
        Me.snapshotToPicButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.snapshotToPicButton.Location = New System.Drawing.Point(539, 318)
        Me.snapshotToPicButton.Name = "snapshotToPicButton"
        Me.snapshotToPicButton.Size = New System.Drawing.Size(111, 22)
        Me.snapshotToPicButton.TabIndex = 6
        Me.snapshotToPicButton.Text = "Snapshot2Picture"
        Me.snapshotToPicButton.UseVisualStyleBackColor = True
        '
        'snapshotButton
        '
        Me.snapshotButton.AutoSize = True
        Me.snapshotButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.snapshotButton.Location = New System.Drawing.Point(470, 318)
        Me.snapshotButton.Name = "snapshotButton"
        Me.snapshotButton.Size = New System.Drawing.Size(63, 22)
        Me.snapshotButton.TabIndex = 5
        Me.snapshotButton.Text = "Snapshot"
        Me.snapshotButton.UseVisualStyleBackColor = True
        '
        'groupBox8
        '
        Me.groupBox8.Controls.Add(Me.soundTrackBar)
        Me.groupBox8.Location = New System.Drawing.Point(14, 491)
        Me.groupBox8.Name = "groupBox8"
        Me.groupBox8.Size = New System.Drawing.Size(306, 44)
        Me.groupBox8.TabIndex = 20
        Me.groupBox8.TabStop = False
        Me.groupBox8.Text = "Sound"
        '
        'soundTrackBar
        '
        Me.soundTrackBar.AutoSize = False
        Me.soundTrackBar.Location = New System.Drawing.Point(6, 17)
        Me.soundTrackBar.Maximum = 10000
        Me.soundTrackBar.Name = "soundTrackBar"
        Me.soundTrackBar.Size = New System.Drawing.Size(291, 18)
        Me.soundTrackBar.TabIndex = 4
        Me.soundTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'fileButton
        '
        Me.fileButton.AutoSize = True
        Me.fileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.fileButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileButton.Location = New System.Drawing.Point(6, 39)
        Me.fileButton.Name = "fileButton"
        Me.fileButton.Size = New System.Drawing.Size(115, 23)
        Me.fileButton.TabIndex = 4
        Me.fileButton.Text = "Select Media File"
        Me.fileButton.UseVisualStyleBackColor = True
        '
        'groupBox7
        '
        Me.groupBox7.Controls.Add(Me.heightTextBox)
        Me.groupBox7.Controls.Add(Me.label19)
        Me.groupBox7.Controls.Add(Me.widthTextBox)
        Me.groupBox7.Controls.Add(Me.label20)
        Me.groupBox7.Controls.Add(Me.positionTextBox)
        Me.groupBox7.Controls.Add(Me.label18)
        Me.groupBox7.Controls.Add(Me.durationTextBox)
        Me.groupBox7.Controls.Add(Me.label17)
        Me.groupBox7.Location = New System.Drawing.Point(326, 491)
        Me.groupBox7.Name = "groupBox7"
        Me.groupBox7.Size = New System.Drawing.Size(466, 69)
        Me.groupBox7.TabIndex = 19
        Me.groupBox7.TabStop = False
        Me.groupBox7.Text = "Info"
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox1.Location = New System.Drawing.Point(488, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(387, 289)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 17
        Me.pictureBox1.TabStop = False
        '
        'usePitchCheckBox
        '
        Me.usePitchCheckBox.AutoSize = True
        Me.usePitchCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usePitchCheckBox.Location = New System.Drawing.Point(6, 18)
        Me.usePitchCheckBox.Name = "usePitchCheckBox"
        Me.usePitchCheckBox.Size = New System.Drawing.Size(152, 17)
        Me.usePitchCheckBox.TabIndex = 0
        Me.usePitchCheckBox.Text = "Use Pitch and Tempo "
        Me.usePitchCheckBox.UseVisualStyleBackColor = True
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.GroupBox4)
        Me.groupBox5.Controls.Add(Me.Button1)
        Me.groupBox5.Controls.Add(Me.resizeButton2)
        Me.groupBox5.Controls.Add(Me.resizeButton1)
        Me.groupBox5.Controls.Add(Me.fileButton)
        Me.groupBox5.Controls.Add(Me.pauseButton)
        Me.groupBox5.Controls.Add(Me.stopButton)
        Me.groupBox5.Controls.Add(Me.playButton)
        Me.groupBox5.Controls.Add(Me.usePitchCheckBox)
        Me.groupBox5.Location = New System.Drawing.Point(14, 365)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(514, 121)
        Me.groupBox5.TabIndex = 16
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Control"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbomousebutton)
        Me.GroupBox4.Controls.Add(Me.cbokey)
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Location = New System.Drawing.Point(305, 43)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(205, 69)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Clear Full Screen Type"
        '
        'cbomousebutton
        '
        Me.cbomousebutton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomousebutton.FormattingEnabled = True
        Me.cbomousebutton.Location = New System.Drawing.Point(91, 40)
        Me.cbomousebutton.Name = "cbomousebutton"
        Me.cbomousebutton.Size = New System.Drawing.Size(109, 20)
        Me.cbomousebutton.TabIndex = 3
        '
        'cbokey
        '
        Me.cbokey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbokey.FormattingEnabled = True
        Me.cbokey.Location = New System.Drawing.Point(91, 18)
        Me.cbokey.Name = "cbokey"
        Me.cbokey.Size = New System.Drawing.Size(109, 20)
        Me.cbokey.TabIndex = 2
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(89, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "MouseButton"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(8, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(41, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Key"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(321, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 28)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Full Screen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pauseButton
        '
        Me.pauseButton.AutoSize = True
        Me.pauseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pauseButton.Enabled = False
        Me.pauseButton.Location = New System.Drawing.Point(252, 14)
        Me.pauseButton.Name = "pauseButton"
        Me.pauseButton.Size = New System.Drawing.Size(45, 22)
        Me.pauseButton.TabIndex = 3
        Me.pauseButton.Text = "Pause"
        Me.pauseButton.UseVisualStyleBackColor = True
        '
        'stopButton
        '
        Me.stopButton.AutoSize = True
        Me.stopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.stopButton.Enabled = False
        Me.stopButton.Location = New System.Drawing.Point(207, 14)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(39, 22)
        Me.stopButton.TabIndex = 2
        Me.stopButton.Text = "Stop"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'playButton
        '
        Me.playButton.AutoSize = True
        Me.playButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.playButton.Enabled = False
        Me.playButton.Location = New System.Drawing.Point(164, 14)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(39, 22)
        Me.playButton.TabIndex = 1
        Me.playButton.Text = "Play"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'trackBar1
        '
        Me.trackBar1.Location = New System.Drawing.Point(11, 314)
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(451, 45)
        Me.trackBar1.TabIndex = 15
        Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'AxMoviePlayer1
        '
        Me.AxMoviePlayer1.Enabled = True
        Me.AxMoviePlayer1.Location = New System.Drawing.Point(13, 13)
        Me.AxMoviePlayer1.Name = "AxMoviePlayer1"
        Me.AxMoviePlayer1.OcxState = CType(resources.GetObject("AxMoviePlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMoviePlayer1.Size = New System.Drawing.Size(452, 277)
        Me.AxMoviePlayer1.TabIndex = 24
        '
        'ListBoxMP4Stream
        '
        Me.ListBoxMP4Stream.FormattingEnabled = True
        Me.ListBoxMP4Stream.ItemHeight = 12
        Me.ListBoxMP4Stream.Location = New System.Drawing.Point(543, 383)
        Me.ListBoxMP4Stream.Name = "ListBoxMP4Stream"
        Me.ListBoxMP4Stream.Size = New System.Drawing.Size(235, 64)
        Me.ListBoxMP4Stream.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(540, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 12)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "For DIVX , WMV, WEBM, MOV, MP4, VOB, MPEG2, MPEG1, M2TS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(543, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Audio Tracks"
        '
        'ButtonStepBackward
        '
        Me.ButtonStepBackward.Location = New System.Drawing.Point(544, 459)
        Me.ButtonStepBackward.Name = "ButtonStepBackward"
        Me.ButtonStepBackward.Size = New System.Drawing.Size(103, 32)
        Me.ButtonStepBackward.TabIndex = 28
        Me.ButtonStepBackward.Text = "Step backward"
        Me.ButtonStepBackward.UseVisualStyleBackColor = True
        '
        'ButtonStepForward
        '
        Me.ButtonStepForward.Location = New System.Drawing.Point(660, 459)
        Me.ButtonStepForward.Name = "ButtonStepForward"
        Me.ButtonStepForward.Size = New System.Drawing.Size(118, 31)
        Me.ButtonStepForward.TabIndex = 29
        Me.ButtonStepForward.Text = "Step forward"
        Me.ButtonStepForward.UseVisualStyleBackColor = True
        '
        'snapshot2bytearray
        '
        Me.snapshot2bytearray.AutoSize = True
        Me.snapshot2bytearray.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.snapshot2bytearray.Location = New System.Drawing.Point(765, 318)
        Me.snapshot2bytearray.Name = "snapshot2bytearray"
        Me.snapshot2bytearray.Size = New System.Drawing.Size(123, 22)
        Me.snapshot2bytearray.TabIndex = 30
        Me.snapshot2bytearray.Text = "Snapshot2ByteArray"
        Me.snapshot2bytearray.UseVisualStyleBackColor = True
        '
        'chkshowspectrum
        '
        Me.chkshowspectrum.AutoSize = True
        Me.chkshowspectrum.Checked = True
        Me.chkshowspectrum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkshowspectrum.Location = New System.Drawing.Point(11, 346)
        Me.chkshowspectrum.Name = "chkshowspectrum"
        Me.chkshowspectrum.Size = New System.Drawing.Size(204, 16)
        Me.chkshowspectrum.TabIndex = 42
        Me.chkshowspectrum.Text = "Show Spectrum(Audio File Only)"
        Me.chkshowspectrum.UseVisualStyleBackColor = True
        '
        'btnspectmono
        '
        Me.btnspectmono.Location = New System.Drawing.Point(449, 348)
        Me.btnspectmono.Name = "btnspectmono"
        Me.btnspectmono.Size = New System.Drawing.Size(61, 20)
        Me.btnspectmono.TabIndex = 41
        Me.btnspectmono.Text = "Mono"
        Me.btnspectmono.UseVisualStyleBackColor = True
        '
        'btnspectstereo
        '
        Me.btnspectstereo.Location = New System.Drawing.Point(384, 348)
        Me.btnspectstereo.Name = "btnspectstereo"
        Me.btnspectstereo.Size = New System.Drawing.Size(61, 20)
        Me.btnspectstereo.TabIndex = 40
        Me.btnspectstereo.Text = "Stereo"
        Me.btnspectstereo.UseVisualStyleBackColor = True
        '
        'btnspectseparator
        '
        Me.btnspectseparator.Location = New System.Drawing.Point(316, 348)
        Me.btnspectseparator.Name = "btnspectseparator"
        Me.btnspectseparator.Size = New System.Drawing.Size(62, 20)
        Me.btnspectseparator.TabIndex = 39
        Me.btnspectseparator.Text = "S color"
        Me.btnspectseparator.UseVisualStyleBackColor = True
        '
        'btnspectbar2
        '
        Me.btnspectbar2.Location = New System.Drawing.Point(267, 348)
        Me.btnspectbar2.Name = "btnspectbar2"
        Me.btnspectbar2.Size = New System.Drawing.Size(42, 20)
        Me.btnspectbar2.TabIndex = 38
        Me.btnspectbar2.Text = "B2 color"
        Me.btnspectbar2.UseVisualStyleBackColor = True
        '
        'btnspectbar1
        '
        Me.btnspectbar1.Location = New System.Drawing.Point(221, 348)
        Me.btnspectbar1.Name = "btnspectbar1"
        Me.btnspectbar1.Size = New System.Drawing.Size(40, 20)
        Me.btnspectbar1.TabIndex = 37
        Me.btnspectbar1.Text = "B1 color"
        Me.btnspectbar1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 725)
        Me.Controls.Add(Me.chkshowspectrum)
        Me.Controls.Add(Me.btnspectmono)
        Me.Controls.Add(Me.btnspectstereo)
        Me.Controls.Add(Me.btnspectseparator)
        Me.Controls.Add(Me.btnspectbar2)
        Me.Controls.Add(Me.btnspectbar1)
        Me.Controls.Add(Me.snapshot2bytearray)
        Me.Controls.Add(Me.ButtonStepForward)
        Me.Controls.Add(Me.ButtonStepBackward)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxMP4Stream)
        Me.Controls.Add(Me.AxMoviePlayer1)
        Me.Controls.Add(Me.groupBox10)
        Me.Controls.Add(Me.groupBox9)
        Me.Controls.Add(Me.pitchGroupBox)
        Me.Controls.Add(Me.snapshotToHBitButton)
        Me.Controls.Add(Me.snapshotToPicButton)
        Me.Controls.Add(Me.groupBox8)
        Me.Controls.Add(Me.snapshotButton)
        Me.Controls.Add(Me.groupBox7)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.trackBar1)
        Me.Name = "Form1"
        Me.Text = "Movie Player Pro VMR7 Demo"
        Me.groupBox10.ResumeLayout(False)
        Me.groupBox10.PerformLayout()
        CType(Me.position, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox9.ResumeLayout(False)
        Me.groupBox9.PerformLayout()
        CType(Me.playbackRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pitchGroupBox.ResumeLayout(False)
        Me.pitchGroupBox.PerformLayout()
        CType(Me.decTempoTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.incTempoTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pitchTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox8.ResumeLayout(False)
        CType(Me.soundTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox7.ResumeLayout(False)
        Me.groupBox7.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxMoviePlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label19 As System.Windows.Forms.Label
    Private WithEvents widthTextBox As System.Windows.Forms.TextBox
    Private WithEvents label20 As System.Windows.Forms.Label
    Private WithEvents positionTextBox As System.Windows.Forms.TextBox
    Private WithEvents groupBox10 As System.Windows.Forms.GroupBox
    Private WithEvents bothRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents leftRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents rightRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents label23 As System.Windows.Forms.Label
    Private WithEvents label22 As System.Windows.Forms.Label
    Private WithEvents position As System.Windows.Forms.NumericUpDown
    Private WithEvents postionButton As System.Windows.Forms.Button
    Private WithEvents loopingCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents ratioCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents heightTextBox As System.Windows.Forms.TextBox
    Private WithEvents label18 As System.Windows.Forms.Label
    Private WithEvents durationTextBox As System.Windows.Forms.TextBox
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents groupBox9 As System.Windows.Forms.GroupBox
    Private WithEvents label21 As System.Windows.Forms.Label
    Private WithEvents playbackRateButton As System.Windows.Forms.Button
    Private WithEvents playbackRate As System.Windows.Forms.NumericUpDown
    Private WithEvents resizeButton2 As System.Windows.Forms.Button
    Private WithEvents resizeButton1 As System.Windows.Forms.Button
    Private WithEvents pitchGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents restoreTempoButton As System.Windows.Forms.Button
    Private WithEvents decTempoTrackBar As System.Windows.Forms.TrackBar
    Private WithEvents label28 As System.Windows.Forms.Label
    Private WithEvents incTempoTrackBar As System.Windows.Forms.TrackBar
    Private WithEvents label27 As System.Windows.Forms.Label
    Private WithEvents restorePitchButton As System.Windows.Forms.Button
    Private WithEvents label26 As System.Windows.Forms.Label
    Private WithEvents label25 As System.Windows.Forms.Label
    Private WithEvents label24 As System.Windows.Forms.Label
    Private WithEvents pitchTrackBar As System.Windows.Forms.TrackBar
    Private WithEvents snapshotToHBitButton As System.Windows.Forms.Button
    Private WithEvents snapshotToPicButton As System.Windows.Forms.Button
    Private WithEvents snapshotButton As System.Windows.Forms.Button
    Private WithEvents groupBox8 As System.Windows.Forms.GroupBox
    Private WithEvents soundTrackBar As System.Windows.Forms.TrackBar
    Private WithEvents fileButton As System.Windows.Forms.Button
    Private WithEvents groupBox7 As System.Windows.Forms.GroupBox
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents usePitchCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents pauseButton As System.Windows.Forms.Button
    Private WithEvents stopButton As System.Windows.Forms.Button
    Private WithEvents playButton As System.Windows.Forms.Button
    Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents AxMoviePlayer1 As AxMOVIEPLAYERLib.AxMoviePlayer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbokey As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents cbomousebutton As System.Windows.Forms.ComboBox
    Friend WithEvents ListBoxMP4Stream As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonStepBackward As System.Windows.Forms.Button
    Friend WithEvents ButtonStepForward As System.Windows.Forms.Button
    Private WithEvents snapshot2bytearray As System.Windows.Forms.Button
    Friend WithEvents chkshowspectrum As System.Windows.Forms.CheckBox
    Friend WithEvents btnspectmono As System.Windows.Forms.Button
    Friend WithEvents btnspectstereo As System.Windows.Forms.Button
    Friend WithEvents btnspectseparator As System.Windows.Forms.Button
    Friend WithEvents btnspectbar2 As System.Windows.Forms.Button
    Friend WithEvents btnspectbar1 As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog

End Class
