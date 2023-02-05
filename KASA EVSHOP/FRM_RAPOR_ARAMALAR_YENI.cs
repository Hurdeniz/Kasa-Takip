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
    public partial class FRM_RAPOR_ARAMALAR_YENI : DevExpress.XtraEditors.XtraForm
    {
        public FRM_RAPOR_ARAMALAR_YENI()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();
        public int arama;
        private void FRM_RAPOR_ARAMALAR_YENI_Load(object sender, EventArgs e)
        {
            if (arama==3)
            {
                txt_telefon.Enabled = false;
                date_arama_tarih.Enabled = false;
                date_arama_tarih.Text = "";
               
            }
            txt_musteri_kodu.Focus();

            date_tarih.Text = DateTime.Now.ToShortDateString();
            date_arama_tarih.Text = DateTime.Now.ToShortDateString();

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
        
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
    
       
        // VERİLERİ KAYDETME      
        public void kaydet()
        {
           
                if (arama == 1)
                {

                    OleDbTransaction islem = null;
                    islem = bgl.baglanti().BeginTransaction();

                    OleDbCommand kmt = new OleDbCommand("insert into aramalar (musteri_kodu,adi_soyadi,magaza_adi,tutar,telefon,arama_tarih,alisveris_tarih,arayan_kisi,durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                    kmt.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
                    kmt.Parameters.AddWithValue("@p2", txt_adi_soyadi.Text);
                    kmt.Parameters.AddWithValue("@p3", txt_magaza.Text);
                    kmt.Parameters.AddWithValue("@p4", txt_tutar.Text);
                    kmt.Parameters.AddWithValue("@p5", txt_telefon.Text);
                    kmt.Parameters.AddWithValue("@p6", date_arama_tarih.Text);
                    kmt.Parameters.AddWithValue("@p7", date_tarih.Text);
                    kmt.Parameters.AddWithValue("@p8", cmb_kullanici.Text);
                    kmt.Parameters.AddWithValue("@p9", 1);


                    try
                    {
                        kmt.ExecuteNonQuery();
                        islem.Commit();
                        XtraMessageBox.Show("YENİ ARAMA KAYIT EDİLMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        islem.Rollback();
                        XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        bgl.baglanti().Close();

                    }

                    // PERSONEL FORMUNDAKİ GRİD YENİLEME


                    FRM_RAPOR_ARAMALAR frm_arama = (FRM_RAPOR_ARAMALAR)Application.OpenForms["FRM_RAPOR_ARAMALAR"];
                    frm_arama.listele_arama();

                    //FORM KAPAT
                    this.Hide();

                }
                else if (arama == 2)
                {

                    OleDbTransaction islem = null;
                    islem = bgl.baglanti().BeginTransaction();

                    OleDbCommand kmt = new OleDbCommand("insert into aramalar (musteri_kodu,adi_soyadi,magaza_adi,tutar,telefon,arama_tarih,alisveris_tarih,arayan_kisi,durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                    kmt.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
                    kmt.Parameters.AddWithValue("@p2", txt_adi_soyadi.Text);
                    kmt.Parameters.AddWithValue("@p3", txt_magaza.Text);
                    kmt.Parameters.AddWithValue("@p4", txt_tutar.Text);
                    kmt.Parameters.AddWithValue("@p5", txt_telefon.Text);
                    kmt.Parameters.AddWithValue("@p6", date_arama_tarih.Text);
                    kmt.Parameters.AddWithValue("@p7", date_tarih.Text);
                    kmt.Parameters.AddWithValue("@p8", cmb_kullanici.Text);
                    kmt.Parameters.AddWithValue("@p9", 2);


                    try
                    {
                        kmt.ExecuteNonQuery();
                        islem.Commit();
                        XtraMessageBox.Show("YENİ ARAMA KAYIT EDİLMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        islem.Rollback();
                        XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        bgl.baglanti().Close();

                    }

                    // PERSONEL FORMUNDAKİ GRİD YENİLEME


                     FRM_RAPOR_ARAMALAR frm_arama = (FRM_RAPOR_ARAMALAR)Application.OpenForms["FRM_RAPOR_ARAMALAR"];
                     frm_arama.listele_dogum_gunu();

                    //FORM KAPAT
                       this.Hide();

                }
                else if (arama == 3)
                {

                    OleDbTransaction islem = null;
                    islem = bgl.baglanti().BeginTransaction();

                    OleDbCommand kmt = new OleDbCommand("insert into aramalar (musteri_kodu,adi_soyadi,magaza_adi,tutar,alisveris_tarih,arayan_kisi,durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                    kmt.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
                    kmt.Parameters.AddWithValue("@p2", txt_adi_soyadi.Text);
                    kmt.Parameters.AddWithValue("@p3", txt_magaza.Text);
                    kmt.Parameters.AddWithValue("@p4", txt_tutar.Text);
                    kmt.Parameters.AddWithValue("@p5", date_tarih.Text);
                    kmt.Parameters.AddWithValue("@p6", cmb_kullanici.Text);
                    kmt.Parameters.AddWithValue("@p7", 3);


                    try
                    {
                        kmt.ExecuteNonQuery();
                        islem.Commit();
                        XtraMessageBox.Show("YENİ ARAMA KAYIT EDİLMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        islem.Rollback();
                        XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
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