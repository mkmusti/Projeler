using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Drawing;
using System.ComponentModel;
using MustiYazilim.OgrenciTakip.UI.Win.Interfaces;

namespace MustiYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyToogleSwitch : ToggleSwitch, IStatusBarAciklama
    {
        public MyToogleSwitch()
        {
            Name = "tglDurum";
            Properties.OnText = "Aktif";
            Properties.OffText = "Pasif";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; } = "Kartın Kullanım Durumunu Seçiniz.";
    }
}