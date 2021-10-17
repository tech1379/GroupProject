using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace Team3
{
    class HelperMp3
    {
        public HelperMp3()
        {
            try
            {

                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                wplayer.URL = "runningdownadream.mp3";
                wplayer.settings.setMode("loop", true);
                wplayer.controls.play();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No music. Windows Media Player not installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
