namespace KASA_EVSHOP
{
    partial class FRM_PERSONEL_TAKIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PERSONEL_TAKIP));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.check_pazar = new DevExpress.XtraEditors.CheckEdit();
            this.check_cumartesi = new DevExpress.XtraEditors.CheckEdit();
            this.check_cuma = new DevExpress.XtraEditors.CheckEdit();
            this.check_persembe = new DevExpress.XtraEditors.CheckEdit();
            this.check_carsamba = new DevExpress.XtraEditors.CheckEdit();
            this.check_sali = new DevExpress.XtraEditors.CheckEdit();
            this.check_pazartesi = new DevExpress.XtraEditors.CheckEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_pazar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_cumartesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_cuma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_persembe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_carsamba.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_sali.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_pazartesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_kaydet);
            this.panelControl1.Controls.Add(this.check_pazar);
            this.panelControl1.Controls.Add(this.check_cumartesi);
            this.panelControl1.Controls.Add(this.check_cuma);
            this.panelControl1.Controls.Add(this.check_persembe);
            this.panelControl1.Controls.Add(this.check_carsamba);
            this.panelControl1.Controls.Add(this.check_sali);
            this.panelControl1.Controls.Add(this.check_pazartesi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(227, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(170, 327);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageIndex = 0;
            this.btn_kaydet.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(5, 270);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(160, 52);
            this.btn_kaydet.TabIndex = 124;
            this.btn_kaydet.TabStop = false;
            this.btn_kaydet.Text = "AKTAR";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "iconfinder_logo_brand_brands_logos_excel_2993694.png");
            // 
            // check_pazar
            // 
            this.check_pazar.Location = new System.Drawing.Point(6, 228);
            this.check_pazar.Name = "check_pazar";
            this.check_pazar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_pazar.Properties.Appearance.Options.UseFont = true;
            this.check_pazar.Properties.Caption = "PAZAR";
            this.check_pazar.Size = new System.Drawing.Size(154, 30);
            this.check_pazar.TabIndex = 6;
            this.check_pazar.CheckedChanged += new System.EventHandler(this.check_pazar_CheckedChanged);
            // 
            // check_cumartesi
            // 
            this.check_cumartesi.Location = new System.Drawing.Point(5, 192);
            this.check_cumartesi.Name = "check_cumartesi";
            this.check_cumartesi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_cumartesi.Properties.Appearance.Options.UseFont = true;
            this.check_cumartesi.Properties.Caption = "CUMARTESİ";
            this.check_cumartesi.Size = new System.Drawing.Size(154, 30);
            this.check_cumartesi.TabIndex = 5;
            this.check_cumartesi.CheckedChanged += new System.EventHandler(this.check_cumartesi_CheckedChanged);
            // 
            // check_cuma
            // 
            this.check_cuma.Location = new System.Drawing.Point(5, 156);
            this.check_cuma.Name = "check_cuma";
            this.check_cuma.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_cuma.Properties.Appearance.Options.UseFont = true;
            this.check_cuma.Properties.Caption = "CUMA";
            this.check_cuma.Size = new System.Drawing.Size(154, 30);
            this.check_cuma.TabIndex = 4;
            this.check_cuma.CheckedChanged += new System.EventHandler(this.check_cuma_CheckedChanged);
            // 
            // check_persembe
            // 
            this.check_persembe.Location = new System.Drawing.Point(5, 120);
            this.check_persembe.Name = "check_persembe";
            this.check_persembe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_persembe.Properties.Appearance.Options.UseFont = true;
            this.check_persembe.Properties.Caption = "PERŞEMBE";
            this.check_persembe.Size = new System.Drawing.Size(154, 30);
            this.check_persembe.TabIndex = 3;
            this.check_persembe.CheckedChanged += new System.EventHandler(this.check_persembe_CheckedChanged);
            // 
            // check_carsamba
            // 
            this.check_carsamba.Location = new System.Drawing.Point(5, 84);
            this.check_carsamba.Name = "check_carsamba";
            this.check_carsamba.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_carsamba.Properties.Appearance.Options.UseFont = true;
            this.check_carsamba.Properties.Caption = "ÇARŞAMBA";
            this.check_carsamba.Size = new System.Drawing.Size(154, 30);
            this.check_carsamba.TabIndex = 2;
            this.check_carsamba.CheckedChanged += new System.EventHandler(this.check_carsamba_CheckedChanged);
            // 
            // check_sali
            // 
            this.check_sali.Location = new System.Drawing.Point(5, 48);
            this.check_sali.Name = "check_sali";
            this.check_sali.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_sali.Properties.Appearance.Options.UseFont = true;
            this.check_sali.Properties.Caption = "SALI";
            this.check_sali.Size = new System.Drawing.Size(154, 30);
            this.check_sali.TabIndex = 1;
            this.check_sali.CheckedChanged += new System.EventHandler(this.check_sali_CheckedChanged);
            // 
            // check_pazartesi
            // 
            this.check_pazartesi.Location = new System.Drawing.Point(5, 12);
            this.check_pazartesi.Name = "check_pazartesi";
            this.check_pazartesi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_pazartesi.Properties.Appearance.Options.UseFont = true;
            this.check_pazartesi.Properties.Caption = "PAZARTESİ";
            this.check_pazartesi.Size = new System.Drawing.Size(154, 30);
            this.check_pazartesi.TabIndex = 0;
            this.check_pazartesi.CheckedChanged += new System.EventHandler(this.check_pazartesi_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(227, 327);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.TabStop = false;
            // 
            // FRM_PERSONEL_TAKIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 327);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_PERSONEL_TAKIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL TAKİP";
            this.Load += new System.EventHandler(this.FRM_PERSONEL_TAKIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_pazar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_cumartesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_cuma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_persembe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_carsamba.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_sali.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_pazartesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit check_pazartesi;
        private DevExpress.XtraEditors.CheckEdit check_pazar;
        private DevExpress.XtraEditors.CheckEdit check_cumartesi;
        private DevExpress.XtraEditors.CheckEdit check_cuma;
        private DevExpress.XtraEditors.CheckEdit check_persembe;
        private DevExpress.XtraEditors.CheckEdit check_carsamba;
        private DevExpress.XtraEditors.CheckEdit check_sali;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.Utils.ImageCollection ımageCollection1;
    }
}