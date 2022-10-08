namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbomousebutton = new System.Windows.Forms.ComboBox();
            this.cbokey = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.resizeButton2 = new System.Windows.Forms.Button();
            this.resizeButton1 = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.usePitchCheckBox = new System.Windows.Forms.CheckBox();
            this.snapshotToHBitButton = new System.Windows.Forms.Button();
            this.snapshotToPicButton = new System.Windows.Forms.Button();
            this.snapshotButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.soundTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.playbackRateButton = new System.Windows.Forms.Button();
            this.playbackRate = new System.Windows.Forms.NumericUpDown();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.bothRadioButton = new System.Windows.Forms.RadioButton();
            this.leftRadioButton = new System.Windows.Forms.RadioButton();
            this.rightRadioButton = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.NumericUpDown();
            this.postionButton = new System.Windows.Forms.Button();
            this.loopingCheckBox = new System.Windows.Forms.CheckBox();
            this.ratioCheckBox = new System.Windows.Forms.CheckBox();
            this.pitchGroupBox = new System.Windows.Forms.GroupBox();
            this.restoreTempoButton = new System.Windows.Forms.Button();
            this.decTempoTrackBar = new System.Windows.Forms.TrackBar();
            this.label28 = new System.Windows.Forms.Label();
            this.incTempoTrackBar = new System.Windows.Forms.TrackBar();
            this.label27 = new System.Windows.Forms.Label();
            this.restorePitchButton = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pitchTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMP4Stream = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.axMoviePlayer1 = new AxMOVIEPLAYERLib.AxMoviePlayer();
            this.snapshot2bytearray = new System.Windows.Forms.Button();
            this.chkshowspectrum = new System.Windows.Forms.CheckBox();
            this.btnspectmono = new System.Windows.Forms.Button();
            this.btnspectstereo = new System.Windows.Forms.Button();
            this.btnspectseparator = new System.Windows.Forms.Button();
            this.btnspectbar2 = new System.Windows.Forms.Button();
            this.btnspectbar1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundTrackBar)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playbackRate)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.position)).BeginInit();
            this.pitchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decTempoTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incTempoTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMoviePlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 300);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(451, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.resizeButton2);
            this.groupBox5.Controls.Add(this.resizeButton1);
            this.groupBox5.Controls.Add(this.fileButton);
            this.groupBox5.Controls.Add(this.pauseButton);
            this.groupBox5.Controls.Add(this.stopButton);
            this.groupBox5.Controls.Add(this.playButton);
            this.groupBox5.Controls.Add(this.usePitchCheckBox);
            this.groupBox5.Location = new System.Drawing.Point(12, 351);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(511, 121);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Control";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbomousebutton);
            this.groupBox4.Controls.Add(this.cbokey);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(303, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 74);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clear Full Screen Type";
            // 
            // cbomousebutton
            // 
            this.cbomousebutton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomousebutton.FormattingEnabled = true;
            this.cbomousebutton.Location = new System.Drawing.Point(102, 48);
            this.cbomousebutton.Name = "cbomousebutton";
            this.cbomousebutton.Size = new System.Drawing.Size(99, 20);
            this.cbomousebutton.TabIndex = 3;
            // 
            // cbokey
            // 
            this.cbokey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbokey.FormattingEnabled = true;
            this.cbokey.Location = new System.Drawing.Point(102, 26);
            this.cbokey.Name = "cbokey";
            this.cbokey.Size = new System.Drawing.Size(99, 20);
            this.cbokey.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "MouseButton";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Key";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 18);
            this.button1.TabIndex = 10;
            this.button1.Text = "Full Screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resizeButton2
            // 
            this.resizeButton2.AutoSize = true;
            this.resizeButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizeButton2.Location = new System.Drawing.Point(185, 92);
            this.resizeButton2.Name = "resizeButton2";
            this.resizeButton2.Size = new System.Drawing.Size(117, 22);
            this.resizeButton2.TabIndex = 9;
            this.resizeButton2.Text = "Resize to 200x200";
            this.resizeButton2.UseVisualStyleBackColor = true;
            this.resizeButton2.Click += new System.EventHandler(this.resizeButton2_Click);
            // 
            // resizeButton1
            // 
            this.resizeButton1.AutoSize = true;
            this.resizeButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizeButton1.Location = new System.Drawing.Point(16, 91);
            this.resizeButton1.Name = "resizeButton1";
            this.resizeButton1.Size = new System.Drawing.Size(117, 22);
            this.resizeButton1.TabIndex = 8;
            this.resizeButton1.Text = "Resize to 100x100";
            this.resizeButton1.UseVisualStyleBackColor = true;
            this.resizeButton1.Click += new System.EventHandler(this.resizeButton1_Click);
            // 
            // fileButton
            // 
            this.fileButton.AutoSize = true;
            this.fileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileButton.Location = new System.Drawing.Point(6, 39);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(115, 23);
            this.fileButton.TabIndex = 4;
            this.fileButton.Text = "Select Media File";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.AutoSize = true;
            this.pauseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(252, 14);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(45, 22);
            this.pauseButton.TabIndex = 3;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = true;
            this.stopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(207, 14);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(39, 22);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playButton
            // 
            this.playButton.AutoSize = true;
            this.playButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playButton.Enabled = false;
            this.playButton.Location = new System.Drawing.Point(164, 14);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(39, 22);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // usePitchCheckBox
            // 
            this.usePitchCheckBox.AutoSize = true;
            this.usePitchCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usePitchCheckBox.Location = new System.Drawing.Point(6, 18);
            this.usePitchCheckBox.Name = "usePitchCheckBox";
            this.usePitchCheckBox.Size = new System.Drawing.Size(152, 17);
            this.usePitchCheckBox.TabIndex = 0;
            this.usePitchCheckBox.Text = "Use Pitch and Tempo ";
            this.usePitchCheckBox.UseVisualStyleBackColor = true;
            this.usePitchCheckBox.CheckedChanged += new System.EventHandler(this.usePitchCheckBox_CheckedChanged);
            // 
            // snapshotToHBitButton
            // 
            this.snapshotToHBitButton.AutoSize = true;
            this.snapshotToHBitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.snapshotToHBitButton.Location = new System.Drawing.Point(656, 301);
            this.snapshotToHBitButton.Name = "snapshotToHBitButton";
            this.snapshotToHBitButton.Size = new System.Drawing.Size(111, 22);
            this.snapshotToHBitButton.TabIndex = 7;
            this.snapshotToHBitButton.Text = "Snapshot2HBITMAP";
            this.snapshotToHBitButton.UseVisualStyleBackColor = true;
            this.snapshotToHBitButton.Click += new System.EventHandler(this.snapshotToHBitButton_Click);
            // 
            // snapshotToPicButton
            // 
            this.snapshotToPicButton.AutoSize = true;
            this.snapshotToPicButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.snapshotToPicButton.Location = new System.Drawing.Point(543, 301);
            this.snapshotToPicButton.Name = "snapshotToPicButton";
            this.snapshotToPicButton.Size = new System.Drawing.Size(111, 22);
            this.snapshotToPicButton.TabIndex = 6;
            this.snapshotToPicButton.Text = "Snapshot2Picture";
            this.snapshotToPicButton.UseVisualStyleBackColor = true;
            this.snapshotToPicButton.Click += new System.EventHandler(this.snapshotToPicButton_Click);
            // 
            // snapshotButton
            // 
            this.snapshotButton.AutoSize = true;
            this.snapshotButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.snapshotButton.Location = new System.Drawing.Point(477, 301);
            this.snapshotButton.Name = "snapshotButton";
            this.snapshotButton.Size = new System.Drawing.Size(63, 22);
            this.snapshotButton.TabIndex = 5;
            this.snapshotButton.Text = "Snapshot";
            this.snapshotButton.UseVisualStyleBackColor = true;
            this.snapshotButton.Click += new System.EventHandler(this.snapshotButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(417, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.heightTextBox);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.widthTextBox);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.positionTextBox);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.durationTextBox);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Location = new System.Drawing.Point(324, 470);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(466, 67);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Info";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(353, 42);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.ReadOnly = true;
            this.heightTextBox.Size = new System.Drawing.Size(100, 21);
            this.heightTextBox.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(266, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 6;
            this.label19.Text = "Video Height";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(353, 18);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.ReadOnly = true;
            this.widthTextBox.Size = new System.Drawing.Size(100, 21);
            this.widthTextBox.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(266, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 12);
            this.label20.TabIndex = 4;
            this.label20.Text = "Video Width";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(93, 42);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.ReadOnly = true;
            this.positionTextBox.Size = new System.Drawing.Size(100, 21);
            this.positionTextBox.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "Current Position";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(93, 18);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.ReadOnly = true;
            this.durationTextBox.Size = new System.Drawing.Size(100, 21);
            this.durationTextBox.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "Total Duration";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.soundTrackBar);
            this.groupBox8.Location = new System.Drawing.Point(12, 489);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(306, 44);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Sound";
            // 
            // soundTrackBar
            // 
            this.soundTrackBar.AutoSize = false;
            this.soundTrackBar.Location = new System.Drawing.Point(6, 17);
            this.soundTrackBar.Maximum = 10000;
            this.soundTrackBar.Name = "soundTrackBar";
            this.soundTrackBar.Size = new System.Drawing.Size(291, 18);
            this.soundTrackBar.TabIndex = 4;
            this.soundTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.soundTrackBar.Scroll += new System.EventHandler(this.soundTrackBar_Scroll);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.playbackRateButton);
            this.groupBox9.Controls.Add(this.playbackRate);
            this.groupBox9.Location = new System.Drawing.Point(12, 539);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(306, 56);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Playback rate";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(192, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 36);
            this.label21.TabIndex = 3;
            this.label21.Text = "1 = normal speed\r\n0.5 = half speed\r\n2 = twice speed";
            // 
            // playbackRateButton
            // 
            this.playbackRateButton.AutoSize = true;
            this.playbackRateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playbackRateButton.Location = new System.Drawing.Point(153, 15);
            this.playbackRateButton.Name = "playbackRateButton";
            this.playbackRateButton.Size = new System.Drawing.Size(33, 22);
            this.playbackRateButton.TabIndex = 2;
            this.playbackRateButton.Text = "Set";
            this.playbackRateButton.UseVisualStyleBackColor = true;
            this.playbackRateButton.Click += new System.EventHandler(this.playbackRateButton_Click);
            // 
            // playbackRate
            // 
            this.playbackRate.DecimalPlaces = 1;
            this.playbackRate.Location = new System.Drawing.Point(27, 18);
            this.playbackRate.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.playbackRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.playbackRate.Name = "playbackRate";
            this.playbackRate.Size = new System.Drawing.Size(120, 21);
            this.playbackRate.TabIndex = 0;
            this.playbackRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.bothRadioButton);
            this.groupBox10.Controls.Add(this.leftRadioButton);
            this.groupBox10.Controls.Add(this.rightRadioButton);
            this.groupBox10.Controls.Add(this.label23);
            this.groupBox10.Controls.Add(this.label22);
            this.groupBox10.Controls.Add(this.position);
            this.groupBox10.Controls.Add(this.postionButton);
            this.groupBox10.Controls.Add(this.loopingCheckBox);
            this.groupBox10.Controls.Add(this.ratioCheckBox);
            this.groupBox10.Location = new System.Drawing.Point(12, 601);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(306, 78);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Misc";
            // 
            // bothRadioButton
            // 
            this.bothRadioButton.AutoSize = true;
            this.bothRadioButton.Location = new System.Drawing.Point(121, 55);
            this.bothRadioButton.Name = "bothRadioButton";
            this.bothRadioButton.Size = new System.Drawing.Size(47, 16);
            this.bothRadioButton.TabIndex = 10;
            this.bothRadioButton.Text = "Both";
            this.bothRadioButton.UseVisualStyleBackColor = true;
            this.bothRadioButton.CheckedChanged += new System.EventHandler(this.bothRadioButton_CheckedChanged);
            // 
            // leftRadioButton
            // 
            this.leftRadioButton.AutoSize = true;
            this.leftRadioButton.Location = new System.Drawing.Point(69, 55);
            this.leftRadioButton.Name = "leftRadioButton";
            this.leftRadioButton.Size = new System.Drawing.Size(47, 16);
            this.leftRadioButton.TabIndex = 9;
            this.leftRadioButton.Text = "Left";
            this.leftRadioButton.UseVisualStyleBackColor = true;
            this.leftRadioButton.CheckedChanged += new System.EventHandler(this.leftRadioButton_CheckedChanged);
            // 
            // rightRadioButton
            // 
            this.rightRadioButton.AutoSize = true;
            this.rightRadioButton.Checked = true;
            this.rightRadioButton.Location = new System.Drawing.Point(9, 55);
            this.rightRadioButton.Name = "rightRadioButton";
            this.rightRadioButton.Size = new System.Drawing.Size(53, 16);
            this.rightRadioButton.TabIndex = 8;
            this.rightRadioButton.TabStop = true;
            this.rightRadioButton.Text = "Right";
            this.rightRadioButton.UseVisualStyleBackColor = true;
            this.rightRadioButton.CheckedChanged += new System.EventHandler(this.rightRadioButton_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(149, 12);
            this.label23.TabIndex = 7;
            this.label23.Text = "MPEG1 File Audio Channel";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(288, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(11, 12);
            this.label22.TabIndex = 6;
            this.label22.Text = "s";
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(239, 15);
            this.position.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(43, 21);
            this.position.TabIndex = 5;
            // 
            // postionButton
            // 
            this.postionButton.AutoSize = true;
            this.postionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.postionButton.Location = new System.Drawing.Point(169, 14);
            this.postionButton.Name = "postionButton";
            this.postionButton.Size = new System.Drawing.Size(69, 22);
            this.postionButton.TabIndex = 4;
            this.postionButton.Text = "Go to Pos";
            this.postionButton.UseVisualStyleBackColor = true;
            this.postionButton.Click += new System.EventHandler(this.postionButton_Click);
            // 
            // loopingCheckBox
            // 
            this.loopingCheckBox.AutoSize = true;
            this.loopingCheckBox.Checked = true;
            this.loopingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loopingCheckBox.Location = new System.Drawing.Point(99, 18);
            this.loopingCheckBox.Name = "loopingCheckBox";
            this.loopingCheckBox.Size = new System.Drawing.Size(66, 16);
            this.loopingCheckBox.TabIndex = 1;
            this.loopingCheckBox.Text = "Looping";
            this.loopingCheckBox.UseVisualStyleBackColor = true;
            // 
            // ratioCheckBox
            // 
            this.ratioCheckBox.AutoSize = true;
            this.ratioCheckBox.Checked = true;
            this.ratioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ratioCheckBox.Location = new System.Drawing.Point(6, 18);
            this.ratioCheckBox.Name = "ratioCheckBox";
            this.ratioCheckBox.Size = new System.Drawing.Size(96, 16);
            this.ratioCheckBox.TabIndex = 0;
            this.ratioCheckBox.Text = "Aspect Ratio";
            this.ratioCheckBox.UseVisualStyleBackColor = true;
            this.ratioCheckBox.CheckedChanged += new System.EventHandler(this.ratioCheckBox_CheckedChanged);
            // 
            // pitchGroupBox
            // 
            this.pitchGroupBox.Controls.Add(this.restoreTempoButton);
            this.pitchGroupBox.Controls.Add(this.decTempoTrackBar);
            this.pitchGroupBox.Controls.Add(this.label28);
            this.pitchGroupBox.Controls.Add(this.incTempoTrackBar);
            this.pitchGroupBox.Controls.Add(this.label27);
            this.pitchGroupBox.Controls.Add(this.restorePitchButton);
            this.pitchGroupBox.Controls.Add(this.label26);
            this.pitchGroupBox.Controls.Add(this.label25);
            this.pitchGroupBox.Controls.Add(this.label24);
            this.pitchGroupBox.Controls.Add(this.pitchTrackBar);
            this.pitchGroupBox.Enabled = false;
            this.pitchGroupBox.Location = new System.Drawing.Point(324, 543);
            this.pitchGroupBox.Name = "pitchGroupBox";
            this.pitchGroupBox.Size = new System.Drawing.Size(466, 139);
            this.pitchGroupBox.TabIndex = 11;
            this.pitchGroupBox.TabStop = false;
            this.pitchGroupBox.Text = "Pitch and Tempo";
            // 
            // restoreTempoButton
            // 
            this.restoreTempoButton.AutoSize = true;
            this.restoreTempoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.restoreTempoButton.Location = new System.Drawing.Point(362, 98);
            this.restoreTempoButton.Name = "restoreTempoButton";
            this.restoreTempoButton.Size = new System.Drawing.Size(105, 22);
            this.restoreTempoButton.TabIndex = 15;
            this.restoreTempoButton.Text = "Restore Default";
            this.restoreTempoButton.UseVisualStyleBackColor = true;
            this.restoreTempoButton.Click += new System.EventHandler(this.restoreTempoButton_Click);
            // 
            // decTempoTrackBar
            // 
            this.decTempoTrackBar.AutoSize = false;
            this.decTempoTrackBar.Location = new System.Drawing.Point(21, 117);
            this.decTempoTrackBar.Name = "decTempoTrackBar";
            this.decTempoTrackBar.Size = new System.Drawing.Size(328, 18);
            this.decTempoTrackBar.TabIndex = 14;
            this.decTempoTrackBar.Scroll += new System.EventHandler(this.decTempoTrackBar_Scroll);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(6, 102);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(103, 13);
            this.label28.TabIndex = 13;
            this.label28.Text = "Tempo Decrease";
            // 
            // incTempoTrackBar
            // 
            this.incTempoTrackBar.AutoSize = false;
            this.incTempoTrackBar.Location = new System.Drawing.Point(21, 84);
            this.incTempoTrackBar.Name = "incTempoTrackBar";
            this.incTempoTrackBar.Size = new System.Drawing.Size(328, 18);
            this.incTempoTrackBar.TabIndex = 12;
            this.incTempoTrackBar.Scroll += new System.EventHandler(this.incTempoTrackBar_Scroll);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 69);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 13);
            this.label27.TabIndex = 11;
            this.label27.Text = "Tempo Increase";
            // 
            // restorePitchButton
            // 
            this.restorePitchButton.AutoSize = true;
            this.restorePitchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.restorePitchButton.Location = new System.Drawing.Point(362, 45);
            this.restorePitchButton.Name = "restorePitchButton";
            this.restorePitchButton.Size = new System.Drawing.Size(105, 22);
            this.restorePitchButton.TabIndex = 10;
            this.restorePitchButton.Text = "Restore Default";
            this.restorePitchButton.UseVisualStyleBackColor = true;
            this.restorePitchButton.Click += new System.EventHandler(this.restorePitchButton_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(276, 33);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(107, 12);
            this.label26.TabIndex = 3;
            this.label26.Text = "-> voice to child";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 33);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(95, 12);
            this.label25.TabIndex = 2;
            this.label25.Text = "voice to man <-";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Pitch";
            // 
            // pitchTrackBar
            // 
            this.pitchTrackBar.AutoSize = false;
            this.pitchTrackBar.Location = new System.Drawing.Point(21, 48);
            this.pitchTrackBar.Name = "pitchTrackBar";
            this.pitchTrackBar.Size = new System.Drawing.Size(328, 18);
            this.pitchTrackBar.TabIndex = 0;
            this.pitchTrackBar.Scroll += new System.EventHandler(this.pitchTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "For DIVX , WMV, WEBM, MOV, MP4, VOB, MPEG2, MPEG1, M2TS";
            // 
            // listBoxMP4Stream
            // 
            this.listBoxMP4Stream.FormattingEnabled = true;
            this.listBoxMP4Stream.ItemHeight = 12;
            this.listBoxMP4Stream.Location = new System.Drawing.Point(538, 380);
            this.listBoxMP4Stream.Name = "listBoxMP4Stream";
            this.listBoxMP4Stream.Size = new System.Drawing.Size(220, 52);
            this.listBoxMP4Stream.TabIndex = 13;
            this.listBoxMP4Stream.Click += new System.EventHandler(this.listBoxMP4Stream_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Audio Tracks";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Step backward";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(665, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 27);
            this.button3.TabIndex = 16;
            this.button3.Text = "Step forward";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // axMoviePlayer1
            // 
            this.axMoviePlayer1.Enabled = true;
            this.axMoviePlayer1.Location = new System.Drawing.Point(12, 12);
            this.axMoviePlayer1.Name = "axMoviePlayer1";
            this.axMoviePlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMoviePlayer1.OcxState")));
            this.axMoviePlayer1.Size = new System.Drawing.Size(389, 270);
            this.axMoviePlayer1.TabIndex = 0;
            this.axMoviePlayer1.OnCompleted += new System.EventHandler(this.axMoviePlayer1_OnCompleted);
            this.axMoviePlayer1.OnPlaying += new AxMOVIEPLAYERLib._DMoviePlayerEvents_OnPlayingEventHandler(this.axMoviePlayer1_OnPlaying);
            // 
            // snapshot2bytearray
            // 
            this.snapshot2bytearray.AutoSize = true;
            this.snapshot2bytearray.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.snapshot2bytearray.Location = new System.Drawing.Point(770, 301);
            this.snapshot2bytearray.Name = "snapshot2bytearray";
            this.snapshot2bytearray.Size = new System.Drawing.Size(123, 22);
            this.snapshot2bytearray.TabIndex = 17;
            this.snapshot2bytearray.Text = "Snapshot2ByteArray";
            this.snapshot2bytearray.UseVisualStyleBackColor = true;
            this.snapshot2bytearray.Click += new System.EventHandler(this.snapshot2bytearray_Click);
            // 
            // chkshowspectrum
            // 
            this.chkshowspectrum.AutoSize = true;
            this.chkshowspectrum.Checked = true;
            this.chkshowspectrum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkshowspectrum.Location = new System.Drawing.Point(8, 323);
            this.chkshowspectrum.Name = "chkshowspectrum";
            this.chkshowspectrum.Size = new System.Drawing.Size(204, 16);
            this.chkshowspectrum.TabIndex = 48;
            this.chkshowspectrum.Text = "Show Spectrum(Audio File Only)";
            this.chkshowspectrum.UseVisualStyleBackColor = true;
            // 
            // btnspectmono
            // 
            this.btnspectmono.Location = new System.Drawing.Point(446, 325);
            this.btnspectmono.Name = "btnspectmono";
            this.btnspectmono.Size = new System.Drawing.Size(61, 20);
            this.btnspectmono.TabIndex = 47;
            this.btnspectmono.Text = "Mono";
            this.btnspectmono.UseVisualStyleBackColor = true;
            this.btnspectmono.Click += new System.EventHandler(this.btnspectmono_Click);
            // 
            // btnspectstereo
            // 
            this.btnspectstereo.Location = new System.Drawing.Point(381, 325);
            this.btnspectstereo.Name = "btnspectstereo";
            this.btnspectstereo.Size = new System.Drawing.Size(61, 20);
            this.btnspectstereo.TabIndex = 46;
            this.btnspectstereo.Text = "Stereo";
            this.btnspectstereo.UseVisualStyleBackColor = true;
            this.btnspectstereo.Click += new System.EventHandler(this.btnspectstereo_Click);
            // 
            // btnspectseparator
            // 
            this.btnspectseparator.Location = new System.Drawing.Point(313, 325);
            this.btnspectseparator.Name = "btnspectseparator";
            this.btnspectseparator.Size = new System.Drawing.Size(62, 20);
            this.btnspectseparator.TabIndex = 45;
            this.btnspectseparator.Text = "S color";
            this.btnspectseparator.UseVisualStyleBackColor = true;
            this.btnspectseparator.Click += new System.EventHandler(this.btnspectseparator_Click);
            // 
            // btnspectbar2
            // 
            this.btnspectbar2.Location = new System.Drawing.Point(264, 325);
            this.btnspectbar2.Name = "btnspectbar2";
            this.btnspectbar2.Size = new System.Drawing.Size(42, 20);
            this.btnspectbar2.TabIndex = 44;
            this.btnspectbar2.Text = "B2 color";
            this.btnspectbar2.UseVisualStyleBackColor = true;
            this.btnspectbar2.Click += new System.EventHandler(this.btnspectbar2_Click);
            // 
            // btnspectbar1
            // 
            this.btnspectbar1.Location = new System.Drawing.Point(218, 325);
            this.btnspectbar1.Name = "btnspectbar1";
            this.btnspectbar1.Size = new System.Drawing.Size(40, 20);
            this.btnspectbar1.TabIndex = 43;
            this.btnspectbar1.Text = "B1 color";
            this.btnspectbar1.UseVisualStyleBackColor = true;
            this.btnspectbar1.Click += new System.EventHandler(this.btnspectbar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 719);
            this.Controls.Add(this.chkshowspectrum);
            this.Controls.Add(this.btnspectmono);
            this.Controls.Add(this.btnspectstereo);
            this.Controls.Add(this.btnspectseparator);
            this.Controls.Add(this.btnspectbar2);
            this.Controls.Add(this.btnspectbar1);
            this.Controls.Add(this.snapshot2bytearray);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxMP4Stream);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pitchGroupBox);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.snapshotToHBitButton);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.snapshotToPicButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.snapshotButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.axMoviePlayer1);
            this.Name = "Form1";
            this.Text = "Movie Player Pro VMR7 Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soundTrackBar)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playbackRate)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.position)).EndInit();
            this.pitchGroupBox.ResumeLayout(false);
            this.pitchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decTempoTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incTempoTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMoviePlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMOVIEPLAYERLib.AxMoviePlayer axMoviePlayer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button resizeButton2;
        private System.Windows.Forms.Button resizeButton1;
        private System.Windows.Forms.Button snapshotToHBitButton;
        private System.Windows.Forms.Button snapshotToPicButton;
        private System.Windows.Forms.Button snapshotButton;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.CheckBox usePitchCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TrackBar soundTrackBar;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button playbackRateButton;
        private System.Windows.Forms.NumericUpDown playbackRate;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.NumericUpDown position;
        private System.Windows.Forms.Button postionButton;
        private System.Windows.Forms.CheckBox loopingCheckBox;
        private System.Windows.Forms.CheckBox ratioCheckBox;
        private System.Windows.Forms.RadioButton bothRadioButton;
        private System.Windows.Forms.RadioButton leftRadioButton;
        private System.Windows.Forms.RadioButton rightRadioButton;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox pitchGroupBox;
        private System.Windows.Forms.Button restorePitchButton;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TrackBar pitchTrackBar;
        private System.Windows.Forms.Button restoreTempoButton;
        private System.Windows.Forms.TrackBar decTempoTrackBar;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TrackBar incTempoTrackBar;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cbomousebutton;
        private System.Windows.Forms.ComboBox cbokey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMP4Stream;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button snapshot2bytearray;
        internal System.Windows.Forms.CheckBox chkshowspectrum;
        internal System.Windows.Forms.Button btnspectmono;
        internal System.Windows.Forms.Button btnspectstereo;
        internal System.Windows.Forms.Button btnspectseparator;
        internal System.Windows.Forms.Button btnspectbar2;
        internal System.Windows.Forms.Button btnspectbar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

