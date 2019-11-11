﻿using DevExpress.XtraEditors;
using System.Drawing;
using MustiYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace MustiYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCheckedComboBoxEdit : CheckedComboBoxEdit, IStatusBarKisaYol
    {
        public MyCheckedComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
    }
}
