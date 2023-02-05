namespace KASA_EVSHOP
{
    partial class FRM_PERSONELLER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PERSONELLER));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_maaslar = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btn_cikislar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cikis_ver = new DevExpress.XtraEditors.SimpleButton();
            this.btn_yenile = new DevExpress.XtraEditors.SimpleButton();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_yeni = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ara = new DevExpress.XtraEditors.SimpleButton();
            this.btn_excel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.grid_taksit = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_taksit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_maaslar);
            this.panelControl1.Controls.Add(this.btn_cikislar);
            this.panelControl1.Controls.Add(this.btn_cikis_ver);
            this.panelControl1.Controls.Add(this.btn_yenile);
            this.panelControl1.Controls.Add(this.btn_guncelle);
            this.panelControl1.Controls.Add(this.btn_yeni);
            this.panelControl1.Controls.Add(this.btn_ara);
            this.panelControl1.Controls.Add(this.btn_excel);
            this.panelControl1.Controls.Add(this.btn_sil);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(1219, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(161, 657);
            this.panelControl1.TabIndex = 14;
            // 
            // btn_maaslar
            // 
            this.btn_maaslar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_maaslar.Appearance.Options.UseFont = true;
            this.btn_maaslar.ImageIndex = 8;
            this.btn_maaslar.ImageList = this.ımageCollection1;
            this.btn_maaslar.Location = new System.Drawing.Point(5, 492);
            this.btn_maaslar.Name = "btn_maaslar";
            this.btn_maaslar.Size = new System.Drawing.Size(149, 54);
            this.btn_maaslar.TabIndex = 9;
            this.btn_maaslar.Text = "ÜCRETLER";
            this.btn_maaslar.Click += new System.EventHandler(this.btn_maaslar_Click);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "1383579721_network_add.png");
            this.ımageCollection1.Images.SetKeyName(1, "icons8_cancel_125px_3.png");
            this.ımageCollection1.Images.SetKeyName(2, "icons8_edit_125px_3.png");
            this.ımageCollection1.Images.SetKeyName(3, "icons8_search_125px_15.png");
            this.ımageCollection1.Images.SetKeyName(4, "icons8_ms_excel_125px_16.png");
            this.ımageCollection1.Images.SetKeyName(5, "iconfinder_view-refresh_118801.png");
            this.ımageCollection1.Images.SetKeyName(6, "1383579709_network.png");
            this.ımageCollection1.Images.SetKeyName(7, "1383579797_mypc_close.png");
            this.ımageCollection1.Images.SetKeyName(8, "iconfinder_Money_10998.png");
            // 
            // btn_cikislar
            // 
            this.btn_cikislar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikislar.Appearance.Options.UseFont = true;
            this.btn_cikislar.ImageIndex = 6;
            this.btn_cikislar.ImageList = this.ımageCollection1;
            this.btn_cikislar.Location = new System.Drawing.Point(5, 432);
            this.btn_cikislar.Name = "btn_cikislar";
            this.btn_cikislar.Size = new System.Drawing.Size(149, 54);
            this.btn_cikislar.TabIndex = 8;
            this.btn_cikislar.Text = "ÇIKIŞLAR";
            this.btn_cikislar.Click += new System.EventHandler(this.btn_cikislar_Click);
            // 
            // btn_cikis_ver
            // 
            this.btn_cikis_ver.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis_ver.Appearance.Options.UseFont = true;
            this.btn_cikis_ver.ImageIndex = 7;
            this.btn_cikis_ver.ImageList = this.ımageCollection1;
            this.btn_cikis_ver.Location = new System.Drawing.Point(5, 372);
            this.btn_cikis_ver.Name = "btn_cikis_ver";
            this.btn_cikis_ver.Size = new System.Drawing.Size(149, 54);
            this.btn_cikis_ver.TabIndex = 7;
            this.btn_cikis_ver.Text = "ÇIKIŞ VER";
            this.btn_cikis_ver.Click += new System.EventHandler(this.btn_cikis_ver_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yenile.Appearance.Options.UseFont = true;
            this.btn_yenile.ImageIndex = 5;
            this.btn_yenile.ImageList = this.ımageCollection1;
            this.btn_yenile.Location = new System.Drawing.Point(5, 312);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(149, 54);
            this.btn_yenile.TabIndex = 6;
            this.btn_yenile.Text = "YENİLE";
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Appearance.Options.UseFont = true;
            this.btn_guncelle.ImageIndex = 2;
            this.btn_guncelle.ImageList = this.ımageCollection1;
            this.btn_guncelle.Location = new System.Drawing.Point(5, 132);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(149, 54);
            this.btn_guncelle.TabIndex = 3;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_yeni
            // 
            this.btn_yeni.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeni.Appearance.Options.UseFont = true;
            this.btn_yeni.ImageIndex = 0;
            this.btn_yeni.ImageList = this.ımageCollection1;
            this.btn_yeni.Location = new System.Drawing.Point(5, 12);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(149, 54);
            this.btn_yeni.TabIndex = 1;
            this.btn_yeni.Text = "YENİ";
            this.btn_yeni.Click += new System.EventHandler(this.btn_yeni_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.Appearance.Options.UseFont = true;
            this.btn_ara.ImageIndex = 3;
            this.btn_ara.ImageList = this.ımageCollection1;
            this.btn_ara.Location = new System.Drawing.Point(5, 192);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(149, 54);
            this.btn_ara.TabIndex = 4;
            this.btn_ara.Text = "ARA";
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_excel.Appearance.Options.UseFont = true;
            this.btn_excel.ImageIndex = 4;
            this.btn_excel.ImageList = this.ımageCollection1;
            this.btn_excel.Location = new System.Drawing.Point(5, 252);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(149, 54);
            this.btn_excel.TabIndex = 5;
            this.btn_excel.Text = "EXCEL";
            // 
            // btn_sil
            // 
            this.btn_sil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Appearance.Options.UseFont = true;
            this.btn_sil.ImageIndex = 1;
            this.btn_sil.ImageList = this.ımageCollection1;
            this.btn_sil.Location = new System.Drawing.Point(5, 72);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(149, 54);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // grid_taksit
            // 
            this.grid_taksit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_taksit.Location = new System.Drawing.Point(0, 0);
            this.grid_taksit.MainView = this.gridView1;
            this.grid_taksit.Name = "grid_taksit";
            this.grid_taksit.Size = new System.Drawing.Size(1219, 657);
            this.grid_taksit.TabIndex = 16;
            this.grid_taksit.TabStop = false;
            this.grid_taksit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.GridControl = this.grid_taksit;
            this.gridView1.GroupPanelText = "PERSONEL LİSTESİ";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // FRM_PERSONELLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 657);
            this.Controls.Add(this.grid_taksit);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_PERSONELLER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONELLER";
            this.Load += new System.EventHandler(this.FRM_PERSONELLER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_taksit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_yeni;
        private DevExpress.XtraEditors.SimpleButton btn_ara;
        private DevExpress.XtraEditors.SimpleButton btn_excel;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraGrid.GridControl grid_taksit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.SimpleButton btn_yenile;
        private DevExpress.XtraEditors.SimpleButton btn_cikislar;
        private DevExpress.XtraEditors.SimpleButton btn_cikis_ver;
        private DevExpress.XtraEditors.SimpleButton btn_maaslar;
    }
}