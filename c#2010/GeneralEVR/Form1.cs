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

       

        private void ratioCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.axMoviePlayer1.AspectRatio = this.ratioCheckBox.Checked;
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
        }

        

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.axMoviePlayer1.Stop();
            this.stopButton.Enabled = false;
            this.pauseButton.Enabled = false;
            this.stopButton.Enabled = false;
            this.usePitchCheckBox.Enabled = true;
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
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "All Files (*.*)|*.*|webm (*.webm)|*.webm|Flash (*.swf)|*.swf|AVCHD, TS(*.m2ts,ts)|*.m2ts;*.ts|Vob (*.vob)|*.vob|F4V (*.f4v)|*.f4v|FLV (*.flv)|*.flv|mpg (*.mpg)|*.mpg|mpeg (*.mpeg)|*.mpeg|wmv (*.wmv)|*.wmv|avi (*.avi)|*.avi|mov (*.mov)|*.mov|mp4 (*.mp4)|*.mp4|3gp (*.3gp)|*.3gp";
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                  
                    this.axMoviePlayer1.ScrollTextPage = 1;
                    
                   // do not use microsoft mpeg2 decoder if you playback mpeg2 file
                    this.axMoviePlayer1.UseDecoderFilter = true;
                    this.axMoviePlayer1.DecoderFilterType = MOVIEPLAYERLib.MYDECODERFILTERTYPE.BLACKLIST;
                    this.axMoviePlayer1.DecoderAdd2BlackList("Microsoft DTV-DVD Video Decoder");
                    this.axMoviePlayer1.DecoderAdd2BlackList("Microsoft DTV-DVD Audio Decoder");

                    this.axMoviePlayer1.UsePitchTempo = this.usePitchCheckBox.Checked;
                    this.axMoviePlayer1.FileName = ofd.FileName;

                    this.trackBar1.Minimum = 0;
                    if (this.axMoviePlayer1.Duration > 0D)
                    {
                        this.trackBar1.Maximum =(int) this.axMoviePlayer1.Duration;
                    }
                    this.durationTextBox.Text = this.axMoviePlayer1.Duration.ToString();
                    this.widthTextBox.Text = this.axMoviePlayer1.VideoWidth.ToString();
                    this.heightTextBox.Text = this.axMoviePlayer1.VideoHeight.ToString();

                    this.soundTrackBar.Value = 10000;
                    axMoviePlayer1.SoundVolume = 0;

                    listBoxMP4Stream.Items.Clear();
                    for (int i = 0; i < axMoviePlayer1.AudioTrackGetCount(); i++)
                    {
                        listBoxMP4Stream.Items.Add(axMoviePlayer1.AudioTrackGetName((short)i));
                    }

                    this.usePitchCheckBox.Enabled = false;
                    this.playButton.Enabled = true;
                    this.pauseButton.Enabled = false;
                    this.stopButton.Enabled = false;

                    
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
            this.axMoviePlayer1.UseEVR = true;

            cbokey.Items.Add("ESC Key");
            cbokey.Items.Add("Q Key");
            cbokey.SelectedIndex = 0;

            cbomousebutton.Items.Add("Left ButtonDown");
            cbomousebutton.Items.Add("Left ButtonDblClk");
            cbomousebutton.Items.Add("Right ButtonDown");
            cbomousebutton.Items.Add("Right ButtonDblClk");
            cbomousebutton.SelectedIndex = 0;

            this.textFontColor = this.Color2Uint32(Color.FromArgb(255, 0, 0));
            this.textbgFontColor = this.Color2Uint32(Color.FromArgb(0, 0, 0));
            this.textTransparentColor = this.Color2Uint32(Color.FromArgb(0, 0, 0));

            this.textFontBold = false;
            this.textFontItalic = false;
            this.textFontUnderline = false;

       

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

       

        private void pitchTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axMoviePlayer1.ChangePitch((short)(this.pitchTrackBar.Value - 20));
        }

       
        private void decTempoTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axMoviePlayer1.ChangeTempo((short)(-this.decTempoTrackBar.Value));
        }

        private void incTempoTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axMoviePlayer1.ChangeTempo((short)this.incTempoTrackBar.Value);
        }

       

       
        private void button1_Click(object sender, EventArgs e)
        {

            if (axMoviePlayer1.ClearFullScreenType == 0)
            {
                if (cbokey.SelectedIndex == 0)
                    axMoviePlayer1.ClearFullScreenKey = 27;
             
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

        private void label1_Click(object sender, EventArgs e)
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


    }
}