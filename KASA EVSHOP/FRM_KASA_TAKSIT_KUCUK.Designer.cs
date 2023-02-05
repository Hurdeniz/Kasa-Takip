namespace KASA_EVSHOP
{
    partial class FRM_KASA_TAKSIT_KUCUK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_KASA_TAKSIT_KUCUK));
            this.txt_para_ustu = new DevExpress.XtraEditors.TextEdit();
            this.btn_hesapla = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tahsilat_tutar = new DevExpress.XtraEditors.TextEdit();
            this.txt_odenen_tutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_musteri_kodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_tarih = new DevExpress.XtraEditors.LabelControl();
            this.lbl_saat = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_para_ustu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tahsilat_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_odenen_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri_kodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_para_ustu
            // 
            this.txt_para_ustu.EditValue = "0 ₺";
            this.txt_para_ustu.Enabled = false;
            this.txt_para_ustu.Location = new System.Drawing.Point(67, 218);
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
            this.txt_para_ustu.TabIndex = 78;
            this.txt_para_ustu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_para_ustu_KeyDown);
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.Appearance.Options.UseFont = true;
            this.btn_hesapla.ImageIndex = 0;
            this.btn_hesapla.ImageList = this.ımageCollection1;
            this.btn_hesapla.Location = new System.Drawing.Point(97, 140);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(174, 55);
            this.btn_hesapla.TabIndex = 73;
            this.btn_hesapla.TabStop = false;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "icons8_calculator_125px_4.png");
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(14, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 25);
            this.labelControl4.TabIndex = 76;
            this.labelControl4.Text = "T.T :";
            // 
            // txt_tahsilat_tutar
            // 
            this.txt_tahsilat_tutar.EditValue = "0 ₺";
            this.txt_tahsilat_tutar.Location = new System.Drawing.Point(67, 88);
            this.txt_tahsilat_tutar.Name = "txt_tahsilat_tutar";
            this.txt_tahsilat_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tahsilat_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_tahsilat_tutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_tahsilat_tutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tahsilat_tutar.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_tahsilat_tutar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tahsilat_tutar.Properties.Mask.EditMask = "c";
            this.txt_tahsilat_tutar.Size = new System.Drawing.Size(223, 32);
            this.txt_tahsilat_tutar.TabIndex = 72;
            // 
            // txt_odenen_tutar
            // 
            this.txt_odenen_tutar.EditValue = "0 ₺";
            this.txt_odenen_tutar.Location = new System.Drawing.Point(67, 50);
            this.txt_odenen_tutar.Name = "txt_odenen_tutar";
            this.txt_odenen_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_odenen_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_odenen_tutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_odenen_tutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_odenen_tutar.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_odenen_tutar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_odenen_tutar.Properties.Mask.EditMask = "c";
            this.txt_odenen_tutar.Size = new System.Drawing.Size(223, 32);
            this.txt_odenen_tutar.TabIndex = 71;
            this.txt_odenen_tutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_odenen_tutar_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 25);
            this.labelControl3.TabIndex = 75;
            this.labelControl3.Text = "Ö.T :";
            // 
            // txt_musteri_kodu
            // 
            this.txt_musteri_kodu.EditValue = "0";
            this.txt_musteri_kodu.Location = new System.Drawing.Point(67, 12);
            this.txt_musteri_kodu.Name = "txt_musteri_kodu";
            this.txt_musteri_kodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteri_kodu.Properties.Appearance.Options.UseFont = true;
            this.txt_musteri_kodu.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_musteri_kodu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_musteri_kodu.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_musteri_kodu.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_musteri_kodu.Size = new System.Drawing.Size(223, 32);
            this.txt_musteri_kodu.TabIndex = 70;
            this.txt_musteri_kodu.TabStop = false;
            this.txt_musteri_kodu.EditValueChanged += new System.EventHandler(this.txt_musteri_kodu_EditValueChanged);
            this.txt_musteri_kodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_musteri_kodu_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(6, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 25);
            this.labelControl1.TabIndex = 74;
            this.labelControl1.Text = "M.K :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(10, 221);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 25);
            this.labelControl7.TabIndex = 77;
            this.labelControl7.Text = "P.Ü :";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.Appearance.Options.UseFont = true;
            this.lbl_tarih.Location = new System.Drawing.Point(67, 256);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(90, 19);
            this.lbl_tarih.TabIndex = 79;
            this.lbl_tarih.Text = "12.05.2019";
            // 
            // lbl_saat
            // 
            this.lbl_saat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Appearance.Options.UseFont = true;
            this.lbl_saat.Location = new System.Drawing.Point(244, 256);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(46, 19);
            this.lbl_saat.TabIndex = 80;
            this.lbl_saat.Text = "12:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_KASA_TAKSIT_KUCUK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 284);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_KASA_TAKSIT_KUCUK";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAKSİT ÖDEME";
            this.Load += new System.EventHandler(this.FRM_KASA_TAKSIT_KUCUK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_para_ustu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tahsilat_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_odenen_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri_kodu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_para_ustu;
        private DevExpress.XtraEditors.SimpleButton btn_hesapla;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_tahsilat_tutar;
        private DevExpress.XtraEditors.TextEdit txt_odenen_tutar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_musteri_kodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lbl_tarih;
        private DevExpress.XtraEditors.LabelControl lbl_saat;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private System.Windows.Forms.Timer timer1;
    }
}