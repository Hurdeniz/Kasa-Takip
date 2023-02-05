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
    public partial class FRM_MAIN : DevExpress.XtraEditors.XtraForm
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public string kullanici_adi;
        public int yetki;
        FRM_ANA_SAYFA frm_ana_sayfa;
        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

           timer1.Start();
            //YÖNETİCİ
           if (yetki == 1)
           {
               kullanici_kodu();
               page_kasa.Visible = true;
               page_detay.Visible = true;
               page_sevkiyat.Visible = true;
               page_rapor.Visible = true;
               page_elden_gelecekler.Visible = true;
               page_banka.Visible = true;
               page_odemeler.Visible = true;
               page_sifre.Visible = true;
               page_personel.Visible = true;
               bar_btn_personel_ekle.Enabled = true;
              

           }
               //KASİYER
           else if (yetki == 2)
           {
               kullanici_kodu();
               page_kasa.Visible = true;
               page_detay.Visible = true;
               page_sevkiyat.Visible = true;
               page_sifre.Visible = true;
               page_personel.Visible = true;

           }
               //DEPOCU
           else if (yetki == 3)
           {
               kullanici_kodu();
               page_sevkiyat.Visible = true;
               page_sifre.Visible = true;
           }
               //MAGAZA  MÜDÜR
           else if (yetki == 4)
           {
               kullanici_kodu();
               page_personel.Visible = true;
               bar_btn_personel_ekle.Enabled = true;
               page_sifre.Visible = true;
           }
         
           else
           {
               MessageBox.Show("yetki yok");
           }
           if (frm_ana_sayfa == null)
           {
               frm_ana_sayfa = new FRM_ANA_SAYFA();
               frm_ana_sayfa.MdiParent = this;
               frm_ana_sayfa.not_kod = Convert.ToInt32(bar_kod.Caption.ToString());
               frm_ana_sayfa.Show();
           }

            
        }
        // TARİH - SAAT 
        private void timer1_Tick(object sender, EventArgs e)
        {
            date_tarih.EditValue = DateTime.Now.ToShortDateString();
            date_saat.EditValue = DateTime.Now.ToShortTimeString();
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
        // TAKSİT ÖDEME FORM
        FRM_TAKSIT frm_taksit;
        private void bar_btn_taksit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_taksit == null || frm_taksit.IsDisposed)
            {
                frm_taksit = new FRM_TAKSIT();
                frm_taksit.MdiParent = this;
                frm_taksit.kod = Convert.ToInt32(bar_kod.Caption.ToString());
                frm_taksit.Show();
            }

        }
        // PEŞİN İŞLEM FORM
        FRM_PESIN frm_pesin;
        private void bar_btn_pesin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_pesin == null || frm_pesin.IsDisposed)
            {
                frm_pesin = new FRM_PESIN();
                frm_pesin.MdiParent = this;
                frm_pesin.pesin_kod = Convert.ToInt32(bar_kod.Caption.ToString());
                frm_pesin.Show();
            }

        }
        // KREDİ KART FORM
        FRM_KART frm_kart;
        private void bar_btn_kart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_kart == null || frm_kart.IsDisposed)
            {
                frm_kart = new FRM_KART();
                frm_kart.MdiParent = this;
                frm_kart.kart_kullanici_kod = Convert.ToInt32(bar_kod.Caption.ToString());
                frm_kart.Show();
            }
        }
        //PEŞİNAT ÖDEME FORM
        FRM_PESINAT_AL frm_pesinat_al;
        private void bar_btn_pesinat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_pesinat_al == null || frm_pesinat_al.IsDisposed)
            {
                frm_pesinat_al = new FRM_PESINAT_AL();
                frm_pesinat_al.MdiParent = this;
                frm_pesinat_al.pesinat_kullanici_kod = Convert.ToInt32(bar_kod.Caption.ToString());
                frm_pesinat_al.Show();
            }
        }
        //PEŞİNAT İADE FORM
        FRM_PESINAT_IADE frm_pesinat_iade;
        private void bar_btn_pesinat_iade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_pesinat_iade == null || frm_pesinat_iade.IsDisposed)
            {
                frm_pesinat_iade = new FRM_PESINAT_IADE();
                frm_pesinat_iade.MdiParent = this;
                frm_pesinat_iade.pesinat_iade_kullanici_kod = Convert.ToInt32(bar_kod.Caption.ToString());
                frm_pesinat_iade.Show();
            }
        }
        //ELDEN GELECEK FORMU
        FRM_ELDEN_GELECEK frm_e_gelecek;
        private void bar_btn_e_gelecek_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_e_gelecek == null || frm_e_gelecek.IsDisposed)
            {
                frm_e_gelecek = new FRM_ELDEN_GELECEK();
                frm_e_gelecek.MdiParent = this;
                frm_e_gelecek.e_gelecek_kullanici_kod = Convert.ToInt32(bar_kod.Caption.ToString());
                frm_e_gelecek.e_gelecek_kullanici_adi = Convert.ToString(bar_kullanici.Caption.ToString());
                frm_e_gelecek.Show();
            }
        }
        //MASRAF FORMU
        FRM_MASRAF frm_masraf;
        private void bar_btn_masraf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_masraf == null || frm_masraf.IsDisposed)
            {
                frm_masraf = new FRM_MASRAF();
                frm_masraf.MdiParent = this;
                frm_masraf.masraf_kullanici_kod = Convert.ToInt32(bar_kod.Caption.ToString());            
                frm_masraf.Show();
            }
        }
        //KASA TOPLAMA FORMU
        FRM_KASA_TOPLA frm_kasa_topla;
        private void bar_btn_kasa_topla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm_kasa_topla == null || frm_kasa_topla.IsDisposed)
            {
                frm_kasa_topla = new FRM_KASA_TOPLA();
                frm_kasa_topla.MdiParent = this;           
                frm_kasa_topla.Show();
            }
        }
        //KASA FORMU
        FRM_KASA frm_kasa;
        private void bar_btn_kasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_kasa == null || frm_kasa.IsDisposed)
            {
                frm_kasa = new FRM_KASA();
                frm_kasa.kasa_kullanici_kod= Convert.ToInt32(bar_kod.Caption.ToString());   
                frm_kasa.MdiParent = this;
                frm_kasa.Show();
            }
        }
        //KASA ÇIKIŞ FORMU
        private void bar_btn_kasa_cikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_KASA_CIKIS frm_kasa_cikis = new FRM_KASA_CIKIS();
            frm_kasa_cikis.kasa_cikis_kullanici_kod = Convert.ToInt32(bar_kod.Caption.ToString());
            frm_kasa_cikis.kasa_cikis_kullanici_adi = Convert.ToString(bar_kullanici.Caption.ToString());
            frm_kasa_cikis.Show();
        }

        //**********PAGE DETAYLAR *****************//

        //TAKSİT DETAY FORMU      
        private void bar_dty_btn_taksitler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                FRM_DETAY_TAKSIT frm_dty_taksit = new FRM_DETAY_TAKSIT();       
                frm_dty_taksit.taksit_dty_kod = Convert.ToInt32(bar_kod.Caption.ToString());
                frm_dty_taksit.Show();
            
        }
        // PEŞİN İŞLEMLER FORMU
        private void bar_dty_btn_pesinler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_DETAY_PESIN frm_dty_pesin = new FRM_DETAY_PESIN();
            frm_dty_pesin.pesin_dty_kod = Convert.ToInt32(bar_kod.Caption.ToString());
            frm_dty_pesin.Show();
        }
        //KREDİ KART İŞLEMLER FORMU
        private void bar_dty_btn_kart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_DETAY_KART frm_dty_kart = new FRM_DETAY_KART();
            frm_dty_kart.kart_dty_kod = Convert.ToInt32(bar_kod.Caption.ToString());
            frm_dty_kart.Show();
        }
        //PEŞİNAT AL İŞLEMLERİ FORMU
        private void bar_dty_btn_pesinat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_DETAY_PESINAT frm_dty_pesinat = new FRM_DETAY_PESINAT();
            frm_dty_pesinat.pesinat_dty_kod = Convert.ToInt32(bar_kod.Caption.ToString());
            frm_dty_pesinat.Show();
        }
        //PEŞİNAT İADE İŞLEMLERİ FORMU
        private void bar_dty_btn_pesinat_iade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_DETAY_PESINAT_IADE frm_dty_pesinat_iade = new FRM_DETAY_PESINAT_IADE();
            frm_dty_pesinat_iade.pesinat_iade_dty_kod = Convert.ToInt32(bar_kod.Caption.ToString());
            frm_dty_pesinat_iade.Show();
        }
        // MASRAF FORMU
        private void bar_dty_btn_masraflar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_DETAY_MASRAF frm_masraf = new FRM_DETAY_MASRAF();
            frm_masraf.masraf_dty_kod = Convert.ToInt32(bar_kod.Caption.ToString());
            frm_masraf.Show();
        }
        //E-GELECEK FORMU 
        FRM_DETAY_E_GELECEK frm_dty_e_gelecek;
        private void bar_dty_btn_e_gelecek_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_dty_e_gelecek == null || frm_dty_e_gelecek.IsDisposed)
            {
                frm_dty_e_gelecek = new FRM_DETAY_E_GELECEK();
                frm_dty_e_gelecek.e_gelecek_dty_kod = Convert.ToInt32(bar_kod.Caption.ToString());
                frm_dty_e_gelecek.MdiParent = this;
                frm_dty_e_gelecek.Show();
            }
        }
        // SEVKİYAT OLUŞTUR
        FRM_SEVKIYAT_OLUSTUR frm_sevkiyat;
        private void bar_btn_sevkiyat_olustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_sevkiyat == null || frm_sevkiyat.IsDisposed)
            {
                frm_sevkiyat = new FRM_SEVKIYAT_OLUSTUR();             
                frm_sevkiyat.MdiParent = this;
                frm_sevkiyat.Show();
            }
            
        }
        // SEVKİYAT GÜNCELLE
        private void bar_btn_sevkiyat_guncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_SEVKIYAT_GUNCELLE frm_sevkiyat_guncelle = new FRM_SEVKIYAT_GUNCELLE();
            frm_sevkiyat_guncelle.Show();
        }
        //SEVKİYAT LİSTESİ
        private void bar_btn_sevkiyat_listesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_SEVKIYAT_LISTESI frm_sevkiyat_listesi = new FRM_SEVKIYAT_LISTESI();
            frm_sevkiyat_listesi.Show();
        }
        // MEMNUNIYET
        private void bar_btn_memnuniyet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_MEMNUNIYET frm_memnuniyet = new FRM_MEMNUNIYET();
            frm_memnuniyet.Show();
        }
        //SEVKİYAT EXCEL
        private void bar_btn_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_SEVKIYAT_LISTESI_EXCEL frm_excel = new FRM_SEVKIYAT_LISTESI_EXCEL();
            frm_excel.Show();
        }

        //GÜNLÜK KASA
        private void bar_btn_gunluk_kasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_KASA_RAPOR frm_kasa_rapor = new FRM_KASA_RAPOR();
            frm_kasa_rapor.Show();
        }
        // KASA DETAY GÜNLÜK
        private void bar_btn_kasa_detay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_RAPOR_KASA_DETAY frm_rapor_kasa_detay = new FRM_RAPOR_KASA_DETAY();
            frm_rapor_kasa_detay.Show();
        }
        // PARA YATIRMA
        FRM_PARA_YATIRMA frm_para_yatirma;
        private void bar_btn_para_yatirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_para_yatirma == null || frm_para_yatirma.IsDisposed)
            {
                frm_para_yatirma = new FRM_PARA_YATIRMA(); 
                frm_para_yatirma.MdiParent = this;
                frm_para_yatirma.Show();
            }
        }
        //PARA YATIRMA DETAY
        private void bar_btn_detay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_DETAY_PARA_YATIRMA frm_para_yatirma_detay = new FRM_DETAY_PARA_YATIRMA();
            frm_para_yatirma_detay.Show();
        }
        //ELDEN GELECEK ÖDEMELER
        private void bar_btn_gelecek_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FRM_DETAY_ELDEN_GELECEK frm_dty_elden_gelecek = new FRM_DETAY_ELDEN_GELECEK();
            frm_dty_elden_gelecek.Show();
        }
        //ELDEN GELEN ÖDEMELER
        private void bar_btn_gelen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_DETAY_ELDEN_GELEN frm_dty_elden_gelen = new FRM_DETAY_ELDEN_GELEN();
            frm_dty_elden_gelen.Show();
        }
        //MERKEZ ÖDEMESİ
        FRM_MERKEZ_ODEME frm_merkez_odeme;
        private void bar_btn_merkez_odeme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_merkez_odeme == null || frm_merkez_odeme.IsDisposed)
            {
                frm_merkez_odeme = new FRM_MERKEZ_ODEME();
                frm_merkez_odeme.MdiParent = this;
                frm_merkez_odeme.Show();
            }
        }
        //FİRMA ÖDEMESİ
        FRM_FIRMA_ODEMESI frm_firma_odeme;
        private void bar_btn_firma_odeme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_firma_odeme == null || frm_firma_odeme.IsDisposed)
            {
                frm_firma_odeme = new FRM_FIRMA_ODEMESI();
                frm_firma_odeme.MdiParent = this;
                frm_firma_odeme.Show();
            }

        }
        //MERKEZ ÖDEMESİ DETAY
        private void bar_btn_merkez_detay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_DETAY_MERKEZ_ODEME frm_dty_merkez_odeme = new FRM_DETAY_MERKEZ_ODEME();
            frm_dty_merkez_odeme.Show();
        }
        //FİRMA ÖDEMESİ DETAY
        private void bar_btn_firma_detay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_DETAY_FIRMA_ODEME frm_dty_firma_odeme = new FRM_DETAY_FIRMA_ODEME();
            frm_dty_firma_odeme.Show();
        }
        //KASA ÇIKIŞ DETAY
        private void bar_btn_cikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_DETAY_KASA_CIKIS frm_dty_kasa_cikis = new FRM_DETAY_KASA_CIKIS();
            frm_dty_kasa_cikis.dty_cikis_kod = Convert.ToInt32(bar_kod.Caption.ToString());
            frm_dty_kasa_cikis.Show();
        }
        
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
       
        private void bar_btn_yenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        // ŞİFRE DEĞİŞTİR
        private void bar_btn_sifre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_SIFRE_DEGISTIR frm_sifre = new FRM_SIFRE_DEGISTIR();
            frm_sifre.kullanici_kod_sifre = int.Parse(bar_kod.Caption.ToString());
            frm_sifre.Show();
        }

        private void FRM_MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz ? ", "KASA EVSHOP V1.0 ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
               
            }
           
          
        }

        private void FRM_MAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // PERSONEL
        private void bar_btn_personel_ekle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_PERSONELLER frm_personel = new FRM_PERSONELLER();
            frm_personel.Show();
        }
        //PERSONEL SHİFT
        private void bar_btn_personel_shift_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_PERSONEL_SHIFT frm_shift = new FRM_PERSONEL_SHIFT();
            frm_shift.Show();
        }
        // PERSONEL TAKİP
        private void rapor_bar_btn_personel_takip_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_PERSONEL_TAKIP frm_takip = new FRM_PERSONEL_TAKIP();
            frm_takip.Show();
        }
        //GENEL KASA
        private void rapor_bar_btn_genel_kasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_RAPOR_GENEL_KASA frm_genel_kasa = new FRM_RAPOR_GENEL_KASA();
            frm_genel_kasa.Show();
        }
        // RAPOR ÇIKIŞLAR
        private void rapor_bar_btn_cikislar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_RAPOR_CIKISLAR frm_rapor_cikis = new FRM_RAPOR_CIKISLAR();
            frm_rapor_cikis.Show();
        }
        //ANA SAYFA
        private void bar_ana_sayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_ana_sayfa == null || frm_ana_sayfa.IsDisposed)
            {
                frm_ana_sayfa = new FRM_ANA_SAYFA();
                frm_ana_sayfa.MdiParent = this;
                frm_ana_sayfa.not_kod = Convert.ToInt32(bar_kod.Caption.ToString());
                frm_ana_sayfa.Show();
            }
        }
        //RAPOR ARAMALAR
        private void bar_btn_arama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_RAPOR_ARAMALAR frm_arama = new FRM_RAPOR_ARAMALAR();
            frm_arama.Show();
        }
        // RAPOR AÇIKLAR
        private void bar_btn_aciklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FRM_KASA_ACIKLAR frm_aciklar = new FRM_KASA_ACIKLAR();
            frm_aciklar.Show();
            
        }
    }
}