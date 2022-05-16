using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyGame_netFrameWorck
{
    static class Victorina
    {
        static public List<string> mList = new List<string>();
        static public int GameDuration = 60;
        static public int MusicDuration = 10;
        static public bool RandomPlay = false;
        static public string lastFolder = "";
        static public bool allDirectoris = false;
        static public string answer = "";
        static public string answer2 = "";

        static public void ReadMusic()
        {
            try
            {
                string[] music_list = System.IO.Directory.GetFiles(lastFolder, "*.mp3", allDirectoris ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly);
                mList.Clear();
                mList.AddRange(music_list);
            }
            catch
            {

            }
        }

        static string regKeyName = "Software\\ImPaniking\\GuessMelody";

        static public void WriteParam()
        {
            Microsoft.Win32.RegistryKey rk = null;
            try
            {
                rk = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("Random", RandomPlay);
                rk.SetValue("GameDuration", GameDuration);
                rk.SetValue("MusicDuration", MusicDuration);
                rk.SetValue("AllDirectories", allDirectoris);

            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
        static public void ReadParam()
        {
            Microsoft.Win32.RegistryKey rk = null;
            try
            {
                rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    RandomPlay = Convert.ToBoolean(rk.GetValue("Random", false));
                    GameDuration = (int)rk.GetValue("GameDuration");
                    MusicDuration = (int)rk.GetValue("MusicDuration");
                    allDirectoris = Convert.ToBoolean(rk.GetValue("AllDirectories", false));
                }
            }
            finally
            {
                if ( rk != null ) rk.Close();
            }
        }
    }
}
