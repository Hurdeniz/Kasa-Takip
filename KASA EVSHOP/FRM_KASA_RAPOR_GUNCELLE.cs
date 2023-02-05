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
    public partial class FRM_KASA_RAPOR_GUNCELLE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_KASA_RAPOR_GUNCELLE()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public string kullanici_adi;
        public int rapor_kullanici_kod;

        private void FRM_KASA_RAPOR_GUNCELLE_Load(object sender, EventArgs e)
        {
            cikis_id();
        }
        // ÇIKIŞ ID VERI TABANINDAN ÇEKME
        public void cikis_id()
        {
           txt_personel_adi.Text = kullanici_adi.ToString();

           OleDbCommand kmt = new OleDbCommand("Select * from kasa_cikis where kullanici_adi=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", Convert.ToString(kullanici_adi.ToString()));
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                rapor_kullanici_kod =Convert.ToInt32( oku["id"].ToString());


            }

        }
        //KAYDET
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // VERİ GÜNCELLEME
        void kaydet()
        {

            OleDbTransaction islem = null;
            islem = bgl.baglanti().BeginTransaction();


            OleDbCommand kmt = new OleDbCommand("update kasa_cikis set toplam_kasa=@p1 where id=@p2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_tutar.Text);
            kmt.Parameters.Add("@p2", rapor_kullanici_kod.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("KASA ÇIKIŞ İŞLEMİNİZ GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("KASA ÇIKIŞ GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }

            // KASA ÇIKIŞ FORMUNDAKİ GRİD YENİLEME

            FRM_KASA_RAPOR frm_kasa_rapor = (FRM_KASA_RAPOR)Application.OpenForms["FRM_KASA_RAPOR"];
            frm_kasa_rapor.listele_kasa();
            frm_kasa_rapor.hesapla();

            //FORM KAPAT
            this.Close();


        }

        private void txt_tutar_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        
        }
    }
}