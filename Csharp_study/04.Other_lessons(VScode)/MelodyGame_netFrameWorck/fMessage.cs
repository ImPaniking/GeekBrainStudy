using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelodyGame_netFrameWorck
{
    public partial class fMessage : Form
    {
        int TimeAnser = 10;
        public fMessage()
        {
            InitializeComponent();
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            TimeAnser = 10;
            lblTimeAnser.Text = TimeAnser.ToString();
            tTimeAnser.Start();
            pbTimeAnser.Maximum = TimeAnser;
            pbTimeAnser.Value = TimeAnser;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeAnser--;
            lblTimeAnser.Text = TimeAnser.ToString();
            pbTimeAnser.Value = TimeAnser;
            if (TimeAnser == 0)
            {
                tTimeAnser.Stop();
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer("Resources\\kol.wav");
                sp.Play();
            }
        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            tTimeAnser.Stop();
        }

        private void lblShowAnser_Click(object sender, EventArgs e)
        {
            lblShowAnser.Text = Victorina.answer;
        }

        private void lblAnswer2_Click(object sender, EventArgs e)
        {
            var mp3File = TagLib.File.Create(Victorina.answer2);
            
            lblAnswer2.Text = mp3File.Tag.FirstAlbumArtist + " - " + mp3File.Tag.Title;
        }
    }
}
