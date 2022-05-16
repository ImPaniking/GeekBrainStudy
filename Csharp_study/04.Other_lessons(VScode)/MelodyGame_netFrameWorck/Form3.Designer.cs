namespace MelodyGame_netFrameWorck
{
    partial class fGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.ntmNext = new System.Windows.Forms.Button();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPointsTeam1 = new System.Windows.Forms.Label();
            this.lblPoitnsTeam2 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblSongsCount = new System.Windows.Forms.Label();
            this.lblRemaning = new System.Windows.Forms.Label();
            this.pbGameRime = new System.Windows.Forms.ProgressBar();
            this.tGameTime = new System.Windows.Forms.Timer(this.components);
            this.lblMusicDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // ntmNext
            // 
            this.ntmNext.BackColor = System.Drawing.Color.Aqua;
            this.ntmNext.Font = new System.Drawing.Font("Forte", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntmNext.Location = new System.Drawing.Point(379, 227);
            this.ntmNext.Name = "ntmNext";
            this.ntmNext.Size = new System.Drawing.Size(234, 57);
            this.ntmNext.TabIndex = 1;
            this.ntmNext.Text = "Следующая";
            this.ntmNext.UseVisualStyleBackColor = false;
            this.ntmNext.Click += new System.EventHandler(this.ntmNext_Click);
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(379, 553);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(218, 47);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer1.Location = new System.Drawing.Point(138, 34);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(89, 33);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Team1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer2.Location = new System.Drawing.Point(756, 34);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(89, 33);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Team2";
            // 
            // lblPointsTeam1
            // 
            this.lblPointsTeam1.AutoSize = true;
            this.lblPointsTeam1.BackColor = System.Drawing.Color.Transparent;
            this.lblPointsTeam1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsTeam1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPointsTeam1.Location = new System.Drawing.Point(163, 85);
            this.lblPointsTeam1.Name = "lblPointsTeam1";
            this.lblPointsTeam1.Size = new System.Drawing.Size(29, 33);
            this.lblPointsTeam1.TabIndex = 4;
            this.lblPointsTeam1.Text = "0";
            this.lblPointsTeam1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblPointsTeam1_MouseClick);
            // 
            // lblPoitnsTeam2
            // 
            this.lblPoitnsTeam2.AutoSize = true;
            this.lblPoitnsTeam2.BackColor = System.Drawing.Color.Transparent;
            this.lblPoitnsTeam2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoitnsTeam2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPoitnsTeam2.Location = new System.Drawing.Point(785, 85);
            this.lblPoitnsTeam2.Name = "lblPoitnsTeam2";
            this.lblPoitnsTeam2.Size = new System.Drawing.Size(29, 33);
            this.lblPoitnsTeam2.TabIndex = 5;
            this.lblPoitnsTeam2.Text = "0";
            this.lblPoitnsTeam2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblPoitnsTeam2_MouseClick);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPlay.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(379, 426);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(94, 39);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnPause.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(503, 426);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(94, 39);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Pauese";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblSongsCount
            // 
            this.lblSongsCount.AutoSize = true;
            this.lblSongsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblSongsCount.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongsCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSongsCount.Location = new System.Drawing.Point(485, 191);
            this.lblSongsCount.Name = "lblSongsCount";
            this.lblSongsCount.Size = new System.Drawing.Size(29, 33);
            this.lblSongsCount.TabIndex = 8;
            this.lblSongsCount.Text = "0";
            // 
            // lblRemaning
            // 
            this.lblRemaning.AutoSize = true;
            this.lblRemaning.BackColor = System.Drawing.Color.Transparent;
            this.lblRemaning.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRemaning.Location = new System.Drawing.Point(379, 197);
            this.lblRemaning.Name = "lblRemaning";
            this.lblRemaning.Size = new System.Drawing.Size(100, 26);
            this.lblRemaning.TabIndex = 9;
            this.lblRemaning.Text = "Осталось:";
            // 
            // pbGameRime
            // 
            this.pbGameRime.Location = new System.Drawing.Point(254, 34);
            this.pbGameRime.Name = "pbGameRime";
            this.pbGameRime.Size = new System.Drawing.Size(496, 33);
            this.pbGameRime.Step = 5;
            this.pbGameRime.TabIndex = 10;
            this.pbGameRime.Value = 100;
            // 
            // tGameTime
            // 
            this.tGameTime.Interval = 1000;
            this.tGameTime.Tick += new System.EventHandler(this.tGameTime_Tick);
            // 
            // lblMusicDuration
            // 
            this.lblMusicDuration.AutoSize = true;
            this.lblMusicDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicDuration.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicDuration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMusicDuration.Location = new System.Drawing.Point(478, 370);
            this.lblMusicDuration.Name = "lblMusicDuration";
            this.lblMusicDuration.Size = new System.Drawing.Size(36, 42);
            this.lblMusicDuration.TabIndex = 11;
            this.lblMusicDuration.Text = "0";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::MelodyGame_netFrameWorck.Properties.Resources.Music_Wallpaper_music_36986181_1920_1200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(974, 612);
            this.Controls.Add(this.lblMusicDuration);
            this.Controls.Add(this.pbGameRime);
            this.Controls.Add(this.lblRemaning);
            this.Controls.Add(this.lblSongsCount);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblPoitnsTeam2);
            this.Controls.Add(this.lblPointsTeam1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.ntmNext);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "GuessTheMelody Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button ntmNext;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPointsTeam1;
        private System.Windows.Forms.Label lblPoitnsTeam2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblSongsCount;
        private System.Windows.Forms.Label lblRemaning;
        private System.Windows.Forms.ProgressBar pbGameRime;
        private System.Windows.Forms.Timer tGameTime;
        private System.Windows.Forms.Label lblMusicDuration;
    }
}