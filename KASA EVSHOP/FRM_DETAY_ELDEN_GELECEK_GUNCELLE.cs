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
    public partial class FRM_DETAY_ELDEN_GELECEK_GUNCELLE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_ELDEN_GELECEK_GUNCELLE()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();
        public int elden_gelecek_guncelle_id;
        
        private void FRM_DETAY_ELDEN_GELECEK_GUNCELLE_Load(object sender, EventArgs e)
        {
            musteri_bilgileri();
        }
        // MÜŞTERİ BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void musteri_bilgileri()
        {
            DateTime a;
            OleDbCommand kmt = new OleDbCommand("select * from elden_gelecek_gelen where id=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", elden_gelecek_guncelle_id.ToString());

            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                a = Convert.ToDateTime(oku["islem_tarih"].ToString());
                date_tarih.Text = a.ToShortDateString();
                txt_islem_tipi.Text = oku["islem"].ToString();
                txt_senet_no.Text = oku["senet_no"].ToString();
                txt_musteri_kodu.Text = oku["musteri_kodu"].ToString();               
                txt_adi_soyadi.Text = oku["adi_soyadi"].ToString();               
                txt_islem_tutari.Text = oku["islem_tutari"].ToString();
                txt_odenen_tutar.Text = oku["odenen_tutar"].ToString();
                txt_gelecek_tutar.Text = oku["gelecek_tutar"].ToString();
                memo_aciklama.Text = oku["aciklama"].ToString();


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

            OleDbCommand kmt = new OleDbCommand("update elden_gelecek_gelen set islem=@p1,senet_no=@p2,musteri_kodu=@p3,adi_soyadi=@p4,islem_tutari=@p5,odenen_tutar=@p6,gelecek_tutar=@p7,islem_tarih=@p8,aciklama=@p9 where id=@p10", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_islem_tipi.Text);
            kmt.Parameters.AddWithValue("@p2", txt_senet_no.Text);
            kmt.Parameters.AddWithValue("@p3", txt_musteri_kodu.Text);
            kmt.Parameters.AddWithValue("@p4", txt_adi_soyadi.Text);
            kmt.Parameters.AddWithValue("@p5", txt_islem_tutari.Text);
            kmt.Parameters.AddWithValue("@p6", txt_odenen_tutar.Text);
            kmt.Parameters.AddWithValue("@p7", txt_gelecek_tutar.Text);
            kmt.Parameters.AddWithValue("@p8", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p9", memo_aciklama.Text);
            kmt.Parameters.Add("@p10", elden_gelecek_guncelle_id.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("ELDEN GELECEK MÜŞTERİ GÜNCELLENMİŞTİR.", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("ELDEN GELECEK MÜŞTERİ GÜNCELLENMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }


            // E-GELECEK FORMUNDAKİ GRİD YENİLEME

            FRM_DETAY_ELDEN_GELECEK frm_gelecek = (FRM_DETAY_ELDEN_GELECEK)Application.OpenForms["FRM_DETAY_ELDEN_GELECEK"];
            frm_gelecek.listele_elden_gelecek();

            //FORM KAPAT
            this.Close();


        }

        private void txt_islem_tipi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void date_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_senet_no_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_musteri_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_adi_soyadi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_islem_tutari_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_odenen_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_gelecek_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void memo_aciklama_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}