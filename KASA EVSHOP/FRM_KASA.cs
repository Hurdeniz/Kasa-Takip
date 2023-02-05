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
    public partial class FRM_KASA : DevExpress.XtraEditors.XtraForm
    {
        public FRM_KASA()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int kasa_kullanici_kod;
        //FORM LOAD
        private void FRM_KASA_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(btn_yenile, "YENİLE");


            timer1.Start();

            tahsilat();
            pesin_islem();
            alinan_pesinat();
            pesinat_iade();
            e_gelecek();
            masraf();
            hesapla();
        }
        //TİMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            date_tarih.Text = DateTime.Now.ToShortDateString();
        }
        // TOPLAM TAHSİLAT
        void tahsilat()
        {
            DateTime tarih;
            tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            OleDbCommand kmt = new OleDbCommand("select sum(tahsilat_tutari) as toplam from kasa_taksit where tarih=@p1 and kullanici_kodu=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", tarih.ToString());
            kmt.Parameters.AddWithValue("@p2", kasa_kullanici_kod.ToString());
            txt_tahsilat.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_tahsilat.Text=="")
            {
                txt_tahsilat.Text = "0";
            }
        }
        // TOPLAM PEŞİN İŞLEM
        void pesin_islem()
        {
              DateTime tarih;
              tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            OleDbCommand kmt = new OleDbCommand("select sum(tutar) as toplam from kasa_pesin where tarih=@p1 and kullanici_kodu=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", tarih.ToString());
            kmt.Parameters.AddWithValue("@p2", kasa_kullanici_kod.ToString());
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
            DateTime tarih;
            tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            OleDbCommand kmt = new OleDbCommand("select sum(tutar) as toplam from kasa_pesinat_al where tarih=@p1 and kullanici_kodu=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", tarih.ToString());
            kmt.Parameters.AddWithValue("@p2", kasa_kullanici_kod.ToString());
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
            DateTime tarih;
            tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            OleDbCommand kmt = new OleDbCommand("select sum(iade_tutari) as toplam from kasa_pesinat_iade where tarih=@p1 and kullanici_kodu=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", tarih.ToString());
            kmt.Parameters.AddWithValue("@p2", kasa_kullanici_kod.ToString());
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
            DateTime tarih;
            tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            OleDbCommand kmt = new OleDbCommand("select sum(gelecek_tutar) as toplam from elden_gelecek_gelen where islem_tarih=@p1 and kullanici_kodu=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", tarih.ToString());
            kmt.Parameters.AddWithValue("@p2", kasa_kullanici_kod.ToString());
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
            DateTime tarih;
            tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            OleDbCommand kmt = new OleDbCommand("select sum(tutar) as toplam from kasa_masraf where tarih=@p1 and kullanici_kodu=@p2 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", tarih.ToString());
            kmt.Parameters.AddWithValue("@p2", kasa_kullanici_kod.ToString());
            txt_masraf.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            if (txt_masraf.Text == "")
            {
                txt_masraf.Text = "0";
            }
        }
        //YENİLE BUTONU
        private void btn_yenile_Click(object sender, EventArgs e)
        {
            tahsilat();
            pesin_islem();
            alinan_pesinat();
            pesinat_iade();
            e_gelecek();
            masraf();
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
            txt_kasa.Text = sonuc.ToString() + "₺";
    
        }

    }
}