namespace KASA_EVSHOP
{
    partial class FRM_PESINAT_AL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PESINAT_AL));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_tarih = new DevExpress.XtraEditors.LabelControl();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tutar = new DevExpress.XtraEditors.TextEdit();
            this.txt_musteri_kodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_senet_no = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_senet_no.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.Location = new System.Drawing.Point(116, 128);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(63, 13);
            this.lbl_tarih.TabIndex = 86;
            this.lbl_tarih.Text = "labelControl2";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageIndex = 0;
            this.btn_kaydet.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(554, 205);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(174, 55);
            this.btn_kaydet.TabIndex = 4;
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
            this.labelControl4.Location = new System.Drawing.Point(307, 159);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(194, 25);
            this.labelControl4.TabIndex = 85;
            this.labelControl4.Text = "PEŞİNAT TUTARI :";
            // 
            // txt_tutar
            // 
            this.txt_tutar.EditValue = "0 ₺";
            this.txt_tutar.Location = new System.Drawing.Point(507, 156);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_tutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_tutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tutar.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_tutar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tutar.Properties.Mask.EditMask = "c";
            this.txt_tutar.Size = new System.Drawing.Size(255, 32);
            this.txt_tutar.TabIndex = 3;
            this.txt_tutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tutar_KeyDown);
            // 
            // txt_musteri_kodu
            // 
            this.txt_musteri_kodu.EditValue = "0";
            this.txt_musteri_kodu.Location = new System.Drawing.Point(507, 80);
            this.txt_musteri_kodu.Name = "txt_musteri_kodu";
            this.txt_musteri_kodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteri_kodu.Properties.Appearance.Options.UseFont = true;
            this.txt_musteri_kodu.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_musteri_kodu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_musteri_kodu.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_musteri_kodu.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_musteri_kodu.Size = new System.Drawing.Size(255, 32);
            this.txt_musteri_kodu.TabIndex = 1;
            this.txt_musteri_kodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_musteri_kodu_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(319, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(182, 25);
            this.labelControl1.TabIndex = 84;
            this.labelControl1.Text = "MÜŞTERİ KODU :";
            // 
            // txt_senet_no
            // 
            this.txt_senet_no.EditValue = "0";
            this.txt_senet_no.Location = new System.Drawing.Point(507, 118);
            this.txt_senet_no.Name = "txt_senet_no";
            this.txt_senet_no.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_senet_no.Properties.Appearance.Options.UseFont = true;
            this.txt_senet_no.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_senet_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_senet_no.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_senet_no.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_senet_no.Size = new System.Drawing.Size(255, 32);
            this.txt_senet_no.TabIndex = 2;
            this.txt_senet_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_senet_no_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(381, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 25);
            this.labelControl2.TabIndex = 89;
            this.labelControl2.Text = "SENET NO :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_PESINAT_AL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 372);
            this.Controls.Add(this.txt_senet_no);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.txt_musteri_kodu);
            this.Controls.Add(this.labelControl1);
            this.Name = "FRM_PESINAT_AL";
            this.Text = "PEŞİNAT ÖDEMESİ";
            this.Load += new System.EventHandler(this.FRM_PESINAT_AL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_senet_no.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lbl_tarih;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_tutar;
        private DevExpress.XtraEditors.TextEdit txt_musteri_kodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_senet_no;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private System.Windows.Forms.Timer timer1;
    }
}