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
    public partial class fSettings : Form
    {
        
        public fSettings()
        {
            InitializeComponent();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Victorina.allDirectoris = cbFolderCheck.Checked;
            Victorina.GameDuration = Convert.ToInt32(cbGameDuration.Text);
            Victorina.MusicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Victorina.RandomPlay = cbRandom.Checked;
            Victorina.WriteParam();
            this.Hide();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }
        void Set()
        {
            cbGameDuration.Text = Victorina.GameDuration.ToString();
            cbMusicDuration.Text = Victorina.MusicDuration.ToString();
            cbFolderCheck.Checked = Victorina.allDirectoris;
            cbRandom.Checked = Victorina.RandomPlay;
      
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] list = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbFolderCheck.Checked ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = fbd.SelectedPath;
                lbMusicList.Items.Clear();
                lbMusicList.Items.AddRange(list);
                Victorina.mList.Clear();
                Victorina.mList.AddRange(list);
            };
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            Set();
            lbMusicList.Items.Clear();
            lbMusicList.Items.AddRange(Victorina.mList.ToArray());
        }
    }
}
