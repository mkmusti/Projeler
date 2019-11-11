namespace MustiYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    partial class OkulKartlari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.longNavigtor1 = new MustiYazilim.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigtor();
            this.grid = new MustiYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.table = new MustiYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colId = new MustiYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKod = new MustiYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colOkulAdi = new MustiYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIl = new MustiYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIlce = new MustiYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAciklama = new MustiYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // longNavigtor1
            // 
            this.longNavigtor1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigtor1.Location = new System.Drawing.Point(0, 393);
            this.longNavigtor1.Name = "longNavigtor1";
            this.longNavigtor1.Size = new System.Drawing.Size(902, 24);
            this.longNavigtor1.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 104);
            this.grid.MainView = this.table;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(902, 289);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.table});
            // 
            // table
            // 
            this.table.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.table.Appearance.FooterPanel.Options.UseFont = true;
            this.table.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.table.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.table.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.table.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.table.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.table.Appearance.ViewCaption.Options.UseForeColor = true;
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKod,
            this.colOkulAdi,
            this.colIl,
            this.colIlce,
            this.colAciklama});
            this.table.GridControl = this.grid;
            this.table.Name = "table";
            this.table.OptionsMenu.EnableColumnMenu = false;
            this.table.OptionsMenu.EnableFooterMenu = false;
            this.table.OptionsMenu.EnableGroupPanelMenu = false;
            this.table.OptionsNavigation.EnterMoveNextColumn = true;
            this.table.OptionsPrint.AutoWidth = false;
            this.table.OptionsPrint.PrintFooter = false;
            this.table.OptionsPrint.PrintGroupFooter = false;
            this.table.OptionsView.ColumnAutoWidth = false;
            this.table.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.table.OptionsView.RowAutoHeight = true;
            this.table.OptionsView.ShowAutoFilterRow = true;
            this.table.OptionsView.ShowGroupPanel = false;
            this.table.OptionsView.ShowViewCaption = true;
            this.table.StatusBarAciklama = null;
            this.table.StatusBarKisaYol = null;
            this.table.StatusBarKisaYolAciklama = null;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 110;
            // 
            // colOkulAdi
            // 
            this.colOkulAdi.Caption = "Okul Adı ";
            this.colOkulAdi.FieldName = "OkulAdi";
            this.colOkulAdi.Name = "colOkulAdi";
            this.colOkulAdi.OptionsColumn.AllowEdit = false;
            this.colOkulAdi.StatusBarAciklama = null;
            this.colOkulAdi.StatusBarKisaYol = null;
            this.colOkulAdi.StatusBarKisaYolAciklama = null;
            this.colOkulAdi.Visible = true;
            this.colOkulAdi.VisibleIndex = 1;
            this.colOkulAdi.Width = 260;
            // 
            // colIl
            // 
            this.colIl.Caption = "İl";
            this.colIl.FieldName = "IlAdi";
            this.colIl.Name = "colIl";
            this.colIl.OptionsColumn.AllowEdit = false;
            this.colIl.StatusBarAciklama = null;
            this.colIl.StatusBarKisaYol = null;
            this.colIl.StatusBarKisaYolAciklama = null;
            this.colIl.Visible = true;
            this.colIl.VisibleIndex = 2;
            this.colIl.Width = 130;
            // 
            // colIlce
            // 
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "IlceAdi";
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            this.colIlce.StatusBarAciklama = null;
            this.colIlce.StatusBarKisaYol = null;
            this.colIlce.StatusBarKisaYolAciklama = null;
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 3;
            this.colIlce.Width = 130;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Aciklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 450;
            // 
            // OkulKartlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 448);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigtor1);
            this.Name = "OkulKartlari";
            this.Text = "Okul Kartları";
            this.Controls.SetChildIndex(this.longNavigtor1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigtor longNavigtor1;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView table;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Grid.MyGridColumn colOkulAdi;
        private UserControls.Grid.MyGridColumn colIl;
        private UserControls.Grid.MyGridColumn colIlce;
        private UserControls.Grid.MyGridColumn colAciklama;
    }
}