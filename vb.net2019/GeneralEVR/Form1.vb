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

  



    Private Sub ratioCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles ratioCheckBox.CheckedChanged
        Me.AxMoviePlayer1.AspectRatio = Me.ratioCheckBox.Checked
    End Sub

   


    Private Sub usePitchCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usePitchCheckBox.CheckedChanged
        Me.pitchGroupBox.Enabled = Me.usePitchCheckBox.Checked
    End Sub

    Private Sub playButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playButton.Click
        Me.axMoviePlayer1.Play()
        Me.playButton.Enabled = False
        Me.stopButton.Enabled = True
        Me.pauseButton.Enabled = True

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

   

    Private Sub stopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopButton.Click
        Me.axMoviePlayer1.Stop()
        Me.stopButton.Enabled = False
        Me.pauseButton.Enabled = False
        Me.stopButton.Enabled = False
        Me.usePitchCheckBox.Enabled = True
    End Sub

    


    Private Sub drawButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub pauseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pauseButton.Click
        Me.axMoviePlayer1.Pause()
        Me.playButton.Enabled = True
        Me.pauseButton.Enabled = False
        Me.stopButton.Enabled = False
    End Sub

    

    Private Sub snapshotToPicButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles snapshotToPicButton.Click
        If (Me.pictureBox1.Image Is Nothing) Then
            Me.pictureBox1.Image = Nothing
        End If
        Try
            Me.pictureBox1.Image = Me.axMoviePlayer1.SnapShot2Picture()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

    Private Sub postionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles postionButton.Click
        Me.axMoviePlayer1.SetPos(Me.position.Value)
    End Sub

    Private Sub playbackRateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playbackRateButton.Click
        Try
            Me.axMoviePlayer1.PlaybackRate = Me.playbackRate.Value
        Catch ave As AccessViolationException
            MessageBox.Show("Play the file first!")
            Console.WriteLine(ave.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

    Private Sub resizeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resizeButton1.Click
        Me.axMoviePlayer1.ResizeControl(100, 100)
    End Sub

    Private Sub resizeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resizeButton2.Click
        Me.axMoviePlayer1.ResizeControl(200, 200)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.AxMoviePlayer1.UseEVR = True

        cbokey.Items.Add("ESC Key")
        cbokey.Items.Add("Q Key")
        cbokey.SelectedIndex = 0

        cbomousebutton.Items.Add("Left ButtonDown")
        cbomousebutton.Items.Add("Left ButtonDblClk")
        cbomousebutton.Items.Add("Right ButtonDown")
        cbomousebutton.Items.Add("Right ButtonDblClk")
        cbomousebutton.SelectedIndex = 0



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
        Me.axMoviePlayer1.UnRegisterMsg()
    End Sub

    Private Sub axMoviePlayer1_OnCompleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxMoviePlayer1.OnCompleted
        Me.trackBar1.Value = Math.Min(Me.axMoviePlayer1.Duration, Me.trackBar1.Maximum)
        If (Me.loopingCheckBox.Checked) Then
            Me.axMoviePlayer1.Play()

        Else
            Me.playButton.Enabled = True
            Me.pauseButton.Enabled = False
            Me.stopButton.Enabled = False
            Me.usePitchCheckBox.Enabled = True
        End If
    End Sub

    Private Sub axMoviePlayer1_OnPlaying(ByVal sender As System.Object, ByVal e As AxMOVIEPLAYERLib._DMoviePlayerEvents_OnPlayingEvent) Handles AxMoviePlayer1.OnPlaying
        Me.trackBar1.Value = e.iCurrent
        Me.positionTextBox.Text = e.iCurrent.ToString()
    End Sub

   

  


    Private Sub rightRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles rightRadioButton.CheckedChanged
        If (Me.rightRadioButton.Checked) Then
            Me.AxMoviePlayer1.SetMPEG1AudioChannel(0)
        End If
    End Sub

    Private Sub leftRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leftRadioButton.CheckedChanged
        If (Me.leftRadioButton.Checked) Then
            Me.axMoviePlayer1.SetMPEG1AudioChannel(1)
        End If
    End Sub

    Private Sub bothRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bothRadioButton.CheckedChanged
        If (Me.bothRadioButton.Checked) Then
            Me.axMoviePlayer1.SetMPEG1AudioChannel(2)
        End If
    End Sub

    Private Sub soundTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles soundTrackBar.Scroll
        Me.axMoviePlayer1.SoundVolume = Me.soundTrackBar.Value - 10000
    End Sub

   

 

    Private Sub pitchTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pitchTrackBar.Scroll
        Me.AxMoviePlayer1.ChangePitch(Me.pitchTrackBar.Value - 12)
    End Sub

   

    Private Sub decTempoTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTempoTrackBar.Scroll
        Me.axMoviePlayer1.ChangeTempo(-Me.decTempoTrackBar.Value)
    End Sub

    Private Sub incTempoTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles incTempoTrackBar.Scroll
        Me.axMoviePlayer1.ChangeTempo(Me.incTempoTrackBar.Value)
    End Sub

   



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (AxMoviePlayer1.ClearFullScreenType = 0) Then

            If (cbokey.SelectedIndex = 0) Then
                AxMoviePlayer1.ClearFullScreenKey = 27
        
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

    Private Sub fileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fileButton.Click
        Using ofd As New OpenFileDialog
            Dim i As Integer
            ofd.Filter = "All Files (*.*)|*.*|webm (*.webm)|*.webm|Flash (*.swf)|*.swf|AVCHD, TS(*.m2ts,ts)|*.m2ts;*.ts;*.mts;*.m2t|vob (*.vob)|*.vob|f4v (*.f4v)|*.f4v|flv (*.flv)|*.flv|mpg (*.mpg)|*.mpg|mpeg (*.mpeg)|*.mpeg|wmv (*.wmv)|*.wmv|avi (*.avi)|*.avi|mov (*.mov)|*.mov|mp4 (*.mp4)|*.mp4|3gp (*.3gp)|*.3gp"
            If (ofd.ShowDialog(Me) = DialogResult.OK) Then

                Me.AxMoviePlayer1.ScrollTextPage = 1
                Me.AxMoviePlayer1.UsePitchTempo = Me.usePitchCheckBox.Checked

                ' do not use microsoft mpeg2 decoder if you playback mpeg2 file
                Me.AxMoviePlayer1.UseDecoderFilter = True
                Me.AxMoviePlayer1.DecoderFilterType = MOVIEPLAYERLib.MYDECODERFILTERTYPE.BLACKLIST
                Me.AxMoviePlayer1.DecoderAdd2BlackList("Microsoft DTV-DVD Video Decoder")
                Me.AxMoviePlayer1.DecoderAdd2BlackList("Microsoft DTV-DVD Audio Decoder")

                Me.AxMoviePlayer1.FileName = ofd.FileName

                Me.trackBar1.Minimum = 0
                If (Me.AxMoviePlayer1.Duration > 0D) Then
                    Me.trackBar1.Maximum = Me.AxMoviePlayer1.Duration
                End If
                Me.durationTextBox.Text = Me.AxMoviePlayer1.Duration.ToString()
                Me.widthTextBox.Text = Me.AxMoviePlayer1.VideoWidth.ToString()
                Me.heightTextBox.Text = Me.AxMoviePlayer1.VideoHeight.ToString()

                Me.soundTrackBar.Value = soundTrackBar.Maximum
                AxMoviePlayer1.SoundVolume = 0

                Me.ListBoxMP4Stream.Items.Clear()

                For i = 0 To AxMoviePlayer1.AudioTrackGetCount - 1

                    ListBoxMP4Stream.Items.Add(AxMoviePlayer1.AudioTrackGetName(i))
                Next

                Me.usePitchCheckBox.Enabled = False
                Me.playButton.Enabled = True
                Me.pauseButton.Enabled = False
                Me.stopButton.Enabled = False


            End If
        End Using
    End Sub

    Private Sub ListBoxMP4Stream_Click(sender As System.Object, e As System.EventArgs) Handles ListBoxMP4Stream.Click
        Me.AxMoviePlayer1.AudioTrackSelectStream(Me.ListBoxMP4Stream.SelectedIndex)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.AxMoviePlayer1.StepFramePro(False)
        Me.playButton.Enabled = True
        Me.pauseButton.Enabled = False
        Me.stopButton.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.AxMoviePlayer1.StepFramePro(True)
        Me.playButton.Enabled = True
        Me.pauseButton.Enabled = False
        Me.stopButton.Enabled = False
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
