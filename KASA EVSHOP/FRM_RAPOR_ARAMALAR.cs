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
    public partial class FRM_RAPOR_ARAMALAR : DevExpress.XtraEditors.XtraForm
    {
        public FRM_RAPOR_ARAMALAR()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        int durum = 0;
        private void FRM_RAPOR_ARAMALAR_Load(object sender, EventArgs e)
        {
            DateTime aybasi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime aysonu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            date_baslangic.Text = aybasi.ToShortDateString();
            date_bitis.Text = aysonu.ToShortDateString();

            listele_arama();
            listele_dogum_gunu();
            listele_borc_kapama();
        }
        // GRİD DOLDUR ARAMA
        public void listele_arama()
        {
            durum = 1;
            bag.Close();
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select id,musteri_kodu,adi_soyadi,magaza_adi,tutar,telefon,arama_tarih,alisveris_tarih,arayan_kisi from aramalar where durum=@p3 and alisveris_tarih BETWEEN @tar1 and @tar2 Order By alisveris_tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", durum.ToString());
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);

            DataTable dt = new DataTable();
            adt.Fill(dt);

            grid_arama.DataSource = dt;
            bag.Close();

            isim_arama();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;


            gridView1.Columns["tutar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["tutar"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["tutar"].SummaryItem.Tag = 1;
            
        }
        //GRİD KOLON İSİM
        void isim_arama()
        {
            gridView1.Columns[0].Width = 40; // GRİD KOLON BOYUT


            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "MÜŞTERİ KODU";
            gridView1.Columns[2].Caption = "ADI SOYADI";
            gridView1.Columns[3].Caption = "MAĞAZA ADI";
            gridView1.Columns[4].Caption = "TUTAR";
            gridView1.Columns[5].Caption = "TELEFON";
            gridView1.Columns[6].Caption = "ARAMA TARİHİ";
            gridView1.Columns[7].Caption = "ALIŞVERİŞ TARİHİ";
            gridView1.Columns[8].Caption = "ARAYAN";

        }

        // GRİD DOLDUR DOĞUM GÜNÜ
        public void listele_dogum_gunu()
        {
            durum = 2;
            bag.Close();
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select id,musteri_kodu,adi_soyadi,magaza_adi,tutar,telefon,arama_tarih,alisveris_tarih,arayan_kisi from aramalar where durum=@p3 and alisveris_tarih BETWEEN @tar1 and @tar2 Order By alisveris_tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", durum.ToString());
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);

            DataTable dt = new DataTable();
            adt.Fill(dt);

            grid_dogum_gunu.DataSource = dt;
            bag.Close();

            isim_dogum_gunu();

            // TABLO EN SON VERİ SEÇME
            gridView2.FocusedRowHandle = gridView1.RowCount - 1;


            gridView2.Columns["tutar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView2.Columns["tutar"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView2.Columns["tutar"].SummaryItem.Tag = 1;
        }
        //GRİD KOLON İSİM
        void isim_dogum_gunu()
        {

            gridView2.Columns[0].Width = 40; // GRİD KOLON BOYUT

            gridView2.Columns[0].Caption = "ID";
            gridView2.Columns[1].Caption = "MÜŞTERİ KODU";
            gridView2.Columns[2].Caption = "ADI SOYADI";
            gridView2.Columns[3].Caption = "MAĞAZA ADI";
            gridView2.Columns[4].Caption = "TUTAR";
            gridView2.Columns[5].Caption = "TELEFON";
            gridView2.Columns[6].Caption = "ARAMA TARİHİ";
            gridView2.Columns[7].Caption = "ALIŞVERİŞ TARİHİ";
            gridView2.Columns[8].Caption = "ARAYAN";

        }

        // GRİD DOLDUR BORC KAPAMA
        public void listele_borc_kapama()
        {
            durum = 3;
            bag.Close();
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select id,musteri_kodu,adi_soyadi,magaza_adi,tutar,alisveris_tarih,arayan_kisi from aramalar where durum=@p3 and alisveris_tarih BETWEEN @tar1 and @tar2 Order By alisveris_tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", durum.ToString());
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);

            DataTable dt = new DataTable();
            adt.Fill(dt);

            grid_borc_kapama.DataSource = dt;
            bag.Close();

            isim_borc_kapama();

            // TABLO EN SON VERİ SEÇME
            gridView3.FocusedRowHandle = gridView1.RowCount - 1;


            gridView3.Columns["tutar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView3.Columns["tutar"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView3.Columns["tutar"].SummaryItem.Tag = 1;
        }
        //GRİD KOLON İSİM
        void isim_borc_kapama()
        {

            gridView3.Columns[0].Width = 40; // GRİD KOLON BOYUT

            gridView3.Columns[0].Caption = "ID";
            gridView3.Columns[1].Caption = "MÜŞTERİ KODU";
            gridView3.Columns[2].Caption = "ADI SOYADI";
            gridView3.Columns[3].Caption = "MAĞAZA ADI";
            gridView3.Columns[4].Caption = "TUTAR";
            gridView3.Columns[5].Caption = "TARİH";
            gridView3.Columns[6].Caption = "YÖNLENDİREN";

        }
        // FİLTRE BUTONU
        int sayac = 1;
        private void btn_filtre_Click(object sender, EventArgs e)
        {
            if (sayac == 2)
            {
                panel_tarih.Visible = false;

                sayac = 1;
            }
            else
            {
                panel_tarih.Visible = true;
                sayac++;

            }
        }
        //YENİ
        private void btn_yeni_Click(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage==page_arama)
            {
                FRM_RAPOR_ARAMALAR_YENI frm_yeni_arama = new FRM_RAPOR_ARAMALAR_YENI();
                frm_yeni_arama.arama = 1;
                frm_yeni_arama.Show();
            }
            else if (xtraTabControl1.SelectedTabPage == page_dogum_gunu)
            {
                FRM_RAPOR_ARAMALAR_YENI frm_yeni_arama = new FRM_RAPOR_ARAMALAR_YENI();
                frm_yeni_arama.arama = 2;
                frm_yeni_arama.Show();
            }
            else if (xtraTabControl1.SelectedTabPage == page_borc_kapama)
            {
                FRM_RAPOR_ARAMALAR_YENI frm_yeni_arama = new FRM_RAPOR_ARAMALAR_YENI();
                frm_yeni_arama.arama = 3;
                frm_yeni_arama.Show();
            }
        }
        //SİL
        private void btn_sil_Click(object sender, EventArgs e)
        {
            //eğer arama müşteriler seçili ise
            if (xtraTabControl1.SelectedTabPage==page_arama)
            {
                int id;

                // GRİD DEN VERİ ÇEKME

                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                id = int.Parse(dr["id"].ToString());
                //VERİ TABANINDAN SİLME İŞLEMİ

                DialogResult cevap;
                cevap = XtraMessageBox.Show("KAYIDI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bag.Open();
                    OleDbCommand sil = new OleDbCommand("Delete from aramalar where id=" + id + " ", bag);
                    sil.ExecuteNonQuery();
                    bag.Close();
                }
                listele_arama();
            }
                //eğer doğum günün seçili ise
            else if (xtraTabControl1.SelectedTabPage==page_dogum_gunu)
            {
                int id;

                // GRİD DEN VERİ ÇEKME

                  DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                id = int.Parse(dr["id"].ToString());
                //VERİ TABANINDAN SİLME İŞLEMİ

                DialogResult cevap;
                cevap = XtraMessageBox.Show("KAYIDI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bag.Open();
                    OleDbCommand sil = new OleDbCommand("Delete from aramalar where id=" + id + " ", bag);
                    sil.ExecuteNonQuery();
                    bag.Close();
                }
                listele_dogum_gunu();
            }
                //eğer borc kapama secili ise
            else if (xtraTabControl1.SelectedTabPage == page_borc_kapama)
            {
                int id;

                // GRİD DEN VERİ ÇEKME

                DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
                id = int.Parse(dr["id"].ToString());
                //VERİ TABANINDAN SİLME İŞLEMİ

                DialogResult cevap;
                cevap = XtraMessageBox.Show("KAYIDI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bag.Open();
                    OleDbCommand sil = new OleDbCommand("Delete from aramalar where id=" + id + " ", bag);
                    sil.ExecuteNonQuery();
                    bag.Close();
                }
                listele_borc_kapama();
            }
               
            
           
        }
        //GÜNCELLE
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage==page_arama)
            {
                // GUNCELLE FORMUNA ID GÖNDERME

                FRM_RAPOR_ARAMA_GUNCELLE frm_arama_guncelle = new FRM_RAPOR_ARAMA_GUNCELLE();

                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                if (dr != null)
                {
                    frm_arama_guncelle.musteri_id = int.Parse(dr["id"].ToString());
                    frm_arama_guncelle.arama_guncel = 1;

                }

                frm_arama_guncelle.Show();
            }
            else  if (xtraTabControl1.SelectedTabPage == page_dogum_gunu)
            {
                // GUNCELLE FORMUNA ID GÖNDERME

                FRM_RAPOR_ARAMA_GUNCELLE frm_arama_guncelle = new FRM_RAPOR_ARAMA_GUNCELLE();

                DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                if (dr != null)
                {
                    frm_arama_guncelle.musteri_id = int.Parse(dr["id"].ToString());
                    frm_arama_guncelle.arama_guncel = 2;

                }

                frm_arama_guncelle.Show();
            }
            else if (xtraTabControl1.SelectedTabPage == page_borc_kapama)
            {
                // GUNCELLE FORMUNA ID GÖNDERME

                FRM_RAPOR_ARAMA_GUNCELLE frm_arama_guncelle = new FRM_RAPOR_ARAMA_GUNCELLE();

                DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);

                if (dr != null)
                {
                    frm_arama_guncelle.musteri_id = int.Parse(dr["id"].ToString());
                    frm_arama_guncelle.arama_guncel = 3;

                }

                frm_arama_guncelle.Show();
            }
           
        }
        //ARA BUTONU
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == page_arama)
            {


                if (sayac == 2)
                {
                    gridView1.OptionsView.ShowAutoFilterRow = false;

                    sayac = 1;
                }
                else
                {
                    gridView1.OptionsView.ShowAutoFilterRow = true;
                    sayac++;

                }
            }
           else  if (xtraTabControl1.SelectedTabPage == page_dogum_gunu)
            {


                if (sayac == 2)
                {
                    gridView2.OptionsView.ShowAutoFilterRow = false;

                    sayac = 1;
                }
                else
                {
                    gridView2.OptionsView.ShowAutoFilterRow = true;
                    sayac++;

                }
            }
           else  if (xtraTabControl1.SelectedTabPage == page_borc_kapama)
            {


                if (sayac == 2)
                {
                    gridView3.OptionsView.ShowAutoFilterRow = false;

                    sayac = 1;
                }
                else
                {
                    gridView3.OptionsView.ShowAutoFilterRow = true;
                    sayac++;

                }
            }
        }
        //GÖSTER
        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_arama();
            listele_dogum_gunu();
            listele_borc_kapama();
        }

        private void date_baslangic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listele_arama();
                listele_dogum_gunu();
                listele_borc_kapama();
            }
        }

        private void date_bitis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listele_arama();
                listele_dogum_gunu();
                listele_borc_kapama();
            }
        }
        //EXCEL
        private void btn_excel_Click(object sender, EventArgs e)
        {
            FRM_RAPOR_ARAMALAR_EXCEL frm_excel = new FRM_RAPOR_ARAMALAR_EXCEL();
            frm_excel.Show();
        }
       
    }
}