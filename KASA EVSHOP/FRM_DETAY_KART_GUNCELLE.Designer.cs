namespace KASA_EVSHOP
{
    partial class FRM_DETAY_KART_GUNCELLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DETAY_KART_GUNCELLE));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_garanti = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.date_tarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_yapikredi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_finansbank = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_is_bankasi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_halkbank = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_akbank = new DevExpress.XtraEditors.TextEdit();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_garanti.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yapikredi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_finansbank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_is_bankasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_halkbank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_akbank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(68, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(112, 25);
            this.labelControl4.TabIndex = 83;
            this.labelControl4.Text = "GARANTİ :";
            // 
            // txt_garanti
            // 
            this.txt_garanti.EditValue = "0 ₺";
            this.txt_garanti.Location = new System.Drawing.Point(186, 50);
            this.txt_garanti.Name = "txt_garanti";
            this.txt_garanti.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_garanti.Properties.Appearance.Options.UseFont = true;
            this.txt_garanti.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_garanti.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_garanti.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_garanti.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_garanti.Properties.Mask.EditMask = "c";
            this.txt_garanti.Size = new System.Drawing.Size(255, 32);
            this.txt_garanti.TabIndex = 1;
            this.txt_garanti.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_garanti_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(15, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(165, 25);
            this.labelControl2.TabIndex = 85;
            this.labelControl2.Text = "İŞLEM TARİHİ :";
            // 
            // date_tarih
            // 
            this.date_tarih.EditValue = null;
            this.date_tarih.Location = new System.Drawing.Point(186, 12);
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
            this.date_tarih.TabIndex = 84;
            this.date_tarih.TabStop = false;
            this.date_tarih.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_tarih_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 91);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 25);
            this.labelControl1.TabIndex = 87;
            this.labelControl1.Text = "YAPIKREDİ :";
            // 
            // txt_yapikredi
            // 
            this.txt_yapikredi.EditValue = "0 ₺";
            this.txt_yapikredi.Location = new System.Drawing.Point(186, 88);
            this.txt_yapikredi.Name = "txt_yapikredi";
            this.txt_yapikredi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yapikredi.Properties.Appearance.Options.UseFont = true;
            this.txt_yapikredi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_yapikredi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_yapikredi.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_yapikredi.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_yapikredi.Properties.Mask.EditMask = "c";
            this.txt_yapikredi.Size = new System.Drawing.Size(255, 32);
            this.txt_yapikredi.TabIndex = 2;
            this.txt_yapikredi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_yapikredi_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(154, 25);
            this.labelControl3.TabIndex = 89;
            this.labelControl3.Text = "FİNANSBANK :";
            // 
            // txt_finansbank
            // 
            this.txt_finansbank.EditValue = "0 ₺";
            this.txt_finansbank.Location = new System.Drawing.Point(186, 126);
            this.txt_finansbank.Name = "txt_finansbank";
            this.txt_finansbank.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_finansbank.Properties.Appearance.Options.UseFont = true;
            this.txt_finansbank.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_finansbank.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_finansbank.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_finansbank.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_finansbank.Properties.Mask.EditMask = "c";
            this.txt_finansbank.Size = new System.Drawing.Size(255, 32);
            this.txt_finansbank.TabIndex = 3;
            this.txt_finansbank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_finansbank_KeyDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(41, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(139, 25);
            this.labelControl5.TabIndex = 91;
            this.labelControl5.Text = "İŞ BANKASI :";
            // 
            // txt_is_bankasi
            // 
            this.txt_is_bankasi.EditValue = "0 ₺";
            this.txt_is_bankasi.Location = new System.Drawing.Point(186, 164);
            this.txt_is_bankasi.Name = "txt_is_bankasi";
            this.txt_is_bankasi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_is_bankasi.Properties.Appearance.Options.UseFont = true;
            this.txt_is_bankasi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_is_bankasi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_is_bankasi.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_is_bankasi.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_is_bankasi.Properties.Mask.EditMask = "c";
            this.txt_is_bankasi.Size = new System.Drawing.Size(255, 32);
            this.txt_is_bankasi.TabIndex = 4;
            this.txt_is_bankasi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_is_bankasi_KeyDown);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(50, 205);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(130, 25);
            this.labelControl6.TabIndex = 93;
            this.labelControl6.Text = "HALKBANK :";
            // 
            // txt_halkbank
            // 
            this.txt_halkbank.EditValue = "0 ₺";
            this.txt_halkbank.Location = new System.Drawing.Point(186, 202);
            this.txt_halkbank.Name = "txt_halkbank";
            this.txt_halkbank.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_halkbank.Properties.Appearance.Options.UseFont = true;
            this.txt_halkbank.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_halkbank.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_halkbank.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_halkbank.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_halkbank.Properties.Mask.EditMask = "c";
            this.txt_halkbank.Size = new System.Drawing.Size(255, 32);
            this.txt_halkbank.TabIndex = 5;
            this.txt_halkbank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_halkbank_KeyDown);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(78, 243);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(102, 25);
            this.labelControl7.TabIndex = 95;
            this.labelControl7.Text = "AKBANK :";
            // 
            // txt_akbank
            // 
            this.txt_akbank.EditValue = "0 ₺";
            this.txt_akbank.Location = new System.Drawing.Point(186, 240);
            this.txt_akbank.Name = "txt_akbank";
            this.txt_akbank.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_akbank.Properties.Appearance.Options.UseFont = true;
            this.txt_akbank.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_akbank.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_akbank.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_akbank.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_akbank.Properties.Mask.EditMask = "c";
            this.txt_akbank.Size = new System.Drawing.Size(255, 32);
            this.txt_akbank.TabIndex = 6;
            this.txt_akbank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_akbank_KeyDown);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageIndex = 0;
            this.btn_kaydet.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(243, 282);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(157, 46);
            this.btn_kaydet.TabIndex = 96;
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
            // FRM_DETAY_KART_GUNCELLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 340);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txt_akbank);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_halkbank);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_is_bankasi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_finansbank);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_yapikredi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.date_tarih);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_garanti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FRM_DETAY_KART_GUNCELLE";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KREDİ KART GÜNCELLE";
            this.Load += new System.EventHandler(this.FRM_DETAY_KART_GUNCELLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_garanti.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yapikredi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_finansbank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_is_bankasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_halkbank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_akbank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_garanti;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit date_tarih;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_yapikredi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_finansbank;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_is_bankasi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_halkbank;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_akbank;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.Utils.ImageCollection ımageCollection1;
    }
}