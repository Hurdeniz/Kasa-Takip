using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace KASA_EVSHOP
{
    public partial class FRM_RAPOR_YENI_CIKIS_KULLANICI : DevExpress.XtraEditors.XtraForm
    {
        public FRM_RAPOR_YENI_CIKIS_KULLANICI()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();
        private void FRM_RAPOR_YENI_CIKIS_KULLANICI_Load(object sender, EventArgs e)
        {
            kullanici_bilgiler();
        }
        // KULLANICI BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void kullanici_bilgiler()
        {
            OleDbCommand kmt = new OleDbCommand("select kullanici_adi from kullanici_giris", bgl.baglanti());
            OleDbDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit1.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();



        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            giris();
        }

        // KULLANICI GİRİŞ YETKİSİ
        void giris()
        {
            if (comboBoxEdit1.Text == "")// EĞER KULLANICI BOŞ İSE
            {

                XtraMessageBox.Show("LÜTFEN KULLANICI SEÇİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                FRM_RAPOR_YENI_CIKIS frm_kullanici = new FRM_RAPOR_YENI_CIKIS();
                frm_kullanici.kullanici_adi = comboBoxEdit1.Text;
                frm_kullanici.Show();



                this.Hide();
            }

        }

        private void comboBoxEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                giris();
            }
        }
    }
}