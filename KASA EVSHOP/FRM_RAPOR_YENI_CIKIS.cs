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
    public partial class FRM_RAPOR_YENI_CIKIS : DevExpress.XtraEditors.XtraForm
    {
        public FRM_RAPOR_YENI_CIKIS()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();
        public string kullanici_adi;
        private void FRM_RAPOR_YENI_CIKIS_Load(object sender, EventArgs e)
        {
            date_tarih.Text = DateTime.Now.ToShortDateString();
            txt_tahsilat.Focus();
            kullanici_kodu();
        }
        // KULLANICI KODU VERI TABANINDAN ÇEKME
        public void kullanici_kodu()
        {
            bar_kullanici.Caption = kullanici_adi.ToString();

            OleDbCommand kmt = new OleDbCommand("Select * from kullanici_giris where kullanici_adi=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", Convert.ToString(kullanici_adi.ToString()));
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                bar_kod.Caption = oku["kullanici_kodu"].ToString();


            }

        }

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
            kmt.Parameters.AddWithValue("@p2", bar_kod.Caption.ToString());
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
                kmt.Parameters.AddWithValue("@p1", bar_kullanici.Caption.ToString());
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
                kmt.Parameters.AddWithValue("@p17", bar_kod.Caption.ToString());



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

            // PERSONEL FORMUNDAKİ GRİD YENİLEME
             
            FRM_KASA_RAPOR frm_rapor = (FRM_KASA_RAPOR)Application.OpenForms["FRM_KASA_RAPOR"];
            frm_rapor.listele_kasa();
            frm_rapor.hesapla();


            //FORM KAPAT
            this.Hide();


        }

        private void txt_toplam_kasa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            hesapla();
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
    }
}