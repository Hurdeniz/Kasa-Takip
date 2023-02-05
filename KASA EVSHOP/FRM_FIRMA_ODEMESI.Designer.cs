namespace KASA_EVSHOP
{
    partial class FRM_FIRMA_ODEMESI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_FIRMA_ODEMESI));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_tarih = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.memo_aciklama = new DevExpress.XtraEditors.MemoEdit();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_firma_adi = new DevExpress.XtraEditors.TextEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_aciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_firma_adi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.Location = new System.Drawing.Point(99, 148);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(63, 13);
            this.lbl_tarih.TabIndex = 131;
            this.lbl_tarih.Text = "labelControl1";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(395, 76);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 25);
            this.labelControl6.TabIndex = 130;
            this.labelControl6.Text = "TUTAR :";
            // 
            // txt_tutar
            // 
            this.txt_tutar.EditValue = "0";
            this.txt_tutar.Location = new System.Drawing.Point(486, 73);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_tutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_tutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tutar.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_tutar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tutar.Properties.Mask.EditMask = "n";
            this.txt_tutar.Size = new System.Drawing.Size(255, 32);
            this.txt_tutar.TabIndex = 2;
            this.txt_tutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tutar_KeyDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(354, 114);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(126, 25);
            this.labelControl5.TabIndex = 129;
            this.labelControl5.Text = "AÇIKLAMA :";
            // 
            // memo_aciklama
            // 
            this.memo_aciklama.EditValue = "";
            this.memo_aciklama.Location = new System.Drawing.Point(486, 111);
            this.memo_aciklama.Name = "memo_aciklama";
            this.memo_aciklama.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memo_aciklama.Properties.Appearance.Options.UseFont = true;
            this.memo_aciklama.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memo_aciklama.Size = new System.Drawing.Size(255, 109);
            this.memo_aciklama.TabIndex = 3;
            this.memo_aciklama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.memo_aciklama_KeyDown);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageIndex = 0;
            this.btn_kaydet.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(537, 242);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(159, 52);
            this.btn_kaydet.TabIndex = 128;
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(350, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(130, 25);
            this.labelControl1.TabIndex = 134;
            this.labelControl1.Text = "FİRMA ADI :";
            // 
            // txt_firma_adi
            // 
            this.txt_firma_adi.EditValue = "";
            this.txt_firma_adi.Location = new System.Drawing.Point(486, 35);
            this.txt_firma_adi.Name = "txt_firma_adi";
            this.txt_firma_adi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_firma_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_firma_adi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_firma_adi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_firma_adi.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_firma_adi.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_firma_adi.Properties.Mask.EditMask = "n";
            this.txt_firma_adi.Size = new System.Drawing.Size(255, 32);
            this.txt_firma_adi.TabIndex = 1;
            this.txt_firma_adi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_firma_adi_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_FIRMA_ODEMESI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 405);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_firma_adi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.memo_aciklama);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "FRM_FIRMA_ODEMESI";
            this.Text = "FİRMA ÖDEMESİ";
            this.Load += new System.EventHandler(this.FRM_FIRMA_ODEMESI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_aciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_firma_adi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lbl_tarih;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_tutar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit memo_aciklama;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_firma_adi;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private System.Windows.Forms.Timer timer1;
    }
}