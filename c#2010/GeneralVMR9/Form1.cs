using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private bool textFontBold;
        private bool textFontItalic;
        private bool textFontUnderline;
        private uint textFontColor;
        private uint textbgFontColor;
        private uint textTransparentColor;
        short scrollSpeed;
        short alignText;
        float alphaValue;
        float XPos;
        float YPos;

        public Form1()
        {
            InitializeComponent();
        }

        public uint Color2Uint32(Color clr)
        {

            int t;
            byte[] a;

            t = ColorTranslator.ToOle(clr);

            a = BitConverter.GetBytes(t);

            return BitConverter.ToUInt32(a, 0);

        }

        private void fontNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DrawMyText();
        }

        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DrawMyText();
        }

        private void styleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DrawMyText();
        }

        private void ratioCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.axMoviePlayer1.AspectRatio = this.ratioCheckBox.Checked;
        }

        private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.textFontBold = this.boldCheckBox.Checked;
            this.DrawMyText();
        }

        private void italicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.textFontItalic = this.italicCheckBox.Checked;
            this.DrawMyText();
        }

        private void underlineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.textFontUnderline = this.underlineCheckBox.Checked;
            this.DrawMyText();
        }

        private void usePitchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.pitchGroupBox.Enabled = this.usePitchCheckBox.Checked;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.axMoviePlayer1.Play();
            this.playButton.Enabled = false;
            this.stopButton.Enabled = true;
            this.pauseButton.Enabled = true;
            this.DrawMyText();
        }

        private void restoreTempoButton_Click(object sender, EventArgs e)
        {
            this.incTempoTrackBar.Value = 0;
            this.decTempoTrackBar.Value = 0;
            this.axMoviePlayer1.ChangeTempo((short)this.incTempoTrackBar.Value);
            this.axMoviePlayer1.ChangeTempo((short)(-this.decTempoTrackBar.Value));
        }

        private void snapshotButton_Click(object sender, EventArgs e)
        {
            string strApp = Application.ExecutablePath;
            int iFindIndex = strApp.IndexOf("WindowsApplication1");
            strApp = strApp.Substring(0, iFindIndex);

            this.axMoviePlayer1.SnapShot2ImageFile(strApp + "\\test.bmp", 0);

            System.IO.FileStream fs;

            if (System.IO.File.Exists(strApp + "\\test.bmp"))
            {

                fs = new System.IO.FileStream(strApp + "\\test.bmp", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                this.pictureBox1.Image = System.Drawing.Image.FromStream(fs);
                fs.Close();

            }
        }

        private void snapshotToHBitButton_Click(object sender, EventArgs e)
        {
            int hb = this.axMoviePlayer1.SnapShot2HBITMAP();
            if (hb != 0)
            {
                IntPtr h = new IntPtr(hb);
                this.pictureBox1.Image = Image.FromHbitmap(h);
            }
        }

        private void restorePitchButton_Click(object sender, EventArgs e)
        {
            this.pitchTrackBar.Value = 12;
            this.axMoviePlayer1.ChangePitch((short)(this.pitchTrackBar.Value - 12));
        }

        private void fontColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    this.textFontColor = this.Color2Uint32(cd.Color);
                    this.DrawMyText();
                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.axMoviePlayer1.Stop();
            this.stopButton.Enabled = false;
            this.pauseButton.Enabled = false;
            this.stopButton.Enabled = false;
            this.usePitchCheckBox.Enabled = true;
            this.chkshowspectrum.Enabled = true;

        }

        private void DrawMyText()
        {
            string strFontName = this.fontNameComboBox.Text;
            short iFontSize = 16;
            if (this.fontSizeComboBox.SelectedItem != null)
            {
               iFontSize= (short)this.fontSizeComboBox.SelectedItem;
            }
            //if scrolling text and the font large than 30 , increase the scroll text page, it can display more text
            if ((iFontSize > 30) && (this.styleComboBox.SelectedIndex != 0))
            {
                this.axMoviePlayer1.ScrollTextPage = 3;
            }
            else
            {
                this.axMoviePlayer1.ScrollTextPage = 1;
            }

            if (this.imageRadioButton.Checked)
            {
                this.axMoviePlayer1.DrawImage(this.XPos, this.YPos, (short)this.styleComboBox.SelectedIndex, Application.StartupPath + "\\image.bmp", textTransparentColor, alphaValue, scrollSpeed);
                return;
            }

            if (this.textRadioButton.Checked)
            {
                this.axMoviePlayer1.ShowBitmapOnDrawText(string.Empty, imgTextX.Value, imgTextY.Value);
                this.axMoviePlayer1.DrawText(this.XPos, this.YPos, (short)styleComboBox.SelectedIndex, textBox1.Text + Environment.NewLine + textBox2.Text, iFontSize, strFontName, textFontBold, textFontItalic, textFontUnderline, textFontColor, textbgFontColor, textTransparentColor, alphaValue, scrollSpeed, alignText);
                return;
            }

            if (this.ImageTextRadioButton.Checked)
            {
                this.axMoviePlayer1.ShowBitmapOnDrawText(Application.StartupPath + "\\image.bmp", imgTextX.Value, imgTextY.Value);
                this.axMoviePlayer1.DrawText(this.XPos, this.YPos, (short)styleComboBox.SelectedIndex, textBox1.Text + Environment.NewLine + textBox2.Text, iFontSize, strFontName, textFontBold, textFontItalic, textFontUnderline, textFontColor, textbgFontColor, textTransparentColor, alphaValue, scrollSpeed, alignText);
            }
        }

        private void backColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    this.textbgFontColor = this.Color2Uint32(cd.Color);
                    this.DrawMyText();
                }
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            this.DrawMyText();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            this.axMoviePlayer1.Pause();
            this.playButton.Enabled = true;
            this.pauseButton.Enabled = false;
            this.stopButton.Enabled = false;
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            if (!axMoviePlayer1.IsSupportVMR9())
                MessageBox.Show("Your OS does not support use VMR9, try set UseVMR9=False when you load the video file");
           

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "All Files (*.*)|*.*|mov (*.mov)|*.mov|mp4 (*.mp4)|*.mp4|webm (*.webm)|*.webm|Flash (*.swf)|*.swf|AVCHD, TS(*.m2ts,ts)|*.m2ts;*.ts|vob (*.vob)|*.vob|f4v (*.f4v)|*.f4v|flv (*.flv)|*.flv|mpg (*.mpg)|*.mpg|mpeg (*.mpeg)|*.mpeg|wmv (*.wmv)|*.wmv|avi (*.avi)|*.avi|3gp (*.3gp)|*.3gp|wave (*.wav)|*.wav|MP3 (*.mp3)|*.mp3|OGG (*.ogg)|*.ogg|M4a (*.m4a)|*.m4a|AC3 (*.ac3)|*.ac3|FLAC (*.fla)|*.fla|MP2 (*.mp2)|*.mp2||";
         
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    this.axMoviePlayer1.ScrollTextPage = 1;
                    this.axMoviePlayer1.UsePitchTempo = this.usePitchCheckBox.Checked;
                    this.axMoviePlayer1.SpectrumVisibleWhenPlayAudio = chkshowspectrum.Checked;

                    this.axMoviePlayer1.FileName = ofd.FileName;
                
                  
                    if(axMoviePlayer1.IsAudioFile)
                    {
                        btnspectbar1.Enabled = true;
                        btnspectbar2.Enabled = true;
                        btnspectseparator.Enabled = true;
                        btnspectmono.Enabled = true;
                        btnspectstereo.Enabled = true;
                    }
                    else
                    {
                        btnspectbar1.Enabled = false;
                        btnspectbar2.Enabled = false;
                        btnspectseparator.Enabled = false;
                        btnspectmono.Enabled =false;
                        btnspectstereo.Enabled =false;
                    }
                
                    this.trackBar1.Minimum = 0;
                    if (this.axMoviePlayer1.Duration > 0D)
                    {
                        this.trackBar1.Maximum =(int) this.axMoviePlayer1.Duration;
                    }
                    this.durationTextBox.Text = this.axMoviePlayer1.Duration.ToString();
                    this.widthTextBox.Text = this.axMoviePlayer1.VideoWidth.ToString();
                    this.heightTextBox.Text = this.axMoviePlayer1.VideoHeight.ToString();

                    this.soundTrackBar.Value = 1000;
                    this.imgTextY.Value = 100;

                    this.usePitchCheckBox.Enabled = false;
                    this.chkshowspectrum.Enabled = false;
                    this.playButton.Enabled = true;
                    this.pauseButton.Enabled = false;
                    this.stopButton.Enabled = false;

                    listBoxMP4Stream.Items.Clear();
                    for(int i = 0;i <axMoviePlayer1.AudioTrackGetCount() ;i++)
                    {
                    listBoxMP4Stream.Items.Add(axMoviePlayer1.AudioTrackGetName((short)i));
                    }


                    this.DrawMyText();
                }
            }
        }

        private void snapshotToPicButton_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image != null)
            {
                this.pictureBox1.Image = null;
            }
            try
            {
                this.pictureBox1.Image = this.axMoviePlayer1.SnapShot2Picture();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void postionButton_Click(object sender, EventArgs e)
        {
            this.axMoviePlayer1.SetPos((double)this.position.Value);
        }

        private void playbackRateButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.axMoviePlayer1.PlaybackRate = (double)this.playbackRate.Value;
            }
            catch (AccessViolationException ave)
            {
                MessageBox.Show("Play the file first!");
                Console.WriteLine(ave.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void resizeButton1_Click(object sender, EventArgs e)
        {
            this.axMoviePlayer1.ResizeControl(100, 100);
        }

        private void resizeButton2_Click(object sender, EventArgs e)
        {
            this.axMoviePlayer1.ResizeControl(200, 200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbokey.Items.Add("SpaceBar Key");
            cbokey.Items.Add("Q Key");
            cbokey.SelectedIndex = 0;

            cbomousebutton.Items.Add("Left ButtonDown");
            cbomousebutton.Items.Add("Left ButtonDblClk");
            cbomousebutton.Items.Add("Right ButtonDown");
            cbomousebutton.Items.Add("Right ButtonDblClk");
            cbomousebutton.SelectedIndex = 0;






            this.alignText = 0;
            this.imageRadioButton.Checked = true;

            this.fontNameComboBox.Items.AddRange(new string[] { "Arial", "Impact", "Times New Roman" });
            this.fontNameComboBox.SelectedIndex = 0;

            this.scrollSpeed = 125;

            this.alphaValue = 1F;
            this.XPos = 0;
            this.YPos = 0;

            this.textFontColor = this.Color2Uint32(Color.FromArgb(255, 0, 0));
            this.textbgFontColor = this.Color2Uint32(Color.FromArgb(0, 0, 0));
            this.textTransparentColor = this.Color2Uint32(Color.FromArgb(0, 0, 0));

            this.textFontBold = false;
            this.textFontItalic = false;
            this.textFontUnderline = false;

            this.alpha.Value = 100;
            this.speed.Value = (int)this.scrollSpeed;

            this.styleComboBox.Items.AddRange(new string[] { "No scroll", "Scroll left", "Scroll right" });
            this.styleComboBox.SelectedIndex = 0;

            for (short i = 8; i <= 60; i += 2)
            {
                this.fontSizeComboBox.Items.Add(i);
            }
            this.fontSizeComboBox.SelectedIndex = 4;

            this.pitchTrackBar.Minimum = 0;
            this.pitchTrackBar.Maximum = 24;
            this.pitchTrackBar.Value =12;

            this.incTempoTrackBar.Maximum = 100;
            this.incTempoTrackBar.Minimum = 0;

            this.decTempoTrackBar.Maximum = 50;
            this.decTempoTrackBar.Minimum = 0;

            //avoid refresh issue
            this.axMoviePlayer1.RegisterMsg();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.axMoviePlayer1.UnRegisterMsg();
        }

        private void axMoviePlayer1_OnCompleted(object sender, EventArgs e)
        {
            this.trackBar1.Value=Math.Min((int)this.axMoviePlayer1.Duration,this.trackBar1.Maximum);
            if(this.loopingCheckBox.Checked)
            {
                this.axMoviePlayer1.Play();
                this.DrawMyText();
            }
            else
            {
                this.playButton.Enabled=true;
                this.pauseButton.Enabled=false;
                this.stopButton.Enabled=false;
                this.usePitchCheckBox.Enabled=true;
            }
        }

        private void axMoviePlayer1_OnPlaying(object sender, AxMOVIEPLAYERLib._DMoviePlayerEvents_OnPlayingEvent e)
        {
            this.trackBar1.Value = (int)e.iCurrent;
            this.positionTextBox.Text = e.iCurrent.ToString();
        }

        private void imageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.imageRadioButton.Checked)
            {
                this.imgTextGroupBox.Enabled = false;
                this.DrawMyText();
            }
        }

        private void alignCenterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.alignText = 1;
            this.DrawMyText();
        }

        private void alignLeftRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.alignText = 0;
            this.DrawMyText();
        }

        private void alignRightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.alignText = 2;
            this.DrawMyText();
        }

        private void ImageTextRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ImageTextRadioButton.Checked)
            {
                this.imgTextGroupBox.Enabled = true;
                this.DrawMyText();
            }
        }

        private void rightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rightRadioButton.Checked)
            {
                this.axMoviePlayer1.SetMPEG1AudioChannel(0);
            }
        }

        private void leftRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.leftRadioButton.Checked)
            {
                this.axMoviePlayer1.SetMPEG1AudioChannel(1);
            }
        }

        private void bothRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.bothRadioButton.Checked)
            {
                this.axMoviePlayer1.SetMPEG1AudioChannel(2);
            }
        }

        private void soundTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axMoviePlayer1.SoundVolume = this.soundTrackBar.Value - 10000;
        }

        private void alpha_Scroll(object sender, EventArgs e)
        {
            this.alphaValue = this.alpha.Value / 100F;
            this.DrawMyText();
        }

        private void imgTextX_Scroll(object sender, EventArgs e)
        {
            this.DrawMyText();
        }

        private void imgTextY_Scroll(object sender, EventArgs e)
        {
            this.DrawMyText();
        }

        private void pitchTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axMoviePlayer1.ChangePitch((short)(this.pitchTrackBar.Value - 12));
        }

        private void speed_Scroll(object sender, EventArgs e)
        {
            this.scrollSpeed = (short)this.speed.Value;
            this.DrawMyText();
        }

        private void decTempoTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axMoviePlayer1.ChangeTempo((short)(-this.decTempoTrackBar.Value));
        }

        private void incTempoTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axMoviePlayer1.ChangeTempo((short)this.incTempoTrackBar.Value);
        }

        private void xPos_Scroll(object sender, EventArgs e)
        {
            this.XPos=this.xPos.Value/100F;
            this.DrawMyText();
        }

        private void yPos_Scroll(object sender, EventArgs e)
        {
            this.YPos = this.yPos.Value / 100F;
            this.DrawMyText();
        }

        private void textRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.textRadioButton.Checked)
            {
                this.imgTextGroupBox.Enabled = false;
                this.DrawMyText();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (axMoviePlayer1.ClearFullScreenType == 0)
            {
                if (cbokey.SelectedIndex == 0)
                    axMoviePlayer1.ClearFullScreenKey = 32;
                else if (cbokey.SelectedIndex == 1)
                    axMoviePlayer1.ClearFullScreenKey = 81;
            }
            else
            {
                axMoviePlayer1.ClearFullScreenMouseButton =(short) cbomousebutton.SelectedIndex;


            }
            axMoviePlayer1.ShowFullScreen(true);
        }

      
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            axMoviePlayer1.ClearFullScreenType = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            axMoviePlayer1.ClearFullScreenType = 1;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxMP4Stream_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.AudioTrackSelectStream((short)listBoxMP4Stream.SelectedIndex);
        }

        private void listBoxMP4Stream_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.StepFramePro(false);
            this.playButton.Enabled = true;
            this.pauseButton.Enabled = false;
            this.stopButton.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.StepFramePro(true);
            this.playButton.Enabled = true;
            this.pauseButton.Enabled = false;
            this.stopButton.Enabled = false;
        }

        private void snapshot2ByteArray_Click(object sender, EventArgs e)
        {
            byte[] bytes = (byte[])axMoviePlayer1.SnapShot2ByteArray();

            if (bytes != null)
                pictureBox1.Image = Image.FromStream(new System.IO.MemoryStream(bytes));
        }

        private void btnspectbar1_Click(object sender, EventArgs e)
        {
             if(colorDialog1.ShowDialog() == DialogResult.OK)
                axMoviePlayer1.SpectrumBarColor1 = colorDialog1.Color;

       
        }

        private void btnspectbar2_Click(object sender, EventArgs e)
        {
              if(colorDialog1.ShowDialog() == DialogResult.OK )
                    axMoviePlayer1.SpectrumBarColor2 = colorDialog1.Color;

       
        }

        private void btnspectseparator_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK )
                 axMoviePlayer1.SpectrumSeparatorColor = colorDialog1.Color;

        
        }

        private void btnspectstereo_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.SpectrumStereo = true;

        }

        private void btnspectmono_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.SpectrumStereo = false;
        }


    }
}