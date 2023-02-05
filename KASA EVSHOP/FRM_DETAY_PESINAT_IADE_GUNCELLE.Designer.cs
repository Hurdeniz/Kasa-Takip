namespace KASA_EVSHOP
{
    partial class FRM_DETAY_PESINAT_IADE_GUNCELLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DETAY_PESINAT_IADE_GUNCELLE));
            this.txt_senet_no = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.date_tarih = new DevExpress.XtraEditors.DateEdit();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_islem_tutari = new DevExpress.XtraEditors.TextEdit();
            this.txt_musteri_kodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_iade_tutari = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_senet_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_islem_tutari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iade_tutari.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_senet_no
            // 
            this.txt_senet_no.EditValue = "0";
            this.txt_senet_no.Location = new System.Drawing.Point(219, 88);
            this.txt_senet_no.Name = "txt_senet_no";
            this.txt_senet_no.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_senet_no.Properties.Appearance.Options.UseFont = true;
            this.txt_senet_no.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_senet_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_senet_no.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_senet_no.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_senet_no.Size = new System.Drawing.Size(255, 32);
            this.txt_senet_no.TabIndex = 95;
            this.txt_senet_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_senet_no_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl3.Location = new System.Drawing.Point(8, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(205, 25);
            this.labelControl3.TabIndex = 101;
            this.labelControl3.Text = "SENET NUMARASI :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(48, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(165, 25);
            this.labelControl2.TabIndex = 100;
            this.labelControl2.Text = "İŞLEM TARİHİ :";
            // 
            // date_tarih
            // 
            this.date_tarih.EditValue = null;
            this.date_tarih.Location = new System.Drawing.Point(219, 12);
            this.date_tarih.Name = "date_tarih";
            this.date_tarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_tarih.Properties.Appearance.Options.UseFont = true;
            this.date_tarih.Properties.Appearance.Options.UseTextOptions = true;
            this.date_tarih.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.date_tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_tarih.Properties.Mask.EditMask = "99.99.0000";
            this.date_tarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.date_tarih.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_tarih.Size = new System.Drawing.Size(255, 32);
            this.date_tarih.TabIndex = 93;
            this.date_tarih.TabStop = false;
            this.date_tarih.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_tarih_KeyDown);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageIndex = 0;
            this.btn_kaydet.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(260, 204);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(157, 46);
            this.btn_kaydet.TabIndex = 97;
            this.btn_kaydet.TabStop = false;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "icons8_save_125px_19.png");
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(45, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(168, 25);
            this.labelControl4.TabIndex = 99;
            this.labelControl4.Text = "İŞLEM TUTARI :";
            // 
            // txt_islem_tutari
            // 
            this.txt_islem_tutari.EditValue = "0 ₺";
            this.txt_islem_tutari.Location = new System.Drawing.Point(219, 126);
            this.txt_islem_tutari.Name = "txt_islem_tutari";
            this.txt_islem_tutari.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_islem_tutari.Properties.Appearance.Options.UseFont = true;
            this.txt_islem_tutari.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_islem_tutari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_islem_tutari.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_islem_tutari.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_islem_tutari.Properties.Mask.EditMask = "c";
            this.txt_islem_tutari.Size = new System.Drawing.Size(255, 32);
            this.txt_islem_tutari.TabIndex = 96;
            this.txt_islem_tutari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_islem_tutari_KeyDown);
            // 
            // txt_musteri_kodu
            // 
            this.txt_musteri_kodu.EditValue = "0";
            this.txt_musteri_kodu.Location = new System.Drawing.Point(219, 50);
            this.txt_musteri_kodu.Name = "txt_musteri_kodu";
            this.txt_musteri_kodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteri_kodu.Properties.Appearance.Options.UseFont = true;
            this.txt_musteri_kodu.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_musteri_kodu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_musteri_kodu.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_musteri_kodu.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_musteri_kodu.Size = new System.Drawing.Size(255, 32);
            this.txt_musteri_kodu.TabIndex = 94;
            this.txt_musteri_kodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_musteri_kodu_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(31, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(182, 25);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "MÜŞTERİ KODU :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(59, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(154, 25);
            this.labelControl5.TabIndex = 103;
            this.labelControl5.Text = "İADE TUTARI :";
            // 
            // txt_iade_tutari
            // 
            this.txt_iade_tutari.EditValue = "0 ₺";
            this.txt_iade_tutari.Location = new System.Drawing.Point(219, 164);
            this.txt_iade_tutari.Name = "txt_iade_tutari";
            this.txt_iade_tutari.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_iade_tutari.Properties.Appearance.Options.UseFont = true;
            this.txt_iade_tutari.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_iade_tutari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_iade_tutari.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_iade_tutari.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_iade_tutari.Properties.Mask.EditMask = "c";
            this.txt_iade_tutari.Size = new System.Drawing.Size(255, 32);
            this.txt_iade_tutari.TabIndex = 102;
            this.txt_iade_tutari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_iade_tutari_KeyDown);
            // 
            // FRM_DETAY_PESINAT_IADE_GUNCELLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 262);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_iade_tutari);
            this.Controls.Add(this.txt_senet_no);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.date_tarih);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_islem_tutari);
            this.Controls.Add(this.txt_musteri_kodu);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FRM_DETAY_PESINAT_IADE_GUNCELLE";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEŞİNAT İADE GÜNCELLE";
            this.Load += new System.EventHandler(this.FRM_DETAY_PESINAT_IADE_GUNCELLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_senet_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_islem_tutari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iade_tutari.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_senet_no;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit date_tarih;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_islem_tutari;
        private DevExpress.XtraEditors.TextEdit txt_musteri_kodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_iade_tutari;
    }
}