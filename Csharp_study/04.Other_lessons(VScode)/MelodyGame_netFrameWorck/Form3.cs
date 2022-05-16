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
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int MusicDuration = Victorina.MusicDuration;
        bool[] players = new bool[2];

        public fGame()
        {
            InitializeComponent();
        }
        void MakeMusic()
        {
            if (Victorina.mList.Count == 0) GameStop();
            else
            {
                MusicDuration = Victorina.MusicDuration;
                lblMusicDuration.Text = MusicDuration.ToString();
                int n = rnd.Next(0, Victorina.mList.Count);
                WMP.URL = Victorina.mList[n];
                Victorina.answer = System.IO.Path.GetFileNameWithoutExtension(WMP.URL);
                Victorina.answer2 = WMP.URL;
                //WMP.Ctlcontrols.play();
                Victorina.mList.RemoveAt(n);
                lblSongsCount.Text = Victorina.mList.Count.ToString();
                players[0] = false;
                players[1] = false;
            }
        }

        private void ntmNext_Click(object sender, EventArgs e)
        {
            tGameTime.Start();
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            tGameTime.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblSongsCount.Text = Victorina.mList.Count.ToString();
            pbGameRime.Maximum = Victorina.GameDuration;
            pbGameRime.Value = Victorina.GameDuration;
            lblMusicDuration.Text = MusicDuration.ToString();
            Victorina.answer = "";
        }

        private void tGameTime_Tick(object sender, EventArgs e)
        {
            pbGameRime.Value--;
            MusicDuration--;
            lblMusicDuration.Text = MusicDuration.ToString();
            if (pbGameRime.Value == 0)
            {
                GameStop();
                return;
            }
            if (MusicDuration == 0) GamePause();

        }

        void GameStop()
        {
            tGameTime.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        void GamePause()
        {
            tGameTime.Stop();
            WMP.Ctlcontrols.pause();
        }

        void GamePlay()
        {
            tGameTime.Start();
            WMP.Ctlcontrols.play();
        }


        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (tGameTime.Enabled)
            {
                if (players[0] == false && e.KeyData == Keys.A)
                {
                    GamePause();
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer("Resources\\HolyShit.wav");
                    sp.Play();
                    players[0] = true;
                    fMessage fm = new fMessage();
                    fm.lblMessage.Text = "Команда 1";
                    if (fm.ShowDialog() == DialogResult.Yes)
                    {
                        lblPointsTeam1.Text = Convert.ToString(Convert.ToInt32(lblPointsTeam1.Text) + 1);
                        MakeMusic();
                    }
                    GamePlay();
                }
                if (players[1] == false && e.KeyData == Keys.P)
                {
                    GamePause();
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer("Resources\\Combowhore.wav");
                    sp.Play();
                    players[1] = true;
                    fMessage fm = new fMessage();
                    fm.lblMessage.Text = "Команда 2";
                    if (fm.ShowDialog() == DialogResult.Yes)
                    {
                        lblPoitnsTeam2.Text = Convert.ToString(Convert.ToInt32(lblPoitnsTeam2.Text) + 1);
                        MakeMusic();
                    }
                    GamePlay();
                }
            }
            else return;
            
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.RandomPlay)
            {
                if (WMP.openState==WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration / 2);
                }    
            }
        }

        private void lblPointsTeam1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
            if(e.Button == MouseButtons.Right) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
        }

        private void lblPoitnsTeam2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
            if (e.Button == MouseButtons.Right) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
        }

    }
     
}
