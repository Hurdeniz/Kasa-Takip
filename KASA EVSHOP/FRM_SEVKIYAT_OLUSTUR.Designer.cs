namespace KASA_EVSHOP
{
    partial class FRM_SEVKIYAT_OLUSTUR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SEVKIYAT_OLUSTUR));
            this.btn_sevkiyat1 = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btn_sevkiyat2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sevkiyat1
            // 
            this.btn_sevkiyat1.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sevkiyat1.Appearance.Options.UseFont = true;
            this.btn_sevkiyat1.ImageIndex = 2;
            this.btn_sevkiyat1.ImageList = this.ımageCollection1;
            this.btn_sevkiyat1.Location = new System.Drawing.Point(322, 64);
            this.btn_sevkiyat1.Name = "btn_sevkiyat1";
            this.btn_sevkiyat1.Size = new System.Drawing.Size(406, 84);
            this.btn_sevkiyat1.TabIndex = 0;
            this.btn_sevkiyat1.Text = "-";
            this.btn_sevkiyat1.Click += new System.EventHandler(this.btn_sevkiyat1_Click);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(80, 80);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "iconfinder_LorryGreen_22994.png");
            this.ımageCollection1.Images.SetKeyName(1, "icons8_People_Working_Together_125px.png");
            this.ımageCollection1.Images.SetKeyName(2, "icons8_shipped_125px_3.png");
            // 
            // btn_sevkiyat2
            // 
            this.btn_sevkiyat2.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sevkiyat2.Appearance.Options.UseFont = true;
            this.btn_sevkiyat2.ImageIndex = 1;
            this.btn_sevkiyat2.ImageList = this.ımageCollection1;
            this.btn_sevkiyat2.Location = new System.Drawing.Point(322, 171);
            this.btn_sevkiyat2.Name = "btn_sevkiyat2";
            this.btn_sevkiyat2.Size = new System.Drawing.Size(406, 84);
            this.btn_sevkiyat2.TabIndex = 1;
            this.btn_sevkiyat2.Text = "-";
            this.btn_sevkiyat2.Click += new System.EventHandler(this.btn_sevkiyat2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_SEVKIYAT_OLUSTUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 395);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sevkiyat2);
            this.Controls.Add(this.btn_sevkiyat1);
            this.Name = "FRM_SEVKIYAT_OLUSTUR";
            this.Text = "SEVKİYAT OLUŞTUR";
            this.Load += new System.EventHandler(this.FRM_SEVKIYAT_OLUSTUR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_sevkiyat1;
        private DevExpress.XtraEditors.SimpleButton btn_sevkiyat2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.Utils.ImageCollection ımageCollection1;
    }
}