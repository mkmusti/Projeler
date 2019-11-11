using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Drawing;
using MustiYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace MustiYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyCalcEdit : CalcEdit, IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "n2";
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; } = "Hesap Makinesi";
        public string StatusBarAciklama { get ; set; }
    }
}
