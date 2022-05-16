namespace MelodyGame_netFrameWorck
{
    partial class fSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettings));
            this.lbMusicList = new System.Windows.Forms.ListBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.cbFolderCheck = new System.Windows.Forms.CheckBox();
            this.gbGameSettings = new System.Windows.Forms.GroupBox();
            this.lblGameTime = new System.Windows.Forms.Label();
            this.lblMusicTime = new System.Windows.Forms.Label();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.lblPlayer1But = new System.Windows.Forms.Label();
            this.lblPlayer2but = new System.Windows.Forms.Label();
            this.cbPlayer1Button = new System.Windows.Forms.ComboBox();
            this.cbPlayer2Button = new System.Windows.Forms.ComboBox();
            this.gbGameSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMusicList
            // 
            this.lbMusicList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMusicList.FormattingEnabled = true;
            this.lbMusicList.ItemHeight = 19;
            this.lbMusicList.Location = new System.Drawing.Point(13, 13);
            this.lbMusicList.Name = "lbMusicList";
            this.lbMusicList.Size = new System.Drawing.Size(775, 232);
            this.lbMusicList.TabIndex = 0;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolder.Location = new System.Drawing.Point(13, 258);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(150, 34);
            this.btnAddFolder.TabIndex = 1;
            this.btnAddFolder.Text = "Добавить папку";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.Location = new System.Drawing.Point(12, 324);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(150, 34);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "Очистить список";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Location = new System.Drawing.Point(12, 364);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(91, 34);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "Сохранить";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(13, 404);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(91, 34);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "Отмена";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // cbFolderCheck
            // 
            this.cbFolderCheck.AutoSize = true;
            this.cbFolderCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFolderCheck.Location = new System.Drawing.Point(13, 298);
            this.cbFolderCheck.Name = "cbFolderCheck";
            this.cbFolderCheck.Size = new System.Drawing.Size(125, 23);
            this.cbFolderCheck.TabIndex = 5;
            this.cbFolderCheck.Text = "Влючая папки";
            this.cbFolderCheck.UseVisualStyleBackColor = true;
            // 
            // gbGameSettings
            // 
            this.gbGameSettings.Controls.Add(this.cbPlayer2Button);
            this.gbGameSettings.Controls.Add(this.cbPlayer1Button);
            this.gbGameSettings.Controls.Add(this.lblPlayer2but);
            this.gbGameSettings.Controls.Add(this.lblPlayer1But);
            this.gbGameSettings.Controls.Add(this.cbRandom);
            this.gbGameSettings.Controls.Add(this.cbMusicDuration);
            this.gbGameSettings.Controls.Add(this.cbGameDuration);
            this.gbGameSettings.Controls.Add(this.lblMusicTime);
            this.gbGameSettings.Controls.Add(this.lblGameTime);
            this.gbGameSettings.Location = new System.Drawing.Point(170, 252);
            this.gbGameSettings.Name = "gbGameSettings";
            this.gbGameSettings.Size = new System.Drawing.Size(618, 186);
            this.gbGameSettings.TabIndex = 6;
            this.gbGameSettings.TabStop = false;
            this.gbGameSettings.Text = "Настройки игры";
            // 
            // lblGameTime
            // 
            this.lblGameTime.AutoSize = true;
            this.lblGameTime.Location = new System.Drawing.Point(7, 26);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(139, 13);
            this.lblGameTime.TabIndex = 0;
            this.lblGameTime.Text = "Продолжительность игры";
            // 
            // lblMusicTime
            // 
            this.lblMusicTime.AutoSize = true;
            this.lblMusicTime.Location = new System.Drawing.Point(10, 55);
            this.lblMusicTime.Name = "lblMusicTime";
            this.lblMusicTime.Size = new System.Drawing.Size(153, 13);
            this.lblMusicTime.TabIndex = 1;
            this.lblMusicTime.Text = "Продолжительность музыки";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "300",
            "600",
            "900",
            "1200",
            "1800",
            "3600"});
            this.cbGameDuration.Location = new System.Drawing.Point(179, 26);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(83, 21);
            this.cbGameDuration.TabIndex = 2;
            this.cbGameDuration.Text = "20";
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "3",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbMusicDuration.Location = new System.Drawing.Point(179, 55);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(83, 21);
            this.cbMusicDuration.TabIndex = 3;
            this.cbMusicDuration.Text = "10";
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(13, 88);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(133, 17);
            this.cbRandom.TabIndex = 4;
            this.cbRandom.Text = "Со случайного места";
            this.cbRandom.UseVisualStyleBackColor = true;
            // 
            // lblPlayer1But
            // 
            this.lblPlayer1But.AutoSize = true;
            this.lblPlayer1But.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1But.Location = new System.Drawing.Point(13, 124);
            this.lblPlayer1But.Name = "lblPlayer1But";
            this.lblPlayer1But.Size = new System.Drawing.Size(143, 23);
            this.lblPlayer1But.TabIndex = 5;
            this.lblPlayer1But.Text = "Кнопка игрока 1";
            // 
            // lblPlayer2but
            // 
            this.lblPlayer2but.AutoSize = true;
            this.lblPlayer2but.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2but.Location = new System.Drawing.Point(13, 152);
            this.lblPlayer2but.Name = "lblPlayer2but";
            this.lblPlayer2but.Size = new System.Drawing.Size(143, 23);
            this.lblPlayer2but.TabIndex = 6;
            this.lblPlayer2but.Text = "Кнопка игрока 2";
            // 
            // cbPlayer1Button
            // 
            this.cbPlayer1Button.FormattingEnabled = true;
            this.cbPlayer1Button.Location = new System.Drawing.Point(179, 124);
            this.cbPlayer1Button.Name = "cbPlayer1Button";
            this.cbPlayer1Button.Size = new System.Drawing.Size(83, 21);
            this.cbPlayer1Button.TabIndex = 7;
            this.cbPlayer1Button.Text = "A";
            // 
            // cbPlayer2Button
            // 
            this.cbPlayer2Button.FormattingEnabled = true;
            this.cbPlayer2Button.Location = new System.Drawing.Point(179, 152);
            this.cbPlayer2Button.Name = "cbPlayer2Button";
            this.cbPlayer2Button.Size = new System.Drawing.Size(83, 21);
            this.cbPlayer2Button.TabIndex = 8;
            this.cbPlayer2Button.Text = "P";
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbGameSettings);
            this.Controls.Add(this.cbFolderCheck);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.lbMusicList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.gbGameSettings.ResumeLayout(false);
            this.gbGameSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMusicList;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.CheckBox cbFolderCheck;
        private System.Windows.Forms.GroupBox gbGameSettings;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.Label lblMusicTime;
        private System.Windows.Forms.Label lblGameTime;
        private System.Windows.Forms.ComboBox cbPlayer2Button;
        private System.Windows.Forms.ComboBox cbPlayer1Button;
        private System.Windows.Forms.Label lblPlayer2but;
        private System.Windows.Forms.Label lblPlayer1But;
    }
}