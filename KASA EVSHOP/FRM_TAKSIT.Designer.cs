namespace KASA_EVSHOP
{
    partial class FRM_TAKSIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TAKSIT));
            this.btn_hesapla = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tahsilat_tutar = new DevExpress.XtraEditors.TextEdit();
            this.txt_odenen_tutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_musteri_kodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_para_ustu = new DevExpress.XtraEditors.TextEdit();
            this.lbl_tarih = new DevExpress.XtraEditors.LabelControl();
            this.lbl_saat = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_kucult = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tahsilat_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_odenen_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_para_ustu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.Appearance.Options.UseFont = true;
            this.btn_hesapla.ImageIndex = 0;
            this.btn_hesapla.ImageList = this.ımageCollection1;
            this.btn_hesapla.Location = new System.Drawing.Point(557, 201);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(174, 55);
            this.btn_hesapla.TabIndex = 63;
            this.btn_hesapla.TabStop = false;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "icons8_calculator_125px_4.png");
            this.ımageCollection1.Images.SetKeyName(1, "icons8_minus_math_125px_2.png");
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(315, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(206, 25);
            this.labelControl4.TabIndex = 66;
            this.labelControl4.Text = "TAHSİLAT TUTARI :";
            // 
            // txt_tahsilat_tutar
            // 
            this.txt_tahsilat_tutar.EditValue = "0 ₺";
            this.txt_tahsilat_tutar.Location = new System.Drawing.Point(527, 149);
            this.txt_tahsilat_tutar.Name = "txt_tahsilat_tutar";
            this.txt_tahsilat_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tahsilat_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_tahsilat_tutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_tahsilat_tutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tahsilat_tutar.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_tahsilat_tutar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tahsilat_tutar.Properties.Mask.EditMask = "c";
            this.txt_tahsilat_tutar.Size = new System.Drawing.Size(223, 32);
            this.txt_tahsilat_tutar.TabIndex = 62;
            this.txt_tahsilat_tutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tahsilat_tutar_KeyDown);
            // 
            // txt_odenen_tutar
            // 
            this.txt_odenen_tutar.EditValue = "0 ₺";
            this.txt_odenen_tutar.Location = new System.Drawing.Point(527, 111);
            this.txt_odenen_tutar.Name = "txt_odenen_tutar";
            this.txt_odenen_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_odenen_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_odenen_tutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_odenen_tutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_odenen_tutar.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_odenen_tutar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_odenen_tutar.Properties.Mask.EditMask = "c";
            this.txt_odenen_tutar.Size = new System.Drawing.Size(223, 32);
            this.txt_odenen_tutar.TabIndex = 61;
            this.txt_odenen_tutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_odenen_tutar_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(340, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(181, 25);
            this.labelControl3.TabIndex = 65;
            this.labelControl3.Text = "ÖDENEN TUTAR :";
            // 
            // txt_musteri_kodu
            // 
            this.txt_musteri_kodu.EditValue = "0";
            this.txt_musteri_kodu.Location = new System.Drawing.Point(527, 73);
            this.txt_musteri_kodu.Name = "txt_musteri_kodu";
            this.txt_musteri_kodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteri_kodu.Properties.Appearance.Options.UseFont = true;
            this.txt_musteri_kodu.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_musteri_kodu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_musteri_kodu.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_musteri_kodu.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_musteri_kodu.Size = new System.Drawing.Size(223, 32);
            this.txt_musteri_kodu.TabIndex = 60;
            this.txt_musteri_kodu.TabStop = false;
            this.txt_musteri_kodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_musteri_kodu_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(339, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(182, 25);
            this.labelControl1.TabIndex = 64;
            this.labelControl1.Text = "MÜŞTERİ KODU :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(386, 290);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(135, 25);
            this.labelControl7.TabIndex = 68;
            this.labelControl7.Text = "PARA ÜSTÜ :";
            // 
            // txt_para_ustu
            // 
            this.txt_para_ustu.EditValue = "0 ₺";
            this.txt_para_ustu.Enabled = false;
            this.txt_para_ustu.Location = new System.Drawing.Point(527, 287);
            this.txt_para_ustu.Name = "txt_para_ustu";
            this.txt_para_ustu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_para_ustu.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_para_ustu.Properties.Appearance.Options.UseFont = true;
            this.txt_para_ustu.Properties.Appearance.Options.UseForeColor = true;
            this.txt_para_ustu.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_para_ustu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_para_ustu.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_para_ustu.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_para_ustu.Properties.Mask.EditMask = "c";
            this.txt_para_ustu.Size = new System.Drawing.Size(223, 32);
            this.txt_para_ustu.TabIndex = 69;
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.Location = new System.Drawing.Point(82, 98);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(63, 13);
            this.lbl_tarih.TabIndex = 70;
            this.lbl_tarih.Text = "labelControl2";
            // 
            // lbl_saat
            // 
            this.lbl_saat.Location = new System.Drawing.Point(82, 124);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(63, 13);
            this.lbl_saat.TabIndex = 71;
            this.lbl_saat.Text = "labelControl5";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // btn_kucult
            // 
            this.btn_kucult.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kucult.Appearance.Options.UseFont = true;
            this.btn_kucult.ImageIndex = 0;
            this.btn_kucult.ImageList = this.ımageCollection2;
            this.btn_kucult.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_kucult.Location = new System.Drawing.Point(727, 12);
            this.btn_kucult.Name = "btn_kucult";
            this.btn_kucult.Size = new System.Drawing.Size(35, 27);
            this.btn_kucult.TabIndex = 73;
            this.btn_kucult.TabStop = false;
            this.btn_kucult.Click += new System.EventHandler(this.btn_kucult_Click);
            // 
            // ımageCollection2
            // 
            this.ımageCollection2.ImageSize = new System.Drawing.Size(35, 35);
            this.ımageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection2.ImageStream")));
            this.ımageCollection2.Images.SetKeyName(0, "icons8_minus_math_125px_2.png");
            // 
            // FRM_TAKSIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 372);
            this.Controls.Add(this.btn_kucult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.txt_para_ustu);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_tahsilat_tutar);
            this.Controls.Add(this.txt_odenen_tutar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_musteri_kodu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl7);
            this.Name = "FRM_TAKSIT";
            this.Text = "TAKSİT ÖDEME";
            this.Load += new System.EventHandler(this.FRM_TAKSIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tahsilat_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_odenen_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_para_ustu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_hesapla;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_tahsilat_tutar;
        private DevExpress.XtraEditors.TextEdit txt_odenen_tutar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_musteri_kodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.TextEdit txt_para_ustu;
        private DevExpress.XtraEditors.LabelControl lbl_tarih;
        private DevExpress.XtraEditors.LabelControl lbl_saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btn_kucult;
        private DevExpress.Utils.ImageCollection ımageCollection2;
    }
}