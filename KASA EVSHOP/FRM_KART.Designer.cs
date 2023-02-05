namespace KASA_EVSHOP
{
    partial class FRM_KART
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_KART));
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tutar = new DevExpress.XtraEditors.TextEdit();
            this.lbl_tarih = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.check_akbank = new DevExpress.XtraEditors.CheckEdit();
            this.check_halkbank = new DevExpress.XtraEditors.CheckEdit();
            this.check_isbankasi = new DevExpress.XtraEditors.CheckEdit();
            this.check_finansbank = new DevExpress.XtraEditors.CheckEdit();
            this.check_yapikredi = new DevExpress.XtraEditors.CheckEdit();
            this.check_garanti = new DevExpress.XtraEditors.CheckEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_yazi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_akbank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_halkbank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_isbankasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_finansbank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_yapikredi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_garanti.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageIndex = 0;
            this.btn_kaydet.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(364, 143);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(160, 55);
            this.btn_kaydet.TabIndex = 78;
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
            this.labelControl4.Location = new System.Drawing.Point(364, 63);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(160, 25);
            this.labelControl4.TabIndex = 79;
            this.labelControl4.Text = "İŞLEM TUTARI ";
            // 
            // txt_tutar
            // 
            this.txt_tutar.EditValue = "0 ₺";
            this.txt_tutar.Location = new System.Drawing.Point(331, 94);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_tutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_tutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tutar.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_tutar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tutar.Properties.Mask.EditMask = "f";
            this.txt_tutar.Size = new System.Drawing.Size(223, 32);
            this.txt_tutar.TabIndex = 77;
            this.txt_tutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tutar_KeyDown);
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.Location = new System.Drawing.Point(81, 105);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(63, 13);
            this.lbl_tarih.TabIndex = 80;
            this.lbl_tarih.Text = "labelControl1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // check_akbank
            // 
            this.check_akbank.Location = new System.Drawing.Point(587, 205);
            this.check_akbank.Name = "check_akbank";
            this.check_akbank.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_akbank.Properties.Appearance.Options.UseFont = true;
            this.check_akbank.Properties.Caption = "AKBANK";
            this.check_akbank.Size = new System.Drawing.Size(189, 30);
            this.check_akbank.TabIndex = 87;
            this.check_akbank.CheckedChanged += new System.EventHandler(this.check_akbank_CheckedChanged);
            // 
            // check_halkbank
            // 
            this.check_halkbank.Location = new System.Drawing.Point(587, 169);
            this.check_halkbank.Name = "check_halkbank";
            this.check_halkbank.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_halkbank.Properties.Appearance.Options.UseFont = true;
            this.check_halkbank.Properties.Caption = "HALKBANK";
            this.check_halkbank.Size = new System.Drawing.Size(189, 30);
            this.check_halkbank.TabIndex = 86;
            this.check_halkbank.CheckedChanged += new System.EventHandler(this.check_halkbank_CheckedChanged);
            // 
            // check_isbankasi
            // 
            this.check_isbankasi.Location = new System.Drawing.Point(587, 133);
            this.check_isbankasi.Name = "check_isbankasi";
            this.check_isbankasi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_isbankasi.Properties.Appearance.Options.UseFont = true;
            this.check_isbankasi.Properties.Caption = "İŞ BANKASI";
            this.check_isbankasi.Size = new System.Drawing.Size(189, 30);
            this.check_isbankasi.TabIndex = 85;
            this.check_isbankasi.CheckedChanged += new System.EventHandler(this.check_isbankasi_CheckedChanged);
            // 
            // check_finansbank
            // 
            this.check_finansbank.Location = new System.Drawing.Point(587, 97);
            this.check_finansbank.Name = "check_finansbank";
            this.check_finansbank.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_finansbank.Properties.Appearance.Options.UseFont = true;
            this.check_finansbank.Properties.Caption = "FİNANSBANK";
            this.check_finansbank.Size = new System.Drawing.Size(189, 30);
            this.check_finansbank.TabIndex = 84;
            this.check_finansbank.CheckedChanged += new System.EventHandler(this.check_finansbank_CheckedChanged);
            // 
            // check_yapikredi
            // 
            this.check_yapikredi.Location = new System.Drawing.Point(587, 61);
            this.check_yapikredi.Name = "check_yapikredi";
            this.check_yapikredi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_yapikredi.Properties.Appearance.Options.UseFont = true;
            this.check_yapikredi.Properties.Caption = "YAPIKREDİ";
            this.check_yapikredi.Size = new System.Drawing.Size(189, 30);
            this.check_yapikredi.TabIndex = 83;
            this.check_yapikredi.CheckedChanged += new System.EventHandler(this.check_yapikredi_CheckedChanged);
            // 
            // check_garanti
            // 
            this.check_garanti.Location = new System.Drawing.Point(587, 25);
            this.check_garanti.Name = "check_garanti";
            this.check_garanti.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_garanti.Properties.Appearance.Options.UseFont = true;
            this.check_garanti.Properties.Caption = "GARANTİ";
            this.check_garanti.Size = new System.Drawing.Size(189, 30);
            this.check_garanti.TabIndex = 82;
            this.check_garanti.CheckedChanged += new System.EventHandler(this.check_garanti_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_yazi
            // 
            this.lbl_yazi.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazi.Appearance.Options.UseFont = true;
            this.lbl_yazi.Location = new System.Drawing.Point(330, 285);
            this.lbl_yazi.Name = "lbl_yazi";
            this.lbl_yazi.Size = new System.Drawing.Size(354, 25);
            this.lbl_yazi.TabIndex = 89;
            this.lbl_yazi.Text = "BANKA KAYIDINIZ YAPILMISTIR.";
            this.lbl_yazi.Visible = false;
            // 
            // FRM_KART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 372);
            this.Controls.Add(this.lbl_yazi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.check_akbank);
            this.Controls.Add(this.check_halkbank);
            this.Controls.Add(this.check_isbankasi);
            this.Controls.Add(this.check_finansbank);
            this.Controls.Add(this.check_yapikredi);
            this.Controls.Add(this.check_garanti);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_tutar);
            this.Name = "FRM_KART";
            this.Text = "KREDİ KART";
            this.Load += new System.EventHandler(this.FRM_KART_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_akbank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_halkbank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_isbankasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_finansbank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_yapikredi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_garanti.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_tutar;
        private DevExpress.XtraEditors.LabelControl lbl_tarih;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.CheckEdit check_akbank;
        private DevExpress.XtraEditors.CheckEdit check_halkbank;
        private DevExpress.XtraEditors.CheckEdit check_isbankasi;
        private DevExpress.XtraEditors.CheckEdit check_finansbank;
        private DevExpress.XtraEditors.CheckEdit check_yapikredi;
        private DevExpress.XtraEditors.CheckEdit check_garanti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lbl_yazi;
    }
}