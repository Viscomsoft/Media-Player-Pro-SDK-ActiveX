

Public Class Form1
    Private textFontBold As Boolean
    Private textFontItalic As Boolean
    Private textFontUnderline As Boolean
    Private textFontColor As UInt32
    Private textbgFontColor As UInt32
    Private textTransparentColor As UInt32
    Private scrollSpeed As Short
    Private alignText As Short
    Private alphaValue As Single
    Private XPos As Single
    Private YPos As Single


    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Integer
        Dim a As Byte()
        t = ColorTranslator.ToOle(clr)
        a = BitConverter.GetBytes(t)
        Return BitConverter.ToUInt32(a, 0)
    End Function

    Private Sub fontNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fontNameComboBox.SelectedIndexChanged
        Me.DrawMyText()
    End Sub

    Private Sub fontSizeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fontSizeComboBox.SelectedIndexChanged
        Me.DrawMyText()
    End Sub

    Private Sub styleComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles styleComboBox.SelectedIndexChanged
        Me.DrawMyText()
    End Sub

    Private Sub ratioCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles ratioCheckBox.CheckedChanged
        Me.AxMoviePlayer1.AspectRatio = Me.ratioCheckBox.Checked
    End Sub

    Private Sub boldCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boldCheckBox.CheckedChanged
        Me.textFontBold = Me.boldCheckBox.Checked
        Me.DrawMyText()
    End Sub

    Private Sub italicCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles italicCheckBox.CheckedChanged
        Me.textFontItalic = Me.italicCheckBox.Checked
        Me.DrawMyText()
    End Sub

    Private Sub underlineCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles underlineCheckBox.CheckedChanged
        Me.textFontUnderline = Me.underlineCheckBox.Checked
        Me.DrawMyText()
    End Sub

    Private Sub usePitchCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usePitchCheckBox.CheckedChanged
        Me.pitchGroupBox.Enabled = Me.usePitchCheckBox.Checked
    End Sub

    Private Sub playButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playButton.Click
        Me.AxMoviePlayer1.Play()
        Me.playButton.Enabled = False
        Me.stopButton.Enabled = True
        Me.pauseButton.Enabled = True
        Me.DrawMyText()
    End Sub

    Private Sub restoreTempoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restoreTempoButton.Click
        Me.incTempoTrackBar.Value = 0
        Me.decTempoTrackBar.Value = 0
        Me.AxMoviePlayer1.ChangeTempo(Me.incTempoTrackBar.Value)
        Me.AxMoviePlayer1.ChangeTempo(-Me.decTempoTrackBar.Value)

    End Sub

    Private Sub snapshotButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles snapshotButton.Click

        Dim strApp = Application.ExecutablePath

        Dim iFindIndex = strApp.IndexOf("WindowsApplication1")

        strApp = strApp.Substring(0, iFindIndex)

        Me.AxMoviePlayer1.SnapShot2ImageFile(strApp + "\test.bmp", 0)

        Dim fs As System.IO.FileStream
        ' Specify a valid picture file path on your computer.
        If System.IO.File.Exists(strApp + "\test.bmp") Then
            fs = New System.IO.FileStream(strApp + "\test.bmp",
            IO.FileMode.Open, IO.FileAccess.Read)
            pictureBox1.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        End If

    End Sub

    Private Sub snapshotToHBitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles snapshotToHBitButton.Click
        Dim hb As Integer = Me.AxMoviePlayer1.SnapShot2HBITMAP
        If hb <> 0 Then
            Dim h As New IntPtr(hb)
            Me.pictureBox1.Image = Image.FromHbitmap(h)
        End If
    End Sub

    Private Sub restorePitchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restorePitchButton.Click
        Me.pitchTrackBar.Value = 12
        Me.AxMoviePlayer1.ChangePitch(Me.pitchTrackBar.Value - 12)
    End Sub

    Private Sub fontColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fontColorButton.Click
        Using cd As New ColorDialog
            If cd.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.textFontColor = Me.Color2Uint32(cd.Color)
                Me.DrawMyText()
            End If
        End Using
    End Sub

    Private Sub stopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopButton.Click
        Me.AxMoviePlayer1.Stop()
        Me.stopButton.Enabled = False
        Me.pauseButton.Enabled = False
        Me.stopButton.Enabled = False
        Me.usePitchCheckBox.Enabled = True
        Me.chkshowspectrum.Enabled = True
    End Sub

    Private Sub DrawMyText()
        Try
            Dim strFontName As String = Me.fontNameComboBox.Text
            Dim iFontSize As Short = 16

            iFontSize = Val(fontSizeComboBox.SelectedItem)

            'if scrolling text and the font large than 30 , increase the scroll text page, it can display more text
            If ((iFontSize > 30) AndAlso (Me.styleComboBox.SelectedIndex <> 0)) Then
                Me.AxMoviePlayer1.ScrollTextPage = 3
            Else
                Me.AxMoviePlayer1.ScrollTextPage = 1
            End If

            If (Me.imageRadioButton.Checked) Then
                Me.AxMoviePlayer1.DrawImage(Me.XPos, Me.YPos, Me.styleComboBox.SelectedIndex, Application.StartupPath + "\image.bmp", textTransparentColor, alphaValue, scrollSpeed)
                Exit Sub
            End If

            If (Me.textRadioButton.Checked) Then
                Me.AxMoviePlayer1.ShowBitmapOnDrawText(String.Empty, imgTextX.Value, imgTextY.Value)
                Me.AxMoviePlayer1.DrawText(Me.XPos, Me.YPos, styleComboBox.SelectedIndex, textBox1.Text + Environment.NewLine + textBox2.Text, iFontSize, strFontName, textFontBold, textFontItalic, textFontUnderline, textFontColor, textbgFontColor, textTransparentColor, alphaValue, scrollSpeed, alignText)
                Exit Sub
            End If

            If (Me.ImageTextRadioButton.Checked) Then
                Me.AxMoviePlayer1.ShowBitmapOnDrawText(Application.StartupPath + "\image.bmp", imgTextX.Value, imgTextY.Value)
                Me.AxMoviePlayer1.DrawText(Me.XPos, Me.YPos, styleComboBox.SelectedIndex, textBox1.Text + Environment.NewLine + textBox2.Text, iFontSize, strFontName, textFontBold, textFontItalic, textFontUnderline, textFontColor, textbgFontColor, textTransparentColor, alphaValue, scrollSpeed, alignText)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub backColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backColorButton.Click
        Using cd As New ColorDialog
            If cd.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.textbgFontColor = Me.Color2Uint32(cd.Color)
                Me.DrawMyText()
            End If
        End Using
    End Sub

    Private Sub drawButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drawButton.Click
        Me.DrawMyText()
    End Sub

    Private Sub pauseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pauseButton.Click
        Me.AxMoviePlayer1.Pause()
        Me.playButton.Enabled = True
        Me.pauseButton.Enabled = False
        Me.stopButton.Enabled = False
    End Sub

    Private Sub fileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fileButton.Click
        Using ofd As New OpenFileDialog
            Dim i As Integer

            If AxMoviePlayer1.IsSupportVMR9() <> True Then
                MessageBox.Show("Your OS does not support use VMR9, try set UseVMR9=False when you load the video file")
            End If

            ofd.Filter = "All Files (*.*)|*.*|mov (*.mov)|*.mov|mp4 (*.mp4)|*.mp4|webm (*.webm)|*.webm|Flash (*.swf)|*.swf|AVCHD, TS(*.m2ts,ts)|*.m2ts;*.ts|vob (*.vob)|*.vob|f4v (*.f4v)|*.f4v|flv (*.flv)|*.flv|mpg (*.mpg)|*.mpg|mpeg (*.mpeg)|*.mpeg|wmv (*.wmv)|*.wmv|avi (*.avi)|*.avi|3gp (*.3gp)|*.3gp|wave (*.wav)|*.wav|MP3 (*.mp3)|*.mp3|OGG (*.ogg)|*.ogg|M4a (*.m4a)|*.m4a|AC3 (*.ac3)|*.ac3|FLAC (*.fla)|*.fla|MP2 (*.mp2)|*.mp2||"
            If (ofd.ShowDialog(Me) = DialogResult.OK) Then

                Me.AxMoviePlayer1.ScrollTextPage = 1
                Me.AxMoviePlayer1.UsePitchTempo = Me.usePitchCheckBox.Checked
                Me.AxMoviePlayer1.SpectrumVisibleWhenPlayAudio = chkshowspectrum.Checked
                Me.AxMoviePlayer1.FileName = ofd.FileName

                If AxMoviePlayer1.IsAudioFile Then

                    Me.btnspectbar1.Enabled = True
                    Me.btnspectbar2.Enabled = True
                    Me.btnspectseparator.Enabled = True
                    Me.btnspectmono.Enabled = True
                    Me.btnspectstereo.Enabled = True
                Else
                    Me.btnspectbar1.Enabled = False
                    Me.btnspectbar2.Enabled = False
                    Me.btnspectseparator.Enabled = False
                    Me.btnspectmono.Enabled = False
                    Me.btnspectstereo.Enabled = False
                End If

                Me.trackBar1.Minimum = 0
                If (Me.AxMoviePlayer1.Duration > 0D) Then
                    Me.trackBar1.Maximum = Me.AxMoviePlayer1.Duration
                End If
                Me.durationTextBox.Text = Me.AxMoviePlayer1.Duration.ToString()
                Me.widthTextBox.Text = Me.AxMoviePlayer1.VideoWidth.ToString()
                Me.heightTextBox.Text = Me.AxMoviePlayer1.VideoHeight.ToString()

                Me.soundTrackBar.Value = 1000
                Me.imgTextY.Value = 100

                Me.usePitchCheckBox.Enabled = False
                Me.chkshowspectrum.Enabled = False

                Me.playButton.Enabled = True
                Me.pauseButton.Enabled = False
                Me.stopButton.Enabled = False

                Me.ListBoxMP4Stream.Items.Clear()

                For i = 0 To AxMoviePlayer1.AudioTrackGetCount - 1

                    ListBoxMP4Stream.Items.Add(AxMoviePlayer1.AudioTrackGetName(i))
                Next

                Me.DrawMyText()
            End If
        End Using
    End Sub

    Private Sub snapshotToPicButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles snapshotToPicButton.Click
        If (Me.pictureBox1.Image Is Nothing) Then
            Me.pictureBox1.Image = Nothing
        End If
        Try
            Me.pictureBox1.Image = Me.AxMoviePlayer1.SnapShot2Picture()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

    Private Sub postionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles postionButton.Click
        Me.AxMoviePlayer1.SetPos(Me.position.Value)
    End Sub

    Private Sub playbackRateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playbackRateButton.Click
        Try
            Me.AxMoviePlayer1.PlaybackRate = Me.playbackRate.Value
        Catch ave As AccessViolationException
            MessageBox.Show("Play the file first!")
            Console.WriteLine(ave.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

    Private Sub resizeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resizeButton1.Click
        Me.AxMoviePlayer1.ResizeControl(100, 100)
    End Sub

    Private Sub resizeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resizeButton2.Click
        Me.AxMoviePlayer1.ResizeControl(200, 200)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbokey.Items.Add("SpaceBar Key")
        cbokey.Items.Add("Q Key")
        cbokey.SelectedIndex = 0

        cbomousebutton.Items.Add("Left ButtonDown")
        cbomousebutton.Items.Add("Left ButtonDblClk")
        cbomousebutton.Items.Add("Right ButtonDown")
        cbomousebutton.Items.Add("Right ButtonDblClk")
        cbomousebutton.SelectedIndex = 0



        Me.alignText = 0
        Me.imageRadioButton.Checked = True

        Me.fontNameComboBox.Items.AddRange(New String() {"Arial", "Impact", "Times New Roman"})
        Me.fontNameComboBox.SelectedIndex = 0

        Me.scrollSpeed = 125

        Me.alphaValue = 1
        Me.XPos = 0
        Me.YPos = 0

        Me.textFontColor = Me.Color2Uint32(Color.FromArgb(255, 0, 0))
        Me.textbgFontColor = Me.Color2Uint32(Color.FromArgb(0, 0, 0))
        Me.textTransparentColor = Me.Color2Uint32(Color.FromArgb(0, 0, 0))

        Me.textFontBold = False
        Me.textFontItalic = False
        Me.textFontUnderline = False

        Me.alpha.Value = 100
        Me.speed.Value = Me.scrollSpeed

        Me.styleComboBox.Items.AddRange(New String() {"No scroll", "Scroll left", "Scroll right"})
        Me.styleComboBox.SelectedIndex = 0

        For i As Short = 8 To 60 Step 2
            Me.fontSizeComboBox.Items.Add(i)
        Next
        Me.fontSizeComboBox.SelectedIndex = 4

        Me.pitchTrackBar.Minimum = 0
        Me.pitchTrackBar.Maximum = 24
        Me.pitchTrackBar.Value = 12

        Me.incTempoTrackBar.Maximum = 100
        Me.incTempoTrackBar.Minimum = 0

        Me.decTempoTrackBar.Maximum = 50
        Me.decTempoTrackBar.Minimum = 0

        AddHandler rightRadioButton.CheckedChanged, AddressOf rightRadioButton_CheckedChanged
        AddHandler ratioCheckBox.CheckedChanged, AddressOf ratioCheckBox_CheckedChanged
        'avoid refresh issue
        Me.AxMoviePlayer1.RegisterMsg()

    

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.AxMoviePlayer1.UnRegisterMsg()
    End Sub

    Private Sub axMoviePlayer1_OnCompleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxMoviePlayer1.OnCompleted
        Me.trackBar1.Value = Math.Min(Me.AxMoviePlayer1.Duration, Me.trackBar1.Maximum)
        If (Me.loopingCheckBox.Checked) Then
            Me.AxMoviePlayer1.Play()
            Me.DrawMyText()
        Else
            Me.playButton.Enabled = True
            Me.pauseButton.Enabled = False
            Me.stopButton.Enabled = False
            Me.usePitchCheckBox.Enabled = True
            Me.chkshowspectrum.Enabled = True
        End If
    End Sub

    Private Sub axMoviePlayer1_OnPlaying(ByVal sender As System.Object, ByVal e As AxMOVIEPLAYERLib._DMoviePlayerEvents_OnPlayingEvent) Handles AxMoviePlayer1.OnPlaying
        Me.trackBar1.Value = e.iCurrent
        Me.positionTextBox.Text = e.iCurrent.ToString()
    End Sub

    Private Sub imageRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imageRadioButton.CheckedChanged
        If (Me.imageRadioButton.Checked) Then
            Me.imgTextGroupBox.Enabled = False
            Me.DrawMyText()
        End If
    End Sub

    Private Sub alignCenterRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alignCenterRadioButton.CheckedChanged
        Me.alignText = 1
        Me.DrawMyText()
    End Sub

    Private Sub alignLeftRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alignLeftRadioButton.CheckedChanged
        Me.alignText = 0
        Me.DrawMyText()
    End Sub

    Private Sub alignRightRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alignRightRadioButton.CheckedChanged
        Me.alignText = 2
        Me.DrawMyText()
    End Sub

    Private Sub ImageTextRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageTextRadioButton.CheckedChanged
        If (Me.ImageTextRadioButton.Checked) Then
            Me.imgTextGroupBox.Enabled = True
            Me.DrawMyText()
        End If
    End Sub

    Private Sub rightRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles rightRadioButton.CheckedChanged
        If (Me.rightRadioButton.Checked) Then
            Me.AxMoviePlayer1.SetMPEG1AudioChannel(0)
        End If
    End Sub

    Private Sub leftRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leftRadioButton.CheckedChanged
        If (Me.leftRadioButton.Checked) Then
            Me.AxMoviePlayer1.SetMPEG1AudioChannel(1)
        End If
    End Sub

    Private Sub bothRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bothRadioButton.CheckedChanged
        If (Me.bothRadioButton.Checked) Then
            Me.AxMoviePlayer1.SetMPEG1AudioChannel(2)
        End If
    End Sub

    Private Sub soundTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles soundTrackBar.Scroll
        Me.AxMoviePlayer1.SoundVolume = Me.soundTrackBar.Value - 10000
    End Sub

    Private Sub alpha_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alpha.Scroll
        Me.alphaValue = Me.alpha.Value / 100
        Me.DrawMyText()
    End Sub

    Private Sub imgTextX_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgTextX.Scroll
        Me.DrawMyText()
    End Sub

    Private Sub imgTextY_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgTextY.Scroll
        Me.DrawMyText()
    End Sub

    Private Sub pitchTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pitchTrackBar.Scroll
        Me.AxMoviePlayer1.ChangePitch(Me.pitchTrackBar.Value - 12)
    End Sub

    Private Sub speed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles speed.Scroll
        Me.scrollSpeed = Me.speed.Value
        Me.DrawMyText()
    End Sub

    Private Sub decTempoTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTempoTrackBar.Scroll
        Me.AxMoviePlayer1.ChangeTempo(-Me.decTempoTrackBar.Value)
    End Sub

    Private Sub incTempoTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles incTempoTrackBar.Scroll
        Me.AxMoviePlayer1.ChangeTempo(Me.incTempoTrackBar.Value)
    End Sub

    Private Sub xPosTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xPosTrackBar.Scroll
        Me.XPos = Me.xPosTrackBar.Value / 100
        Me.DrawMyText()
    End Sub

    Private Sub yPosTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yPosTrackBar.Scroll
        Me.YPos = Me.yPosTrackBar.Value / 100
        Me.DrawMyText()
    End Sub

    Private Sub textRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textRadioButton.CheckedChanged
        If (Me.textRadioButton.Checked) Then
            Me.imgTextGroupBox.Enabled = False
            Me.DrawMyText()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (AxMoviePlayer1.ClearFullScreenType = 0) Then

            If (cbokey.SelectedIndex = 0) Then
                AxMoviePlayer1.ClearFullScreenKey = 32
            ElseIf (cbokey.SelectedIndex = 1) Then
                AxMoviePlayer1.ClearFullScreenKey = 81
            End If

        Else

            AxMoviePlayer1.ClearFullScreenMouseButton = cbomousebutton.SelectedIndex


        End If


        Me.AxMoviePlayer1.ShowFullScreen(True)


    End Sub

    Private Sub trackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackBar1.Scroll

    End Sub

    Private Sub groupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles groupBox5.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        '  AxMoviePlayer1.ClearFullScreenType = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ' AxMoviePlayer1.ClearFullScreenType = 1
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        AxMoviePlayer1.ClearFullScreenType = 0
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        AxMoviePlayer1.ClearFullScreenType = 1
    End Sub

    Private Sub ListBoxMP4Stream_Click(sender As System.Object, e As System.EventArgs) Handles ListBoxMP4Stream.Click
        Me.AxMoviePlayer1.AudioTrackSelectStream(Me.ListBoxMP4Stream.SelectedIndex)
    End Sub

    Private Sub ListBoxMP4Stream_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBoxMP4Stream.SelectedIndexChanged

    End Sub

    Private Sub btnstepforward_Click(sender As System.Object, e As System.EventArgs) Handles btnstepforward.Click
        Me.AxMoviePlayer1.StepFramePro(False)
        Me.playButton.Enabled = True
        Me.pauseButton.Enabled = False
        Me.stopButton.Enabled = False
    End Sub

    Private Sub btnstepbackward_Click(sender As System.Object, e As System.EventArgs) Handles btnstepbackward.Click
        Me.AxMoviePlayer1.StepFramePro(True)
        Me.playButton.Enabled = True
        Me.pauseButton.Enabled = False
        Me.stopButton.Enabled = False
    End Sub

    Private Sub snapshotTobytearray_Click(sender As System.Object, e As System.EventArgs) Handles snapshotTobytearray.Click
        Dim bytes() As Byte

        bytes = AxMoviePlayer1.SnapShot2ByteArray()


        If IsNothing(bytes) Then
            Exit Sub
        End If


        pictureBox1.Image = Image.FromStream(New System.IO.MemoryStream(bytes))


    End Sub

    Private Sub btnspectbar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnspectbar1.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            AxMoviePlayer1.SpectrumBarColor1 = ColorDialog1.Color

        End If
    End Sub

    Private Sub btnspectbar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnspectbar2.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            AxMoviePlayer1.SpectrumBarColor2 = ColorDialog1.Color

        End If
    End Sub

    Private Sub btnspectseparator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnspectseparator.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            AxMoviePlayer1.SpectrumSeparatorColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub btnspectstereo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnspectstereo.Click
        AxMoviePlayer1.SpectrumStereo = True
    End Sub

    Private Sub btnspectmono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnspectmono.Click
        AxMoviePlayer1.SpectrumStereo = False
    End Sub
End Class
