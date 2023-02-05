namespace KASA_EVSHOP
{
    partial class FRM_KASA_ACIKLAR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_KASA_ACIKLAR));
            this.panel_tarih = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.cmb_kullanici = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.date_tarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel_guncelle = new DevExpress.XtraEditors.PanelControl();
            this.btn_guncel_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_guncel_tutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_yeni = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ara = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.grid_aciklar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panel_tarih)).BeginInit();
            this.panel_tarih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_kullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_guncelle)).BeginInit();
            this.panel_guncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_guncel_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_aciklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_tarih
            // 
            this.panel_tarih.Controls.Add(this.labelControl3);
            this.panel_tarih.Controls.Add(this.labelControl2);
            this.panel_tarih.Controls.Add(this.btn_kaydet);
            this.panel_tarih.Controls.Add(this.cmb_kullanici);
            this.panel_tarih.Controls.Add(this.labelControl8);
            this.panel_tarih.Controls.Add(this.date_tarih);
            this.panel_tarih.Controls.Add(this.labelControl7);
            this.panel_tarih.Controls.Add(this.txt_tutar);
            this.panel_tarih.Controls.Add(this.labelControl1);
            this.panel_tarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tarih.Location = new System.Drawing.Point(0, 0);
            this.panel_tarih.Name = "panel_tarih";
            this.panel_tarih.Size = new System.Drawing.Size(723, 74);
            this.panel_tarih.TabIndex = 22;
            this.panel_tarih.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl3.Location = new System.Drawing.Point(447, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(112, 25);
            this.labelControl3.TabIndex = 77;
            this.labelControl3.Text = "PERSONEL";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(432, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(9, 25);
            this.labelControl2.TabIndex = 142;
            this.labelControl2.Text = "-";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageIndex = 2;
            this.btn_kaydet.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(653, 10);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(61, 55);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "icons8_cancel_125px_3.png");
            this.ımageCollection1.Images.SetKeyName(1, "icons8_search_125px_15.png");
            this.ımageCollection1.Images.SetKeyName(2, "iconfinder_floppy_disk_save_103863.png");
            this.ımageCollection1.Images.SetKeyName(3, "iconfinder_Reload_money_3387293.png");
            this.ımageCollection1.Images.SetKeyName(4, "iconfinder_custom-reports_63120.png");
            // 
            // cmb_kullanici
            // 
            this.cmb_kullanici.Location = new System.Drawing.Point(447, 33);
            this.cmb_kullanici.Name = "cmb_kullanici";
            this.cmb_kullanici.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kullanici.Properties.Appearance.Options.UseFont = true;
            this.cmb_kullanici.Properties.Appearance.Options.UseTextOptions = true;
            this.cmb_kullanici.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_kullanici.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_kullanici.Size = new System.Drawing.Size(200, 32);
            this.cmb_kullanici.TabIndex = 2;
            this.cmb_kullanici.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_kullanici_KeyDown);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(211, 36);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(9, 25);
            this.labelControl8.TabIndex = 141;
            this.labelControl8.Text = "-";
            // 
            // date_tarih
            // 
            this.date_tarih.EditValue = null;
            this.date_tarih.Location = new System.Drawing.Point(5, 33);
            this.date_tarih.Name = "date_tarih";
            this.date_tarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_tarih.Properties.Appearance.Options.UseFont = true;
            this.date_tarih.Properties.Appearance.Options.UseTextOptions = true;
            this.date_tarih.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.date_tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_tarih.Properties.Mask.EditMask = "99.99.0000";
            this.date_tarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.date_tarih.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_tarih.Size = new System.Drawing.Size(200, 32);
            this.date_tarih.TabIndex = 137;
            this.date_tarih.TabStop = false;
            this.date_tarih.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_tarih_KeyDown);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 25);
            this.labelControl7.TabIndex = 136;
            this.labelControl7.Text = "TARİH";
            // 
            // txt_tutar
            // 
            this.txt_tutar.EditValue = "";
            this.txt_tutar.Location = new System.Drawing.Point(226, 33);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_tutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_tutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tutar.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_tutar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tutar.Size = new System.Drawing.Size(200, 32);
            this.txt_tutar.TabIndex = 1;
            this.txt_tutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tutar_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(226, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 25);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "TUTAR";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel_guncelle);
            this.panelControl1.Controls.Add(this.btn_guncelle);
            this.panelControl1.Controls.Add(this.btn_yeni);
            this.panelControl1.Controls.Add(this.btn_ara);
            this.panelControl1.Controls.Add(this.btn_sil);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(562, 74);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(161, 397);
            this.panelControl1.TabIndex = 23;
            // 
            // panel_guncelle
            // 
            this.panel_guncelle.Controls.Add(this.btn_guncel_kaydet);
            this.panel_guncelle.Controls.Add(this.txt_guncel_tutar);
            this.panel_guncelle.Controls.Add(this.labelControl4);
            this.panel_guncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_guncelle.Location = new System.Drawing.Point(2, 261);
            this.panel_guncelle.Name = "panel_guncelle";
            this.panel_guncelle.Size = new System.Drawing.Size(157, 134);
            this.panel_guncelle.TabIndex = 8;
            this.panel_guncelle.Visible = false;
            // 
            // btn_guncel_kaydet
            // 
            this.btn_guncel_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncel_kaydet.Appearance.Options.UseFont = true;
            this.btn_guncel_kaydet.ImageIndex = 2;
            this.btn_guncel_kaydet.ImageList = this.ımageCollection1;
            this.btn_guncel_kaydet.Location = new System.Drawing.Point(50, 74);
            this.btn_guncel_kaydet.Name = "btn_guncel_kaydet";
            this.btn_guncel_kaydet.Size = new System.Drawing.Size(61, 55);
            this.btn_guncel_kaydet.TabIndex = 143;
            this.btn_guncel_kaydet.TabStop = false;
            this.btn_guncel_kaydet.Click += new System.EventHandler(this.btn_guncel_kaydet_Click);
            // 
            // txt_guncel_tutar
            // 
            this.txt_guncel_tutar.EditValue = "";
            this.txt_guncel_tutar.Location = new System.Drawing.Point(5, 36);
            this.txt_guncel_tutar.Name = "txt_guncel_tutar";
            this.txt_guncel_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_guncel_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_guncel_tutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_guncel_tutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_guncel_tutar.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_guncel_tutar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_guncel_tutar.Size = new System.Drawing.Size(150, 32);
            this.txt_guncel_tutar.TabIndex = 77;
            this.txt_guncel_tutar.TabStop = false;
            this.txt_guncel_tutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_guncel_tutar_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl4.Location = new System.Drawing.Point(4, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 25);
            this.labelControl4.TabIndex = 78;
            this.labelControl4.Text = "TUTAR";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Appearance.Options.UseFont = true;
            this.btn_guncelle.ImageIndex = 4;
            this.btn_guncelle.ImageList = this.ımageCollection1;
            this.btn_guncelle.Location = new System.Drawing.Point(7, 126);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(149, 54);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_yeni
            // 
            this.btn_yeni.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeni.Appearance.Options.UseFont = true;
            this.btn_yeni.ImageIndex = 3;
            this.btn_yeni.ImageList = this.ımageCollection1;
            this.btn_yeni.Location = new System.Drawing.Point(7, 6);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(149, 54);
            this.btn_yeni.TabIndex = 10;
            this.btn_yeni.Text = "YENİ";
            this.btn_yeni.Click += new System.EventHandler(this.btn_yeni_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.Appearance.Options.UseFont = true;
            this.btn_ara.ImageIndex = 1;
            this.btn_ara.ImageList = this.ımageCollection1;
            this.btn_ara.Location = new System.Drawing.Point(7, 186);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(149, 54);
            this.btn_ara.TabIndex = 13;
            this.btn_ara.Text = "ARA";
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Appearance.Options.UseFont = true;
            this.btn_sil.ImageIndex = 0;
            this.btn_sil.ImageList = this.ımageCollection1;
            this.btn_sil.Location = new System.Drawing.Point(7, 66);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(149, 54);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // grid_aciklar
            // 
            this.grid_aciklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_aciklar.Location = new System.Drawing.Point(0, 74);
            this.grid_aciklar.MainView = this.gridView1;
            this.grid_aciklar.Name = "grid_aciklar";
            this.grid_aciklar.Size = new System.Drawing.Size(562, 397);
            this.grid_aciklar.TabIndex = 24;
            this.grid_aciklar.TabStop = false;
            this.grid_aciklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.GridControl = this.grid_aciklar;
            this.gridView1.GroupPanelText = "PERSONEL KASA AÇIKLARI";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // FRM_KASA_ACIKLAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 471);
            this.Controls.Add(this.grid_aciklar);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel_tarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_KASA_ACIKLAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KASA AÇIKLARI";
            this.Load += new System.EventHandler(this.FRM_KASA_ACIKLAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel_tarih)).EndInit();
            this.panel_tarih.ResumeLayout(false);
            this.panel_tarih.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_kullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_guncelle)).EndInit();
            this.panel_guncelle.ResumeLayout(false);
            this.panel_guncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_guncel_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_aciklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel_tarih;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_yeni;
        private DevExpress.XtraEditors.SimpleButton btn_ara;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.TextEdit txt_tutar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit date_tarih;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_kullanici;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraGrid.GridControl grid_aciklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panel_guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_guncel_kaydet;
        private DevExpress.XtraEditors.TextEdit txt_guncel_tutar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
    }
}