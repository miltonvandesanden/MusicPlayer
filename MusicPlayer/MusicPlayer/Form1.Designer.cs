namespace MusicPlayer
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
            this.libPlaylist = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.tbSPath = new System.Windows.Forms.TextBox();
            this.rtbLyrics = new System.Windows.Forms.RichTextBox();
            this.lbSName = new System.Windows.Forms.Label();
            this.lbSYear = new System.Windows.Forms.Label();
            this.lbSLyrics = new System.Windows.Forms.Label();
            this.lbSPath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSArtist = new System.Windows.Forms.Label();
            this.cbSArtist = new System.Windows.Forms.ComboBox();
            this.lbABirthday = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAName = new System.Windows.Forms.Label();
            this.tbAName = new System.Windows.Forms.TextBox();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.gbAddSong = new System.Windows.Forms.GroupBox();
            this.nudSYear = new System.Windows.Forms.NumericUpDown();
            this.gbAddArtist = new System.Windows.Forms.GroupBox();
            this.dtpDateArtist = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPCreate = new System.Windows.Forms.Button();
            this.lbPName = new System.Windows.Forms.Label();
            this.tbPName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbASPPlaylistName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPAddSong = new System.Windows.Forms.Button();
            this.cbCurrentPlaylist = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPRemove = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPRemove = new System.Windows.Forms.Button();
            this.gbRemoveSongFromPlaylist = new System.Windows.Forms.GroupBox();
            this.btnRSFPRemove = new System.Windows.Forms.Button();
            this.cbRSFPSong = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRSFPPlaylist = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbAddSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSYear)).BeginInit();
            this.gbAddArtist.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbRemoveSongFromPlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // libPlaylist
            // 
            this.libPlaylist.FormattingEnabled = true;
            this.libPlaylist.Location = new System.Drawing.Point(12, 12);
            this.libPlaylist.Name = "libPlaylist";
            this.libPlaylist.Size = new System.Drawing.Size(532, 524);
            this.libPlaylist.TabIndex = 0;
            this.libPlaylist.SelectedIndexChanged += new System.EventHandler(this.libPlaylist_SelectedIndexChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 553);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(174, 553);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(93, 553);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Enabled = false;
            this.btnAddSong.Location = new System.Drawing.Point(161, 260);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 4;
            this.btnAddSong.Text = "Add";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(68, 29);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(168, 20);
            this.tbSName.TabIndex = 5;
            this.tbSName.TextChanged += new System.EventHandler(this.tbSName_TextChanged);
            // 
            // tbSPath
            // 
            this.tbSPath.Enabled = false;
            this.tbSPath.Location = new System.Drawing.Point(68, 234);
            this.tbSPath.Name = "tbSPath";
            this.tbSPath.Size = new System.Drawing.Size(168, 20);
            this.tbSPath.TabIndex = 8;
            this.tbSPath.TextChanged += new System.EventHandler(this.tbSPath_TextChanged);
            // 
            // rtbLyrics
            // 
            this.rtbLyrics.Enabled = false;
            this.rtbLyrics.Location = new System.Drawing.Point(68, 121);
            this.rtbLyrics.Name = "rtbLyrics";
            this.rtbLyrics.Size = new System.Drawing.Size(168, 96);
            this.rtbLyrics.TabIndex = 9;
            this.rtbLyrics.Text = "";
            this.rtbLyrics.TextChanged += new System.EventHandler(this.rtbLyrics_TextChanged);
            // 
            // lbSName
            // 
            this.lbSName.AutoSize = true;
            this.lbSName.Location = new System.Drawing.Point(12, 32);
            this.lbSName.Name = "lbSName";
            this.lbSName.Size = new System.Drawing.Size(35, 13);
            this.lbSName.TabIndex = 11;
            this.lbSName.Text = "Name";
            // 
            // lbSYear
            // 
            this.lbSYear.AutoSize = true;
            this.lbSYear.Location = new System.Drawing.Point(11, 88);
            this.lbSYear.Name = "lbSYear";
            this.lbSYear.Size = new System.Drawing.Size(29, 13);
            this.lbSYear.TabIndex = 12;
            this.lbSYear.Text = "Year";
            // 
            // lbSLyrics
            // 
            this.lbSLyrics.AutoSize = true;
            this.lbSLyrics.Location = new System.Drawing.Point(11, 121);
            this.lbSLyrics.Name = "lbSLyrics";
            this.lbSLyrics.Size = new System.Drawing.Size(34, 13);
            this.lbSLyrics.TabIndex = 13;
            this.lbSLyrics.Text = "Lyrics";
            // 
            // lbSPath
            // 
            this.lbSPath.AutoSize = true;
            this.lbSPath.Location = new System.Drawing.Point(11, 234);
            this.lbSPath.Name = "lbSPath";
            this.lbSPath.Size = new System.Drawing.Size(29, 13);
            this.lbSPath.TabIndex = 14;
            this.lbSPath.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            // 
            // lbSArtist
            // 
            this.lbSArtist.AutoSize = true;
            this.lbSArtist.Location = new System.Drawing.Point(12, 62);
            this.lbSArtist.Name = "lbSArtist";
            this.lbSArtist.Size = new System.Drawing.Size(30, 13);
            this.lbSArtist.TabIndex = 17;
            this.lbSArtist.Text = "Artist";
            // 
            // cbSArtist
            // 
            this.cbSArtist.Enabled = false;
            this.cbSArtist.FormattingEnabled = true;
            this.cbSArtist.Location = new System.Drawing.Point(68, 59);
            this.cbSArtist.Name = "cbSArtist";
            this.cbSArtist.Size = new System.Drawing.Size(168, 21);
            this.cbSArtist.TabIndex = 18;
            this.cbSArtist.DropDown += new System.EventHandler(this.cbSArtist_DropDown);
            this.cbSArtist.SelectedIndexChanged += new System.EventHandler(this.cbSArtist_SelectedIndexChanged);
            // 
            // lbABirthday
            // 
            this.lbABirthday.AutoSize = true;
            this.lbABirthday.Location = new System.Drawing.Point(10, 57);
            this.lbABirthday.Name = "lbABirthday";
            this.lbABirthday.Size = new System.Drawing.Size(45, 13);
            this.lbABirthday.TabIndex = 23;
            this.lbABirthday.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 22;
            // 
            // lbAName
            // 
            this.lbAName.AutoSize = true;
            this.lbAName.Location = new System.Drawing.Point(10, 27);
            this.lbAName.Name = "lbAName";
            this.lbAName.Size = new System.Drawing.Size(35, 13);
            this.lbAName.TabIndex = 21;
            this.lbAName.Text = "Name";
            // 
            // tbAName
            // 
            this.tbAName.Location = new System.Drawing.Point(58, 27);
            this.tbAName.Name = "tbAName";
            this.tbAName.Size = new System.Drawing.Size(188, 20);
            this.tbAName.TabIndex = 20;
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(171, 77);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(75, 23);
            this.btnAddArtist.TabIndex = 26;
            this.btnAddArtist.Text = "Add";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // gbAddSong
            // 
            this.gbAddSong.Controls.Add(this.nudSYear);
            this.gbAddSong.Controls.Add(this.cbSArtist);
            this.gbAddSong.Controls.Add(this.label2);
            this.gbAddSong.Controls.Add(this.lbSPath);
            this.gbAddSong.Controls.Add(this.lbSLyrics);
            this.gbAddSong.Controls.Add(this.lbSYear);
            this.gbAddSong.Controls.Add(this.rtbLyrics);
            this.gbAddSong.Controls.Add(this.tbSPath);
            this.gbAddSong.Controls.Add(this.lbSArtist);
            this.gbAddSong.Controls.Add(this.lbSName);
            this.gbAddSong.Controls.Add(this.tbSName);
            this.gbAddSong.Controls.Add(this.btnAddSong);
            this.gbAddSong.Location = new System.Drawing.Point(550, 12);
            this.gbAddSong.Name = "gbAddSong";
            this.gbAddSong.Size = new System.Drawing.Size(252, 329);
            this.gbAddSong.TabIndex = 27;
            this.gbAddSong.TabStop = false;
            this.gbAddSong.Text = "Add Song";
            // 
            // nudSYear
            // 
            this.nudSYear.Location = new System.Drawing.Point(68, 86);
            this.nudSYear.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nudSYear.Minimum = new decimal(new int[] {
            1890,
            0,
            0,
            0});
            this.nudSYear.Name = "nudSYear";
            this.nudSYear.Size = new System.Drawing.Size(168, 20);
            this.nudSYear.TabIndex = 32;
            this.nudSYear.Value = new decimal(new int[] {
            1890,
            0,
            0,
            0});
            // 
            // gbAddArtist
            // 
            this.gbAddArtist.Controls.Add(this.dtpDateArtist);
            this.gbAddArtist.Controls.Add(this.btnAddArtist);
            this.gbAddArtist.Controls.Add(this.lbABirthday);
            this.gbAddArtist.Controls.Add(this.label5);
            this.gbAddArtist.Controls.Add(this.lbAName);
            this.gbAddArtist.Controls.Add(this.tbAName);
            this.gbAddArtist.Location = new System.Drawing.Point(550, 356);
            this.gbAddArtist.Name = "gbAddArtist";
            this.gbAddArtist.Size = new System.Drawing.Size(252, 122);
            this.gbAddArtist.TabIndex = 28;
            this.gbAddArtist.TabStop = false;
            this.gbAddArtist.Text = "Add Artist";
            // 
            // dtpDateArtist
            // 
            this.dtpDateArtist.Location = new System.Drawing.Point(58, 53);
            this.dtpDateArtist.Name = "dtpDateArtist";
            this.dtpDateArtist.Size = new System.Drawing.Size(188, 20);
            this.dtpDateArtist.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPCreate);
            this.groupBox1.Controls.Add(this.lbPName);
            this.groupBox1.Controls.Add(this.tbPName);
            this.groupBox1.Location = new System.Drawing.Point(808, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 104);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Playlist";
            // 
            // btnPCreate
            // 
            this.btnPCreate.Enabled = false;
            this.btnPCreate.Location = new System.Drawing.Point(159, 56);
            this.btnPCreate.Name = "btnPCreate";
            this.btnPCreate.Size = new System.Drawing.Size(75, 23);
            this.btnPCreate.TabIndex = 28;
            this.btnPCreate.Text = "Create";
            this.btnPCreate.UseVisualStyleBackColor = true;
            this.btnPCreate.Click += new System.EventHandler(this.btnPCreate_Click);
            // 
            // lbPName
            // 
            this.lbPName.AutoSize = true;
            this.lbPName.Location = new System.Drawing.Point(10, 33);
            this.lbPName.Name = "lbPName";
            this.lbPName.Size = new System.Drawing.Size(35, 13);
            this.lbPName.TabIndex = 20;
            this.lbPName.Text = "Name";
            // 
            // tbPName
            // 
            this.tbPName.Location = new System.Drawing.Point(66, 30);
            this.tbPName.Name = "tbPName";
            this.tbPName.Size = new System.Drawing.Size(168, 20);
            this.tbPName.TabIndex = 19;
            this.tbPName.TextChanged += new System.EventHandler(this.tbPName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbASPPlaylistName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnPAddSong);
            this.groupBox2.Location = new System.Drawing.Point(808, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 106);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Songs To Playlist";
            // 
            // cbASPPlaylistName
            // 
            this.cbASPPlaylistName.Enabled = false;
            this.cbASPPlaylistName.FormattingEnabled = true;
            this.cbASPPlaylistName.Location = new System.Drawing.Point(88, 32);
            this.cbASPPlaylistName.Name = "cbASPPlaylistName";
            this.cbASPPlaylistName.Size = new System.Drawing.Size(148, 21);
            this.cbASPPlaylistName.TabIndex = 18;
            this.cbASPPlaylistName.DropDown += new System.EventHandler(this.cbASPPlaylistName_DropDown);
            this.cbASPPlaylistName.SelectedIndexChanged += new System.EventHandler(this.cbASPPlaylistName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Playlist Name";
            // 
            // btnPAddSong
            // 
            this.btnPAddSong.Enabled = false;
            this.btnPAddSong.Location = new System.Drawing.Point(161, 62);
            this.btnPAddSong.Name = "btnPAddSong";
            this.btnPAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnPAddSong.TabIndex = 4;
            this.btnPAddSong.Text = "Add";
            this.btnPAddSong.UseVisualStyleBackColor = true;
            this.btnPAddSong.Click += new System.EventHandler(this.btnPAddSong_Click);
            // 
            // cbCurrentPlaylist
            // 
            this.cbCurrentPlaylist.FormattingEnabled = true;
            this.cbCurrentPlaylist.Location = new System.Drawing.Point(423, 553);
            this.cbCurrentPlaylist.Name = "cbCurrentPlaylist";
            this.cbCurrentPlaylist.Size = new System.Drawing.Size(121, 21);
            this.cbCurrentPlaylist.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Current Playlist";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbPRemove);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnPRemove);
            this.groupBox3.Location = new System.Drawing.Point(807, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 106);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remove Playlist";
            // 
            // cbPRemove
            // 
            this.cbPRemove.FormattingEnabled = true;
            this.cbPRemove.Location = new System.Drawing.Point(88, 32);
            this.cbPRemove.Name = "cbPRemove";
            this.cbPRemove.Size = new System.Drawing.Size(148, 21);
            this.cbPRemove.TabIndex = 18;
            this.cbPRemove.DropDown += new System.EventHandler(this.cbPRemove_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Playlist Name";
            // 
            // btnPRemove
            // 
            this.btnPRemove.Enabled = false;
            this.btnPRemove.Location = new System.Drawing.Point(161, 62);
            this.btnPRemove.Name = "btnPRemove";
            this.btnPRemove.Size = new System.Drawing.Size(75, 23);
            this.btnPRemove.TabIndex = 4;
            this.btnPRemove.Text = "Add";
            this.btnPRemove.UseVisualStyleBackColor = true;
            this.btnPRemove.Click += new System.EventHandler(this.btnPRemove_Click);
            // 
            // gbRemoveSongFromPlaylist
            // 
            this.gbRemoveSongFromPlaylist.Controls.Add(this.btnRSFPRemove);
            this.gbRemoveSongFromPlaylist.Controls.Add(this.cbRSFPSong);
            this.gbRemoveSongFromPlaylist.Controls.Add(this.label9);
            this.gbRemoveSongFromPlaylist.Controls.Add(this.cbRSFPPlaylist);
            this.gbRemoveSongFromPlaylist.Controls.Add(this.label8);
            this.gbRemoveSongFromPlaylist.Location = new System.Drawing.Point(807, 356);
            this.gbRemoveSongFromPlaylist.Name = "gbRemoveSongFromPlaylist";
            this.gbRemoveSongFromPlaylist.Size = new System.Drawing.Size(200, 100);
            this.gbRemoveSongFromPlaylist.TabIndex = 32;
            this.gbRemoveSongFromPlaylist.TabStop = false;
            this.gbRemoveSongFromPlaylist.Text = "Remove Song From Playlist";
            // 
            // btnRSFPRemove
            // 
            this.btnRSFPRemove.Enabled = false;
            this.btnRSFPRemove.Location = new System.Drawing.Point(94, 71);
            this.btnRSFPRemove.Name = "btnRSFPRemove";
            this.btnRSFPRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRSFPRemove.TabIndex = 4;
            this.btnRSFPRemove.Text = "Remove";
            this.btnRSFPRemove.UseVisualStyleBackColor = true;
            this.btnRSFPRemove.Click += new System.EventHandler(this.btnRSFPRemove_Click);
            // 
            // cbRSFPSong
            // 
            this.cbRSFPSong.Enabled = false;
            this.cbRSFPSong.FormattingEnabled = true;
            this.cbRSFPSong.Location = new System.Drawing.Point(47, 41);
            this.cbRSFPSong.Name = "cbRSFPSong";
            this.cbRSFPSong.Size = new System.Drawing.Size(121, 21);
            this.cbRSFPSong.TabIndex = 3;
            this.cbRSFPSong.DropDown += new System.EventHandler(this.cbRSFPSong_DropDown);
            this.cbRSFPSong.SelectedIndexChanged += new System.EventHandler(this.cbRSFPSong_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Song:";
            // 
            // cbRSFPPlaylist
            // 
            this.cbRSFPPlaylist.FormattingEnabled = true;
            this.cbRSFPPlaylist.Location = new System.Drawing.Point(48, 16);
            this.cbRSFPPlaylist.Name = "cbRSFPPlaylist";
            this.cbRSFPPlaylist.Size = new System.Drawing.Size(121, 21);
            this.cbRSFPPlaylist.TabIndex = 1;
            this.cbRSFPPlaylist.DropDown += new System.EventHandler(this.cbRSFPPlaylist_DropDown);
            this.cbRSFPPlaylist.SelectedIndexChanged += new System.EventHandler(this.cbRSFPPlaylist_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Playlist:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 655);
            this.Controls.Add(this.gbRemoveSongFromPlaylist);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCurrentPlaylist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAddArtist);
            this.Controls.Add(this.gbAddSong);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.libPlaylist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAddSong.ResumeLayout(false);
            this.gbAddSong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSYear)).EndInit();
            this.gbAddArtist.ResumeLayout(false);
            this.gbAddArtist.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbRemoveSongFromPlaylist.ResumeLayout(false);
            this.gbRemoveSongFromPlaylist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox libPlaylist;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.TextBox tbSPath;
        private System.Windows.Forms.RichTextBox rtbLyrics;
        private System.Windows.Forms.Label lbSName;
        private System.Windows.Forms.Label lbSYear;
        private System.Windows.Forms.Label lbSLyrics;
        private System.Windows.Forms.Label lbSPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSArtist;
        private System.Windows.Forms.ComboBox cbSArtist;
        private System.Windows.Forms.Label lbABirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAName;
        private System.Windows.Forms.TextBox tbAName;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.GroupBox gbAddSong;
        private System.Windows.Forms.GroupBox gbAddArtist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudSYear;
        private System.Windows.Forms.Button btnPCreate;
        private System.Windows.Forms.Label lbPName;
        private System.Windows.Forms.TextBox tbPName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbASPPlaylistName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPAddSong;
        private System.Windows.Forms.ComboBox cbCurrentPlaylist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbPRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPRemove;
        private System.Windows.Forms.DateTimePicker dtpDateArtist;
        private System.Windows.Forms.GroupBox gbRemoveSongFromPlaylist;
        private System.Windows.Forms.Button btnRSFPRemove;
        private System.Windows.Forms.ComboBox cbRSFPSong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRSFPPlaylist;
        private System.Windows.Forms.Label label8;
    }
}

