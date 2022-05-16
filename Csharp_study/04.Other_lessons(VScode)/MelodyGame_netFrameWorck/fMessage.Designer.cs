namespace MelodyGame_netFrameWorck
{
    partial class fMessage
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
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tTimeAnser = new System.Windows.Forms.Timer(this.components);
            this.lblTimeAnser = new System.Windows.Forms.Label();
            this.pbTimeAnser = new System.Windows.Forms.ProgressBar();
            this.lblShowAnser = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Chartreuse;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(45, 507);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(152, 70);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "YES!";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Red;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(256, 507);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(152, 70);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "NO=(";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(45, 13);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(246, 63);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Player";
            // 
            // tTimeAnser
            // 
            this.tTimeAnser.Interval = 1000;
            this.tTimeAnser.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimeAnser
            // 
            this.lblTimeAnser.AutoSize = true;
            this.lblTimeAnser.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeAnser.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAnser.Location = new System.Drawing.Point(369, 29);
            this.lblTimeAnser.Name = "lblTimeAnser";
            this.lblTimeAnser.Size = new System.Drawing.Size(39, 45);
            this.lblTimeAnser.TabIndex = 3;
            this.lblTimeAnser.Text = "0";
            // 
            // pbTimeAnser
            // 
            this.pbTimeAnser.Location = new System.Drawing.Point(45, 100);
            this.pbTimeAnser.Name = "pbTimeAnser";
            this.pbTimeAnser.Size = new System.Drawing.Size(363, 20);
            this.pbTimeAnser.Step = 1;
            this.pbTimeAnser.TabIndex = 4;
            this.pbTimeAnser.Value = 100;
            // 
            // lblShowAnser
            // 
            this.lblShowAnser.AutoSize = true;
            this.lblShowAnser.BackColor = System.Drawing.Color.Transparent;
            this.lblShowAnser.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAnser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowAnser.Location = new System.Drawing.Point(12, 278);
            this.lblShowAnser.Name = "lblShowAnser";
            this.lblShowAnser.Size = new System.Drawing.Size(224, 39);
            this.lblShowAnser.TabIndex = 5;
            this.lblShowAnser.Text = "Показать ответ";
            this.lblShowAnser.Click += new System.EventHandler(this.lblShowAnser_Click);
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer2.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnswer2.Location = new System.Drawing.Point(19, 362);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(361, 57);
            this.lblAnswer2.TabIndex = 6;
            this.lblAnswer2.Text = "Вариант ответа 2";
            this.lblAnswer2.Click += new System.EventHandler(this.lblAnswer2_Click);
            // 
            // fMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::MelodyGame_netFrameWorck.Properties.Resources.dj_naushniki_ustanovka_122020_225x300;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(443, 589);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblShowAnser);
            this.Controls.Add(this.pbTimeAnser);
            this.Controls.Add(this.lblTimeAnser);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Name = "fMessage";
            this.Text = "fMessage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMessage_FormClosed);
            this.Load += new System.EventHandler(this.fMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        public System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer tTimeAnser;
        private System.Windows.Forms.Label lblTimeAnser;
        private System.Windows.Forms.ProgressBar pbTimeAnser;
        private System.Windows.Forms.Label lblShowAnser;
        private System.Windows.Forms.Label lblAnswer2;
    }
}