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
    public partial class FRM_RAPOR_ARAMA_GUNCELLE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_RAPOR_ARAMA_GUNCELLE()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int musteri_id, arama_guncel;
        private void FRM_RAPOR_ARAMA_GUNCELLE_Load(object sender, EventArgs e)
        {
            personel_bilgiler();
            kullanici_bilgiler();
        }
        // KULLANICI BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void kullanici_bilgiler()
        {
            OleDbCommand kmt = new OleDbCommand("select kullanici_adi from kullanici_giris", bgl.baglanti());
            OleDbDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {

                cmb_kullanici.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();



        }
        // ARAMA  BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void personel_bilgiler()
        {
            if (arama_guncel == 1)
            {

                OleDbCommand kmt = new OleDbCommand("select * from aramalar where id=@p1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", musteri_id.ToString());
                DateTime a, b;
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    a = Convert.ToDateTime(oku["alisveris_tarih"].ToString());
                    date_tarih.Text = a.ToShortDateString();
                    txt_musteri_kodu.Text = oku["musteri_kodu"].ToString();
                    txt_adi_soyadi.Text = oku["adi_soyadi"].ToString();
                    txt_magaza.Text = oku["magaza_adi"].ToString();
                    txt_tutar.Text = oku["tutar"].ToString();
                    txt_telefon.Text = oku["telefon"].ToString();
                    b = Convert.ToDateTime(oku["arama_tarih"].ToString());
                    date_arama_tarih.Text = b.ToShortDateString();
                    cmb_kullanici.Text = oku["arayan_kisi"].ToString();



                }
                bgl.baglanti().Close();
            }
            else if (arama_guncel == 2)
            {

                OleDbCommand kmt = new OleDbCommand("select * from aramalar where id=@p1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", musteri_id.ToString());
                DateTime a, b;
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    a = Convert.ToDateTime(oku["alisveris_tarih"].ToString());
                    date_tarih.Text = a.ToShortDateString();
                    txt_musteri_kodu.Text = oku["musteri_kodu"].ToString();
                    txt_adi_soyadi.Text = oku["adi_soyadi"].ToString();
                    txt_magaza.Text = oku["magaza_adi"].ToString();
                    txt_tutar.Text = oku["tutar"].ToString();
                    txt_telefon.Text = oku["telefon"].ToString();
                    b = Convert.ToDateTime(oku["arama_tarih"].ToString());
                    date_arama_tarih.Text = b.ToShortDateString();
                    cmb_kullanici.Text = oku["arayan_kisi"].ToString();



                }
                bgl.baglanti().Close();
            }
            else if (arama_guncel == 3)
            {
                txt_telefon.Enabled = false;
                date_arama_tarih.Enabled = false;
                date_arama_tarih.Text = "";

                OleDbCommand kmt = new OleDbCommand("select * from aramalar where id=@p1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", musteri_id.ToString());
                DateTime a;
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    a = Convert.ToDateTime(oku["alisveris_tarih"].ToString());
                    date_tarih.Text = a.ToShortDateString();
                    txt_musteri_kodu.Text = oku["musteri_kodu"].ToString();
                    txt_adi_soyadi.Text = oku["adi_soyadi"].ToString();
                    txt_magaza.Text = oku["magaza_adi"].ToString();
                    txt_tutar.Text = oku["tutar"].ToString();                                 
                    cmb_kullanici.Text = oku["arayan_kisi"].ToString();



                }
                bgl.baglanti().Close();
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
            if (arama_guncel == 3)
            {
                OleDbTransaction islem = null;
                islem = bgl.baglanti().BeginTransaction();


                OleDbCommand kmt = new OleDbCommand("update aramalar set musteri_kodu=@p1,adi_soyadi=@p2,magaza_adi=@p3,tutar=@p4,alisveris_tarih=@p5,arayan_kisi=@p6 where id=@p7", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
                kmt.Parameters.AddWithValue("@p2", txt_adi_soyadi.Text);
                kmt.Parameters.AddWithValue("@p3", txt_magaza.Text);
                kmt.Parameters.AddWithValue("@p4", txt_tutar.Text);
                kmt.Parameters.AddWithValue("@p5", date_tarih.Text);
                kmt.Parameters.AddWithValue("@p6", cmb_kullanici.Text);
                kmt.Parameters.Add("@p7", musteri_id.ToString());

                try
                {
                    kmt.ExecuteNonQuery();
                    islem.Commit();
                    XtraMessageBox.Show("ARAMA GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

                }
                catch
                {
                    islem.Rollback();
                    XtraMessageBox.Show("ARAMA GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bgl.baglanti().Close();

                }

                // PERSONEL FORMUNDAKİ GRİD YENİLEME


                FRM_RAPOR_ARAMALAR frm_arama = (FRM_RAPOR_ARAMALAR)Application.OpenForms["FRM_RAPOR_ARAMALAR"];
                frm_arama.listele_borc_kapama();

                //FORM KAPAT
                this.Hide();
            }
            else
            {


                OleDbTransaction islem = null;
                islem = bgl.baglanti().BeginTransaction();


                OleDbCommand kmt = new OleDbCommand("update aramalar set musteri_kodu=@p1,adi_soyadi=@p2,magaza_adi=@p3,tutar=@p4,telefon=@p5,arama_tarih=@p6,alisveris_tarih=@p7,arayan_kisi=@p8 where id=@p9", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
                kmt.Parameters.AddWithValue("@p2", txt_adi_soyadi.Text);
                kmt.Parameters.AddWithValue("@p3", txt_magaza.Text);
                kmt.Parameters.AddWithValue("@p4", txt_tutar.Text);
                kmt.Parameters.AddWithValue("@p5", txt_telefon.Text);
                kmt.Parameters.AddWithValue("@p6", date_arama_tarih.Text);
                kmt.Parameters.AddWithValue("@p7", date_tarih.Text);
                kmt.Parameters.AddWithValue("@p8", cmb_kullanici.Text);
                kmt.Parameters.Add("@p9", musteri_id.ToString());

                try
                {
                    kmt.ExecuteNonQuery();
                    islem.Commit();
                    XtraMessageBox.Show("ARAMA GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

                }
                catch
                {
                    islem.Rollback();
                    XtraMessageBox.Show("ARAMA GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bgl.baglanti().Close();

                }
                // PERSONEL FORMUNDAKİ GRİD YENİLEME


                FRM_RAPOR_ARAMALAR frm_arama = (FRM_RAPOR_ARAMALAR)Application.OpenForms["FRM_RAPOR_ARAMALAR"];
                frm_arama.listele_arama();
                frm_arama.listele_dogum_gunu();

                //FORM KAPAT
                this.Hide();


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

        private void txt_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_telefon_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void date_arama_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_kullanici_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}