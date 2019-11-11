using DevExpress.XtraEditors;
using MustiYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace MustiYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MySimpleButton : SimpleButton, IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MySimpleButton()
        {
            Appearance.ForeColor = Color.Maroon;
        }
        public string StatusBarAciklama { get; set; }
    }
}
