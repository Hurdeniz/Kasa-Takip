namespace KASA_EVSHOP
{
    partial class FRM_PESINAT_IADE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PESINAT_IADE));
            this.txt_senet_no = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_tarih = new DevExpress.XtraEditors.LabelControl();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_islem_tutari = new DevExpress.XtraEditors.TextEdit();
            this.txt_musteri_kodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_iade_tutari = new DevExpress.XtraEditors.TextEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_senet_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_islem_tutari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iade_tutari.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_senet_no
            // 
            this.txt_senet_no.EditValue = "0";
            this.txt_senet_no.Location = new System.Drawing.Point(507, 116);
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
            this.labelControl2.Location = new System.Drawing.Point(381, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 25);
            this.labelControl2.TabIndex = 98;
            this.labelControl2.Text = "SENET NO :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.Location = new System.Drawing.Point(110, 122);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(63, 13);
            this.lbl_tarih.TabIndex = 96;
            this.lbl_tarih.Text = "labelControl2";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageIndex = 0;
            this.btn_kaydet.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(555, 255);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(174, 55);
            this.btn_kaydet.TabIndex = 5;
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
            this.labelControl4.Location = new System.Drawing.Point(333, 157);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(168, 25);
            this.labelControl4.TabIndex = 95;
            this.labelControl4.Text = "İŞLEM TUTARI :";
            // 
            // txt_islem_tutari
            // 
            this.txt_islem_tutari.EditValue = "0 ₺";
            this.txt_islem_tutari.Location = new System.Drawing.Point(507, 154);
            this.txt_islem_tutari.Name = "txt_islem_tutari";
            this.txt_islem_tutari.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_islem_tutari.Properties.Appearance.Options.UseFont = true;
            this.txt_islem_tutari.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_islem_tutari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_islem_tutari.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_islem_tutari.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_islem_tutari.Properties.Mask.EditMask = "c";
            this.txt_islem_tutari.Size = new System.Drawing.Size(255, 32);
            this.txt_islem_tutari.TabIndex = 3;
            this.txt_islem_tutari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_islem_tutari_KeyDown);
            // 
            // txt_musteri_kodu
            // 
            this.txt_musteri_kodu.EditValue = "0";
            this.txt_musteri_kodu.Location = new System.Drawing.Point(507, 78);
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
            this.labelControl1.Location = new System.Drawing.Point(319, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(182, 25);
            this.labelControl1.TabIndex = 94;
            this.labelControl1.Text = "MÜŞTERİ KODU :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(347, 195);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(154, 25);
            this.labelControl3.TabIndex = 100;
            this.labelControl3.Text = "İADE TUTARI :";
            // 
            // txt_iade_tutari
            // 
            this.txt_iade_tutari.EditValue = "0 ₺";
            this.txt_iade_tutari.Location = new System.Drawing.Point(507, 192);
            this.txt_iade_tutari.Name = "txt_iade_tutari";
            this.txt_iade_tutari.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_iade_tutari.Properties.Appearance.Options.UseFont = true;
            this.txt_iade_tutari.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_iade_tutari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_iade_tutari.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_iade_tutari.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_iade_tutari.Properties.Mask.EditMask = "c";
            this.txt_iade_tutari.Size = new System.Drawing.Size(255, 32);
            this.txt_iade_tutari.TabIndex = 4;
            this.txt_iade_tutari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_iade_tutari_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_PESINAT_IADE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 372);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_iade_tutari);
            this.Controls.Add(this.txt_senet_no);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_islem_tutari);
            this.Controls.Add(this.txt_musteri_kodu);
            this.Controls.Add(this.labelControl1);
            this.Name = "FRM_PESINAT_IADE";
            this.Text = "PEŞİNAT İADESİ";
            this.Load += new System.EventHandler(this.FRM_PESINAT_IADE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_senet_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_islem_tutari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iade_tutari.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_senet_no;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lbl_tarih;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_islem_tutari;
        private DevExpress.XtraEditors.TextEdit txt_musteri_kodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_iade_tutari;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private System.Windows.Forms.Timer timer1;
    }
}