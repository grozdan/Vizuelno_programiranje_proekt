using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using CSCore.Streams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace VPProject
{
    public partial class Form1 : Form
    {
        private DrawingShapes currentShape;
        private bool curvesVisualization;
        private List<TrackBar> trackbars;
        private DrawingShapes equalizerCurve;
        private bool shuffle;
        private int currentSongIndex;
        private bool firstSongRemoved;
        private bool initialState;
        private bool isStreamFinished;
        private string fileName = "mp3Player.app";
        private List<ButtonShape> buttons;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.DoubleBuffered = true;

            currentShape = new Curves(picGraph);
            curvesVisualization = true;

            trackbars = new List<TrackBar>();
            trackbars.Add(trackBar9);
            trackbars.Add(trackBar1);
            trackbars.Add(trackBar2);
            trackbars.Add(trackBar3);
            trackbars.Add(trackBar4);
            trackbars.Add(trackBar5);
            trackbars.Add(trackBar6);
            trackbars.Add(trackBar7);
            trackbars.Add(trackBar8);
            trackbars.Add(trackBar10);
            equalizerCurve = new EqualizerCurve(pictureBoxCurve, trackbars);

            shuffle = false;
            currentSongIndex = -1;
            firstSongRemoved = false;
            initialState = true;
            isStreamFinished = true;
            txtTime.TextAlign = HorizontalAlignment.Center;
            txtTime.Text = "00 : 00";

            buttons = new List<ButtonShape>();
            buttons.Add(btnAddSong);
            buttons.Add(btnRemoveAll);
            buttons.Add(btnRemoveSong);
            buttons.Add(btnForward);
            buttons.Add(btnPlay);
            buttons.Add(btnPause);
            buttons.Add(btnStop);
            buttons.Add(btnRewind);
            buttons.Add(btnShuffle);

            deserialize();
        }

        public void addSong()
        {

            var ofn = new OpenFileDialog();
            ofn.Multiselect = true;
            ofn.Filter = CodecFactory.SupportedFilesFilterEN;
            if (ofn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String[] names = ofn.FileNames;
                foreach (String name in names)
                {
                    var source = CodecFactory.Instance.GetCodec(name);
                    Song song = new Song(name, source.GetLength().Minutes, source.GetLength().Seconds);
                    lbSongs.Items.Add(song);
                }
            }

        }

        public void removeSong()
        {
            if (lbSongs.SelectedIndex == -1)
            {
                return;
            }
            if (lbSongs.SelectedIndex == currentSongIndex)
            {
                currentSongIndex--;
                if (currentSongIndex < 0)
                {
                    firstSongRemoved = true;
                }
            }
            lbSongs.Items.RemoveAt(lbSongs.SelectedIndex);
        }

        public void playSong()
        {
            if (lbSongs.SelectedIndex == -1)
            {
                return;
            }
            currentSongIndex = lbSongs.SelectedIndex;
            firstSongRemoved = false;
            initialState = false;

            PlaySong(lbSongs.SelectedItem as Song);
        }

        public void pauseSong()
        {
            if (initialState)
            {
                return;
            }
            if (_soundOut != null && !isStreamFinished)
            {
                _soundOut.Pause();
                timer.Stop();
                timerSeconds.Stop();
            }
        }

        public void resumeSong()
        {
            if (initialState)
            {
                return;
            }
            if (_soundOut != null && !isStreamFinished)
            {
                _soundOut.Resume();
                timer.Start();
                timerSeconds.Start();
            }
        }

        private Random random = new Random();
        public void forwardSong()
        {
            if (lbSongs.Items.Count == 0)
            {
                return;
            }
            if (currentSongIndex == -1 && !firstSongRemoved)
            {
                return;
            }
            firstSongRemoved = false;
            if (shuffle)
            {
                currentSongIndex = lbSongs.SelectedIndex = random.Next(0, lbSongs.Items.Count);
            }
            else
            {
                currentSongIndex = lbSongs.SelectedIndex = (currentSongIndex + 1) % lbSongs.Items.Count;
            }
            PlaySong(lbSongs.SelectedItem as Song);
        }

        public void rewindSong()
        {
            if (currentSongIndex == -1 && !firstSongRemoved)
            {
                return;
            }
            if (lbSongs.Items.Count == 0)
            {
                return;
            }
            firstSongRemoved = false;

            int idx = currentSongIndex - 1;
            if (idx < 0)
            {
                idx = lbSongs.Items.Count - 1;
            }
            currentSongIndex = lbSongs.SelectedIndex = idx;
            PlaySong(lbSongs.SelectedItem as Song);
        }

        public void stopSongs()
        {
            if (currentSongIndex == -1 && !firstSongRemoved)
            {
                return;
            }
            streamFinished(null, null);
            Stop();
            if (lbSongs.Items.Count == 0)
            {
                return;
            }
            currentSongIndex = lbSongs.SelectedIndex = 0;
            firstSongRemoved = false;
            shuffle = false;
        }

        public void shuffleSongs()
        {
            if (lbSongs.Items.Count == 0)
            {
                return;
            }

            shuffle = !shuffle;

            if (shuffle)
            {
                if (initialState)
                {
                    initialState = false;
                    firstSongRemoved = false;
                    currentSongIndex = lbSongs.SelectedIndex = random.Next(0, lbSongs.Items.Count);
                    PlaySong(lbSongs.SelectedItem as Song);
                }
                else
                {
                    forwardSong();
                }
            }
        }

        private ISoundOut _soundOut;
        private Equalizer _eq;

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            if (_eq != null)
            {
                const double MaxDB = 20;

                var trackbar = sender as TrackBar;
                double perc = ((double)trackbar.Value / (double)trackbar.Maximum);
                float value = (float)(perc * MaxDB);

                int filterIndex = Int32.Parse((string)trackbar.Tag);
                EqFilterEntry filter = _eq.SampleFilters[filterIndex];
                filter.SetGain(value);
            }

            equalizerCurve.Draw();
        }

        private void alertTrackBars()
        {
            trackBar_ValueChanged(trackBar1, null);
            trackBar_ValueChanged(trackBar2, null);
            trackBar_ValueChanged(trackBar3, null);
            trackBar_ValueChanged(trackBar4, null);
            trackBar_ValueChanged(trackBar5, null);
            trackBar_ValueChanged(trackBar6, null);
            trackBar_ValueChanged(trackBar7, null);
            trackBar_ValueChanged(trackBar8, null);
            trackBar_ValueChanged(trackBar9, null);
            trackBar_ValueChanged(trackBar10, null);
        }

        private void PlaySong(Song song)
        {
            Stop();

            if (WasapiOut.IsSupportedOnCurrentPlatform)
            {
                _soundOut = new WasapiOut();
            }
            else
            {
                _soundOut = new DirectSoundOut();
            }

            var source = CodecFactory.Instance.GetCodec(song.FileName);

            source = new LoopStream(source) { EnableLoop = false };
            (source as LoopStream).StreamFinished += (s, args) => streamFinished(null, null);
            isStreamFinished = false;

            _eq = Equalizer.Create10BandEqualizer(source);
            alertTrackBars();

            lblSongName.Text = song.ToString();
            lblSongName.Location = new Point(5, 149);
            progressBar.Maximum = song.getDurationInSeconds();
            progressBar.Value = 0;

            _soundOut.Initialize(_eq.ToWaveSource(16));
            _soundOut.Volume = (float)colorSliderVolume.Value / 100;

            _soundOut.Play();

            timer.Start();
            timerSeconds.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentShape.Draw();

            Point point = lblSongName.Location;
            point.X += 3;
            if (point.X > this.Width)
            {
                point.X = -lblSongName.Width;
            }
            lblSongName.Location = point;
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value != progressBar.Maximum)
            {
                progressBar.Value++;
            }
            else if (lbSongs.Items.Count == 0)
            {
                timerSeconds.Stop();
                progressBar.Value = 0;
                txtTime.Text = "00 : 00";
                lblSongName.Text = "";
            }

            txtTime.Text = string.Format("{0:00} : {1:00}", progressBar.Value / 60, progressBar.Value % 60);

            if (progressBar.Value == progressBar.Maximum)
            {
                forwardSong();
            }
        }

        private void streamFinished(object sender, EventArgs e)
        {
            isStreamFinished = true;
            timer.Stop();
            currentShape.stopDrawing();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Stop();
            serialize();
        }

        private void Stop()
        {
            timer.Stop();
            timerSeconds.Stop();

            if (_soundOut != null)
            {
                _soundOut.Stop();
                _soundOut.Dispose();
                _eq.Dispose();
                _soundOut = null;
            }
            txtTime.Text = "00 : 00";
            progressBar.Value = 0;
            lblSongName.Text = "";
        }

        private void btnChangeView_Click(object sender, EventArgs e)
        {
            curvesVisualization = !curvesVisualization;
            if (curvesVisualization)
            {
                currentShape = new Curves(picGraph);
            }
            else
            {
                currentShape = new Bars(picGraph);
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            this.addSong();
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            this.removeSong();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.playSong();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (!btnPause.isPaused)
            {
                this.pauseSong();
            }
            else
            {
                this.resumeSong();
            }
            btnPause.isPaused = !btnPause.isPaused;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            this.forwardSong();
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            this.rewindSong();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.stopSongs();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {

            this.shuffleSongs();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = null;
                this.BackColor = colorDialog.Color;
                lblSongName.Image = null;
                lblSongName.BackColor = colorDialog.Color;
            }
        }

        private void lbSongs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                playSong();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                removeSong();
            }
        }

        private void serialize()
        {
            Songs listSongs = new Songs();

            foreach (Song s in lbSongs.Items)
            {
                listSongs.addSong(s);
            }

            System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            System.IO.FileStream strm = new System.IO.FileStream(fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None);
            fmt.Serialize(strm, listSongs);
            strm.Close();
        }

        private void deserialize()
        {
            String file = System.IO.Directory.GetCurrentDirectory() + '\\' + fileName;
            if (System.IO.File.Exists(file))
            {
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new System.IO.FileStream(fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.None);
                Songs listSongs = (Songs)fmt.Deserialize(strm);
                foreach (Song s in listSongs.songs)
                {
                    lbSongs.Items.Add(s);
                }
                strm.Close();
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (lbSongs.Items.Count == 0)
            {
                return;
            }
            lbSongs.Items.Clear();
            firstSongRemoved = true;
            currentSongIndex = -1;
        }

        private void lbSongs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbSongs.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                playSong();
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Array files = (Array)e.Data.GetData(DataFormats.FileDrop);
            MessageBox.Show(CodecFactory.SupportedFilesFilterEN);
            if (files != null)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    String name = files.GetValue(i).ToString();
                    String extension = name.Substring(name.LastIndexOf('.'));

                    if (CodecFactory.SupportedFilesFilterEN.Contains(extension))
                    {
                        var source = CodecFactory.Instance.GetCodec(name);
                        Song song = new Song(name, source.GetLength().Minutes, source.GetLength().Seconds);
                        lbSongs.Items.Add(song);
                    }
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void colorSliderVolume_ValueChanged(object sender, EventArgs e)
        {
            if (_soundOut != null)
            {
                _soundOut.Volume = (float)colorSliderVolume.Value / 100;
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            foreach (ButtonShape b in buttons)
            {
                b.Invalidate(true);
            }
        }

        private void colorSliderVolume_MouseUp(object sender, MouseEventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(colorSliderVolume, "Volume: " + colorSliderVolume.Value + "%");
            tooltip.IsBalloon = true;
        }
    }
}

