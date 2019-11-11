using System;
using System.Windows.Forms;
using MustiYazilim.OgrenciTakip.UI.Win.GenelForms;

namespace MustiYazilim.OgrenciTakip.UI.Win
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaForm());
        }
    }
}
