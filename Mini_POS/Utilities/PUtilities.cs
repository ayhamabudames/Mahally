using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Mini_POS.Utilities
{
    public class PUtilities
    {
        static string sfxPath = @"D:\_Root\Work\Mini-POS & Inventory System\SFX\";
        public static string invoicePath = @"D:\_Root\Work\Mini-POS & Inventory System\Invoices\";
        public static string logoPath = @"D:\_Root\Work\Mini-POS & Inventory System\Images\logo-no-bg.png";
        public static frmMain MainFormInstance = null;
        public static void PlaySFX(string sfxName)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = sfxPath + sfxName;
            player.Play();
        }

        public static void ShowNot(string title, string content, float seconds, bool red = false)
        {
            PUtilities.MainFormInstance.ShowNotification(title, content, (seconds * 1000), red);
            if (red)
            {
                PlaySFX("fail.wav");
            }
            else
            {
                PlaySFX("success.wav");
            }
        }
    }

}
