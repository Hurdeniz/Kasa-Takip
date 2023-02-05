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
    public partial class FRM_KASA_CIKIS : DevExpress.XtraEditors.XtraForm
    {
        public FRM_KASA_CIKIS()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int kasa_cikis_kullanici_kod;
        public string kasa_cikis_kullanici_adi;

        private void FRM_KASA_CIKIS_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(btn_yenile, "YENİLE");
           

            date_tarih.Text = DateTime.Now.ToShortDateString();

            tahsilat();
            pesin_islem();
            alinan_pesinat();
            pesinat_iade();
            e_gelecek();
            masraf();
            hesapla();

            garanti();
            yapikredi();
            finansbank();
            isbankasi();
            halkbank();
            akbank();
        }
        //KASA İŞLEMLERİ *************************//
        // TOPLAM TAHSİLAT
        void tahsilat()
        {
            
            OleDbCommand kmt = new OleDbCommand("select sum(tahsilat_tutari) as toplam from kasa_taksit where tarih=@p1 and kullanici_kodu=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod.ToString());
            txt_tahsilat.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_tahsilat.Text == "")
            {
                txt_tahsilat.Text = "0";
            }
        }
        // TOPLAM PEŞİN İŞLEM
        void pesin_islem()
        {
        
            OleDbCommand kmt = new OleDbCommand("select sum(tutar) as toplam from kasa_pesin where tarih=@p1 and kullanici_kodu=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod.ToString());
            txt_pesin.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_pesin.Text == "")
            {
                txt_pesin.Text = "0";
            }
        }
        // TOPLAM ALINAN PEŞİNAT 
        void alinan_pesinat()
        {

            OleDbCommand kmt = new OleDbCommand("select sum(tutar) as toplam from kasa_pesinat_al where tarih=@p1 and kullanici_kodu=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod.ToString());
            txt_alinan_pesinat.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_alinan_pesinat.Text == "")
            {
                txt_alinan_pesinat.Text = "0";
            }
        }
        // TOPLAM PEŞİNAT İADE 
        void pesinat_iade()
        {

            OleDbCommand kmt = new OleDbCommand("select sum(iade_tutari) as toplam from kasa_pesinat_iade where tarih=@p1 and kullanici_kodu=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod.ToString());
            txt_pesinat_iade.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_pesinat_iade.Text == "")
            {
                txt_pesinat_iade.Text = "0";
            }
        }
        // TOPLAM E-GELECEK
        void e_gelecek()
        {

            OleDbCommand kmt = new OleDbCommand("select sum(gelecek_tutar) as toplam from elden_gelecek_gelen where islem_tarih=@p1 and kullanici_kodu=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod.ToString());
            txt_elden_gelecek.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_elden_gelecek.Text == "")
            {
                txt_elden_gelecek.Text = "0";
            }
        }
        // TOPLAM MASRAF
        void masraf()
        {
            OleDbCommand kmt = new OleDbCommand("select sum(tutar) as toplam from kasa_masraf where tarih=@p1 and kullanici_kodu=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod.ToString());
            txt_masraf.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_masraf.Text == "")
            {
                txt_masraf.Text = "0";
            }
        }
        //KASA İŞLEMLERİ
        decimal taksit, pesin, pesinat, iade, gelecek, masraflar, sonuc;
        void hesapla()
        {
            taksit = Convert.ToDecimal(txt_tahsilat.Text);
            pesin = Convert.ToDecimal(txt_pesin.Text);
            pesinat = Convert.ToDecimal(txt_alinan_pesinat.Text);
            iade = Convert.ToDecimal(txt_pesinat_iade.Text);
            gelecek = Convert.ToDecimal(txt_elden_gelecek.Text);
            masraflar = Convert.ToDecimal(txt_masraf.Text);
            sonuc = taksit + pesin + pesinat - iade - gelecek - masraflar;
            txt_toplam_kasa.Text = sonuc.ToString();

        }

        // BANKA İŞLEMLERİ ***************************//
        // TOPLAM GARANTİ
        void garanti()
        {
            OleDbCommand kmt = new OleDbCommand("select sum(garanti) as toplam from kasa_kredi_kart where tarih=@p1 and kullanici_kod=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod.ToString());
            txt_garanti.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_garanti.Text == "")
            {
                txt_garanti.Text = "0";
            }
        }
        // TOPLAM YAPIKREDİ
        void yapikredi()
        {
            OleDbCommand kmt = new OleDbCommand("select sum(yapikredi) as toplam from kasa_kredi_kart where tarih=@p1 and kullanici_kod=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod.ToString());
            txt_yapikredi.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_yapikredi.Text == "")
            {
                txt_yapikredi.Text = "0";
            }
        }
        // TOPLAM FİNANSBANK
        void finansbank()
        {
            OleDbCommand kmt = new OleDbCommand("select sum(finansbank) as toplam from kasa_kredi_kart where tarih=@p1 and kullanici_kod=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod.ToString());
            txt_finansbank.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_finansbank.Text == "")
            {
                txt_finansbank.Text = "0";
            }
        }
        // TOPLAM İŞBANKASI
        void isbankasi()
        {
            OleDbCommand kmt = new OleDbCommand("select sum(isbankasi) as toplam from kasa_kredi_kart where tarih=@p1 and kullanici_kod=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod.ToString());
            txt_is_bankasi.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_is_bankasi.Text == "")
            {
                txt_is_bankasi.Text = "0";
            }
        }
        // TOPLAM HALKBANK
        void halkbank()
        {
            OleDbCommand kmt = new OleDbCommand("select sum(halkbank) as toplam from kasa_kredi_kart where tarih=@p1 and kullanici_kod=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod.ToString());
            txt_halkbank.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_halkbank.Text == "")
            {
                txt_halkbank.Text = "0";
            }
        }
        // TOPLAM AKBANK
        void akbank()
        {
            OleDbCommand kmt = new OleDbCommand("select sum(akbank) as toplam from kasa_kredi_kart where tarih=@p1 and kullanici_kod=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod.ToString());
            txt_akbank.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_akbank.Text == "")
            {
                txt_akbank.Text = "0";
            }
        }
        //MANUEL ÇIKIŞ
        private void btn_manuel_Click(object sender, EventArgs e)
        {
            txt_tahsilat.Text = "0";
            txt_pesin.Text = "0";
            txt_alinan_pesinat.Text = "0";
            txt_pesinat_iade.Text = "0";
            txt_elden_gelecek.Text = "0";
            txt_masraf.Text = "0";
            txt_toplam_kasa.Text = "0";
            txt_toplam_kasa.Enabled = true;
            txt_toplam_kasa.Focus();
        }
        //KAYDET BUTONU
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // AYNI VERİ ENGELLEME
        bool durum;
        public void control()
        {
            OleDbCommand kmt = new OleDbCommand("select * from kasa_cikis where tarih=@p1 and kullanici_kodu=@p2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", kasa_cikis_kullanici_kod);
            OleDbDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                durum = true;
            }
            else
            {
                durum = false;
            }



        }
        // VERİLERİ KAYDETME      
        public void kaydet()
        {
            control();
            if (durum == false)
            {
                OleDbTransaction islem = null;
                islem = bgl.baglanti().BeginTransaction();


                OleDbCommand kmt = new OleDbCommand("insert into kasa_cikis (kullanici_adi,toplam_kasa,aciklama,tarih,tahsilat,pesin,pesinat,pesinat_iade,e_gelecek,masraf,garanti,yapikredi,finansbank,isbankasi,halkbank,akbank,kullanici_kodu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", kasa_cikis_kullanici_adi.ToString());
                kmt.Parameters.AddWithValue("@p2", txt_toplam_kasa.Text);
                kmt.Parameters.AddWithValue("@p3", memo_aciklama.Text);
                kmt.Parameters.AddWithValue("@p4", date_tarih.Text);
                kmt.Parameters.AddWithValue("@p5", txt_tahsilat.Text);
                kmt.Parameters.AddWithValue("@p6", txt_pesin.Text);
                kmt.Parameters.AddWithValue("@p7", txt_alinan_pesinat.Text);
                kmt.Parameters.AddWithValue("@p8", txt_pesinat_iade.Text);
                kmt.Parameters.AddWithValue("@p9", txt_elden_gelecek.Text);
                kmt.Parameters.AddWithValue("@p10", txt_masraf.Text);
                kmt.Parameters.AddWithValue("@p11", txt_garanti.Text);
                kmt.Parameters.AddWithValue("@p12", txt_yapikredi.Text);
                kmt.Parameters.AddWithValue("@p13", txt_finansbank.Text);
                kmt.Parameters.AddWithValue("@p14", txt_is_bankasi.Text);
                kmt.Parameters.AddWithValue("@p15", txt_halkbank.Text);
                kmt.Parameters.AddWithValue("@p16", txt_akbank.Text);
                kmt.Parameters.AddWithValue("@p17", kasa_cikis_kullanici_kod.ToString());



                try
                {
                    kmt.ExecuteNonQuery();
                    islem.Commit();
                    XtraMessageBox.Show("KASA ÇIKIŞ İŞLEMİNİZ YAPILMIŞTIR.", "BAŞARILI", MessageBoxButtons.OK);

                }
                catch
                {
                    islem.Rollback();

                    XtraMessageBox.Show("KASA ÇIKIŞ İŞLEMİNİZ YAPILAMAMIŞTIR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bgl.baglanti().Close();

                }

            }
            else
            {
                MessageBox.Show("KASA ÇIKIŞINIZ DAHA ÖNCE YAPILMIŞTIR LÜTFEN FARKLI TARİH ÇIKIŞ YAPINIZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void date_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_toplam_kasa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void memo_aciklama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
        //YENİLE
        private void btn_yenile_Click(object sender, EventArgs e)
        {
            tahsilat();
            pesin_islem();
            alinan_pesinat();
            pesinat_iade();
            e_gelecek();
            masraf();
            hesapla();

            garanti();
            yapikredi();
            finansbank();
            isbankasi();
            halkbank();
            akbank();
        }

    }
}