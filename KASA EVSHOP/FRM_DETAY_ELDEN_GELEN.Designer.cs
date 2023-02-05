namespace KASA_EVSHOP
{
    partial class FRM_DETAY_ELDEN_GELEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DETAY_ELDEN_GELEN));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txt_tutar = new DevExpress.XtraEditors.TextEdit();
            this.txt_adi_soyadi = new DevExpress.XtraEditors.TextEdit();
            this.txt_musteri_kodu = new DevExpress.XtraEditors.TextEdit();
            this.grid_taksit = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adi_soyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_taksit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_sil);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(1164, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(143, 526);
            this.panelControl1.TabIndex = 15;
            // 
            // btn_sil
            // 
            this.btn_sil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Appearance.Options.UseFont = true;
            this.btn_sil.ImageIndex = 0;
            this.btn_sil.ImageList = this.ımageCollection1;
            this.btn_sil.Location = new System.Drawing.Point(5, 12);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(135, 54);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "icons8_cancel_125px_3.png");
            this.ımageCollection1.Images.SetKeyName(1, "icons8_edit_125px_3.png");
            this.ımageCollection1.Images.SetKeyName(2, "icons8_ms_excel_125px_16.png");
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txt_tutar);
            this.panelControl2.Controls.Add(this.txt_adi_soyadi);
            this.panelControl2.Controls.Add(this.txt_musteri_kodu);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 491);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1164, 35);
            this.panelControl2.TabIndex = 16;
            // 
            // txt_tutar
            // 
            this.txt_tutar.EditValue = "";
            this.txt_tutar.Location = new System.Drawing.Point(621, 5);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_tutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_tutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tutar.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_tutar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tutar.Size = new System.Drawing.Size(207, 26);
            this.txt_tutar.TabIndex = 5;
            // 
            // txt_adi_soyadi
            // 
            this.txt_adi_soyadi.EditValue = "";
            this.txt_adi_soyadi.Location = new System.Drawing.Point(408, 5);
            this.txt_adi_soyadi.Name = "txt_adi_soyadi";
            this.txt_adi_soyadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adi_soyadi.Properties.Appearance.Options.UseFont = true;
            this.txt_adi_soyadi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_adi_soyadi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_adi_soyadi.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_adi_soyadi.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_adi_soyadi.Size = new System.Drawing.Size(207, 26);
            this.txt_adi_soyadi.TabIndex = 4;
            // 
            // txt_musteri_kodu
            // 
            this.txt_musteri_kodu.EditValue = "";
            this.txt_musteri_kodu.Location = new System.Drawing.Point(195, 5);
            this.txt_musteri_kodu.Name = "txt_musteri_kodu";
            this.txt_musteri_kodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteri_kodu.Properties.Appearance.Options.UseFont = true;
            this.txt_musteri_kodu.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_musteri_kodu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_musteri_kodu.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_musteri_kodu.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_musteri_kodu.Size = new System.Drawing.Size(207, 26);
            this.txt_musteri_kodu.TabIndex = 3;
            // 
            // grid_taksit
            // 
            this.grid_taksit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_taksit.Location = new System.Drawing.Point(0, 0);
            this.grid_taksit.MainView = this.gridView1;
            this.grid_taksit.Name = "grid_taksit";
            this.grid_taksit.Size = new System.Drawing.Size(1164, 491);
            this.grid_taksit.TabIndex = 17;
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
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.gridView1.GridControl = this.grid_taksit;
            this.gridView1.GroupPanelText = "ELDEN GELEN İŞLEMLER";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // FRM_DETAY_ELDEN_GELEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 526);
            this.Controls.Add(this.grid_taksit);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_DETAY_ELDEN_GELEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELDEN GELEN";
            this.Load += new System.EventHandler(this.FRM_DETAY_ELDEN_GELEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adi_soyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_taksit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grid_taksit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txt_musteri_kodu;
        private DevExpress.XtraEditors.TextEdit txt_tutar;
        private DevExpress.XtraEditors.TextEdit txt_adi_soyadi;
        private DevExpress.Utils.ImageCollection ımageCollection1;
    }
}