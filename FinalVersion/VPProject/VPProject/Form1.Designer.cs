namespace VPProject
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnChangeView = new System.Windows.Forms.Button();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblSongName = new System.Windows.Forms.Label();
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.pictureBoxCurve = new System.Windows.Forms.PictureBox();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar10 = new System.Windows.Forms.TrackBar();
            this.colorSliderVolume = new VPProject.ColorSlider();
            this.btnRemoveAll = new VPProject.BtnRemoveAllSongs();
            this.btnShuffle = new VPProject.BtnShuffle();
            this.btnStop = new VPProject.BtnStop();
            this.btnRewind = new VPProject.BtnRewind();
            this.btnForward = new VPProject.BtnForward();
            this.btnPause = new VPProject.BtnPause();
            this.btnPlay = new VPProject.BtnPlay();
            this.btnRemoveSong = new VPProject.BtnRemoveSong();
            this.btnAddSong = new VPProject.BtnAddSong();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 150;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnChangeView
            // 
            this.btnChangeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeView.ForeColor = System.Drawing.Color.Green;
            this.btnChangeView.Location = new System.Drawing.Point(232, 109);
            this.btnChangeView.Name = "btnChangeView";
            this.btnChangeView.Size = new System.Drawing.Size(90, 23);
            this.btnChangeView.TabIndex = 4;
            this.btnChangeView.Text = "Change View";
            this.btnChangeView.UseVisualStyleBackColor = true;
            this.btnChangeView.Click += new System.EventHandler(this.btnChangeView_Click);
            // 
            // lbSongs
            // 
            this.lbSongs.BackColor = System.Drawing.Color.Silver;
            this.lbSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongs.ForeColor = System.Drawing.Color.Green;
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 16;
            this.lbSongs.Location = new System.Drawing.Point(6, 339);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(316, 180);
            this.lbSongs.TabIndex = 5;
            this.lbSongs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbSongs_KeyDown);
            this.lbSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSongs_MouseDoubleClick);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Black;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Green;
            this.txtTime.Location = new System.Drawing.Point(6, 3);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(152, 33);
            this.txtTime.TabIndex = 14;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 109);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(214, 23);
            this.progressBar.TabIndex = 16;
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSongName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSongName.Location = new System.Drawing.Point(5, 149);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(0, 21);
            this.lblSongName.TabIndex = 17;
            // 
            // timerSeconds
            // 
            this.timerSeconds.Interval = 1000;
            this.timerSeconds.Tick += new System.EventHandler(this.timerSeconds_Tick);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColor.ForeColor = System.Drawing.Color.Green;
            this.btnChangeColor.Location = new System.Drawing.Point(54, 531);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(180, 23);
            this.btnChangeColor.TabIndex = 18;
            this.btnChangeColor.Text = "Change Back-Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // pictureBoxCurve
            // 
            this.pictureBoxCurve.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCurve.Location = new System.Drawing.Point(6, 43);
            this.pictureBoxCurve.Name = "pictureBoxCurve";
            this.pictureBoxCurve.Size = new System.Drawing.Size(152, 60);
            this.pictureBoxCurve.TabIndex = 15;
            this.pictureBoxCurve.TabStop = false;
            // 
            // picGraph
            // 
            this.picGraph.BackColor = System.Drawing.Color.Black;
            this.picGraph.Location = new System.Drawing.Point(172, 3);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(150, 100);
            this.picGraph.TabIndex = 3;
            this.picGraph.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Controls.Add(this.trackBar9);
            this.flowLayoutPanel1.Controls.Add(this.trackBar1);
            this.flowLayoutPanel1.Controls.Add(this.trackBar2);
            this.flowLayoutPanel1.Controls.Add(this.trackBar3);
            this.flowLayoutPanel1.Controls.Add(this.trackBar4);
            this.flowLayoutPanel1.Controls.Add(this.trackBar5);
            this.flowLayoutPanel1.Controls.Add(this.trackBar6);
            this.flowLayoutPanel1.Controls.Add(this.trackBar7);
            this.flowLayoutPanel1.Controls.Add(this.trackBar8);
            this.flowLayoutPanel1.Controls.Add(this.trackBar10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 220);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(316, 102);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // trackBar9
            // 
            this.trackBar9.AutoSize = false;
            this.trackBar9.BackColor = System.Drawing.Color.Silver;
            this.trackBar9.Location = new System.Drawing.Point(3, 3);
            this.trackBar9.Maximum = 100;
            this.trackBar9.Minimum = -100;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar9.Size = new System.Drawing.Size(25, 92);
            this.trackBar9.TabIndex = 9;
            this.trackBar9.Tag = "8";
            this.trackBar9.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar9.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.Silver;
            this.trackBar1.Location = new System.Drawing.Point(34, 3);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(25, 92);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Tag = "0";
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.BackColor = System.Drawing.Color.Silver;
            this.trackBar2.Location = new System.Drawing.Point(65, 3);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = -100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(25, 92);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Tag = "1";
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.AutoSize = false;
            this.trackBar3.BackColor = System.Drawing.Color.Silver;
            this.trackBar3.Location = new System.Drawing.Point(96, 3);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Minimum = -100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(25, 92);
            this.trackBar3.TabIndex = 3;
            this.trackBar3.Tag = "2";
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar4
            // 
            this.trackBar4.AutoSize = false;
            this.trackBar4.BackColor = System.Drawing.Color.Silver;
            this.trackBar4.Location = new System.Drawing.Point(127, 3);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Minimum = -100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(25, 92);
            this.trackBar4.TabIndex = 4;
            this.trackBar4.Tag = "3";
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar4.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar5
            // 
            this.trackBar5.AutoSize = false;
            this.trackBar5.BackColor = System.Drawing.Color.Silver;
            this.trackBar5.Location = new System.Drawing.Point(158, 3);
            this.trackBar5.Maximum = 100;
            this.trackBar5.Minimum = -100;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar5.Size = new System.Drawing.Size(25, 92);
            this.trackBar5.TabIndex = 5;
            this.trackBar5.Tag = "4";
            this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar5.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar6
            // 
            this.trackBar6.AutoSize = false;
            this.trackBar6.BackColor = System.Drawing.Color.Silver;
            this.trackBar6.Location = new System.Drawing.Point(189, 3);
            this.trackBar6.Maximum = 100;
            this.trackBar6.Minimum = -100;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar6.Size = new System.Drawing.Size(25, 92);
            this.trackBar6.TabIndex = 6;
            this.trackBar6.Tag = "5";
            this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar6.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar7
            // 
            this.trackBar7.AutoSize = false;
            this.trackBar7.BackColor = System.Drawing.Color.Silver;
            this.trackBar7.Location = new System.Drawing.Point(220, 3);
            this.trackBar7.Maximum = 100;
            this.trackBar7.Minimum = -100;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar7.Size = new System.Drawing.Size(25, 92);
            this.trackBar7.TabIndex = 7;
            this.trackBar7.Tag = "6";
            this.trackBar7.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar7.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar8
            // 
            this.trackBar8.AutoSize = false;
            this.trackBar8.BackColor = System.Drawing.Color.Silver;
            this.trackBar8.Location = new System.Drawing.Point(251, 3);
            this.trackBar8.Maximum = 100;
            this.trackBar8.Minimum = -100;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar8.Size = new System.Drawing.Size(25, 92);
            this.trackBar8.TabIndex = 8;
            this.trackBar8.Tag = "7";
            this.trackBar8.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar8.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar10
            // 
            this.trackBar10.AutoSize = false;
            this.trackBar10.BackColor = System.Drawing.Color.Silver;
            this.trackBar10.Location = new System.Drawing.Point(282, 3);
            this.trackBar10.Maximum = 100;
            this.trackBar10.Minimum = -100;
            this.trackBar10.Name = "trackBar10";
            this.trackBar10.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar10.Size = new System.Drawing.Size(25, 92);
            this.trackBar10.TabIndex = 10;
            this.trackBar10.Tag = "9";
            this.trackBar10.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar10.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // colorSliderVolume
            // 
            this.colorSliderVolume.BackColor = System.Drawing.Color.Transparent;
            this.colorSliderVolume.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSliderVolume.LargeChange = ((uint)(5u));
            this.colorSliderVolume.Location = new System.Drawing.Point(232, 187);
            this.colorSliderVolume.Name = "colorSliderVolume";
            this.colorSliderVolume.Size = new System.Drawing.Size(85, 27);
            this.colorSliderVolume.SmallChange = ((uint)(1u));
            this.colorSliderVolume.TabIndex = 20;
            this.colorSliderVolume.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSliderVolume.ValueChanged += new System.EventHandler(this.colorSliderVolume_ValueChanged);
            this.colorSliderVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorSliderVolume_MouseUp);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveAll.Image")));
            this.btnRemoveAll.Location = new System.Drawing.Point(292, 531);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(30, 23);
            this.btnRemoveAll.TabIndex = 19;
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffle.Image")));
            this.btnShuffle.Location = new System.Drawing.Point(195, 187);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(30, 30);
            this.btnShuffle.TabIndex = 13;
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(114, 187);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(30, 30);
            this.btnStop.TabIndex = 12;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRewind
            // 
            this.btnRewind.Image = ((System.Drawing.Image)(resources.GetObject("btnRewind.Image")));
            this.btnRewind.Location = new System.Drawing.Point(150, 187);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(30, 30);
            this.btnRewind.TabIndex = 11;
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // btnForward
            // 
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.Location = new System.Drawing.Point(6, 187);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(30, 30);
            this.btnForward.TabIndex = 10;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnPause
            // 
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.isPaused = false;
            this.btnPause.Location = new System.Drawing.Point(78, 187);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(30, 30);
            this.btnPause.TabIndex = 9;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(42, 187);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 30);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveSong.Image")));
            this.btnRemoveSong.Location = new System.Drawing.Point(252, 531);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(30, 23);
            this.btnRemoveSong.TabIndex = 7;
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSong.Image")));
            this.btnAddSong.Location = new System.Drawing.Point(6, 527);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(30, 30);
            this.btnAddSong.TabIndex = 6;
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(329, 562);
            this.Controls.Add(this.colorSliderVolume);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBoxCurve);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRewind);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.lbSongs);
            this.Controls.Add(this.btnChangeView);
            this.Controls.Add(this.picGraph);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "MP3 Player";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.TrackBar trackBar10;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.Button btnChangeView;
        private System.Windows.Forms.ListBox lbSongs;
        private BtnAddSong btnAddSong;
        private BtnRemoveSong btnRemoveSong;
        private BtnPlay btnPlay;
        private BtnPause btnPause;
        private BtnForward btnForward;
        private BtnRewind btnRewind;
        private BtnStop btnStop;
        private BtnShuffle btnShuffle;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.PictureBox pictureBoxCurve;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Timer timerSeconds;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnChangeColor;
        BtnRemoveAllSongs btnRemoveAll;
        private ColorSlider colorSliderVolume;
    }
}


